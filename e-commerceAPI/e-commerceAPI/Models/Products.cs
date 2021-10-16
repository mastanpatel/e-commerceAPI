using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerceAPI.Models
{
    public class Products
    {     
          [Key]
          public int Id { get; set; }

          public string Title { get; set; }

          public int  Price { get; set; }

          public string  Description { get; set; }

          public string Category { get; set; }

          public string Image { get; set; }

          public string Rate { get; set; }

          public string Count { get; set; }
    }
}
