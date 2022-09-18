using EMovie.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EMovie.Models
{
    public class Actor_Movie
    {
        public int MovieID { get; set; }
        public Movie Movie { get; set; }

        public int ActorID { get; set; }
        public Actor Actor { get; set; }
    }
}
