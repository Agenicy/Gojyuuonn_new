using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gojyuonn_new
{
	class Kana
	{
		public string character
		{
			get;
			private set;
		}
		public string[] yomi
		{
			get;
			private set;
		}

		public Kana(string[] yomi, string character)
		{
			this.yomi = yomi;
			this.character = character;
		}

		public bool check(string msg)
		{
			foreach (string i in yomi)
				if (msg == i)
					return true;
			return false;
		}
	}
}
