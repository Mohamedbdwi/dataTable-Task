using Student_task_datatable.Models;

namespace Student_task_datatable.Repository.StudentRepository
{
    public interface IStudentRepository
    {
        Task<IQueryable<Student>> GetStudentsIQuerable(string searchValue, string sortColumn, string sortColumnDirection);
        Task<List<Student>> GetStudents(int skip, int pageSize, string searchValue, string sortColumn, string sortColumnDirection);
    }
}
