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

		public event EventHandler hira_clicked;
		public event EventHandler kata_clicked;

		private void button_select_hira_Click(object sender, EventArgs e)
		{
			hira_clicked?.Invoke(this, e);
		}

		private void button_select_kata_Click(object sender, EventArgs e)
		{
			kata_clicked?.Invoke(this, e);
		}
	}
}
