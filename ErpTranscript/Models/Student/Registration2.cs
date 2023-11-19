using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("registration2")]
    public partial class Registration2
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
    }
}
