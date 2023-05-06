using System;
using System.Collections.Generic;

namespace SchoolMGT.Api.Domain.Models.clsTeacher;

public partial class Teacher
{
    public long Id { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public DateTime? BirthDate { get; set; }

    public long? Age { get; set; }

    public clsEnums.Enums.Gender? Gender { get; set; }

    public string? Address { get; set; }
}
