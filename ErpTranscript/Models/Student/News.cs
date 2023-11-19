using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Table("news")]
    public partial class News
    {
        [Key]
        [Column("NewsID")]
        public int NewsId { get; set; }
        [StringLength(500)]
        [Unicode(false)]
        public string? Details { get; set; }
        [StringLength(225)]
        [Unicode(false)]
        public string? Status { get; set; }
        [Column("SchoolID")]
        public int? SchoolId { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? Title { get; set; }
        [Column("ProgrammeID")]
        public int? ProgrammeId { get; set; }
        [Column("ProgrammetypeID")]
        public int? ProgrammetypeId { get; set; }
    }
}
