using System;
using System.Collections.Generic;
using System.Linq;
using Exercises.Models;
namespace Exercises
{
    public class Exercise001
    {
        public string CapitalizeWord(string word)
        {
            return char.ToUpper(word[0]) + word.Substring(1);
        }

        public string GenerateInitials(string firstName, string lastName)
        {
            return firstName[0] + "." + lastName[0];
        }

        public double AddVat(double originalPrice, double vatRate)
        {
            return Math.Round(originalPrice * (100 + vatRate) / 100, 2);
        }

        public string Reverse(string sentence)
        {
            return string.IsNullOrEmpty(sentence) ? sentence : new string(sentence.Reverse().ToArray());
        }

        public int CountLinuxUsers(List<User> users)
        {
            return users.Count(u => u.Type == "Linux");
        }
    }
}
