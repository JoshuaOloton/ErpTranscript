using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    public partial class VwComplain
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
        [StringLength(15)]
        public string? ComplaintId { get; set; }
        [Column("complaint_details")]
        [StringLength(1000)]
        public string? ComplaintDetails { get; set; }
        [Column("status")]
        [StringLength(15)]
        public string? Status { get; set; }
        [Column("matricnum")]
        [StringLength(50)]
        [Unicode(false)]
        public string Matricnum { get; set; } = null!;
        [Column("surname")]
        [StringLength(100)]
        [Unicode(false)]
        public string Surname { get; set; } = null!;
        [Column("firstname")]
        [StringLength(100)]
        [Unicode(false)]
        public string Firstname { get; set; } = null!;
        [Column("othername")]
        [StringLength(100)]
        [Unicode(false)]
        public string Othername { get; set; } = null!;
        [Column("sex")]
        [StringLength(50)]
        [Unicode(false)]
        public string Sex { get; set; } = null!;
        [Column("dob")]
        [StringLength(50)]
        [Unicode(false)]
        public string Dob { get; set; } = null!;
        [Column("mob")]
        [StringLength(50)]
        [Unicode(false)]
        public string Mob { get; set; } = null!;
        [Column("yob")]
        [StringLength(50)]
        [Unicode(false)]
        public string Yob { get; set; } = null!;
        [Column("email")]
        [StringLength(255)]
        [Unicode(false)]
        public string Email { get; set; } = null!;
        [Column("phone")]
        [StringLength(50)]
        [Unicode(false)]
        public string Phone { get; set; } = null!;
        [Column("address")]
        [StringLength(200)]
        [Unicode(false)]
        public string Address { get; set; } = null!;
        [Column("Real_Level")]
        [StringLength(50)]
        [Unicode(false)]
        public string? RealLevel { get; set; }
        public int Department { get; set; }
        [StringLength(225)]
        [Unicode(false)]
        public string Programme { get; set; } = null!;
        [StringLength(100)]
        public string? School { get; set; }
        [StringLength(50)]
        public string? ProgrammeType { get; set; }
    }
}
