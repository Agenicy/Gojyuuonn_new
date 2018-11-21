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
	public partial class Hiragana : UserControl
	{
		public Hiragana()
		{
			InitializeComponent();

			qusList = new List<Question>
			{
				new Question(new string[] {"a"}, "あ"),
				new Question(new string[] {"i", "yi"}, "い"),
				new Question(new string[] {"u"}, "う"),
				new Question(new string[] {"e", "ye"}, "え"),
				new Question(new string[] {"o"}, "お"),
				new Question(new string[] {"ka", "ca"}, "か"),
				new Question(new string[] {"ki"}, "き"),
				new Question(new string[] {"ku", "cu"}, "く"),
				new Question(new string[] {"ke"}, "け"),
				new Question(new string[] {"ko", "co"}, "こ"),
				new Question(new string[] {"sa"}, "さ"),
				new Question(new string[] {"shi", "si", "ci"}, "し"),
				new Question(new string[] {"su"}, "す"),
				new Question(new string[] {"se", "ce"}, "せ"),
				new Question(new string[] {"so"}, "そ"),
				new Question(new string[] {"ta"}, "た"),
				new Question(new string[] {"chi", "ti"}, "ち"),
				new Question(new string[] {"tsu", "tu"}, "つ"),
				new Question(new string[] {"te"}, "て"),
				new Question(new string[] {"to"}, "と"),
				new Question(new string[] {"na"}, "な"),
				new Question(new string[] {"ni"}, "に"),
				new Question(new string[] {"nu"}, "ぬ"),
				new Question(new string[] {"ne"}, "ね"),
				new Question(new string[] {"no"}, "の"),
				new Question(new string[] {"ha"}, "は"),
				new Question(new string[] {"hi"}, "ひ"),
				new Question(new string[] {"hu", "fu"}, "ふ"),
				new Question(new string[] {"he"}, "へ"),
				new Question(new string[] {"ho"}, "ほ"),
				new Question(new string[] {"ma"}, "ま"),
				new Question(new string[] {"mi"}, "み"),
				new Question(new string[] {"mu"}, "む"),
				new Question(new string[] {"me"}, "め"),
				new Question(new string[] {"mo"}, "も"),
				new Question(new string[] {"ya"}, "や"),
				new Question(new string[] {"yu"}, "ゆ"),
				new Question(new string[] {"yo"}, "よ"),
				new Question(new string[] {"ra"}, "ら"),
				new Question(new string[] {"ri"}, "り"),
				new Question(new string[] {"ru"}, "る"),
				new Question(new string[] {"re"}, "れ"),
				new Question(new string[] {"ro"}, "ろ"),
				new Question(new string[] {"wa"}, "わ"),
				new Question(new string[] {"wo"}, "を"),
				new Question(new string[] {"n", "nn"}, "ん"),
				new Question(new string[] {"ga"}, "が"),
				new Question(new string[] {"gi"}, "ぎ"),
				new Question(new string[] {"gu"}, "ぐ"),
				new Question(new string[] {"ge"}, "げ"),
				new Question(new string[] {"go"}, "ご"),
				new Question(new string[] {"za"}, "ざ"),
				new Question(new string[] {"zi", "ji"}, "じ"),
				new Question(new string[] {"zu"}, "ず"),
				new Question(new string[] {"ze"}, "ぜ"),
				new Question(new string[] {"zo"}, "ぞ"),
				new Question(new string[] {"da"}, "だ"),
				new Question(new string[] {"di"}, "ぢ"),
				new Question(new string[] {"du"}, "づ"),
				new Question(new string[] {"de"}, "で"),
				new Question(new string[] {"do"}, "ど"),
				new Question(new string[] {"ba"}, "ば"),
				new Question(new string[] {"bi"}, "び"),
				new Question(new string[] {"bu"}, "ぶ"),
				new Question(new string[] {"be"}, "べ"),
				new Question(new string[] {"bo"}, "ぼ"),
				new Question(new string[] {"pa"}, "ぱ"),
				new Question(new string[] {"pi"}, "ぴ"),
				new Question(new string[] {"pu"}, "ぷ"),
				new Question(new string[] {"pe"}, "ぺ"),
				new Question(new string[] {"po"}, "ぽ")
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
