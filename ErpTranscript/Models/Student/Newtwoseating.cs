using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("Newtwoseating")]
    public partial class Newtwoseating
    {
        [StringLength(50)]
        public string? Appnum { get; set; }
    }
}
