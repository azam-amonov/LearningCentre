using LearnigCentre.Common;
namespace LearningCentre.Models;

public class Payment: Auditable
{
    public long UserId { get; set; }
    public decimal Amount { get; set; }
}