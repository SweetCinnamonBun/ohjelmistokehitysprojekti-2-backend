using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ohjelmistokehitysprojekti_2_backend.Models.Domain;

namespace ohjelmistokehitysprojekti_2_backend.Data
{
    public class OKP2DbContext : DbContext
    {
        public OKP2DbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<User> Users { get; set; }

    }
}