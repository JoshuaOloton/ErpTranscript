using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("Cbtsubft")]
    public partial class Cbtsubft
    {
        [StringLength(50)]
        public string? CosCode { get; set; }
    }
}
