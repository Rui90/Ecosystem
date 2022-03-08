using AutoMapper;
using Ecosystem.Core.Entitities.ViewModels.StoreRoomManager;
using StorageManagerService.Entities;

namespace StorageManagerService.Profiles
{
    public class ProductPriceMappingProfile : Profile
    {
        public ProductPriceMappingProfile()
        {
            CreateMap<ProductPriceViewModel, ProductPrices>()
                .ReverseMap();
        }
    }
}
