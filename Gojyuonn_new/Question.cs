using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gojyuonn_new
{
	public class Question
	{
		public string Ques
		{
			get;
			set;
		}
		public string[] Ans
		{
			get;
			set;
		}

		public Question(string[] yomi, string character)
		{
			this.Ans = yomi;
			this.Ques = character;
		}

		public bool check(string msg)
		{
			foreach (string i in Ans)
				if (msg == i)
					return true;
			return false;
		}
	}
}
