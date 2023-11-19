using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("fullprogramme")]
    public partial class Fullprogramme
    {
        [Column("FullProgrammeID")]
        public int FullProgrammeId { get; set; }
        [Column("ProgrammeID")]
        public int ProgrammeId { get; set; }
        [Column("SchoolID")]
        public int SchoolId { get; set; }
        public int Department { get; set; }
        [Column("ProgrammeTypeID")]
        public int ProgrammeTypeId { get; set; }
        [StringLength(225)]
        [Unicode(false)]
        public string FullProg { get; set; } = null!;
        [Column(TypeName = "date")]
        public DateTime? DateCreated { get; set; }
        public TimeSpan? TimeCreated { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateOfLastUpdate { get; set; }
        public TimeSpan? TimeOfLastUpdate { get; set; }
        public int? UpdatedBy { get; set; }
        public int? CreatedBy { get; set; }
    }
}
