using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("olevelissues")]
    public partial class Olevelissue
    {
        [Column("id")]
        public int Id { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? Matricnum { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? Name { get; set; }
        [Column("dept")]
        [StringLength(255)]
        [Unicode(false)]
        public string? Dept { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? Examyr { get; set; }
        [Column("remarks")]
        [StringLength(255)]
        [Unicode(false)]
        public string? Remarks { get; set; }
        [Column("phone")]
        [StringLength(255)]
        [Unicode(false)]
        public string? Phone { get; set; }
    }
}
