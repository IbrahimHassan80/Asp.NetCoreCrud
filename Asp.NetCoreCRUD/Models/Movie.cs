﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCoreCRUD.Models
{
    public class Movie
    {
        public int Id { get; set; }
        
        [Required,MaxLength(250)]
        public string Title { get; set; }
        
        public int Year { get; set; }
        
        public double Rate { get; set; }
        
        [Required, MaxLength(250)]
        public string StoreLine { get; set; }

        [Required]
        public byte[] Poster { get; set; }
        
        public byte GenreId { get; set; }

        public Genre Genre { get; set; }
    }
}
