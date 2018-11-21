namespace Gojyuonn_new
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.button_PrevPage = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button_PrevPage
			// 
			this.button_PrevPage.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.button_PrevPage.Location = new System.Drawing.Point(18, 18);
			this.button_PrevPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button_PrevPage.Name = "button_PrevPage";
			this.button_PrevPage.Size = new System.Drawing.Size(45, 45);
			this.button_PrevPage.TabIndex = 0;
			this.button_PrevPage.Text = "↻";
			this.button_PrevPage.UseVisualStyleBackColor = true;
			this.button_PrevPage.Click += new System.EventHandler(this.button_PrevPage_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(786, 392);
			this.Controls.Add(this.button_PrevPage);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Form1";
			this.Text = "Kana practice";
			this.ClientSizeChanged += new System.EventHandler(this.Form1_ClientSizeChanged);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button_PrevPage;
	}
}

