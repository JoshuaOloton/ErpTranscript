using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Transcript
{
    [Keyless]
    [Table("Transcript_activity")]
    public partial class TranscriptActivity
    {
        [Column("erpactivityid")]
        public int? Erpactivityid { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
