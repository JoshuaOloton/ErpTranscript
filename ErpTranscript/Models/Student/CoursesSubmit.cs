using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("Courses_Submit")]
    public partial class CoursesSubmit
    {
        public int? Programme { get; set; }
        [StringLength(50)]
        public string? ProgrammeType { get; set; }
        [Column("A_Sessionid")]
        public int? ASessionid { get; set; }
        public int? SemesterId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        public int? Userid { get; set; }
        public int Id { get; set; }
        public int? Status { get; set; }
        [Column("dateEdited", TypeName = "date")]
        public DateTime? DateEdited { get; set; }
    }
}
