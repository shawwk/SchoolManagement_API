using Microsoft.EntityFrameworkCore.Query.Internal;
using SchoolMGT.Api.Domain.Models.clsStudent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMGT.Api.Domain.Models.clsSection
{
    public class Section
    {
        public long Id { get; set; }
        public string SectionName { get; set; } = string.Empty;
        public string SectionDescription { get; set; } = string.Empty;

    }
}
