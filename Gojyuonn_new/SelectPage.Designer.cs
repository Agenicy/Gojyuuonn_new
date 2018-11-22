namespace Gojyuonn_new
{
	partial class SelectPage
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
			this.button_select_kata = new System.Windows.Forms.Button();
			this.button_select_hira = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button_select_kata
			// 
			this.button_select_kata.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button_select_kata.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold);
			this.button_select_kata.Location = new System.Drawing.Point(10, 59);
			this.button_select_kata.Name = "button_select_kata";
			this.button_select_kata.Size = new System.Drawing.Size(113, 41);
			this.button_select_kata.TabIndex = 3;
			this.button_select_kata.Text = "片仮名\r\nKatakana";
			this.button_select_kata.UseVisualStyleBackColor = true;
			this.button_select_kata.Click += new System.EventHandler(this.button_select_kata_Click);
			// 
			// button_select_hira
			// 
			this.button_select_hira.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button_select_hira.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.button_select_hira.Location = new System.Drawing.Point(10, 6);
			this.button_select_hira.Name = "button_select_hira";
			this.button_select_hira.Size = new System.Drawing.Size(113, 41);
			this.button_select_hira.TabIndex = 2;
			this.button_select_hira.Text = "平仮名\r\nHiragana";
			this.button_select_hira.UseVisualStyleBackColor = true;
			this.button_select_hira.Click += new System.EventHandler(this.button_select_hira_Click);
			// 
			// button1
			// 
			this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold);
			this.button1.Location = new System.Drawing.Point(10, 112);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(113, 41);
			this.button1.TabIndex = 4;
			this.button1.Text = "漢字\r\nKanjiyomi";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.button_select_hira, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.button1, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.button_select_kata, 0, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(100, 87);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(133, 160);
			this.tableLayoutPanel1.TabIndex = 5;
			// 
			// SelectPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "SelectPage";
			this.Size = new System.Drawing.Size(333, 333);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button_select_kata;
		private System.Windows.Forms.Button button_select_hira;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}
