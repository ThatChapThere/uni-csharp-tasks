using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903MWorkshopCode
{
    public static class Output
    {
		public static void email(string message)
		{
			Console.WriteLine($"Email: {message}");
		}

		public static void txt(string message)
		{
			Console.WriteLine($"TXT: {message}");
		}
	}
}
