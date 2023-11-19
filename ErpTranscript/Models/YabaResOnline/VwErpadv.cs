using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.YabaResOnline
{
    [Keyless]
    public partial class VwErpadv
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
        [Column("uname")]
        [StringLength(150)]
        public string? Uname { get; set; }
        [StringLength(150)]
        public string? CreatedDate { get; set; }
        [Column("staffid")]
        [StringLength(50)]
        public string? Staffid { get; set; }
        [Column("fulln")]
        [StringLength(150)]
        public string? Fulln { get; set; }
        [StringLength(225)]
        [Unicode(false)]
        public string Programme { get; set; } = null!;
        [Column("SchoolID")]
        public int SchoolId { get; set; }
        [StringLength(100)]
        public string? School { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Level { get; set; }
    }
}
