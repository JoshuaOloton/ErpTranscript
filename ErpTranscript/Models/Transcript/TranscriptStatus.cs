using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Transcript
{
    [Keyless]
    [Table("Transcript_Status")]
    public partial class TranscriptStatus
    {
        public int? Statuscode { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
