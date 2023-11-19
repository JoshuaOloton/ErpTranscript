using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Table("semester")]
    public partial class Semester
    {
        [Key]
        [Column("SemesterID")]
        public int SemesterId { get; set; }
        [Column("Semester")]
        [StringLength(225)]
        [Unicode(false)]
        public string Semester1 { get; set; } = null!;
        public int Status { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateCreated { get; set; }
        public TimeSpan? TimeCreated { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateOfLastUpdated { get; set; }
        public TimeSpan? TimeOfLastUpdate { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        [Column("CurrentPTSemester")]
        public int CurrentPtsemester { get; set; }
        [Column("CurrentFTSemester")]
        public int CurrentFtsemester { get; set; }
        [StringLength(50)]
        public string? SemName { get; set; }
    }
}
