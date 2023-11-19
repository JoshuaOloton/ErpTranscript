using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Erp
{
    public partial class UserPreviledge
    {
        public int? Userid { get; set; }
        public int? Activityid { get; set; }
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("activitystatus")]
        public int? Activitystatus { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? GroupId { get; set; }

        [ForeignKey("Activityid")]
        [InverseProperty("UserPreviledges")]
        public virtual Activity? Activity { get; set; }
        [ForeignKey("Userid")]
        [InverseProperty("UserPreviledges")]
        public virtual User? User { get; set; }
    }
}
