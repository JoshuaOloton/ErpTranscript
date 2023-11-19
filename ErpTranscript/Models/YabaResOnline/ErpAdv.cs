using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.YabaResOnline
{
    [Keyless]
    public partial class ErpAdv
    {
        public int? Advid { get; set; }
        [Column("programid")]
        public int? Programid { get; set; }
        [Column("levelid")]
        public int? Levelid { get; set; }
        [Column("programmetypeid")]
        public int? Programmetypeid { get; set; }
        [Column("id")]
        public int Id { get; set; }
        public int? Status { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Dateinserted { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateUpdated { get; set; }
    }
}
