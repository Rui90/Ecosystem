﻿using Core.Base;
using Core.Entitities.ViewModels.TrainningManager;
using Microsoft.AspNetCore.Mvc;
using TrainningManagerService.Entities.Database;
using TrainningManagerService.ViewServices.Interfaces;

namespace TrainningManagerService.Controllers
{
    public class PlanController : CrudController<PlanViewModel, Plan>
    {

        private readonly IPlanViewService _planViewService;

        public PlanController(
            ILogger<PlanController> logger,
            IPlanViewService viewService) : base(logger, viewService)
        {
            _planViewService = viewService;
        }

        [HttpPost("generate")]
        public IActionResult GeneratePlan(PlanGeneratorViewModel model)
        {
            return Ok(_planViewService.GeneratePlan(model));
        }
    }
}
