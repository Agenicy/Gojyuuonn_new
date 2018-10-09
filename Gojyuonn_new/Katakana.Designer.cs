namespace Gojyuonn_new
{
	partial class Katakana
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
			this.SuspendLayout();
			// 
			// textBox_ans
			// 
			this.textBox_ans.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.textBox_ans.Location = new System.Drawing.Point(40, 121);
			this.textBox_ans.Name = "textBox_ans";
			this.textBox_ans.Size = new System.Drawing.Size(120, 47);
			this.textBox_ans.TabIndex = 5;
			this.textBox_ans.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_ans_KeyDown);
			// 
			// label1_qus
			// 
			this.label1_qus.AutoSize = true;
			this.label1_qus.Font = new System.Drawing.Font("UD Digi Kyokasho NK-R", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label1_qus.Location = new System.Drawing.Point(56, 33);
			this.label1_qus.Name = "label1_qus";
			this.label1_qus.Size = new System.Drawing.Size(85, 64);
			this.label1_qus.TabIndex = 4;
			this.label1_qus.Text = "ア";
			this.label1_qus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Katakana
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.textBox_ans);
			this.Controls.Add(this.label1_qus);
			this.Name = "Katakana";
			this.Size = new System.Drawing.Size(200, 200);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox_ans;
		private System.Windows.Forms.Label label1_qus;
	}
}
