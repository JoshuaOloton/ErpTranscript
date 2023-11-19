using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Index("Levelid", "RealLevel", "Semesterid", "Semid1", Name = "Semidx")]
    public partial class Semid
    {
        public int? Levelid { get; set; }
        [Column("Real_Level")]
        [StringLength(50)]
        public string? RealLevel { get; set; }
        public int? Semesterid { get; set; }
        [Column("Semid")]
        public int? Semid1 { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
