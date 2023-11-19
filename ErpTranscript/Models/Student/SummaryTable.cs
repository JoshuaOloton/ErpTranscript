using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("summary_table")]
    public partial class SummaryTable
    {
        [Column("SummaryID")]
        public int SummaryId { get; set; }
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
        [Column("LastLevelID")]
        [StringLength(50)]
        [Unicode(false)]
        public string LastLevelId { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Remark { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string GraduationLevel { get; set; } = null!;
        [StringLength(10)]
        [Unicode(false)]
        public string ReviewDay { get; set; } = null!;
        [Column(TypeName = "date")]
        public DateTime DateCreated { get; set; }
        public TimeSpan TimeCreated { get; set; }
        [Column(TypeName = "date")]
        public DateTime DateOfLastUpdated { get; set; }
        public TimeSpan TimeOfLastUpdate { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}
