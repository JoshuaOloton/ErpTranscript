using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.YabaResOnline
{
    [Keyless]
    public partial class Supre
    {
        [StringLength(50)]
        public string? Appnum { get; set; }
        [Column("score", TypeName = "decimal(18, 2)")]
        public decimal? Score { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
