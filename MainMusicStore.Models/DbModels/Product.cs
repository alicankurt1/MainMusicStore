using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MainMusicStore.Models.DbModels
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string title { get; set; }

        public string Description { get; set; }
        
        [Required]
        public string ProductNo { get; set; }

        [Required]
        [Range(1,10000000)]
        public double Price { get; set; }

        [Required]
        [Range(1, 10000000)]
        public double ListPrice { get; set; }

        public string ImageUrl { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public int BrandId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        [ForeignKey("BrandId")]
        public Brand Brand { get; set; }




    }
}
