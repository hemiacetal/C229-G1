using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C229_G1.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace C229_G1.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private UserManager<UserModel> userManager;
        private SignInManager<UserModel> signInManager;
        private RoleManager<IdentityRole> roleManager;

        public AccountController(UserManager<UserModel> userMgr,
        SignInManager<UserModel> signInMgr,
        RoleManager<IdentityRole> roleMgr)
        {
            userManager = userMgr;
            signInManager = signInMgr;
            roleManager = roleMgr;

            roleManager.CreateAsync(new IdentityRole("Admin"));
            roleManager.CreateAsync(new IdentityRole("General"));
        }

        [AllowAnonymous]
        public ViewResult Login(string returnUrl)
        {
            return View(new LoginModel
            {
                ReturnUrl = returnUrl
            });
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                UserModel user =
                await userManager.FindByNameAsync(loginModel.UserName);
                if (user != null)
                {
                    await signInManager.SignOutAsync();
                    if ((await signInManager.PasswordSignInAsync(user,
                    loginModel.Password, false, false)).Succeeded)
                    {
                        TempData["message"] = "Welcome, " + user.UserName;
                        return Redirect(loginModel?.ReturnUrl ?? "/Home/Index");
                    }
                    else
                    {
                        ModelState.AddModelError("UserName", "Username/Password Combination not in Database.");
                    }
                }
                else
                {
                    ModelState.AddModelError("UserName", "Username/Password Combination not in Database.");
                }
            }
            return View(loginModel);
        }

        [AllowAnonymous]
        public ViewResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegistrationModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new UserModel { FirstName = model.FirstName, LastName = model.LastName, Email = model.Email, UserName = model.UserName };
                var result = await userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "General");
                    TempData["message"] = $"Thank you for registering, {model.UserName}. Please enter your credentials to log in.";
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    AddErrorsFromResult(result);
                }
            }
            
            if (ModelState.IsValid)
                ModelState.AddModelError("", "Username Already In Use.");

            return View(model);
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            TempData["message"] = "You have successfully been logged out.";
            return RedirectToAction("Index", "Home");
        }

        [Authorize(Roles = "Admin")]
        public async Task<ViewResult> Users() {
            var users = await userManager.Users.ToListAsync();
            return View(users);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            UserModel user = await userManager.FindByIdAsync(id);
            if (user != null)
            {
                IdentityResult result = await userManager.DeleteAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("Users","Account");
                }
                else
                {
                    AddErrorsFromResult(result);
                }
            }
            else
            {
                ModelState.AddModelError("", "User Not Found");
            }
            return View("Index", userManager.Users);
        }

        [AllowAnonymous]
        private void AddErrorsFromResult(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
        }
    }
}