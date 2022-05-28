using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.Models;
namespace Project.Controllers
{
    public class ContactController : Controller
    {

        [HttpGet]
        public ViewResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Contact(Customer user)
        {
            CustomerData custom = new CustomerData();
            bool result = custom.Add(user);
            if (ModelState.IsValid)
            {

                if (result == true)
                {
                    return (View("Views/Home/Index.cshtml"));
                }
                else
                {
                    return (View());
                }
            }
            else
            {
                return (View());
            }
            }
        }
    }

