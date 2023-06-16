using System;
using System.Collections.Generic;
using LINQ;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> vidGames= new List<string>
            { "Mortal Kombat", "God of War", "Splinter Cell", "Super Smash Bros.", "Madden"};

            int minLength = 0;

            IEnumerable<string> longestNames = vidGames.Where(name => name.Length > minLength);

            vidGames = vidGames.OrderBy(name => name.Length).ToList();

            foreach (var name in vidGames)
            {

                Console.WriteLine(name);
            }

        }
    }
}
