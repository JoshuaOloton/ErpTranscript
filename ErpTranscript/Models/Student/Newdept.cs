using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("newdepts")]
    public partial class Newdept
    {
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? Matricno { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? Programme { get; set; }
        [Column("ProgramID")]
        [StringLength(20)]
        [Unicode(false)]
        public string? ProgramId { get; set; }
    }
}
