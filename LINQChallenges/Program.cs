using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQChallenges
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            var wordsWithTH = words.Where(w => w.Contains("th"));
            foreach (var word in wordsWithTH)
            {
                Console.WriteLine($"{ word}");
            }
            Console.ReadLine();

            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            var noDuplicates = names.Distinct();
            foreach (var name in noDuplicates)
            {
                Console.WriteLine($"{name}");
            }
            Console.ReadLine();


            List<string> classGrades = new List<string>()
                {
                    "80,100,92,89,65",
                    "93,81,78,84,69",
                    "73,88,83,99,64",
                    "98,100,66,74,55"
                };
            List<double> gradeList = new List<double>();
            foreach (string grade in classGrades)
            {
                var gradeArray = grade.Split(',').Select(int.Parse).ToArray().OrderByDescending(g => g);
                var nonLowNumberGrade = gradeArray.Take(gradeArray.Count() - 1);
                foreach (double gradeTwo in nonLowNumberGrade)
                {
                    gradeList.Add(gradeTwo);
                }
            }
            double avgavg = gradeList.Sum() / gradeList.Count();
            Console.WriteLine(avgavg);
            Console.ReadLine();

            string namer = "mommaerts";

            var letterToArray = namer.ToUpper().ToCharArray();
            var lettersToNumbers = letterToArray.GroupBy(l => l).ToDictionary( l=> l.Key, l => l.Count()).OrderBy(l => l.Key);
            var final = lettersToNumbers.Select(l => $"{l.Key}{l.Value}");

            Console.ReadLine();
        }
    }
}
