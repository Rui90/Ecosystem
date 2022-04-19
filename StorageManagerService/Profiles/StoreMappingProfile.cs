using AutoMapper;
using Ecosystem.Shared.Entitities.ViewModels.StoreRoomManager;
using StorageManagerService.Entities;

namespace StorageManagerService.Profiles
{
    public class StoreMappingProfile : Profile
    {
        public StoreMappingProfile()
        {
            CreateMap<StoreViewModel, Store>()
                .ReverseMap();
        }
    }
}
