using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using SchoolMGT.Api.Domain.Models.clsStudent;
using SchoolMGT.Api.Service.StudentService;

namespace SchoolMGT.Api.Controllers
{
    [Route("api/[controller]"), Authorize]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        [HttpPost, Route("v1/add")]
        public async Task<IActionResult> AddStudent([FromBody]StudentDTO student)
        {
            var AddStudent = await _studentService.AddStudent(student);
            return Ok(AddStudent);
        }
        [HttpPut, Route("v1/update")]
        public async Task<IActionResult> UpdateStudent([FromBody]Student student)
        {
            var updateStudent = await _studentService.UpdateStudent(student);
            return Ok(updateStudent);
        }
        [HttpGet, Route("v1/getStudents")]
        public async Task<IActionResult> GetStudent()
        {
            string token = "";
            var students = await _studentService.GetAllStudents(token);
            if (students == null)
            {
                return NotFound();
            }
            return Ok(students);
        }
        [HttpGet, Route("v1/getStudent/{studentId}")]
        public async Task<IActionResult> GetStudent(int studentId) 
        {
            var getStudent = await _studentService.GetStudentById(studentId);
            if(getStudent == null) 
                return NotFound();
            return Ok(getStudent);
        }
    }
}
