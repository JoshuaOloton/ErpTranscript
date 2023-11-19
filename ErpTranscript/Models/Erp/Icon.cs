using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Erp
{
    public partial class Icon
    {
        [Key]
        public int IconId { get; set; }
        [StringLength(50)]
        public string? IconName { get; set; }
    }
}
