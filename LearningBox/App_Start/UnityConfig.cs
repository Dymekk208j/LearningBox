using System.Web.Mvc;
using LearningBox.Controllers;
using Microsoft.Practices.Unity;
using Unity.Mvc5;

namespace LearningBox
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            //container.RegisterType<IRepository<GamerProfile, int>, GamerProfileRepository>();

            container.RegisterType<AccountController>(new InjectionConstructor());
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}