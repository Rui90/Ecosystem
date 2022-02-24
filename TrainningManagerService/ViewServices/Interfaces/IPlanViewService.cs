using Core.Base.Interfaces;
using Core.Entitities.ViewModels.TrainningManager;
using TrainningManagerService.Entities.Database;

namespace TrainningManagerService.ViewServices.Interfaces
{
    public interface IPlanViewService : ICrudViewService<PlanViewModel, Plan>
    {
        Task<PlanViewModel> GeneratePlan(PlanGeneratorViewModel model);

    }
}
