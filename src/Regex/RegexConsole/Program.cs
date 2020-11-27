using System;
using RegexLib;
namespace RegexConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MatchCollection matches = new MatchCollection();
            foreach(Match match in matches)
            {
                Console.WriteLine(match.ToString());
            }
        }
    }
}
