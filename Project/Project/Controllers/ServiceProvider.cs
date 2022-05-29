using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.Models;
namespace Project.Controllers
{
    public class ServiceProvider : Controller
    {
        [HttpGet]
        public ViewResult houseCare()
        {
            return View();
        }

        [HttpPost]
        public ViewResult houseCare(Customer c)
        {
            return (View("Views/Home/Index.cshtml"));
        }
        }
    }

