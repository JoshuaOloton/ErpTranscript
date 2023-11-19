using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("Option_Table")]
    public partial class OptionTable
    {
        [StringLength(50)]
        public string? Matricno { get; set; }
        public int? Progoption { get; set; }
        public int? Program { get; set; }
        public int? Status { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
