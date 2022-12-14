using System;
using System.Collections.Generic;

namespace nagyZH_gsqrbp.ModelsStudies;

public partial class Employement
{
    public string EmployementId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<Instructor> Instructors { get; } = new List<Instructor>();
}
