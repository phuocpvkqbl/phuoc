using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace PhuocProjectTest.EntityFrameworkCore
{
    public static class PhuocProjectTestDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<PhuocProjectTestDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<PhuocProjectTestDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
