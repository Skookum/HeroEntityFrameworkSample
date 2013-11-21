using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HeroEntityFrameworkSample.Models.Mapping
{
    public class AbilityMap : EntityTypeConfiguration<SecureAbility>
    {
        public AbilityMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ParentId)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Ability");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ParentId).HasColumnName("ParentId");
            this.Property(t => t.IsSecure).HasColumnName("IsSecure");

            // Relationships
            this.HasOptional(t => t.Parent)
                .WithMany(t => t.Abilities)
                .HasForeignKey(d => d.ParentId);

        }
    }
}
