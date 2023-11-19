using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    public partial class VwResort
    {
        [StringLength(50)]
        public string? Matricno { get; set; }
        [StringLength(50)]
        public string? Subject { get; set; }
        public int? Score { get; set; }
        public int? Status { get; set; }
        [Column("id")]
        public int Id { get; set; }
        [Column("STAMP")]
        public int? Stamp { get; set; }
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
        [Column("sex")]
        [StringLength(50)]
        [Unicode(false)]
        public string Sex { get; set; } = null!;
        [Column("programme_type")]
        [StringLength(200)]
        [Unicode(false)]
        public string ProgrammeType { get; set; } = null!;
        [Column("programme")]
        [StringLength(200)]
        [Unicode(false)]
        public string Programme { get; set; } = null!;
        [Column("Real_Level")]
        [StringLength(50)]
        [Unicode(false)]
        public string? RealLevel { get; set; }
        [Column("ProgrammeID")]
        [StringLength(50)]
        [Unicode(false)]
        public string? ProgrammeId { get; set; }
        [Column("programme2")]
        [StringLength(225)]
        [Unicode(false)]
        public string Programme2 { get; set; } = null!;
        [StringLength(100)]
        public string? School { get; set; }
        [StringLength(225)]
        [Unicode(false)]
        public string Department { get; set; } = null!;
    }
}
