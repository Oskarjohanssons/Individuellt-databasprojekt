using System;
using System.Collections.Generic;

namespace Individuellt_databasprojekt.Models;

public partial class StudentGradeInfo
{
    public string StudentName { get; set; } = null!;

    public string? Class { get; set; }

    public string? CourseName { get; set; }

    public string TeacherName { get; set; } = null!;

    public string? Grade { get; set; }

    public DateOnly? GradeDate { get; set; }
}
