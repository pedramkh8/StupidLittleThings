
using LongestSubstring.Tools;
using System;

namespace LongestSubstring
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{

				Console.WriteLine("Enter Your String:");
				string content = Console.ReadLine();
				int longest = Substring.FindLongetSubstringWithoutRepeat(content);
				Console.WriteLine($"The Longest Substring Wothou Repeat Is: {longest}");
				

			}
		}
	}
}
