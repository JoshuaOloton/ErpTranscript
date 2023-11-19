using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    public partial class VwProgrammeType
    {
        [Column("ProgrammeTypeID")]
        public int ProgrammeTypeId { get; set; }
        [StringLength(50)]
        public string? ProgrammeType { get; set; }
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
        [StringLength(25)]
        public string? Session { get; set; }
        [StringLength(225)]
        [Unicode(false)]
        public string Semester { get; set; } = null!;
        [Column("semester_name")]
        [StringLength(8000)]
        [Unicode(false)]
        public string? SemesterName { get; set; }
    }
}
