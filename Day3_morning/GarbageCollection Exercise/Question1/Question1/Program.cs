using System;

class Program
{
	static void Main()
	{

		/* Getting memory in bytes */

		long initialBytes = GC.GetTotalMemory(false); 

		/* After 10 million bytes are allocated */

		byte[] memory = new byte[1000 * 1000 * 10];
		memory[0] = 1;
		long usedBytes = GC.GetTotalMemory(false);

		/* After garbage collection */

		long finalBytes = GC.GetTotalMemory(true);

		Console.WriteLine(initialBytes);
		Console.WriteLine(usedBytes);
		Console.WriteLine(finalBytes - usedBytes);

	}
}