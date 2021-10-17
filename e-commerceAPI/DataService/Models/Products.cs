using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Models
{
    class Products
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Price { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }

        public string Image { get; set; }

        public Rating rating { get; set; }
        
    }

    class Rating
    {
        public string Rate { get; set; }

        public string Count { get; set; }
    }
}
