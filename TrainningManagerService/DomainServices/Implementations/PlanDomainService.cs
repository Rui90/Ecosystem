using AutoMapper;
using Core.Base.Implementations;
using Ecosystem.Core.Base.Interfaces;
using TrainningManagerService.DomainServices.Interfaces;
using TrainningManagerService.Entities.Database;

namespace TrainningManagerService.DomainServices.Implementations
{

    public class PlanDomainService : CrudDomainService<Plan>, IPlanDomainService
    {

        private readonly IVideoDomainService _videoDomainService;

        public PlanDomainService(
            ILogger<IPlanDomainService> logger, 
            IMapper mapper, 
            IRepository<Plan> repository,
            IVideoDomainService videoDomainService) : base(logger, mapper, repository)
        {
            _videoDomainService = videoDomainService;
        }

        public async Task<Plan> GeneratePlan(PlanGeneratorViewModel model)
        {

            var videos = await _videoDomainService.FilterVideos(null, model.TrainningPeriodInMinutes, model.VideoGoal, model.Area);
            var videosCopy = videos.Entries.ToList();
            var finalListOfVideos = new List<Video>();
            var currentTrainningPeriod = 0.00;
            var finished = false;
            var indexes = new List<int>();
            while (!finished)
            {
                var random = new Random();
                int[] values = Enumerable.Range(0, videos.TotalEntries - 1).Where(x => !indexes.Contains(x)).ToArray();
                var number = random.Next(values.Count());
                indexes.Add(number);
                var video = videos.Entries.ElementAt(number);
                var planDuration = currentTrainningPeriod + video.DurationInSeconds / 60;
                if (planDuration <= model.TrainningPeriodInMinutes)
                {
                    finalListOfVideos.Add(video);
                    videosCopy.Remove(video);
                    currentTrainningPeriod = planDuration;
                    finished = currentTrainningPeriod == model.TrainningPeriodInMinutes ||
                        videos.TotalEntries == indexes.Count() ||
                        !videosCopy.Any(x => x.DurationInSeconds / 60 < currentTrainningPeriod);
                }
            }

            return new Plan
            {
                Name = "GeneratedPlan",
                CreatedAt = DateTime.UtcNow,
                Videos = finalListOfVideos
            };
        }

        public async Task<bool> AddVideoToPlan(Guid planId, Guid videoId)
        {
            try
            {
                var video = _videoDomainService.GetById(videoId);
                var plan = GetById(planId, include => include.Videos);
                if (video != null && plan != null)
                {
                    if (plan.Videos != null)
                    {
                        plan.Videos.Add(video);
                    } else
                    {
                        plan.Videos = new List<Video> { video };
                    }
                    base.Update(plan.Id, plan);
                }
                return true;
            } catch(Exception ex)
            {
                throw;
            }

        }
    }
}
