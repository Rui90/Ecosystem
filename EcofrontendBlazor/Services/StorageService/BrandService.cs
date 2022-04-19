using Ecosystem.Shared.Entitities;
using Ecosystem.Shared.Entitities.ViewModels.StoreRoomManager;
using Newtonsoft.Json;

namespace Ecofrontend.Services.StorageService
{
    public class BrandService : IBrandService
    {
        public async Task<PaginatedViewModel<BrandViewModel>> GetBrands()
        {
            var client = new HttpClient();
            var response = await client.GetAsync("https://localhost:44353/Brand?currentPage=0&pageSize=10");
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<PaginatedViewModel<BrandViewModel>>(await response.Content.ReadAsStringAsync());
            }
            return new PaginatedViewModel<BrandViewModel>(null, 0);
        }
    }
}
