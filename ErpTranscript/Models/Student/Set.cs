using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Index("SessionName", Name = "Setidx")]
    public partial class Set
    {
        [StringLength(50)]
        public string? SessionName { get; set; }
        [Key]
        public int Setid { get; set; }
        public int? CurrentSet { get; set; }
    }
}
