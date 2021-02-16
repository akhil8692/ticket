using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using movieproject1.Models;
using System.Data.Entity;

namespace movieproject1.Controllers
{
    public class movieController : Controller
    {
        movieEntities dbmovie = new movieEntities();
        // GET: movie
        public ActionResult moviecs()
        {
            var movieinfo = dbmovie.tblmovies.ToList();
            return View(movieinfo);
        }

        public ActionResult addmovie()
        {
            return View();
        }


        [HttpPost]
        public ActionResult addmovie(tblmovy moviename, tblmovy movietyp, tblmovy desc)
        {
            dbmovie.tblmovies.Add(moviename);
            dbmovie.tblmovies.Add(movietyp);
            dbmovie.tblmovies.Add(desc);
            dbmovie.SaveChanges();
            return View();
        }

        public ActionResult editmovie(int id)
        {
            var movieinfo = dbmovie.tblmovies.Find(id);
            return View(movieinfo);
        }

        [HttpPost]
        public ActionResult editmovie(tblmovy movienam)
        {
            dbmovie.Entry(movienam).State = EntityState.Modified;
            dbmovie.SaveChanges();
            return View(movienam);
        }

        public ActionResult deletemovie(int id)
        {
            var movieinfo = dbmovie.tblmovies.Find(id);
            return View(movieinfo);
        }

        [HttpPost,ActionName("deletemovie")]
        public ActionResult deletemoviec(int id)
        {
            var movieinfo = dbmovie.tblmovies.Find(id);
            dbmovie.tblmovies.Remove(movieinfo);
            dbmovie.SaveChanges();
            return RedirectToAction("moviecs");
        }

    }
}