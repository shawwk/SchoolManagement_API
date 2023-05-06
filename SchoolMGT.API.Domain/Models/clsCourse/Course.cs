using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMGT.Api.Domain.Models.clsCourse
{
    public class Course
    {
        public long Id { get; set; }
        public string CourseName { get; set; } = string.Empty;
        public string CourseDescription { get;set; } = string.Empty;
        public string ShortcutName { get; set; } = string.Empty;
    }
}
