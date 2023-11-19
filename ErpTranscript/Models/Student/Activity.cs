using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("activity")]
    public partial class Activity
    {
        [Column("ActivityID")]
        public int ActivityId { get; set; }
        [Column("Activity")]
        [StringLength(225)]
        [Unicode(false)]
        public string Activity1 { get; set; } = null!;
        public int Status { get; set; }
        [Column(TypeName = "date")]
        public DateTime DateCreated { get; set; }
        public TimeSpan TimeCreated { get; set; }
        [Column(TypeName = "date")]
        public DateTime DateOfLastUpdate { get; set; }
        public TimeSpan TimeOfLastUpdate { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}
