using System;
using System.Collections.Generic;

namespace HeroEntityFrameworkSample.Models
{
    public partial class SecureAbility : Hero.Ability
    {
        public SecureAbility()
        {
            this.Abilities = new List<Hero.Ability>();
        }

        public bool IsSecure { get; set; }
        public string ParentId { get; set; }
    }
}
