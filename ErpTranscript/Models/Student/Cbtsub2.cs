using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("Cbtsub2")]
    public partial class Cbtsub2
    {
        [StringLength(50)]
        public string? CourseCode { get; set; }
    }
}
