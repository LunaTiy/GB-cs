using System;
using System.IO;

namespace LibraryTwoDeminsionalArray
{
	public class TwoDimensionalArray
	{
		private int[,] _array;

		#region ClassLifeCycles

		public TwoDimensionalArray(int countRows, int countColumns, int maxValue)
		{
			Random rnd = new Random();

			_array = new int[countRows, countColumns];

			for (int i = 0; i < _array.GetLength(0); i++)
				for (int j = 0; j < _array.GetLength(1); j++)
					_array[i, j] = rnd.Next(maxValue * 2 + 1) - maxValue;
		}

		public TwoDimensionalArray(string fileName)
		{
			#region Определение размерности массива
			StreamReader sr = new StreamReader(fileName);

			string line = sr.ReadLine();
			string[] elementsInLine = line.Split(" ");

			int countRows = File.ReadAllLines(fileName).Length;
			int countColumn = elementsInLine.Length;
			
			_array = new int[countRows, countColumn];

			sr.Close();
			#endregion
			
			sr = new StreamReader(fileName);

			#region Заполнение массива при считывании файла

			int i = 0;

			while (!sr.EndOfStream)
			{
				line = sr.ReadLine();
				elementsInLine = line.Split(" ");

				for (int j = 0; j < countColumn; j++)
					if (!int.TryParse(elementsInLine[j], out _array[i, j])) _array[i, j] = 0;

				i++;
			}

			#endregion

			sr.Close();
		}

		#endregion

		#region Properties
		public int this[int i, int j]
		{
			get => _array[i, j];
			set => _array[i, j] = value;
		}

		public int Rows { get => _array.GetLength(0); }

		public int Columns { get => _array.GetLength(1); }

		public int MinElement
		{
			get
			{
				int min = _array[0, 0];

				for(int i = 0; i < _array.GetLength(0); i++)
					for(int j = 0; j < _array.GetLength(1); j++)
						if (_array[i, j] < min) min = _array[i, j];

				return min;
			}
		}

		public int MaxElement
		{
			get
			{
				int max = _array[0, 0];

				for (int i = 0; i < _array.GetLength(0); i++)
					for (int j = 0; j < _array.GetLength(1); j++)
						if (_array[i, j] > max) max = _array[i, j];

				return max;
			}
		}

		#endregion

		#region Methods
		public int SumElements()
		{
			int sum = 0;

			for (int i = 0; i < _array.GetLength(0); i++)
				for (int j = 0; j < _array.GetLength(1); j++)
					sum += _array[i, j];

			return sum;
		}

		public int SumElemntsGreaterNumber(int minRange)
		{
			int sum = 0;

			for (int i = 0; i < _array.GetLength(0); i++)
				for (int j = 0; j < _array.GetLength(1); j++)
					if(_array[i, j] > minRange) sum += _array[i, j];

			return sum;
		}

		public void IndexMaxElement(out int indexRow, out int indexColumn)
		{
			int max = _array[0, 0];
			indexRow = 0;
			indexColumn = 0;

			for (int i = 0; i < _array.GetLength(0); i++)
			{
				for (int j = 0; j < _array.GetLength(1); j++)
				{
					if (_array[i, j] > max)
					{
						max = _array[i, j];
						indexRow = i;
						indexColumn = j;
					}
				}
			}
		}

		public void OutputArray()
		{
			Console.WriteLine("Двумерный массив:");

			for (int i = 0; i < _array.GetLength(0); i++)
			{
				for (int j = 0; j < _array.GetLength(1); j++)
				{
					Console.Write($"{_array[i, j], 5}");
				}
				Console.WriteLine();
			}

			Console.WriteLine();
		}

		public void WriteArrayInFile(string fileName)
		{
			StreamWriter sw = null;

			try
			{
				sw = new StreamWriter(fileName);

				for (int i = 0; i < _array.GetLength(0); i++)
				{
					for (int j = 0; j < _array.GetLength(1); j++)
					{
						sw.Write(_array[i, j] + " ");
					}
					sw.WriteLine();
				}
			}
			catch(DirectoryNotFoundException)
			{
				Console.WriteLine("Отсутсвует путь для записи файла!");
			}
			finally
			{
				sw?.Close();
			}
		}
		#endregion
	}
}
