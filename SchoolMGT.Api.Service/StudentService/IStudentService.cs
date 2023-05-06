using SchoolMGT.Api.Domain.Models.clsStudent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMGT.Api.Service.StudentService
{
    public interface IStudentService
    {
        Task<List<Student>> GetAllStudents();
    }
}
