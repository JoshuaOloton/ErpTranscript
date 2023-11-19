using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("Available_Levels")]
    public partial class AvailableLevel
    {
        public int? Programmetypeid { get; set; }
        [Column("levelid")]
        public int? Levelid { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
