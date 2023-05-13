using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using SchoolMGT.Api.Domain.Models.clsStudent;
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
        [HttpPost]
        [Route("Save")]
        public async Task<IActionResult> AddStudent([FromBody]StudentDTO student)
        {
            var AddStudent = await _studentService.AddStudent(student);
            return Ok(AddStudent);
        }
        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> UpdateStudent([FromBody]Student student)
        {
            var updateStudent = await _studentService.UpdateStudent(student);
            return Ok(updateStudent);
        }
        [HttpGet]
        [Route("GetStudents")]
        public async Task<IActionResult> GetStudent()
        {
            var students = await _studentService.GetAllStudents();
            if (students == null)
            {
                return NotFound();
            }
            return Ok(students);
        }
    }
}
