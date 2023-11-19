using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Transcript
{
    [Table("Transcript_Request")]
    public partial class TranscriptRequest
    {
        [StringLength(50)]
        public string? Matricno { get; set; }
        [StringLength(250)]
        public string? Email { get; set; }
        [Column("Remita_rrr")]
        [StringLength(150)]
        public string? RemitaRrr { get; set; }
        [Column("Final_cgpa", TypeName = "decimal(18, 2)")]
        public decimal? FinalCgpa { get; set; }
        [Column("CStatus")]
        public int? Cstatus { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Uploaddate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ApproveDate { get; set; }
        [Column("FStatus")]
        public int? Fstatus { get; set; }
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("schoolid")]
        public int? Schoolid { get; set; }
        [StringLength(255)]
        public string? Tdestination { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Rdate { get; set; }
        [Column("flag")]
        public int? Flag { get; set; }
        [Column("flagby")]
        [StringLength(255)]
        public string? Flagby { get; set; }
        [Column("flagmsg")]
        public string? Flagmsg { get; set; }
        [Column("orderid")]
        public int? Orderid { get; set; }
        [Column("studcopy")]
        public int? Studcopy { get; set; }
        [Column("closereq")]
        public int? Closereq { get; set; }
    }
}
