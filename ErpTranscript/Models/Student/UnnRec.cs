using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("UnnRec")]
    public partial class UnnRec
    {
        [Column("matricno")]
        [StringLength(50)]
        public string? Matricno { get; set; }
        [Column("progid")]
        public int? Progid { get; set; }
    }
}
