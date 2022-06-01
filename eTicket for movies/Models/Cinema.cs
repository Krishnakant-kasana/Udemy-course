using eTicket_for_movies.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket_for_movies.Models
{
    public class Cinema: IEntityBase 
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Cinema Logo")]
        [Required(ErrorMessage ="Cinema Logo is required")]
        public string  Logo { get; set; }
        [Display(Name = "Cinema Name")]
        [Required(ErrorMessage = "Cinema Name is required")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Cinema Description is required")]
        public string Description { get; set; }

      /* public Cinema(List<Movie>  movies)
        {
            Movies = movies;
        }*/
        //Relationships
        public List<Movie> Movies { get; set; }

    }
}
