using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GB_lesson6
{
	class Program
	{
		static void Pause()
		{
			Console.WriteLine("Нажмите любую кнопку...");
			Console.ReadKey();
			Console.Clear();
		}

		#region Задание 1

		/*
		 * Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double).
		 * Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
		 */

		static void Exercise1()
		{
			Console.WriteLine("Задание 1.");
			OutputTable(0, 10, 0.5, 2, (a, x) => a * Math.Pow(x, 2));
			OutputTable(0, 10, 0.5, 3, (a, x) => a * Math.Sin(x));
			Pause();
		}

		delegate double Function(double a, double x);

		static void OutputTable(double x0, double x1, double step, double factor, Function function)
		{
			if (x0 > x1) return;

			if (step <= 0) return;

			Console.WriteLine($"Table for {function.Method}:");

			for(double i = x0; i <= x1; i += step)
				Console.WriteLine($"x: {i, 5:F2} => y: {function(factor, i), 6:F2}");
			
			Console.WriteLine();
		}

		#endregion

		#region Задание 2

		/*
		 * Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
		 *	а)  Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум.
		 *		Использовать массив (или список) делегатов, в котором хранятся различные функции.
		 *	б) *Переделать функцию Load, чтобы она возвращала массив считанных значений.
		 *		Пусть она возвращает минимум через параметр (с использованием модификатора out).
		 */

		static void Exercise2()
		{
			Console.WriteLine("Задание 2.");

			string filename = "function.bin";

			List<Func> functions = new List<Func>();

			functions.Add(x => Math.Sin(x));
			functions.Add(x => Math.Cos(x));
			functions.Add(x => Math.Pow(x, 2));

			while (true)
			{
				int action;
				double minX, maxX, step;

				if (InputAction(out action, out minX, out maxX, out step))
				{
					if (action == 4) break;
					else if (action > 0 && action < 4)
					{
						SaveFuncToFile(filename, minX, maxX, step, functions[action]);

						double minValue;
						double[] array = ReadFuncFromFile(filename, out minValue);

						Console.WriteLine("Значения функции:");

						foreach (double value in array)
							Console.WriteLine($"{value:F3}");

						Console.WriteLine($"\nМнимальное значение функции: {minValue:F3}\n");
					}
					else Console.WriteLine("Неверный ввод");
				}
			}

			Pause();
		}

		delegate double Func(double x);

		static void SaveFuncToFile(string filename, double minX, double maxX, double step, Func function)
		{
			if (minX > maxX || step <= 0) return;

			FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
			BinaryWriter bw = new BinaryWriter(fs);

			for(double x = minX; x <= maxX; x += step)
				bw.Write(function(x));

			bw.Close();
			fs.Close();
		}

		static bool InputAction(out int action, out double minX, out double maxX, out double step)
		{
			action = 0;
			minX = maxX = step = 0;

			try
			{
				Console.WriteLine("Выберите действие:\n1. Sin(x)\n2. Cos(x)\n3. x^2\n4. Выход");
				action = int.Parse(Console.ReadLine());

				if (action < 1 || action > 3) return true;

				Console.WriteLine("Введите нижнюю границу функции:");
				minX = double.Parse(Console.ReadLine());

				Console.WriteLine("Введите верхнюю границу функции:");
				maxX = double.Parse(Console.ReadLine());

				Console.WriteLine("Введите шаг вычислений:");
				step = double.Parse(Console.ReadLine());

				Console.WriteLine();

				return true;
			}
			catch
			{
				return false;
			}
		}

		static double[] ReadFuncFromFile(string filename, out double minValue)
		{
			minValue = double.MaxValue;

			if (!File.Exists(filename)) return new double[0];

			FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
			BinaryReader br = new BinaryReader(fs);

			double[] array = new double[fs.Length / sizeof(double)];

			for(int i = 0; i < fs.Length / sizeof(double); i++)
			{
				array[i] = br.ReadDouble();
				if (array[i] < minValue) minValue = array[i];
			}

			return array;
		}

		#endregion

		#region Задание 3

		/*
		 * Переделать программу Пример использования коллекций для решения следующих задач:
			а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
			б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив);
			в) отсортировать список по возрасту студента;
			г) *отсортировать список по курсу и возрасту студента;
		 */

		static void Exercise3()
		{
			Console.WriteLine("Задание 3.");

			#region Считывание файла

			string fileName = "students_4.csv";
			List<Student> students = ReadStudentsFromFile(fileName);

			if (students.Count == 0) return;

			#endregion

			#region Подсчет студентов 5 и 6 курсов

			Console.WriteLine("Количество студентов 5, 6 курсов: " + 
				CountStudents(students, student => student.Course == 5 || student.Course == 6) + "\n");

			#endregion

			#region Подсчет студентов на разных курсах с возрастом от 18 до 20

			Dictionary<int, int> courseStudents = FrequencyCourseStudents(students, student => student.Age >= 18 && student.Age <= 20);

			Console.WriteLine("Кол-во студентов на разных курсах, возраст которых от 18 до 20:");

			foreach (var course in courseStudents)
				Console.WriteLine($"Курс: {course.Key}, кол-во студентов: {course.Value}");

			#endregion

			#region Сортировка стдуентов по возрасту

			students.Sort(ComparerAge);

			Console.WriteLine("Сортировка студентов по возрасту (запись в csv файл)");

			WriteToCsvFile("studentsOrderByAge.csv", students);
			//foreach (var student in students)
			//Console.WriteLine(student);

			#endregion

			#region Сортировка студентов по курсу и возрасту

			Console.WriteLine("Сортировка студентов по курсу и возрасту (запись в csv файл)");
			students.Sort(ComparerCourseAndAge);

			WriteToCsvFile("studentsOrderByCourseAndAge.csv", students);

			//foreach (var student in students)
			//Console.WriteLine(student);

			// Можно реализовать проще, но хотел сделать через делегаты:
			// students = students.OrderBy(student => student.Course).ThenBy(student => student.Age).ToList();

			#endregion

			Pause();
		}

		static List<Student> ReadStudentsFromFile(string filename)
		{
			if (!File.Exists(filename)) return new List<Student>();

			List<Student> students = new List<Student>();

			StreamReader sr = new StreamReader(filename);

			while (!sr.EndOfStream)
			{
				string[] line = sr.ReadLine().Split(';');
				students.Add(new Student(line[0], line[1], line[2], line[3], line[4], int.Parse(line[5]), int.Parse(line[6]), int.Parse(line[7]), line[8]));
			}

			sr.Close();

			return students;
		}

		delegate bool IsStudent(Student student);

		static int CountStudents(List<Student> students, IsStudent isStudent)
		{
			if (students.Count == 0)
				return 0;

			int count = 0;

			foreach (var student in students)
				if (isStudent(student)) count++;

			return count;
		}

		static Dictionary<int, int> FrequencyCourseStudents(List<Student> students, IsStudent isStudent)
		{
			Dictionary<int, int> courseStudents = new Dictionary<int, int>();

			for (int i = 1; i < 7; i++) 
				courseStudents.Add(i, CountStudents(students, student => isStudent(student) && student.Course == i));

			return courseStudents;
		}

		static int ComparerAge(Student student1, Student student2)
		{
			return student1.Age.CompareTo(student2.Age);
		}

		static int ComparerCourseAndAge(Student student1, Student student2)
		{
			int temp = student1.Course.CompareTo(student2.Course);

			if (temp == 0)
				return student1.Age.CompareTo(student2.Age);

			return temp;
		}

		static void WriteToCsvFile(string fileName, List<Student> students)
		{
			StreamWriter sw = new StreamWriter(fileName);
			
			foreach(var student in students)
				sw.WriteLine(student.ToStringCsv(';'));

			sw.Close();
		}

		#endregion

		#region Задание 4

		/*
		 * **Считайте файл различными способами. Смотрите “Пример записи файла различными способами”.
		 *	Создайте методы, которые возвращают массив byte (FileStream, BufferedStream),
		 *	строку для StreamReader и массив int для BinaryReader.
		 */

		static void Exercise4()
		{
			Console.WriteLine("Задание 4.");

			string fileName = "function.bin";

			#region BufferedStream

			Console.WriteLine("Чтение байтов через BufferedStream");

			byte[] buffer = ReadBytesFile(fileName);

			foreach(byte element in buffer)
				Console.WriteLine(element);
			Console.WriteLine();


			Console.WriteLine("Перевод из байтов в double");
			double[] arrayFromBuffer = new double[buffer.Length / sizeof(double)];

			for (int i = 0; i < arrayFromBuffer.Length; i++)
			{
				arrayFromBuffer[i] = BitConverter.ToDouble(buffer, i * sizeof(double));
				Console.WriteLine(arrayFromBuffer[i]);
			}

			#endregion

			#region StreamReader

			Console.WriteLine("\nСимвольное считывание файла:");

			string line = ReadStringsFile(fileName);
			Console.WriteLine(line);

			#endregion

			#region BinaryReader

			Console.WriteLine("\nБинарное считывание файла:");

			double[] array = ReadBinaryFile(fileName);

			foreach (double element in array)
				Console.WriteLine(element + " ");

			#endregion
		}

		static byte[] ReadBytesFile(string filename)
		{
			if (!File.Exists(filename)) return new byte[0];

			byte[] bytes = new byte[File.ReadAllBytes(filename).Length];
			FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
			BufferedStream bs = new BufferedStream(fs);

			bs.Read(bytes);

			bs.Close();
			fs.Close();

			return bytes;
		}

		static string ReadStringsFile(string filename)
		{
			if (!File.Exists(filename)) return "";

			StreamReader sr = new StreamReader(filename);
			string line = sr.ReadLine();

			sr.Close();
			return line;
		}

		static double[] ReadBinaryFile(string filename)
		{
			if (!File.Exists(filename)) return new double[0];

			FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
			BinaryReader br = new BinaryReader(fs);

			double[] array = new double[fs.Length / sizeof(double)];

			for (int i = 0; i < array.Length; i++)
				array[i] = br.ReadDouble();

			return array;
		}

		#endregion

		static void Main(string[] args)
		{
			Exercise1();
			Exercise2();
			Exercise3();
			Exercise4();
		}
	}
}
