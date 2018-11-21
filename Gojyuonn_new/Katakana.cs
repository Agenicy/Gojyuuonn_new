using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gojyuonn_new
{
	public partial class Katakana : UserControl
	{
		public Katakana()
		{
			InitializeComponent();

			qusList = new List<Question>
			{
				new Question(new string[] {"a"}, "ア"),
				new Question(new string[] {"i", "yi"}, "イ"),
				new Question(new string[] {"u"}, "ウ"),
				new Question(new string[] {"e", "ye"}, "エ"),
				new Question(new string[] {"o"}, "オ"),
				new Question(new string[] {"ka", "ca"}, "カ"),
				new Question(new string[] {"ki"}, "キ"),
				new Question(new string[] {"ku", "cu"}, "ク"),
				new Question(new string[] {"ke"}, "ケ"),
				new Question(new string[] {"ko", "co"}, "コ"),
				new Question(new string[] {"sa"}, "サ"),
				new Question(new string[] {"shi", "si", "ci"}, "シ"),
				new Question(new string[] {"su"}, "ス"),
				new Question(new string[] {"se", "ce"}, "セ"),
				new Question(new string[] {"so"}, "ソ"),
				new Question(new string[] {"ta"}, "タ"),
				new Question(new string[] {"chi", "ti"}, "チ"),
				new Question(new string[] {"tsu", "tu"}, "ツ"),
				new Question(new string[] {"te"}, "テ"),
				new Question(new string[] {"to"}, "ト"),
				new Question(new string[] {"na"}, "ナ"),
				new Question(new string[] {"ni"}, "ニ"),
				new Question(new string[] {"nu"}, "ヌ"),
				new Question(new string[] {"ne"}, "ネ"),
				new Question(new string[] {"no"}, "ノ"),
				new Question(new string[] {"ha"}, "ハ"),
				new Question(new string[] {"hi"}, "ヒ"),
				new Question(new string[] {"hu", "fu"}, "フ"),
				new Question(new string[] {"he"}, "ヘ"),
				new Question(new string[] {"ho"}, "ホ"),
				new Question(new string[] {"ma"}, "マ"),
				new Question(new string[] {"mi"}, "ミ"),
				new Question(new string[] {"mu"}, "ム"),
				new Question(new string[] {"me"}, "メ"),
				new Question(new string[] {"mo"}, "モ"),
				new Question(new string[] {"ya"}, "ヤ"),
				new Question(new string[] {"yu"}, "ユ"),
				new Question(new string[] {"yo"}, "ヨ"),
				new Question(new string[] {"ra"}, "ラ"),
				new Question(new string[] {"ri"}, "リ"),
				new Question(new string[] {"ru"}, "ル"),
				new Question(new string[] {"re"}, "レ"),
				new Question(new string[] {"ro"}, "ロ"),
				new Question(new string[] {"wa"}, "ワ"),
				new Question(new string[] {"wo"}, "ヲ"),
				new Question(new string[] {"n", "nn"}, "ン"),
				new Question(new string[] {"ga"}, "ガ"),
				new Question(new string[] {"gi"}, "ギ"),
				new Question(new string[] {"gu"}, "グ"),
				new Question(new string[] {"ge"}, "ゲ"),
				new Question(new string[] {"go"}, "ゴ"),
				new Question(new string[] {"za"}, "ザ"),
				new Question(new string[] {"zi", "ji"}, "ジ"),
				new Question(new string[] {"zu"}, "ズ"),
				new Question(new string[] {"ze"}, "ゼ"),
				new Question(new string[] {"zo"}, "ゾ"),
				new Question(new string[] {"da"}, "ダ"),
				new Question(new string[] {"di"}, "ヂ"),
				new Question(new string[] {"du"}, "ヅ"),
				new Question(new string[] {"de"}, "デ"),
				new Question(new string[] {"do"}, "ド"),
				new Question(new string[] {"ba"}, "バ"),
				new Question(new string[] {"bi"}, "ビ"),
				new Question(new string[] {"bu"}, "ブ"),
				new Question(new string[] {"be"}, "ベ"),
				new Question(new string[] {"bo"}, "ボ"),
				new Question(new string[] {"pa"}, "パ"),
				new Question(new string[] {"pi"}, "ピ"),
				new Question(new string[] {"pu"}, "プ"),
				new Question(new string[] {"pe"}, "ペ"),
				new Question(new string[] {"po"}, "ポ"),
			};

			// pre-load first question
			now = rand.Next(qusList.Count);
			label1_qus.Text = qusList[now].Ques;

			// make textBox & label in the right position
			textBox_ansLocation = new Point((this.Size.Width - textBox_ans.Size.Width) / 2,
											(this.Size.Height - textBox_ans.Size.Height) / 4 * 3);
			textBox_ans.Location = textBox_ansLocation;
			label1_qus.Location = new Point((this.Size.Width - label1_qus.Size.Width) / 2,
											(this.Size.Height - label1_qus.Size.Height) / 4);

			textBox_ansTimer.Interval = 10;
			textBox_ansTimer.Tick += (send, eve) =>
			{
				// shake it 5 period per 500ms, left and right 3px.
				textBox_ans.Location = new Point(textBox_ansLocation.X + Convert.ToInt32(3 * Math.Cos((double)timerCount / 500 * 5 * 2 * Math.PI)), textBox_ansLocation.Y);
				// timerCount records how long timer have ran,  we let it run for only 500ms
				if ((timerCount += textBox_ansTimer.Interval) >= 500)
				{
					// in case of location error done by shaking, we need to reset textBox to where it should be.
					textBox_ans.Location = textBox_ansLocation;
					timerCount = 0;
					textBox_ansTimer.Stop();
				}
			};
		}

		Random rand = new Random();
		List<Question> qusList;
		int now;
		Point textBox_ansLocation;
		Timer textBox_ansTimer = new Timer();
		int timerCount;

		private void textBox_ans_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				System.Diagnostics.Debug.WriteLine("[" + textBox_ans.Text + "]");
				if (qusList[now].check(textBox_ans.Text))
				{
					// clear textBox so that user don't have to delete it
					textBox_ans.Text = "";
					// next question
					now = rand.Next(qusList.Count);
					label1_qus.Text = qusList[now].Ques;
				}
				else if (textBox_ans.Text == "\\ans")
				{
					textBox_ans.Text = qusList[now].Ans[0];
				}
				else
				{
					// user enters wrong answer
					// if it's shaking right now (which textBox_ansTimer.Enabled is true), skip shaking.
					if (!textBox_ansTimer.Enabled)
						textBox_ansTimer.Start();
				}
			}
		}
	}
}
