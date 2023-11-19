using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Table("Complainstbl")]
    public partial class Complainstbl
    {
        [Key]
        [Column("sn")]
        public int Sn { get; set; }
        [Column("complaintId")]
        [StringLength(50)]
        public string? ComplaintId { get; set; }
        [Column("StatusID")]
        public int? StatusId { get; set; }
        [Column("remark")]
        [StringLength(1000)]
        public string? Remark { get; set; }
        [Column("date_created", TypeName = "datetime")]
        public DateTime? DateCreated { get; set; }
        [Column("created_by")]
        [StringLength(50)]
        public string? CreatedBy { get; set; }

        [ForeignKey("StatusId")]
        [InverseProperty("Complainstbls")]
        public virtual ComplianStatus? Status { get; set; }
    }
}
