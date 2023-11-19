using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("access_level")]
    public partial class AccessLevel
    {
        [Column("url")]
        [StringLength(255)]
        [Unicode(false)]
        public string? Url { get; set; }
        [Column("PASSED")]
        public int Passed { get; set; }
        [Column("GRADUATED")]
        public int Graduated { get; set; }
        [Column("INACTIVE")]
        public int Inactive { get; set; }
        [Column("DEFERED")]
        public int Defered { get; set; }
        [Column("STEP DOWN")]
        public int StepDown { get; set; }
        [Column("EXPELLED")]
        public int Expelled { get; set; }
        [Column("WITHDRAWN")]
        public int Withdrawn { get; set; }
        [Column("ACTIVE")]
        public int Active { get; set; }
    }
}
