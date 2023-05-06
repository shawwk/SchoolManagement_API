using SchoolMGT.Api.Domain.clsEnums;
using System;
using System.Collections.Generic;

namespace SchoolMGT.Api.Domain.Models.clsStudent;

public partial class Student
{
    public long Id { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Address { get; set; }

    public Enums.Gender? Gender { get; set; }

    public DateTime? BirthDate { get; set; }

    public int? Age { get; set; }
}
