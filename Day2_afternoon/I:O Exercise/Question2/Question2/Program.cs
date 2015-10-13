using System;
using System.IO;

namespace Question2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			copyContent ("OriginalDirectory", "CopyDirectory");
		}

		private static void copyContent(string sourceDirectory, string destinationDirectory)
		{
			DirectoryInfo directory = new DirectoryInfo(sourceDirectory);

			DirectoryInfo[] directoryContent = directory.GetDirectories();

			/* Creating a new directory */

			Directory.CreateDirectory(destinationDirectory);

			/* Copying the files from source directory to destination directory */

			FileInfo[] files = directory.GetFiles();
			foreach (FileInfo file in files)
			{
				string path = Path.Combine(destinationDirectory, file.Name);
				file.CopyTo(path, false);
			}

			// Copying the directories from source directory to destination directory */

			foreach (DirectoryInfo subDirectory in directoryContent)
			{
				string path = Path.Combine(destinationDirectory, subDirectory.Name);
				copyContent(subDirectory.FullName, path);
			}
		}

	}
}