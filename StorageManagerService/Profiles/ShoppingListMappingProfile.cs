using AutoMapper;
using Ecosystem.Core.Entitities.ViewModels.StoreRoomManager;
using StorageManagerService.Entities;

namespace StorageManagerService.Profiles
{
    public class ShoppingListMappingProfile : Profile
    {
        public ShoppingListMappingProfile()
        {
            CreateMap<ShoppingListViewModel, ShoppingList>()
                .ReverseMap();
        }
    }
}
