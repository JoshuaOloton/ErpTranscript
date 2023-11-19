using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.YabaResOnline
{
    [Keyless]
    [Table("UtmeflagApril")]
    public partial class UtmeflagApril
    {
        [StringLength(50)]
        public string? Appnum { get; set; }
        public string? ProctorComment { get; set; }
        public string? CandComment { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
