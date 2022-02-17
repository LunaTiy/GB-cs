using System;
using System.IO;
using System.Collections.Generic;

using LibraryOneDimensionalArray;
using LibraryTwoDeminsionalArray;

namespace GB_lesson4
{
	class Program
	{
		#region Задание 1
		/*
		 * Дан  целочисленный  массив  из 20 элементов.  Элементы  массива  могут принимать  целые  значения  от –10 000 до 10 000 включительно. 
		 * Заполнить случайными числами.  Написать программу, позволяющую найти и вывести количество пар элементов массива, 
		 * в которых только одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих элемента массива. 
		 * Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. 
		 */
		static void Exercise1()
		{
			Console.WriteLine("Задание 1.");
			const int N = 20;
			int[] array = RandomInitArray(N);

			for (int i = 0; i < array.Length; i++)
				Console.Write(array[i] + " ");

			Console.WriteLine("\nКоличетсво пар, в которых 1 эл-т делится на 3: " + SearchPairsDevisible3(array));

			Console.WriteLine("Нажмите любую кнопку:");
			Console.ReadKey();
			Console.Clear();
		}

		static int[] RandomInitArray(int N)
		{
			Random rnd = new Random();
			int maxValueArray = 10001;

			int[] array = new int[N];

			for (int i = 0; i < N; i++)
				array[i] = rnd.Next(-maxValueArray, maxValueArray);

			return array;
		}

		static int SearchPairsDevisible3(int[] array)
		{
			int count = 0;

			for(int i = 1; i < array.Length; i++)
				if((array[i - 1] % 3 == 0 && array[i] % 3 != 0) || (array[i - 1] % 3 != 0 && array[i] % 3 == 0)) count++;

			return count;
		}

		#endregion

		#region Задание 2
		/*
		 * Реализуйте задачу 1 в виде статического класса StaticClass;
		 *	а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
		 *	б) *Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
		 *	в)**Добавьте обработку ситуации отсутствия файла на диске.
		 */
		static void Exercise2()
		{
			Console.WriteLine("Задаине 2.");

			string nameFile = "D:/Learn/GB-cs/GB_lesson4/Array.txt";

			if (File.Exists(nameFile) == false)
				return;

			int[] array = StaticClass.ReadArrayFromFile(nameFile);

			for (int i = 0; i < array.Length; i++)
				Console.Write(array[i] + " ");

			Console.WriteLine("\nКоличетсво пар, в которых 1 эл-т делится на 3: " + StaticClass.SearchPairsDevisible3(array));

			Console.WriteLine("Нажмите любую кнопку:");
			Console.ReadKey();
			Console.Clear();
		}
		#endregion

		#region Задание 3
		/*
		 * а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий массив определенного размера и заполняющий массив 
		 *    числами от начального значения с заданным шагом. Создать свойство Sum, которое возвращает сумму элементов массива, 
		 *    метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений),
		 *    метод Multi, умножающий каждый элемент массива на определённое число, свойство MaxCount,
		 *    возвращающее количество максимальных элементов. 
		 *	б) ** Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки
		 *	в) *** Подсчитать частоту вхождения каждого элемента в массив (коллекция Dictionary<int,int>)
		 */
		static void Exercise3()
		{
			Console.WriteLine("Задание 3.");

			Console.WriteLine("Создание массива с помощью конструктора (шаг 3):");
			OneDimensionalArray array = new OneDimensionalArray(20, 3);
			array.OutputArray();

			Console.WriteLine("\nИзменение 0-го элемента массива через индексируемое свойство:");
			array[0] = 57;
			array.OutputArray();

			Console.WriteLine("\nПодсчет суммы эл-ов массива:\nСумма = " + array.Sum);

			Console.WriteLine("\nПодсчет кол-ва максимального эл-та массива: " + array.MaxCount);

			Console.WriteLine("\nИнверсия знака эл-ов массива и запись в новый массив:");
			int[] inverseArray = array.Inverse();

			foreach (int num in inverseArray)
				Console.Write(num + " ");

			Console.WriteLine("\n\nУмножение всех эл-ов массива на некоторое число (в примере 3):");
			array.Multi(3);
			array.OutputArray();

			Console.WriteLine("\nПодсчет частоты встречаемости каждого эл-та в массиве:");
			Dictionary<int, int> countEachElements = array.CountEachElements();

			foreach (var element in countEachElements)
				Console.WriteLine($"Элемент: {element.Key} => количество элементов в массиве: {element.Value}");

			Console.WriteLine("Нажмите любую кнопку:");
			Console.ReadKey();
			Console.Clear();
		}
		#endregion

