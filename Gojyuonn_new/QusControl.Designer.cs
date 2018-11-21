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
			this.textBox_ans = new System.Windows.Forms.TextBox();
			this.label1_qus = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox_ans
			// 
			this.textBox_ans.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBox_ans.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.textBox_ans.Location = new System.Drawing.Point(158, 333);
			this.textBox_ans.Margin = new System.Windows.Forms.Padding(4);
			this.textBox_ans.Name = "textBox_ans";
			this.textBox_ans.Size = new System.Drawing.Size(178, 75);
			this.textBox_ans.TabIndex = 3;
			this.textBox_ans.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_ans_KeyDown);
			// 
			// label1_qus
			// 
			this.label1_qus.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1_qus.AutoSize = true;
			this.label1_qus.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1_qus.Location = new System.Drawing.Point(201, 82);
			this.label1_qus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1_qus.Name = "label1_qus";
			this.label1_qus.Size = new System.Drawing.Size(92, 82);
			this.label1_qus.TabIndex = 2;
			this.label1_qus.Text = "Q";
			this.label1_qus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.label1_qus, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.textBox_ans, 0, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(494, 494);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// QusControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "QusControl";
			this.Size = new System.Drawing.Size(500, 500);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox textBox_ans;
		private System.Windows.Forms.Label label1_qus;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}
