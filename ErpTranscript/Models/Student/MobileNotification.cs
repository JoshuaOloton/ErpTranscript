using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("mobileNotification")]
    public partial class MobileNotification
    {
        [Column("NewsID")]
        public int NewsId { get; set; }
        [Column("title")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Title { get; set; }
        [Column("message", TypeName = "text")]
        public string Message { get; set; } = null!;
        [Column("image")]
        [StringLength(60)]
        [Unicode(false)]
        public string? Image { get; set; }
        [Column("status")]
        public int Status { get; set; }
        [Column("dateUploaded")]
        [StringLength(50)]
        [Unicode(false)]
        public string? DateUploaded { get; set; }
    }
}
