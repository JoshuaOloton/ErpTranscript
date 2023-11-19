using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Table("Resortar")]
    public partial class Resortar
    {
        [StringLength(50)]
        public string? Matricno { get; set; }
        [StringLength(50)]
        public string? Subject { get; set; }
        public int? Score { get; set; }
        public int? Status { get; set; }
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("STAMP")]
        public int? Stamp { get; set; }
    }
}
