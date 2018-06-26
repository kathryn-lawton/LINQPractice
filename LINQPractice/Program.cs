using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPractice
{
	class Program
	{
		static void Main(string[] args)
		{

			List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };

				var resultWords = words.Where(w => w.Contains("th"));
				foreach (string result in resultWords)
				{
					Console.WriteLine(result);
				}

			Console.WriteLine();
			Console.WriteLine();

			List<string> names = new List<string>() { "Mike", "Dan", "Scott", "Nick", "Mike" };

			IEnumerable<string> distinctNames = names.Distinct();
			foreach(string result in distinctNames)
			{
				Console.WriteLine(result);
			}
			Console.WriteLine();
			Console.WriteLine();


			List<string> classGrades = new List<string>()
			{
				"80, 100, 92, 89, 65",
				"93, 81, 78, 84, 69",
				"73, 88, 83, 99, 64",
				"98, 100, 66, 74, 55"
			};

			var classGrade = classGrades.Select(c => c.Split(',').Select(x => int.Parse(x)).OrderBy(x => x).Skip(1).Average()).Average();
			Console.WriteLine(classGrade);

			Console.ReadLine();

			Console.WriteLine();
			Console.WriteLine();


			string input = "mississippi";

			var inputFrequency = input.OrderBy(x => x).GroupBy(x => x).Select(x => x);
			string resultLetters = "";
			foreach(var letter in inputFrequency)
			{
				int count = letter.Count();
				resultLetters += $"{count}{letter.First()}";
			}
			Console.WriteLine(resultLetters);

			Console.ReadLine();
		}
		
	}

}