		#region Задание 4
		/*
		 * Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив. 
		 * Создайте структуру Account, содержащую Login и Password.
		 */

		static void Exercise4()
		{
			Console.WriteLine("Задание 4");

			Account[] accounts;

			if (!ReadFileAccounts(out accounts))
				return;

			bool isAuth = false;
			int countTry = 3;

			while (!isAuth && countTry > 0)
			{
				Console.WriteLine("Введите логин:");
				string userLogin = Console.ReadLine();

				Console.WriteLine("Введите пароль:");
				string userPassword = Console.ReadLine();

				for (int i = 0; i < accounts.Length; i++)
				{
					if (accounts[i].CheckAccount(userLogin, userPassword))
					{
						Console.WriteLine("Успешная авторизация!");
						isAuth = true;
						break;
					}
				}

				countTry--;
			}

			Console.WriteLine("Нажмите любую кнопку:");
			Console.ReadKey();
			Console.Clear();
		}

		static bool ReadFileAccounts(out Account[] accounts)
		{
			string accountsFile = "D:/Learn/GB-cs/GB_lesson4/Accounts.txt";

			if (!File.Exists(accountsFile))
			{
				Console.WriteLine("Файла с логинами и паролями не существует");
				accounts = new Account[0];

				return false;
			}

			int countAccounts = File.ReadAllLines(accountsFile).Length;
			accounts = new Account[countAccounts];

			StreamReader sr = new StreamReader(accountsFile);

			int current = 0;

			while (!sr.EndOfStream)
			{
				string readLine = sr.ReadLine();
				string[] currentAccount = new string[2];

				currentAccount = readLine.Split(" ");

				accounts[current] = new Account(currentAccount[0], currentAccount[1]);
			}

			sr.Close();
			return true;
		}

		#endregion

		#region Задание 5
		/*
		 * *а) Реализовать библиотеку с классом для работы с двумерным массивом. Реализовать конструктор, заполняющий массив случайными числами. 
		 *	   Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного, свойство, 
		 *	   возвращающее минимальный элемент массива, свойство, возвращающее максимальный элемент массива, метод, возвращающий номер 
		 *	   максимального элемента массива (через параметры, используя модификатор ref или out).
		 * **б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
		 * **в) Обработать возможные исключительные ситуации при работе с файлами.
		 */

		static void Exercise5()
		{
			Console.WriteLine("Здание 5.");

			TwoDimensionalArray array2D = new TwoDimensionalArray(5, 7, 20);
			array2D.OutputArray();

			Console.WriteLine("Сумма всех эл-ов массива:" + array2D.SumElements());

			Console.WriteLine("Сумма элементов массива больше заданного числа (10): " + array2D.SumElemntsGreaterNumber(10));

			Console.WriteLine("Минимальный эл-т массива: " + array2D.MinElement);

			Console.WriteLine("Максимальный эл-т массива: " + array2D.MaxElement);

			int indexRowMaxElement;
			int indexColumnMaxElement;
			array2D.IndexMaxElement(out indexRowMaxElement, out indexColumnMaxElement);

			Console.WriteLine($"Индексы максимального эл-та массива: [{indexRowMaxElement}, {indexColumnMaxElement}]\n");

			string fileName = "D:/Learn/GB-cs/GB_lesson4/Array2D.txt";
			if (!File.Exists(fileName))
			{
				Console.WriteLine("Файл с 2-ным массивом не существует!");
				return;
			}

			Console.WriteLine("Считывание двумерного массива из файла:");
			TwoDimensionalArray fileArray2D = new TwoDimensionalArray(fileName);
			fileArray2D.OutputArray();

			Console.WriteLine("Замена эл-ов массива через индексируемое свойство:");
			fileArray2D[0, 0] = 100;
			fileArray2D[fileArray2D.Rows - 1, fileArray2D.Columns - 1] = -100;
			fileArray2D.OutputArray();

			string writerFileName = "D:/Learn/GB-cs/GB_lesson4/NewArray2D.txt";
			Console.WriteLine("Запись массива в файл: " + writerFileName);
			fileArray2D.WriteArrayInFile(writerFileName);
		}
		#endregion

		static void Main(string[] args)
		{
			Exercise1();
			Exercise2();
			Exercise3();
			Exercise4();
			Exercise5();
		}
	}
}
