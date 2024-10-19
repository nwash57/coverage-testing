namespace ClassLib;

public class SomeClass : ISomeClass
{
	public int DoSomething(int input)
	{
		if (input % 2 == 0)
		{
			return input * 2;
		}

		if (input % 3 == 0)
		{
			return input * 3;
		}

		if (input % 5 == 0)
		{
			return input * 5;
		}

		if (input % 7 == 0)
		{
			return input * 7;
		}

		return input;
	}
}

public interface ISomeClass
{
	int DoSomething(int input);
}