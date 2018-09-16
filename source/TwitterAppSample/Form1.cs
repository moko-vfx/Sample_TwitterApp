using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreTweet;            // 追加を忘れずに

namespace TwitterAppSample
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		// トークン
		Tokens tokens;

		private void Form1_Load(object sender, EventArgs e)
		{
			// 認証
			tokens = Tokens.Create("API keyを入力",		// API key
				"API secret keyを入力",					// API secret key
				"Access tokenを入力",					// Access token
				"Access token secretを入力");			// Access token secret
		}

		// ツイートボタン
		private async void Button_Tweet_Click(object sender, EventArgs e)
		{
			// TextBox内の文字列をツイートする
			Status _status = await tokens.Statuses.UpdateAsync
				(status => TextBox_Tweet.Text);
		}

		// TL読み込みボタン
		private void Button_TLLoad_Click(object sender, EventArgs e)
		{
			LoadTimeLine();
		}

		// TextBox に 自身のタイムラインを読み込む
		private void LoadTimeLine()
		{
			// 取得するツイート数
			long l1 = long.Parse(textBox_LoadNum.Text);  // 一度に取得する数
			long l2 = long.Parse(textBox_LoadPage.Text); // ページ数

			// リプライを含めるかどうかチェックボックスの状態を取得
			bool rep = checkBox_IncrudeReply.Checked;

			// タイムラインを取得
			var tl = tokens.Statuses.UserTimeline(count => l1, page => l2, exclude_replies => rep);

			// TextBoxへの書き込み
			foreach (var value in tl)
			{
				TextBox_TL.AppendText(value.Text + "\r\n");
			}
		}

		// 読み込み数の指定で数値入力のみ受け付ける
		private void textBox_LoadPage_KeyPress(object sender, KeyPressEventArgs e)
		{
			// 0～9とバックスペース以外の入力時はイベントをキャンセルする
			if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
			{
				e.Handled = true;
			}
		}
		// ページ数の指定で数値入力のみ受け付ける
		private void textBox_LoadNum_KeyPress(object sender, KeyPressEventArgs e)
		{
			// 0～9とバックスペース以外の入力時はイベントをキャンセルする
			if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
			{
				e.Handled = true;
			}
		}
	}
}
