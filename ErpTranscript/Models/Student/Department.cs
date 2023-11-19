using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Table("department")]
    public partial class Department
    {
        [Key]
        [Column("DepartmentID")]
        public int DepartmentId { get; set; }
        [Column("SchoolID")]
        public int SchoolId { get; set; }
        [Column("Department")]
        [StringLength(225)]
        [Unicode(false)]
        public string Department1 { get; set; } = null!;
    }
}
