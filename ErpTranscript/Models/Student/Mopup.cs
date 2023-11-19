﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("Mopup")]
    public partial class Mopup
    {
        [StringLength(50)]
        public string? Matricno { get; set; }
        [StringLength(150)]
        public string? Name { get; set; }
        [StringLength(50)]
        public string? Asession { get; set; }
        [StringLength(50)]
        public string? Semester { get; set; }
        [StringLength(50)]
        public string? Prog { get; set; }
        [StringLength(50)]
        public string? Slevel { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Cgpa { get; set; }
        [StringLength(250)]
        public string? Remark { get; set; }
        public int? Semid { get; set; }
        [Column("id")]
        public int Id { get; set; }
        [Column("programId")]
        [StringLength(200)]
        public string? ProgramId { get; set; }
    }
}
