using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Erp
{
    [Keyless]
    public partial class VwUsersIdenty
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
        [Column("id")]
        public int Id { get; set; }
        [Column("staffid")]
        [StringLength(50)]
        public string? Staffid { get; set; }
        [Column("ssid")]
        public int? Ssid { get; set; }
        public int? Status { get; set; }
        [Column("fulln")]
        [StringLength(150)]
        public string? Fulln { get; set; }
        [Column("dept")]
        [StringLength(250)]
        public string? Dept { get; set; }
        [Column("ranc")]
        [StringLength(200)]
        public string? Ranc { get; set; }
        [Column("categ")]
        [StringLength(250)]
        public string? Categ { get; set; }
        [Column("unit")]
        [StringLength(250)]
        public string? Unit { get; set; }
    }
}
