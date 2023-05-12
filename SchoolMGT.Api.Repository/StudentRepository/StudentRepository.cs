using AutoMapper;
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
        private readonly IMapper _mapper;
        public StudentRepository(RepositoryDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<StudentDTO> AddStudent()
        {
            var students = await _dbContext.Student.FirstOrDefaultAsync(x => x.Id == 1);
            return _mapper.Map<StudentDTO>(students);
        }

        public async Task<List<StudentDTO>> GetStudents()
        {
            var students = await _dbContext.Student.ToListAsync();
           return _mapper.Map<List<StudentDTO>>(students);
        }
    }
}
