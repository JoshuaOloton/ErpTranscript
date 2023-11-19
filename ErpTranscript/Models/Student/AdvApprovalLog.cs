using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("adv_approval_log")]
    public partial class AdvApprovalLog
    {
        [Column("id")]
        public int? Id { get; set; }
        [Column("userid")]
        public int? Userid { get; set; }
        [Column("matno")]
        [StringLength(50)]
        public string? Matno { get; set; }
        [Column("statusapprovd")]
        public int? Statusapprovd { get; set; }
        [Column("datetransact", TypeName = "date")]
        public DateTime? Datetransact { get; set; }
        [Column("Adv_note")]
        public string? AdvNote { get; set; }
    }
}
