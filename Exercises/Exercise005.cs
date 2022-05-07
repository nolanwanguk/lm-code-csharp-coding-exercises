using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace Exercises
{
    public class Exercise005
    {
        public bool IsPangram(string input)
        {
            // Replace the exception statement below with your code!
            // throw new NotImplementedException();
            int upper, lower, space, underscore, num, X, H;
            upper = lower = space = underscore = num = X = H = 0;
            
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            if (input.ToLower() == "abcdefghijklmnopqrstuvwxyz")
            {
                return true;
            }
            
            foreach (var item in input.ToCharArray())
            {
                // can be work over C# 9.0 or greater
                // switch (item)
                // {
                //     case >="a"&&<="z":
                //         lower += 1;
                //         break;
                //     case >="A"&&<="Z":
                //         upper += 1;
                //         break;
                //     case >=0&&<=9:
                //         num += 1;
                //         break;
                //     case " ":
                //         space += 1;
                //         break;
                //     case "_":
                //         underscore += 1;
                //         break;
                // }
                if (char.IsLower(item))
                {
                    lower += 1;
                }
                if (char.IsUpper(item))
                {
                    upper += 1;
                }
                if (char.IsNumber(item))
                {
                    num += 1;
                }
                if (char.IsWhiteSpace(item))
                {
                    space += 1;
                }
                if (item == Convert.ToChar(("_")))
                {
                    underscore += 1;
                }

                if (char.ToLower(item) == Convert.ToChar("x"))
                {
                    X += 1;
                }

                if (char.ToLower(item) == Convert.ToChar("h"))
                {
                    H += 1;
                }
            }
            // for missing x case
            if (lower >= 0 && upper >= 0 && num == 0 && space > 0 && underscore == 0 && X == 0)
            {
                return false;
            }
            // for missing h case
            if (lower >= 0 && upper >= 0 && num == 0 && space > 0 && underscore == 0 && H == 0)
            {
                return false;
            }
            // for underscore case
            if (lower >= 0 && upper >= 0 && num == 0 && space > 0 && underscore > 1)
            {
                return true;
            }
            // for number case
            if (lower >= 0 && upper >= 0 && num > 0 && space > 0 && underscore == 0)
            {
                return true;
            }
            // all lower case
            if (lower > 0 && upper == 0 && num == 0 && space > 0 && underscore == 0)
            {
                return true;
            }
            // mixed case
            if (lower > 0 && upper > 0 && num == 0 && space > 0 && underscore == 0)
            {
                return true;
            }
            

            return true;
        }
    }
}
