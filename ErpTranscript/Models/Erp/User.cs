using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Erp
{
    public partial class User
    {
        public User()
        {
            ActivityLocations = new HashSet<ActivityLocation>();
            UserPreviledges = new HashSet<UserPreviledge>();
        }

        [StringLength(150)]
        public string? Uname { get; set; }
        [StringLength(150)]
        public string? Password { get; set; }
        [StringLength(150)]
        public string? CreatedDate { get; set; }
        [StringLength(150)]
        public string? LastLogin { get; set; }
        [StringLength(150)]
        public string? CreatedbyId { get; set; }
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("staffid")]
        [StringLength(50)]
        public string? Staffid { get; set; }
        [Column("ssid")]
        public int? Ssid { get; set; }
        public int? Status { get; set; }

        [InverseProperty("CreatedBy")]
        public virtual ICollection<ActivityLocation> ActivityLocations { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<UserPreviledge> UserPreviledges { get; set; }
    }
}
