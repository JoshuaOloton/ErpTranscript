using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.YabaResOnline
{
    [Keyless]
    [Table("Unflag")]
    public partial class Unflag
    {
        [StringLength(50)]
        public string? Appnum { get; set; }
    }
}
