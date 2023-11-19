using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("student_passport")]
    public partial class StudentPassport
    {
        [Column("StudentID")]
        [StringLength(50)]
        [Unicode(false)]
        public string? StudentId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Passport { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? Programme { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? DateUploaded { get; set; }
        [Column("SessionID")]
        [StringLength(50)]
        [Unicode(false)]
        public string? SessionId { get; set; }
        [Column("StudentPassportID")]
        public int StudentPassportId { get; set; }
    }
}
