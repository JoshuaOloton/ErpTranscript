using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("registration_copy")]
    public partial class RegistrationCopy
    {
        [Column("RegistrationID")]
        public int RegistrationId { get; set; }
        [Column("A_SessionID")]
        [StringLength(50)]
        [Unicode(false)]
        public string ASessionId { get; set; } = null!;
        [Column("SemesterID")]
        [StringLength(50)]
        [Unicode(false)]
        public string SemesterId { get; set; } = null!;
        [StringLength(225)]
        [Unicode(false)]
        public string CourseCode { get; set; } = null!;
        public int? CourseId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? ContinuosAssesment { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Exam { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Score { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Grade { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string CourseUnit { get; set; } = null!;
        [Column("ProgrammeID")]
        [StringLength(50)]
        [Unicode(false)]
        public string ProgrammeId { get; set; } = null!;
        [Column("LevelID")]
        [StringLength(50)]
        [Unicode(false)]
        public string LevelId { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string MatricNo { get; set; } = null!;
        [Column("CPoint")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Cpoint { get; set; }
        [Column("SemID")]
        [StringLength(50)]
        [Unicode(false)]
        public string? SemId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateCreated { get; set; }
        public TimeSpan? TimeCreated { get; set; }
        [Column("AStatus")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Astatus { get; set; }
        [Column("ProgrammeTypeID")]
        public int? ProgrammeTypeId { get; set; }
        [Column("ProgrammeID2")]
        public int? ProgrammeId2 { get; set; }
        public int? DeptId { get; set; }
    }
}
