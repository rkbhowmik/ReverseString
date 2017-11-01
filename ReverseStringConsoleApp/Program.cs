using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStringConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("******** A program to reverse an input string ********\n\n ");

			Console.Write("Enter your word: ");
			var input = Console.ReadLine();
			char[] inputarr = input.ToCharArray();
			Array.Reverse(inputarr);
			Console.WriteLine("Reversed order: " + new String(inputarr)); 
			Console.ReadLine();
		}
	}
}
