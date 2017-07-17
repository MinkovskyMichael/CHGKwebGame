using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CHGKPhilaGame.Controllers
{
    public class CHGKGameController : Controller
    {
        // GET: CHGKGame
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CHGKGame()
        {
            return View();
        }
        
    }
}