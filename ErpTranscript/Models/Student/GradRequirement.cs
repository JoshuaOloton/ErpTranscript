using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("GradRequirement")]
    [Index("Semid", "ProgrammeId", "ProgrammeTypeId", "ASessionId", "SemesterId", "LevelId", Name = "GradRequirementIdx")]
    public partial class GradRequirement
    {
        [Column("A_SessionID")]
        public int? ASessionId { get; set; }
        [Column("SemesterID")]
        public int? SemesterId { get; set; }
        [Column("LevelID")]
        public int? LevelId { get; set; }
        public int? Semid { get; set; }
        [Column("ProgrammeTypeID")]
        public int? ProgrammeTypeId { get; set; }
        [Column("ProgrammeID")]
        public int? ProgrammeId { get; set; }
        public int? CosBaseid { get; set; }
        [Column("CStatus")]
        [StringLength(20)]
        public string? Cstatus { get; set; }
        public int? SubmissionStatus { get; set; }
        public int? Setid { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
