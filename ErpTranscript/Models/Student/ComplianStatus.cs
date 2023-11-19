using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Table("Complian_Status")]
    public partial class ComplianStatus
    {
        public ComplianStatus()
        {
            Complainstbls = new HashSet<Complainstbl>();
        }

        [Key]
        [Column("sn")]
        public int Sn { get; set; }
        [Column("status")]
        [StringLength(15)]
        public string? Status { get; set; }

        [InverseProperty("Status")]
        public virtual ICollection<Complainstbl> Complainstbls { get; set; }
    }
}
