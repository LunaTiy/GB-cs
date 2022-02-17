using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GB_lesson4
{
	static class StaticClass
	{
		public static int SearchPairsDevisible3(int[] array)
		{
			int count = 0;

			for (int i = 1; i < array.Length; i++)
				if ((array[i - 1] % 3 == 0 && array[i] % 3 != 0) || (array[i - 1] % 3 != 0 && array[i] % 3 == 0)) count++;

			return count;
		}

		public static int[] ReadArrayFromFile(string nameFile)
		{
			StreamReader sr = new StreamReader(nameFile);

			int N = File.ReadAllLines(nameFile).Length;
			int[] array = new int[N];

			for(int i = 0; i < N; i++)
				int.TryParse(sr.ReadLine(), out array[i]);

			sr.Close();
			return array;
		}
	}
}
