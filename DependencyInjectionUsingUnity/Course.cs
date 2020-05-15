using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionUsingUnity
{
        public class Course
        {
            public long CourseID { get; set; }
            public long InstitutionID { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }

        public override string ToString()
        {
            return "Course id :" + CourseID  + "\n Institution Id :" + InstitutionID + "\n Title :" + Title + "\n Description :" + Description;
        }

    }
}
