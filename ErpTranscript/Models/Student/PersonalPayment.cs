using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("personal_payment")]
    public partial class PersonalPayment
    {
        public int Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Matricno { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? Desc { get; set; }
        public int? Amount { get; set; }
        [Column("PaymentID")]
        public int? PaymentId { get; set; }
        [Column("SessionID")]
        [StringLength(50)]
        [Unicode(false)]
        public string? SessionId { get; set; }
        public int? Status { get; set; }
    }
}
