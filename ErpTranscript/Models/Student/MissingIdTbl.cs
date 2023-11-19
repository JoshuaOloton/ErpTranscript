using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("missingIdTbl")]
    public partial class MissingIdTbl
    {
        [Column("matricnum")]
        [StringLength(50)]
        [Unicode(false)]
        public string Matricnum { get; set; } = null!;
        [Column("programme")]
        [StringLength(200)]
        [Unicode(false)]
        public string Programme { get; set; } = null!;
        [Column("ProgrammeID")]
        [StringLength(50)]
        [Unicode(false)]
        public string? ProgrammeId { get; set; }
    }
}
