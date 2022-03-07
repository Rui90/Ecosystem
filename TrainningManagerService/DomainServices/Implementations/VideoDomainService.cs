using AutoMapper;
using Core.Base.Implementations;
using Core.Entitities;
using Core.Entitities.ViewModels.TrainningManager.Enumerables;
using Ecosystem.Core.Base.Extensions;
using Ecosystem.Core.Base.Interfaces;
using Microsoft.EntityFrameworkCore;
using TrainningManagerService.Context;
using TrainningManagerService.DomainServices.Interfaces;
using TrainningManagerService.Entities.Database;

namespace TrainningManagerService.DomainServices.Implementations
{
    public class VideoDomainService : CrudDomainService<Video>, IVideoDomainService
    {
        public VideoDomainService(
            ILogger<IVideoDomainService> logger,
            IMapper mapper,
            IRepository<Video> repository) : base(logger, mapper, repository)
        {
        }

        public async Task<PaginatedViewModel<Video>> FilterVideos(string? search, long? maxVideoDuration, TrainningGoal? trainningGoal, BodyArea? bodyArea)
        {
            var query = CommonSearchCriteria(search, bodyArea, trainningGoal);            
            if(maxVideoDuration.HasValue)
            {
                query = query.Where(x => x.DurationInSeconds / 60 <= maxVideoDuration);
            }
            var videosCounter = await query.CountAsync();
            var videos = await query.ToListAsync();
            return new PaginatedViewModel<Video>(videos, videosCounter);
        }

        public async Task<Video> GetRandomVideo(string? search,
            BodyArea? bodyArea,
            TrainningGoal? trainningGoal,
            long? maxDuration,
            long? minDuration)
        {
            var query = CommonSearchCriteria(search, bodyArea, trainningGoal);

            if (maxDuration.HasValue)
            {
                query = query.Where(x => x.DurationInSeconds / 60 <= maxDuration);
            }
            if (minDuration.HasValue)
            {
                query = query.Where(x => x.DurationInSeconds / 60 >= minDuration);
            }
            var video = await query.FirstOrDefaultAsync();
            if (video != null)
            {
                return video;
            }
            return new Video();
        }

        private IQueryable<Video> CommonSearchCriteria(string? search,
            BodyArea? bodyArea,
            TrainningGoal? trainningGoal)
        {
            var query = _repository.GetQueryable(x => x.Author).AsQueryable();
            if (bodyArea.HasValue)
            {
                query = query.Where(x => x.Area == bodyArea);
            }
            if (trainningGoal.HasValue)
            {
                query = query.Where(x => x.VideoGoal == trainningGoal);
            }
            if (!string.IsNullOrWhiteSpace(search))
            {
                query = query.Where(x => x.Name.ToLower().Contains(search.ToLower()) 
                || x.Author.Name.ToLower().Contains(search.ToLower()));
            }
            return query;
        }
    }
}
