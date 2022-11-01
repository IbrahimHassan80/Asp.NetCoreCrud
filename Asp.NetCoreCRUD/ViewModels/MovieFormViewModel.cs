using Asp.NetCoreCRUD.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCoreCRUD.ViewModels
{
    public class MovieFormViewModel
    {
        public int Id { get; set; }
        
        [Required, MaxLength(250)]
        public string Title { get; set; }

        public int Year { get; set; }

        [Range(1, 10)]
        public double Rate { get; set; }

        [Required, StringLength(250)]
        public string StoreLine { get; set; }

        public byte[] Poster { get; set; }

        [Display(Name = "Genre")]
        public byte GenreId { get; set; }

        public Genre Genre { get; set; }

        public IEnumerable<Genre> Genres { get; set; }
    }
}
