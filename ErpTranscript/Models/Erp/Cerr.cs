using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Erp
{
    [Keyless]
    [Table("cerr")]
    public partial class Cerr
    {
        [Column("c1")]
        [StringLength(50)]
        public string? C1 { get; set; }
        [Column("c2")]
        [StringLength(50)]
        public string? C2 { get; set; }
        [Column("c3")]
        [StringLength(50)]
        public string? C3 { get; set; }
        [Column("c4")]
        [StringLength(50)]
        public string? C4 { get; set; }
        [Column("c5")]
        [StringLength(50)]
        public string? C5 { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
