using Havenza.Core.Entities;
using System.Net.Http.Json;

namespace Havenza.Web.Client.Services
{
    public class CategoriesService
    {
        private readonly HttpClient _http;
        public CategoriesService(HttpClient http) { _http = http; }
        public async Task<List<Category>> GetCategoriesAsync()
        {
            return await _http.GetFromJsonAsync<List<Category>>("api/categories");
        }
    }
}
