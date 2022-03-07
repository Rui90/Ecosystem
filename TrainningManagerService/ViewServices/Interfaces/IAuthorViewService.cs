using Core.Base.Interfaces;
using Ecosystem.Core.Entitities.ViewModels.TrainningManager;
using TrainningManagerService.Entities.Database;

namespace TrainningManagerService.ViewServices.Interfaces
{
    public interface IAuthorViewService : ICrudViewService<AuthorViewModel, Video>
    {
    }
}
