using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeVS21
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            var game = new GameInfo(str);

            // Example #4: Append new text to an existing file
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\WriteLines2.txt", true);

            string line;

            for (int i = 0; i < 5000; i++)
            {
                line = Console.ReadLine();
            }

            file.Close();

            Console.WriteLine("2 0");
            for (int i = 0; i < game.NumberOfBlocks; i++)
            {
                Console.WriteLine("2 0");
            }
        }
    }
}
