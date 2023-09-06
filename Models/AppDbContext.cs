using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMarksDashboardAPI.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
        public DbSet<SubjectModule> subjectModules{ get; set; }
        public DbSet<Status> statuses { get; set; }
        public DbSet<Score> scores { get; set; }


    }
}
