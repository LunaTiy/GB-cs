using System;

namespace GameLogic
{
	public class Game
	{
		private int _number;
		private int _maxCountAttempt;
		private int _countAttempt;

		public Game()
		{
			int minValue = 1;
			int maxValue = 100;

			_number = new Random.Next(minValue, maxValue + 1);
			_maxCountAttempt = (int)Math.Log2(maxValue - minValue) + 1;
			_countAttempt = 0;
		}

		public int NewAttempt(int number)
		{
			if (_countAttempt > _maxCountAttempt)
				return -2;

			_countAttempt++;

			int resultComparer = Comparer(number);

			if (resultComparer == 0) return 0;
			else if (resultComparer > 0) return 1;
			else return -1;
		}

		private int Comparer(int number)
		{
			return number - _number;
		}
	}
}