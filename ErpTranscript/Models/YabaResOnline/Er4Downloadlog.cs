using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.YabaResOnline
{
    [Keyless]
    [Table("Er4Downloadlog")]
    public partial class Er4Downloadlog
    {
        [StringLength(150)]
        public string? Username { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateDownloaded { get; set; }
        [StringLength(50)]
        public string? Subdownloaded { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
