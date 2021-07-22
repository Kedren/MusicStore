using System;
using System.Collections.Generic;
using MvcMusicStore.Models;
using System.Linq;
using System.Web;

namespace MvcMusicStore.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}