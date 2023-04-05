using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using BinarySearcher;

namespace BinarySearch
{
	class Program
	{		
		public static void Main(string[] args)
		{
			List<int> list = new List<int>() { 3, 5, 7, 9, 11 };
			int item = 9;

			var searcher = new BinarySearcher.BinarySearcher();

			Console.WriteLine(searcher.Search(list, item));

			Console.ReadLine();
		}
	}


}


