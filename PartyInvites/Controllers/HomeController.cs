using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            int hour = DateTime.Now.Hour;

            ViewBag.Greeting = hour < 17 ? "Dzień dobry" : "Dobry wieczór";

            return View();
        }

        [HttpGet]
        public ActionResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RsvpForm(GuestResponse guestResponse)
        {
            
            if (ModelState.IsValid) //Sprawdzenie czy wszystkie wymagane dane zostały wypełnione
            {
                //Do zrobienia: wyślij wiadomość o organizatora przyjęcia
                return View("Thanks", guestResponse);
            }
            else
            {
                return View();
            }
            
        }
        
    }
    
}