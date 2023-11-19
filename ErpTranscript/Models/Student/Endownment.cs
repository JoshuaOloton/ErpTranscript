using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("endownment")]
    public partial class Endownment
    {
        public string? Name { get; set; }
        [StringLength(255)]
        public string? MatricNo { get; set; }
        [StringLength(255)]
        public string? PhoneNo { get; set; }
        [StringLength(255)]
        public string? EmailAddy { get; set; }
        [StringLength(255)]
        public string? HomeAddy { get; set; }
    }
}
