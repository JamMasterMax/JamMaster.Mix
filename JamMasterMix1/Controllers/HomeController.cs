using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using JamMasterMax1.App_Data;

namespace JamMasterMax1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ViewData["Tracks"] = TrackManager.GetTracks();

            return View();
        }
    }
}
