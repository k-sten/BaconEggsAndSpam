using System;
using System.Linq;

namespace BaconEggsAndSpam
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputfile = System.IO.File.ReadAllText(@"input.txt");
            string[] input = inputfile.Split("\n");

            Console.WriteLine(input[0]);

            Array.Sort<string>(input);

            foreach (var line in input)
            {
                Console.WriteLine(line);
            }

            inputfile.
        }
    }
}
