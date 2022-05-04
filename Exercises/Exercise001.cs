using System;
using System.Collections.Generic;
using Exercises.Models;
namespace Exercises
{
    public class Exercise001
    {
        public string CapitalizeWord(string word)
        {
            // Replace the exception statement below with your code!
            // throw new NotImplementedException();
            return char.ToUpper(word[0]) + word.Substring(1);
        }

        public string GenerateInitials(string firstName, string lastName)
        {
            // Replace the exception statement below with your code!
            // throw new NotImplementedException();
            return firstName[0] + "." + lastName[0];
        }

        public double AddVat(double originalPrice, double vatRate)
        {
            // Replace the exception statement below with your code!
            // throw new NotImplementedException();
            return Math.Round(originalPrice * (100 + vatRate) / 100, 2);
        }

        public string Reverse(string sentence)
        {
            // Replace the exception statement below with your code!
            // throw new NotImplementedException();
            char[] arr = sentence.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public int CountLinuxUsers(List<User> users)
        {
            // Replace the exception statement below with your code!
            // throw new NotImplementedException();
            int count = 0;
            foreach (var user in users)
            {
                if (user.Type == "Linux")
                {
                    count += 1;
                }
            };
            return count;

        }
    }
}
