using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearcher
{
	public class BinarySearcher
	{
		public int Search<T>(List<T> list, T item) where T : IComparable
		{
			if ((list == null) || (list.Count == 0)) 
			{
				return -1;
			}	

			int min = 0;
			int max = list.Count - 1;			

			while (min <= max)
			{
				int mid = (max + min) / 2;
				T itemMid = list.ElementAt(mid);
				var comparison = item.CompareTo(itemMid);

				if (comparison == 0)
				{					
					return mid;
				}
				if (comparison < 0)
				{
					max = mid - 1;
				}
				else
				{
					min = mid + 1;
				}
			}
			return -1;
		}
	}
}
