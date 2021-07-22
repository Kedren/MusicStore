using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    /// <summary>
    /// 艺术家
    /// </summary>
    public class Artist
    {
        [Required]
        [Display(Name = "艺术家ID")]
        public int ArtistId { get; set; }
        [Required]
        [Display(Name = "艺术家名称")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "修改日期")]
        public DateTime ModifiedDate { get; set; }
    }
}