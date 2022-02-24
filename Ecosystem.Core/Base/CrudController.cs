using Core.Base.Interfaces;
using Core.Entitities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Core.Base
{
    public class CrudController<T, K> : ControllerBase
        where T : IViewModel
        where K : class, IEntity

    {
        public readonly ILogger<CrudController<T, K>> Logger;
        public readonly ICrudViewService<T, K> ViewService;

        public CrudController(
            ILogger<CrudController<T, K>> logger,
            ICrudViewService<T, K> viewService)
        {
            Logger = logger;
            ViewService = viewService;
        }


        [HttpPost]
        public async Task<IActionResult> Create(T entity)
        {
            return Created(string.Empty, await ViewService.Create(entity));
        }

        [HttpPut("{entityId:Guid}")]
        public async Task<IActionResult> Update(Guid entityId, T entity)
        {
            return Ok(await ViewService.Update(entityId, entity));
        }

        [HttpDelete("{entityId:Guid}")]
        public async Task<IActionResult> Delete(Guid entityId)
        {
            await ViewService.Delete(entityId);
            return Ok();
        }

        [HttpGet]
        public IActionResult FindAll(int currentPage = 0, int pageSize = 10)
        {
            return Ok(ViewService.GetAll(currentPage, pageSize));
        }
    }
}
