using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.YabaResOnline
{
    [Keyless]
    [Table("Partflag")]
    public partial class Partflag
    {
        [StringLength(50)]
        public string? Appnum { get; set; }
        public string? Reason { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
