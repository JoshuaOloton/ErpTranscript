using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("StudentNotification")]
    public partial class StudentNotification
    {
        [Column("NotificationID")]
        public int NotificationId { get; set; }
        [Column("pubMessage", TypeName = "text")]
        public string PubMessage { get; set; } = null!;
        [StringLength(10)]
        public string Status { get; set; } = null!;
        [Column("datePublished")]
        [StringLength(10)]
        public string DatePublished { get; set; } = null!;
        [Column("title")]
        [StringLength(100)]
        [Unicode(false)]
        public string Title { get; set; } = null!;
    }
}
