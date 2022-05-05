using System;
namespace Exercises
{
    public class Exercise003
    {
        // Replace the exception statement below with your code!
        public string[] IceCreamFlavours = new string[6]
            { "Pistachio", "Raspberry Ripple", "Vanilla", "Mint Chocolate Chip", "Chocolate", "Mango Sorbet" };

        // Replace the exception statement below with your code!
        public int IceCreamCode(string iceCreamFlavour)
        {
            return Array.IndexOf(IceCreamFlavours, iceCreamFlavour);
        }
    }
}
