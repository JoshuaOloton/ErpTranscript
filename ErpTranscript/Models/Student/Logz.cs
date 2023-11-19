using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("logz")]
    public partial class Logz
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("myid")]
        public int Myid { get; set; }
        [Column("typee")]
        [StringLength(255)]
        [Unicode(false)]
        public string Typee { get; set; } = null!;
        [Column("dreg")]
        [StringLength(255)]
        [Unicode(false)]
        public string Dreg { get; set; } = null!;
    }
}
