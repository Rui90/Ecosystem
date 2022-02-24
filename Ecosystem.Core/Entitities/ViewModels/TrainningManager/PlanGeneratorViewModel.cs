using Core.Entitities.ViewModels.TrainningManager.Enumerables;
using System.ComponentModel.DataAnnotations;

public class PlanGeneratorViewModel
{

    [Required]
    public int TrainningPeriodInMinutes { get; set; }

    public BodyArea? Area { get; set; }

    public TrainningGoal? VideoGoal { get; set; }

}