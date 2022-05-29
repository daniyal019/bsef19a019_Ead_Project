using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.Models;

namespace Project.Controllers
{
    public class orderService : Controller
    {
        [HttpGet]
        public ViewResult order()
        {
            return View();
        }

        [HttpPost]
        public ViewResult order(Customer user)
        {
            CustomerData custom = new CustomerData();
            bool result = custom.AddOrder(user);

            if (ModelState.IsValid)
            {
                if (result == true)
                {
                    return (View("Views/Home/Index.cshtml"));

                }
                else
                {
                    return (View("Views/orderService/order_done.cshtml"));
                }
            }
            else
            {
                return View();
            }
        }
        }
    }
    
