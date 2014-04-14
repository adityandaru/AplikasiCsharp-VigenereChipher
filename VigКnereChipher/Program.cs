/*
 * Created by SharpDevelop.
 * User: Ndaru
 * Date: 01/05/2013
 * Time: 21:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace VigènereChipher
{
	
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello ndaru!");
			Console.WriteLine("Contoh Vigènere ");
			cod cd = new cod();
			cd.SetAlfabet();
			cd.InputPlaiNSet();
			cd.InputKunciNSet();
			cd.SetDataH();
			
			cd.ResumePlainText();
			cd.ResumeKunci();
			cd.finish();
			Console.ReadKey(true);
		}
	}
}