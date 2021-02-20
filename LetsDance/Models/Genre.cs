using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetsDance.Models
{
    public class Genre
    {


        public int GenreId { get; set; }
        public string GenreName { get; set; }
        public List<BuddingDancer> BuddingDancers { get; set; }
        public List<Faculty> Faculties { get; set; }
    }
}
