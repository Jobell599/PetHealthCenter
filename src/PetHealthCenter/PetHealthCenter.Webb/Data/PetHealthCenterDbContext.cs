using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetHealthCenter.Domain.Entities;

namespace PetHealthCenter.Webb.Data
{
    public class PetHealthCenterDbContext : DbContext
    {
        public PetHealthCenterDbContext (DbContextOptions<PetHealthCenterDbContext> options)
            : base(options)
        {
        }

        public DbSet<PetHealthCenter.Domain.Entities.Clients> Clients { get; set; } = default!;
    }
}
