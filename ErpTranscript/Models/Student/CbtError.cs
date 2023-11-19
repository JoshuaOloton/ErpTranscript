using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("CbtError")]
    public partial class CbtError
    {
        [StringLength(50)]
        public string? CosCode { get; set; }
        [StringLength(250)]
        public string? CosTitle { get; set; }
    }
}
