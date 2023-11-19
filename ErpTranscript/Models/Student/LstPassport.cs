using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Table("LstPassport")]
    public partial class LstPassport
    {
        [StringLength(50)]
        public string? Matricno { get; set; }
        [Key]
        [Column("id")]
        public int Id { get; set; }
    }
}
