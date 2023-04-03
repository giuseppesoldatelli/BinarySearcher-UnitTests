using System;
using System.Collections.Generic;
using System.Linq;
using static BinarySearcher.BinarySearcher;

namespace BinarySearch
{
	class Program
	{		
		public static void Main(string[] args)
		{
			List<int> list = new List<int>() { 3, 5, 7, 9, 11 };

			Console.WriteLine(Searcher(list, 5));

			Console.ReadLine();
		}
	}


}


