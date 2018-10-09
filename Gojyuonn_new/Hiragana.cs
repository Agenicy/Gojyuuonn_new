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

			qusList = new List<Kana>
			{
				new Kana(new string[] {"a"}, "あ"),
				new Kana(new string[] {"i", "yi"}, "い"),
				new Kana(new string[] {"u"}, "う"),
				new Kana(new string[] {"e", "ye"}, "え"),
				new Kana(new string[] {"o"}, "お"),
				new Kana(new string[] {"ka", "ca"}, "か"),
				new Kana(new string[] {"ki"}, "き"),
				new Kana(new string[] {"ku", "cu"}, "く"),
				new Kana(new string[] {"ke"}, "け"),
				new Kana(new string[] {"ko", "co"}, "こ"),
				new Kana(new string[] {"sa"}, "さ"),
				new Kana(new string[] {"shi", "si", "ci"}, "し"),
				new Kana(new string[] {"su"}, "す"),
				new Kana(new string[] {"se", "ce"}, "せ"),
				new Kana(new string[] {"so"}, "そ"),
				new Kana(new string[] {"ta"}, "た"),
				new Kana(new string[] {"chi", "ti"}, "ち"),
				new Kana(new string[] {"tsu", "tu"}, "つ"),
				new Kana(new string[] {"te"}, "て"),
				new Kana(new string[] {"to"}, "と"),
				new Kana(new string[] {"na"}, "な"),
				new Kana(new string[] {"ni"}, "に"),
				new Kana(new string[] {"nu"}, "ぬ"),
				new Kana(new string[] {"ne"}, "ね"),
				new Kana(new string[] {"no"}, "の"),
				new Kana(new string[] {"ha"}, "は"),
				new Kana(new string[] {"hi"}, "ひ"),
				new Kana(new string[] {"hu", "fu"}, "ふ"),
				new Kana(new string[] {"he"}, "へ"),
				new Kana(new string[] {"ho"}, "ほ"),
				new Kana(new string[] {"ma"}, "ま"),
				new Kana(new string[] {"mi"}, "み"),
				new Kana(new string[] {"mu"}, "む"),
				new Kana(new string[] {"me"}, "め"),
				new Kana(new string[] {"mo"}, "も"),
				new Kana(new string[] {"ya"}, "や"),
				new Kana(new string[] {"yu"}, "ゆ"),
				new Kana(new string[] {"yo"}, "よ"),
				new Kana(new string[] {"ra"}, "ら"),
				new Kana(new string[] {"ri"}, "り"),
				new Kana(new string[] {"ru"}, "る"),
				new Kana(new string[] {"re"}, "れ"),
				new Kana(new string[] {"ro"}, "ろ"),
				new Kana(new string[] {"wa"}, "わ"),
				new Kana(new string[] {"wo"}, "を"),
				new Kana(new string[] {"n", "nn"}, "ん"),
				new Kana(new string[] {"ga"}, "が"),
				new Kana(new string[] {"gi"}, "ぎ"),
				new Kana(new string[] {"gu"}, "ぐ"),
				new Kana(new string[] {"ge"}, "げ"),
				new Kana(new string[] {"go"}, "ご"),
				new Kana(new string[] {"za"}, "ざ"),
				new Kana(new string[] {"zi", "ji"}, "じ"),
				new Kana(new string[] {"zu"}, "ず"),
				new Kana(new string[] {"ze"}, "ぜ"),
				new Kana(new string[] {"zo"}, "ぞ"),
				new Kana(new string[] {"da"}, "だ"),
				new Kana(new string[] {"di"}, "ぢ"),
				new Kana(new string[] {"du"}, "づ"),
				new Kana(new string[] {"de"}, "で"),
				new Kana(new string[] {"do"}, "ど"),
				new Kana(new string[] {"ba"}, "ば"),
				new Kana(new string[] {"bi"}, "び"),
				new Kana(new string[] {"bu"}, "ぶ"),
				new Kana(new string[] {"be"}, "べ"),
				new Kana(new string[] {"bo"}, "ぼ"),
				new Kana(new string[] {"pa"}, "ぱ"),
				new Kana(new string[] {"pi"}, "ぴ"),
				new Kana(new string[] {"pu"}, "ぷ"),
				new Kana(new string[] {"pe"}, "ぺ"),
				new Kana(new string[] {"po"}, "ぽ"),
			};

			// pre-load first question
			now = rand.Next(qusList.Count);
			label1_qus.Text = qusList[now].character;

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
		List<Kana> qusList;
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
					label1_qus.Text = qusList[now].character;
				}
				else if (textBox_ans.Text == "\\ans")
				{
					textBox_ans.Text = qusList[now].yomi[0];
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
