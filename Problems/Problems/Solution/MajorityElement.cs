using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Solution
{
	public class MajorityElement
	{
		public MajorityElement()
		{
			int[] numbers = { 6, 6, 6, 7, 7 };

			Console.WriteLine(MajorityElementHelper(numbers));
		}

		private int MajorityElementHelper(int[] numbers)
		{
			int totalCount = 0;
			int maxCount = 0;
			int selectedNumber = 0;
			int length = 0;
			Array.Sort(numbers);

			if(numbers.Length < 2)
			{
				return numbers[0];
			}
		

			while(length < (numbers.Length - 1))
			{
				if (numbers[length] == numbers[length + 1])
				{ 
					maxCount++;

					if(maxCount > totalCount)
					{
						selectedNumber = numbers[length];
						totalCount = maxCount;
					}
				}
				else
				{
					maxCount = 0;
				}

				length++;
			}

			return selectedNumber;
		}
	}
}
