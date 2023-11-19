using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("a_class")]
    public partial class AClass
    {
        [Column("ClassID")]
        public int ClassId { get; set; }
        [Column("SchoolID")]
        public int SchoolId { get; set; }
        [Column("DepartmentID")]
        public int DepartmentId { get; set; }
        [Column("ProgrameID")]
        public int ProgrameId { get; set; }
        [StringLength(225)]
        [Unicode(false)]
        public string Class { get; set; } = null!;
        [Column(TypeName = "date")]
        public DateTime DateCreated { get; set; }
        public TimeSpan TimeCreated { get; set; }
        [Column(TypeName = "date")]
        public DateTime DateOfLastUpdate { get; set; }
        public TimeSpan TimeOfLastUpdate { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}
