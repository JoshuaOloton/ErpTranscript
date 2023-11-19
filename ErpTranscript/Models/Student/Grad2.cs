using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("grad2")]
    public partial class Grad2
    {
        [Column("matricno")]
        [StringLength(50)]
        public string? Matricno { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? Cgpa { get; set; }
        [StringLength(50)]
        public string? Gradlev { get; set; }
        [StringLength(50)]
        public string? Phone { get; set; }
        [StringLength(240)]
        public string? Dept { get; set; }
        [Column("ESession")]
        [StringLength(50)]
        public string? Esession { get; set; }
        [StringLength(50)]
        public string? Prog { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
