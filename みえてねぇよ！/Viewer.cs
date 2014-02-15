using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace みえてねぇよ_
{
	public partial class Viewer : Form
	{
		#region 変数、プロパティ

		private System.Drawing.Bitmap animatedImage;
		private int imageWidth = 0, imageHeight = 0;

		PeerstPlayer.WindowDrager dragWindow = new PeerstPlayer.WindowDrager();

		bool snapWindow;
		public bool SnapWindow
		{
			get { return snapWindow;}
			set { snapWindow = value; スナップウィンドウSToolStripMenuItem.Checked = value; }
		}

		#endregion

		#region メソッド

		// コンストラクタ
		public Viewer()
		{
			InitializeComponent(); // 初期化

			SnapWindow = true;

			MouseWheel += new MouseEventHandler(Viewer_MouseWheel); // マウスホイールイベント
			Paint += new PaintEventHandler(Viewer_Paint);
		}

		// ダイアログを開く
		void OpenDialog()
		{
			OpenFileDialog dlgOpen = new OpenFileDialog();

			// フィルターを設定する
			dlgOpen.Filter =
				"すべてのファイル(*.bmp *.wmf *.ico *.jpg *.gif *.png)|*.bmp;*.wmf;*.ico;*.jpg;*.gif;*.png|" +
				"メタファイル(*.wmf)|*.wmf|" +
				"アイコン(*.ico)|*.ico|" +
				"JPEG(*.jpg)|*.jpg|" +
				"GIF(*.gif)|*.gif|" +
				"PNG(*.png)|*.png|" +
				"ビットマップ(*.bmp)|*.bmp";

			if (dlgOpen.ShowDialog() == DialogResult.OK)
			{
				OpenImage(dlgOpen.FileName);
			}
		}

		// 画像を開く
		void OpenImage(String fileName)
		{
			animatedImage = new Bitmap(fileName);
			Size = new Size(animatedImage.Width, animatedImage.Height);

			imageWidth = animatedImage.Width;
			imageHeight = animatedImage.Height;

			ImageAnimator.Animate(animatedImage, new EventHandler(Image_FrameChanged));

			Refresh();
		}

		// 画像の拡大率を指定
		void SetExpansion(float x, float y)
		{
			if (animatedImage != null)
			{
				imageWidth = (int)(animatedImage.Width * x);
				imageHeight = (int)(animatedImage.Height * y);

				this.Size = new Size(imageWidth, imageHeight);
				this.Refresh();
			}
		}

		void SetWidth(int width)
		{
			if (animatedImage != null)
			{
				imageWidth = width;
				imageHeight = (int)(imageWidth * ((float)animatedImage.Height / animatedImage.Width));
				this.Size = new Size(imageWidth, imageHeight);
				Refresh();
			}
		}

		void SetHeight(int height)
		{
			if (animatedImage != null)
			{
				imageHeight = height;
				imageWidth = (int)(imageHeight * ((float)animatedImage.Width / animatedImage.Height));
				this.Size = new Size(imageWidth, imageHeight);
				Refresh();
			}
		}

		#endregion

		#region メニューストリップ

		private void ファイルを開くToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenDialog();
		}

		private void 閉じるToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void toolStripMenuItem50per_Click(object sender, EventArgs e)
		{
			SetExpansion(0.5f, 0.5f);
		}

		private void toolStripMenuItem75per_Click(object sender, EventArgs e)
		{
			SetExpansion(0.75f, 0.75f);
		}

		private void toolStripMenuItem100per_Click(object sender, EventArgs e)
		{
			SetExpansion(1.0f, 1.0f);
		}

		private void toolStripMenuItem150per_Click(object sender, EventArgs e)
		{
			SetExpansion(1.5f, 1.5f);
		}

		private void toolStripMenuItem200per_Click(object sender, EventArgs e)
		{
			SetExpansion(2.0f, 2.0f);
		}

		private void 常に最前列ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.TopMost = !this.TopMost;
			this.常に最前列ToolStripMenuItem.Checked = !this.常に最前列ToolStripMenuItem.Checked;
		}

		private void スナップウィンドウSToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SnapWindow = !SnapWindow;
		}

		private void toolStripMenuItemWidth160_Click(object sender, EventArgs e)
		{
			SetWidth(160);
		}

		private void toolStripMenuItemWidth320_Click(object sender, EventArgs e)
		{
			SetWidth(320);
		}

		private void toolStripMenuItemWidth480_Click(object sender, EventArgs e)
		{
			SetWidth(480);
		}

		private void toolStripMenuItemWidth640_Click(object sender, EventArgs e)
		{
			SetWidth(640);
		}

		private void toolStripMenuItemWidth800_Click(object sender, EventArgs e)
		{
			SetWidth(800);
		}

		private void toolStripMenuItemHeight120_Click(object sender, EventArgs e)
		{
			SetHeight(120);
		}

		private void toolStripMenuItemHeight240_Click(object sender, EventArgs e)
		{
			SetHeight(240);
		}

		private void toolStripMenuItemHeight360_Click(object sender, EventArgs e)
		{
			SetHeight(360);
		}

		private void toolStripMenuItemHeight480_Click(object sender, EventArgs e)
		{
			SetHeight(480);
		}

		private void toolStripMenuItemHeight600_Click(object sender, EventArgs e)
		{
			SetHeight(600);
		}

		#endregion

		#region イベント

		private void Viewer_SizeChanged(object sender, EventArgs e)
		{
			if (animatedImage != null)
			{
				if (imageWidth != Size.Width || imageHeight != Size.Height)
				{
					imageWidth = Size.Width;
					imageHeight = (int)(imageWidth * (float)(animatedImage.Height / animatedImage.Width));
					Size = new Size(imageWidth, imageHeight);
					Refresh();
				}
			}
		}

		// マウスホイールを動かした
		private void Viewer_MouseWheel(object sender, MouseEventArgs e)
		{
			if (e.Delta > 0) SetWidth(imageWidth + 5);
			else SetWidth(imageWidth - 5);
		}

		private void Viewer_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.T:
					this.TopMost = !this.TopMost;
					this.常に最前列ToolStripMenuItem.Checked = !this.常に最前列ToolStripMenuItem.Checked;
					break;

				case Keys.S:
					SnapWindow = !SnapWindow;
					break;

				case Keys.O:
					OpenDialog();
					break;

				case Keys.D1:
					SetExpansion(0.5f, 0.5f);
					break;

				case Keys.D2:
					SetExpansion(0.75f, 0.75f);
					break;

				case Keys.D3:
					SetExpansion(1.0f, 1.0f);
					break;

				case Keys.D4:
					SetExpansion(1.5f, 1.5f);
					break;

				case Keys.D5:
					SetExpansion(2.0f, 2.0f);
					break;

				case Keys.Escape:
					Close();
					break;
			}
		}

		private void Viewer_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Move;
		}

		private void Viewer_DragDrop(object sender, DragEventArgs e)
		{
			string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop, false);

			OpenImage(fileName[0]);
		}

		void Viewer_Paint(object sender, PaintEventArgs e)
		{
			if (animatedImage != null)
			{
				ImageAnimator.UpdateFrames(animatedImage);
				Rectangle rect = new Rectangle(0, 0, imageWidth, imageHeight);
				e.Graphics.DrawImage(animatedImage, rect);
			}
		}

		private void Image_FrameChanged(object o, EventArgs e)
		{
			// Paintイベントハンドラを呼び出す
			Invalidate();
		}

		private void Viewer_MouseDown(object sender, MouseEventArgs e)
		{
			switch (e.Button)
			{
				case MouseButtons.Left:
					dragWindow.Start(new Point(e.X, e.Y));
					break;

				case MouseButtons.Right:
					contextMenuStrip.Show(new Point(MousePosition.X, MousePosition.Y));
					break;
			}
		}

		private void Viewer_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
				dragWindow.Moving(this, snapWindow, snapWindow);
		}

		private void initTimer_Tick(object sender, EventArgs e)
		{
			string[] commands = Environment.GetCommandLineArgs();
			if (commands.Length >= 2)
			{
				if (File.Exists(commands[1]))
				{
					OpenImage(commands[1]);
				}
			}

			initTimer.Enabled = false;
		}

		#endregion

		#region ウィンドウプロシージャ

		const int frameWidth = 15;
		const int WM_NCHITTEST = 0x84;	// マウスポインタの位置メッセージ
		const int HTCLIENT = 1;			// クライアント領域内にある
		const int HTTOP = 12;			// 可変枠の上辺境界線上にある
		const int HTBOTTOM = 15;		// 可変枠の下辺境界線上にある
		const int HTLEFT = 10;			// 可変枠の左辺境界線上にある
		const int HTRIGHT = 11;			// 可変枠の右辺境界線上にある
		const int HTTOPLEFT = 13;		// 可変枠の左上隅にある
		const int HTTOPRIGHT = 14;		// 可変枠の右上隅にある
		const int HTBOTTOMLEFT = 16;	// 可変枠の左下隅にある
		const int HTBOTTOMRIGHT = 17;	// 可変枠の右下隅にある

		protected override void WndProc(ref Message m)
		{
			// マウスポインタがクライアント領域内にあるか
			// if (m.Msg == WM_NCHITTEST && (m.Result.ToInt32() == HTCLIENT) && this.WindowState == FormWindowState.Normal)
			if (m.Msg == WM_NCHITTEST && this.WindowState == FormWindowState.Normal)
			{
				if (MousePosition.Y - this.Location.Y <= frameWidth)
				{
					if (MousePosition.X - this.Location.X < frameWidth)
					{
						m.Result = (IntPtr)HTTOPLEFT;
						return;
					}
					// 左上
					else if (MousePosition.X - this.Location.X > this.Size.Width - frameWidth)
					{
						m.Result = (IntPtr)HTTOPRIGHT;
						return;
					}
					else
					{
						// 右上
						m.Result = (IntPtr)HTTOP;
						return;
					}
					// 上
				}
				else if (MousePosition.Y - this.Location.Y >= this.Size.Height - frameWidth)
				{
					if (MousePosition.X - this.Location.X <= frameWidth)
					{
						m.Result = (IntPtr)HTBOTTOMLEFT;
						return;
					}
					// 左下
					else if (MousePosition.X - this.Location.X > this.Size.Width - frameWidth)
					{
						m.Result = (IntPtr)HTBOTTOMRIGHT;
						return;
					}
					else
					{
						// 右下
						m.Result = (IntPtr)HTBOTTOM;
						return;
					}
					// 下
				}
				if (MousePosition.X - this.Location.X <= frameWidth)
				{
					m.Result = (IntPtr)HTLEFT;
					return;
				}
				// 左
				else if (MousePosition.X - this.Location.X > this.Size.Width - frameWidth)
				{
					m.Result = (IntPtr)HTRIGHT;
					return;
				}
				// 右
			}

			base.WndProc(ref m);
		}

		#endregion
	}
}
