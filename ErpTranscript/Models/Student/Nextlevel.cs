using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("Nextlevel")]
    public partial class Nextlevel
    {
        public int? Levelid { get; set; }
        [StringLength(50)]
        public string? Semester { get; set; }
        public int? Cursemester { get; set; }
        [Column("nextlevelid")]
        public int? Nextlevelid { get; set; }
        [Column("progtypid")]
        public int? Progtypid { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
