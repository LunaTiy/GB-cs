using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Text.RegularExpressions;

namespace VouchersDB
{
	public class Vouchers
	{
		private List<Voucher> _vouchers;

		public Vouchers()
		{
			_vouchers = new List<Voucher>();
		}

		public Voucher this[int index]
		{
			get => _vouchers[index];
		}

		public int Count { get => _vouchers.Count; }

		public void Add(Voucher voucher)
		{
			_vouchers.Add(voucher);
		}

		public void Remove(int index)
		{
			if(index < _vouchers.Count) _vouchers.RemoveAt(index);
		}

		public void Save(string fileName)
		{
			if (_vouchers.Count == 0) return;

			if (!new Regex(@"\w+\.\w+", RegexOptions.IgnoreCase).IsMatch(fileName)) return;

			XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Voucher>));
			FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);

			xmlSerializer.Serialize(fs, _vouchers);

			fs.Close();
		}

		public void Load(string fileName)
		{
			if (!File.Exists(fileName)) return;

			XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Voucher>));
			FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);

			_vouchers = (List<Voucher>)xmlSerializer.Deserialize(fs);

			fs.Close();
		}
	}
}
