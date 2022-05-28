using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Project.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ViewResult Login()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Login(Customer user)
        {
            CustomerData custom = new CustomerData();

          
                if (custom.find(user) == true)
                {
                    return (View("Views/Home/Index.cshtml"));
                }
                else
                {

                    return (View("Views/Login/LoginFail.cshtml"));
                }
           
        }
    }
}