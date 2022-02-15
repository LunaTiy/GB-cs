using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_lesson3
{
	struct StructComplex
	{
		private double _Im;
		private double _Re;

		public StructComplex(double Im, double Re)
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

		public void Sum(StructComplex num1, StructComplex num2)
		{
			this._Im = num1._Im + num2._Im;
			this._Re = num1._Re + num2._Re;
		}

		public void Sub(StructComplex num1, StructComplex num2)
		{
			this._Im = num1._Im - num2._Im;
			this._Re = num1._Re - num2._Re;
		}

		public void Mult(StructComplex num1, StructComplex num2)
		{
			this._Im = num1._Re * num2._Im + num1._Im * num2._Re;
			this._Re = num1._Re * num2._Re - num1._Im * num2._Im;
		}

		public void Output()
		{
			Console.WriteLine($"Re: {_Re}, Im: {_Im}");
		}
	}
}
