using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using static BinarySearcher.BinarySearcher;

namespace SearcherTest
{
	[TestClass]
	public class SearcherUnitTests
	{
		[TestMethod]
		public void EsperadoEncontrarNoveNoSearcher()
		{
			List<int> list = new List<int>() { 3, 5, 7, 9, 11 };
			int item = 9;		

			if (Searcher(list, item) != 9)
				throw new ArgumentException("Esperado encontrar nove.");
		}

		[TestMethod]
		public void EsperadoEncontrarDoisNoSearcher()
		{
			List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
			int item = 2;

			if (Searcher(list, item) != 2)
				throw new ArgumentException("Esperado encontrar dois.");
		}

		[TestMethod]
		public void EsperadoNaoEncontrarOItemNaLista()
		{
			List<int> list = new List<int>() { 1, 2, 5, 9, 11, 17, 33 };
			int item = 13;

			if (Searcher(list, item) != -1)
				throw new ArgumentException("O número 13 não pertence a lista proposta.");
		}
	}
}
