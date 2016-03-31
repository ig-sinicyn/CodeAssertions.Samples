using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeJam;

namespace CodeAssertions.Samples
{
	class Program
	{
		static void Main(string[] args)
		{
			var evenNumber = 11; // bad value

			Code.AssertState(evenNumber % 2 == 0, "You shall not pass!");

			Console.WriteLine($"{evenNumber} is even.");

			Console.WriteLine("\r\nDone.");
			Console.ReadKey();
		}
	}
}
