using Havenza.Application.DTO;
using Havenza.Application.Interfaces;
using Havenza.Core.Entities;
using Microsoft.EntityFrameworkCore;

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
            var products = await _context.Products.Include(p => p.CategoryName).ToListAsync();
            return products.Select(p => MapProductToResponse(p)).ToList();
        }

        public async Task<ProductResponse?> GetProductByIdAsync(int ProductId)
        {
            var product = await _context.Products.Include(p => p.CategoryName).FirstOrDefaultAsync(p => p.ProductId == ProductId);
            return product is null ? null : MapProductToResponse(product);
        }
    }
}
