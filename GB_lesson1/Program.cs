/*
 * Автор домашнего задания:
 * Савушкин Даниил
 */

using System;

namespace GB_lesson1
{
	class Program
	{
		/*
		 	1. Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
			а) используя склеивание;
			б) используя форматированный вывод;
			в) используя вывод со знаком $.
		*/
		static void Form()
		{
			Console.WriteLine("------------\nExercices 1\n");
			// Объявление переменных
			string first_name, last_name;   // Имя и фамилия
			int age;						// Возраст
			double height, weight;          // Рост и вес
			try
			{
				// Функция ввода данных пользователем
				InputForm(out first_name, out last_name, out age, out height, out weight);

				// 3 варианта вывода на экран
				Console.WriteLine("1. First output\nName: " + first_name + "\nLast name: " + last_name + "\nAge: " + age + "\nHeight: " + height + "\nWeight: " + weight + "\n");
				Console.WriteLine("2. Second output\nName: {0}\nLast name: {1}\nAge: {2}\nHeight: {3}\nWeight: {4}\n", first_name, last_name, age, height, weight);
				Console.WriteLine($"3. Third output\nName: {first_name}\nLast name: {last_name}\nAge: {age}\nHeight: {height}\nWeight: {weight}");
			}
			catch
			{
				Console.WriteLine("Input's error!\n");
			}
		}

		static void InputForm(out string first_name, out string last_name, out int age, out double height, out double weight)
		{
			Console.Write("Input Your first name: ");
			first_name = Console.ReadLine();

			Console.Write("Input Your last name: ");
			last_name = Console.ReadLine();

			Console.Write("Input Your age: ");
			age = int.Parse(Console.ReadLine());

			Console.Write("Input Your height: ");
			height = int.Parse(Console.ReadLine());

			Console.Write("Input Your weight: ");
			weight = int.Parse(Console.ReadLine());

			Console.WriteLine();
		}

		/*
		 	2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); 
			где m — масса тела в килограммах, h — рост в метрах.
		*/
		static void BodyMassIndex()
		{
			Console.WriteLine("------------\nExercices 2\n");
			try
			{
				Console.Write("Input Your height: ");
				double height = int.Parse(Console.ReadLine());

				Console.Write("Input Your weight: ");
				double weight = int.Parse(Console.ReadLine());

				Console.WriteLine("BMI: " + weight / Math.Pow(height, 2));
			}
			catch
			{
				Console.WriteLine("Input's error!\n");
			}
		}

		/*
			3.
		 	а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле:
				r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f
				(с двумя знаками после запятой);

			б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
		*/
		static void Range()
		{
			Console.WriteLine("------------\nExercices 3\n");

			int x1 = 5, y1 = 3;
			int x2 = 7, y2 = 10;
			double r = CalculateRange(x1, y1, x2, y2);

			Console.WriteLine($"Coordinates:\nx1: {x1}, y1: {y1} => x2: {x2}, y2: {y2}");
			Console.WriteLine("Range: {0:F2}", r);
		}

		static double CalculateRange(int x1, int y1, int x2, int y2)
		{
			return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
		}

		/*
		 	4. Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.
			а) с использованием третьей переменной;
			б) *без использования третьей переменной
		*/
		static void Swap()
		{
			Console.WriteLine("------------\nExercices 4\n");

			int a = 5, b = 9;
			Console.WriteLine($"a: {a}, b: {b}");

			SwapWithTemp(ref a, ref b);
			Console.WriteLine($"After temp swap => a: {a}, b: {b}");

			SwapWithoutTemp(ref a, ref b);
			Console.WriteLine($"After not temp swap => a: {a}, b: {b}");
		}
		static void SwapWithTemp(ref int a, ref int b)
		{
			int temp = a;
			a = b;
			b = temp;
		}

		static void SwapWithoutTemp(ref int a, ref int b)
		{
			a = a + b;
			b = a - b;
			a = a - b;
		}

		/*
		 	5.
			а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
			б) Сделать задание, только вывод организовать в центре экрана.
			в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).
		*/
		static void PrintPerson()
		{
			Console.WriteLine("------------\nExercices 5\n");

			string name = "Daniil", lastName = "Savushkin", city = "Saint-Petersburg";

			Console.WriteLine($"Name: {name}\nLast name: {lastName}\nCity: {city}");

			PrintMiddle(name, lastName, city);
		}

		static void PrintMiddle(string name, string lastName, string city)
		{
			int count = 0;

			Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2 + count);
			Console.WriteLine("Name: " + name);
			count++;

			Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2 + count);
			Console.WriteLine("Last name:" + lastName);
			count++;

			Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2 + count);
			Console.WriteLine("City: " + city);
		}

		/*
		 	6. *Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
		*/

		class Learn
		{
			private string name = "Daniil";
			private string lastName = "Savushkin";
			private int age = 22;
			public void Cls()
			{
				Console.WriteLine("\nInput some key: ");
				Console.ReadKey();
				Console.Clear();
			}

			public void PrintAutor()
			{
				Console.WriteLine($"Autor script:\n------\nName: {this.name}\nLast name: {this.lastName}\nAge: {this.age}\n------");
			}
		}
		static void Main(string[] args)
		{
			Learn learn = new Learn();  // Задание 6 (Класс)
			learn.PrintAutor();			// Расположено здесь, т.к. добавлен метод автора

			Form();                     // Задание 1 (Анкета)
			learn.Cls();

			BodyMassIndex();            // Задание 2 (ИМТ)
			learn.Cls();

			Range();                    // Задание 3 (Расстояние между точками)
			learn.Cls();

			Swap();                     // Задание 4 (Смена переменных)
			learn.Cls();

			PrintPerson();              // Задание 5 (Вывод на экран)
			learn.Cls();
		}
	}
}