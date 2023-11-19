using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Table("complian_admin")]
    public partial class ComplianAdmin
    {
        [Key]
        [Column("sn")]
        public int Sn { get; set; }
        [Column("f_name")]
        [StringLength(20)]
        public string? FName { get; set; }
        [Column("l_name")]
        [StringLength(20)]
        public string? LName { get; set; }
        [Column("email")]
        [StringLength(50)]
        public string? Email { get; set; }
        [Column("u_pass")]
        [StringLength(20)]
        public string? UPass { get; set; }
        [Column("image")]
        [StringLength(200)]
        public string? Image { get; set; }
        [Column("school_id")]
        public int? SchoolId { get; set; }
        [Column("programm_id")]
        public int? ProgrammId { get; set; }
        [Column("post")]
        [StringLength(10)]
        public string? Post { get; set; }
        [Column("date_created", TypeName = "datetime")]
        public DateTime? DateCreated { get; set; }
        [Column("date_updated", TypeName = "datetime")]
        public DateTime? DateUpdated { get; set; }

        [ForeignKey("ProgrammId")]
        [InverseProperty("ComplianAdmins")]
        public virtual Programme? Programm { get; set; }
        [ForeignKey("SchoolId")]
        [InverseProperty("ComplianAdmins")]
        public virtual School? School { get; set; }
    }
}
