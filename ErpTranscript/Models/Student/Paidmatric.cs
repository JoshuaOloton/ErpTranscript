using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("paidmatric")]
    public partial class Paidmatric
    {
        [StringLength(50)]
        [Unicode(false)]
        public string? Matricno { get; set; }
        public int Id { get; set; }
    }
}
