using System;

namespace StaticMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Forest f = new Forest("Columbia");
            Forest.PrintTreeFacts();
            f.Burn();
            f.Grow();
            f.Grow();
            Console.WriteLine(f.Trees);


        }
    }
}
