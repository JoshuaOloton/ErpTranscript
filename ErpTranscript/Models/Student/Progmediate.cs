using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("progmediate")]
    public partial class Progmediate
    {
        [StringLength(100)]
        public string? Ebprog { get; set; }
        [StringLength(100)]
        public string? Regprog { get; set; }
        public int? Deptid { get; set; }
        public int? Progid { get; set; }
        [Column("schoolid")]
        public int? Schoolid { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
