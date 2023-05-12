using SchoolMGT.Api.Domain.clsEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SchoolMGT.Api.Domain.Models.clsStudent;

public  class Student
{
    [Key]
    public long Id { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Address { get; set; }

    public Enums.Gender? Gender { get; set; }

    public DateTime? BirthDate { get; set; }

    public int? Age { get; set; }
}
