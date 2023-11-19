using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("stetemp")]
    public partial class Stetemp
    {
        [StringLength(50)]
        [Unicode(false)]
        public string Matricno { get; set; } = null!;
        [StringLength(255)]
        [Unicode(false)]
        public string? Prog { get; set; }
        public int? ProgId { get; set; }
    }
}
