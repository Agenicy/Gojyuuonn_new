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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.字體ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fontDialog1 = new System.Windows.Forms.FontDialog();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button_PrevPage
			// 
			this.button_PrevPage.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.button_PrevPage.Location = new System.Drawing.Point(12, 27);
			this.button_PrevPage.Name = "button_PrevPage";
			this.button_PrevPage.Size = new System.Drawing.Size(30, 30);
			this.button_PrevPage.TabIndex = 0;
			this.button_PrevPage.Text = "↻";
			this.button_PrevPage.UseVisualStyleBackColor = true;
			this.button_PrevPage.Click += new System.EventHandler(this.button_PrevPage_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.字體ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(385, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 字體ToolStripMenuItem
			// 
			this.字體ToolStripMenuItem.Name = "字體ToolStripMenuItem";
			this.字體ToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
			this.字體ToolStripMenuItem.Text = "字體(font)";
			this.字體ToolStripMenuItem.Click += new System.EventHandler(this.字體ToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(385, 363);
			this.Controls.Add(this.button_PrevPage);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Kana practice";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button_PrevPage;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 字體ToolStripMenuItem;
		private System.Windows.Forms.FontDialog fontDialog1;
	}
}

