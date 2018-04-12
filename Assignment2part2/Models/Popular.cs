using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2part2.Models
{
    [Table("Popular")]
    public class Popular
    {
        [Key]
        
        public int MovieId { get; set; }
        [Required]
        public string About { get; set; }
        [Required]
        public int? Budget { get; set; }
        [Required]
        public int? Rating { get; set; }
        [Required]
        public virtual Movie Movie { get; set; }
    }
}
