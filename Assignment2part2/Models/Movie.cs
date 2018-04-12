using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2part2.Models
{
    [Table("Movie")]
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
       
        [Required]

        public string Producer { get; set; }

        [Required]
        public string Hero { get; set; }
        [Required]
        public virtual Popular Popular { get; set; }
    }
}
