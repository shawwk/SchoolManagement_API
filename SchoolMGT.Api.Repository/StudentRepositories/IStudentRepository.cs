using SchoolMGT.Api.Domain.Models.clsStudent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMGT.Api.Repository.StudentRepository
{
    public interface IStudentRepository
    {
        Task<List<StudentDTO>> GetStudents();
        Task<StudentDTO> AddStudent(StudentDTO student);
        Task<Student> UpdateStudent(Student student);
        Task<StudentDTO> GetStudentById(long studentId);
        
    }
}
