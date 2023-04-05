using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SearcherTest
{
	[TestClass]
	public class SearcherUnitTests
	{
		[TestMethod]
		public void EsperadoEncontrarNoveNaPosicaoTres()
		{
			List<uint> list = new List<uint>() { 3, 5, 7, 9, 11 };
			uint item = 9;

			var searcher = new BinarySearcher.BinarySearcher();

			if (searcher.Search(list, item) != list.IndexOf(item))
				throw new ArgumentException("Esperado encontrar o nove na posição 3.");
		}

		[TestMethod]
		public void EsperadoEncontrarDoisNaPosicaoUm()
		{
			List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
			int item = 2;

			var searcher = new BinarySearcher.BinarySearcher();

			if (searcher.Search(list, item) != list.IndexOf(item))
				throw new ArgumentException("Esperado encontrar dois na posição 1.");
		}

		[TestMethod]
		public void EsperadoNaoEncontrarOItemNaLista()
		{
			List<long> list = new List<long>() { 1, 2, 5, 9, 11, 17, 33 };
			long item = 13;

			var searcher = new BinarySearcher.BinarySearcher();

			if (searcher.Search(list, item) != -1)
				throw new ArgumentException("O número 13 não pertence a lista proposta.");
		}

		[TestMethod]
		public void ListaVaziaDeveRetornarMenosUm()
		{
			var searcher = new BinarySearcher.BinarySearcher();

			if (searcher.Search(null, 13) != -1)
				throw new ArgumentException("");
		}

		[TestMethod]
		public void ListaSemNumerosDeveRetornarMenosUm()
		{
			List<int> list = new List<int>() { };
			int item = 13;

			var searcher = new BinarySearcher.BinarySearcher();

			if (searcher.Search(list, item) != -1)
				throw new ArgumentException("A lista está vazia.");
		}
	}
}
