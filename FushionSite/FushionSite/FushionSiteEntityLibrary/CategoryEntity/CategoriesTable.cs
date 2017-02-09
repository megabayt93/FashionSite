using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace FashionSiteEntityLibrary.CategoryEntity
{
    public class CategoriesTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Kategori ismi boş geçilemez!")]
        public string CategoryName { get; set; }

        public string CategorySeo { get; set; }

        


    }
}
