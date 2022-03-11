using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
	public class Game
	{
		private int _number;
		private int _maxCountAttempt;
		private int _countAttempt;
		private bool _isGame;

		public Game()
		{
			int minValue = 1;
			int maxValue = 100;

			Random rnd = new Random();

			_number = rnd.Next(minValue, maxValue + 1);
			_maxCountAttempt = (int)Math.Log2(maxValue - minValue) + 1;
			_countAttempt = 0;
			_isGame = true;
		}

		public int MaxCountAttempt { get => _maxCountAttempt; }

		public int CountAttempt { get => _countAttempt; }

		public bool IsGame { get => _isGame; }

		public string NewAttempt(int number)
		{
			if (_countAttempt >= _maxCountAttempt)
			{
				_isGame = false;
				return "Попытки исчерпаны!";
			}

			_countAttempt++;

			int resultComparer = Comparer(number);

			if (resultComparer == 0)
			{
				_isGame = false;
				return $"Число {number} угадано!";
			}
			else if (resultComparer > 0) return $"Число {number} больше загаданного!";
			else return $"Число {number} меньше загаданного!";
		}

		private int Comparer(int number)
		{
			return number - _number;
		}
	}
}
