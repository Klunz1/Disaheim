using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Disaheim;


namespace UtilityLib
{
    public class Utility
    {
        //metoder oprettes
        public double GetValueOfBook(Book book)
        {
            return book.Price;
        }
        public double GetValueOfAmulet(Amulet amulet) 
        {
            double value = 0;

            if (amulet.Quality == Level.low)
                {
                value = 12.5;
                }
            if (amulet.Quality == Level.medium)
                {
                value = 20.0;
                }
            if (amulet.Quality == Level.high)
                {
                value = 27.5;
                }
            return value;
        }
        public double GetValueOfCourse(Course course) 
        {
            int courseCost = 0;
            int restCost=0;

            int fullHourCost = course.DurationInMinutes / 60;
            
            if (course.DurationInMinutes % 60 > 0)
            {
                restCost = 875;
            }

            courseCost = (fullHourCost * 875) + restCost;
            return courseCost;
        }
    }
}
