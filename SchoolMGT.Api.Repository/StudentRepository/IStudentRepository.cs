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
        public Task<Student> AddStudent(Student student);
    }
}
