using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("payitems")]
    public partial class Payitem
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("paymentid")]
        public int Paymentid { get; set; }
        [Column("item")]
        [StringLength(95)]
        [Unicode(false)]
        public string Item { get; set; } = null!;
        [Column("acode")]
        [StringLength(20)]
        [Unicode(false)]
        public string? Acode { get; set; }
        [Column("amt")]
        [StringLength(30)]
        [Unicode(false)]
        public string Amt { get; set; } = null!;
    }
}
