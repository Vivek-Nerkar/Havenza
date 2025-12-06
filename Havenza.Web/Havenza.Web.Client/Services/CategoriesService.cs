using Havenza.Core.Entities;
using Havenza.Web.Client.Models;
using System.Net.Http.Json;

namespace Havenza.Web.Client.Services
{
    public class CategoriesService
    {
        public readonly HttpClient _http;
        public CategoriesService(HttpClient http) { _http = http; }
        public async Task<List<CategoryDto>> GetCategoriesAsync()
        {
            var res = await _http.GetFromJsonAsync<List<CategoryDto>>("http://localhost:5030/api/categories");
            return res ?? new List<CategoryDto>();
        }
    }
}
