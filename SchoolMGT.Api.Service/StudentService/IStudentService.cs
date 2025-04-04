﻿using SchoolMGT.Api.Domain.Models.clsStudent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMGT.Api.Service.StudentService
{
    public interface IStudentService
    {
        Task<List<StudentDTO>> GetAllStudents(string token);
        Task<StudentDTO> AddStudent(StudentDTO student);
        Task<Student> UpdateStudent(Student student);
        Task<StudentDTO> GetStudentById(long studentId);
    }
}
