using System;
using CalculadoraTest.Regras;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UniTestProject
{
	[TestClass]
	public class UniTest
	{
		[TestMethod]
		public void Soma()
		{
			var p = CalculadoraRegras.Somar(7, 6);
			Assert.AreEqual(p, 13);
		}
		[TestMethod]
		public void Subtracao()
		{
			var s = CalculadoraRegras.Subtrair(6, 2);
			Assert.AreEqual(s, 4);
		}
		[TestMethod]
		public void Multiplicacao()
		{
			var m = CalculadoraRegras.Multiplicar(7, 6);
			Assert.AreEqual(m, 42);
		}
		[TestMethod]
		public void Divisao()
		{
			var d = CalculadoraRegras.Dividir(6, 2);
			Assert.AreEqual(d, 3);
		}
		[TestMethod]
		public void NegativoResultado()
		{
			var nr = CalculadoraRegras.Subtrair(2, 6);
			Assert.AreEqual(nr, -4);
		}
		[TestMethod]
		public void NegativoOperador()
		{
			var no = CalculadoraRegras.Subtrair(-2, -6);
			Assert.AreEqual(no, 4);
		}
		[TestMethod]
		public void ResultDescimal()
		{
			var rd = CalculadoraRegras.Dividir(2, 10);
			Assert.AreEqual(rd, 0.2);
		}
		[TestMethod]
		public void Dizma()
		{
			var td = CalculadoraRegras.Dividir(2, 6);
			td = CalculadoraRegras.Multiplicar(td, 9);
			Assert.AreEqual(td, 3);
		}
		[TestMethod]
		public void QuadradoDeRaiz()
		{
			var qr = Math.Sqrt(2);
			qr = CalculadoraRegras.Multiplicar(qr, qr);
			Assert.AreEqual(qr, 2);
		}
		[TestMethod]
		public void ExtouroDePosicoes_Decimal() // Teste na calculadora da errado
		{
			var ep = CalculadoraRegras.Somar(8888888888888888888, 0.8888888888888888888);
			ep = CalculadoraRegras.Subtrair(ep, 8888888888888888888);
			Assert.AreEqual(ep, 0.8888888888888888888);
		}
		[TestMethod]
		public void ExtouroDePosicoes_Negativo() // Teste na calculadora da certo
		{
			var ep = CalculadoraRegras.Multiplicar(8888888888888888888, -10);
			ep = CalculadoraRegras.Dividir(ep, -8888888888888888888);
			Assert.AreEqual(ep, 10);
		}
	}
}
