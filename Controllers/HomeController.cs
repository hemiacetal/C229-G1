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

        public ViewResult ClubDetailsPage(int clubID)
        {
            Club club = repositoryClub.Clubs.FirstOrDefault(c => c.ClubID == clubID);
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
                repositoryLog.Save(MakeLog($"Created Club \"{club.ClubFullName}\" with ClubID \"" + club.ClubID + "\""));
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
            try
            {
                repositoryClub.Clubs.First(c => c.ClubID == player.ClubID).Equals(0);
            }
            catch
            {
                
                ModelState.AddModelError("ClubID", $"The selected club does not exist in the system."); 
            }
            if (ModelState.IsValid)
            {
                repositoryPlayer.Save(player);
                repositoryLog.Save(MakeLog($"Added Player \"{player.PlayerName}\" to ClubID \"{player.ClubID}\""));
                return View("ClubPage", repositoryClub.Clubs);
            }
            else
            {
                ViewBag.ClubList = repositoryClub.Clubs;
                return View(player);
            }

        }

        [Authorize(Roles = "Admin")]
        public ViewResult EditClub(int clubID) => View(repositoryClub.Clubs.FirstOrDefault
            (c => c.ClubID == clubID));


        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult EditClub(Club club)
        {
            try
            {
                repositoryClub.Clubs.FirstOrDefault(c => c.ClubID == club.ClubID).Equals(null);
            }
            catch
            {

                ModelState.AddModelError("ClubFullName", $"Club {club.ClubFullName} was removed from the system and cannot be edited.");
            }

            if (ModelState.IsValid)
            {
                repositoryClub.Save(club);
                repositoryLog.Save(MakeLog($"Modified Club \"{club.ClubFullName}\" with ClubID \"" + club.ClubID + "\""));
                TempData["message"] = $"Club {club.ClubFullName} has been successfully modified";
                return RedirectToAction("ClubPage", repositoryClub.Clubs);
            }
            else
            {
               
                return View(club);
            }
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult DeleteClub(int clubID)
        {
            Club deletedClub = repositoryClub.DeleteClub(clubID);
            if (deletedClub != null)
            {
                repositoryLog.Save(MakeLog($"Deleted Club \"{deletedClub.ClubFullName}\""));
                repositoryLog.Save(MakeLog($"Deleted Club \"{deletedClub.ClubFullName}\" with ClubID \"" + deletedClub.ClubID + "\""));
                TempData["message"] = $"Club {deletedClub.ClubFullName} was successfully removed from the system";
            }
            return RedirectToAction("ClubPage", repositoryClub.Clubs);
        }


        [Authorize]
        public ViewResult EditPlayer(int playerID) => View(repositoryPlayer.Players.FirstOrDefault
        (p => p.PlayerID == playerID));


        [HttpPost]
        [Authorize]
        public IActionResult EditPlayer(Player player)
        {
            try
            {
                repositoryPlayer.Players.FirstOrDefault(p => p.ClubID == player.ClubID).Equals(null);
            }
            catch
            {
                ModelState.AddModelError("PlayerName", $"Player {player.PlayerName} was removed from the system and cannot be edited.");
            }

            if (ModelState.IsValid)
            {
                repositoryPlayer.Save(player);
                repositoryLog.Save(MakeLog($"Modified Player \"{player.PlayerName}\" of ClubID \"{player.ClubID}\""));
                TempData["message"] = $"Player {player.PlayerName} has been successfully modified";
                return RedirectToAction("ClubPage", repositoryClub.Clubs);
               
            }
            else
            {
                return View(player);
            }
        }

        [HttpPost]
        [Authorize]
        public IActionResult DeletePlayer(int playerID)
        {
            Player deletedPlayer = repositoryPlayer.DeletePlayer(playerID);
            if (deletedPlayer != null)
            {
                repositoryLog.Save(MakeLog($"Deleted Player \"{deletedPlayer.PlayerName}\" from ClubID \"{deletedPlayer.ClubID}\""));
                TempData["message"] = $"Player {deletedPlayer.PlayerName} was successfully removed from the system";
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

