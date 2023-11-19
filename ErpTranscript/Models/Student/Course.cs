using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("course")]
    public partial class Course
    {
        [Column("course")]
        public string Course1 { get; set; } = null!;
        [Column("deptcode")]
        [StringLength(200)]
        public string Deptcode { get; set; } = null!;
        [Column("CoursefeesYr1_New", TypeName = "decimal(10, 2)")]
        public decimal? CoursefeesYr1New { get; set; }
        [Column("CoursefeesYrDE_New", TypeName = "decimal(10, 2)")]
        public decimal? CoursefeesYrDeNew { get; set; }
        [Column("CoursefeesYr2_New", TypeName = "decimal(10, 2)")]
        public decimal? CoursefeesYr2New { get; set; }
        [Column("CoursefeesYr3_New", TypeName = "decimal(10, 2)")]
        public decimal? CoursefeesYr3New { get; set; }
        [Column("CoursefeesYr4_New", TypeName = "decimal(10, 2)")]
        public decimal? CoursefeesYr4New { get; set; }
        [Column("CoursefeesCo_New", TypeName = "decimal(10, 2)")]
        public decimal? CoursefeesCoNew { get; set; }
        [Column("CoursefeesYr1_New_F", TypeName = "decimal(10, 2)")]
        public decimal? CoursefeesYr1NewF { get; set; }
        [Column("CoursefeesYrDE_New_F", TypeName = "decimal(10, 2)")]
        public decimal? CoursefeesYrDeNewF { get; set; }
        [Column("CoursefeesYr2_New_F", TypeName = "decimal(10, 2)")]
        public decimal? CoursefeesYr2NewF { get; set; }
        [Column("CoursefeesYr3_New_F", TypeName = "decimal(10, 2)")]
        public decimal? CoursefeesYr3NewF { get; set; }
        [Column("CoursefeesYr4_New_F", TypeName = "decimal(10, 2)")]
        public decimal? CoursefeesYr4NewF { get; set; }
        [Column("CoursefeesCo_New_F", TypeName = "decimal(10, 2)")]
        public decimal? CoursefeesCoNewF { get; set; }
        [Column("coursetype")]
        [StringLength(200)]
        public string? Coursetype { get; set; }
        [Column("prog_status")]
        [StringLength(200)]
        public string? ProgStatus { get; set; }
        [Column("session")]
        [StringLength(100)]
        public string? Session { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DeadLineSchoolFees { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DeadLineCourseReg { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
