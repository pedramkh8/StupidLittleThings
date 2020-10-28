using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MedianOfTwoSortedArray
{
	class Program
	{
		static void Main(string[] args)
		{

			while (true)
			{
				Console.WriteLine("Enter The First Array Cama Separate:");
				string array = Console.ReadLine();
				int[] nums1 = Regex
								.Replace(array, @"\s+", "")
								.Split(',').Select(x => Int32.Parse(x)).ToArray();

				Console.WriteLine("Enter The Second Array Cama Separate:");
				array = Console.ReadLine();
				int[] nums2 = Regex
								.Replace(array, @"\s+", "")
								.Split(',').Select(x => Int32.Parse(x)).ToArray();


				Console.WriteLine($"Result: {Median.FindMedianSortedArrays(nums1, nums2)}");
			}
		}
	}
}
