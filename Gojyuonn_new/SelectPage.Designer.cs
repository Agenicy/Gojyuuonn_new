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
			this.SuspendLayout();
			// 
			// button_select_kata
			// 
			this.button_select_kata.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold);
			this.button_select_kata.Location = new System.Drawing.Point(27, 95);
			this.button_select_kata.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button_select_kata.Name = "button_select_kata";
			this.button_select_kata.Size = new System.Drawing.Size(170, 62);
			this.button_select_kata.TabIndex = 3;
			this.button_select_kata.Text = "片仮名\r\nKatakana";
			this.button_select_kata.UseVisualStyleBackColor = true;
			this.button_select_kata.Click += new System.EventHandler(this.button_select_kata_Click);
			// 
			// button_select_hira
			// 
			this.button_select_hira.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.button_select_hira.Location = new System.Drawing.Point(27, 25);
			this.button_select_hira.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button_select_hira.Name = "button_select_hira";
			this.button_select_hira.Size = new System.Drawing.Size(170, 62);
			this.button_select_hira.TabIndex = 2;
			this.button_select_hira.Text = "平仮名\r\nHiragana";
			this.button_select_hira.UseVisualStyleBackColor = true;
			this.button_select_hira.Click += new System.EventHandler(this.button_select_hira_Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold);
			this.button1.Location = new System.Drawing.Point(27, 165);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(170, 62);
			this.button1.TabIndex = 4;
			this.button1.Text = "漢字\r\nKanjiyomi";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// SelectPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button_select_kata);
			this.Controls.Add(this.button_select_hira);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "SelectPage";
			this.Size = new System.Drawing.Size(225, 250);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button_select_kata;
		private System.Windows.Forms.Button button_select_hira;
		private System.Windows.Forms.Button button1;
	}
}
