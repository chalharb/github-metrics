using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GitHubMetics.Models;

namespace GitHubMetics.Data
{
    public class GitHubMeticsContext : DbContext
    {
        public GitHubMeticsContext (DbContextOptions<GitHubMeticsContext> options)
            : base(options)
        {
        }

        public DbSet<GitHubMetics.Models.WorkflowRun> WorkflowRun { get; set; } = default!;
    }
}
