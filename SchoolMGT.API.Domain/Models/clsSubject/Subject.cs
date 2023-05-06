using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMGT.Api.Domain.Models.clsSubject
{
    public class Subject
    {
        public long Id { get; set; }
        public string SubjectCode { get; set; } = string.Empty; 
        public string SubjectName { get; set; } = string.Empty;
        public string SubjectDescription { get; set; } = string.Empty;
    }
}
