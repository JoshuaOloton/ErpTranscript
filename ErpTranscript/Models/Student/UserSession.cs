using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("user_session")]
    public partial class UserSession
    {
        public int SessionId { get; set; }
        [Column("hash")]
        [StringLength(255)]
        [Unicode(false)]
        public string Hash { get; set; } = null!;
        [Column("dateOfLastLogin", TypeName = "date")]
        public DateTime DateOfLastLogin { get; set; }
        [Column("timeOfLastLogin")]
        public byte[] TimeOfLastLogin { get; set; } = null!;
        [Column("matricnum")]
        [StringLength(255)]
        [Unicode(false)]
        public string Matricnum { get; set; } = null!;
        [Column("appnum")]
        [StringLength(255)]
        [Unicode(false)]
        public string Appnum { get; set; } = null!;
    }
}
