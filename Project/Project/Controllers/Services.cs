using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.Models;
namespace Project.Controllers
{
    public class Services : Controller
    {
        [HttpGet]
        public ViewResult Service()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Service(Customer user)
        {
          
                return (View("Views/Home/Index.cshtml"));
          
        }
    }
}
