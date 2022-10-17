using Microsoft.AspNetCore.Http.Features;
using Microsoft.EntityFrameworkCore;
using Student_task_datatable.Models;
using System.Drawing.Printing;
using System.Linq.Dynamic.Core;

namespace Student_task_datatable.Repository.StudentRepository
{
    public class StudentRepository: IStudentRepository
    {
        private readonly StudentDbContext _context;

        public StudentRepository(StudentDbContext db)
        {
            _context = db;
        }

        public async Task<IQueryable<Student>> GetStudentsIQuerable(string searchValue, string sortColumn, string sortColumnDirection)
        {
            IQueryable<Student> students = _context.students.Where(m => string.IsNullOrEmpty(searchValue) 
            ?true
            : (m.Year_class.Contains(searchValue)));

            if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)))

            { students = students.OrderBy(string.Concat(sortColumn, " ", sortColumnDirection)); }


            return students;
        }

        public async Task<List<Student>> GetStudents(int skip, int pageSize, string searchValue, string sortColumn, string sortColumnDirection)
        {
            var students = await GetStudentsIQuerable(searchValue, sortColumn, sortColumnDirection);
            var data = await students.Skip(skip).Take(pageSize).ToListAsync();
            return data;
        }
    }
}
