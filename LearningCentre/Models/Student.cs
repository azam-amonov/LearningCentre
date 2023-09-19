using LearnigCentre.Common;

namespace LearnigCentre.Models;

public class Student: Auditable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Subject Subject { get; set; }
    public string Email { get; set; }
    
}