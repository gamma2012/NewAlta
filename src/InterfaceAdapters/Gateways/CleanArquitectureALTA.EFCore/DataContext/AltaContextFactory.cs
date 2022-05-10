using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;

namespace Alta.EFCore.DataContext
{
    public class AltaContextFactory : IDesignTimeDbContextFactory<AltaContext>
    {
        public AltaContext CreateDbContext(string[] args)
        {
            var optionBuilder = new DbContextOptionsBuilder<AltaContext>();

            optionBuilder.UseSqlServer();
            return new AltaContext(optionBuilder.Options);
        }
    }
}
