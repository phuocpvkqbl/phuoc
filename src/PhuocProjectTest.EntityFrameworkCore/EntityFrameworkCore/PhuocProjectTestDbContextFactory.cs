﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using PhuocProjectTest.Configuration;
using PhuocProjectTest.Web;

namespace PhuocProjectTest.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class PhuocProjectTestDbContextFactory : IDesignTimeDbContextFactory<PhuocProjectTestDbContext>
    {
        public PhuocProjectTestDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PhuocProjectTestDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            PhuocProjectTestDbContextConfigurer.Configure(builder, configuration.GetConnectionString(PhuocProjectTestConsts.ConnectionStringName));

            return new PhuocProjectTestDbContext(builder.Options);
        }
    }
}
