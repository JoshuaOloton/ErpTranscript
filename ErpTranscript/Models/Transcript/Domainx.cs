using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Transcript
{
    [Keyless]
    [Table("domainx")]
    public partial class Domainx
    {
        [Column("dname")]
        public string? Dname { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
