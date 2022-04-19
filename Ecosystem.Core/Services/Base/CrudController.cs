using Ecosystem.Services.Base.Interfaces;
using Ecosystem.Shared.Entitities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Ecosystem.Services.Base
{
    [Route("[controller]")]
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
        public IActionResult Create([FromBody] T entity)
        {
            return Created(string.Empty, ViewService.Create(entity));
        }

        [HttpPut("{entityId:Guid}")]
        public IActionResult Update(Guid entityId, [FromBody] T entity)
        {
            return Ok(ViewService.Update(entityId, entity));
        }

        [HttpDelete("{entityId:Guid}")]
        public IActionResult Delete(Guid entityId)
        {
            ViewService.Delete(entityId);
            return Ok();
        }

        [HttpGet]
        public IActionResult FindAll(int currentPage = 0, int pageSize = 10)
        {
            return Ok(ViewService.GetAll(currentPage, pageSize));
        }

        [HttpGet("{entityId:Guid}")]
        public IActionResult GetById(Guid entityId)
        {
            return Ok(ViewService.GetById(entityId));
        }
    }
}
