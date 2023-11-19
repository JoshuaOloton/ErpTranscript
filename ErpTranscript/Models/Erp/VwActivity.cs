using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Erp
{
    [Keyless]
    public partial class VwActivity
    {
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
