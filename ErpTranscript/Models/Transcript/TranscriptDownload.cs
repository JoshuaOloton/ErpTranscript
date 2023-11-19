using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Transcript
{
    [Keyless]
    [Table("Transcript_download")]
    public partial class TranscriptDownload
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("dategen", TypeName = "date")]
        public DateTime? Dategen { get; set; }
        [Column("timegen")]
        public TimeSpan? Timegen { get; set; }
    }
}
