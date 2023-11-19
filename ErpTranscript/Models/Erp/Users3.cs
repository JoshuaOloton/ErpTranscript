using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Erp
{
    [Keyless]
    [Table("Users3")]
    public partial class Users3
    {
        [StringLength(150)]
        public string? Uname { get; set; }
        [StringLength(150)]
        public string? Password { get; set; }
        [StringLength(150)]
        public string? CreatedDate { get; set; }
        [StringLength(150)]
        public string? LastLogin { get; set; }
        [StringLength(150)]
        public string? CreatedbyId { get; set; }
        [Column("staffid")]
        [StringLength(50)]
        public string? Staffid { get; set; }
        [Column("ssid")]
        public int? Ssid { get; set; }
    }
}
