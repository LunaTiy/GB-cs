using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_lesson4
{
	class MyArray
	{
		private int[] _array;

		public MyArray()
		{
			int size = 10;
			int step = 2;

			_array = new int[size];

			for (int i = 0; i < size; i++)
				_array[i] = step * i;
		}

		public MyArray(int size, int step)
		{
			_array = new int[size];

			for (int i = 0; i < size; i++)
				_array[i] = step * i;
		}

		public int this[int index]
		{
			get => _array[index];
			set => _array[index] = value;
		}

		public int Sum
		{
			get
			{
				int sum = 0;

				for (int i = 0; i < _array.Length; i++)
					sum += _array[i];

				return sum;
			}
		}

		public int MaxCount
		{
			get
			{
				int maxElement = _array[0];
				int maxCount = 1;

				for(int i = 1; i < _array.Length; i++)
				{
					if (_array[i] > maxElement)
					{
						maxElement = _array[i];
						maxCount = 1;
					}
					else if (_array[i] == maxElement)
						maxCount++;
				}

				return maxCount;
			}
		}

		public int[] Inverse()
		{
			int[] newArray = new int[_array.Length];

			for (int i = 0; i < _array.Length; i++)
				newArray[i] = -_array[i];

			return newArray;
		}

		public void Multi(int number)
		{
			for (int i = 0; i < _array.Length; i++)
				_array[i] *= number;
		}

		public Dictionary<int, int> CountEachElements()
		{
			Dictionary<int, int> countEachElements = new Dictionary<int, int>();

			foreach(int num in _array)
			{
				if(countEachElements.ContainsKey(num) == true) countEachElements[num]++;
				else countEachElements.Add(num, 1);
			}

			return countEachElements;
		}

		public void OutputArray()
		{
			Console.WriteLine("Массив:");

			foreach (int num in _array)
				Console.Write(num + " ");

			Console.WriteLine();
		}
	}
}