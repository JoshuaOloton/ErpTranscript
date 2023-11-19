using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("messageNotification")]
    public partial class MessageNotification
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("title")]
        [StringLength(100)]
        [Unicode(false)]
        public string Title { get; set; } = null!;
        [Column("message", TypeName = "text")]
        public string Message { get; set; } = null!;
        [Column("matricNo")]
        [StringLength(50)]
        [Unicode(false)]
        public string MatricNo { get; set; } = null!;
        [Column("pubMessage")]
        public int PubMessage { get; set; }
        [Column("status")]
        public int Status { get; set; }
        [Column("dateUploaded")]
        public DateTime DateUploaded { get; set; }
        [Column("uploadedBy")]
        [StringLength(50)]
        [Unicode(false)]
        public string UploadedBy { get; set; } = null!;
    }
}
