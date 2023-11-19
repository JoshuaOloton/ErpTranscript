using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("CVdumpsent")]
    public partial class Cvdumpsent
    {
        [StringLength(50)]
        public string? Appnum { get; set; }
        public int? Seating { get; set; }
        [Column("id")]
        public int? Id { get; set; }
    }
}
