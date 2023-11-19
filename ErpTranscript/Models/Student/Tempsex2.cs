using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("tempsex2")]
    public partial class Tempsex2
    {
        [StringLength(50)]
        public string Matricno { get; set; } = null!;
        [Column("sex")]
        [StringLength(50)]
        public string? Sex { get; set; }
        [StringLength(150)]
        public string? Dept { get; set; }
    }
}
