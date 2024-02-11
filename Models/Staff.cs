using System;
using System.Collections.Generic;

namespace Individuellt_databasprojekt.Models;

public partial class Staff
{
    public int StaffId { get; set; }

    public string? Fname { get; set; }

    public string? Lname { get; set; }

    public string? Position { get; set; }

    public DateOnly? StartDate { get; set; }

    public decimal? Salary { get; set; }

    public string? Department { get; set; }

    public int? DepartmentId { get; set; }

    public virtual ICollection<Grade> Grades { get; set; } = new List<Grade>();
}
