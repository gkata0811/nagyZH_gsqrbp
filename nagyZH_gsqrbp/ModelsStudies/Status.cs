using System;
using System.Collections.Generic;

namespace nagyZH_gsqrbp.ModelsStudies;

public partial class Status
{
    public byte StatusId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Instructor> Instructors { get; } = new List<Instructor>();
}
