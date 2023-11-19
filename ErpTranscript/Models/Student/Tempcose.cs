using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("tempcoses")]
    public partial class Tempcose
    {
        [StringLength(50)]
        [Unicode(false)]
        public string? CosCode { get; set; }
        [Column("ProgrammeID")]
        public int? ProgrammeId { get; set; }
        [Column("ProgrammeTypeID")]
        public int? ProgrammeTypeId { get; set; }
        [Column("ID")]
        public int Id { get; set; }
    }
}
