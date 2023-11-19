using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    public partial class VwOptionSplit
    {
        public int? Programmeid { get; set; }
        [Column("levelid")]
        public int? Levelid { get; set; }
        public int? Semesterid { get; set; }
        [Column("id")]
        public int Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Level { get; set; }
        [StringLength(225)]
        [Unicode(false)]
        public string Semester { get; set; } = null!;
    }
}
