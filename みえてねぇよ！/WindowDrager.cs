using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Windows.Forms;
using みえてねぇよ_;

namespace PeerstPlayer
{
	#region 構造体
	[StructLayout(LayoutKind.Sequential)]
	public struct POINT
	{
		public int x;
		public int y;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct RECT
	{
		public int left;
		public int top;
		public int right;
		public int bottom;
	}
	#endregion

	class WindowDrager
	{
		#region WIN32API
		/// <summary>
		/// 座標を含むウインドウのハンドルを取得
		/// </summary>
		/// <param name="Point">調査する座標</param>
		/// <returns>ポイントにウインドウがなければNULL</returns>
		[DllImport("user32.dll")]
		private static extern IntPtr WindowFromPoint(POINT Point);

		/// <summary>
		/// ハンドルからウインドウの位置を取得
		/// </summary>
		/// <param name="hWnd">ウインドウのハンドル</param>
		/// <param name="lpRect">ウインドウの座標</param>
		/// <returns>成功すればtrue</returns>
		[DllImport("user32.dll")]
		private static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

		/// <summary>
		/// 指定したハンドルの祖先のハンドルを取得
		/// </summary>
		/// <param name="hwnd">ハンドル</param>
		/// <param name="gaFlags">フラグ</param>
		/// <returns>祖先のハンドル</returns>
		[DllImport("user32.dll")]
		private static extern IntPtr GetAncestor(IntPtr hwnd, uint gaFlags);

		private const uint GA_ROOT = 2;

		#endregion

		#region 変数

		// ドラッグ開始時のマウスの位置
		Point click_point;
		// スナップする範囲
		const int dock_dist = 15;

		#endregion

		#region メソッド

		/// <summary>
		/// ドラッグの開始
		/// </summary>
		/// <param name="pos">マウスポインタの位置</param>
		public void Start(Point pos)
		{
			click_point = pos;
		}

		/// <summary>
		/// ドラッグ、スナップの処理
		/// </summary>
		/// <param name="main">MainForm</param>
		/// <param name="snap_window">スナップウィンドウフラグ</param>
		/// <param name="snap_screen">スナップスクリーンフラグ</param>
		public void Moving(Viewer main, bool snap_window, bool snap_screen)
		{
			int top = main.Top;
			int left = main.Left;

			top += Control.MousePosition.Y - main.Location.Y - click_point.Y;
			left += Control.MousePosition.X - main.Location.X - click_point.X;

			#region 他のウインドウに張り付く

			if (snap_window)
			{
				POINT p1, p2, p3, p4;

				p1.x = left + main.Width / 2;
				p1.y = top - dock_dist;

				p2.x = left + main.Width + dock_dist;
				p2.y = top + main.Height / 2;

				p3.x = p1.x;
				p3.y = top + main.Height + dock_dist;

				p4.x = left - dock_dist;
				p4.y = p2.y;

				IntPtr h1 = WindowFromPoint(p1);
				IntPtr h2 = WindowFromPoint(p2);
				IntPtr h3 = WindowFromPoint(p3);
				IntPtr h4 = WindowFromPoint(p4);

				if (h1 != IntPtr.Zero)
				{
					RECT rect1;
					IntPtr anc1 = GetAncestor(h1, GA_ROOT);

					if (GetWindowRect(anc1, out rect1))
					{
						if (Math.Abs(rect1.bottom - top) < dock_dist)
							top = rect1.bottom;
					}
					else
						throw new Exception("GetWindowRectに失敗");
				}

				if (h2 != IntPtr.Zero)
				{
					RECT rect2;
					IntPtr anc2 = GetAncestor(h2, GA_ROOT);
					if (GetWindowRect(anc2, out rect2))
					{
						if (Math.Abs(rect2.left - (left + main.Width)) < dock_dist)
							left = rect2.left - main.Width;
					}
					else
						throw new Exception("GetWindowRectに失敗");
				}

				if (h3 != IntPtr.Zero)
				{
					RECT rect3;
					IntPtr anc3 = GetAncestor(h3, GA_ROOT);
					if (GetWindowRect(anc3, out rect3))
					{
						if (Math.Abs(rect3.top - (top + main.Height)) < dock_dist)
							top = rect3.top - main.Height;
					}
					else
						throw new Exception("GetWindowRectに失敗");
				}

				if (h4 != IntPtr.Zero)
				{
					RECT rect4;
					IntPtr anc4 = GetAncestor(h4, GA_ROOT);
					if (GetWindowRect(anc4, out rect4))
					{
						if (Math.Abs(rect4.right - left) < dock_dist)
							left = rect4.right;
					}
					else
						throw new Exception("GetWindowRectに失敗");
				}
			}

			#endregion

			#region  スクリーンの境界に張り付く

			if (snap_screen)
			{
				Rectangle scr = Screen.GetWorkingArea(main);

				if (Math.Abs(top - scr.Top) <= dock_dist)
					top = scr.Top;
				if (Math.Abs(left - scr.Left) <= dock_dist)
					left = scr.Left;
				if (Math.Abs(top + main.Height - scr.Bottom) <= dock_dist)
					top = scr.Bottom - main.Height;
				if (Math.Abs(left + main.Width - scr.Right) <= dock_dist)
					left = scr.Right - main.Width;
			}

			#endregion

			main.Top = top;
			main.Left = left;
		}

		#endregion
	}
}
