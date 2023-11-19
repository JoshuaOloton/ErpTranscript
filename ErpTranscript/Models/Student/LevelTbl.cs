using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("level_tbl")]
    public partial class LevelTbl
    {
        [StringLength(20)]
        [Unicode(false)]
        public string LevelCode { get; set; } = null!;
        [StringLength(20)]
        [Unicode(false)]
        public string LevelName { get; set; } = null!;
        [Column("level_code")]
        [StringLength(20)]
        [Unicode(false)]
        public string LevelCode1 { get; set; } = null!;
        [Column("prog_status")]
        [StringLength(20)]
        [Unicode(false)]
        public string ProgStatus { get; set; } = null!;
        [Column("biolevel")]
        [StringLength(20)]
        [Unicode(false)]
        public string Biolevel { get; set; } = null!;
        [Column("PCAcronym")]
        [StringLength(20)]
        [Unicode(false)]
        public string Pcacronym { get; set; } = null!;
        [Column("resultlevelname")]
        [StringLength(20)]
        [Unicode(false)]
        public string Resultlevelname { get; set; } = null!;
    }
}
