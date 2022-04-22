using ApiControllers.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiControllers.Controllers
{
    public class HomeController:Controller
    {
        private IRepository repository { get; set; }
        public HomeController(IRepository repo) 
        {
            repository = repo; 
        } 
        public ViewResult Index() => View(repository.Reservations);
       
        [HttpPost]
        public IActionResult AddReservation(Reservation reservation)
        {
            repository.AddReservation(reservation);
            return RedirectToAction("Index");
        }

    }
}
