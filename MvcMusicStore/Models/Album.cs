using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{

    /// <summary>
    ///  专辑
    /// </summary>
    public class Album
    {
        [Required]
        [DisplayName("专辑ID")]
        public int AlbumId { get; set; }
        [Required]
        [DisplayName("类别ID")]
        public int GenreId { get; set; }
        [Required]
        [DisplayName("艺术家名称")]   
        public int ArtistId { get; set; }
       
        [Required(ErrorMessage ="不能缺少标题")]
        [DisplayName ("曲目")]
        
        public string Title { get; set; }

        [Required(ErrorMessage = "不能缺少价格")]
        [Display(Name = "价格")]
        [Range(0.01,100.00,ErrorMessage ="价格必须在0.01到100.00之间")]
        public decimal Price { get; set; }
        [Required]
        [Display(Name = "专辑封面图片地址")]
        public string AlbumArtUrl { get; set; }
        [Required]
        [Display(Name = "修改日期")]   
        public DateTime ModifiedDate { get; set; }   
        //类别（导航属性）
        public virtual Genre Genre { get; set; }
        //艺术家（导航属性）
        public virtual Artist Artist { get; set; }
    }
}