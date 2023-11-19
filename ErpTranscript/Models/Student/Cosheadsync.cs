using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("cosheadsync")]
    public partial class Cosheadsync
    {
        [Column("cid")]
        public int? Cid { get; set; }
        [Column("ProgrammeID")]
        public int? ProgrammeId { get; set; }
        public int? Levelid { get; set; }
        [StringLength(50)]
        public string? CourseCode { get; set; }
        public int? CosHeadId { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
