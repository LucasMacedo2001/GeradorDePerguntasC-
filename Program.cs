/*
 * Created by SharpDevelop.
 * User: lucas
 * Date: 24/05/2021
 * Time: 14:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TesteRedeService
{
	class Program
	{
		public static void Main(string[] args)
		{
			clsTeste clsTeste = new clsTeste{ Codigo = 1000, Descricao = "Teste"}
			
			string retorno = Console.ReadLine();
			string listaNumeros = "";
			
			StreamWriter arquivoNumerosOrdenados;
			
			arquivoNumerosOrdenados = File.CreateText("C:/Users/lucas/Downloads/arquivoNumerosOrdenados.txt");
			
			for(int cont = 0; cont < retorno.Length; cont++)
			{
				if (retorno[cont] >= (char)(48) && retorno[cont] <= (char)(57))
				{
					listaNumeros += retorno[cont];
				}
			}
			
			char [] numerosOrdenados = listaNumeros.ToCharArray();
			Array.Sort(numerosOrdenados);
			
			for(int cont = 0; cont < numerosOrdenados.Length; cont++)
			{
				arquivoNumerosOrdenados.WriteLine(numerosOrdenados[cont]);
			}
			
			arquivoNumerosOrdenados.Close();
			
			Console.ReadKey(true);
		}
	}
}
	