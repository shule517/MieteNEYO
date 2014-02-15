namespace みえてねぇよ_
{
	partial class Viewer
	{
		/// <summary>
		/// 必要なデザイナ変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナで生成されたコード

		/// <summary>
		/// デザイナ サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディタで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Viewer));
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.ファイルを開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.拡大率ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem50per = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem75per = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem100per = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem150per = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem200per = new System.Windows.Forms.ToolStripMenuItem();
			this.サイズ指定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripMenuItemWidth160 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemWidth320 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemWidth480 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemWidth640 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemWidth800 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.高さToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemHeight120 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemHeight240 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemHeight360 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemHeight480 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemHeight600 = new System.Windows.Forms.ToolStripMenuItem();
			this.常に最前列ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.スナップウィンドウSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.閉じるToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.initTimer = new System.Windows.Forms.Timer(this.components);
			this.contextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルを開くToolStripMenuItem,
            this.拡大率ToolStripMenuItem,
            this.サイズ指定ToolStripMenuItem,
            this.常に最前列ToolStripMenuItem,
            this.スナップウィンドウSToolStripMenuItem,
            this.閉じるToolStripMenuItem});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(168, 136);
			// 
			// ファイルを開くToolStripMenuItem
			// 
			this.ファイルを開くToolStripMenuItem.Name = "ファイルを開くToolStripMenuItem";
			this.ファイルを開くToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
			this.ファイルを開くToolStripMenuItem.Text = "ファイルを開く (O)";
			this.ファイルを開くToolStripMenuItem.Click += new System.EventHandler(this.ファイルを開くToolStripMenuItem_Click);
			// 
			// 拡大率ToolStripMenuItem
			// 
			this.拡大率ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem50per,
            this.toolStripMenuItem75per,
            this.toolStripMenuItem100per,
            this.toolStripMenuItem150per,
            this.toolStripMenuItem200per});
			this.拡大率ToolStripMenuItem.Name = "拡大率ToolStripMenuItem";
			this.拡大率ToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
			this.拡大率ToolStripMenuItem.Text = "拡大率";
			// 
			// toolStripMenuItem50per
			// 
			this.toolStripMenuItem50per.Name = "toolStripMenuItem50per";
			this.toolStripMenuItem50per.Size = new System.Drawing.Size(112, 22);
			this.toolStripMenuItem50per.Text = "50% (1)";
			this.toolStripMenuItem50per.Click += new System.EventHandler(this.toolStripMenuItem50per_Click);
			// 
			// toolStripMenuItem75per
			// 
			this.toolStripMenuItem75per.Name = "toolStripMenuItem75per";
			this.toolStripMenuItem75per.Size = new System.Drawing.Size(112, 22);
			this.toolStripMenuItem75per.Text = "75% (2)";
			this.toolStripMenuItem75per.Click += new System.EventHandler(this.toolStripMenuItem75per_Click);
			// 
			// toolStripMenuItem100per
			// 
			this.toolStripMenuItem100per.Name = "toolStripMenuItem100per";
			this.toolStripMenuItem100per.Size = new System.Drawing.Size(112, 22);
			this.toolStripMenuItem100per.Text = "100% (3)";
			this.toolStripMenuItem100per.Click += new System.EventHandler(this.toolStripMenuItem100per_Click);
			// 
			// toolStripMenuItem150per
			// 
			this.toolStripMenuItem150per.Name = "toolStripMenuItem150per";
			this.toolStripMenuItem150per.Size = new System.Drawing.Size(112, 22);
			this.toolStripMenuItem150per.Text = "150% (4)";
			this.toolStripMenuItem150per.Click += new System.EventHandler(this.toolStripMenuItem150per_Click);
			// 
			// toolStripMenuItem200per
			// 
			this.toolStripMenuItem200per.Name = "toolStripMenuItem200per";
			this.toolStripMenuItem200per.Size = new System.Drawing.Size(112, 22);
			this.toolStripMenuItem200per.Text = "200% (5)";
			this.toolStripMenuItem200per.Click += new System.EventHandler(this.toolStripMenuItem200per_Click);
			// 
			// サイズ指定ToolStripMenuItem
			// 
			this.サイズ指定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripMenuItemWidth160,
            this.toolStripMenuItemWidth320,
            this.toolStripMenuItemWidth480,
            this.toolStripMenuItemWidth640,
            this.toolStripMenuItemWidth800,
            this.toolStripSeparator1,
            this.高さToolStripMenuItem,
            this.toolStripMenuItemHeight120,
            this.toolStripMenuItemHeight240,
            this.toolStripMenuItemHeight360,
            this.toolStripMenuItemHeight480,
            this.toolStripMenuItemHeight600});
			this.サイズ指定ToolStripMenuItem.Name = "サイズ指定ToolStripMenuItem";
			this.サイズ指定ToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
			this.サイズ指定ToolStripMenuItem.Text = "サイズ指定";
			// 
			// toolStripTextBox1
			// 
			this.toolStripTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.toolStripTextBox1.Name = "toolStripTextBox1";
			this.toolStripTextBox1.ReadOnly = true;
			this.toolStripTextBox1.Size = new System.Drawing.Size(100, 19);
			this.toolStripTextBox1.Text = "【 Width 】";
			// 
			// toolStripMenuItemWidth160
			// 
			this.toolStripMenuItemWidth160.Name = "toolStripMenuItemWidth160";
			this.toolStripMenuItemWidth160.Size = new System.Drawing.Size(160, 22);
			this.toolStripMenuItemWidth160.Text = "160";
			this.toolStripMenuItemWidth160.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.toolStripMenuItemWidth160.Click += new System.EventHandler(this.toolStripMenuItemWidth160_Click);
			// 
			// toolStripMenuItemWidth320
			// 
			this.toolStripMenuItemWidth320.Name = "toolStripMenuItemWidth320";
			this.toolStripMenuItemWidth320.Size = new System.Drawing.Size(160, 22);
			this.toolStripMenuItemWidth320.Text = "320";
			this.toolStripMenuItemWidth320.Click += new System.EventHandler(this.toolStripMenuItemWidth320_Click);
			// 
			// toolStripMenuItemWidth480
			// 
			this.toolStripMenuItemWidth480.Name = "toolStripMenuItemWidth480";
			this.toolStripMenuItemWidth480.Size = new System.Drawing.Size(160, 22);
			this.toolStripMenuItemWidth480.Text = "480";
			this.toolStripMenuItemWidth480.Click += new System.EventHandler(this.toolStripMenuItemWidth480_Click);
			// 
			// toolStripMenuItemWidth640
			// 
			this.toolStripMenuItemWidth640.Name = "toolStripMenuItemWidth640";
			this.toolStripMenuItemWidth640.Size = new System.Drawing.Size(160, 22);
			this.toolStripMenuItemWidth640.Text = "640";
			this.toolStripMenuItemWidth640.Click += new System.EventHandler(this.toolStripMenuItemWidth640_Click);
			// 
			// toolStripMenuItemWidth800
			// 
			this.toolStripMenuItemWidth800.Name = "toolStripMenuItemWidth800";
			this.toolStripMenuItemWidth800.Size = new System.Drawing.Size(160, 22);
			this.toolStripMenuItemWidth800.Text = "800";
			this.toolStripMenuItemWidth800.Click += new System.EventHandler(this.toolStripMenuItemWidth800_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
			// 
			// 高さToolStripMenuItem
			// 
			this.高さToolStripMenuItem.Name = "高さToolStripMenuItem";
			this.高さToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.高さToolStripMenuItem.Text = "【 Height 】";
			// 
			// toolStripMenuItemHeight120
			// 
			this.toolStripMenuItemHeight120.Name = "toolStripMenuItemHeight120";
			this.toolStripMenuItemHeight120.Size = new System.Drawing.Size(160, 22);
			this.toolStripMenuItemHeight120.Text = "120";
			this.toolStripMenuItemHeight120.Click += new System.EventHandler(this.toolStripMenuItemHeight120_Click);
			// 
			// toolStripMenuItemHeight240
			// 
			this.toolStripMenuItemHeight240.Name = "toolStripMenuItemHeight240";
			this.toolStripMenuItemHeight240.Size = new System.Drawing.Size(160, 22);
			this.toolStripMenuItemHeight240.Text = "240";
			this.toolStripMenuItemHeight240.Click += new System.EventHandler(this.toolStripMenuItemHeight240_Click);
			// 
			// toolStripMenuItemHeight360
			// 
			this.toolStripMenuItemHeight360.Name = "toolStripMenuItemHeight360";
			this.toolStripMenuItemHeight360.Size = new System.Drawing.Size(160, 22);
			this.toolStripMenuItemHeight360.Text = "360";
			this.toolStripMenuItemHeight360.Click += new System.EventHandler(this.toolStripMenuItemHeight360_Click);
			// 
			// toolStripMenuItemHeight480
			// 
			this.toolStripMenuItemHeight480.Name = "toolStripMenuItemHeight480";
			this.toolStripMenuItemHeight480.Size = new System.Drawing.Size(160, 22);
			this.toolStripMenuItemHeight480.Text = "480";
			this.toolStripMenuItemHeight480.Click += new System.EventHandler(this.toolStripMenuItemHeight480_Click);
			// 
			// toolStripMenuItemHeight600
			// 
			this.toolStripMenuItemHeight600.Name = "toolStripMenuItemHeight600";
			this.toolStripMenuItemHeight600.Size = new System.Drawing.Size(160, 22);
			this.toolStripMenuItemHeight600.Text = "600";
			this.toolStripMenuItemHeight600.Click += new System.EventHandler(this.toolStripMenuItemHeight600_Click);
			// 
			// 常に最前列ToolStripMenuItem
			// 
			this.常に最前列ToolStripMenuItem.Name = "常に最前列ToolStripMenuItem";
			this.常に最前列ToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
			this.常に最前列ToolStripMenuItem.Text = "常に最前列 (T)";
			this.常に最前列ToolStripMenuItem.Click += new System.EventHandler(this.常に最前列ToolStripMenuItem_Click);
			// 
			// スナップウィンドウSToolStripMenuItem
			// 
			this.スナップウィンドウSToolStripMenuItem.Name = "スナップウィンドウSToolStripMenuItem";
			this.スナップウィンドウSToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
			this.スナップウィンドウSToolStripMenuItem.Text = "スナップウィンドウ (S)";
			this.スナップウィンドウSToolStripMenuItem.Click += new System.EventHandler(this.スナップウィンドウSToolStripMenuItem_Click);
			// 
			// 閉じるToolStripMenuItem
			// 
			this.閉じるToolStripMenuItem.Name = "閉じるToolStripMenuItem";
			this.閉じるToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
			this.閉じるToolStripMenuItem.Text = "閉じる (ESC)";
			this.閉じるToolStripMenuItem.Click += new System.EventHandler(this.閉じるToolStripMenuItem_Click);
			// 
			// initTimer
			// 
			this.initTimer.Enabled = true;
			this.initTimer.Interval = 1;
			this.initTimer.Tick += new System.EventHandler(this.initTimer_Tick);
			// 
			// Viewer
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(320, 240);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Viewer";
			this.Text = "みえてねぇよ！";
			this.SizeChanged += new System.EventHandler(this.Viewer_SizeChanged);
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Viewer_DragDrop);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Viewer_MouseDown);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Viewer_DragEnter);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Viewer_MouseMove);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Viewer_KeyDown);
			this.contextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem ファイルを開くToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 閉じるToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 拡大率ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem50per;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem75per;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem100per;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem150per;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem200per;
		private System.Windows.Forms.ToolStripMenuItem 常に最前列ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem スナップウィンドウSToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem サイズ指定ToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemWidth160;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemWidth320;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemWidth480;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemWidth640;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemWidth800;
		private System.Windows.Forms.ToolStripMenuItem 高さToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHeight120;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHeight240;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHeight360;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHeight480;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHeight600;
		private System.Windows.Forms.Timer initTimer;

	}
}

