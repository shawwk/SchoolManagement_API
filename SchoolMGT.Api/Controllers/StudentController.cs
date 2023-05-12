using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using SchoolMGT.Api.Service.StudentService;

namespace SchoolMGT.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        [HttpGet]
        [Route("GetStudents")]
        public async Task<IActionResult> GetStudents()
        {
            var students = await _studentService.GetAllStudents();
            if(students == null)
            {
                return NotFound();
            }
            return Ok(students);
        }
        [HttpGet]
        [Route("GetStudent")]
        public async Task<IActionResult> GetStudent()
        {
            var students = await _studentService.AddStudent(new Domain.Models.clsStudent.StudentDTO());
            if (students == null)
            {
                return NotFound();
            }
            return Ok(students);
        }
    }
}
