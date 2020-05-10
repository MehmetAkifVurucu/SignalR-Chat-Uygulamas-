using SignalRChatApp.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignalRChatApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Chat()
        {
            ViewBag.Message = "Chat";
            return View();
        }

        public JsonResult MesajListele(string aliciId)
        {
            ChatHub chatHub = new ChatHub();
            return Json(chatHub.KonusmaListesiGetir(aliciId));
        }
    }
}