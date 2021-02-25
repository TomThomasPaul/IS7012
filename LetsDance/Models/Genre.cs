using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LetsDance.Models
{
    public class Genre
    {
        public int GenreId { get; set; }

        [System.ComponentModel.DisplayName("Genre Name")]
        [Required]
        [StringLength(50)]
        public string GenreName { get; set; }
        public List<BuddingDancer> BuddingDancers { get; set; }
        public List<Faculty> Faculties { get; set; }
    }
}
