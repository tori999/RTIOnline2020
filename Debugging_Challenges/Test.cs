using System;

public class DebugChallengeTest
{
	public static void Main()
	{
        int i = 0;
        for(int j = 1; j <= 10; j++) {
            Console.WriteLine(j * i);
            i += 1;
        }
	}
}
