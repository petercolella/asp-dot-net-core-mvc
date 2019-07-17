﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace App.Controllers
{
    public class AppController : Controller
    {
        // GET: /<controller>/
        public string Index()
        {
            return "Welcome to the /App endpoint.";
        }

        public string About()
        {
            return "Welcome to the About Page.";
        }

        public string Contact()
        {
            return "Welcome to the Contact Page.";
        }
    }
}
