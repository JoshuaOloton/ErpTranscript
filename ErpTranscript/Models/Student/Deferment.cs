using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("deferments")]
    public partial class Deferment
    {
        [Column("DefermentID")]
        public int DefermentId { get; set; }
        [Column("userid")]
        public int Userid { get; set; }
        [Column("matricnum")]
        [StringLength(20)]
        public string Matricnum { get; set; } = null!;
        [Column("R_session")]
        [StringLength(12)]
        public string RSession { get; set; } = null!;
        [Column("R_semester")]
        [StringLength(1)]
        public string RSemester { get; set; } = null!;
        [Column("autho")]
        [StringLength(180)]
        public string Autho { get; set; } = null!;
        [StringLength(75)]
        public string DateTimeCreated { get; set; } = null!;
        [Column("dele")]
        [StringLength(1)]
        public string Dele { get; set; } = null!;
    }
}
