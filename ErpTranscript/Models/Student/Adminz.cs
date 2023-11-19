using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("adminz")]
    public partial class Adminz
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("uzer")]
        [StringLength(255)]
        [Unicode(false)]
        public string Uzer { get; set; } = null!;
        [Column("pazz")]
        [StringLength(255)]
        [Unicode(false)]
        public string Pazz { get; set; } = null!;
        [Column("statuz")]
        [StringLength(20)]
        [Unicode(false)]
        public string Statuz { get; set; } = null!;
        [Column("dele")]
        [StringLength(1)]
        [Unicode(false)]
        public string? Dele { get; set; }
        [Column("hpazz")]
        [StringLength(40)]
        [Unicode(false)]
        public string Hpazz { get; set; } = null!;
        [Column("dreg")]
        [StringLength(255)]
        [Unicode(false)]
        public string? Dreg { get; set; }
        [Column("updateid")]
        public int Updateid { get; set; }
    }
}
