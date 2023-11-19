using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Transcript
{
    [Keyless]
    [Table("Transcript_Dest")]
    public partial class TranscriptDest
    {
        [Column("translocation")]
        [StringLength(150)]
        public string? Translocation { get; set; }
        [Column("amount", TypeName = "decimal(18, 2)")]
        public decimal? Amount { get; set; }
        [Column("transcriptid")]
        public int? Transcriptid { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
