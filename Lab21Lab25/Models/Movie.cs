using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab21Lab25.Models
{
    public class Movie
    {
        [Key]
        [Required(ErrorMessage = "Please enter a valid number")]
        public int ID { get; set; }

        [MinLength(1, ErrorMessage ="Title must not be empty")]
        [Required(ErrorMessage ="Title is required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Genre is required")]
        public string Genre { get; set; }
        [Required(ErrorMessage = "Year is required")]
        public DateTime Year { get; set; }
        [Required(ErrorMessage = "Actors is required")]
        public string Actors { get; set; }
        [Required(ErrorMessage = "Directors is required")]
        public string Directors { get; set; }
    }
}
