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
        

    [HttpGet]
    public ViewResult treesCare()
    {
        return View();
    }

    [HttpPost]
    public ViewResult treesCare(Customer c)
    {
        return (View("Views/Home/Index.cshtml"));
    }

        [HttpGet]
        public ViewResult gardenCare()
        {
            return View();
        }

        [HttpPost]
        public ViewResult gardenCare(Customer c)
        {
            return (View("Views/Home/Index.cshtml"));
        }


        [HttpGet]
        public ViewResult forestCare()
        {
            return View();
        }

        [HttpPost]
        public ViewResult forestCare(Customer c)
        {
            return (View("Views/Home/Index.cshtml"));
        }

        [HttpGet]
        public ViewResult fieldCare()
        {
            return View();
        }

        [HttpPost]
        public ViewResult fieldCare(Customer c)
        {
            return (View("Views/Home/Index.cshtml"));
        }
        [HttpGet]
        public ViewResult flowersCare()
        {
            return View();
        }

        [HttpPost]
        public ViewResult flowersCare(Customer c)
        {
            return (View("Views/Home/Index.cshtml"));
        }



    }


}

