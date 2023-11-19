using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Erp
{
    [Table("GroupActivityName")]
    public partial class GroupActivityName
    {
        public GroupActivityName()
        {
            GroupActivities = new HashSet<GroupActivity>();
        }

        [Key]
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

        [InverseProperty("Group")]
        public virtual ICollection<GroupActivity> GroupActivities { get; set; }
    }
}
