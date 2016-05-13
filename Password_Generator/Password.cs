using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Generator {

	public static class Password {

		private static string alpha_chars = "abcdefghijklmnopqrstuvwzyz";
		private static string alpha_upper_chars = "ABCDEFGHIJKLMNOPQRSTUVWZYZ";
		private static string num_chars = "0123456789";
		private static string special_chars = "!£$%^&*()_Type+~#=-}{@:][;?><.,";

		public static string create(int len = 16, bool use_alpha = true, bool use_upper_alpha = true, bool use_num = true, bool use_special = true) {
			string pass = "";
			int str_len = len;
			string lookup = "";

			if(use_alpha) {
				lookup += alpha_chars;
			}

			if(use_upper_alpha) {
				lookup += alpha_upper_chars;
			}

			if(use_num) {
				lookup += num_chars;
			}

			if(use_special) {
				lookup += special_chars;
			}

			if(lookup.Length == 0){
				return "";
			}

			Random rng = new Random();

			while(str_len > 0) {
				pass += lookup [rng.Next(0, lookup.Length)];
				str_len--;
			}

			return pass;
		}

	}

}
