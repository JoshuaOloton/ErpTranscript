using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("school_fees_transaction")]
    public partial class SchoolFeesTransaction
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("tranid")]
        [StringLength(50)]
        public string? Tranid { get; set; }
        [Column("remita_rrr")]
        [StringLength(50)]
        public string? RemitaRrr { get; set; }
        [Column("semesterID")]
        [StringLength(50)]
        public string? SemesterId { get; set; }
        [Column("transactiondate")]
        [StringLength(50)]
        public string? Transactiondate { get; set; }
        [Column("payeeNum")]
        [StringLength(50)]
        public string? PayeeNum { get; set; }
        [Column("amount")]
        public int? Amount { get; set; }
        [Column("datePosted")]
        [StringLength(50)]
        public string? DatePosted { get; set; }
    }
}
