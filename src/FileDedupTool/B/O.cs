using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007B1262ED64_002DD0A6_002D499E_002D9510_002DF2240F018DBB_007D;
using A;
using B;
using C;
using a;
using b;
using c;

namespace B
{
	public static class O
	{
		private struct A
		{
			public int A_f_1;

			public FILETIME A_f_2;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		private struct a
		{
			public A A;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
			public string A_1;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
			public string a_f_1;

			public int A_2;

			public uint A_3;

			public uint a_f_2;

			[MarshalAs(UnmanagedType.Bool)]
			public bool A_4;
		}

		[Serializable]
		[CompilerGenerated]
		private sealed class B
		{
			public static readonly B A = new B();

			public static Func<N, bool> A_1;

			internal bool A_m_1(N P_0)
			{
				return !P_0.A_3;
			}
		}

		private const int A_1 = 234;

		private const int a_1 = 3;

		private const int B_1 = 1000;

		private static readonly HashSet<string> A_2 = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
		{
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ad(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCo(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCP(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCp(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCQ(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCq(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCR(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCr(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCS(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCs(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCT(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCt(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCU(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCu(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCV(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCv(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCW(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCw(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCX(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCx(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCY(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCy(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCZ(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCz(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acA()
		};

		public static List<N> A_m_1(string P_0)
		{
			List<N> list = new List<N>();
			uint num = 0u;
			try
			{
				string text = Guid.NewGuid().ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.cL());
				if (A_m_1(out num, 0, text) != 0)
				{
					return list;
				}
				string[] array = new string[1] { Path.GetFullPath(P_0) };
				if (A_m_1(num, (uint)array.Length, array, 0u, null, 0u, null) != 0)
				{
					return list;
				}
				uint num2 = 0u;
				uint num3 = 0u;
				uint num4 = 0u;
				if (A_m_1(num, out num2, ref num3, null, out num4) != 234 || num2 == 0)
				{
					return list;
				}
				num3 = num2;
				a[] array2 = new a[num3];
				if (A_m_1(num, out num2, ref num3, array2, out num4) != 0)
				{
					return list;
				}
				int id = Process.GetCurrentProcess().Id;
				uint sessionId = (uint)Process.GetCurrentProcess().SessionId;
				for (int num5 = 0; num5 < num3 && num5 < array2.Length; num5++)
				{
					a a2 = array2[num5];
					int a_f_ = a2.A.A_f_1;
					if (a_f_ <= 4 || a_f_ == id)
					{
						continue;
					}
					string text2 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
					string text3 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
					long num6 = 0L;
					bool flag2 = false;
					try
					{
						using Process process = Process.GetProcessById(a_f_);
						text2 = process.ProcessName;
						// C-02：记录启动时间，供结束进程前做身份校验，避免 PID 复用误杀。
						try
						{
							num6 = process.StartTime.ToUniversalTime().Ticks;
						}
						catch
						{
						}
						try
						{
							flag2 = process.MainWindowHandle != IntPtr.Zero;
						}
						catch
						{
						}
						try
						{
							text3 = ((process.MainModule == null) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D() : process.MainModule.FileName);
						}
						catch
						{
						}
					}
					catch
					{
					}
					bool flag = a2.A_2 == 3 || a2.A_2 == 1000;
					N n2 = new N
					{
						A = a_f_,
						A_1 = text2,
						a = text3,
						A_2 = a2.a_f_2,
						a_1 = (uint)a2.A_2,
						A_4 = num6,
						a_2 = flag2
					};
					n2.A_3 = flag || a2.a_f_2 == 0 || a2.a_f_2 != sessionId || A_2.Contains(text2 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
					list.Add(n2);
				}
			}
			catch
			{
			}
			finally
			{
				if (num != 0)
				{
					try
					{
						A_m_1(num);
					}
					catch
					{
					}
				}
			}
			return list;
		}

		public static List<N> A_m_1(IEnumerable<N> P_0)
		{
			return P_0.Where((N n2) => !n2.A_3).ToList();
		}

		public static n A_m_1(string P_0, bool P_1, Func<string, List<N>, bool> P_2, out string P_3)
		{
			P_3 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			if (!global::a.a.F(P_0))
			{
				return n.A;
			}
			List<N> list = A_m_1(P_0);
			List<N> list2 = A_m_1(list);
			if (list2.Count == 0)
			{
				P_3 = ((list.Count > 0) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCK() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCj());
				return n.b;
			}
			if (!P_1)
			{
				if (P_2 == null)
				{
					P_3 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCk();
					return n.b;
				}
				if (!P_2(P_0, list2))
				{
					P_3 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCL();
					return n.B;
				}
			}
			else if (P_2 != null && list2.Exists((N n2) => n2.a_2))
			{
				// C-02：静默模式原本完全跳过确认。若目标进程拥有主窗口（可能持有未保存数据），仍需一次确认，
				// 避免“静默删除”在用户不知情的情况下关闭其编辑中的文档。
				if (!P_2(P_0, list2))
				{
					P_3 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCL();
					return n.B;
				}
			}
			List<string> list3 = new List<string>();
			List<string> list4 = new List<string>();
			foreach (N item in list2)
			{
				if (A_m_1(item, out var text))
				{
					list3.Add(item.A_1 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCl() + item.A + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.R());
				}
				else
				{
					list4.Add((string.IsNullOrEmpty(item.A_1) ? (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCM() + item.A) : item.A_1) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ah() + text);
				}
			}
			if (list3.Count > 0)
			{
				Thread.Sleep(600);
			}
			if (!global::a.a.F(P_0))
			{
				P_3 = ((list3.Count > 0) ? (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCN() + string.Join(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aw(), list3)) : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCm());
				return n.a;
			}
			P_3 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCn() + ((list4.Count > 0) ? (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCO() + string.Join(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aw(), list4)) : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
			return n.b;
		}

		private static bool A_m_1(N P_0, out string P_1)
		{
			P_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			try
			{
				using Process process = Process.GetProcessById(P_0.A);
				if (process.HasExited)
				{
					return true;
				}
				// C-02：结束前校验进程身份（PID + 启动时间），避免枚举后进程退出、PID 被复用导致误杀其它程序。
				// 无法读取启动时间（受保护进程）时不执行任何强制结束，直接按失败处理。
				long num = 0L;
				try
				{
					num = process.StartTime.ToUniversalTime().Ticks;
				}
				catch
				{
					num = 0L;
				}
				if (P_0.A_4 <= 0 || num <= 0 || num != P_0.A_4)
				{
					P_1 = global::a.Q.EnMode ? "The process identity changed (PID may have been reused); it was not closed." : "进程标识已变化（PID 可能已被复用），已跳过，未结束该进程。";
					return false;
				}
				bool flag = process.MainWindowHandle != IntPtr.Zero;
				// C-02：有主窗口的程序可能持有未保存数据，优先温和关闭，并给它更长的响应时间。
				if (flag && process.CloseMainWindow())
				{
					process.WaitForExit(5000);
				}
				if (!process.HasExited)
				{
					if (flag)
					{
						// C-02：不再 2 秒后直接 Kill，避免丢失未保存数据；交由调用方提示用户手动处理。
						P_1 = global::a.Q.EnMode ? "The program did not close in time and may hold unsaved data, so it was not force-terminated." : "目标程序未响应关闭请求，可能仍有未保存数据，已跳过强制结束，请手动关闭后重试。";
						return false;
					}
					process.Kill();
					process.WaitForExit(2000);
				}
				return true;
			}
			catch (Exception ex)
			{
				P_1 = ex.Message;
				return false;
			}
		}

		[DllImport("rstrtmgr.dll", CharSet = CharSet.Unicode, EntryPoint = "RmStartSession")]
		private static extern int A_m_1(out uint P_0, int P_1, string P_2);

		[DllImport("rstrtmgr.dll", EntryPoint = "RmEndSession")]
		private static extern int A_m_1(uint P_0);

		[DllImport("rstrtmgr.dll", CharSet = CharSet.Unicode, EntryPoint = "RmRegisterResources")]
		private static extern int A_m_1(uint P_0, uint P_1, string[] P_2, uint P_3, A[] P_4, uint P_5, string[] P_6);

		[DllImport("rstrtmgr.dll", EntryPoint = "RmGetList")]
		private static extern int A_m_1(uint P_0, out uint P_1, ref uint P_2, [In][Out] a[] P_3, out uint P_4);
	}
	public sealed class o : Form
	{
		public o(global::b.Y P_0, string P_1, List<N> P_2)
		{
			Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.nj());
			FormBorderStyle = FormBorderStyle.FixedDialog;
			StartPosition = FormStartPosition.CenterParent;
			MaximizeBox = false;
			MinimizeBox = false;
			ShowInTaskbar = false;
			ClientSize = new Size(560, 340);
			Font = Q.A_m_1(9.5f);
			BackColor = P_0.A;
			ForeColor = P_0.b;
			TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
			{
				Dock = DockStyle.Fill,
				ColumnCount = 1,
				RowCount = 4,
				Padding = new Padding(16)
			};
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			Controls.Add(tableLayoutPanel);
			Label control = new Label
			{
				Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.nk()),
				AutoSize = true,
				Font = Q.A_m_1(10f, FontStyle.Bold),
				Margin = new Padding(0, 0, 0, 6)
			};
			tableLayoutPanel.Controls.Add(control, 0, 0);
			Label control2 = new Label
			{
				Text = P_1,
				AutoSize = false,
				Height = 38,
				Dock = DockStyle.Fill,
				AutoEllipsis = true,
				ForeColor = P_0.I,
				Margin = new Padding(0, 0, 0, 8)
			};
			tableLayoutPanel.Controls.Add(control2, 0, 1);
			ListBox listBox = new ListBox
			{
				Dock = DockStyle.Fill,
				IntegralHeight = false,
				BorderStyle = BorderStyle.FixedSingle
			};
			foreach (N item in P_2)
			{
				listBox.Items.Add(item.Display);
			}
			tableLayoutPanel.Controls.Add(listBox, 0, 2);
			Label control3 = new Label
			{
				Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.nl()),
				AutoSize = true,
				ForeColor = P_0.I,
				Margin = new Padding(0, 8, 0, 8)
			};
			tableLayoutPanel.Controls.Add(control3, 0, 3);
			FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel
			{
				FlowDirection = FlowDirection.RightToLeft,
				Dock = DockStyle.Bottom,
				Height = 52,
				Padding = new Padding(12, 8, 12, 8)
			};
			Controls.Add(flowLayoutPanel);
			Button button = new Button
			{
				Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.nn()),
				AutoSize = true,
				DialogResult = DialogResult.Cancel
			};
			Button button2 = new Button
			{
				Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.nm()),
				AutoSize = true
			};
			button2.Click += delegate
			{
				DialogResult = DialogResult.OK;
				Close();
			};
			flowLayoutPanel.Controls.Add(button);
			flowLayoutPanel.Controls.Add(button2);
			AcceptButton = button2;
			CancelButton = button;
			global::b.Z.A_m_1(this, P_0, button2);
		}

		[CompilerGenerated]
		private void A(object? _003Cp0_003E, EventArgs P_1)
		{
			DialogResult = DialogResult.OK;
			Close();
		}
	}
}
namespace b
{
	internal sealed class O : Form
	{
		[CompilerGenerated]
		private sealed class A
		{
			public O A_f_1;

			public int A_f_2;

			internal void A_m_1(int P_0, int P_1, string P_2)
			{
				if (A_f_1.IsDisposed)
				{
					return;
				}
				try
				{
					A_f_1.BeginInvoke(() =>
					{
						if (!A_f_1.IsDisposed && A_f_2 == A_f_1.A_19 && A_f_1.A_16 && A_f_1.a_3)
						{
							A_f_1.A_11.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anN(), P_0, P_1, P_2);
							A_f_1.A_12.Style = ProgressBarStyle.Marquee;
						}
					});
				}
				catch
				{
				}
			}
		}

		[CompilerGenerated]
		private sealed class a
		{
			public int A;

			public int a_f_1;

			public string A_1;

			public A A_2;

			internal void A_m_1()
			{
				if (!A_2.A_f_1.IsDisposed && A_2.A_f_2 == A_2.A_f_1.A_19 && A_2.A_f_1.A_16 && A_2.A_f_1.a_3)
				{
					A_2.A_f_1.A_11.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anN(), A, a_f_1, A_1);
					A_2.A_f_1.A_12.Style = ProgressBarStyle.Marquee;
				}
			}
		}

		private readonly Y A_1;

		private readonly global::A.x A_2;

		private readonly global::B.d A_3;

		private readonly global::c.G A_4;

		private readonly global::c.m A_5;

		private global::A.W A_6;

		private global::B.A A_7;

		private ComboBox A_8;

		private NumericUpDown A_9;

		private Button A_10;

		private Button a_1;

		private Button B_1;

		private Button b_1;

		private Button C_1;

		private Button c_1;

		private Label A_11;

		private Label a_2;

		private ProgressBar A_12;

		private ListView A_13;

		private List<m> A_14 = new List<m>();

		private CancellationTokenSource A_15;

		private bool A_16;

		private M A_17;

		private Font A_18;

		private int A_19;

		private bool a_3;

		private global::B.d RemoteClient
		{
			get
			{
				if (A_3 != null)
				{
					return A_3;
				}
				if (A_6.Id != global::A.v.a)
				{
					return A_4;
				}
				return A_5;
			}
		}

		private bool RecycleBin
		{
			get
			{
				if (A_6.Id == global::A.v.a)
				{
					return A_5.SupportsRecycleBin;
				}
				return A_4.SupportsRecycleBin;
			}
		}

		private string CapabilityText
		{
			get
			{
				if (A_6.Id != global::A.v.a)
				{
					return A_4.DeleteCapabilityText;
				}
				return A_5.DeleteCapabilityText;
			}
		}

		internal List<m> GroupsForTest => A_14;

		internal ListView ListForTest => A_13;

		internal Label SummaryForTest => a_2;

		internal Label StateLabelForTest => A_11;

		internal Button ScanButtonForTest => A_10;

		internal Button StopButtonForTest => a_1;

		internal Button DeleteButtonForTest => C_1;

		internal string CapabilityTextForTest => CapabilityText;

		internal ComboBox PlatformComboForTest => A_8;

		internal O(Y P_0, global::A.x P_1, global::B.d P_2 = null)
		{
			A_1 = P_0 ?? Y.A_m_1();
			A_2 = P_1 ?? new global::A.x();
			A_3 = P_2;
			A_6 = global::A.w.A_m_1(A_2.LanzouPlatform);
			A_4 = new global::c.G(null, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aav(), Math.Max(1000, Math.Min(2000, A_2.LanzouRateLimitMs)), null);
			A_5 = new global::c.m();
			A_m_1();
			Z.A_m_1(this, A_1, A_10);
			A_8.SelectedIndex = ((A_6.Id == global::A.v.a) ? 1 : 0);
			A_8.SelectedIndexChanged += delegate
			{
				a_m_1();
			};
			A_m_1(A_6, false);
			Shown += delegate
			{
				b_m_1();
			};
			FormClosing += delegate
			{
				if (A_15 != null)
				{
					A_15.Cancel();
				}
				A_4.Dispose();
				A_5.Dispose();
				if (A_3 != null)
				{
					A_3.Dispose();
				}
				if (A_18 != null)
				{
					A_18.Dispose();
					A_18 = null;
				}
			};
		}

		private void A_m_1()
		{
			Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajY());
			Icon = global::A.R.App;
			Font = global::B.Q.A_m_1(10f);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1180, 760);
			MinimumSize = new Size(980, 620);
			StartPosition = FormStartPosition.CenterParent;
			BackColor = A_1.A;
			ForeColor = A_1.b;
			TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
			{
				Dock = DockStyle.Fill,
				ColumnCount = 1,
				RowCount = 5,
				Padding = new Padding(16, 12, 16, 12)
			};
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			Controls.Add(tableLayoutPanel);
			FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel
			{
				AutoSize = true,
				Dock = DockStyle.Top,
				WrapContents = true,
				Margin = new Padding(0)
			};
			flowLayoutPanel.Controls.Add(new Label
			{
				Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajy()),
				AutoSize = true,
				Margin = new Padding(0, 10, 4, 0)
			});
			A_8 = new ComboBox
			{
				DropDownStyle = ComboBoxStyle.DropDownList,
				Width = 190,
				Margin = new Padding(0, 6, 16, 0)
			};
			global::A.W[] array = global::A.w.A_1;
			foreach (global::A.W w2 in array)
			{
				A_8.Items.Add(w2.DisplayName);
			}
			flowLayoutPanel.Controls.Add(A_8);
			flowLayoutPanel.Controls.Add(new Label
			{
				Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajZ()),
				AutoSize = true,
				Margin = new Padding(0, 10, 4, 0)
			});
			A_9 = new NumericUpDown
			{
				Minimum = 1m,
				Maximum = 64m,
				Value = 8m,
				Width = 70,
				Margin = new Padding(0, 6, 16, 0)
			};
			flowLayoutPanel.Controls.Add(A_9);
			A_10 = A_m_1(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jX()), true);
			A_10.Click += delegate
			{
				D();
			};
			flowLayoutPanel.Controls.Add(A_10);
			a_1 = A_m_1(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jY()), false);
			a_1.Click += delegate
			{
				c_m_1();
			};
			a_1.Enabled = false;
			flowLayoutPanel.Controls.Add(a_1);
			B_1 = A_m_1(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajz()), false);
			B_1.Click += delegate
			{
				C_m_1();
			};
			flowLayoutPanel.Controls.Add(B_1);
			tableLayoutPanel.Controls.Add(flowLayoutPanel, 0, 0);
			A_12 = new ProgressBar
			{
				Dock = DockStyle.Fill,
				Minimum = 0,
				Maximum = 100,
				Height = 18,
				Margin = new Padding(0, 8, 0, 4)
			};
			tableLayoutPanel.Controls.Add(A_12, 0, 1);
			A_11 = new Label
			{
				Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKA()),
				AutoSize = true,
				MaximumSize = new Size(1120, 0),
				ForeColor = A_1.I,
				Margin = new Padding(0, 0, 0, 8)
			};
			tableLayoutPanel.Controls.Add(A_11, 0, 2);
			A_13 = new ListView
			{
				Dock = DockStyle.Fill,
				View = View.Details,
				FullRowSelect = true,
				CheckBoxes = true,
				GridLines = true,
				HideSelection = false,
				BackColor = A_1.c,
				ForeColor = A_1.D,
				Margin = new Padding(0, 0, 0, 8)
			};
			A_13.Columns.Add(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Te()), 620);
			A_13.Columns.Add(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Kd()), 100);
			A_13.Columns.Add(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.KE()), 150);
			A_13.Columns.Add(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKa()), 240);
			A_13.ItemCheck += (object P_0, ItemCheckEventArgs P_1) =>
			{
				if (P_1.Index >= 0 && P_1.Index < A_13.Items.Count && A_13.Items[P_1.Index].Tag == null)
				{
					P_1.NewValue = CheckState.Unchecked;
				}
			};
			tableLayoutPanel.Controls.Add(A_13, 0, 3);
			TableLayoutPanel tableLayoutPanel2 = new TableLayoutPanel
			{
				Dock = DockStyle.Fill,
				AutoSize = true,
				ColumnCount = 2,
				RowCount = 1,
				Margin = new Padding(0)
			};
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			a_2 = new Label
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(),
				AutoSize = true,
				MaximumSize = new Size(760, 0),
				ForeColor = A_1.I,
				Margin = new Padding(0, 8, 0, 0)
			};
			tableLayoutPanel2.Controls.Add(a_2, 0, 0);
			FlowLayoutPanel flowLayoutPanel2 = new FlowLayoutPanel
			{
				AutoSize = true,
				FlowDirection = FlowDirection.LeftToRight,
				WrapContents = true,
				Margin = new Padding(0)
			};
			b_1 = A_m_1(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKB()), false);
			b_1.Click += delegate
			{
				e();
			};
			flowLayoutPanel2.Controls.Add(b_1);
			C_1 = A_m_1(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKb()), false);
			C_1.Click += delegate
			{
				f();
			};
			flowLayoutPanel2.Controls.Add(C_1);
			c_1 = A_m_1(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bl()), false);
			c_1.Click += delegate
			{
				Close();
			};
			flowLayoutPanel2.Controls.Add(c_1);
			tableLayoutPanel2.Controls.Add(flowLayoutPanel2, 1, 0);
			tableLayoutPanel.Controls.Add(tableLayoutPanel2, 0, 4);
			AcceptButton = A_10;
		}

		private Button A_m_1(string P_0, bool P_1)
		{
			Button button = new Button();
			button.Text = P_0;
			button.AutoSize = true;
			button.MinimumSize = new Size(0, 36);
			button.Padding = new Padding(14, 4, 14, 4);
			button.BackColor = (P_1 ? A_1.f : A_1.E);
			button.ForeColor = (P_1 ? A_1.G : A_1.e);
			button.FlatStyle = FlatStyle.Flat;
			button.Margin = new Padding(0, 4, 10, 0);
			button.FlatAppearance.BorderColor = (P_1 ? A_1.f : A_1.B);
			return button;
		}

		private void a_m_1()
		{
			if (!A_16)
			{
				int selectedIndex = A_8.SelectedIndex;
				global::A.W w2 = ((selectedIndex >= 0 && selectedIndex < global::A.w.A_1.Length) ? global::A.w.A_1[selectedIndex] : global::A.w.Default);
				if (w2.Id != A_6.Id)
				{
					A_m_1(w2, true);
				}
			}
		}

		private void A_m_1(global::A.W P_0, bool P_1)
		{
			if (A_15 != null)
			{
				A_15.Cancel();
				A_15 = null;
			}
			A_6 = P_0 ?? global::A.w.Default;
			A_7 = ((A_3 != null) ? null : global::B.a.B(A_6));
			A_4.B_m_1();
			A_5.A_m_1();
			if (A_3 != null)
			{
				A_3.A();
			}
			if (A_7 != null)
			{
				RemoteClient.A(A_7);
			}
			A_14.Clear();
			A_13.Items.Clear();
			A_13.Groups.Clear();
			a_2.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			A_12.Value = 0;
			Label a_ = A_11;
			string text;
			if (A_3 != null)
			{
				text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKD());
			}
			else
			{
				text = ((A_7 != null) ? global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKc()) : global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKC()));
			}
			a_.Text = text;
			A_10.Enabled = A_3 != null || A_7 != null;
			if (P_1)
			{
				A_2.LanzouPlatform = A_6.Key;
				global::A.Y.A_m_1(A_2);
			}
			B_m_1();
		}

