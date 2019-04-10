using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C229_G1.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace C229_G1.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private UserManager<IdentityUser> userManager;
        private SignInManager<IdentityUser> signInManager;
        private RoleManager<IdentityRole> roleManager;

        public AccountController(UserManager<IdentityUser> userMgr,
        SignInManager<IdentityUser> signInMgr,
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
                IdentityUser user =
                await userManager.FindByNameAsync(loginModel.Name);
                if (user != null)
                {
                    await signInManager.SignOutAsync();
                    if ((await signInManager.PasswordSignInAsync(user,
                    loginModel.Password, false, false)).Succeeded)
                    {
                        return Redirect(loginModel?.ReturnUrl ?? "/Home/Index");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Invalid name or password.");
                }
            }
            return View(loginModel);
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            TempData["message"] = "You have successfully been logged out.";
            return RedirectToAction("Index","Home");
        }
    }
}