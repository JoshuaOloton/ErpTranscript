using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("CbtSubjectsptsec")]
    public partial class CbtSubjectsptsec
    {
        [StringLength(50)]
        public string? CourseCode { get; set; }
        public int? Curstatus { get; set; }
    }
}
