using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace FashionSiteEntityLibrary.HeadLineEntity
{
   public class HeadLineTable
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HeadLineId { get; set; }

        [Required(ErrorMessage = "Manşet başlığı boş geçilemez!")]
       
        public string HeadLineTitle { get; set; }

        public string HeadLineCategory { get; set; }

        public string HeadLineContent { get; set; }

        public string Language { get; set; }

        public string HeadLineImageUrl { get; set; }

        public string HeadLineSeo { get; set; }

       
    }
}
