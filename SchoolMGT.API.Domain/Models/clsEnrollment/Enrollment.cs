using SchoolMGT.Api.Domain.Models.clsCourse;
using SchoolMGT.Api.Domain.Models.clsStudent;
using SchoolMGT.Api.Domain.Models.clsSubject;
using SchoolMGT.Api.Domain.Models.clsTeacher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMGT.Api.Domain.Models.clsEnrollment
{
    public class Enrollment
    {
        public int Id { get; set; }
        public long StudentId { get; set; }
        public long TeacherId { get; set; }
        public long CourseId { get; set;}
        public virtual ICollection<Subject> Subjects { get; set; } = new HashSet<Subject>();
        public virtual Student Student { get; set; } 
        public virtual Teacher Teacher { get; set; }
        public virtual Course Course { get; set; }
    }
}
