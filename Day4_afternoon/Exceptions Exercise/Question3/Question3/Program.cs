using System;
using System.IO;

namespace Question3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			try
			{
				string path;
				Console.Write("Enter File Path : ");
				path = Console.ReadLine();
				Console.WriteLine("The content of file" + " :" + File.ReadAllText(path));
			}

			/* File Not Found Exception */

			catch(FileNotFoundException e){
				Console.WriteLine (e.Message);
			}

			/* File Load Exception */

			catch(FileLoadException e){
				Console.WriteLine (e.Message);
			}

			/* Format Exception */

			catch(FormatException e){
				Console.WriteLine (e.Message);
			}
				
			/* Exception */

			catch(Exception e)
			{
				Console.WriteLine (e.Message);
			}
		}
	}
}