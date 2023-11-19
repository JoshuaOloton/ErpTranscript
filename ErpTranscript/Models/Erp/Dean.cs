using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Erp
{
    [Keyless]
    public partial class Dean
    {
        public int? Userid { get; set; }
        public int? Schoolid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Datecreated { get; set; }
        public int? Status { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
