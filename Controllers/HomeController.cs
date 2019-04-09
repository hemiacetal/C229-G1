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


        public ViewResult ClubDetailsPage(string name)
        {
            Club club = repositoryClub.Clubs.FirstOrDefault(c => c.ClubFullName == name);
            return View(club);
        }


        [HttpGet]
        [Authorize]
        public ViewResult AddClubPage()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public ViewResult AddClubPage(Club club)
        {

            if (ModelState.IsValid)
            {

                repositoryClub.Save(club);
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
                return View("ClubPage", repositoryClub.Clubs);
            }
            else
            {
                ViewBag.ClubList = repositoryClub.Clubs;
                return View(player);
            }

        }

        [Authorize]
        public ViewResult EditClub(string name) => View(repositoryClub.Clubs.FirstOrDefault
            (c => c.ClubFullName == name));


        [HttpPost]
        [Authorize]
        public IActionResult EditClub(Club club)
        {
            if (ModelState.IsValid)
            {
                repositoryClub.Save(club);
                TempData["message"] = $"{club.ClubFullName} has been successfully modified";
                return RedirectToAction("ClubPage", repositoryClub.Clubs);
            }
            else
            {
               
                return View(club);
            }
        }

        [HttpPost]
        [Authorize]
        public IActionResult DeleteClub(string name)
        {
            Club deletedClub = repositoryClub.DeleteClub(name);
            if (deletedClub != null)
            {
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

    }
}

