using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.YabaResOnline
{
    [Keyless]
    [Table("Exam_programme_type")]
    public partial class ExamProgrammeType
    {
        [Column("ProgrammeTypeID")]
        public int ProgrammeTypeId { get; set; }
        [StringLength(50)]
        public string? ProgrammeType { get; set; }
        public int? Asessionid { get; set; }
        public int? Semesterid { get; set; }
    }
}
