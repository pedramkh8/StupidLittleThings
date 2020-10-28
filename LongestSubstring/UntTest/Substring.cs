using Xunit;

namespace UntTest
{
	//"au"
	//" "
	//"  "
	//""
	//"888888"
	//"aab"
	//"yutyiiiituter"
	public class Substring
	{
		[Fact]
		public void FindLongetSubstringWithoutRepeat_RightScenario1()
		{
			//Action
			var result = LongestSubstring.Tools.Substring.FindLongetSubstringWithoutRepeat("au");
			//Assert
			Assert.Equal(2, result);
		}

		[Fact]
		public void FindLongetSubstringWithoutRepeat_RightScenario2()
		{
			//Action
			var result = LongestSubstring.Tools.Substring.FindLongetSubstringWithoutRepeat(" ");
			//Assert
			Assert.Equal(1, result);
		}

		[Fact]
		public void FindLongetSubstringWithoutRepeat_RightScenario3()
		{
			//Action
			var result = LongestSubstring.Tools.Substring.FindLongetSubstringWithoutRepeat("  ");
			//Assert
			Assert.Equal(1, result);
		}

		[Fact]
		public void FindLongetSubstringWithoutRepeat_RightScenario4()
		{
			//Action
			var result = LongestSubstring.Tools.Substring.FindLongetSubstringWithoutRepeat("");
			//Assert
			Assert.Equal(0, result);
		}

		[Fact]
		public void FindLongetSubstringWithoutRepeat_RightScenario5()
		{
			//Action
			var result = LongestSubstring.Tools.Substring.FindLongetSubstringWithoutRepeat("88888");
			//Assert
			Assert.Equal(1, result);
		}

		[Fact]
		public void FindLongetSubstringWithoutRepeat_RightScenario6()
		{
			//Action
			var result = LongestSubstring.Tools.Substring.FindLongetSubstringWithoutRepeat("abcbefghijk");
			//Assert
			Assert.Equal(9, result);
		}

		[Fact]
		public void FindLongetSubstringWithoutRepeat_RightScenario7()
		{
			//Action
			var result = LongestSubstring.Tools.Substring.FindLongetSubstringWithoutRepeat("aab");
			//Assert
			Assert.Equal(2, result);
		}
	}
}
