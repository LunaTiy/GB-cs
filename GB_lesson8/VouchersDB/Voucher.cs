using System;

namespace VouchersDB
{
	public class Voucher
	{
		private string _departureCity;
		private string _arrivalCity;
		private DateTime? _departureTime;
		private DateTime? _arrivalTime;
		private string _airline;

		public Voucher()
		{
			_departureCity = null;
			_arrivalCity = null;
			_departureTime = null;
			_arrivalTime = null;
			_airline = null;
		}

		public Voucher(string departureCity, string arrivalCity, DateTime departureTime, DateTime arrivalTime, string airline)
		{
			DepartureCity = departureCity;
			ArrivalCity = arrivalCity;
			DepartureTime = departureTime;
			ArrivalTime = arrivalTime;
			Airline = airline;
		}

		public string DepartureCity
		{
			get => _departureCity;
			set
			{
				if (value != null) _departureCity = value;
			}
		}

		public string ArrivalCity
		{
			get => _arrivalCity;
			set
			{
				if (value != null) _arrivalCity = value;
			}
		}

		public DateTime? DepartureTime
		{
			get => _departureTime;
			set
			{
				if (_arrivalTime != null && value > _arrivalTime) return;

				_departureTime = value;
			}
		}

		public DateTime? ArrivalTime
		{
			get => _arrivalTime;
			set
			{
				if (_departureTime != null && value < _departureTime) return;

				_departureTime = value;
			}
		}

		public string Airline
		{
			get => _airline;
			set
			{
				if (value != null) _airline = value;
			}
		}

		public override string ToString()
		{
			return $"{_departureCity, 18} => {_arrivalCity, 18} {_departureTime}:{_arrivalTime}{_airline, 15}";
		}
	}
}
