using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("Extrafee")]
    public partial class Extrafee
    {
        [Column("RRR")]
        [StringLength(150)]
        public string? Rrr { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Amount { get; set; }
        [StringLength(50)]
        public string? Matricno { get; set; }
        [Column("PaymentID")]
        public int? PaymentId { get; set; }
        [Column("id")]
        public int Id { get; set; }
        [StringLength(50)]
        public string? PaymentDescrip { get; set; }
    }
}
