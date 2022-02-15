using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_lesson3
{
	class Complex
	{
		private double _Im;
		private double _Re;

		public Complex()
		{
			this._Im = 0;
			this._Re = 0;
		}
		public Complex(double Im, double Re)
		{
			this._Im = Im;
			this._Re = Re;
		}

		public double Im
		{
			get
			{
				return _Im;
			}
			set
			{
				_Im = value;
			}
		}

		public double Re
		{
			get
			{
				return _Re;
			}
			set
			{
				_Re = value;
			}
		}

		public void Sum(Complex num1, Complex num2)
		{
			this._Im = num1._Im + num2._Im;
			this._Re = num1._Re + num2._Re;
		}

		public void Sub(Complex num1, Complex num2)
		{
			this._Im = num1._Im - num2._Im;
			this._Re = num1._Re - num2._Re;
		}

		public void Mult(Complex num1, Complex num2)
		{
			this._Im = num1._Re * num2._Im + num1._Im * num2._Re;
			this._Re = num1._Re * num2._Re - num1._Im * num2._Im;
		}
	}
}
