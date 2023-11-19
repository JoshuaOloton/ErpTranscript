using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("otp")]
    public partial class Otp
    {
        [StringLength(50)]
        public string? Token { get; set; }
        public int? Status { get; set; }
        [StringLength(50)]
        public string? Matricno { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Dateused { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
