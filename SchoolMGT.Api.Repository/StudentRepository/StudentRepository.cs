using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SchoolMGT.Api.Domain.Models.clsStudent;
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
        public StudentRepository(RepositoryDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<Student> AddStudent(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
