using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionUsingUnity
{
    public  class CourseService :ICourseService
    {
        public Course GetCourseByID(long courseID)
        {
            return new Course
            {
                CourseID = courseID,
                Description = "course description",
                InstitutionID = 1,
                Title = "Course Title"
            };
        }
    }
}
