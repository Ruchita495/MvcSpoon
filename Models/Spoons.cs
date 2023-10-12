using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcSpoon.Models
{
    public class Spoons
    {
        // Add a field with datatype
        public int Id { get; set; }
        // Add validation critarea 
        [StringLength(30, MinimumLength = 3)]
        [Required]
        public string Type { get; set; }

        [StringLength(10, MinimumLength = 2)]
        [Required]
        public string Size { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [StringLength(15, MinimumLength = 3)]
        [Required]
        public string Material { get; set; }

        [StringLength(15, MinimumLength = 5)]
        [Required]
        public string Use { get; set; }

        [Required]
        public int Rating { get; set; }
    }
}
