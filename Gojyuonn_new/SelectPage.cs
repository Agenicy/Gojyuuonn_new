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
	public partial class SelectPage : UserControl
	{
		public SelectPage()
		{
			InitializeComponent();
		}

		// to pass events from child to parent,
		// you need to add a eventhandler and add handler in parent class
		// so that we could just invoke it.
		public event EventHandler hira_clicked;
		public event EventHandler kata_clicked;
		public event EventHandler kanji_clicked;

		private void button_select_hira_Click(object sender, EventArgs e)
		{
			hira_clicked?.Invoke(this, e);
		}

		private void button_select_kata_Click(object sender, EventArgs e)
		{
			kata_clicked?.Invoke(this, e);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			kanji_clicked?.Invoke(this, e);
		}
	}
}
