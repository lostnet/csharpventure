using System;
using System.IO;
using System.Text;
using System.Security.Cryptography;

// A basic test of crypto random in C#
// csc randr.cs ; mono randr.exe
public class Randr
{
	public static void Main(string[] args)
	{
		byte[] buffer = new byte[32];
		RandomNumberGenerator rng = RNGCryptoServiceProvider.Create();
		rng.GetBytes(buffer);
		Console.WriteLine("Result Hex: "+ BitConverter.ToString(buffer));
		Console.WriteLine("Result Base64: "+ Convert.ToBase64String(buffer));
	}

}
