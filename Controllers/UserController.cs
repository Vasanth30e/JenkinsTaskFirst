﻿using Microsoft.AspNetCore.Mvc;
using WebAppUsers.Models;

namespace WebAppUsers.Controllers
{
    public class UserController : Controller
    {
        static List<User> users = new List<User>()
        {
            new User(){UserId =  1, UserName = "Sam", UserPwd = "sam@123", UserEmail = "sam@yahoo.com"},
            new User(){UserId =  2, UserName = "Amit", UserPwd = "Amit@123", UserEmail = "Amit@yahoo.com"},
            new User(){UserId =  3, UserName = "Kumar", UserPwd = "Kumar@123", UserEmail = "Kumar@yahoo.com"},
            new User(){UserId =  4, UserName = "Anisha", UserPwd = "Anisha@123", UserEmail = "Anisha@yahoo.com"},
            new User(){UserId =  5, UserName = "Vidisha", UserPwd = "Vidisha@123", UserEmail = "Vidisha@yahoo.com"},
        };
        public IActionResult Index()
        {
            return View(users);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new User());
        }

        [HttpPost]
        public IActionResult Create(User model)
        {
            if(ModelState.IsValid)
            {
                users.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }

            
        }
    }
}
