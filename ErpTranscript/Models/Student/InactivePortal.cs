using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("inactivePortal")]
    public partial class InactivePortal
    {
        [Column("InactiveID")]
        public int InactiveId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string MatricNo { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Status { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string DateSubmitted { get; set; } = null!;
        public int? Status2 { get; set; }
    }
}
