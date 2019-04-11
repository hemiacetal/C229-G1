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

        public IActionResult ClubDetailsPage(int clubID)
        {
            Club club = repositoryClub.Clubs.FirstOrDefault(c => c.ClubID == clubID);
            if (club == null)
            {
                TempData["message"] = "Club not found.";
                return RedirectToAction("ClubPage");
            }
            else
            {
                return View(club);
            }
            
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
                repositoryLog.Save(MakeLog($"Created Club \"{club.ClubFullName}\" with ClubID {club.ClubID}"));
                TempData["message"] = $"Club {club.ClubFullName} has been successfully added";
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
            Club club = repositoryClub.Clubs.FirstOrDefault(c => c.ClubID == player.ClubID);
            if (club == null)
            {
                ModelState.AddModelError("PlayerName", $"The selected Club does not exist.");
            }
            else
            {
                if (ModelState.IsValid)
                {
                    repositoryPlayer.Save(player);
                    repositoryLog.Save(MakeLog($"Added Player \"{player.PlayerName}\" to Club \"{club.ClubFullName}\" with ClubID {player.ClubID}"));
                    return View("ClubPage", repositoryClub.Clubs);
                }
            }

            ViewBag.ClubList = repositoryClub.Clubs;
            return View(player);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult EditClub(int clubID) {

            Club club = repositoryClub.Clubs.FirstOrDefault(c => c.ClubID == clubID);
            if (club == null)
            {
                TempData["message"] = "Club not found.";
                return RedirectToAction("ClubPage", repositoryClub.Clubs);
            }
            else
            {
                return View("EditClub",club);
            }
            
        } 


        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult EditClub(Club club)
        {
            Club editClub = repositoryClub.Clubs.FirstOrDefault(c => c.ClubID == club.ClubID);
            if (editClub == null)
            {
                ModelState.AddModelError("ClubFullName", $"Club \"{club.ClubFullName}\" was removed from the system and cannot be edited.");
            }
            else
            {
                if (ModelState.IsValid)
                {
                    repositoryClub.Save(club);
                    repositoryLog.Save(MakeLog($"Modified Club \"{club.ClubFullName}\" with ClubID {club.ClubID}"));
                    TempData["message"] = $"Club {club.ClubFullName} has been successfully modified";
                    return RedirectToAction("ClubPage", repositoryClub.Clubs);
                }
            }
            return View(club);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult DeleteClub(int clubID)
        {
            Club deletedClub = repositoryClub.DeleteClub(clubID);
            if (deletedClub == null)
            {
                TempData["message"] = "Club not found.";
            }
            else
            {
                repositoryLog.Save(MakeLog($"Deleted Club \"{deletedClub.ClubFullName}\" with ClubID {deletedClub.ClubID}"));
                TempData["message"] = $"Club {deletedClub.ClubFullName} was successfully removed from the system";
            }
            return RedirectToAction("ClubPage", repositoryClub.Clubs);
        }


        [Authorize]
        public IActionResult EditPlayer(int playerID)
        {
            Player player = repositoryPlayer.Players.FirstOrDefault(p => p.PlayerID == playerID);
            if (player == null)
            {
                TempData["message"] = "Player not found.";
                return RedirectToAction("ClubPage", repositoryClub.Clubs);
            }
            else
            {
                return View(player);
            }
            
        }


        [HttpPost]
        [Authorize]
        public IActionResult EditPlayer(Player player)
        {
            Club club = repositoryClub.Clubs.FirstOrDefault(c => c.ClubID == player.ClubID);
            Player editPlayer = repositoryPlayer.Players.FirstOrDefault(p => p.PlayerID == player.PlayerID);
            if (club == null)
            {
                ModelState.AddModelError("PlayerName", $"The player's club does not exist and so the player cannot be modified.");
            }
            else if (editPlayer == null)
            {
                ModelState.AddModelError("PlayerName", $"The player does not exist and so the player cannot be modified");
            }
            else if (ModelState.IsValid)
            {
                repositoryPlayer.Save(player);
                repositoryLog.Save(MakeLog($"Modified Player \"{player.PlayerName}\" of Club \"{club.ClubFullName}\" with ClubID {player.ClubID}"));
                TempData["message"] = $"Player {player.PlayerName} has been successfully modified";
                return RedirectToAction("ClubPage", repositoryClub.Clubs);
            }

            return View(player);
        }

        [HttpPost]
        [Authorize]
        public IActionResult DeletePlayer(int playerID)
        {
            Player deletedPlayer = repositoryPlayer.DeletePlayer(playerID);
            if (deletedPlayer == null)
            {
                TempData["message"] = $"Selected Player was not found.";
            }
            else
            {
                Club club = repositoryClub.Clubs.FirstOrDefault(p => p.ClubID == deletedPlayer.ClubID);
                repositoryLog.Save(MakeLog($"Deleted Player \"{deletedPlayer.PlayerName}\" from Club \"{club.ClubFullName}\" with ClubID {deletedPlayer.ClubID}"));
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

