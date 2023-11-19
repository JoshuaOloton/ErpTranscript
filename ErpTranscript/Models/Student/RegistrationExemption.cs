using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("registration_exemption")]
    public partial class RegistrationExemption
    {
        [Column("exemptionID")]
        public int ExemptionId { get; set; }
        [Column("status")]
        public int Status { get; set; }
        [Column("programTypeID")]
        public int ProgramTypeId { get; set; }
        [Column("schoolID")]
        public int SchoolId { get; set; }
        [Column("levelID")]
        public int LevelId { get; set; }
        [Column("programID")]
        public int ProgramId { get; set; }
        [Column("departmentID")]
        public int DepartmentId { get; set; }
        [Column("matricNo")]
        [StringLength(50)]
        [Unicode(false)]
        public string MatricNo { get; set; } = null!;
        [Column("dateUpdated")]
        public DateTime DateUpdated { get; set; }
        [Column("who")]
        [StringLength(50)]
        [Unicode(false)]
        public string Who { get; set; } = null!;
    }
}
