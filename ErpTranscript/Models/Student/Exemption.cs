using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("exemption")]
    public partial class Exemption
    {
        [Column("ExemptionID")]
        public int ExemptionId { get; set; }
        [StringLength(15)]
        [Unicode(false)]
        public string MatricNo { get; set; } = null!;
        public int Status { get; set; }
        public int E { get; set; }
        [Column("PA")]
        public int Pa { get; set; }
        public int R { get; set; }
        [Column("PE")]
        public int Pe { get; set; }
        [Column("A_SemesterID")]
        public int? ASemesterId { get; set; }
        [Column("A_SessionID")]
        public int? ASessionId { get; set; }
        [StringLength(225)]
        [Unicode(false)]
        public string Description { get; set; } = null!;
        [StringLength(30)]
        [Unicode(false)]
        public string InstructedBy { get; set; } = null!;
        [StringLength(10)]
        [Unicode(false)]
        public string DateInstructed { get; set; } = null!;
        [Column(TypeName = "date")]
        public DateTime DateCreated { get; set; }
        public TimeSpan TimeCreated { get; set; }
        [Column(TypeName = "date")]
        public DateTime DateOfLastUpdate { get; set; }
        public TimeSpan TimeOfLastUpdate { get; set; }
        public int UpdatedBy { get; set; }
        public int CreatedBy { get; set; }
    }
}
