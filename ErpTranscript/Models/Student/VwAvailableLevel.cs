using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    public partial class VwAvailableLevel
    {
        public int? Programmetypeid { get; set; }
        [Column("levelid")]
        public int? Levelid { get; set; }
        [Column("id")]
        public int Id { get; set; }
        [Column("programmetype")]
        [StringLength(50)]
        public string? Programmetype { get; set; }
        [Column("level")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Level { get; set; }
    }
}
