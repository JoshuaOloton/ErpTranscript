using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("Fraud")]
    public partial class Fraud
    {
        [StringLength(50)]
        public string? Matricno { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Datefraud { get; set; }
        [Column("userfraud")]
        [StringLength(50)]
        public string? Userfraud { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
