using BlogPlatform.Models;
using BlogPlatform.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Controllers
{
    public class HomeController : Controller
    {
        private IRepository<Post> depInject;
        public IActionResult Index()
        {
            return View();
        }
    }
}
