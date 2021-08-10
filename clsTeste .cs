/*
 * Created by SharpDevelop.
 * User: lucas
 * Date: 24/05/2021
 * Time: 15:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace TesteRedeService
{
	public class clsTeste
	{
		private int codigo;
		private string descricao;
		
		public int Codigo
		{ 
			get { return this.codigo; }
			set { codigo = value; }
		}
	
		public string Descricao 
		{ 
			get { return this.descricao; } 
			set { descricao = value; }
		}
	}
}
