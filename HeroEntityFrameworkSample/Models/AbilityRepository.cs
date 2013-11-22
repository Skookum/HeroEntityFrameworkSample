using Hero.Repositories;
using Repositories;
using System.Data.Entity;

namespace HeroEntityFrameworkSample.Models
{
    public class AbilityRepository : EntityFrameworkRepository, IAbilityRepository
    {
        public AbilityRepository(DbContext dbContext) : base(dbContext) { }
    }
}