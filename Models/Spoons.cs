using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcSpoon.Models
{
    public class Spoons
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Size { get; set; }
        public decimal Price { get; set; }
        public string Material { get; set; }
        public string Use { get; set; }
        public int Rating { get; set; }
    }
}
