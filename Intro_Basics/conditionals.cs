using System;

public class Test
{
	
	public static void Main()
	{
		// A "conditional" statement makes decision and changes what code gets executed
		
		int numberVariable = 1;

		// if / else
		if(numberVariable > 2) 
		{
			Console.WriteLine("GREATER THAN 2");
		}
		else 
		{
			Console.WriteLine("LESS THAN 2");
		}

		// Switch statement
		switch(numberVariable) 
		{
			case 1:
				Console.WriteLine("Found 1");
				break;
			case 2:
				Console.WriteLine("Found 2");
				break;
			case 3:
				Console.WriteLine("Found 3");
				break;
			default:
				Console.WriteLine("Something else");
				break;
		}
		
		// BONUS: What does this do?
		//Console.WriteLine(numberVariable > 2 ? "Apple" : "Banana");
	}
}
