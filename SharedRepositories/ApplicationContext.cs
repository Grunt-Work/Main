using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SharedServices.Authentication;

namespace SharedRepositories
{
    public class ApplicationContext : DbContext, IApplicationContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {            
        }
        public DbSet<User> Users { get; set; }
        public override async Task<int> SaveChangesAsync(CancellationToken ct = default)
        {
            return await base.SaveChangesAsync(ct);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().ToTable("VW_Users");
        }


    }
}
