using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("issues")]
    public partial class Issue
    {
        [StringLength(50)]
        public string? Matricno { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateIssue { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
