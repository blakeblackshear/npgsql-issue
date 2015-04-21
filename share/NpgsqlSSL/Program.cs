using System.Net;
using System.IO;

namespace NpgsqlSSL
{
	using System;

	class Program
	{
		static void Main(string[] args)
		{
			var getRequest = WebRequest.Create("https://aws.amazon.com");

			Stream stream = getRequest.GetResponse().GetResponseStream();

			StreamReader reader = new StreamReader(stream);

			Console.WriteLine(reader.ReadLine());
			Console.ReadLine ();
		}
	}
}