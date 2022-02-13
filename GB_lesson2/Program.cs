/*
 * Домашнее задание 2
 * Савушкин Даниил
 */

using System;
using System.Diagnostics;

namespace GB_lesson2
{
	class Program
	{
		// 1. Написать метод, возвращающий минимальное из трёх чисел.
		static void Exercise1()
		{
			int a = 5, b = 8, c = 7;
			Console.WriteLine($"Задание 1.\nДаны 3 числа: a = {a},  b = {b}, c = {c}");
			int max = FindMax(a, b, c);
			Console.WriteLine("Максимальное число: " + max);
		}
		static int FindMax(int a, int b, int c)
		{
			if(a > b)
			{
				if (a > c)				
					return a;				
				else
					return c;
			}
			else
			{
				if (b > c)
					return b;
				else
					return c;
			}
		}

		// 2. Написать метод подсчета количества цифр числа.
		static void Exercise2()
		{
			int a = 1013624;
			Console.WriteLine("\nЗадание 2.\nДано число: " + a + "\nКол-во цифр в числе: " + CountingNum(a));
		}
		static int CountingNum(int num)
		{
			int count = 0;

			while(num > 0)
			{
				num /= 10;
				count++;
			}

			return count;
		}

		// 3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
		static void Exercise3()
		{
			Console.WriteLine("\nЗадание 3.\n");
			int tmp, sum = 0;

			while (true)
			{
				try
				{
					Console.WriteLine("Сумма чисел равна: " + sum + "\nВведите число: ");
					tmp = int.Parse(Console.ReadLine());

					if (tmp == 0)
						break;

					if (tmp > 0 && tmp % 2 == 1)
						sum += tmp;
				}
				catch
				{
					Console.WriteLine("Неверный ввод...");
				}
			}

			Console.WriteLine("Сумма чисел равна: " + sum);
		}

		/*
		 * 4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. 
		 * На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
		 * Используя метод проверки логина и пароля, написать программу: 
		 * пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
		 * С помощью цикла do while ограничить ввод пароля тремя попытками.
		 */
		static void Exercise4()
		{
			Console.WriteLine("\nЗадание 4.\n");

			string login, pass;
			int count = 3;

			do
			{
				try
				{
					if (count <= 0)
					{
						Console.WriteLine("Количество попыток исчерпано!!!");
						break;
					}
						
					Console.WriteLine("Введите логин: ");
					login = Console.ReadLine();

					Console.WriteLine("Введите пароль: ");
					pass = Console.ReadLine();

					if (Auth(login, pass))
					{
						Console.WriteLine("Логин и пароль введены верно!\n");
						break;
					}

					Console.WriteLine("Неверный ввод логина или пароля!\n");
				}

				catch
				{
					Console.WriteLine("Некорректный ввод...\n");
				}

				count--;
			} while (true);
		}

		static bool Auth(string login, string password)
		{
			const string trueLogin = "root", truePass = "GeekBrains";

			if(trueLogin == login && truePass == password)
				return true;
			
			return false;
		}

		/*
		 * 5.
		 *	а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, 
		 *	нужно ли человеку похудеть, набрать вес или всё в норме.
		 *	
		 *	б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
		 */
		static void Exercise5()
		{
			Console.WriteLine("\nЗадание 5.\n");
			double height, weight;

			Console.WriteLine("Введите ваш рост: ");
			height = double.Parse(Console.ReadLine());

			Console.WriteLine("Введите ваш вес: ");
			weight = double.Parse(Console.ReadLine());

			CountBMI(height, weight);
		}

		static void CountBMI(double height, double weight)
		{
			const double minBMI = 18.5, maxBMI = 25;
			double BMI = weight / Math.Pow(height / 100, 2);
			Console.WriteLine("Ваш ИМТ: {0:F2}", BMI);

			if(BMI >= minBMI && BMI <= maxBMI)
			{
				Console.WriteLine("Ваш вес в норме, поздравляем!");
			}
			else if(BMI < minBMI)
			{
				double normalize = ((minBMI / BMI) * weight) - weight;
				Console.WriteLine("У вас недостаток веса!\nДля нормализации ИМТ вам необходимо набрать: {0:F2}", normalize);
			}
			else
			{
				double normalize = weight - ((maxBMI / BMI) * weight);
				Console.WriteLine("У вас избыток веса!\nДля нормализации ИМТ вам необходимо сбросить: {0:F2}", normalize);
			}
		}

		/*
		 * 6. *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.
		 * «Хорошим» называется число, которое делится на сумму своих цифр.
		 * Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
		 */
		static void Exercise6()
		{
			Console.WriteLine("\nЗадание 6.\n");

			Stopwatch timer = new Stopwatch();
			timer.Start();

			Console.WriteLine("\nКоличество хороших чисел: " + FindGoodNumbers());

			timer.Stop();
			Console.WriteLine("Время выполнения подпрограммы: " + timer.Elapsed);
		}

		static int FindGoodNumbers()
		{
			int maxNumbers = 1000000000;
			int count = 0;

			for (int i = 1; i <= maxNumbers; i++)
			{
				int sum = 0;
				int current = i;

				while (current > 0)
				{
					sum += current % 10;
					current /= 10;
				}

				if(i % sum == 0)
				{
					Console.WriteLine("Хорошее число: " + i);
					count++;
				}
			}

			return count;
		}

		/*
		 * 7.
		 *	a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
		 *	б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
		 */

		static void Exercise7()
		{
			Console.WriteLine("\nЗадание 7.\n");

			const int a = 2, b = 20;
			Output(a, b);
		}

		static void Output(int a, int b)
		{
			if(a > b)
			{
				Console.WriteLine("\nКонец работы рекурсивного метода");
				return;
			}

			Console.Write(a + " ");
			a++;

			Output(a, b);
		}

		static void Main(string[] args)
		{
			Console.WriteLine("Домашнее задание 2\nСавушкин Даниил\n");
			Exercise1();
			Exercise2();
			Exercise3();
			Exercise4();
			Exercise5();
			Exercise6();
			Exercise7();
		}
	}
}
