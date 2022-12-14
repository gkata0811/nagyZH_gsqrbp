using System;
using System.Collections.Generic;

namespace nagyZH_gsqrbp.ModelsStudies;

public partial class Time
{
    public byte TimeId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Lesson> Lessons { get; } = new List<Lesson>();
}
