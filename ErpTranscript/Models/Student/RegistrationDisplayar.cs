using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("registration_displayar")]
    public partial class RegistrationDisplayar
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
        [Column("DepartmentID")]
        public int? DepartmentId { get; set; }
        [StringLength(1)]
        [Unicode(false)]
        public string? SemesterStatus { get; set; }
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
        [Column("RegistrationDisplayarID")]
        public int RegistrationDisplayarId { get; set; }
        [StringLength(50)]
        public string? Updateby { get; set; }
    }
}
