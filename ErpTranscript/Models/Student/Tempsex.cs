using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("tempsex")]
    public partial class Tempsex
    {
        [Column("matricno")]
        [StringLength(50)]
        public string? Matricno { get; set; }
        [Column("sex")]
        [StringLength(50)]
        public string? Sex { get; set; }
    }
}
