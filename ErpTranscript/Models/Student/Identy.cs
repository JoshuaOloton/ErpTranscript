using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("identy")]
    public partial class Identy
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("fulln")]
        [StringLength(150)]
        public string? Fulln { get; set; }
        [Column("staffno")]
        [StringLength(70)]
        public string? Staffno { get; set; }
        [Column("dappt")]
        [StringLength(120)]
        public string? Dappt { get; set; }
        [Column("dprom")]
        [StringLength(120)]
        public string? Dprom { get; set; }
        [Column("ranc")]
        [StringLength(120)]
        public string? Ranc { get; set; }
        [Column("dob")]
        [StringLength(120)]
        public string? Dob { get; set; }
        [Column("orig")]
        [StringLength(120)]
        public string? Orig { get; set; }
        [Column("lga")]
        [StringLength(150)]
        public string? Lga { get; set; }
        [Column("pics")]
        [StringLength(190)]
        public string? Pics { get; set; }
        [Column("sign")]
        [StringLength(190)]
        public string? Sign { get; set; }
        [Column("fonoffi")]
        [StringLength(16)]
        public string? Fonoffi { get; set; }
        [Column("fon")]
        [StringLength(16)]
        public string? Fon { get; set; }
        [Column("emaloffi")]
        [StringLength(120)]
        public string? Emaloffi { get; set; }
        [Column("emal")]
        [StringLength(120)]
        public string? Emal { get; set; }
        [Column("categ")]
        [StringLength(120)]
        public string? Categ { get; set; }
        [Column("dept")]
        [StringLength(130)]
        public string? Dept { get; set; }
        [Column("qual")]
        [StringLength(160)]
        public string? Qual { get; set; }
        [Column("sexx")]
        [StringLength(30)]
        public string? Sexx { get; set; }
        [Column("profil", TypeName = "text")]
        public string? Profil { get; set; }
        [Column("cvlenk")]
        [StringLength(160)]
        public string? Cvlenk { get; set; }
        [Column("publi", TypeName = "text")]
        public string? Publi { get; set; }
        [Column("supervis", TypeName = "text")]
        public string? Supervis { get; set; }
        [Column("pozt")]
        [StringLength(150)]
        public string? Pozt { get; set; }
        [Column("addy")]
        public string? Addy { get; set; }
        [Column("hpazz")]
        [StringLength(34)]
        public string? Hpazz { get; set; }
        [Column("secq")]
        [StringLength(200)]
        public string? Secq { get; set; }
        [Column("seca")]
        [StringLength(120)]
        public string? Seca { get; set; }
        [Column("titl")]
        [StringLength(40)]
        public string? Titl { get; set; }
        [Column("imgg")]
        [StringLength(160)]
        public string? Imgg { get; set; }
        [Column("unit")]
        [StringLength(160)]
        public string? Unit { get; set; }
    }
}
