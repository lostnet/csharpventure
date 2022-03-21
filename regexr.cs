using System;
using System.IO;
using System.Text.RegularExpressions;

// A basic test of file ops and regexes in C#
// csc regexr.cs ; mono regexr.exe
// csc regexr.cs ; mono regexr.exe regexr.cs regexr.out
public class RegExr
{
	public static void Main(string[] args)
	{
		byte[] buffer; 
		string text = "an example text if no file was used.";
		if (args.Length > 0 && File.Exists(args[0]))
		{
			buffer = File.ReadAllBytes(args[0]);
			text = System.Text.Encoding.UTF8.GetString(buffer);
		}
		text = Regex.Replace(text, @"example", "(Example)");
		if (args.Length > 1) {
			buffer = System.Text.Encoding.UTF8.GetBytes(text);
			File.WriteAllBytes(args[1], buffer);
		}
		Console.WriteLine("Result: "+ text);
	}

}
