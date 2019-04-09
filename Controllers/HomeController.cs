using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C229_G1.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace C229_G1.Controllers
{
    public class HomeController : Controller
    {
        private IClubRepository repositoryClub;
        private IPlayerRepository repositoryPlayer;
        private ILogRepository repositoryLog;

        public HomeController(IClubRepository repo, IPlayerRepository repo2, ILogRepository repo3)
        {
            repositoryClub = repo;
            repositoryPlayer = repo2;
            repositoryLog = repo3;
        }
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult ClubPage()
        {
            return View(repositoryClub.Clubs);
        }


        public ViewResult ClubDetailsPage(string name)
        {
            Club club = repositoryClub.Clubs.FirstOrDefault(c => c.ClubFullName == name);
            return View(club);
        }


        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ViewResult AddClubPage()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ViewResult AddClubPage(Club club)
        {

            if (ModelState.IsValid)
            {
                repositoryClub.Save(club);
                repositoryLog.Save(MakeLog($"Added Club \"{club.ClubFullName}\""));
                return View("ClubPage", repositoryClub.Clubs);
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        [Authorize]
        public ViewResult ManagePlayersPage()
        {

            ViewBag.ClubList = repositoryClub.Clubs; 
            return View();

        }

        
        [HttpPost]
        [Authorize]
        public ViewResult ManagePlayersPage(Player player)
        {
            if (ModelState.IsValid)
            {
                repositoryPlayer.Save(player);
                repositoryLog.Save(MakeLog($"Added Player \"{player.PlayerName}\" to Club \"{player.ClubFullName}\""));
                return View("ClubPage", repositoryClub.Clubs);
            }
            else
            {
                ViewBag.ClubList = repositoryClub.Clubs;
                return View(player);
            }
        }

        [Authorize(Roles = "Admin")]
        public ViewResult EditClub(string name) => View(repositoryClub.Clubs.FirstOrDefault
            (c => c.ClubFullName == name));


        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult EditClub(Club club)
        {
            if (ModelState.IsValid)
            {
                repositoryClub.Save(club);
                repositoryLog.Save(MakeLog($"Modified Club \"{club.ClubFullName}\""));
                TempData["message"] = $"{club.ClubFullName} has been successfully modified";
                return RedirectToAction("ClubPage", repositoryClub.Clubs);
            }
            else
            {
               
                return View(club);
            }
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult DeleteClub(string name)
        {
            Club deletedClub = repositoryClub.DeleteClub(name);
            if (deletedClub != null)
            {
                repositoryLog.Save(MakeLog($"Deleted Club \"{name}\""));
                TempData["message"] = $"{deletedClub.ClubFullName} was successfully removed from the system";
            }
            return RedirectToAction("ClubPage", repositoryClub.Clubs);
        }


        [Authorize]
        public ViewResult EditPlayer(string name) => View(repositoryPlayer.Players.FirstOrDefault
        (p => p.PlayerName == name));


        [HttpPost]
        [Authorize]
        public IActionResult EditPlayer(Player player)
        {
            if (ModelState.IsValid)
            {
                repositoryPlayer.Save(player);
                TempData["message"] = $"{player.PlayerName} has been successfully modified";
                return RedirectToAction("ClubPage", repositoryClub.Clubs);
            }
            else
            {

                return View(player);
            }
        }

        [HttpPost]
        [Authorize]
        public IActionResult DeletePlayer(string name)
        {
            Player deletedPlayer = repositoryPlayer.DeletePlayer(name);
            if (deletedPlayer != null)
            {

                TempData["message"] = $"{deletedPlayer.PlayerName} was successfully removed from the system";
            }
            return RedirectToAction("ClubPage", repositoryClub.Clubs);
        }

        [Authorize(Roles = "Admin")]
        public ViewResult LogPage() => View(repositoryLog.Logs);

        private Log MakeLog(string performed)
        {
            Log log = new Log
            {
                user = HttpContext.User.Identity.Name,
                datetime = DateTime.Now,
                action = performed
            };

            return log;
        }

    }
}

