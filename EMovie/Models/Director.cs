using EMovie.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EMovie.Models
{
    public class Director:IEntityBase
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Director Avatar")]
        [Required(ErrorMessage = "Director avatar is required")]
        public string Avatar { get; set; }

        [Display(Name = "Director Name")]
        [Required(ErrorMessage = "Director name is required")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Director description is required")]
        public string Description { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
