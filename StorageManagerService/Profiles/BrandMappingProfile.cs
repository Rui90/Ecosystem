using AutoMapper;
using Ecosystem.Shared.Entitities.ViewModels.StoreRoomManager;
using StorageManagerService.Entities;

namespace StorageManagerService.Profiles
{
    public class BrandMappingProfile : Profile
    {
        public BrandMappingProfile()
        {
            CreateMap<BrandViewModel, Brand>()
                .ReverseMap();
        }
    }
}
