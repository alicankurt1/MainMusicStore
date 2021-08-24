﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MainMusicStore.Models.DbModels
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Bu alan Boş Geçilemez.")]
        [StringLength(250,MinimumLength = 3,ErrorMessage ="Şartlara uygun değer giriniz.")]
        public string CategoryName { get; set; }
    }
}
