using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Student
{
    [Keyless]
    [Table("level")]
    public partial class Level
    {
        [Column("LevelID")]
        public int LevelId { get; set; }
        [Column("Level")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Level1 { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateCreated { get; set; }
        public TimeSpan? TimeCreated { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateOfLastUpdate { get; set; }
        public TimeSpan? TimeofLastUpdate { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? CreatedBy { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? UpdatedBy { get; set; }
    }
}
