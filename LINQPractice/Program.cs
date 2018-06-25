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
			foreach(string result in resultWords)
			{
				Console.WriteLine(result);
			}

			Console.ReadLine();
		}
		
	}

}
