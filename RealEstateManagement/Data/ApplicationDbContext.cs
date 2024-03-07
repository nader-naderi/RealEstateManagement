using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using RealEstateManagement.Models.Entities;

using System.Data;

namespace RealEstateManagement.Data
{
    public class ApplicationDbContext : IdentityDbContext<REMUser, REMRole, string, REMUserClaim, REMUserRole, REMUserLogin, REMRoleClaim, REMUserToken>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Owner> Owners { get; set; }
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<Agent> Agents { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<CommercialProperty> CommercialProperties { get; set; }
        public DbSet<ResidentialProperty> ResidentialProperties { get; set; }
        public DbSet<LandProperty> LandProperties { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Lease> Leases { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<REMUser>(b =>
            {
                // Each User can have many UserClaims
                b.HasMany(e => e.Claims)
                    .WithOne(e => e.User)
                    .HasForeignKey(uc => uc.UserId)
                    .IsRequired();

                // Each User can have many UserLogins
                b.HasMany(e => e.Logins)
                    .WithOne(e => e.User)
                    .HasForeignKey(ul => ul.UserId)
                    .IsRequired();

                // Each User can have many UserTokens
                b.HasMany(e => e.Tokens)
                    .WithOne(e => e.User)
                    .HasForeignKey(ut => ut.UserId)
                    .IsRequired();

                // Each User can have many entries in the UserRole join table
                b.HasMany(e => e.Role)
                    .WithOne(e => e.User)
                    .HasForeignKey(ur => ur.UserId)
                    .IsRequired();
            });

            builder.Entity<REMRole>(b =>
            {
                // Each Role can have many entries in the UserRole join table
                b.HasMany(e => e.UserRoles)
                    .WithOne(e => e.Role)
                    .HasForeignKey(ur => ur.RoleId)
                    .IsRequired();

                // Each Role can have many associated RoleClaims
                b.HasMany(e => e.RoleClaims)
                    .WithOne(e => e.Role)
                    .HasForeignKey(rc => rc.RoleId)
                    .IsRequired();
            });

            builder.Entity<CommercialProperty>().HasBaseType<Property>();
            builder.Entity<ResidentialProperty>().HasBaseType<Property>();
            builder.Entity<LandProperty>().HasBaseType<Property>();
        }
    }
}
