using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    public partial class VwGradRequirement
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
        [StringLength(25)]
        public string? Session { get; set; }
        [StringLength(225)]
        [Unicode(false)]
        public string Semester { get; set; } = null!;
        [Column("LEVEL")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Level { get; set; }
        [StringLength(50)]
        public string? ProgrammeType { get; set; }
        [Column("program")]
        [StringLength(254)]
        public string? Program { get; set; }
        [Column("PTAcronym")]
        [StringLength(50)]
        [Unicode(false)]
        public string Ptacronym { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string PcAcronym { get; set; } = null!;
        [StringLength(50)]
        public string? EnterSessionset { get; set; }
        [StringLength(255)]
        public string? Coscode { get; set; }
        public string? CosTitle { get; set; }
        public int? Cosunit { get; set; }
        [StringLength(250)]
        public string? Studentprogram { get; set; }
        public int? Studentprogramid { get; set; }
        [Column("SchoolID")]
        public int SchoolId { get; set; }
        [StringLength(100)]
        public string? EntrySessionSet { get; set; }
    }
}
