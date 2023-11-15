using System;
using System.Collections.Generic;

namespace ESMSBusinessObject.Model;

public partial class SlotExam
{
    public int Id { get; set; }

    public string? Time { get; set; }

    public double? Hour { get; set; }

    public virtual ICollection<ExamSchedule> ExamSchedules { get; } = new List<ExamSchedule>();
}
