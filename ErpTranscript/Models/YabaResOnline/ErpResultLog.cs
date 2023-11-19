using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.YabaResOnline
{
    [Table("erp_result_Log")]
    public partial class ErpResultLog
    {
        [Key]
        [Column("sn")]
        public int Sn { get; set; }
        [Column("user_id")]
        [StringLength(150)]
        public string UserId { get; set; } = null!;
        [Column("log_date", TypeName = "datetime")]
        public DateTime LogDate { get; set; }
        [Column("action")]
        [StringLength(200)]
        public string Action { get; set; } = null!;
        [Column("user_ip")]
        [StringLength(50)]
        public string UserIp { get; set; } = null!;
        [Column("studnum")]
        [StringLength(50)]
        public string? Studnum { get; set; }
    }
}
