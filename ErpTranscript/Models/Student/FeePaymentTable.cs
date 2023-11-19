using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("fee_payment_table")]
    public partial class FeePaymentTable
    {
        [Column("FeePaymentID")]
        public int FeePaymentId { get; set; }
        [Column("MatricNo.")]
        [StringLength(15)]
        [Unicode(false)]
        public string MatricNo { get; set; } = null!;
        [Column("A_SessionID")]
        public int ASessionId { get; set; }
        [Column("ProgrammeID")]
        public int ProgrammeId { get; set; }
        [Column("ClassID")]
        public int ClassId { get; set; }
        [Column("PaymentID")]
        public int PaymentId { get; set; }
        [Column(TypeName = "date")]
        public DateTime DateCreated { get; set; }
        public TimeSpan TimeCreated { get; set; }
    }
}
