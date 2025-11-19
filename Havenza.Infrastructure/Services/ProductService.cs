using Havenza.Application.DTO;
using Havenza.Application.Interfaces;
using Havenza.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Havenza.Infrastructure.Services
{
    public class ProductService : IProductService
    {
        // INJECT your DB context into ProductService
        private readonly HavenzaDbContext _context;
        public ProductService(HavenzaDbContext context)
        {
            _context = context;
        }

        public ProductResponse MapProductToResponse(Product product)
        {
            return new ProductResponse
            {
                ProductId = product.ProductId,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                CategoryId = product.CategoryId,
                ImageUrl = product.ImageUrl,
                Stock = product.Stock
            };
        }
        public async Task<List<ProductResponse>> GetAllProductsAsync()
        {
            var products = await _context.Products.Include(p => p.Category).ToListAsync();
            return products.Select(p => MapProductToResponse(p)).ToList();
        }

        public async Task<ProductResponse?> GetProductByIdAsync(int productId)
        {
            var product = await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(p => p.ProductId == productId);
            return product is null ? null : MapProductToResponse(product);
        }

    }
}
