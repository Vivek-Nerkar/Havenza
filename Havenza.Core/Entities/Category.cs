using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Havenza.Core.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        // Navigation property for related products
        public ICollection<Product> Products { get; set; }
    }
}
