using AutoMapper;
using Core.Base.Implementations;
using Core.Entitities.ViewModels.TrainningManager;
using TrainningManagerService.DomainServices.Interfaces;
using TrainningManagerService.Entities.Database;
using TrainningManagerService.ViewServices.Interfaces;

namespace TrainningManagerService.ViewServices.Implementations
{
    public class PlanViewService : CrudViewService<PlanViewModel, Plan>, IPlanViewService
    {

        private readonly IPlanDomainService _domainService;
        public PlanViewService(
            ILogger<IPlanViewService> logger, 
            IMapper mapper,
            IPlanDomainService domainService) : base(logger, mapper, domainService)
        {
            _domainService = domainService;
        }

        public async Task<bool> AddVideoToPlan(Guid planId, Guid videoId)
        {
            return await _domainService.AddVideoToPlan(planId, videoId);
        }

        public async Task<PlanViewModel> GeneratePlan(PlanGeneratorViewModel model)
        {
            return Mapper.Map<PlanViewModel>(await _domainService.GeneratePlan(model));
        }

        public override PlanViewModel GetById(Guid planId) {
            var plan = Mapper.Map<PlanViewModel>(_domainService.GetById(planId, x => x.Videos));
            plan.Duration = plan.Videos.Select(x => x.DurationInSeconds).Sum() / 60;
            return plan;
        }

    }
}
