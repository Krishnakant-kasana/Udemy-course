using eTicket_for_movies.Data;
using eTicket_for_movies.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket_for_movies.Models
{
    public class NewMovieVM 
    {
        public int Id { get; set; }

        [Display(Name = "Movie Name")]
        [Required(ErrorMessage ="Name is required")]
        

        public string  Name { get; set; }

        [Display(Name = "Movie description")]
        [Required(ErrorMessage = "Description is required")]

        public string Description { get; set; }

        [Display(Name = "Price in $")]
        [Required(ErrorMessage = "Price is required")]

        public double Price { get; set; }

        [Display(Name = "Movie poster URL")]
        [Required(ErrorMessage = "Movie poster URL is required")]

        public string ImageURL { get; set; }

        [Display(Name = "Movie start date")]
        [Required(ErrorMessage = "Start Date is required")]

        public DateTime StartDate { get; set; }

        [Display(Name = "Movie end date")]
        [Required(ErrorMessage = "End Date is required")]

        public DateTime EndDate { get; set; }

        [Display(Name = "Movie Category")]
        [Required(ErrorMessage = "Movie category is required")]


        public MovieCategory MovieCategory { get; set; }

        //Relationships

        [Display(Name = "Start Actor(s)")]
        [Required(ErrorMessage = "Movie Actor(s) is required")]


        public List<int> ActorIds{ get; set; }

        [Display(Name = "Start a Cinema")]
        [Required(ErrorMessage = "Movie Cinema is required")]



        public int CinemaId { get; set; }

        [Display(Name = "Start a producer")]
        [Required(ErrorMessage = "Movie producer is required")]


        public int ProducerId { get; set; } 
        

    }
}
