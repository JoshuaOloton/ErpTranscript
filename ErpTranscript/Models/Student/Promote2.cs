using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("Promote2")]
    public partial class Promote2
    {
        [StringLength(150)]
        public string? Matricno { get; set; }
        [Column("A_Sessionid")]
        public int? ASessionid { get; set; }
        public int? SemesterId { get; set; }
        public int? ProgrammeTypeid { get; set; }
        public int? Levelid { get; set; }
        [StringLength(250)]
        public string? Remark { get; set; }
        [StringLength(50)]
        public string? Gradlev { get; set; }
        public int? Progid { get; set; }
        public int Id { get; set; }
        [Column("status")]
        public int? Status { get; set; }
    }
}
