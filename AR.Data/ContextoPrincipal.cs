using AR.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace AR.Data
{
    public class ContextoPrincipal : DbContext //framework Teste
    {
        public ContextoPrincipal(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Cliente> Cliente { get; set; }
    }
}
