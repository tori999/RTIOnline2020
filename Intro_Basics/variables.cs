using System;

public class Test
{
	
	public static void Main()
	{
		// Talk about data types
		
		int numberVariable = 1;
		double fractionVariable = 0.25;
		string stringVariable = "i_am_a_string";
		
		Console.WriteLine(numberVariable);
		Console.WriteLine(fractionVariable);
		Console.WriteLine(stringVariable);
		
		// Some variables have "dynamic typing", C# can do both
		
		var autoVariable = numberVariable * fractionVariable;
		
		Console.WriteLine(autoVariable);
		
		// What is the type of autoVariable??
		
		// BONUS: Talk about casting
		// Console.WriteLine((string)autoVariable); // what happens here??
	}
}
