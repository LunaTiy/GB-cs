// Работу выполнил Савушкин Даниил

using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GB_lesson5
{
	class Program
	{
		static void Pause()
		{
			Console.WriteLine("\nНажмите любую кнопку...");
			Console.ReadKey();
			Console.Clear();
		}

		#region Задание 1

		/*
		 * Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 символов, 
		 * содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
		 *	а) без использования регулярных выражений;
		 *	б) **с использованием регулярных выражений.
		 */

		static void Exercise1()
		{
			Console.WriteLine("Задание 1.\nВведите логин:");
			string login = Console.ReadLine();

			Console.WriteLine("Проверка логина без регулярных выражений:");
			if (CheckLogin(login)) Console.WriteLine("Логин введет верно!");
			else Console.WriteLine("Логин введен не верно!");

			Console.WriteLine("\nПроверка логина с помощью регулярных выражений:");
			if (CheckLoginRegex(login)) Console.WriteLine("Логин введен верно!");
			else Console.WriteLine("Логин введен не верно!");

			Pause();
		}

		static bool CheckLogin(string login)
		{
			bool isCorrectLogin = false;

			if (login.Length < 2 || login.Length > 10) return isCorrectLogin;

			if ((login[0] < 'A' || login[0] > 'Z') && (login[0] < 'a' || login[0] > 'z'))
				return isCorrectLogin;

			foreach(char sym in login)
			{
				if (sym >= 'A' && sym <= 'Z' || sym >= 'a' && sym <= 'z' || sym >= '0' && sym <= '9') isCorrectLogin = true;
				else
				{
					isCorrectLogin = false;
					break;
				}
			}

			return isCorrectLogin;
		}

		static bool CheckLoginRegex(string login)
		{
			Regex reg = new Regex(@"\b[a-z][a-z0-9]{1,9}\b", RegexOptions.IgnoreCase);

			return reg.IsMatch(login);
		}

		#endregion

		#region Задание 2

		/*
		 * Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
		 *	а) Вывести только те слова сообщения, которые содержат не более n букв.
		 *	б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
		 *	в) Найти самое длинное слово сообщения.
		 *	г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
		 *	д) ***Создать метод, который производит частотный анализ текста. В качестве параметра в него передается массив слов и текст, 
		 *		в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст. 
		 *		Здесь требуется использовать класс Dictionary.
		 */

		static void Execrise2()
		{
			Console.WriteLine("Задание 2.");

			string message = "Hello,World!My name is Daniil Savush and I like C# and C++";
			Console.WriteLine("Исходное сообщение:\n" + message + "\n");

			Message.PrintWordLessLength(message, 4);

			Console.WriteLine("Удаление слов, которые заканчиваются на символ 'e':\n" + Message.RemoveWordsEndSym(message, 'e'));

			Console.WriteLine("\nПоиск самого длинного слова: " + Message.FindMaxLengthWord(message));

			Console.WriteLine("\nПоиск всех слов максимальной длины: " + Message.FindAllMaxLengthWords(message));


			Console.WriteLine("\nЧастотный анализ текста:");
			string[] words = { "is", "and", "no"};
			Dictionary<string, int> frequencyWords = Message.TextFrequencyAnalysis(words, message);

			foreach (var word in frequencyWords)
				Console.WriteLine($"{word.Key}: {word.Value}");

			Pause();
		}

		#endregion

		#region Задание 3

		/*
		 * *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
		 *	Например:
		 *	badc являются перестановкой abcd.
		 */

		static void Exercise3()
		{
			string message1 = "Hello, World!";
			string message2 = "odl!rW, lolHe";

			Console.WriteLine($"Строка 1: {message1}\nСтрока 2: {message2}\n");

			if (CompareStrings(message1, message2)) Console.WriteLine("Строка 2 является перестановкой строки 1!");
			else Console.WriteLine("Строка 2 не является перестановкой строки 1");

			Pause();
		}

		static bool CompareStrings(string message1, string message2)
		{
			bool isCompare = false;

			Dictionary<char, int> frequencySymString1 = FrequencySym(message1);
			Dictionary<char, int> frequencySymString2 = FrequencySym(message2);

			if (frequencySymString1.Count != frequencySymString2.Count) return isCompare;

			foreach(var sym in frequencySymString1)
			{
				int countSym;

				if (!frequencySymString2.TryGetValue(sym.Key, out countSym) || sym.Value != countSym) return isCompare;
			}

			isCompare = true;
			return isCompare;
		}

		static Dictionary<char, int> FrequencySym(string message)
		{
			Dictionary<char, int> frequencySym = new Dictionary<char, int>();

			foreach(char sym in message)
			{
				if (frequencySym.ContainsKey(sym)) frequencySym[sym]++;
				else frequencySym.Add(sym, 1);
			}

			return frequencySym;
		}

		#endregion

		#region Задание 4

		/*
		 * На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней школы. 
		 * В первой строке сообщается количество учеников N, которое не меньше 10, но не превосходит 100, 
		 * каждая из следующих N строк имеет следующий формат:
		 * <Фамилия> <Имя> <оценки>, где

		 *	<Фамилия> — строка, состоящая не более чем из 20 символов, 
		 *	<Имя> — строка, состоящая не более чем из 15 символов, 
		 *	<оценки> — через пробел три целых числа, соответствующие оценкам по пятибалльной системе.
		 *	
		 *	<Фамилия> и <Имя>, а также <Имя> и <оценки> разделены одним пробелом. 
		 *	
		 *	Пример входной строки: Иванов Петр 4 5 3
		 *	
		 *	Требуется написать как можно более эффективную программу, которая будет выводить на экран фамилии и имена трёх худших 
		 *	по среднему баллу учеников. Если среди остальных есть ученики, набравшие тот же средний балл, 
		 *	что и один из трёх худших, следует вывести и их фамилии и имена.
		 */

		static void Exercise4()
		{
			Dictionary<string, int[]> students;

			if (!ReadFile(out students)) return;
			OutputStudents(students);

			Output3BadGrades(students);
		}

		static bool ReadFile(out Dictionary<string, int[]> students)
		{
			StreamReader sr = null;
			students = new Dictionary<string, int[]>();

			bool wasRead = false;

			try
			{
				sr = new StreamReader("D:/Learn/GB-cs/GB_lesson5/StudentExamGrades.txt");

				int count;

				if (!int.TryParse(sr.ReadLine(), out count)) return wasRead;

				if (count < 10 || count > 100) return wasRead;

				while(!sr.EndOfStream)
				{
					string line = sr.ReadLine();
					string[] words = line.Split(" ");

					string studentName = words[0] + " " + words[1];
					int[] studentGrades = new int[3];

					for(int i = 0; i < 3; i++)
						if (!int.TryParse(words[i + 2], out studentGrades[i])) studentGrades[i] = 0;

					if (!students.ContainsKey(studentName)) students.Add(studentName, studentGrades);
				}

				wasRead = true;
			}
			catch
			{
				Console.WriteLine("Ошибка чтения файла!");
			}
			finally
			{
				if (sr != null) sr.Close();
			}

			return wasRead;
		}

		static void OutputStudents(Dictionary<string, int[]> students)
		{
			foreach (var student in students)
			{
				Console.Write($"{student.Key}: ");

				for (int i = 0; i < 3; i++)
					Console.Write($"{student.Value[i]} ");

				Console.WriteLine();
			}
		}

		static void Output3BadGrades(Dictionary<string, int[]> students)
		{
			Dictionary<string, double> badStudents = new Dictionary<string, double>();
			double[] minAverageGrades = new double[3];

			for(int i = 0; i < 3; i++)
				minAverageGrades[i] = 5.0;

			// Поиск 3-х минимальных средних баллов
			foreach (var student in students)
			{
				double average = 0;

				for(int i = 0; i < student.Value.Length; i++)
					average += student.Value[i];

				average /= student.Value.Length;

				if(minAverageGrades[0] > average)
				{
					minAverageGrades[2] = minAverageGrades[1];
					minAverageGrades[1] = minAverageGrades[0];
					minAverageGrades[0] = average;
				}
				else if(minAverageGrades[1] > average && minAverageGrades[0] != average)
				{
					minAverageGrades[2] = minAverageGrades[1];
					minAverageGrades[1] = average;
				}
				else if(minAverageGrades[2] > average && minAverageGrades[1] != average  && minAverageGrades[0] != average)
				{
					minAverageGrades[2] = average;
				}
			}

			// Добавление плохих учеников в новую библиотеку
			foreach(var student in students)
			{
				double average = 0;

				for(int i = 0; i < student.Value.Length; i++)
					average += student.Value[i];

				average /= student.Value.Length;

				for (int i = 0; i < student.Value.Length; i++)
					if (average == minAverageGrades[i]) badStudents.Add(student.Key, average);
				
			}

			Console.WriteLine("\nХудшие ученики:");
			foreach (var badStudent in badStudents.OrderBy(badStudent => badStudent.Value))
				Console.WriteLine($"{badStudent.Key}: {badStudent.Value:F2}");
		}

		#endregion
		static void Main(string[] args)
		{
			Exercise1();
			Execrise2();
			Exercise3();
			Exercise4();
		}
	}
}