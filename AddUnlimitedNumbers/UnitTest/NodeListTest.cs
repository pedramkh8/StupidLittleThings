using AddUnlimitedNumbers.Class;
using Xunit;

namespace UnitTest
{
	public class NodeListTest
	{
		[Fact]
		public void Add_RightScenario2()
		{
			//Arrange
			NodeList first = new NodeList("99999");
			NodeList second = new NodeList("9999999");
			NodeList result = first.Add(first, second);

			//Action
			string resultToShow = string.Empty;

			while (result != null)
			{
				resultToShow += result.Value.ToString();
				result = result.Next;
			}

			//Assertion
			Assert.Equal("89999001", resultToShow);
		}

		[Fact]
		public void Add_RightScenario1()
		{
			//Arrange
			NodeList first = new NodeList("99");
			NodeList second = new NodeList("999");
			NodeList result = first.Add(first, second);

			//Action
			string resultToShow = string.Empty;

			while (result != null)
			{
				resultToShow += result.Value.ToString();
				result = result.Next;
			}

			//Assertion
			Assert.Equal("8901", resultToShow);
		}

		[Fact]
		public void Add_RightScenario3()
		{
			//Arrange
			NodeList first = new NodeList("0000111");
			NodeList second = new NodeList("000999");
			NodeList result = first.Add(first, second);

			//Action
			string resultToShow = string.Empty;

			while (result != null)
			{
				resultToShow += result.Value.ToString();
				result = result.Next;
			}

			//Assertion
			Assert.Equal("0009012", resultToShow);
		}
	}
}
