using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    public partial class VwProgramme
    {
        [Column("ProgrammeID")]
        public int ProgrammeId { get; set; }
        [Column("SchoolID")]
        public int SchoolId { get; set; }
        public int Department { get; set; }
        [StringLength(225)]
        [Unicode(false)]
        public string Programme { get; set; } = null!;
        [Column(TypeName = "date")]
        public DateTime? DateCreated { get; set; }
        public TimeSpan? TimeCreated { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateOfLastUpdate { get; set; }
        public TimeSpan? TimeOfLastUpdate { get; set; }
        public int? UpdatedBy { get; set; }
        public int? CreatedBy { get; set; }
        [StringLength(100)]
        public string? School { get; set; }
        [StringLength(225)]
        [Unicode(false)]
        public string Dept { get; set; } = null!;
    }
}
