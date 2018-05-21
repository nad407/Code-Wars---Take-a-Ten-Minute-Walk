using System;

namespace Kata
{
    public class main
    {
       public static void Main(string[] args)
        {
            bool valid = TenMinuteWalk.IsValidWalk(new string[] { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s" });
            Console.WriteLine(valid);
            Console.ReadKey();
        }
    }
}
