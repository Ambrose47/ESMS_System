using System;
using System.Collections.Generic;

namespace ESMSBusinessObject.Model;

public partial class ExamSchedule
{
    public int Id { get; set; }

    public string? Room { get; set; }

    public string? Lecturer { get; set; }

    public string? Course { get; set; }

    public int? Slotid { get; set; }

    public virtual SlotExam? Slot { get; set; }
}
