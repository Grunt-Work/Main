using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SharedServices.Authentication;

namespace SharedRepositories
{
    public interface IApplicationContext
    {
        public DbSet<User> Users { get; set; }
        public Task<int> SaveChangesAsync(CancellationToken ct = default);
    }
}
