using BranchCrudAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BranchCrudAPI.Data
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Branch> Branch { get; set; } = default!;
    }
}