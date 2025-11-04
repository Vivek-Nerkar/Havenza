using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Havenza.Core.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; } // Foreign key for the Category (will link to Category entity)

        // Navigation property for the product's category
        // This creates a relationship to the Category entity
        public Category Category { get; set; }
        public string? ImageUrl { get; set; }         // URL/path to the product image
        public int Stock { get; set; }

    }
}
