namespace TwitterAppSample
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.checkBox_IncrudeReply = new System.Windows.Forms.CheckBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.TextBox_TL = new System.Windows.Forms.RichTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox_LoadNum = new System.Windows.Forms.TextBox();
			this.textBox_LoadPage = new System.Windows.Forms.TextBox();
			this.TextBox_Tweet = new System.Windows.Forms.TextBox();
			this.Button_TLLoad = new System.Windows.Forms.Button();
			this.Button_Tweet = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// checkBox_IncrudeReply
			// 
			this.checkBox_IncrudeReply.AutoSize = true;
			this.checkBox_IncrudeReply.Checked = true;
			this.checkBox_IncrudeReply.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox_IncrudeReply.Font = new System.Drawing.Font("メイリオ", 9.75F);
			this.checkBox_IncrudeReply.Location = new System.Drawing.Point(132, 249);
			this.checkBox_IncrudeReply.Name = "checkBox_IncrudeReply";
			this.checkBox_IncrudeReply.Size = new System.Drawing.Size(128, 24);
			this.checkBox_IncrudeReply.TabIndex = 22;
			this.checkBox_IncrudeReply.Text = "Replyを含めない";
			this.checkBox_IncrudeReply.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(140)))), ((int)(((byte)(40)))));
			this.panel1.Location = new System.Drawing.Point(0, 159);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(385, 8);
			this.panel1.TabIndex = 15;
			// 
			// TextBox_TL
			// 
			this.TextBox_TL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TextBox_TL.Font = new System.Drawing.Font("メイリオ", 9.75F);
			this.TextBox_TL.Location = new System.Drawing.Point(17, 285);
			this.TextBox_TL.Name = "TextBox_TL";
			this.TextBox_TL.Size = new System.Drawing.Size(350, 163);
			this.TextBox_TL.TabIndex = 23;
			this.TextBox_TL.Text = "";
			this.TextBox_TL.WordWrap = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label3.Location = new System.Drawing.Point(154, 203);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(23, 24);
			this.label3.TabIndex = 18;
			this.label3.Text = "×";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label2.Location = new System.Drawing.Point(15, 180);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(126, 20);
			this.label2.TabIndex = 16;
			this.label2.Text = "読み込むツイート数";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label1.Location = new System.Drawing.Point(209, 180);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(152, 20);
			this.label1.TabIndex = 19;
			this.label1.Text = "読み込ませたいページ数";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label4.Location = new System.Drawing.Point(17, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(230, 20);
			this.label4.TabIndex = 12;
			this.label4.Text = "ツイートしたい文章を書いてください";
			// 
			// textBox_LoadNum
			// 
			this.textBox_LoadNum.Font = new System.Drawing.Font("メイリオ", 9.75F);
			this.textBox_LoadNum.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.textBox_LoadNum.Location = new System.Drawing.Point(16, 203);
			this.textBox_LoadNum.Name = "textBox_LoadNum";
			this.textBox_LoadNum.Size = new System.Drawing.Size(98, 27);
			this.textBox_LoadNum.TabIndex = 17;
			this.textBox_LoadNum.Text = "3";
			this.textBox_LoadNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox_LoadNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_LoadNum_KeyPress);
			// 
			// textBox_LoadPage
			// 
			this.textBox_LoadPage.Font = new System.Drawing.Font("メイリオ", 9.75F);
			this.textBox_LoadPage.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.textBox_LoadPage.Location = new System.Drawing.Point(210, 203);
			this.textBox_LoadPage.Name = "textBox_LoadPage";
			this.textBox_LoadPage.Size = new System.Drawing.Size(98, 27);
			this.textBox_LoadPage.TabIndex = 20;
			this.textBox_LoadPage.Text = "1";
			this.textBox_LoadPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox_LoadPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_LoadPage_KeyPress);
			// 
			// TextBox_Tweet
			// 
			this.TextBox_Tweet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TextBox_Tweet.Font = new System.Drawing.Font("メイリオ", 9.75F);
			this.TextBox_Tweet.Location = new System.Drawing.Point(18, 32);
			this.TextBox_Tweet.Multiline = true;
			this.TextBox_Tweet.Name = "TextBox_Tweet";
			this.TextBox_Tweet.Size = new System.Drawing.Size(349, 77);
			this.TextBox_Tweet.TabIndex = 13;
			// 
			// Button_TLLoad
			// 
			this.Button_TLLoad.Font = new System.Drawing.Font("メイリオ", 9.75F);
			this.Button_TLLoad.Location = new System.Drawing.Point(15, 244);
			this.Button_TLLoad.Name = "Button_TLLoad";
			this.Button_TLLoad.Size = new System.Drawing.Size(98, 33);
			this.Button_TLLoad.TabIndex = 21;
			this.Button_TLLoad.Text = "TL読み込み";
			this.Button_TLLoad.UseVisualStyleBackColor = true;
			this.Button_TLLoad.Click += new System.EventHandler(this.Button_TLLoad_Click);
			// 
			// Button_Tweet
			// 
			this.Button_Tweet.Font = new System.Drawing.Font("メイリオ", 9.75F);
			this.Button_Tweet.Location = new System.Drawing.Point(18, 115);
			this.Button_Tweet.Name = "Button_Tweet";
			this.Button_Tweet.Size = new System.Drawing.Size(95, 33);
			this.Button_Tweet.TabIndex = 14;
			this.Button_Tweet.Text = "Tweet";
			this.Button_Tweet.UseVisualStyleBackColor = true;
			this.Button_Tweet.Click += new System.EventHandler(this.Button_Tweet_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 462);
			this.Controls.Add(this.checkBox_IncrudeReply);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.TextBox_TL);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox_LoadNum);
			this.Controls.Add(this.textBox_LoadPage);
			this.Controls.Add(this.TextBox_Tweet);
			this.Controls.Add(this.Button_TLLoad);
			this.Controls.Add(this.Button_Tweet);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(400, 400);
			this.Name = "Form1";
			this.Text = "Twitter App Sample";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox checkBox_IncrudeReply;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RichTextBox TextBox_TL;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox_LoadNum;
		private System.Windows.Forms.TextBox textBox_LoadPage;
		private System.Windows.Forms.TextBox TextBox_Tweet;
		private System.Windows.Forms.Button Button_TLLoad;
		private System.Windows.Forms.Button Button_Tweet;
	}
}

