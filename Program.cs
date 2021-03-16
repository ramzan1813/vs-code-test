using System;

namespace Gith_hub_reposotrary
{
    class Program
    {
        static void Main(string[] args)
        {

			//Ramdom Number Game
			/*
			Random randomNumber = new Random();
			Console.WriteLine("Please Enter a Number ");
			int UserNumber = Convert.ToInt32(Console.ReadLine());
			int Number = randomNumber.Next(999);
			if(Number.Equals(UserNumber))
			{
				Console.WriteLine("Conragulation You Won ");

			}
			else
			{
				Console.WriteLine($"Sorry Try Next Time You Lose {Number}");
			}
			*/

			//Prime Number Genrater
			/*double TotalNumber = 0;
			for (double PrimeNmber =3; PrimeNmber < 10000000; PrimeNmber++)
			{
				int Primevalue = 0;
				for (double i = 2; i < PrimeNmber; i++)
				{

					if (PrimeNmber % i == 0)
					{
						//Console.WriteLine("Not a Prime Number ");
						Primevalue++;
					}
					else
					{
						//Console.WriteLine("Prime Number ");
					}

				}
				if (Primevalue == 0)
				{
					Console.WriteLine($" Prime Number is {PrimeNmber}");
					TotalNumber++;
				}
				else
				{
					//Console.WriteLine("Not a Prime Number ");
				}
			}
			Console.WriteLine($"Total Prime Number {TotalNumber}");
			*/

			//Prime Number Checker 


			/*
			 * int Primevalue = 0;
			Console.WriteLine("Please Enter a Number ");
			int PrimeNmber = Convert.ToInt32(Console.ReadLine());
			for (int i = 2; i < PrimeNmber; i++)
			{
				
				if (PrimeNmber % i == 0)
				{
					//Console.WriteLine("Not a Prime Number ");
					Primevalue++;
				} else
				{
					//Console.WriteLine("Prime Number ");
				}
				
			}
			if (Primevalue == 0)
			{
				Console.WriteLine(" Prime Number ");
			}
			else
			{
				Console.WriteLine("Not a Prime Number ");
			}
			*/





			//Console.WriteLine($"Y = 2 * 5 * 5 + 3 * 5 + 7 = { 2 * 5 * 5 + 3 * 5 + 7}");

			//int aset=Convert.ToInt32(Console.ReadLine());
			//Console.WriteLine(aset);




			/*string projectName = "ACME";
			string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
			Console.WriteLine("View English output:");
			Console.WriteLine("\t" + $@"c:\Exercise\{projectName}\data.txt");
			Console.WriteLine(russianMessage);
			Console.WriteLine("\t" + $@"c:\Exercise\{projectName}\ru-RU\data.txt");*/
			Console.ReadKey();

        }
    }
}
