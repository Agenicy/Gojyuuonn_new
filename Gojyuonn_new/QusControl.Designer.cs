namespace Gojyuonn_new
{
	partial class QusControl
	{
		/// <summary> 
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region 元件設計工具產生的程式碼

		/// <summary> 
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.label1_qus = new System.Windows.Forms.Label();
			this.textBox_ans = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1_qus
			// 
			this.label1_qus.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1_qus.AutoSize = true;
			this.label1_qus.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1_qus.Location = new System.Drawing.Point(133, 78);
			this.label1_qus.Name = "label1_qus";
			this.label1_qus.Size = new System.Drawing.Size(66, 61);
			this.label1_qus.TabIndex = 4;
			this.label1_qus.Text = "Q";
			this.label1_qus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox_ans
			// 
			this.textBox_ans.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBox_ans.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.textBox_ans.Location = new System.Drawing.Point(106, 223);
			this.textBox_ans.Name = "textBox_ans";
			this.textBox_ans.Size = new System.Drawing.Size(120, 53);
			this.textBox_ans.TabIndex = 5;
			this.textBox_ans.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_ans_KeyDown);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.label1_qus, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(333, 217);
			this.tableLayoutPanel1.TabIndex = 6;
			// 
			// QusControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.textBox_ans);
			this.Name = "QusControl";
			this.Size = new System.Drawing.Size(333, 333);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1_qus;
		private System.Windows.Forms.TextBox textBox_ans;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}
