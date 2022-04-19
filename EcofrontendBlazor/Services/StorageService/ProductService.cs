using Ecosystem.Shared.Entitities;
using Ecosystem.Shared.Entitities.ViewModels.StoreRoomManager;
using Newtonsoft.Json;
using System.Net.Http;

namespace Ecofrontend.Services.StorageService
{
    public class ProductService : IProductService
    {
        public ProductService()
        {
        }

        public async Task<PaginatedViewModel<ProductViewModel>> GetProducts() {
            var client = new HttpClient();
            var response = await client.GetAsync("https://localhost:44353/Product?currentPage=0&pageSize=10");
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<PaginatedViewModel<ProductViewModel>>(await response.Content.ReadAsStringAsync());
            }
            return new PaginatedViewModel<ProductViewModel>(null, 0);
        }
    }
}
