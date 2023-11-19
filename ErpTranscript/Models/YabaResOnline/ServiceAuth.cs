using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.YabaResOnline
{
    [Keyless]
    [Table("ServiceAuth")]
    public partial class ServiceAuth
    {
        [StringLength(50)]
        public string? Userid { get; set; }
        [StringLength(50)]
        public string? Token { get; set; }
        [Column("id")]
        public int Id { get; set; }
        public int? Adminstatus { get; set; }
    }
}
