using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace Exercises
{
    public class Exercise005
    {
        public bool IsPangram(string input)
        {
            String alphabet = "abcdefghijklmnopqrstuvwxyz";
            return alphabet.All(c => input.ToLower().Contains(c));
        }
    }
}
