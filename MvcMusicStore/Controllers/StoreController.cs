using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore.Models;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        private MusicSroreContext db = new MusicSroreContext();
        //
        // GET: /Store/
        public ActionResult Index()
        {
            var album = db.AlbumSet.ToList();
            return View(album);
        }
        //
        // GET: /Store/Browse
        public ActionResult Browse(int id)
        {
            if (id == 0)
            {
                return RedirectToAction("index", "Genres");
            }
            else
            {
                var genreModel = db.GenreSet.Find(id);
                return View(genreModel);
            }


        }
        //
        // GET: /Store/Details
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Album album = db.AlbumSet.Find(id);
            if (album == null)
            {
                return HttpNotFound();
            }
            return View(album);
        }
        //
        // GET: /Store/GenreMenu
        [ChildActionOnly]
        public ActionResult GenreMenu()
        {
            var genres = db.GenreSet.ToList();
            return PartialView(genres);
        }
    }
}