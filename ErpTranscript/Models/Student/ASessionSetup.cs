using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("a_session_setup")]
    public partial class ASessionSetup
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("ProgrammeType2ID")]
        public int ProgrammeType2Id { get; set; }
        [Column("SemesterID")]
        public int SemesterId { get; set; }
        [Column("SessionID")]
        public int SessionId { get; set; }
        public int Status { get; set; }
    }
}
