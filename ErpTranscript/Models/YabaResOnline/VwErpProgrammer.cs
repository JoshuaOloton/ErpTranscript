using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.YabaResOnline
{
    [Keyless]
    public partial class VwErpProgrammer
    {
        [Column("erpserid")]
        public int? Erpserid { get; set; }
        public int? Studentschoolid { get; set; }
        [Column("id")]
        public int Id { get; set; }
        [StringLength(150)]
        public string? Uname { get; set; }
        [StringLength(100)]
        public string? School { get; set; }
    }
}
