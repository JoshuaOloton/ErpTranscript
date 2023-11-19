using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.YabaResOnline
{
    [Keyless]
    [Table("Putme2021ar")]
    public partial class Putme2021ar
    {
        [StringLength(50)]
        public string? Appnum { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? PutmeScores { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? OlevelScore { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? JambScore { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? AggScore { get; set; }
        [Column("id")]
        public int Id { get; set; }
        [Column("comment")]
        public string? Comment { get; set; }
        [Column("cancelled")]
        public int? Cancelled { get; set; }
    }
}
