using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    public partial class VwPrintedIdCard1
    {
        [Column("matricnum")]
        [StringLength(50)]
        public string? Matricnum { get; set; }
        [Column("status")]
        [StringLength(50)]
        public string? Status { get; set; }
        [Column("date", TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Column("sn")]
        public int Sn { get; set; }
        [Column("program")]
        [StringLength(154)]
        [Unicode(false)]
        public string Program { get; set; } = null!;
        [Column("ProgramID")]
        public int? ProgramId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Surname { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Firstname { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Othername { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string SchoolName { get; set; } = null!;
        [StringLength(10)]
        [Unicode(false)]
        public string Sex { get; set; } = null!;
        [StringLength(200)]
        [Unicode(false)]
        public string? Email { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? Phone { get; set; }
        [Column("PNName")]
        [StringLength(50)]
        [Unicode(false)]
        public string Pnname { get; set; } = null!;
        [Column("Real_Level")]
        [StringLength(50)]
        [Unicode(false)]
        public string? RealLevel { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string EntrySession { get; set; } = null!;
        [Column("EntrySessionID")]
        public int? EntrySessionId { get; set; }
    }
}
