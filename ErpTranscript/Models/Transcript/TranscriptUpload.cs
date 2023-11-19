using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Transcript
{
    [Table("Transcript_Upload")]
    public partial class TranscriptUpload
    {
        [StringLength(50)]
        public string? Matricno { get; set; }
        [StringLength(250)]
        public string? Loc2 { get; set; }
        [StringLength(250)]
        public string? Loc { get; set; }
        [Key]
        [Column("id")]
        public int Id { get; set; }
    }
}
