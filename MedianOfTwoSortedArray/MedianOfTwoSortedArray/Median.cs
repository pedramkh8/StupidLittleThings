namespace MedianOfTwoSortedArray
{
	public static class Median
	{
		/// <summary>
		/// O(Log(n))
		/// </summary>
		/// <param name="nums1"></param>
		/// <param name="nums2"></param>
		/// <returns></returns>
		public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
		{
			int[] nums3 = new int[nums1.Length + nums2.Length];

			for (int i = 0; i < nums1.Length; i++)
			{
				nums3[i] = nums1[i];
			}

			for (int i = 0; i < nums2.Length; i++)
			{
				nums3[nums1.Length + i] = nums2[i];
			}

			nums3 = nums3.MergeSort();

			if ((nums3.Length % 2) == 1)
			{
				return nums3[nums3.Length / 2];
			}

			return (nums3[nums3.Length / 2 - 1] + nums3[nums3.Length / 2]) / 2d;
		}

	}
}
