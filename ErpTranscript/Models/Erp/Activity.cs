using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Erp
{
    public partial class Activity
    {
        public Activity()
        {
            ActivityLocations = new HashSet<ActivityLocation>();
            UserPreviledges = new HashSet<UserPreviledge>();
        }

        [Column("Activity")]
        [StringLength(150)]
        public string? Activity1 { get; set; }
        public int? Menuid { get; set; }
        [Key]
        public int Activityid { get; set; }

        [ForeignKey("Menuid")]
        [InverseProperty("Activities")]
        public virtual Menu? Menu { get; set; }
        [InverseProperty("Activity")]
        public virtual ICollection<ActivityLocation> ActivityLocations { get; set; }
        [InverseProperty("Activity")]
        public virtual ICollection<UserPreviledge> UserPreviledges { get; set; }
    }
}
