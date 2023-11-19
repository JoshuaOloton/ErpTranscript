using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Table("programme")]
    public partial class Programme
    {
        public Programme()
        {
            ComplianAdmins = new HashSet<ComplianAdmin>();
        }

        [Key]
        [Column("ProgrammeID")]
        public int ProgrammeId { get; set; }
        [Column("SchoolID")]
        public int SchoolId { get; set; }
        public int Department { get; set; }
        [Column("Programme")]
        [StringLength(225)]
        [Unicode(false)]
        public string Programme1 { get; set; } = null!;
        [Column(TypeName = "date")]
        public DateTime? DateCreated { get; set; }
        public TimeSpan? TimeCreated { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateOfLastUpdate { get; set; }
        public TimeSpan? TimeOfLastUpdate { get; set; }
        public int? UpdatedBy { get; set; }
        public int? CreatedBy { get; set; }

        [InverseProperty("Programm")]
        public virtual ICollection<ComplianAdmin> ComplianAdmins { get; set; }
    }
}
