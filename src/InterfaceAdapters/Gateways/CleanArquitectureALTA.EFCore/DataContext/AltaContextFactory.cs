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

            optionBuilder.UseSqlServer("Server=localhost,1433; Initial Catalog= AltaWS; User=sa; Password=Passw0rd; TrustServerCertificate=True;");
            return new AltaContext(optionBuilder.Options);
        }
    }
}
