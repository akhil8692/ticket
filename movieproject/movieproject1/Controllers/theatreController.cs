using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using movieproject1.Models;
using System.Data.Entity;

namespace movieproject1.Controllers
{
    public class theatreController : Controller
    {
        movieEntities dbtheatre = new movieEntities();
        // GET: theatre
        public ActionResult theatrecs()
        {
            var theatreinfo = dbtheatre.tbltheatres.ToList();
            return View(theatreinfo);
        }

        public ActionResult addtheatre()
        {
            return View();
        }

        [HttpPost]
        public ActionResult addtheatre(tbltheatre theatrename)
        {
            dbtheatre.tbltheatres.Add(theatrename);          
            dbtheatre.SaveChanges();
            return View(theatrename);
        }

        public ActionResult edittheatre(int id)
        {
            var theatreinfo=dbtheatre.tbltheatres.Find(id);
            return View(theatreinfo);
        }

        [HttpPost]
        public ActionResult edittheatre(tbltheatre data)
        {
            dbtheatre.Entry(data).State = EntityState.Modified;
            dbtheatre.SaveChanges();
            return View(data);
        }

        public ActionResult deletetheatre(int id)
        {
            var theatreinfo = dbtheatre.tbltheatres.Find(id);
            return View(theatreinfo);
        }

        [HttpPost,ActionName("deletetheatre")]
        public ActionResult deletetheatreconfirmed(int id)
        {
            var theatreinfo = dbtheatre.tbltheatres.Find(id);
            dbtheatre.tbltheatres.Remove(theatreinfo);
            dbtheatre.SaveChanges();
            return RedirectToAction("theatrecs");
        }

    }
}