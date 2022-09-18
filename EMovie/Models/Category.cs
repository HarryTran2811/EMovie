using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EMovie.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Category Name")]
        [Required(ErrorMessage = "Category is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 100 chars")]
        public string Name { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
