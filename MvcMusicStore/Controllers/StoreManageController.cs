using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore.Models;

namespace MvcMusicStore.Controllers
{
    [Authorize]
    public class StoreManageController : Controller
    {
        // GET: StoreManage
        public ActionResult Index()
        {
            ViewBag.Mes = TempData["Mes"];
            return View();
        }
        public RedirectToRouteResult DatabaseInit()
        {
            //创建数据库上下文
            MusicSroreContext db = new MusicSroreContext();
            //数据库初始化
            db.Database.CreateIfNotExists();

            Random radom = new Random();
            //创建一个艺术家集合
            //艺术家列表
            List<Artist> artistList = new List<Artist>();
            List<Genre> genreList = new List<Genre>();
            List<Album> AlbumList = new List<Album>();
            for (int i = 1; i < 10; i++)
            {
                var artist = new Artist()
                {
                    Name = "艺术家" + i.ToString(),
                    ModifiedDate = DateTime.Now
                };

                artistList.Add(artist);
            }
            for (int i = 1; i < 5; i++)
            {
                var genre = new Genre()
                {
                    Name = "回到南方" + i.ToString(),
                    Description = "略懂",
                    ModifiedDate = DateTime.Now
                };
                genreList.Add(genre);
            }

            for (int i = 1; i< 20; i++)
            {
                var artist = artistList.ElementAt(radom.Next(artistList.Count));
                var genre = genreList.ElementAt(radom.Next(genreList.Count));
                var album = new Album()
                {
                    Artist = artist,
                    Genre = genre,
                    Title = "标题" + i.ToString(),
                    Price = radom.Next(100),
                    AlbumArtUrl = "01.jpg",
                    ModifiedDate = DateTime.Now,
                };
                //将实体对象置入集合
                db.AlbumSet.Add(album);
            }

            //初始化成功--成功
            if (db.SaveChanges() > 0)
            {
                TempData["Mes"] = "成功";
            }

            else
            {
                TempData["Mes"] = "失败";
            }
            return RedirectToAction("Index");
        }
    }
}