using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Gojyuonn_new
{
	public partial class QusControl : UserControl
	{
		public QusControl(string qusFilename)
		{
			InitializeComponent();

			qusList = new List<Question>();
			// read in json and decode datas from it
			string json = System.IO.File.ReadAllText(qusFilename);
			List<Question> questions = JsonConvert.DeserializeObject<List<Question>>(json);
			if (questions != null)
			{
				foreach (var qus in questions)
				{
					qusList.Add(qus);
				}
			}

			// pre-load first question
			if (qusList.Count > 0)
			{
				now = rand.Next(qusList.Count);
				label1_qus.Text = qusList[now].Ques;
			}

			textBox_ansLocation = textBox_ans.Location;

			// make textBox shake animation
			textBox_ansTimer.Interval = 10;
			textBox_ansTimer.Tick += (send, eve) =>
			{
				// shake it 5 period per 500ms, left and right 3px.
				textBox_ans.Location = new Point(textBox_ansLocation.X + (int)(3 * Math.Cos((double)timerCount / 500 * 5 * 2 * Math.PI)), textBox_ansLocation.Y);
				// timerCount records how long timer have ran,  we let it run for only 500ms
				if ((timerCount += textBox_ansTimer.Interval) >= 500)
				{
					// in case of location error done during shaking, we need to reset textBox to where it should be.
					textBox_ans.Location = textBox_ansLocation;
					timerCount = 0;
					textBox_ansTimer.Stop();
				}
			};
		}

		public List<Question> qusList;
		Random rand = new Random();
		int now;
		Point textBox_ansLocation;
		Timer textBox_ansTimer = new Timer();
		int timerCount;

		public Font font
		{
			set
			{
				textBox_ans.Font = value;
				label1_qus.Font = value;
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
