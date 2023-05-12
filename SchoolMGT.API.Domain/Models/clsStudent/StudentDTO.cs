using SchoolMGT.Api.Domain.clsEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SchoolMGT.Api.Domain.Models.clsStudent;

public class StudentDTO
{
    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Address { get; set; }

    public Enums.Gender? Gender { get; set; }

}
