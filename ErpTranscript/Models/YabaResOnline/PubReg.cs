using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.YabaResOnline
{
    [Keyless]
    [Table("PubReg")]
    public partial class PubReg
    {
        [Column("ASession")]
        public int? Asession { get; set; }
        public int? Semester { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? CosCode { get; set; }
        [Column("ca", TypeName = "decimal(18, 1)")]
        public decimal? Ca { get; set; }
        [Column("exam", TypeName = "decimal(18, 1)")]
        public decimal? Exam { get; set; }
        public int? Score { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? Grade { get; set; }
        [Column("CUnit")]
        public int? Cunit { get; set; }
        [Column("CNature")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Cnature { get; set; }
        public int? Clevel { get; set; }
        [Column("id")]
        [StringLength(100)]
        public string Id { get; set; } = null!;
        [StringLength(50)]
        public string? MatricNo { get; set; }
        [Column("CPoint", TypeName = "decimal(18, 2)")]
        public decimal? Cpoint { get; set; }
        public int? SemId { get; set; }
        [Column("pid")]
        public int Pid { get; set; }
        public int? Mup { get; set; }
        [Column("dateCreated", TypeName = "datetime")]
        public DateTime? DateCreated { get; set; }
        [Column("dateUpdated", TypeName = "datetime")]
        public DateTime? DateUpdated { get; set; }
        public int? Bulkin { get; set; }
        public int? Programid { get; set; }
        public int? Programtypeid { get; set; }
        public int? AppenRec { get; set; }
        [Column("status")]
        public int? Status { get; set; }
    }
}
