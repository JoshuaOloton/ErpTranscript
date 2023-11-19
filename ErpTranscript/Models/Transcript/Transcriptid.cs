using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Transcript
{
    [Table("Transcriptid")]
    public partial class Transcriptid
    {
        [StringLength(50)]
        public string? Matricno { get; set; }
        [StringLength(150)]
        public string? Transid { get; set; }
        [Key]
        [Column("id")]
        public int Id { get; set; }
    }
}
