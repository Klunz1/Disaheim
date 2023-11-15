using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Disaheim;


namespace Disaheim
{
    public class Utility
    {
        public double LowQualityValue { get; set; } = 12.5;
        public double MediumQualityValue { get; set; } = 20.00;
        public double HighQualityValue { get; set; } = 27.5;

        public double CourseHourValue { get; set; } = 875.00;
        //metoder oprettes

        public double GetValueOfMerchandise(Merchandise merchandise)
        {
            
            if (merchandise is Amulet amulet )
            {
                double value = 0;
                Utility utility = new Utility();

                if (amulet.Quality == Level.low)
                {
                   value = utility.LowQualityValue;
                }
                if (amulet.Quality == Level.medium)
                {
                    value = utility.MediumQualityValue;
                }
                if (amulet.Quality == Level.high)
                {
                    value = utility.HighQualityValue;
                }
                return value;
            }
            if (merchandise is Book book ) 
            {
                return book.Price;
            }
            return 0;
        }
        
        public double GetValueOfCourse(Course course) 
        {
            double courseCost = 0;
            double restCost=0;
            Utility util= new Utility();

            int fullHourCost = course.DurationInMinutes / 60;
            
            if (course.DurationInMinutes % 60 > 0)
            {
                restCost = util.CourseHourValue;
            }

            courseCost = (fullHourCost * util.CourseHourValue) + restCost;
            return courseCost;
        }
    }
}
