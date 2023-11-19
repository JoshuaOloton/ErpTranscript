using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("setup_payment_school_fees")]
    public partial class SetupPaymentSchoolFee
    {
        [Column("SetUpPaymenID")]
        public int SetUpPaymenId { get; set; }
        [Column("DepartmentID")]
        public int DepartmentId { get; set; }
        [Column("SessionID")]
        public int SessionId { get; set; }
        [Column("PaymentID")]
        public int PaymentId { get; set; }
        [Column("LevelID")]
        public int LevelId { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string DeadLine { get; set; } = null!;
        [Column(TypeName = "date")]
        public DateTime? DateCreated { get; set; }
        public TimeSpan? TimeCreated { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateOfLastUpdate { get; set; }
        public TimeSpan? TimeOfLastUpdate { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
