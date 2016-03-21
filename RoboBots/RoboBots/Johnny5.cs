using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboBots
	{
	public class Johnny5 : RobotChassis

		{
		

		public Johnny5 (string name, int powerLevel)
			{

			}


		public string j5OffenseMenu ()
		
				{

				
			
			for (int i = 0; i < 5; i++)
				
				Console.WriteLine("\nFor your offensive strike do you wnat to...\n\nThrow sticks  --  1\nThrow stones  --  2\nSay bad words  --  3/n");
			 string choiceValue = (Console.ReadLine());
			Console.WriteLine(choiceValue);
			Console.Clear();
			return choiceValue;
			
			//if case
				

			}
		}
		}
	
		
	

	
