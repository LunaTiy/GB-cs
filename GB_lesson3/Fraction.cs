using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_lesson3
{
	class Fraction
	{
		private int _whole;			// Целая часть дроби
		private int _numerator;		// Числитель
		private int _denominator;	// Знаменатель
		private double _decimal;	// Десятичное представление дроби

		public Fraction()
		{
			_numerator = 1;
			_denominator = 1;

			_decimal = _numerator / _denominator;
			_whole = 0;
		}

		public Fraction(int numerator, int denominator)
		{
			this._numerator = numerator;

			try
			{
				if (denominator == 0)
				{
					throw new ArgumentException("Знаменатель не может быть нулевым. Автоматически ему присовено значение 1.");
				}

				else this._denominator = denominator;
			}
			catch (ArgumentException ex)
			{
				Console.WriteLine(ex.Message);
				this._denominator = 1;
			}			

			_decimal = Convert.ToDouble(this._numerator) / Convert.ToDouble(this._denominator);
			_whole = 0;
		}

		// Свойства в данном классе не имееют никакого смысла,т.к. доступ к полям класса осуществляется через методы
		// Но т.к. в условиях работы они приписаны, то и в классе я их оставил
		#region Свойства
		public int Numerator
		{
			get
			{
				return _numerator;
			}
			set
			{
				_numerator = value;
			}
		}

		public int Denominator
		{
			get
			{
				return _denominator;
			}
			set
			{
				if (value == 0) throw new ArgumentException("Знаменатель не может быть нулевым");
				else _denominator = value;
			}
		}

		public double Decimal
		{
			get
			{
				return _decimal;
			}
		}

		public int Whole
		{
			get
			{
				return _whole;
			}
		}
		#endregion

		private void SimplificationFraction()
		{
			#region Поиск делителей

			for(int i = 1; i < _denominator + 1; i++)
			{
				if (_numerator % i == 0 && _denominator % i == 0)
				{
					_numerator /= i;
					_denominator /= i;
				}
			}
			#endregion

			if (Math.Abs(_numerator) < Math.Abs(_denominator))
				return;

			#region Ситуация, когда числитель > знаменателя
			_whole = _numerator / _denominator;

			if (_numerator < 0) _numerator = -_numerator;
			if (_denominator < 0) _denominator = -_denominator;

			_numerator %= _denominator;
			#endregion
		}

		private void UnSimplificationFraction()
		{
			if (_whole == 0)
				return;

			if (_whole < 0)
				_numerator = -_numerator;

			_numerator += _whole * _denominator;
			_whole = 0;
		}

		public void EnteringValues()
		{
			while (true)
			{
				Console.WriteLine("Введите числитель дроби:");

				if (int.TryParse(Console.ReadLine(), out _numerator)) break;
				else Console.WriteLine("Некорректный ввод!");
			}

			while (true)
			{
				Console.WriteLine("Введите знаменатель дроби:");

				try
				{
					if (int.TryParse(Console.ReadLine(), out _denominator))
					{
						if (_denominator == 0) throw new ArgumentException("Знаменатель не может быть нулевым!");

						break;
					}
					else Console.WriteLine("Некорректный ввод!");
				}
				catch (ArgumentException ex)
				{
					Console.WriteLine("Ошибка: " + ex.Message);
				}
			}

			_decimal = Convert.ToDouble(this._numerator) / Convert.ToDouble(this._denominator);
			_whole = 0;
		}

		public string OutputValues()
		{
			SimplificationFraction();

			string message;

			if (_whole != 0 && _numerator != 0) message = $"{_whole} ({_numerator} / {_denominator})";
			else if (_numerator == 0) message = $"{_whole}";
			else message = $"{_numerator} / {_denominator}";

			UnSimplificationFraction();

			return message;
		}

		public void Sum(Fraction num1, Fraction num2)
		{
			if (num1._denominator == num2._denominator)
			{
				this._numerator = num1._numerator + num2._numerator;
				this._denominator = num1._denominator;

				this._decimal = Convert.ToDouble(this._numerator) / Convert.ToDouble(this._denominator);

				return;
			}

			this._numerator = num1._numerator * num2._denominator + num2._numerator * num1._denominator;
			this._denominator = num1._denominator * num2._denominator;

			this._decimal = Convert.ToDouble(this._numerator) / Convert.ToDouble(this._denominator);
		}

		public void Sub(Fraction num1, Fraction num2)
		{
			if (num1._denominator == num2._denominator)
			{
				this._numerator = num1._numerator - num2._numerator;
				this._denominator = num1._denominator;

				this._decimal = Convert.ToDouble(this._numerator) / Convert.ToDouble(this._denominator);

				return;
			}

			this._numerator = num1._numerator * num2._denominator - num2._numerator * num1._denominator;
			this._denominator = num1._denominator * num2._denominator;

			this._decimal = Convert.ToDouble(this._numerator) / Convert.ToDouble(this._denominator);
		}

		public void Mult(Fraction num1, Fraction num2)
		{
			this._numerator = num1._numerator * num2._numerator;
			this._denominator = num1._denominator * num2._denominator;

			this._decimal = Convert.ToDouble(this._numerator) / Convert.ToDouble(this._denominator);
		}

		public void Div(Fraction num1, Fraction num2)
		{
			this._numerator = num1._numerator * num2._denominator;
			this._denominator = num1._denominator * num2._numerator;

			this._decimal = Convert.ToDouble(this._numerator) / Convert.ToDouble(this._denominator);
		}
	}
}