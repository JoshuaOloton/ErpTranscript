using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Erp
{
    [Table("ActivityLocation")]
    public partial class ActivityLocation
    {
        public int? Activityid { get; set; }
        [StringLength(150)]
        public string? ActivityUrl { get; set; }
        [StringLength(50)]
        public string? ActivityIcon { get; set; }
        [StringLength(50)]
        public string? DateCreated { get; set; }
        public int? CreatedByid { get; set; }
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [ForeignKey("Activityid")]
        [InverseProperty("ActivityLocations")]
        public virtual Activity? Activity { get; set; }
        [ForeignKey("CreatedByid")]
        [InverseProperty("ActivityLocations")]
        public virtual User? CreatedBy { get; set; }
    }
}
