using System;

namespace Test20220508
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string s = "The Chicago Bears are a professional American football team based in Chicago, Illinois. The Bears compete in the National Football League as a member club of the league's National Football Conference North division.";//"mary had a little lamb whos fleece was white as snow";
            Console.WriteLine("{0} {1}", s, Solution.Solution5(s));
         }
    }
}
