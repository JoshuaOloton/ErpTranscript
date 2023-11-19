using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Table("CosBase")]
    public partial class CosBase
    {
        [StringLength(255)]
        public string? Coscode { get; set; }
        public string? CosTitle { get; set; }
        public int? Cosunit { get; set; }
        public int? Deptid { get; set; }
        [Key]
        public int Cosid { get; set; }
    }
}
