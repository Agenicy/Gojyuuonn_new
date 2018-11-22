using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gojyuonn_new
{
	public class Question
	{
		public int Index;
		public string Ques;
		public string[] Ans;

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
