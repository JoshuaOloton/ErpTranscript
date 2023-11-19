using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("OptionSplit")]
    public partial class OptionSplit
    {
        public int? Programmeid { get; set; }
        [Column("levelid")]
        public int? Levelid { get; set; }
        public int? Semesterid { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
