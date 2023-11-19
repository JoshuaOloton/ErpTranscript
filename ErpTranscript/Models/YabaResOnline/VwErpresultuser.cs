using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.YabaResOnline
{
    [Keyless]
    public partial class VwErpresultuser
    {
        [StringLength(50)]
        public string? Userid { get; set; }
        [StringLength(50)]
        public string? Password { get; set; }
        public int? Upriv { get; set; }
        [Column("id")]
        public int Id { get; set; }
        [StringLength(150)]
        public string? Uname { get; set; }
        [Column("staffid")]
        [StringLength(50)]
        public string? Staffid { get; set; }
    }
}
