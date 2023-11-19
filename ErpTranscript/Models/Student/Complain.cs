using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    public partial class Complain
    {
        [Column("sn")]
        public int Sn { get; set; }
        [Column("student_id")]
        public int? StudentId { get; set; }
        [Column("program_type_id")]
        public int? ProgramTypeId { get; set; }
        [Column("school_id")]
        public int? SchoolId { get; set; }
        [Column("programm_id")]
        public int? ProgrammId { get; set; }
        [Column("noc")]
        [StringLength(50)]
        public string? Noc { get; set; }
        [Column("doc")]
        [StringLength(100)]
        public string? Doc { get; set; }
        [Column("date_created", TypeName = "datetime")]
        public DateTime? DateCreated { get; set; }
        [Column("date_updated", TypeName = "datetime")]
        public DateTime? DateUpdated { get; set; }
        [Column("status_id")]
        public int? StatusId { get; set; }
        [Column("complaintId")]
        [StringLength(50)]
        public string? ComplaintId { get; set; }
        [Column("complaint_details")]
        [StringLength(1000)]
        public string? ComplaintDetails { get; set; }
    }
}
