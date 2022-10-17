using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TP02_SWII.Models;

namespace TP02_SWII.Controllers
{
    public class HomeController : Controller
    {
        private Context db = new Context();
        public ActionResult Index()
        {
            var containers = db.Containers.Include(c => c.bl);
            var bl = db.Bls.ToList();
            //containers.Concat(bl.ToList());
            ViewBag.ListaBL = bl;
            ViewBag.ListContainer = containers;
            
            //var listaConcatenada = bl.Concat(containers);
            return View(containers.ToList());
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}