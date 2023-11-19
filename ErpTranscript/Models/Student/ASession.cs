using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("a_session")]
    public partial class ASession
    {
        [Column("SessionID")]
        public int SessionId { get; set; }
        [StringLength(25)]
        public string? Session { get; set; }
        public int? CurrentSession { get; set; }
        public int? CurrentApplicationSession { get; set; }
        public int? CurrentAdmissionSession { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateCreated { get; set; }
        public TimeSpan? TimeCreated { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateOfLastUpdate { get; set; }
        public TimeSpan? TimeOfLastUpdate { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        [Column("CurrentPTSession")]
        public int? CurrentPtsession { get; set; }
        [Column("CurrentFTSession")]
        public int? CurrentFtsession { get; set; }
    }
}
