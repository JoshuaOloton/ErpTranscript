using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Table("programme_type")]
    public partial class ProgrammeType
    {
        [Key]
        [Column("ProgrammeTypeID")]
        public int ProgrammeTypeId { get; set; }
        [Column("ProgrammeType")]
        [StringLength(50)]
        public string? ProgrammeType1 { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateCreated { get; set; }
        public TimeSpan? TimeCreated { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateOfLastUpdate { get; set; }
        public TimeSpan? TimeOfLastUpdate { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? CreatedBy { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? UpdatedBy { get; set; }
        public int? Asessionid { get; set; }
        public int? Semesterid { get; set; }
    }
}
