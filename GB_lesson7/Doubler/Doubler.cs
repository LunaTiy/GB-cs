using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doubler
{
	class Doubler
	{
		private int _targetNumber;
		private int _currentNumber;
		private int _countCommands;

		private enum Actions
		{
			Plus,
			Mult
		}

		private Stack<Actions> _actions;

		public event Action EventUpdateInfo;
		public event Action EventEndGame;

		public Doubler()
		{
			_targetNumber = new Random().Next(10, 100);
			_currentNumber = 0;
			_countCommands = 0;

			_actions = new Stack<Actions>();
		}

		public int TargetNumber { get => _targetNumber; }

		public int CurrentNumber { get => _currentNumber; }

		public int CountCommands { get => _countCommands; }

		public void PlusOne()
		{
			_currentNumber++;
			_countCommands++;

			_actions.Push(Actions.Plus);

			Update();
		}

		public void MultTwo()
		{
			_currentNumber *= 2;
			_countCommands++;

			_actions.Push(Actions.Mult);

			Update();
		}

		public void Revoke()
		{
			if (_actions.Count == 0)
				return;

			Actions lastAction = _actions.Pop();

			CancelLastAction(lastAction);

			Update();
		}

		public void Clear()
		{
			_currentNumber = 0;
			_countCommands = 0;

			EventUpdateInfo();
		}

		private void Update()
		{
			EventUpdateInfo?.Invoke();

			if (_currentNumber == _targetNumber) EventEndGame();
		}

		private void CancelLastAction(Actions lastAction)
		{
			if(lastAction == Actions.Plus)
			{
				_currentNumber--;
				_countCommands--;
			}
			else
			{
				_currentNumber /= 2;
				_countCommands--;
			}
		}
	}
}