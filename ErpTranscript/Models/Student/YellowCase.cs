using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    /// <summary>
    /// This table was set up in respect of issue with CODE NAME: &apos;YELLO CASE / YELLOW FILE
    /// </summary>
    [Keyless]
    [Table("yellow_case")]
    public partial class YellowCase
    {
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? MatricNo { get; set; }
        [StringLength(225)]
        [Unicode(false)]
        public string? Description { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateAdded { get; set; }
    }
}
