﻿using System;
using System.Collections.Generic;

namespace nagyZH_gsqrbp.ModelsStudies;

public partial class Day
{
    public byte DayId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Lesson> Lessons { get; } = new List<Lesson>();
}
