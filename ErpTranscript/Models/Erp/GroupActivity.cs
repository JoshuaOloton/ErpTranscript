using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Erp
{
    public partial class GroupActivity
    {
        [Key]
        [Column("sn")]
        public int Sn { get; set; }
        public int? GroupId { get; set; }
        public int? Activityid { get; set; }

        [ForeignKey("GroupId")]
        [InverseProperty("GroupActivities")]
        public virtual GroupActivityName? Group { get; set; }
    }
}
