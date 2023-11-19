using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("process-order")]
    public partial class ProcessOrder
    {
        [Column("ProcessOrderID")]
        public int ProcessOrderId { get; set; }
        public int Activity { get; set; }
        public int Prerequisite { get; set; }
        public int Status { get; set; }
        [Column(TypeName = "date")]
        public DateTime DateOfLastUpdated { get; set; }
        public TimeSpan TimeOfLastUpdate { get; set; }
        [Column(TypeName = "date")]
        public DateTime DateCreated { get; set; }
        public TimeSpan TimeCreated { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}