		private void B_m_1()
		{
			if (A_11 != null && A_3 == null)
			{
				A_11.Text = ((A_7 == null) ? global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKE()) : (global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKd()) + CapabilityText));
			}
		}

		private void b_m_1()
		{
			if (A_3 != null)
			{
				A_10.Enabled = true;
				return;
			}
			A_7 = global::B.a.B(A_6);
			if (A_7 != null)
			{
				RemoteClient.A(A_7);
				B_m_1();
				A_10.Enabled = true;
			}
		}

		private void C_m_1()
		{
			if (A_16)
			{
				return;
			}
			using global::B.b b2 = new global::B.b(A_6, A_1);
			if (b2.ShowDialog(this) == DialogResult.OK && b2.Result != null)
			{
				A_7 = b2.Result;
				RemoteClient.A(A_7);
				if (!global::B.a.A_m_1(A_6, A_7))
				{
					global::B.p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKe());
				}
				B_m_1();
				A_10.Enabled = true;
			}
		}

		private void c_m_1()
		{
			try
			{
				if (A_15 != null)
				{
					A_15.Cancel();
				}
			}
			catch
			{
			}
			A_11.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Nv());
		}

		private void A_m_1(bool P_0)
		{
			A_16 = P_0;
			A_10.Enabled = !P_0 && (A_3 != null || A_7 != null);
			a_1.Enabled = P_0;
			B_1.Enabled = !P_0;
			A_8.Enabled = !P_0;
			A_9.Enabled = !P_0;
			b_1.Enabled = !P_0 && A_14.Count > 0;
			C_1.Enabled = !P_0 && A_14.Count > 0;
		}

		private async void D()
		{
			if (A_16)
			{
				return;
			}
			if (A_3 == null && A_7 == null)
			{
				MessageBox.Show(this, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anw()), global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bB()), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			A_14.Clear();
			A_13.Items.Clear();
			A_13.Groups.Clear();
			a_2.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			A_12.Value = 0;
			A_m_1(true);
			A_15 = new CancellationTokenSource();
			int A_f_2 = ++A_19;
			a_3 = true;
			A_11.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anX());
			int num = (int)A_9.Value + 1;
			M m2 = null;
			try
			{
				m2 = await n.A_m_1(RemoteClient.B, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iZ(), num, (int P_0, int P_1, string P_2) =>
				{
					if (IsDisposed)
					{
						return;
					}
					try
					{
						BeginInvoke(() =>
						{
							if (!IsDisposed && A_f_2 == A_19 && A_16 && a_3)
							{
								A_11.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anN(), P_0, P_1, P_2);
								A_12.Style = ProgressBarStyle.Marquee;
							}
						});
					}
					catch
					{
					}
				}, A_15.Token);
			}
			catch (OperationCanceledException)
			{
				A_m_1(false);
				A_11.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anx());
				return;
			}
			catch (global::a.v v2)
			{
				A_m_1(false);
				A_11.ForeColor = A_1.J;
				A_11.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.QQ()) + global::a.u.A(v2, A_6.Experimental);
				global::B.p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anY() + v2.Message);
				return;
			}
			catch (Exception ex2)
			{
				A_m_1(false);
				A_11.ForeColor = A_1.J;
				A_11.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.any()) + ex2.Message;
				global::B.p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anZ() + ex2.Message);
				return;
			}
			finally
			{
				a_3 = false;
				if (!IsDisposed && A_12 != null && !A_12.IsDisposed)
				{
					A_12.Style = ProgressBarStyle.Blocks;
				}
			}
			A_17 = m2;
			A_14 = n.A_m_1((IEnumerable<l>)m2.Nodes);
			if (m2.Nodes.Count == 0 && m2.Errors.Count > 0 && m2.Errors.Count >= m2.FoldersScanned)
			{
				A_11.ForeColor = A_1.J;
				A_11.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.QQ()) + m2.Errors[0];
				global::B.p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anz() + m2.Errors[0]);
				A_m_1(false);
				return;
			}
			await A_m_1(A_15.Token);
			if (A_15.IsCancellationRequested)
			{
				A_m_1(false);
				A_11.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anx());
				return;
			}
			int count = n.A_m_1(A_14).Count;
			A_11.ForeColor = A_1.I;
			A_11.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOA(), m2.FoldersScanned, m2.FilesFound, A_14.Count, count) + (m2.DepthLimited ? global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOa(), A_9.Value) : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()) + ((m2.Errors.Count > 0) ? global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOB(), m2.Errors.Count) : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
			for (int num2 = 0; num2 < m2.Errors.Count && num2 < 20; num2++)
			{
				global::B.p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ans() + m2.Errors[num2]);
			}
			if (m2.Errors.Count > 20)
			{
				global::B.p.a_m_1(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOb(), m2.Errors.Count - 20));
			}
			A_m_1(false);
			A_12.Value = ((A_14.Count > 0) ? 100 : 0);
			global::B.p.A_m_1(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOC(), m2.FoldersScanned, m2.FilesFound, A_14.Count, count, m2.Errors.Count));
		}

		private void d()
		{
			List<ListViewItem> list = E();
			A_13.BeginUpdate();
			try
			{
				A_13.Items.Clear();
				A_13.Items.AddRange(list.ToArray());
			}
			finally
			{
				A_13.EndUpdate();
			}
			b_1.Enabled = A_14.Count > 0;
			C_1.Enabled = A_14.Count > 0;
		}

		private async Task A_m_1(CancellationToken P_0)
		{
			List<ListViewItem> list = E();
			A_13.BeginUpdate();
			try
			{
				A_13.Items.Clear();
				for (int num = 0; num < list.Count; num += 200)
				{
					if (P_0.IsCancellationRequested)
					{
						break;
					}
					int num2 = Math.Min(200, list.Count - num);
					ListViewItem[] array = new ListViewItem[num2];
					list.CopyTo(num, array, 0, num2);
					A_13.Items.AddRange(array);
					A_11.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anW(), num + num2, list.Count);
					await Task.Yield();
				}
			}
			finally
			{
				A_13.EndUpdate();
				b_1.Enabled = A_14.Count > 0;
				C_1.Enabled = A_14.Count > 0;
			}
		}

		private List<ListViewItem> E()
		{
			if (A_18 == null)
			{
				A_18 = new Font(A_13.Font, FontStyle.Bold);
			}
			List<ListViewItem> list = new List<ListViewItem>(A_14.Count * 3 + 8);
			for (int num = 0; num < A_14.Count; num++)
			{
				m m2 = A_14[num];
				ListViewItem listViewItem = new ListViewItem(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKF(), num + 1, m2.Name, m2.SizeText, m2.Items.Count));
				listViewItem.SubItems.Add(m2.SizeText);
				listViewItem.SubItems.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bE());
				listViewItem.SubItems.Add(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKf()));
				listViewItem.Tag = null;
				listViewItem.BackColor = A_1.a;
				listViewItem.ForeColor = A_1.C;
				listViewItem.Font = A_18;
				list.Add(listViewItem);
				for (int num2 = 0; num2 < m2.Items.Count; num2++)
				{
					l l2 = m2.Items[num2];
					bool flag = num2 == m2.KeepIndex;
					ListViewItem listViewItem2 = new ListViewItem(l2.Path)
					{
						Tag = l2
					};
					listViewItem2.SubItems.Add(l2.SizeText);
					listViewItem2.SubItems.Add(string.IsNullOrWhiteSpace(l2.Time) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bE() : l2.Time);
					listViewItem2.SubItems.Add(flag ? global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKg()) : global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKG()));
					listViewItem2.Checked = false;
					if (flag)
					{
						listViewItem2.ForeColor = A_1.j;
					}
					list.Add(listViewItem2);
				}
			}
			return list;
		}

		private void e()
		{
			A_13.BeginUpdate();
			try
			{
				foreach (ListViewItem item in A_13.Items)
				{
					if (item.Tag == null)
					{
						item.Checked = false;
					}
					else
					{
						item.Checked = !item.SubItems[3].Text.StartsWith(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bi()), StringComparison.Ordinal);
					}
				}
			}
			finally
			{
				A_13.EndUpdate();
			}
			a_2.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKH());
		}

		private List<l> F()
		{
			List<l> list = new List<l>();
			foreach (ListViewItem item2 in A_13.Items)
			{
				if (item2.Checked && item2.Tag is l item)
				{
					list.Add(item);
				}
			}
			return list;
		}

		private async void f()
		{
			if (A_16)
			{
				return;
			}
			List<l> list = F();
			if (list.Count == 0)
			{
				MessageBox.Show(this, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ann()), global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bB()), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			if (A_3 != null)
			{
				MessageBox.Show(this, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anO()), global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bB()), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			if (!RecycleBin)
			{
				global::b.C c2 = new global::b.C
				{
					A = list.Count,
					A_1 = A_m_1(list),
					a = 0,
					B = 0
				};
				string text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ano(), list.Count, global::C.E.A_m_1(c2.A_1), A_6.DisplayName, CapabilityText);
				if (!global::b.c.A_m_1(this, text, c2))
				{
					return;
				}
			}
			A_m_1(true);
			A_15 = new CancellationTokenSource();
			List<N> list2 = new List<N>();
			int num = 0;
			int num2 = 0;
			bool flag = false;
			try
			{
				foreach (List<l> item in n.A_m_1(list, 20))
				{
					if (A_15.IsCancellationRequested)
					{
						flag = true;
						break;
					}
					foreach (l item2 in item)
					{
						if (A_15.IsCancellationRequested)
						{
							flag = true;
							break;
						}
						num++;
						A_12.Value = ((list.Count != 0) ? Math.Min(100, num * 100 / list.Count) : 0);
						A_11.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anP(), num, list.Count, item2.Path);
						if (!A_m_1(item2))
						{
							flag = true;
							list2.Add(new N
							{
								Path = item2.Path,
								Size = item2.Size,
								Ok = false,
								Reason = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anp()
							});
							break;
						}
						try
						{
							await A_m_1(item2, A_15.Token);
							num2++;
							list2.Add(new N
							{
								Path = item2.Path,
								Size = item2.Size,
								Ok = true,
								Reason = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()
							});
							global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anQ() + item2.Path + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.IF() + item2.SizeText + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ln());
							A_m_1(item2, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zw()), true);
						}
						catch (OperationCanceledException)
						{
							flag = true;
							list2.Add(new N
							{
								Path = item2.Path,
								Size = item2.Size,
								Ok = false,
								Reason = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anp()
							});
							break;
						}
						catch (Exception ex2)
						{
							list2.Add(new N
							{
								Path = item2.Path,
								Size = item2.Size,
								Ok = false,
								Reason = ex2.Message
							});
							global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anq(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ot(), item2.Path, ex2.Message, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf());
							A_m_1(item2, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Zo()) + ex2.Message, false);
						}
					}
					if (!flag)
					{
						try
						{
							await Task.Delay(1500, A_15.Token);
						}
						catch
						{
						}
						continue;
					}
					break;
				}
			}
			finally
			{
				if (!IsDisposed)
				{
					A_m_1(false);
				}
			}
			int num3 = list2.Count - num2 - ((flag && list2.Count > 0 && list2[list2.Count - 1].Reason == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anp()) ? 1 : 0);
			if (num3 < 0)
			{
				num3 = 0;
			}
			string text2 = n.A_m_1(list2, global::B.p.OpsDir, DateTime.Now);
			string text3 = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anR(), num2, num3, flag ? global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anr()) : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
			List<string> list3 = new List<string>();
			foreach (N item3 in list2)
			{
				if (!item3.Ok && item3.Reason != _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anp())
				{
					list3.Add(item3.Path + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHr() + item3.Reason);
				}
			}
			a_2.Text = text3 + ((text2.Length > 0) ? (global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anS()) + text2) : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
			A_11.Text = text3;
			global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ans() + text3 + ((text2.Length > 0) ? (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anS() + text2) : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()));
			if (list3.Count > 0)
			{
				string text4 = text3 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anT() + string.Join(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kk(), list3.GetRange(0, Math.Min(30, list3.Count)).ToArray()) + ((list3.Count > 30) ? (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ant() + list3.Count + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anU()) : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()) + ((text2.Length > 0) ? (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anu() + text2) : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
				MessageBox.Show(this, text4, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anV()), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else if (!flag)
			{
				MessageBox.Show(this, text3, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anv()), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		private bool A_m_1(l P_0)
		{
			string text = (string.IsNullOrEmpty(P_0.DirPath) ? global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Dw()) : P_0.DirPath);
			string text2 = (RecycleBin ? global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKI(), P_0.Path, text) : global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKh(), P_0.Path, text));
			return MessageBox.Show(this, text2, RecycleBin ? global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKJ()) : global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKi()), MessageBoxButtons.YesNo, RecycleBin ? MessageBoxIcon.Question : MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes;
		}

		private async Task A_m_1(l P_0, CancellationToken P_1)
		{
			if (A_6.Id == global::A.v.a)
			{
				await A_5.D_m_1(P_0.Id, P_1).ConfigureAwait(continueOnCapturedContext: true);
			}
			else
			{
				await A_4.A_m_1(P_0.Id, false, P_1).ConfigureAwait(continueOnCapturedContext: true);
			}
		}

		private void A_m_1(l P_0, string P_1, bool P_2)
		{
			foreach (ListViewItem item in A_13.Items)
			{
				if (item.Tag is l l2 && string.Equals(l2.Path, P_0.Path, StringComparison.Ordinal))
				{
					item.SubItems[3].Text = P_1;
					item.Checked = false;
					item.ForeColor = (P_2 ? A_1.I : A_1.J);
				}
			}
		}

		private static long A_m_1(List<l> P_0)
		{
			long num = 0L;
			foreach (l item in P_0)
			{
				if (item.Size > 0)
				{
					num += item.Size;
				}
			}
			return num;
		}

		internal void A_m_1(List<m> P_0)
		{
			A_14 = P_0 ?? new List<m>();
			d();
		}

		internal void G()
		{
			D();
		}

		internal Task a_m_1(List<m> P_0)
		{
			A_14 = P_0 ?? new List<m>();
			return A_m_1(CancellationToken.None);
		}

		[CompilerGenerated]
		private void A_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			a_m_1();
		}

		[CompilerGenerated]
		private void a_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			b_m_1();
		}

		[CompilerGenerated]
		private void A_m_1(object? _003Cp0_003E, FormClosingEventArgs P_1)
		{
			if (A_15 != null)
			{
				A_15.Cancel();
			}
			A_4.Dispose();
			A_5.Dispose();
			if (A_3 != null)
			{
				A_3.Dispose();
			}
			if (A_18 != null)
			{
				A_18.Dispose();
				A_18 = null;
			}
		}

		[CompilerGenerated]
		private void B_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			D();
		}

		[CompilerGenerated]
		private void b_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			c_m_1();
		}

		[CompilerGenerated]
		private void C_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			C_m_1();
		}

		[CompilerGenerated]
		private void A_m_1(object P_0, ItemCheckEventArgs P_1)
		{
			if (P_1.Index >= 0 && P_1.Index < A_13.Items.Count && A_13.Items[P_1.Index].Tag == null)
			{
				P_1.NewValue = CheckState.Unchecked;
			}
		}

		[CompilerGenerated]
		private void c_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			e();
		}

		[CompilerGenerated]
		private void D(object? _003Cp0_003E, EventArgs P_1)
		{
			f();
		}

		[CompilerGenerated]
		private void d(object? _003Cp0_003E, EventArgs P_1)
		{
			Close();
		}
	}
	public static class o
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class A
		{
			public static readonly A A_f_1 = new A();

			public static Func<Q, bool> A_f_2;

			public static Func<q, IEnumerable<Q>> A_f_3;

			public static Func<Q, string> A_f_4;

			public static Func<Q, long> A_f_5;

			public static Func<IGrouping<string, Q>, B<string, int, long>> A_f_6;

			public static Func<B<string, int, long>, long> A_f_7;

			public static Func<q, b<q, long>> A_f_8;

			public static Func<b<q, long>, long> A_f_9;

			internal IEnumerable<Q> A_m_1(q P_0)
			{
				return P_0.A_2.Where((Q q2) => !q2.A_3);
			}

			internal bool A_m_1(Q P_0)
			{
				return !P_0.A_3;
			}

			internal string a(Q P_0)
			{
				return Path.GetExtension(P_0.A).ToLowerInvariant();
			}

			internal B<string, int, long> A_m_1(IGrouping<string, Q> P_0)
			{
				return new B<string, int, long>(P_0.Key, P_0.Count(), P_0.Sum((Q q2) => q2.A_1));
			}

			internal long B(Q P_0)
			{
				return P_0.A_1;
			}

			internal long A_m_1(B<string, int, long> P_0)
			{
				return P_0.Bytes;
			}

			internal b<q, long> a(q P_0)
			{
				return new b<q, long>(P_0, P_0.WastedBytes);
			}

			internal long A_m_1(b<q, long> P_0)
			{
				return P_0.W;
			}
		}

		public static string A_m_1(R P_0, string P_1, int P_2 = 0)
		{
			StringBuilder stringBuilder = new StringBuilder(A_m_1(P_2));
			stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kN()).Append(global::a.Q.EnMode ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Hk() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.HK()).Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kn());
			stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kO()).Append(a(P_1)).Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kP());
			stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kp());
			stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kQ());
			stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kq());
			stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kR());
			stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kr());
			stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kS());
			stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ks());
			stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKj());
			stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKK());
			stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kT());
			stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kt());
			stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kU()).Append(a(P_1)).Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ku());
			stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kV() + global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Sz())).Append(a(P_0.A_4)).Append(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kW()))
				.Append(P_0.A_5.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CI()))
				.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kw());
			stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kX() + global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kx()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kY()).Append(P_0.A_2).Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ky());
			stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kX() + global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kZ()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kY()).Append(P_0.A_1.Count).Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ky());
			stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kX() + global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.sC()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kY()).Append(P_0.DupFileCount).Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ky());
			stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kX() + global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kz()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kY()).Append(A_m_1(P_0.WastedBytes)).Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ky());
			IOrderedEnumerable<B<string, int, long>> orderedEnumerable = from q2 in P_0.A_1.SelectMany((q q2) => q2.A_2.Where((Q q3) => !q3.A_3))
				group q2 by Path.GetExtension(q2.A).ToLowerInvariant() into grouping
				select new B<string, int, long>(grouping.Key, grouping.Count(), grouping.Sum((Q q2) => q2.A_1)) into b2
				orderby b2.Bytes descending
				select b2;
			if (orderedEnumerable.Any())
			{
				stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKk() + global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.sd()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKL() + global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.se()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LE() + global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.sf()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LE() + global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.sg()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LF());
				foreach (B<string, int, long> item in orderedEnumerable)
				{
					stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lf()).Append(a(item.Ext)).Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LI())
						.Append(item.Count)
						.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LI())
						.Append(A_m_1(item.Bytes))
						.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Li());
				}
				stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LJ());
			}
			IEnumerable<b<q, long>> enumerable = (from q2 in P_0.A_1
				select new b<q, long>(q2, q2.WastedBytes) into b2
				orderby b2.W descending
				select b2).Take(10);
			stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKk() + global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.QI()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKL() + global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bh()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LE() + global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BI()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LE() + global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.sh()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LE() + global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.si()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LF());
			foreach (b<q, long> item2 in enumerable)
			{
				stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lf()).Append(a(item2.G.B)).Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LI())
					.Append(a(item2.G.a))
					.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LI())
					.Append(A_m_1(item2.W))
					.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LI())
					.Append(a(item2.G.A_2[0].A))
					.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Li());
			}
			stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LJ());
			stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKk() + global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.sj())).Append(P_0.A_1.Count).Append(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.sk()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lc());
			int num = 0;
			foreach (q item3 in P_0.A_1)
			{
				stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LB()).Append(++num).Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aA())
					.Append(P_0.A_1.Count)
					.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Il())
					.Append(a(item3.B))
					.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKl())
					.Append(a(item3.a))
					.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKM() + global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.sl()))
					.Append(A_m_1(item3.WastedBytes))
					.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lc());
				if (item3.A_1 == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CU())
				{
					stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKm());
					foreach (Q item4 in item3.A_2.Take(4))
					{
						stringBuilder.Append(A_m_1(item4.A));
					}
					stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKN());
				}
				stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LD() + global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ld()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LE() + global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Le()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LE() + global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Kd()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LE() + global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.KE()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LF());
				foreach (Q item5 in item3.A_2)
				{
					stringBuilder.Append(item5.A_3 ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKO() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKn());
					stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lh()).Append(a(item5.A)).Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LI())
						.Append(A_m_1(item5.A_1))
						.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LI())
						.Append(item5.A_2.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.q()))
						.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Li());
				}
				stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LJ());
			}
			foreach (string item6 in P_0.A_6)
			{
				stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKo()).Append(a(item6)).Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kw());
			}
			stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lj()).Append(a(global::C.f.HtmlLine)).Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kw());
			stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKP());
			return stringBuilder.ToString();
		}

		private static string A_m_1(string P_0)
		{
			try
			{
				using FileStream stream = File.OpenRead(global::a.a.A(P_0));
				using Bitmap bitmap = new Bitmap(stream);
				int num = bitmap.Width;
				int num2 = bitmap.Height;
				int num3 = 220;
				if (num > num3 || num2 > num3)
				{
					double num4 = Math.Min((double)num3 / (double)num, (double)num3 / (double)num2);
					num = Math.Max(1, (int)((double)num * num4));
					num2 = Math.Max(1, (int)((double)num2 * num4));
				}
				using Bitmap bitmap2 = new Bitmap(bitmap, num, num2);
				using MemoryStream memoryStream = new MemoryStream();
				bitmap2.Save(memoryStream, ImageFormat.Jpeg);
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKp() + Convert.ToBase64String(memoryStream.ToArray()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKQ() + a(P_0) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKq();
			}
			catch
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}
		}

		public static void a(R P_0, string P_1, int P_2 = 0)
		{
			StringBuilder stringBuilder = new StringBuilder(A_m_1(P_2));
			stringBuilder.AppendLine(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.sn()) + global::C.f.CsvHeaderSuffix);
			int num = 0;
			foreach (q item in P_0.A_1)
			{
				foreach (Q item2 in item.A_2)
				{
					stringBuilder.AppendLine(string.Format(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKR(), ++num, global::a.Q.A_m_1(item.a), item2.A_3 ? global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mB()) : (item2.a ? global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.so()) : global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.sp())), item2.A.Replace(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JX(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lk()), item2.A_1, item2.A_2));
				}
			}
			File.WriteAllText(P_1, stringBuilder.ToString(), new UTF8Encoding(encoderShouldEmitUTF8Identifier: true));
		}

		private static string a(string P_0)
		{
			return (P_0 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).Replace(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LL(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ll()).Replace(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LM(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lm()).Replace(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LN(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ln())
				.Replace(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JX(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LO());
		}

		private static int A_m_1(int P_0)
		{
			if (P_0 <= 0)
			{
				return 16;
			}
			long num = (long)P_0 * 1024L;
			if (num <= 1048576)
			{
				return (int)num;
			}
			return 1048576;
		}

		private static string A_m_1(long P_0)
		{
			double num = P_0;
			if (num < 1024.0)
			{
				return P_0 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bd();
			}
			if (num < 1048576.0)
			{
				return (num / 1024.0).ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.w()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BE();
			}
			if (num < 1073741824.0)
			{
				return (num / 1024.0 / 1024.0).ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.w()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Be();
			}
			return (num / 1024.0 / 1024.0 / 1024.0).ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BF()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bf();
		}
	}
}
