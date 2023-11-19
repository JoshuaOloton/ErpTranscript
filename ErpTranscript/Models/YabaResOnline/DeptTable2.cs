using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.YabaResOnline
{
    [Keyless]
    [Table("DeptTable2")]
    public partial class DeptTable2
    {
        [StringLength(90)]
        [Unicode(false)]
        public string Dept { get; set; } = null!;
        [StringLength(90)]
        [Unicode(false)]
        public string? School { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? DeptCode { get; set; }
        [Column("CDept")]
        [StringLength(80)]
        [Unicode(false)]
        public string? Cdept { get; set; }
        public int? OlineProgId { get; set; }
        [Column("onlinedeptid")]
        public int? Onlinedeptid { get; set; }
        [Column("onlineschoolid")]
        public int? Onlineschoolid { get; set; }
        [Column("localprogid")]
        public int? Localprogid { get; set; }
        [Column("localschoolid")]
        public int? Localschoolid { get; set; }
    }
}
