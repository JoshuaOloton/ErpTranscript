using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("registration_display_copy")]
    public partial class RegistrationDisplayCopy
    {
        [StringLength(15)]
        [Unicode(false)]
        public string MatricNo { get; set; } = null!;
        [Column("A_SessionID")]
        [StringLength(50)]
        [Unicode(false)]
        public string ASessionId { get; set; } = null!;
        [Column("SemesterID")]
        [StringLength(50)]
        [Unicode(false)]
        public string SemesterId { get; set; } = null!;
        [Column("ProgrammeTypeID")]
        [StringLength(50)]
        [Unicode(false)]
        public string ProgrammeTypeId { get; set; } = null!;
        [Column("LevelID")]
        [StringLength(50)]
        [Unicode(false)]
        public string LevelId { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Status { get; set; } = null!;
        public int? UnlockCount { get; set; }
        [Column("TU")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Tu { get; set; }
        [Column("WGPA")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Wgpa { get; set; }
        [Column("GPA")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Gpa { get; set; }
        [Column("CTU")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Ctu { get; set; }
        [Column("CTUIP")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Ctuip { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Cgpa { get; set; }
        [StringLength(225)]
        [Unicode(false)]
        public string? Remark { get; set; }
        [Column("DepartmentID")]
        public int? DepartmentId { get; set; }
        [Column("CTUP")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Ctup { get; set; }
        [Column("SemID")]
        [StringLength(50)]
        [Unicode(false)]
        public string? SemId { get; set; }
        [StringLength(1)]
        [Unicode(false)]
        public string? SemesterStatus { get; set; }
        [Column("GradeLevelID")]
        public int? GradeLevelId { get; set; }
        public TimeSpan? TimeCreated { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateCreated { get; set; }
        public TimeSpan? TimeSubmitted { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateSubmitted { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? Astatus { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? SchoolId { get; set; }
        [Column("ProgrammeID")]
        public int? ProgrammeId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? Docketid { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? Seriano { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? DocketSerialHash { get; set; }
        public int? IsCleared { get; set; }
        [Column("RegistrationDisplayID")]
        public int RegistrationDisplayId { get; set; }
    }
}
