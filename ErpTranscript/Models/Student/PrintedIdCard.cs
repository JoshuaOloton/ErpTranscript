using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("printedIdCard")]
    public partial class PrintedIdCard
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
    }
}
