using Microsoft.EntityFrameworkCore;
using SchoolMGT.Api.Domain.Models.clsTeacher;
using SchoolMGT.Api.Domain.Models.clsStudent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolMGT.Api.Domain.Models.clsSection;
using SchoolMGT.Api.Domain.Models.clsCourse;
using SchoolMGT.Api.Domain.Models.clsEnrollment;
using SchoolMGT.Api.Domain.Models.clsUser;

namespace SchoolMGT.Api.Repository.Data
{
    public class RepositoryDbContext : DbContext
    {
        public RepositoryDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Student> Student { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<Section> Section { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Enrollment> Enrollment { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<UserAccount> UserAccounts2 { get; set; }
    }
}
