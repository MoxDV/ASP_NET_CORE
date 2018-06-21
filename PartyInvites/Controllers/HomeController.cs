using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;
using System;
using System.Linq;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int _hour = DateTime.Now.Hour;
            ViewBag.Greeting = _hour < 12 ? "Доброе утро!" : "Добрый вечер";
            return View("MyView");
        }

        public ViewResult RsvpForm() {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guest) {
            if (ModelState.IsValid) {
                Repository.AddResponse(guest);
                return View("Thanks", guest);
            } else {
                return View();
            }
           
        }

        public ViewResult ListResponses() {
            return View(Repository.Responses.Where(g => g.WillAttend == true));
        }
    }
}
