using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SchoolMGT.Api.Domain.Models.clsStudent;
using SchoolMGT.Api.Domain.Models.clsUser;
using SchoolMGT.Api.Repository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMGT.Api.Repository.StudentRepository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly RepositoryDbContext _dbContext;
        private readonly IMapper _mapper;
        public StudentRepository(RepositoryDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<StudentDTO> AddStudent(StudentDTO student)
        {
            var stud =  _mapper.Map<Student>(student);
            await _dbContext.Student.AddAsync(stud);
            await _dbContext.SaveChangesAsync();
            return student;
        }

        public async Task<StudentDTO> GetStudentById(long studentId)
        {
            try
            {
                var student = await _dbContext.Student.FindAsync(studentId);
                return _mapper.Map<StudentDTO>(student);
            }
            catch (Exception ex)
            {

                throw new Exception("Error :" + ex.Message);
            } 
        }

        public async Task<List<StudentDTO>> GetStudents()
        {
            var students = await _dbContext.Student.ToListAsync();
           return _mapper.Map<List<StudentDTO>>(students);
        }

        public async Task<Student> UpdateStudent(Student student)
        {
            await _dbContext.Student.AddAsync(student);
            _dbContext.Entry(student).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return student;
        }
    }
}
