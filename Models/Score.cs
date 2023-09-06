using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMarksDashboardAPI.Models
{
    public class Score
    {
        public int Id { get; set; }
        [StringLength(25)]
        public string Status { get; set; } = string.Empty;
        public  float ModuleScore { get; set; }
        public  int SubjectModuleId { get; set; }
        public  SubjectModule SubjectModule { get; set; }

        
    }
}
