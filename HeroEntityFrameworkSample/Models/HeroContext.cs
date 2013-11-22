using System.Data.Entity;
using HeroEntityFrameworkSample.Models.Mapping;

namespace HeroEntityFrameworkSample.Models
{
    public partial class HeroContext : DbContext
    {
        static HeroContext()
        {
            Database.SetInitializer<HeroContext>(null);
        }

        public HeroContext()
            : base("Name=HeroContext")
        {
        }

        public DbSet<SecureAbility> Abilities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new SecureAbilityMap());
        }
    }
}
