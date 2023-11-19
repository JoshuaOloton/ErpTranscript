using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.YabaResOnline
{
    [Keyless]
    [Table("GradeTab")]
    public partial class GradeTab
    {
        [StringLength(50)]
        [Unicode(false)]
        public string Grade { get; set; } = null!;
        public int? MinScore { get; set; }
        public int? MaxScore { get; set; }
        [Column("GPoint", TypeName = "decimal(18, 2)")]
        public decimal? Gpoint { get; set; }
    }
}
