using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("lockhistory")]
    public partial class Lockhistory
    {
        [StringLength(50)]
        [Unicode(false)]
        public string Matricno { get; set; } = null!;
        public int? LockCount { get; set; }
        [Column(TypeName = "date")]
        public DateTime LockDate { get; set; }
        public int Id { get; set; }
    }
}
