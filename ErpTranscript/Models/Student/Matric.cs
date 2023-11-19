using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    public partial class Matric
    {
        [StringLength(50)]
        public string? Appnum { get; set; }
        public int? ProgramId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Dategen { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
