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

        [System.ComponentModel.DisplayName("Budding Dancer")]
        public List<BuddingDancer> BuddingDancers { get; set; }

        [System.ComponentModel.DisplayName("Faculty")]
        public List<Faculty> Faculties { get; set; }
    }
}
