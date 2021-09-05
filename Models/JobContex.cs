using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PandoAPI.Models
{
    public class JobContext : DbContext
    {
        public JobContext(DbContextOptions<JobContext> options)
            :base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Job> Jobs { get; set; }
    }
}
