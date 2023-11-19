using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.YabaResOnline
{
    [Keyless]
    [Table("FL_Exam_semester")]
    public partial class FlExamSemester
    {
        [StringLength(50)]
        public string? Semester { get; set; }
        public int? Semesterid { get; set; }
        public int? Status { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Datecreated { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Dateupdated { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
