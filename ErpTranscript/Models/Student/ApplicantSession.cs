using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("applicant_session")]
    public partial class ApplicantSession
    {
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(50)]
        public string? Appnum { get; set; }
        [StringLength(225)]
        public string? Hash { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateLoggedin { get; set; }
    }
}
