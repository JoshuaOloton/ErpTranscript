using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.YabaResOnline
{
    [Keyless]
    [Table("ER5View13")]
    public partial class Er5view13
    {
        [StringLength(90)]
        [Unicode(false)]
        public string? Matricno { get; set; }
        [StringLength(90)]
        [Unicode(false)]
        public string? Name { get; set; }
        [Column("ASession")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Asession { get; set; }
        [StringLength(70)]
        [Unicode(false)]
        public string? Semester { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Prog { get; set; }
        [Column("SLevel")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Slevel { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Cos1 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Cos2 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Cos3 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Cos4 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Cos5 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Cos6 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Cos7 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Cos8 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Cos9 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Cos10 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Cos11 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Cos12 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Cos13 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Cos14 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Cos15 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Cos16 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Cos17 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Cos18 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Cos19 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Cos20 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Cos21 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Cos22 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Cos23 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Cos24 { get; set; }
        [Column("TU")]
        public int? Tu { get; set; }
        [Column("WGP", TypeName = "decimal(18, 2)")]
        public decimal? Wgp { get; set; }
        [Column("GPA", TypeName = "decimal(18, 2)")]
        public decimal? Gpa { get; set; }
        [Column("CTU")]
        public int? Ctu { get; set; }
        [Column("CTUIP", TypeName = "decimal(18, 2)")]
        public decimal? Ctuip { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Cgpa { get; set; }
        [StringLength(245)]
        [Unicode(false)]
        public string? Remark { get; set; }
        [StringLength(245)]
        [Unicode(false)]
        public string? Remark1 { get; set; }
        [StringLength(245)]
        [Unicode(false)]
        public string? Remark2 { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string Id { get; set; } = null!;
        [StringLength(80)]
        [Unicode(false)]
        public string? Dept { get; set; }
        [Column("CTUP")]
        public int? Ctup { get; set; }
        public int? AbsCount { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? AbsVal { get; set; }
        [Column("semid")]
        public int? Semid { get; set; }
        [Column("semStatus")]
        [StringLength(50)]
        [Unicode(false)]
        public string? SemStatus { get; set; }
        [Column("gradlev")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Gradlev { get; set; }
        [StringLength(60)]
        [Unicode(false)]
        public string? Surname { get; set; }
        [Column("othernames")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Othernames { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Cos25 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Cos26 { get; set; }
        [Column("tid")]
        public int Tid { get; set; }
        public int? Mup { get; set; }
        [Column("dateCreated", TypeName = "datetime")]
        public DateTime? DateCreated { get; set; }
        [Column("dateUpdated", TypeName = "datetime")]
        public DateTime? DateUpdated { get; set; }
        public int? Bulkin { get; set; }
        public int? SubmitStatus { get; set; }
        public int? ApproveStatus { get; set; }
        public int? UploadStatus { get; set; }
        public int? Semesterid { get; set; }
        [Column("progid")]
        public int? Progid { get; set; }
        [Column("slevelid")]
        public int? Slevelid { get; set; }
        public int? Asessionid { get; set; }
        [Column("semid2")]
        public int? Semid2 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Cos27 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Cos28 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Cos29 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Cos30 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Cos31 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Cos32 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Cos33 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Cos34 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Cos35 { get; set; }
        public int? Mopup { get; set; }
    }
}
