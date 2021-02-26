﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Display(Name = "Release Date")]
        [Required]
        public DateTime ReleaseDate { get; set; }
        
        public DateTime DateAdded { get; set; }
        [Display(Name = "Number in Stock")]
        [Range(1,20)]
        public int NumberInStocks { get; set; }
        public Genre Genre { get; set; }
        
        [Display(Name = "Genre")]
        public int GenreId { get; set; }
    }
}