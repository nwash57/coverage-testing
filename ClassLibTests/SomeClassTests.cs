using ClassLib;

namespace TestProject1;

[TestClass]
public class SomeClassTests
{
	protected SomeClass Target = new SomeClass();

	public void BaseTest(int input, int expected)
	{
		var result = Target.DoSomething(input);
		Assert.AreEqual(expected, result);
	}
	
	[TestMethod]
	[DataRow(2, 4)]
	[DataRow(0, 0)]
	[DataRow(6, 12)]
	public void WhenInputDivisibleByTwo_ShouldReturnInputTimesTwo(int input, int expected)
	{
		BaseTest(input, expected);
	}

	[TestMethod]
	[DataRow(3, 9)]
	[DataRow(6, 12)]
	[DataRow(9, 27)]
	public void WhenInputIsDivisibleByThree_AndNotDivisibleByTwo_ShouldReturnInputTimesThree(int input, int expected)
	{
		BaseTest(input, expected);
	}

	[TestMethod]
	[DataRow(7, 49)]
	[DataRow(14, 28)]
	[DataRow(21, 63)]
	public void WhenInputIsOnlyDivisibleBySeven_ShouldReturnInputTimesSeven(int input, int expected)
	{
		BaseTest(input, expected);
	}
}