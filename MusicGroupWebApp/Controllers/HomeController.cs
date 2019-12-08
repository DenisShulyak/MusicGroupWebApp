using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicGroupWebApp.Controllers
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
        public ActionResult DownloadAlbom()
        {

            return File($"/App_Data/Nirvana/Nirvana.rar", "application/x-rar-compressed", "Nirvana.rar");
        }
        public ActionResult DownloadOpinion()
        {

            return File($"/App_Data/Nirvana/Opinion.mp3", "audio/mp3", "Opinion.mp3");
        }
        public ActionResult DownloadBeenASon()
        {

            return File($"/App_Data/Nirvana/BeenASon.mp3", "audio/mp3", "BeenASon.mp3");
        }public ActionResult DownloadDrainYou()
        {

            return File($"/App_Data/Nirvana/DrainYou.mp3", "audio/mp3", "DrainYou.mp3");
        }public ActionResult DownloadLithium()
        {

            return File($"/App_Data/Nirvana/Lithium.mp3", "audio/mp3", "Lithium.mp3");
        }public ActionResult DownloadPayToPlay()
        {

            return File($"/App_Data/Nirvana/PayToPlay.mp3", "audio/mp3", "PayToPlay.mp3");
        }public ActionResult DownloadSliver()
        {

            return File($"/App_Data/Nirvana/Sliver.mp3", "audio/mp3", "Sliver.mp3");
        }public ActionResult DownloadWhereDidYouSleepLastNight()
        {

            return File($"/App_Data/Nirvana/WhereDidYouSleepLastNight.mp3", "audio/mp3", "WhereDidYouSleepLastNight.mp3");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}