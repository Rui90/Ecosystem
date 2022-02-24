using AutoMapper;
using Core.Base.Implementations;
using Core.Base.Interfaces;
using Microsoft.EntityFrameworkCore;
using TrainningManagerService.Context;
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
            ApplicationDbContext dbContext,
            IVideoDomainService videoDomainService) : base(logger, mapper, dbContext)
        {
            _videoDomainService = videoDomainService;
        }

        public async Task<Plan> GeneratePlan(PlanGeneratorViewModel model)
        {

            var videos = await _videoDomainService.FilterVideos(model.TrainningPeriodInMinutes, model.VideoGoal, model.Area);
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
                DurationInSeconds = Convert.ToInt64(currentTrainningPeriod),
                Videos = finalListOfVideos
            };
        }
    }
}
