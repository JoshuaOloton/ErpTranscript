using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("EbportalProgmap")]
    public partial class EbportalProgmap
    {
        [StringLength(250)]
        public string? Ebportalprogram { get; set; }
        public int? Ebportalprogramid { get; set; }
        [StringLength(250)]
        public string? Studentprogram { get; set; }
        public int? Studentprogramid { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
