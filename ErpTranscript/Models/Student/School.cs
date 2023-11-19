using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Table("school")]
    public partial class School
    {
        public School()
        {
            ComplianAdmins = new HashSet<ComplianAdmin>();
        }

        [Key]
        [Column("SchoolID")]
        public int SchoolId { get; set; }
        [Column("School")]
        [StringLength(100)]
        public string? School1 { get; set; }
        [Column("resultid")]
        public int? Resultid { get; set; }

        [InverseProperty("School")]
        public virtual ICollection<ComplianAdmin> ComplianAdmins { get; set; }
    }
}
