using System;
using SimpleFactory.Common;

namespace SimpleFactory.Application
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var eagle = BirdFactory.GetBird("Eagle");
            var swan = BirdFactory.GetBird("Swan");

            Console.WriteLine($"Bird Name : {eagle.Name}");
            Console.WriteLine($"Bird Name : {swan.Name}");
        }
    }
}