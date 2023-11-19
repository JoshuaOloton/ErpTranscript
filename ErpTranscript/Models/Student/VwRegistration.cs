using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    public partial class VwRegistration
    {
        [Column("A_SessionID")]
        [StringLength(50)]
        public string? ASessionId { get; set; }
        [Column("SemesterID")]
        [StringLength(50)]
        public string? SemesterId { get; set; }
        [StringLength(225)]
        public string? CourseCode { get; set; }
        public int? CourseId { get; set; }
        [StringLength(50)]
        public string? ContinuosAssesment { get; set; }
        [StringLength(50)]
        public string? Exam { get; set; }
        [StringLength(50)]
        public string? Score { get; set; }
        [StringLength(50)]
        public string? Grade { get; set; }
        [StringLength(50)]
        public string? CourseUnit { get; set; }
        [Column("ProgrammeID")]
        [StringLength(50)]
        public string? ProgrammeId { get; set; }
        [Column("LevelID")]
        [StringLength(50)]
        public string? LevelId { get; set; }
        [StringLength(50)]
        public string? MatricNo { get; set; }
        [Column("CPoint")]
        [StringLength(50)]
        public string? Cpoint { get; set; }
        [Column("SemID")]
        [StringLength(50)]
        public string? SemId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateCreated { get; set; }
        public TimeSpan? TimeCreated { get; set; }
        [Column("AStatus")]
        [StringLength(10)]
        public string? Astatus { get; set; }
        [Column("ProgrammeTypeID")]
        public int? ProgrammeTypeId { get; set; }
        [Column("ProgrammeID2")]
        public int? ProgrammeId2 { get; set; }
        public int? DeptId { get; set; }
        [Column("RegistrationID")]
        public int RegistrationId { get; set; }
        [Column("mdel")]
        public int? Mdel { get; set; }
        [Column("pubflag")]
        public int? Pubflag { get; set; }
        [Column("flexi")]
        public int? Flexi { get; set; }
        [StringLength(25)]
        public string? Session { get; set; }
        [StringLength(225)]
        [Unicode(false)]
        public string Semester { get; set; } = null!;
        [StringLength(50)]
        public string? ProgrammeType { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Level { get; set; }
        [StringLength(225)]
        [Unicode(false)]
        public string Department { get; set; } = null!;
        [Column("DepartmentID")]
        public int DepartmentId { get; set; }
        [StringLength(225)]
        [Unicode(false)]
        public string Programme { get; set; } = null!;
        [StringLength(255)]
        [Unicode(false)]
        public string? CourseTitle { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Tstatus { get; set; }
        [StringLength(100)]
        public string? School { get; set; }
        [Column("SchoolID")]
        public int SchoolId { get; set; }
        [Column("surname")]
        [StringLength(100)]
        [Unicode(false)]
        public string Surname { get; set; } = null!;
        [Column("firstname")]
        [StringLength(100)]
        [Unicode(false)]
        public string Firstname { get; set; } = null!;
        [Column("othername")]
        [StringLength(100)]
        [Unicode(false)]
        public string Othername { get; set; } = null!;
        [Column(TypeName = "date")]
        public DateTime? DateSubmitted2 { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateCreated2 { get; set; }
    }
}
