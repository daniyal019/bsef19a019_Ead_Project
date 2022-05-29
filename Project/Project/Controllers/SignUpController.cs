using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.Models;
namespace Project.Controllers
{
    public class SignUpController : Controller
    {
        [HttpGet]
        public ViewResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ViewResult SignUp(Customer user)
        {
            CustomerData custom = new CustomerData();

            bool result = custom.Add(user);
           //while(user.username!=null &&user.email!=null &&user.email!=null&&user.password!=null)
           // {
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
                return View();
            }
        }

            //return (View());
        }

                


        }
    