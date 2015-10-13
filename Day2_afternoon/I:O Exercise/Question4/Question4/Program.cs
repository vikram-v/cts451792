using System;
using System.Security.Cryptography;
using System.Text;
using System.IO;

namespace Question4
{
	class MainClass
	{

		/* Using a Key and an Initialization Vector */

		private static byte[] Key = new byte[8] {1, 2, 3, 4, 5, 6, 7, 8};
		private static byte[] IV = new byte[8] {1, 2, 3, 4, 5, 6, 7, 8};

		/* Function to encrypt text */

		public static string Encrypt(string text)
		{
			SymmetricAlgorithm algorithm = DES.Create();
			ICryptoTransform transform = algorithm.CreateEncryptor(Key, IV);
			byte[] inputbuffer = Encoding.Unicode.GetBytes(text);
			byte[] outputBuffer = transform.TransformFinalBlock(inputbuffer, 0, inputbuffer.Length);
			return Convert.ToBase64String(outputBuffer);
		}

		/* Function to decrypt text */

		public static string Decrypt(string text)
		{
			SymmetricAlgorithm algorithm = DES.Create();
			ICryptoTransform transform = algorithm.CreateDecryptor(Key, IV);
			byte[] inputbuffer = Convert.FromBase64String(text);
			byte[] outputBuffer = transform.TransformFinalBlock(inputbuffer, 0, inputbuffer.Length);
			return Encoding.Unicode.GetString(outputBuffer);
		}

		public static void Main (string[] args)
		{

			/* Reading text from Console */

			Console.WriteLine ("Enter text: ");
			string text = Console.ReadLine ();

			/* Encrypting text and writing to a file */

			string encryptedText = Encrypt(text);
			File.WriteAllText("EncryptedFile.txt", encryptedText);

			Console.WriteLine();

			/* Reading the encrypted file and printing the decypted text */

			string fileText = File.ReadAllText("EncryptedFile.txt");
			Console.WriteLine ("Decrypted text: " + Decrypt(fileText));
		}
	}
}
