using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace KDMEDISP
{

	public class Encrypt
	{
	
		public static string HashPassword(string password)
		{
			string hash = BCrypt.Net.BCrypt.HashPassword("abc123", workFactor: 12);
			return hash;
		}

		public static bool ValidatePassword(string password, string correctHash)
		{
			bool isValid = BCrypt.Net.BCrypt.Verify("abc123", correctHash);
			return isValid;
		}
	}
}
