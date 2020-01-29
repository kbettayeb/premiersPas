using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MediaChill.Controllers
{
    public class FilmController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Historique()
        {

            return View();
        }
        public ActionResult ToSeeLater()
        {
            return View();
        }
        public ActionResult AddFilm()
        {
            return View();
        }

    }
}