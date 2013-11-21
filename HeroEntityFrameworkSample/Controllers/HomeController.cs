using Hero.Configuration;
using Hero.Repositories;
using Hero.Services;
using Hero.Services.Interfaces;
using HeroEntityFrameworkSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HeroEntityFrameworkSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HeroContext dbContext = new HeroContext();
            IAbilityRepository repository = new HeroEntityFrameworkSample.Models.AbilityRepository(dbContext);

            IAbilityAuthorizationService service = new AbilityAuthorizationService(null, null, repository);
            HeroConfig.Initialize(service);

            var abilitesFromHero = HeroConfig.AuthorizationService.GetAbilities();

            var abilities = repository.Get<SecureAbility>().ToList();
            return View();
        }
    }
}
