using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Student_task_datatable.Models;
using Student_task_datatable.Repository.StudentRepository;

namespace Student_task_datatable.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository studentRepo;

        public StudentController(IStudentRepository studentRepo)
        {
            this.studentRepo = studentRepo;
        }

        [HttpPost]
        public async Task<IActionResult> GetAllStudents()
        {
            var pageSize = int.Parse(Request.Form["length"]);
            var skip = int.Parse(Request.Form["start"]);
            var searchValue = Request.Form["search[value]"];
            var sortColumn = Request.Form[string.Concat("columns[", Request.Form["order[0][column]"], "][name]")];
            var sortColumnDirection = Request.Form["order[0][dir]"];

            var students = await studentRepo.GetStudentsIQuerable(searchValue, sortColumn, sortColumnDirection);
                
            var data = await studentRepo.GetStudents(skip, pageSize, searchValue, sortColumn, sortColumnDirection);
            var recordsTotal = students.Count();
            var jsonData = new { recordsFiltered = recordsTotal, recordsTotal, data };
            return Ok(jsonData); 
        }
    }
}
