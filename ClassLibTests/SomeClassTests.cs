using ClassLib;

namespace TestProject1;

[TestClass]
public class SomeClassTests
{
	protected SomeClass Target = new SomeClass();

	[TestMethod]
	[DataRow(2, 4)]
	[DataRow(0, 0)]
	[DataRow(6, 12)]
	public void WhenInputDivisibleByTwo_ShouldReturnInputTimesTwo(int input, int expected)
	{
		var result = Target.DoSomething(input);

		Assert.AreEqual(expected, result);
	}
}