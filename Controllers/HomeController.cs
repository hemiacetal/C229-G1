using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mariia_S_301052981.Models;
using Microsoft.AspNetCore.Mvc;

namespace Mariia_S_301052981.Controllers
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
        public ViewResult AddClubPage()
        {
            return View();
        }

        [HttpPost]
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
        public ViewResult ManagePlayersPage()
        {

            ViewBag.ClubList = repositoryClub.Clubs; 
            return View();

        }

        [HttpPost]
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

        public ViewResult EditClub(string name) => View(repositoryClub.Clubs.FirstOrDefault
            (c => c.ClubFullName == name));


        [HttpPost]
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
        public IActionResult Delete(string name)
        {
            Club deletedClub = repositoryClub.DeleteClub(name);
            if (deletedClub != null)
            {
                TempData["message"] = $"{deletedClub.ClubFullName} was successfully removed from the system";
            }
            return RedirectToAction("ClubPage", repositoryClub.Clubs);
        }

    }
}

