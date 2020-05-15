using Microsoft.Practices.Unity;
using System;

namespace DependencyInjectionUsingUnity
{
    class Program
    {
        static void Main(string[] args)
        {

            var container = new UnityContainer();
            container.RegisterType<IInstitutionService, InstitutionService>();
            container.RegisterType<ICourseService, CourseService>();

            InstitutionService institution = container.Resolve<InstitutionService>();
          Console.WriteLine( institution.GetInstitutionByID(1).ToString());

            CourseService course = container.Resolve<CourseService>();

            Console.WriteLine(course.GetCourseByID(2));
        

        }
    }
}
