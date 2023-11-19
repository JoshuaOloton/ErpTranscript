using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("gradsummary")]
    public partial class Gradsummary
    {
        [StringLength(50)]
        public string? Matricno { get; set; }
        public double? Cgpa { get; set; }
        [StringLength(50)]
        public string? Gradlev { get; set; }
        [StringLength(250)]
        public string? Remark { get; set; }
        [StringLength(50)]
        public string? Asession { get; set; }
        [StringLength(50)]
        public string? Semester { get; set; }
        [StringLength(50)]
        public string? Slevel { get; set; }
        [StringLength(150)]
        public string? Dept { get; set; }
        [Column("school")]
        [StringLength(50)]
        public string? School { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
