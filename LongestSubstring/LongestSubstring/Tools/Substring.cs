using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestSubstring.Tools
{
	public static class Substring
	{
		public static int FindLongetSubstringWithoutRepeat(string content)
		{
			if (content.Length == 0)
			{
				return 0;
			}

			if (content.Length == 1)
			{
				return 1;
			}

			Dictionary<char, int> tempList = new Dictionary<char, int>();
			List<int> counters = new List<int>();
			int counter = 0;

			for (int i = 0; i < content.Length; i++)
			{
				if (tempList.Keys.Contains(content[i]))
				{
					counters.Add(counter);
					counter = 0;
					i = tempList.GetValueOrDefault(content[i]);
					tempList.Clear();
				}
				else
				{
					tempList.Add(content[i], i);
					counter++;
				}
			}

			counters.Add(counter);

			return counters.Max();
		}
	}
}
