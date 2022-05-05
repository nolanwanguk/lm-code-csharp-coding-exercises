using System;
using Exercises.Models;

namespace Exercises
{
    public class Exercise002
    {
        public bool IsFromManchester(Person person)
        {
            // Replace the exception statement below with your code!
            // throw new NotImplementedException();

            if (person.City == "Manchester")
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        public bool CanWatchFilm(Person person, int ageLimit)
        {
            // Replace the exception statement below with your code!
            // throw new NotImplementedException();
            int limit = ageLimit;
            if (person.Age < limit)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

