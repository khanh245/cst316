using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KASKBlog.Models;

namespace KASKBlog.Controllers
{
    public class PostController : Controller
    {
        private KASKBlogContext db = new KASKBlogContext();

        // Index is the list of all Posts.
        // GET: /Post/

        public ActionResult Index()
        {
            return View(db.Posts.ToList());
        }

        // Details is a detailed of a Post.
        // GET: /Post/Details/5

        public ActionResult Details(int id = 0)
        {
            Post post = db.Posts.Find(id);
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }

        // Create (without data) is a way to bring up an HTML form for a new post.
        // GET: /Post/Create

        public ActionResult Create()
        {
            return View();
        }

        // Create (with data) is a way to save data for a new Post.
        // POST: /Post/Create

        [HttpPost]
        public ActionResult Create(Post post)
        {
            if (ModelState.IsValid)
            {
                db.Posts.Add(post);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(post);
        }

        // Edit (without data) is a way to bring up an HTML form for an existing Post (with Post id given as a parameter.)
        // GET: /Post/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Post post = db.Posts.Find(id);
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }

        // Edit (with data) is a way to save data for an existing Post (with Post id given as a parameter.)
        // POST: /Post/Edit/5

        [HttpPost]
        public ActionResult Edit(Post post)
        {
            if (ModelState.IsValid)
            {
                db.Entry(post).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(post);
        }

        // Delete is a way to ask if a user wants to really delete an existing Post (with Post id given as a parameter.)
        // GET: /Post/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Post post = db.Posts.Find(id);
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }

        // Delete Confirmed is a way to actually delete a specified, existing Post (with Post id given as a parameter.)
        // POST: /Post/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Post post = db.Posts.Find(id);
            db.Posts.Remove(post);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // Dispose is used to free up unmanaged resources.
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}