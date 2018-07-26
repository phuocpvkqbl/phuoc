using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using PhuocProjectTest.Authorization.Roles;
using PhuocProjectTest.Authorization.Users;
using PhuocProjectTest.MultiTenancy;

namespace PhuocProjectTest.EntityFrameworkCore
{
    public class PhuocProjectTestDbContext : AbpZeroDbContext<Tenant, Role, User, PhuocProjectTestDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Appointment> appointment { get; set; }
        public DbSet<Brand> brand { get; set; }
        public DbSet<Company> company { get; set; }
        public DbSet<Customer> customer { get; set; }
        public DbSet<Document> document { get; set; }
        public DbSet<DocumentDetail> documentDetail { get; set; }
        public DbSet<DocumentGroup> documentGroup { get; set; }
        public DbSet<Event> eventProp { get; set; }
        public DbSet<Favorite> favorite { get; set; }
        public DbSet<Maintenance> maintenance { get; set; }
        public DbSet<Mileage> mileage { get; set; }
        public DbSet<Model> model { get; set; }
        public DbSet<News> news { get; set; }
        public DbSet<Package> package { get; set; }
        public DbSet<Period> period { get; set; }
        public DbSet<Review> review { get; set; }
        public DbSet<Role> role { get; set; }
        //public DbSet<Setting> setting { get; set; }
        //public DbSet<User> user { get; set; }
        public DbSet<Vehicle> vehicle { get; set; }
       // public DbSet<Verification> verification { get; set; }
        public PhuocProjectTestDbContext(DbContextOptions<PhuocProjectTestDbContext> options)
            : base(options)
        {
        }
    }
}
