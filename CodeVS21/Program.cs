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

            game.ReadPacks();
            game.WriteAnswers();
        }
    }
}
