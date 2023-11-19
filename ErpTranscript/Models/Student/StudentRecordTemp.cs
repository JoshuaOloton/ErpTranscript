using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("student_record_temp")]
    public partial class StudentRecordTemp
    {
        [StringLength(50)]
        public string? Matricno { get; set; }
        [Column("Real_Level")]
        [StringLength(50)]
        public string? RealLevel { get; set; }
        [Column("cgpa", TypeName = "decimal(10, 0)")]
        public decimal? Cgpa { get; set; }
        [StringLength(250)]
        public string? Remark { get; set; }
        [Column("LevelID")]
        public int? LevelId { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
