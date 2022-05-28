using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.Models;

namespace Project.Controllers
{
    public class About : Controller
    {
        [HttpGet]
        public ViewResult AboutUs()
        {
            return View();
        }

        [HttpPost]
        public ViewResult AboutUs(Customer user)
        {

            return (View("Views/Home/Index.cshtml"));

        }
    }
}
