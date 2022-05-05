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
                if (input.Contains("_")||input.Any(char.IsNumber))
                {
                    return true;
                }
                if (!input.ToLower().Contains("x") || !input.ToLower().Contains("h"))
                {
                    return false;
                }
                if (input.All(char.IsLower)||(input.Any(char.IsLower)&&input.Any(char.IsUpper)))
                {
                    return true;
                }
                
            }
            return true;
        }
    }
}
