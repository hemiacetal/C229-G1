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

        public HomeController(IClubRepository repo, IPlayerRepository repo2)
        {
            repositoryClub = repo;
            repositoryPlayer = repo2;
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
            Club club = repositoryClub.Clubs.First(c => c.ClubID == player.ClubID);
            if (club == null)
            {
                ModelState.AddModelError("ClubID", $"The selected club does not exist in the system.");
            }
            else
            {
                if (ModelState.IsValid)
                {
                    repositoryPlayer.Save(player);
                    return View("ClubPage", repositoryClub.Clubs);
                }
            }

            ViewBag.ClubList = repositoryClub.Clubs;
            return View(player);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult EditClub(int clubID)
        {

            Club club = repositoryClub.Clubs.FirstOrDefault(c => c.ClubID == clubID);
            if (club == null)
            {
                TempData["message"] = "Club not found.";
                return RedirectToAction("ClubPage", repositoryClub.Clubs);
            }
            else
            {
                return View("EditClub", club);
            }

        }


        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult EditClub(Club club)
        {
            Club editClub = repositoryClub.Clubs.FirstOrDefault(c => c.ClubID == club.ClubID);
            if (editClub == null)
            {
                ModelState.AddModelError("ClubFullName", $"Club {club.ClubFullName} was removed from the system and cannot be edited.");
            }
            else
            {
                if (ModelState.IsValid)
                {
                    repositoryClub.Save(club);
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
                TempData["message"] = $"Club {deletedClub.ClubFullName} was successfully removed from the system";
            }
            return RedirectToAction("ClubPage", repositoryClub.Clubs);
        }

    }
}

