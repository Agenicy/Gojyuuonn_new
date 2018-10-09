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
