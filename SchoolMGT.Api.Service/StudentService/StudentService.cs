using AutoMapper;
using SchoolMGT.Api.Common;
using SchoolMGT.Api.Domain.Models.clsStudent;
using SchoolMGT.Api.Repository.StudentRepository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            try
            {
                return await _studentRepository.AddStudent(student);
            }
            catch (Exception)
            {

                throw;
            }
           
        }
        public async Task<Student> UpdateStudent(Student student)
        {
            try
            {
                return await _studentRepository.UpdateStudent(student);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<StudentDTO>> GetAllStudents(string token)
        {
            try
            {
                var validateToken = JwtManager.ValidateToken(token);
                var list = await _studentRepository.GetStudents();
                return list;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task<StudentDTO> GetStudentById(long studentId)
        {
            try
            {
                var student = await _studentRepository.GetStudentById(studentId);
                return student;
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
