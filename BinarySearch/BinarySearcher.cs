using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearcher
{
	public class BinarySearcher
	{
		private readonly List<int> _list;
		private readonly int _item;
			
		public BinarySearcher(List<int> list, int item)
		{
			_list = list;
			_item = item;
		}

		public static int Searcher(List<int> list, int item)
		{
			int min = 0;
			int max = list.Count - 1;			

			while (min <= max)
			{
				int mid = (max + min) / 2;

				if (list[mid] == item)
				{
					mid = item;
					return mid;
				}
				if (list[mid] > item)
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
