using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("PayLevel")]
    public partial class PayLevel
    {
        [StringLength(50)]
        public string? Matricnum { get; set; }
        [StringLength(250)]
        public string? Program { get; set; }
        [StringLength(150)]
        public string? School { get; set; }
        [StringLength(50)]
        public string? Slevel { get; set; }
        public int? Payflag { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
