using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using movieproject.Models;
using System.Data.Entity;

namespace movieproject.Controllers
{

    public class locationController : Controller
    {
        movieEntities dblocation = new movieEntities();
        // GET: location
        public ActionResult locationcs()
        {
            var locationinfo = dblocation.tbllocations.ToList();
            return View(locationinfo);
        }

        public ActionResult editlocation(int id)
        {
            var locinfo=dblocation.tbllocations.Find(id);
            return View(locinfo);
        }

        [HttpPost]
        public ActionResult editlocation(tbllocation data)
        {
            
            dblocation.Entry(data).State = EntityState.Modified;
            dblocation.SaveChanges();
            return View(data);
        }
        

        public ActionResult deletelocation(int id)
        {
            var delete = dblocation.tbllocations.Find(id);
            return View(delete);
        }
        [HttpPost,ActionName("deletelocation")]
        public ActionResult deletelocationconfirmed(int id)
        {
            var locationinfo = dblocation.tbllocations.Find(id);
            dblocation.tbllocations.Remove(locationinfo);
            dblocation.SaveChanges();
            return View();
        }
        public ActionResult addlocation()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult addlocation(tbllocation location)
        {
            dblocation.tbllocations.Add(location);
            dblocation.SaveChanges();
            return View();
        }


    }
}