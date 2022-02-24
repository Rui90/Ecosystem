using AutoMapper;
using Core.Base.Implementations;
using Core.Entitities;
using Core.Entitities.ViewModels.TrainningManager.Enumerables;
using Microsoft.EntityFrameworkCore;
using TrainningManagerService.Context;
using TrainningManagerService.DomainServices.Interfaces;
using TrainningManagerService.Entities.Database;

namespace TrainningManagerService.DomainServices.Implementations
{
    public class VideoDomainService : CrudDomainService<Video>, IVideoDomainService
    {
        private readonly ApplicationDbContext _dbContext; 

        public VideoDomainService(
            ILogger<IVideoDomainService> logger,
            IMapper mapper,
            ApplicationDbContext dbContext) : base(logger, mapper, dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<PaginatedViewModel<Video>> FilterVideos(long videoDuration, TrainningGoal? trainningGoal, BodyArea? bodyArea)
        {
            var query = _dbContext.Videos.Where(x => x.DurationInSeconds / 60 > videoDuration);
            if (bodyArea.HasValue)
            {
                query = query.Where(x => x.Area == bodyArea);
            }
            if (trainningGoal.HasValue)
            {
                query = query.Where(x => x.VideoGoal == trainningGoal);
            }
            var videosCounter = await query.CountAsync();
            var videos = await query.ToListAsync();
            return new PaginatedViewModel<Video>(videos, videosCounter);
        }
    }
}
