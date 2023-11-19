using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ErpTranscript.Models.Erp
{
    [Index("MenuOrder", Name = "MenuOrder_u", IsUnique = true)]
    public partial class Menu
    {
        public Menu()
        {
            Activities = new HashSet<Activity>();
        }

        [Column("Menu")]
        [StringLength(50)]
        public string? Menu1 { get; set; }
        [Key]
        public int Menuid { get; set; }
        public int? MenuOrder { get; set; }
        [Column("menuIcon")]
        [StringLength(20)]
        public string? MenuIcon { get; set; }

        [InverseProperty("Menu")]
        public virtual ICollection<Activity> Activities { get; set; }
    }
}
