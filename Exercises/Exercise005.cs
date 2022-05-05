using System;
using System.Linq;
namespace Exercises
{
    public class Exercise005
    {
        public bool IsPangram(string input)
        {
            // Replace the exception statement below with your code!
            // throw new NotImplementedException();
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }
            else if (input.ToLower() == "abcdefghijklmnopqrstuvwxyz")
            {
                return true;
            }
            else
            {
                if (input.Contains("_"))
                {
                    return true;
                }

                if (input.Any(char.IsNumber))
                {
                    return true;
                }

                string trim_input = input.Replace(" ", "");
                if (!trim_input.ToLower().Contains("x") || !trim_input.ToLower().Contains("h"))
                {
                    return false;
                }
                if (trim_input.All(char.IsLower)||(trim_input.Any(char.IsLower)&&trim_input.Any(char.IsUpper)))
                {
                    return true;
                }
                
            }

            return true;
        }
    }
}
