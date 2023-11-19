using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("schoolfee")]
    public partial class Schoolfee
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("ProgrammeID")]
        public int ProgrammeId { get; set; }
        [Column("ProgrammeTypeID")]
        public int ProgrammeTypeId { get; set; }
        public int Level { get; set; }
        [Column("PaytypeID")]
        public int PaytypeId { get; set; }
        [Column("SessionID")]
        public int SessionId { get; set; }
        [StringLength(75)]
        [Unicode(false)]
        public string LastUpdate { get; set; } = null!;
        [StringLength(65)]
        [Unicode(false)]
        public string UpdateBy { get; set; } = null!;
    }
}
