namespace LearnigCentre.Common;

public class Auditable
{
    public long Id { get; set; }
    public DateTime CreatedDateTime{ get; set; }
    public DateTime UpdatedDateTime{ get; set; }
}