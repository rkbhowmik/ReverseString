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
			Console.WriteLine("******** A program to reverse an input string using helper method********\n\n ");

			Console.Write("Enter your word: ");
			var input = Console.ReadLine();

			Console.Write("Results:");

			DisplayResult(
			ReverseString(input));

			Console.ReadLine();
		}

			private static string ReverseString(string message)
			{
				char[] messageArray = message.ToArray();
				Array.Reverse(messageArray);
				return String.Concat(messageArray);
			}

			private static void DisplayResult(string reversedLine)
			{
				Console.WriteLine("{0}", reversedLine); 
			}
		}
	}


