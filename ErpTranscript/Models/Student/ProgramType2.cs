using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("program_type_2")]
    public partial class ProgramType2
    {
        [Column("ProgrammeType2ID")]
        public int ProgrammeType2Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? ProgrammeType2 { get; set; }
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
    }
}
