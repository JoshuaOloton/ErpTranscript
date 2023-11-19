using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.YabaResOnline
{
    [Keyless]
    public partial class School
    {
        [Column("School")]
        [StringLength(150)]
        public string? School1 { get; set; }
        public int Schoolid { get; set; }
    }
}
