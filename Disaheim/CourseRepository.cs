using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class CourseRepository
    {
        List<Course> courses = new List<Course>();

        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

        public Course GetCourse(string itemId)
        {
            Course course = null;
            Utility util = new Utility();
            foreach (Course amu in courses)
            {
                if (amu != null && amu.Name == itemId)
                {
                    course = amu;
                }
            }
            return course;
        }

        public double GetTotalValue()
        {
            Utility util = new Utility();
            double total = 0;
            if (courses != null)
            {
                for (int a = 0; a < courses.Count; a++)
                {
                    total += util.GetValueOfCourse(courses[a]);
                }
            }

            return total;

        }
        }
}
