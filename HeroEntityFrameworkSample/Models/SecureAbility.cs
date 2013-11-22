using System;
using System.Collections.Generic;
using Hero;

namespace HeroEntityFrameworkSample.Models
{
    public partial class SecureAbility : Hero.Ability
    {
        public bool IsSecure { get; set; }
    }
}
