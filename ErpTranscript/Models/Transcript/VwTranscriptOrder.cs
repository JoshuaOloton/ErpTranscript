using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Transcript
{
    [Keyless]
    public partial class VwTranscriptOrder
    {
        [Column("matricno")]
        [StringLength(50)]
        public string? Matricno { get; set; }
        [Column("namex")]
        [StringLength(150)]
        public string? Namex { get; set; }
        [Column("amount", TypeName = "decimal(18, 2)")]
        public decimal? Amount { get; set; }
        [Column("paymentid")]
        public int? Paymentid { get; set; }
        [Column("sessionname")]
        [StringLength(50)]
        public string? Sessionname { get; set; }
        [Column("remita_rrr")]
        [StringLength(50)]
        public string? RemitaRrr { get; set; }
        [Column("phone")]
        [StringLength(50)]
        public string? Phone { get; set; }
        [Column("locationx")]
        [StringLength(150)]
        public string? Locationx { get; set; }
        [Column("destination")]
        [StringLength(250)]
        public string? Destination { get; set; }
        [Column("destinationadd")]
        [StringLength(250)]
        public string? Destinationadd { get; set; }
        [Column("cgpa", TypeName = "decimal(18, 2)")]
        public decimal? Cgpa { get; set; }
        [Column("finalresult")]
        [StringLength(150)]
        public string? Finalresult { get; set; }
        [Column("status")]
        public int? Status { get; set; }
        [Column("id")]
        public int Id { get; set; }
        [Column("download")]
        public int? Download { get; set; }
        [Column("destemail")]
        [StringLength(150)]
        public string? Destemail { get; set; }
        [Column("studcopy")]
        public int? Studcopy { get; set; }
        [Column("program")]
        [StringLength(254)]
        public string? Program { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string SchoolName { get; set; } = null!;
    }
}
