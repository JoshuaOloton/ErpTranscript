using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.YabaResOnline
{
    [Keyless]
    [Table("erpProgrammers")]
    public partial class ErpProgrammer
    {
        [Column("erpserid")]
        public int? Erpserid { get; set; }
        public int? Studentschoolid { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
