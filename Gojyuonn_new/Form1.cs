using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gojyuonn_new
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			qusList = new List<Hiragana>
			{
				new Hiragana(new string[] {"a"}, "あ"),
				new Hiragana(new string[] {"i", "yi"}, "い"),
				new Hiragana(new string[] {"u"}, "う"),
				new Hiragana(new string[] {"e", "ye"}, "え"),
				new Hiragana(new string[] {"o"}, "お"),
				new Hiragana(new string[] {"ka", "ca"}, "か"),
				new Hiragana(new string[] {"ki"}, "き"),
				new Hiragana(new string[] {"ku", "cu"}, "く"),
				new Hiragana(new string[] {"ke"}, "け"),
				new Hiragana(new string[] {"ko", "co"}, "こ"),
				new Hiragana(new string[] {"sa"}, "さ"),
				new Hiragana(new string[] {"shi", "si", "ci"}, "し"),
				new Hiragana(new string[] {"su"}, "す"),
				new Hiragana(new string[] {"se", "ce"}, "せ"),
				new Hiragana(new string[] {"so"}, "そ"),
				new Hiragana(new string[] {"ta"}, "た"),
				new Hiragana(new string[] {"chi", "ti"}, "ち"),
				new Hiragana(new string[] {"tsu", "tu"}, "つ"),
				new Hiragana(new string[] {"te"}, "て"),
				new Hiragana(new string[] {"to"}, "と"),
				new Hiragana(new string[] {"na"}, "な"),
				new Hiragana(new string[] {"ni"}, "に"),
				new Hiragana(new string[] {"nu"}, "ぬ"),
				new Hiragana(new string[] {"ne"}, "ね"),
				new Hiragana(new string[] {"no"}, "の"),
				new Hiragana(new string[] {"ha"}, "は"),
				new Hiragana(new string[] {"hi"}, "ひ"),
				new Hiragana(new string[] {"hu", "fu"}, "ふ"),
				new Hiragana(new string[] {"he"}, "へ"),
				new Hiragana(new string[] {"ho"}, "ほ"),
				new Hiragana(new string[] {"ma"}, "ま"),
				new Hiragana(new string[] {"mi"}, "み"),
				new Hiragana(new string[] {"mu"}, "む"),
				new Hiragana(new string[] {"me"}, "め"),
				new Hiragana(new string[] {"mo"}, "も"),
				new Hiragana(new string[] {"ya"}, "や"),
				new Hiragana(new string[] {"yu"}, "ゆ"),
				new Hiragana(new string[] {"yo"}, "よ"),
				new Hiragana(new string[] {"ra"}, "ら"),
				new Hiragana(new string[] {"ri"}, "り"),
				new Hiragana(new string[] {"ru"}, "る"),
				new Hiragana(new string[] {"re"}, "れ"),
				new Hiragana(new string[] {"ro"}, "ろ"),
				new Hiragana(new string[] {"wa"}, "わ"),
				new Hiragana(new string[] {"wo"}, "を"),
				new Hiragana(new string[] {"n", "nn"}, "ん"),
				new Hiragana(new string[] {"ga"}, "が"),
				new Hiragana(new string[] {"gi"}, "ぎ"),
				new Hiragana(new string[] {"gu"}, "ぐ"),
				new Hiragana(new string[] {"ge"}, "げ"),
				new Hiragana(new string[] {"go"}, "ご"),
				new Hiragana(new string[] {"za"}, "ざ"),
				new Hiragana(new string[] {"zi", "ji"}, "じ"),
				new Hiragana(new string[] {"zu"}, "ず"),
				new Hiragana(new string[] {"ze"}, "ぜ"),
				new Hiragana(new string[] {"zo"}, "ぞ"),
				new Hiragana(new string[] {"da"}, "だ"),
				new Hiragana(new string[] {"di"}, "ぢ"),
				new Hiragana(new string[] {"du"}, "づ"),
				new Hiragana(new string[] {"de"}, "で"),
				new Hiragana(new string[] {"do"}, "ど"),
				new Hiragana(new string[] {"ba"}, "ば"),
				new Hiragana(new string[] {"bi"}, "び"),
				new Hiragana(new string[] {"bu"}, "ぶ"),
				new Hiragana(new string[] {"be"}, "べ"),
				new Hiragana(new string[] {"bo"}, "ぼ"),
				new Hiragana(new string[] {"pa"}, "ぱ"),
				new Hiragana(new string[] {"pi"}, "ぴ"),
				new Hiragana(new string[] {"pu"}, "ぷ"),
				new Hiragana(new string[] {"pe"}, "ぺ"),
				new Hiragana(new string[] {"po"}, "ぽ"),
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
		List<Hiragana> qusList;
		int now;
		Point textBox_ansLocation;
		Timer textBox_ansTimer = new Timer();
		int timerCount;

		class Hiragana
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

			public Hiragana(string[] yomi, string character)
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

		private void Form1_Resize(object sender, EventArgs e)
		{
			Control control = (Control)sender;

			textBox_ansLocation = new Point((this.Size.Width - textBox_ans.Size.Width) / 2,
											(this.Size.Height - textBox_ans.Size.Height) / 4 * 3);
			textBox_ans.Location = textBox_ansLocation;
			label1_qus.Location = new Point((control.Size.Width - label1_qus.Size.Width) / 2,
											(control.Size.Height - label1_qus.Size.Height) / 4);
		}
	}
}
