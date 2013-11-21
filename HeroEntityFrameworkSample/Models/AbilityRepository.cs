using Hero.Repositories;
using Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HeroEntityFrameworkSample.Models
{
    public class AbilityRepository : EntityFrameworkRepository, IAbilityRepository
    {
        public AbilityRepository(DbContext dbContext) : base(dbContext) { }
    }
}