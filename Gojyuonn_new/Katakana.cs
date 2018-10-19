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

			qusList = new List<Kana>
			{
				new Kana(new string[] {"a"}, "ア"),
				new Kana(new string[] {"i", "yi"}, "イ"),
				new Kana(new string[] {"u"}, "ウ"),
				new Kana(new string[] {"e", "ye"}, "エ"),
				new Kana(new string[] {"o"}, "オ"),
				new Kana(new string[] {"ka", "ca"}, "カ"),
				new Kana(new string[] {"ki"}, "キ"),
				new Kana(new string[] {"ku", "cu"}, "ク"),
				new Kana(new string[] {"ke"}, "ケ"),
				new Kana(new string[] {"ko", "co"}, "コ"),
				new Kana(new string[] {"sa"}, "サ"),
				new Kana(new string[] {"shi", "si", "ci"}, "シ"),
				new Kana(new string[] {"su"}, "ス"),
				new Kana(new string[] {"se", "ce"}, "セ"),
				new Kana(new string[] {"so"}, "ソ"),
				new Kana(new string[] {"ta"}, "タ"),
				new Kana(new string[] {"chi", "ti"}, "チ"),
				new Kana(new string[] {"tsu", "tu"}, "ツ"),
				new Kana(new string[] {"te"}, "テ"),
				new Kana(new string[] {"to"}, "ト"),
				new Kana(new string[] {"na"}, "ナ"),
				new Kana(new string[] {"ni"}, "ニ"),
				new Kana(new string[] {"nu"}, "ヌ"),
				new Kana(new string[] {"ne"}, "ネ"),
				new Kana(new string[] {"no"}, "ノ"),
				new Kana(new string[] {"ha"}, "ハ"),
				new Kana(new string[] {"hi"}, "ヒ"),
				new Kana(new string[] {"hu", "fu"}, "フ"),
				new Kana(new string[] {"he"}, "ヘ"),
				new Kana(new string[] {"ho"}, "ホ"),
				new Kana(new string[] {"ma"}, "マ"),
				new Kana(new string[] {"mi"}, "ミ"),
				new Kana(new string[] {"mu"}, "ム"),
				new Kana(new string[] {"me"}, "メ"),
				new Kana(new string[] {"mo"}, "モ"),
				new Kana(new string[] {"ya"}, "ヤ"),
				new Kana(new string[] {"yu"}, "ユ"),
				new Kana(new string[] {"yo"}, "ヨ"),
				new Kana(new string[] {"ra"}, "ラ"),
				new Kana(new string[] {"ri"}, "リ"),
				new Kana(new string[] {"ru"}, "ル"),
				new Kana(new string[] {"re"}, "レ"),
				new Kana(new string[] {"ro"}, "ロ"),
				new Kana(new string[] {"wa"}, "ワ"),
				new Kana(new string[] {"wo"}, "ヲ"),
				new Kana(new string[] {"n", "nn"}, "ン"),
				new Kana(new string[] {"ga"}, "ガ"),
				new Kana(new string[] {"gi"}, "ギ"),
				new Kana(new string[] {"gu"}, "グ"),
				new Kana(new string[] {"ge"}, "ゲ"),
				new Kana(new string[] {"go"}, "ゴ"),
				new Kana(new string[] {"za"}, "ザ"),
				new Kana(new string[] {"zi", "ji"}, "ジ"),
				new Kana(new string[] {"zu"}, "ズ"),
				new Kana(new string[] {"ze"}, "ゼ"),
				new Kana(new string[] {"zo"}, "ゾ"),
				new Kana(new string[] {"da"}, "ダ"),
				new Kana(new string[] {"di"}, "ヂ"),
				new Kana(new string[] {"du"}, "ヅ"),
				new Kana(new string[] {"de"}, "デ"),
				new Kana(new string[] {"do"}, "ド"),
				new Kana(new string[] {"ba"}, "バ"),
				new Kana(new string[] {"bi"}, "ビ"),
				new Kana(new string[] {"bu"}, "ブ"),
				new Kana(new string[] {"be"}, "ベ"),
				new Kana(new string[] {"bo"}, "ボ"),
				new Kana(new string[] {"pa"}, "パ"),
				new Kana(new string[] {"pi"}, "ピ"),
				new Kana(new string[] {"pu"}, "プ"),
				new Kana(new string[] {"pe"}, "ペ"),
				new Kana(new string[] {"po"}, "ポ"),
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
