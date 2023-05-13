﻿using AutoMapper;
using SchoolMGT.Api.Domain.Models.clsStudent;
using SchoolMGT.Api.Repository.StudentRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SchoolMGT.Api.Service.StudentService
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<StudentDTO> AddStudent(StudentDTO student)
        {
            return await _studentRepository.AddStudent(student);
        }
        public async Task<Student> UpdateStudent(Student student)
        {
            return await _studentRepository.UpdateStudent(student);
        }

        public async Task<List<StudentDTO>> GetAllStudents()
        {
            var list = await _studentRepository.GetStudents();
            return list;
        }
    }
}
