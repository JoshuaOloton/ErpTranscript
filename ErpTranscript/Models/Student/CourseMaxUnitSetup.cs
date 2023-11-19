using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("course_max_unit_setup")]
    public partial class CourseMaxUnitSetup
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("ProgrammeTypeID")]
        public int? ProgrammeTypeId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? MaxUnit { get; set; }
    }
}
