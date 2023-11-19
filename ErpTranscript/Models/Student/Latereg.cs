using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    public partial class Latereg
    {
        [StringLength(50)]
        public string? Matricno { get; set; }
        [StringLength(50)]
        public string? ProgramType { get; set; }
        public int? ProgramTypeid { get; set; }
    }
}
