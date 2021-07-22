using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;

namespace MvcMusicStore.Models
{
    public class TempData : DropCreateDatabaseAlways<MusicSroreContext>
    {
        protected override void Seed(MusicSroreContext db)
        {
            Random ran = new Random();
            //数据
            //艺术家
            var artists = new List<Artist> {
                new Artist { Name = "周杰伦" },
                new Artist{ Name = "张杰" },
                new Artist{ Name = "邓紫棋" },
                new Artist{ Name = "陈奕迅" },
                new Artist{ Name = "张学友" },
                new Artist{ Name = "林俊杰" },
                new Artist{ Name = "毛不易" },
                new Artist{ Name = "TFBOYS" },
                new Artist{ Name = "鹿晗" },
                new Artist{ Name = "李荣浩" },
                new Artist{ Name = "BEYOND" },
                new Artist{ Name = "张艺兴" },
                new Artist{ Name = "张碧晨" },
                new Artist{ Name = "邓丽君" },
                new Artist{ Name = "王菲" },
                new Artist{ Name = "张靓颖" },
                new Artist{ Name = "刘瑞琦" },
                new Artist{ Name = "小虎队" },
                new Artist{ Name = "薛之谦" }

            };
            foreach (var item in artists)
            {
                item.ModifiedDate = DateTime.Now;
            }
            db.ArtistSet.AddRange(artists);
            //类别
            var genres = new List<Genre> {
                new Genre { Name = "流行", },
                new Genre { Name = "摇滚", },
                new Genre { Name = "爵士",},
                new Genre { Name = "嘻哈",},
                new Genre { Name = "蓝调", },
                new Genre { Name = "朋克" },
                new Genre { Name = "金属" },
                new Genre { Name = "拉丁" },
                new Genre { Name = "雷鬼" },
                new Genre { Name = "新世纪" },
                new Genre { Name = "乡村音乐" },
                new Genre { Name = "电子舞曲" },
                new Genre { Name = "民乐/民歌、世界音乐" },
                new Genre { Name = "发烧音乐" }
            };
            foreach (var item in genres)
            {
                item.ModifiedDate = DateTime.Now;
                if (string.IsNullOrEmpty(item.Description))
                {
                    item.Description = "只剩下钢琴，安静的久久的！";
                }
            }
            db.GenreSet.AddRange(genres);
            //专辑
            var album = new List<Album> {
                new Album { Title = "慢慢", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "张学友"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "一路上有你", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m1.jpg", Artist = artists.Single(a => a.Name == "张学友"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "吻别", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m2.jpg", Artist = artists.Single(a => a.Name == "张学友"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "一千个伤心的理由", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m3.jpg", Artist = artists.Single(a => a.Name == "张学友"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "只想一生跟你走", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m4.jpg", Artist = artists.Single(a => a.Name == "张学友"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "饿狼传说", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m5.jpg", Artist = artists.Single(a => a.Name == "张学友"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "遥远的她", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m6.jpg", Artist = artists.Single(a => a.Name == "张学友"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "等你等到我心痛", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "张学友"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "爱你痛到不知痛", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "张学友"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "江南", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "林俊杰"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "修炼爱情", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "林俊杰"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "不为谁而作的歌", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "林俊杰"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "背对背拥抱", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "林俊杰"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "小酒窝", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "林俊杰"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "一千年以后", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "林俊杰"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "海阔天空", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "BEYOND"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "光辉岁月", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "BEYOND"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "不在犹豫", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "BEYOND"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "真的爱你", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "BEYOND"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "喜欢你", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "BEYOND"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "谁伴我闯荡", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "BEYOND"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "大地", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "BEYOND"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "情人", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "BEYOND"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "冷雨夜", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "BEYOND"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "无尽空虚", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "BEYOND"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "消愁", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "毛不易"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "像我这样的人", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "毛不易"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "致爱Your Song", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "鹿晗"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "勋章", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "鹿晗"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "追梦赤子心", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "鹿晗"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "我们的明天", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "鹿晗"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "让我留在你身边", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "鹿晗"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "虫儿飞", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "鹿晗"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "原动力", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "鹿晗"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "我只在乎你", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "邓丽君"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "甜蜜蜜", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "邓丽君"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "月亮代表我的心", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "邓丽君"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "恰是你的温柔", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "邓丽君"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "但愿人长久", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "邓丽君"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "在水一方", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "邓丽君"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "凉凉", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "张碧晨"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "年轮", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "张碧晨"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "胡桃夹子", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "张碧晨"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "下一秒", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "张碧晨"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "曾经守候", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "张碧晨"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "青春修炼手册", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "TFBOYS"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "不完美的小孩", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "TFBOYS"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "剩下的盛夏", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "TFBOYS"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "加油！AMIGO", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "TFBOYS"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "我们的时光", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "TFBOYS"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "是你", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "TFBOYS"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "样", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "TFBOYS"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "未来的进击", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "TFBOYS"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "爱", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "小虎队"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "青苹果乐园", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "小虎队"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "星星的约会", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "小虎队"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "李白", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "李荣浩"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "模特", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "李荣浩"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "老街", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "李荣浩"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "不将就", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "李荣浩"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "说好的幸福呢", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "周杰伦"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "稻香", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "周杰伦"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "青花瓷", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "周杰伦"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "七里香", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "周杰伦"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "简单爱", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "周杰伦"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "安静", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "周杰伦"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "晴天", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "周杰伦"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "十年", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "陈奕迅"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "红玫瑰", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "陈奕迅"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "好久不见", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "陈奕迅"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "不要说话", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "陈奕迅"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "淘汰", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "陈奕迅"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "爱情转移", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "陈奕迅"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "浮夸", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "陈奕迅"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "阴天快乐", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "陈奕迅"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "单车", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "陈奕迅"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "最美的太阳", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "张杰"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "逆战", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "张杰"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "三生三世", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "张杰"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "我们都一样", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "张杰"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "明天过后", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "张杰"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "剑心", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "张杰"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "逆战", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "张杰"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "浮诛", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "张杰"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "他不懂", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "张杰"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "浩瀚", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "张杰"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "睡公主", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "邓紫棋"), Genre = genres.Single(g => g.Name == "发烧音乐") },
                new Album { Title = "后会无期", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "邓紫棋"), Genre = genres.Single(g => g.Name == "发烧音乐") },
                new Album { Title = "新的心跳", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "邓紫棋"), Genre = genres.Single(g => g.Name == "发烧音乐") },
                new Album { Title = "龙卷风", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "邓紫棋"), Genre = genres.Single(g => g.Name == "发烧音乐") },
                new Album { Title = "红蔷薇白玫瑰", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "邓紫棋"), Genre = genres.Single(g => g.Name == "发烧音乐") },
                new Album { Title = "来自天堂的魔鬼", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "邓紫棋"), Genre = genres.Single(g => g.Name == "发烧音乐") },
                new Album { Title = "单行的轨道", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "邓紫棋"), Genre = genres.Single(g => g.Name == "发烧音乐") },
                new Album { Title = "一路逆风", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "邓紫棋"), Genre = genres.Single(g => g.Name == "发烧音乐") },
                new Album { Title = "房间", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "刘瑞琦"), Genre = genres.Single(g => g.Name == "发烧音乐") },
                new Album { Title = "演员", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "薛之谦"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "刚刚好", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "薛之谦"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "你还要我怎样", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "薛之谦"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "狐狸", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "薛之谦"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "丑八怪", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "薛之谦"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "方圆几里", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "薛之谦"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "高尚", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "薛之谦"), Genre = genres.Single(g => g.Name == "流行") },
                new Album { Title = "意外", Price = ran.Next(100), AlbumArtUrl = "/Content/images/m"+ran.Next(24).ToString()+".jpg", Artist = artists.Single(a => a.Name == "薛之谦"), Genre = genres.Single(g => g.Name == "流行") }
            };
            foreach (var item in album)
            {
                item.ModifiedDate = DateTime.Now;

            }
            db.AlbumSet.AddRange(album);
            db.SaveChanges();
        }
    }
}