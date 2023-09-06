using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMarksDashboardAPI.Models
{
    public class SubjectModule
    {
        [Key]
        public int Id { get; set; }
        [StringLength(25)]
        public string ModuleName { get; set; } = string.Empty;
    }
}
