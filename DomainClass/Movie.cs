﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations; 

namespace DomainClass
{
    public class Movie
    {
        public int Id { get; set; }
        [MaxLength(150, ErrorMessage = "Up to 150 chars")]
        [Required(ErrorMessage = "Please Latin Name is insert")]
        public string LatinName { get; set; }
        [MaxLength(150, ErrorMessage = "Up to 150 chars")]
        [Required(ErrorMessage = "Please Persian Name is insert")]
        public string PersianName { get; set; }
        [Range(1,10)]
        [DefaultValue(1)]
        public double Rate { get; set; }
    }
}