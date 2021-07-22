using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStore.ViewModels
{
    public class ShoppingCartRemoveViewModel
    {
        //消息
        public string Message { get; set; }
        //总价
        public decimal CartTotal { get; set; }
        //购物车总数量
        public int CartCount { get; set; }
        //专辑总数量
        public int ItemCount { get; set; }
        //删除ID
        public int DeleteId { get; set; }
    }
}