using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EMovie.Models
{
    public class Movie
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Movie Name")]
        [Required(ErrorMessage = "Movie name is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 100 chars")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Display(Name = "Price")]
        [Required(ErrorMessage = "Price is required")]
        public double Price { get; set; }
        [Display(Name = "Image source")]
        [Required(ErrorMessage = "Image is required")]
        public string ImageURL { get; set; }

        [Display(Name = "Film source")]
        [Required(ErrorMessage = "Film source is required")]
        public string FilmURL { get; set; }
        [Display(Name = "Start Date")]
        [Required(ErrorMessage = "Start date is required")]
        public DateTime StartDate { get; set; }
        [Display(Name = "End Date")]
        [Required(ErrorMessage = "End date is required")]
        public DateTime EndDate { get; set; }


        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }

        //Director
        public int DirectorID { get; set; }
        [ForeignKey("DirectorID")]
        public Director Director { get; set; }

        //Producer
        public int ProducerID { get; set; }
        [ForeignKey("ProducerID")]
        public Producer Producer { get; set; }

        //Category
        public int CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        public Category Category { get; set; }
    }
}
