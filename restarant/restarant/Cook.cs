using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restarant
{
	public class Cook : Employee

	{
		bool PizzaOven = false;
		bool prepWork = false;

		public Cook(String Name, bool WorkingStatus)
		{
			name = Name;
			workingStatus = WorkingStatus;

		}
		public bool validPizza()
		{
			PizzaOven = true;
			return PizzaOven;
		}
		public bool validPrepWORK()
		{
			prepWork = true;
			return prepWork;

		}

	}

}
