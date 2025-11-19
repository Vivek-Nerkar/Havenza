using Havenza.Application.DTO;
using Havenza.Application.Interfaces;
using Havenza.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Havenza.Infrastructure.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly HavenzaDbContext _context;
        public CategoryService(HavenzaDbContext context)
        {
            _context = context;
        }

        public CategoryResponse MapCategoryToResponse(Category category)
        {
            return new CategoryResponse
            {
                CategoryId = category.Id,
                Name = category.Name
            };
        }

        public async Task<List<CategoryResponse>> GetAllCategoriesAsync()
        {
            var categories = await _context.Categories.ToListAsync();
            return categories.Select(c => MapCategoryToResponse(c)).ToList();
        }

        public async Task<CategoryResponse?> GetCategoryByIdAsync(int categoryId)
        {
            var category = await _context.Categories.FirstOrDefaultAsync(c => c.Id == categoryId);
            return category is null ? null : MapCategoryToResponse(category);
        }
    }
}
