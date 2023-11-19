using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("payment")]
    public partial class Payment
    {
        [Column("PaymentID")]
        public int PaymentId { get; set; }
        [Column("PayID")]
        public int PayId { get; set; }
        [StringLength(225)]
        [Unicode(false)]
        public string BreakDownDescription { get; set; } = null!;
        public int Amount { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateCreated { get; set; }
        public TimeSpan? TimeCreated { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateOfLastUpdate { get; set; }
        public TimeSpan? TimeOfLastUpdate { get; set; }
        public int? CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}
