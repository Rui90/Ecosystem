using Core.Base.Interfaces;
using TrainningManagerService.Entities.Database;

namespace TrainningManagerService.DomainServices.Interfaces
{
    public interface IPlanDomainService : ICrudDomainService<Plan>
    {
        Task<Plan> GeneratePlan(PlanGeneratorViewModel model);
    }
}
