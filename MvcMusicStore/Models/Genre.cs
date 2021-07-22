using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class Genre
    {
        [Required]
        [Display(Name = "类别ID")]
        public int GenreId { get; set; }
        [Required]
        [Display(Name = "类别名称")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "类别描述")]
        public string Description { get; set; }
        [Required]
        [Display(Name = "修改日期")]
        public DateTime ModifiedDate { get; set; }
        public virtual ICollection<Album> Albums { get; set; }
    }
}