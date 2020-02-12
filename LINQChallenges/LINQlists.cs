using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQChallenges
{
    class LINQlists
    {
        //Member Variables (HAS A)

        //Constructor
        public LINQlists()
        {
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
        }

        //Member Methods (CAN DO)
        public void FindTH()
        {
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            var wordsWithTH = words.Where(w => w.Contains("th"));
            foreach (var word in words)
            {
                Console.WriteLine($"{ word}");
            }
        }

    }
}
