using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restarant
{
	public class Program
	{
		static void Main(string[] args)
		{
			Cook NewCook = new Cook("Bob", true);
		bool pizzajobVallid = NewCook.validPizza();
			Console.WriteLine(pizzajobVallid);

		}
	}
}
