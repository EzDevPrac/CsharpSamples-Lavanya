using Microsoft.Practices.Unity;
using System;

namespace DependencyInjectionUsingUnity
{
    class Program
    {
        static void Main(string[] args)
        {

            var container = new UnityContainer()
                .RegisterType<ICar, BMW>();

            var driver1 = container.Resolve<Driver>();
            driver1.RunCar();
        }
    }
}
