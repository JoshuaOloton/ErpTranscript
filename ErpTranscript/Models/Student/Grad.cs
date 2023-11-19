using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("grads")]
    public partial class Grad
    {
        [StringLength(50)]
        public string? Matricno { get; set; }
        [StringLength(50)]
        public string? Asession { get; set; }
        [StringLength(50)]
        public string? Grade { get; set; }
        [StringLength(50)]
        public string? Sex { get; set; }
        [StringLength(50)]
        public string? Phone { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
