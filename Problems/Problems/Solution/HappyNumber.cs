using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Solution
{
	public class HappyNumber
	{
		public HappyNumber()
		{
			int number = 2;

			Console.WriteLine(HappyNumberHelper(number));
		}

		private bool HappyNumberHelper(int number)
		{

			int totalNumber = 0;

			while (totalNumber > -1)
			{


				if(number > 0)
				{
					int modNumber = (number % 10);

					totalNumber += modNumber * modNumber;
					number = number / 10;
				}
                else
                {

					if(totalNumber == 1)
					{
						return true;
					}
					else
					{
						number = totalNumber;

						totalNumber = 0;
					}

                }

			}

			return false;

		}
	}
}
