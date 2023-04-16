using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace HelloWorld
{
	class CiclosYCondicionales
	{
		static void Main(string[] args)
		{
			/*for (int i = 0; i <= 2; i++)
			{
				for (int x = 0; x <= 5; x++)
				{
					Thread.Sleep(500);
					Console.Write(x);

				}
				Console.WriteLine();
			}
			Console.WriteLine();

			for (int i = 0; i <= 5; i++)
			{
				for (int x = 0; x <= i; x++)
				{
					Thread.Sleep(500);
					Console.Write("Resultado {0}", x);

				}
				Console.WriteLine();
			}
			Console.WriteLine();


			int num = 1;

			for (int i = 1; i <= 100; i++)
			{
				if (i == 9)
				{
					break;
				}

				num *= i;
				Thread.Sleep(500);
				Console.WriteLine(num);
			}
			Console.WriteLine(num);


			char[] alphabet = new char[30];

			for (int i = 0; i <= alphabet.Length; i++)
			{
				alphabet[i] = '';



				Console.Write(alphabet);

			}


			int[] enteros = new int[3];

			enteros[0] = 1;
			enteros[1] = 2;
			enteros[2] = 3;
			Console.Write(enteros);

			for (int i = 0; i <= enteros.Length; i++)
			{
				enteros[i] = 0;
				Console.Write(enteros);

			}*/

			// NOMBRE INTERMITENTE

			/* string nombre = "Orion Ra ";

			 for (int i = 0; i <= 3; i++)
			 {
				 foreach (char letra in nombre)
				 {

					 Thread.Sleep(300);
					 Console.Write(" " + letra + " ");
				 }
				 Console.Clear();
			 }*/

			//ALFABETO

			/*for (char i = 'a'; i <= 'z'; i++)
			{
				Thread.Sleep(300);
				Console.Write(" " + i + " ");
			}

			Console.WriteLine();*/

			//ARRAY EMPLEADOS


			/* string[] emp = new string[5];

			 emp[0] = "pedro";
			 emp[1] = "juan";
			 emp[2] = "maria";
			 emp[3] = "daniela";
			 emp[4] = "Orion";

			 foreach (string reg in emp)
			 {
				 Thread.Sleep(300);
				 Console.WriteLine(reg);

			 }*/


			//MATRIZ 

			/* int[,] num = new int[3, 3];

			 for (int fila = 0; fila < 3; fila++)
			 {
				 for (int col = 0; col < 3; col++)
				 {

					 Console.WriteLine("dame un numero ");
					 num[fila, col] = Convert.ToInt32(Console.ReadLine());
				 }
				 Console.WriteLine();
			 }
			 Console.Clear();


			 for (int fila = 0; fila < 3; fila++)
			 {
				 for (int col = 0; col < 3; col++)
				 {

					 Thread.Sleep(300);
					 Console.Write(" " + num[fila, col]);
				 }
				 Console.WriteLine();

			 }
			 Console.WriteLine();*/

			//OTRA OFRMA DE DECLARAR UN ARRAY

			/* string[] gente = new string[] { "pedrito", "jacinta", "carmen", "antonio" };
			 foreach (string nom in gente)
			 {
				 Thread.Sleep(300);
				 Console.WriteLine(nom);
			 }*/

			//OBJETO RANDOM

			/*Console.WriteLine("dame el numero inicial");
			int num1 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("dame el numero final");
			int num2 = Convert.ToInt32(Console.ReadLine());

			Random gen = new Random();

			int numR = gen.Next(num1, num2);

			Thread.Sleep(250);
			Console.WriteLine(numR);*/

			//PRACTICA

			Random x = new Random();

			int a = x.Next(0, 5);

			char conf;

			do
			{

				Console.WriteLine("Adivina el numero");

				int num = Convert.ToInt32(Console.ReadLine());

				if (num != a)
				{
					Thread.Sleep(250);
					Console.WriteLine("no pegas una, dale de nuevo");
					Console.WriteLine("pulsa cualquier tecla para continuar \no (s) para salir)");
				}
				else
				{
					Console.WriteLine("Lo lograste perro pulsa (s) para salir");
				}
				
				conf = Convert.ToChar(Console.ReadLine());

				Console.Clear();

			} while (conf != 's');


			Console.WriteLine("adios");



			Console.ReadKey();



		}
	}
}

















