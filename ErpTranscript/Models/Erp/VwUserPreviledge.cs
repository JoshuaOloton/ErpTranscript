using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Erp
{
    [Keyless]
    public partial class VwUserPreviledge
    {
        [Column("activitystatus")]
        public int? Activitystatus { get; set; }
        [Column("id")]
        public int Id { get; set; }
        [StringLength(150)]
        public string? Uname { get; set; }
        [StringLength(150)]
        public string? Activity { get; set; }
        public int? Menuid { get; set; }
        public int? Activityid { get; set; }
        [StringLength(150)]
        public string? ActivityUrl { get; set; }
        [StringLength(50)]
        public string? Menu { get; set; }
        public int? MenuOrder { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? GroupId { get; set; }
        [StringLength(50)]
        public string? GroupName { get; set; }
    }
}
