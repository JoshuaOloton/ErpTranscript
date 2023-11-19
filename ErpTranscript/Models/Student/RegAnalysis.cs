using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("Reg_analysis")]
    public partial class RegAnalysis
    {
        [StringLength(250)]
        public string? Program { get; set; }
        [Column("nd1")]
        public int? Nd1 { get; set; }
        [Column("nd2")]
        public int? Nd2 { get; set; }
        [Column("nd3")]
        public int? Nd3 { get; set; }
        [Column("hnd1")]
        public int? Hnd1 { get; set; }
        [Column("hnd2")]
        public int? Hnd2 { get; set; }
        [Column("hnd3")]
        public int? Hnd3 { get; set; }
        [Column("A_session")]
        [StringLength(50)]
        public string? ASession { get; set; }
        [Column("progtype")]
        [StringLength(50)]
        public string? Progtype { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
