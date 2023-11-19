using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("coursestemp")]
    public partial class Coursestemp
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("A_SessionID")]
        [StringLength(50)]
        [Unicode(false)]
        public string? ASessionId { get; set; }
        [Column("SemesterID")]
        [StringLength(50)]
        [Unicode(false)]
        public string? SemesterId { get; set; }
        [Column("ProgrammeTypeID")]
        [StringLength(50)]
        [Unicode(false)]
        public string? ProgrammeTypeId { get; set; }
        [Column("ProgrammeID")]
        [StringLength(50)]
        [Unicode(false)]
        public string? ProgrammeId { get; set; }
        [Column("LevelID")]
        [StringLength(50)]
        [Unicode(false)]
        public string? LevelId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? CourseCode { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? CourseTitle { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? CourseUnit { get; set; }
        [Column("CourseID")]
        [StringLength(225)]
        [Unicode(false)]
        public string? CourseId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? CourseStatus { get; set; }
        [Column("SemID")]
        [StringLength(50)]
        [Unicode(false)]
        public string? SemId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Tstatus { get; set; }
        [Column("AStatus")]
        [StringLength(20)]
        [Unicode(false)]
        public string? Astatus { get; set; }
        [Column("ID2")]
        public int? Id2 { get; set; }
    }
}
