using System;
using System.Collections.Generic;

namespace Individuellt_databasprojekt.Models;

public partial class TeacherCoursesView
{
    public int TeacherId { get; set; }

    public string? TeacherName { get; set; }

    public int CourseId { get; set; }

    public string? CourseName { get; set; }
}
