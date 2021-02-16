using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using movieproject.Models;

namespace movieproject.Controllers
{
    public class theatreController : Controller
    {
        movieEntities theatre = new movieEntities();
        // GET: theatre
        public ActionResult theatrecs()
        {
            var theatreinfo = theatre.tbltheatres.ToList();
            return View(theatreinfo);
        }
    }
}