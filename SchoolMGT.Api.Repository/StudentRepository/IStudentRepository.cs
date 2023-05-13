﻿using SchoolMGT.Api.Domain.Models.clsStudent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMGT.Api.Repository.StudentRepository
{
    public interface IStudentRepository
    {
        public Task<List<StudentDTO>> GetStudents();
        public Task<StudentDTO> AddStudent(StudentDTO student);
        public Task<Student> UpdateStudent(Student student);
    }
}
