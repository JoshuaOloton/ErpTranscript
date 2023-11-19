using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("Errors1")]
    public partial class Errors1
    {
        [Column("appnum")]
        [StringLength(50)]
        public string? Appnum { get; set; }
        [Column("score")]
        public int? Score { get; set; }
    }
}
