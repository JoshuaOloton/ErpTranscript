using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Erp
{
    [Keyless]
    public partial class VwGroupActivity
    {
        [Column("sn")]
        public int Sn { get; set; }
        [StringLength(50)]
        public string? GroupName { get; set; }
        [StringLength(50)]
        public string? GroupId { get; set; }
        [StringLength(10)]
        public string? Status { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateCreated { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateUpdated { get; set; }
        [StringLength(150)]
        public string? Activity { get; set; }
        public int? Menuid { get; set; }
        public int Activityid { get; set; }
        [StringLength(150)]
        public string? ActivityUrl { get; set; }
        [StringLength(50)]
        public string? Menu { get; set; }
        public int? MenuOrder { get; set; }
    }
}
