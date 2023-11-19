using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("paytype")]
    public partial class Paytype
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("fulltype")]
        [StringLength(140)]
        [Unicode(false)]
        public string Fulltype { get; set; } = null!;
        [Column("totalamt")]
        [StringLength(25)]
        [Unicode(false)]
        public string Totalamt { get; set; } = null!;
        [Column("dele")]
        [StringLength(1)]
        [Unicode(false)]
        public string? Dele { get; set; }
    }
}
