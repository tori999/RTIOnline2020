using System;

public class Test
{
	
	public static void Main()
	{
		var separator = "----";
		
		// A "loop" runs a particular block of code more than once, based on a built-in condition
		// Often more than one way to get the job done

		for(int i = 0; i < 10; i++) 
		{
			Console.WriteLine(i);
		}
		
		Console.WriteLine(separator);
		
		int w = 10;
		while(w > 0) 
		{
			Console.WriteLine(w);
			w--; // special decrement operator
		}
	
		Console.WriteLine(separator);
		
		w = 10; // why no "int" here??
		do 
		{
			Console.WriteLine(w);
			w--; // special decrement operator			
		} while (w > 0);
			
		// What is the difference between the last two loops?
	}
}
