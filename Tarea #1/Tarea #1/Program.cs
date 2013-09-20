/*
 * Created by SharpDevelop.
 * User: Aula1
 * Date: 17/09/2013
 * Time: 07:12 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Tarea__1
{
	class Program
	{
		
		public static void Main(string[] args)
			
		{
			persona p=new persona();
		
			Console.WriteLine("Ingrese su nombre: \n");
			p.nombre= Console.ReadLine();
			
			Console.WriteLine("ingrese su edad: \n");
			p.edad= Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine("ingrese su correo: \n");
			p.correo= Console.ReadLine();
			
			
			Console.WriteLine("Sus datos son: \n " + p.nombre + "\n" + p.edad + "\n" + p.correo);
			
			Console.Write(" Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
