using System;
using System.Collections.Generic;

namespace GB_lesson3
{
	class Program
	{
		/*
		 * Задание 1
		 * а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
		 * б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
		 * в) Добавить диалог с использованием switch демонстрирующий работу класса.
		 * 
		 * Структура и класс описаны в других файлах проекта.
		 */
		static void Exercise1()
		{
			bool flag = true;
			int size = 3;

			Random random = new Random();

			#region Струкутра
			StructComplex[] complexStruct = new StructComplex[size];
			for (int i = 0; i < size; i++)
			{
				complexStruct[i] = new StructComplex(random.NextDouble() * 10 - 5, random.NextDouble() * 10 - 5);
				Console.WriteLine($"Complex struct {i + 1}: Re = {complexStruct[i].Re:F2}, Im = {complexStruct[i].Im:F2}");
			}

			complexStruct[2].Sub(complexStruct[0], complexStruct[1]);
			Console.WriteLine($"\nРезультат вычитания комплексного числа в структуре:\nComplex struct 2: " +
				$"Re = {complexStruct[2].Re:F2}, Im = {complexStruct[2].Im:F2}");
			Console.WriteLine("\nНажмите любую клавишу для продолжения...");

			Console.ReadKey();
			Console.Clear();
			#endregion

			#region Класс
			Complex[] complexClass = new Complex[size];
			for(int i = 0; i < size; i++)
			{
				complexClass[i] = new Complex(random.NextDouble() * 10 - 5, random.NextDouble() * 10 - 5);
			}

			while (flag)
			{
				Console.WriteLine("Выберите действие:\n1. Установка значений комплексного числа\n" +
					"2. Сложение комплексных чисел\n3. Вычитание комплексных чисел\n4. Перемножение комплексных чисел\n5. Выход\n");

				try
				{
					for(int i = 0; i < size; i++)
					{
						Console.WriteLine($"Complex class {i + 1}: Re = {complexClass[i].Re:F2}, Im = {complexClass[i].Im:F2}");
					}

					int input = int.Parse(Console.ReadLine());

					switch (input)
					{
						case 1:
							for (int i = 0; i < size; i++)
							{
								Console.WriteLine($"Complex class {i + 1}:");

								while (true)
								{
									try
									{
										Console.WriteLine("Введите значение действительной части:");
										complexClass[i].Re = double.Parse(Console.ReadLine());

										Console.WriteLine("Введите значение мнимой части:");
										complexClass[i].Im = double.Parse(Console.ReadLine());

										break;
									}
									catch
									{
										Console.WriteLine("Неверный ввод...");
									}
								}
							}
							break;

						case 2:
							Console.WriteLine("Сложение комплексных чисел 1 и 2, запись результата в 3-е число");
							complexClass[2].Sum(complexClass[0], complexClass[1]);
							break;

						case 3:
							Console.WriteLine("Вычитание комплексных чисел из 1-го числа 2-ое, запись результата в 3-е число");
							complexClass[2].Sub(complexClass[0], complexClass[1]);
							break;

						case 4:
							Console.WriteLine("Перемножение комплексных чисел 1 и 2, запись результата в 3-е число");
							complexClass[2].Mult(complexClass[0], complexClass[1]);
							break;

						case 5:
							Console.WriteLine("Выход из подпрограммы!");
							flag = false;
							break;

						default:
							Console.WriteLine("Неверный ввод...");
							break;
					}
				}
				catch
				{
					Console.WriteLine("Неверный ввод...");
				}

				Console.WriteLine("\nНажмите любую клавишу для продолжения...");
				Console.ReadKey();
				Console.Clear();
			}
			#endregion
		}

		/*
		 * Задание 2
		 * а)  С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
		 * Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse
		 */
		static void Execrice2()
		{
			List<int> numbers = InputNumbers();

			int sum = SumOddNumbers(numbers);

			OutputNumbers(numbers, sum);
		}

		static List<int> InputNumbers()
		{
			List<int> numbers = new List<int>();

			while (true)
			{
				Console.WriteLine("Введите целое число:");

				int num;

				if (int.TryParse(Console.ReadLine(), out num))
				{
					numbers.Add(num);

					if (num == 0) break;
				}
				else Console.WriteLine("Введено не целое число!");
			}

			return numbers;
		}

		static int SumOddNumbers(List<int> numbers)
		{
			if (numbers.Count == 0)
				return 0;

			int sum = 0;

			foreach(int num in numbers)
			{
				if (num % 2 != 0) sum += num;
			}

			return sum;
		}

		static void OutputNumbers(List<int> numbers, int sum)
		{
			Console.WriteLine("Элементы списка:");

			foreach (int num in numbers) Console.Write(num + " ");

			Console.WriteLine("\nСумма нечетных чисел: " + sum);
		}

		/*
		 * Задание 3.
		 * 
		 *  Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. 
		 *	Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса.
		 *		* Добавить свойства типа int для доступа к числителю и знаменателю;
		 *		* Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
		 *		** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
		 *		*** Добавить упрощение дробей.
		 */
		static void Exercise3()
		{
			Fraction num1 = new Fraction(-14, 4);
			Fraction num2 = new Fraction();
			Fraction result = new Fraction();

			Console.WriteLine("\nДробь 1: " + num1.OutputValues());

			num2.EnteringValues();
			Console.WriteLine("Дробь 2: " + num2.OutputValues());

			result.Sum(num1, num2);
			Console.WriteLine($"{num1.OutputValues()} + {num2.OutputValues()} = {result.OutputValues()}");

			result.Sub(num1, num2);
			Console.WriteLine($"{num1.OutputValues()} - {num2.OutputValues()} = {result.OutputValues()}");

			result.Mult(num1, num2);
			Console.WriteLine($"{num1.OutputValues()} * {num2.OutputValues()} = {result.OutputValues()}");

			result.Div(num1, num2);
			Console.WriteLine($"{num1.OutputValues()} / {num2.OutputValues()} = {result.OutputValues()}");
		}
		static void Main(string[] args)
		{
			Exercise1();
			Execrice2();
			Exercise3();
		}
	}
}