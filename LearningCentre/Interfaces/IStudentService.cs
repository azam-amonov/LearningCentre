using LearnigCentre.Models;

namespace LearnigCentre.Interfaces;

public interface IStudentService
{
    public void Create(Student student);
    public void Update(Student student);
    public void Delete(Student student);
    public void Get();
    public void GetById(long id);
}