using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Table("grade_level")]
    public partial class GradeLevel
    {
        [Key]
        [Column("GradelevelID")]
        public int GradelevelId { get; set; }
        [Column("GradeLevel")]
        [StringLength(50)]
        [Unicode(false)]
        public string? GradeLevel1 { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateCreated { get; set; }
        public TimeSpan? TimeCreated { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateOfLastUpdate { get; set; }
        public TimeSpan? TimeOfLastUpdate { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
