using BlogPlatform.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogPlatform.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BlogPlatform.Controllers
{
    public class PostController : Controller
    {

        private BlogContext depInject;

        public PostController(BlogContext appDb)
        {
            depInject = appDb;
        }
        public IActionResult Index()
        {
            return View(depInject.Posts.ToList());
        }

        public IActionResult Create()
        {
            ViewBag.Categories = depInject.Categories.ToList();
            return View();
        }

        [HttpPost]

        public IActionResult Create(Post post)
        {
            ViewBag.Categories = depInject.Categories.ToList();
            post.CreatedOn = DateTime.Now;
            depInject.Posts.Add(post);
            depInject.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var post = depInject.Posts.Find(id);
            depInject.Posts.Remove(post);
            depInject.SaveChanges();

            return View(post);

        }

        [HttpPost]
        public IActionResult Delete(int id, Post post)
        {
            Post post1 = depInject.Posts.Find(id);
            depInject.Posts.Remove(post);
            return RedirectToAction("Index");

        }

        public IActionResult Edit(int id = 0)
        {
            Post post = depInject.Posts.Find(id);
            ViewBag.Categories = depInject.Categories.ToList();
            if (post == null)
            {
                return NotFound();
            }
            return View(post);
        }



        [HttpPost]
        public IActionResult Edit(int id, Post post)
        {
            depInject.Entry(post).State = EntityState.Modified;
            depInject.SaveChanges();
            ViewBag.Categories = depInject.Categories.ToList();
            return RedirectToAction("Index");
        }


    }
}
