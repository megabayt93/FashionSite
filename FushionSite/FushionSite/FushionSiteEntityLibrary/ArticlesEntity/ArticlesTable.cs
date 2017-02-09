using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace FashionSiteEntityLibrary.ArticlesEntity
{
   public class ArticlesTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ArticleId { get; set; }

        [Required(ErrorMessage = "Yazı başlığı boş geçilemez!")]
      
        public string ArticleTitle { get; set; }

        public string ArticleContent { get; set; }

        public string ArticleSeo { get; set; }

        public string ArticleCategory { get; set; }

        public string ArticleImage { get; set; }

       public string Language { get; set; }
    }
}
