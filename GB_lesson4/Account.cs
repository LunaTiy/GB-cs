using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GB_lesson4
{
	struct Account
	{
		private string _login;
		private string _password;

		public Account(string login, string password)
		{
			_login = login;
			_password = password;
		}

		public bool CheckAccount(string userLogin, string userPassword)
		{
			if (userLogin == _login && userPassword == _password)
				return true;

			return false;
		}
	}
}
