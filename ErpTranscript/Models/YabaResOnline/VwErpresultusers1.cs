using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.YabaResOnline
{
    [Keyless]
    public partial class VwErpresultusers1
    {
        [StringLength(50)]
        public string? Userid { get; set; }
        [StringLength(50)]
        public string? Password { get; set; }
        public int? Upriv { get; set; }
        [Column("id")]
        public int Id { get; set; }
        [Column("fulln")]
        [StringLength(150)]
        public string? Fulln { get; set; }
        [Column("staffno")]
        [StringLength(70)]
        public string? Staffno { get; set; }
        [Column("ranc")]
        [StringLength(200)]
        public string? Ranc { get; set; }
        [Column("emaloffi")]
        [StringLength(200)]
        public string? Emaloffi { get; set; }
        [Column("categ")]
        [StringLength(250)]
        public string? Categ { get; set; }
        [Column("dept")]
        [StringLength(250)]
        public string? Dept { get; set; }
        [Column("unit")]
        [StringLength(250)]
        public string? Unit { get; set; }
    }
}
