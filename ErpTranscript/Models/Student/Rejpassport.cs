using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("rejpassport")]
    public partial class Rejpassport
    {
        [Column("matricno")]
        [StringLength(50)]
        public string Matricno { get; set; } = null!;
        [Column("phonenum")]
        [StringLength(50)]
        public string? Phonenum { get; set; }
        [Column("matricnoreal")]
        [StringLength(50)]
        public string? Matricnoreal { get; set; }
        [StringLength(100)]
        public string? Fullpath { get; set; }
    }
}
