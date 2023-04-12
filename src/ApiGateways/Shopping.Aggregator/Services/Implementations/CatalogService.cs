using Shopping.Aggregator.Extensions;
using Shopping.Aggregator.Models;
using Shopping.Aggregator.Services.Interfaces;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
namespace Shopping.Aggregator.Services.Implementations
{
    public class CatalogService : ICatalogService
    {
        private readonly HttpClient _client;
        public CatalogService(HttpClient client)
        {
            _client = client;
        }

        public async Task<IEnumerable<CatalogModel>> GetCatalog()
        {
            var responese = await _client.GetAsync("/api/v1/catalog");
            return await responese.ReadContentAs<List<CatalogModel>>();
        }
        public async Task<CatalogModel> GetCatalog(string id)
        {
            var responese = await _client.GetAsync($"/api/v1/catalog/{id}");
            return await responese.ReadContentAs<CatalogModel>();
        }
        public async Task<IEnumerable<CatalogModel>> GetCatalogByCategory(string category)
        {
            var response = await _client.GetAsync($"/api/v1/Catalog/GetProductByCategory/{category}");
            return await response.ReadContentAs<List<CatalogModel>>();
        }
    }
}