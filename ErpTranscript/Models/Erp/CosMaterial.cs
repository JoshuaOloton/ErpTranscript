using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Erp
{
    [Keyless]
    [Table("CosMaterial")]
    public partial class CosMaterial
    {
        [StringLength(50)]
        public string? Coscode { get; set; }
        [StringLength(250)]
        public string? MatTitle { get; set; }
        public string? MatDescription { get; set; }
        public string? FileUploaded { get; set; }
        [Column("A_SessionId")]
        public int? ASessionId { get; set; }
        public int? SemesterId { get; set; }
        public int? ProgramId { get; set; }
        public int? ProgramTypeid { get; set; }
        [StringLength(250)]
        public string? Createdby { get; set; }
        [StringLength(250)]
        public string? Updatedby { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateCreated { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
