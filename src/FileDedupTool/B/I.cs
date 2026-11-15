using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007B1262ED64_002DD0A6_002D499E_002D9510_002DF2240F018DBB_007D;
using A;
using a;
using b;
using c;

namespace B
{
	internal sealed class I : Form
	{
		private sealed class A
		{
			public string A_f_1;

			public string a;

			public long A_f_2;

			public global::a.w A_f_3;

			public bool A_f_4;

			public string B;

			public string b;

			public bool a_1;
		}

		[Serializable]
		[CompilerGenerated]
		private sealed class a
		{
			public static readonly a A = new a();

			public static Func<global::a.w, string> A_1;

			public static Func<global::a.w, string> a_f_1;

			public static Func<global::a.w, long> A_2;

			public static Func<global::a.w, long> a_f_2;

			public static Func<global::a.w, string> B;

			public static Func<global::a.w, string> b;

			public static Func<global::a.w, string> C;

			public static Func<global::a.w, string> c;

			public static Func<A, bool> A_3;

			public static Func<A, bool> a_f_3;

			internal string A_m_1(global::a.w P_0)
			{
				return P_0.Name ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}

			internal string a_m_1(global::a.w P_0)
			{
				return P_0.Name ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}

			internal long B_m_1(global::a.w P_0)
			{
				return P_0.SizeBytes;
			}

			internal long b_m_1(global::a.w P_0)
			{
				return P_0.SizeBytes;
			}

			internal string C_m_1(global::a.w P_0)
			{
				return P_0.Time ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}

			internal string c_m_1(global::a.w P_0)
			{
				return P_0.Time ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}

			internal string D(global::a.w P_0)
			{
				return P_0.Id ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}

			internal string d(global::a.w P_0)
			{
				return P_0.Id ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}

			internal bool A_m_1(A P_0)
			{
				return P_0.A_f_3 != null;
			}

			internal bool a_m_1(A P_0)
			{
				if (P_0.A_f_3 == null)
				{
					return P_0.A_f_4;
				}
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class B
		{
			public I A;

			public global::B.A A_1;

			internal Task A_m_1()
			{
				return A.A_m_1(A_1);
			}
		}

		[CompilerGenerated]
		private sealed class b
		{
			public string A;

			internal bool A_m_1(global::a.w P_0)
			{
				if (P_0.Name != null)
				{
					return P_0.Name.IndexOf(A, StringComparison.OrdinalIgnoreCase) >= 0;
				}
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class C
		{
			public string A;

			internal bool A_m_1(global::a.w P_0)
			{
				if (P_0.Name != null)
				{
					return P_0.Name.IndexOf(A, StringComparison.OrdinalIgnoreCase) >= 0;
				}
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class c
		{
			public I A;

			public string A_1;

			public string a;

			public string B;

			public string b;

			public bool A_2;

			public global::B.h A_3;

			public int A_4;

			public int a_1;

			public int B_1;

			internal Task<global::B.f> A_m_1(A P_0, CancellationToken P_1)
			{
				return A.A_m_1(P_0, A_1, a, B, b, A_2, A_3, P_1);
			}

			internal void A_m_1(A P_0, global::B.f P_1, Exception P_2)
			{
				if (P_2 is global::a.v && ((global::a.v)P_2).Kind == global::a.V.a)
				{
					Interlocked.Exchange(ref A_4, 1);
				}
				int A_3 = 0;
				if (P_1 != global::B.f.D)
				{
					A_3 = Interlocked.Increment(ref a_1);
				}
				try
				{
					A.Invoke(() =>
					{
						if (!A.IsDisposed)
						{
							P_0.a_1 = true;
							A.A_m_1(P_0, P_1, P_2, a);
							if (A.A_29 != null && A_3 > 0)
							{
								A.A_29.Value = Math.Min(A.A_29.Maximum, A_3 * A.A_29.Maximum / Math.Max(1, B_1));
							}
							if (A.b_3 != null && A.A_16)
							{
								A.b_3.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ww(), A_3, B_1);
							}
						}
					});
				}
				catch
				{
				}
			}
		}

		[CompilerGenerated]
		private sealed class D
		{
			public A A;

			public global::B.f A_1;

			public Exception A_2;

			public int A_3;

			public c A_4;

			internal void A_m_1()
			{
				if (!A_4.A.IsDisposed)
				{
					A.a_1 = true;
					A_4.A.A_m_1(A, A_1, A_2, A_4.a);
					if (A_4.A.A_29 != null && A_3 > 0)
					{
						A_4.A.A_29.Value = Math.Min(A_4.A.A_29.Maximum, A_3 * A_4.A.A_29.Maximum / Math.Max(1, A_4.B_1));
					}
					if (A_4.A.b_3 != null && A_4.A.A_16)
					{
						A_4.A.b_3.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ww(), A_3, A_4.B_1);
					}
				}
			}
		}

		[CompilerGenerated]
		private sealed class d
		{
			public I A;

			public A A_1;

			internal void A_m_1(long P_0, long P_1)
			{
				A.A_m_1(A_1, P_0, P_1);
			}
		}

		[CompilerGenerated]
		private sealed class E
		{
			public I A;

			public A A_1;

			public long A_2;

			public long a;

			internal void A_m_1()
			{
				if (!A.IsDisposed && A.A_16 && A.B_3 != null)
				{
					A.B_3.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.wv(), A_1.a, I.A_m_1(A_2), I.A_m_1(a));
				}
			}
		}

		[CompilerGenerated]
		private sealed class e
		{
			public I A;

			public Control A_1;

			internal void A_m_1(object? _003Cp0_003E, EventArgs P_1)
			{
				A.A_33.SetToolTip(A_1, A_1.Text);
			}
		}

		internal static Action<string> A_1;

		private readonly global::b.Y A_2;

		private readonly global::A.x A_3;

		private global::A.W A_4;

		private global::B.A A_5;

		private readonly global::c.G A_6;

		private readonly global::c.m A_7;

		private readonly global::B.d A_8;

		private readonly List<global::B.C> A_9 = new List<global::B.C>();

		private string A_10 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iZ();

		private List<global::a.w> A_11;

		private global::a.t A_12 = global::a.t.A_m_1();

		private readonly List<A> A_13 = new List<A>();

		private CancellationTokenSource A_14;

		private bool A_15;

		private volatile bool A_16;

		private long A_17;

		private readonly object A_18 = new object();

		private w A_19;

		private TextBox A_20;

		private TextBox a_1;

		private TextBox B_1;

		private TextBox b_1;

		private ComboBox A_21;

		private Button A_22;

		private Button a_2;

		private Button B_2;

		private Button b_2;

		private Button C_1;

		private Button c_1;

		private Button D_1;

		private Button d_1;

		private Button E_1;

		private Button e_1;

		private Button F_1;

		private Button f_1;

		private Button G_1;

		private Button g_1;

		private NumericUpDown A_23;

		private CheckBox A_24;

		private Label A_25;

		private Label a_3;

		private Label B_3;

		private Label b_3;

		private Label C_2;

		private Label c_2;

		private Label D_2;

		private global::A.s A_26;

		private GroupBox A_27;

		private ListView A_28;

		private ListView a_4;

		private ListView B_4;

		private ProgressBar A_29;

		private TextBox C_3;

		private Label d_2;

		private Button H_1;

		private Button h_1;

		internal static bool a_5;

		private bool B_5;

		private const int A_30 = 50;

		private int a_6;

		private int B_6 = -1;

		private bool b_4 = true;

		private TableLayoutPanel A_31;

		private FlowLayoutPanel A_32;

		private GroupBox a_7;

		private readonly ToolTip A_33 = new ToolTip();

		private readonly List<Label> A_34 = new List<Label>();

		private Panel A_35;

		private TableLayoutPanel a_8;

		private bool C_4;

		private const int b_5 = 211;

		private const int C_5 = 1;

		private const int c_3 = 2;

		private global::B.d RemoteClient
		{
			get
			{
				if (A_8 != null)
				{
					return A_8;
				}
				if (A_4.Id != global::A.v.a)
				{
					return A_6;
				}
				return A_7;
			}
		}

		private bool HasCookie
		{
			get
			{
				if (A_5 != null)
				{
					return A_5.A_m_1(A_4);
				}
				return false;
			}
		}

		internal I(global::b.Y P_0, global::A.x P_1, string P_2)
			: this(P_0, P_1, P_2, null)
		{
		}

		internal I(global::b.Y P_0, global::A.x P_1, string P_2, global::B.d P_3)
		{
			A_2 = P_0 ?? (global::b.Z.A_m_1() ? global::b.Y.a_m_1() : global::b.Y.A_m_1());
			A_3 = P_1 ?? new global::A.x();
			A_4 = global::A.w.A_m_1(A_3.LanzouPlatform);
			A_8 = P_3;
			int num = A_3.LanzouRateLimitMs;
			if (num < 1000)
			{
				num = 1000;
			}
			if (num > 2000)
			{
				num = 2000;
			}
			A_6 = new global::c.G(null, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aav(), num, null);
			A_7 = new global::c.m();
			D_m_1();
			global::a.Q.A_m_1(this);
			if (A_24 != null)
			{
				A_33.SetToolTip(A_24, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.wt()));
			}
			d_m_1();
			global::b.Z.A_m_1(this, A_2, E_1);
			string text = (string.IsNullOrWhiteSpace(P_2) ? A_3.LanzouLastLocalDir : P_2);
			if (!string.IsNullOrWhiteSpace(text) && Directory.Exists(text))
			{
				A_20.Text = text;
			}
			B_1.Text = (string.IsNullOrWhiteSpace(A_3.NetworkDuplicateFolderName) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iy() : A_3.NetworkDuplicateFolderName);
			b_1.Text = A_3.NetworkDuplicateFolderPath ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			A_21.SelectedIndex = ((A_4.Id == global::A.v.a) ? 1 : 0);
			A_21.SelectedIndexChanged += delegate
			{
				a_m_1();
			};
			A_m_1(A_4, false);
			i_m_1();
			b_m_1(false);
			Shown += delegate
			{
				if (A_5 != null)
				{
					B_3.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.VB());
					A_m_1(() => L_m_1());
				}
				else if (A_8 == null && global::A.T.IsTestBuild && A_4.Id == global::A.v.a)
				{
					A_m_1();
				}
			};
			FormClosing += delegate
			{
				if (A_14 != null)
				{
					A_14.Cancel();
				}
				q();
				// C-19：统一判空后再释放，避免 q() 内部置空导致的空引用。
				A_6?.Dispose();
				A_7?.Dispose();
				A_8?.Dispose();
			};
		}

		private async void A_m_1()
		{
			if (!global::A.T.A_m_1(out var text, out var text2) || A_15)
			{
				return;
			}
			b_m_1(true);
			B_3.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aND());
			global::B.B b2 = null;
			try
			{
				b2 = new global::B.B();
				global::B.A a2 = await b2.a_m_1(text, text2, CancellationToken.None);
				if (a2 == null || !a2.A_m_1(A_4))
				{
					throw new global::a.v(global::a.V.a, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ur()));
				}
				A_5 = a2;
				RemoteClient.A(a2);
				B_5 = false;
				if (!global::B.a.A_m_1(A_4, a2))
				{
					global::B.p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNd());
				}
				global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNE());
				b_m_1(false);
				A_m_1(() => L_m_1());
			}
			catch (Exception ex)
			{
				if (!IsDisposed)
				{
					b_m_1(false);
				}
				if (!IsDisposed)
				{
					B_3.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNe()) + ex.Message;
				}
				global::B.p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNF() + ex.Message);
			}
			finally
			{
				b2?.Dispose();
			}
		}

		private void a_m_1()
		{
			if (!A_15 && A_21 != null)
			{
				int selectedIndex = A_21.SelectedIndex;
				global::A.W w2 = ((selectedIndex >= 0 && selectedIndex < global::A.w.A_1.Length) ? global::A.w.A_1[selectedIndex] : global::A.w.Default);
				if (w2.Id != A_4.Id)
				{
					A_m_1(w2, true);
				}
			}
		}

		private void A_m_1(global::A.W P_0, bool P_1)
		{
			A_4 = P_0 ?? global::A.w.Default;
			if (A_14 != null)
			{
				A_14.Cancel();
				A_14 = null;
			}
			A_5 = global::B.a.B(A_4);
			B_5 = false;
			A_6.B_m_1();
			A_7.A_m_1();
			if (A_8 != null)
			{
				A_8.A();
			}
			if (A_5 != null)
			{
				RemoteClient.A(A_5);
			}
			A_10 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iZ();
			A_12 = global::a.t.A_m_1();
			A_9.Clear();
			A_9.Add(h_m_1());
			A_11 = null;
			a_6 = 0;
			B_6 = -1;
			b_4 = true;
			A_13.Clear();
			if (A_28 != null)
			{
				A_28.Items.Clear();
			}
			if (a_4 != null)
			{
				a_4.Items.Clear();
			}
			if (C_3 != null)
			{
				C_3.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}
			if (d_2 != null)
			{
				d_2.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}
			if (B_4 != null)
			{
				B_4.Items.Clear();
			}
			if (b_3 != null)
			{
				b_3.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}
			if (A_29 != null)
			{
				A_29.Value = 0;
			}
			I_m_1();
			if (A_27 != null)
			{
				A_27.Text = ((A_4.Id == global::A.v.a) ? global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.uh()) : global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.uV()));
			}
			if (C_2 != null)
			{
				C_2.Text = (A_4.Experimental ? global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.vQ()) : global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ug()));
			}
			if (c_2 != null)
			{
				c_2.Text = ((A_4.Id == global::A.v.a) ? global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.uX()) : global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.uW()));
			}
			if (A_5 != null)
			{
				a_m_1(A_5);
				B_3.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.um());
			}
			else
			{
				A_25.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.VH());
				B_3.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.uk());
			}
			i_m_1();
			if (P_1)
			{
				A_3.LanzouPlatform = A_4.Key;
				global::A.Y.A_m_1(A_3);
				global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aaW() + A_4.DisplayName);
			}
			b_m_1(false);
		}

		private static Font A_m_1(float P_0, FontStyle P_1 = FontStyle.Regular)
		{
			return global::B.Q.A_m_1(P_0, P_1);
		}

		private static int A_m_1(Font P_0)
		{
			return Math.Max(TextRenderer.MeasureText(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.MK(), P_0).Height, P_0.Height);
		}

		private Button A_m_1(string P_0, int P_1, bool P_2)
		{
			Font font = A_m_1(10f);
			int height = A_m_1(font) + 14;
			Button button = new Button
			{
				Text = P_0,
				Font = font,
				AutoSize = false,
				MinimumSize = new Size(P_1, height),
				Width = P_1,
				Height = height,
				Padding = new Padding(9, 0, 9, 0),
				Margin = new Padding(0, 0, 10, 8),
				UseVisualStyleBackColor = false
			};
			if (P_2)
			{
				button.Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aaw();
			}
			return button;
		}

		private Label A_m_1(string P_0, string P_1)
		{
			Font font = A_m_1(10f);
			return new Label
			{
				Text = P_0,
				AutoSize = true,
				Anchor = AnchorStyles.Left,
				Tag = P_1,
				Margin = new Padding(2, 8, 8, 8),
				Font = font,
				MinimumSize = new Size(0, A_m_1(font) + 4)
			};
		}

		private Label a_m_1(string P_0, string P_1)
		{
			Label label = A_m_1(P_0, P_1);
			label.Margin = new Padding(2, 4, 8, 8);
			A_34.Add(label);
			return label;
		}

		private Label B_m_1(string P_0, string P_1)
		{
			Font font = A_m_1(10f);
			int height = A_m_1(font) + 6;
			Label label = new Label
			{
				Text = P_0,
				AutoSize = false,
				Dock = DockStyle.Fill,
				AutoEllipsis = true,
				Tag = P_1,
				Font = font,
				MinimumSize = new Size(0, height),
				Height = height,
				TextAlign = ContentAlignment.MiddleLeft,
				Margin = new Padding(2, 3, 8, 3)
			};
			A_m_1(label);
			return label;
		}

		private TextBox A_m_1(bool P_0)
		{
			Font font = A_m_1(10f);
			int num = A_m_1(font);
			TextBox textBox = new TextBox
			{
				Dock = DockStyle.Fill,
				Multiline = P_0,
				Font = font,
				Margin = new Padding(0, 5, 8, 5),
				BorderStyle = BorderStyle.FixedSingle,
				MinimumSize = new Size(0, P_0 ? (num * 4 + 14) : (num + 12))
			};
			if (P_0)
			{
				textBox.ScrollBars = ScrollBars.Vertical;
			}
			A_m_1(textBox);
			return textBox;
		}

		private GroupBox A_m_1(string P_0)
		{
			Font font = A_m_1(10f);
			return new GroupBox
			{
				Text = P_0,
				Dock = DockStyle.Fill,
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				Padding = new Padding(12, A_m_1(font) + 12, 12, 10),
				Margin = new Padding(0, 0, 0, 12),
				Font = font
			};
		}

		private void A_m_1(Control P_0)
		{
			if (P_0 != null)
			{
				P_0.MouseHover += delegate
				{
					A_33.SetToolTip(P_0, P_0.Text);
				};
			}
		}

		[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "SendMessage")]
		private static extern nint A_m_1(nint P_0, int P_1, nint P_2, nint P_3);

		private static void A_m_1(TextBox P_0, int P_1, int P_2)
		{
			if (P_0 != null && P_0.IsHandleCreated)
			{
				int num = Math.Max(0, P_1);
				int num2 = Math.Max(0, P_2);
				A_m_1(P_0.Handle, 211, 3, (num2 << 16) | (num & 0xFFFF));
			}
		}

		private static IEnumerable<Control> a_m_1(Control P_0)
		{
			foreach (Control control in P_0.Controls)
			{
				yield return control;
				foreach (Control item in a_m_1(control))
				{
					yield return item;
				}
			}
		}

		private void B_m_1()
		{
			if (IsDisposed)
			{
				return;
			}
			SuspendLayout();
			try
			{
				Font font = A_m_1(10f);
				int num = A_m_1(font);
				int height = num + 14;
				foreach (Control item in a_m_1(this))
				{
					if (item is Button button)
					{
						int val = TextRenderer.MeasureText(button.Text, button.Font).Width + button.Padding.Horizontal + 20;
						button.Height = height;
						button.Width = Math.Max(Math.Max(button.MinimumSize.Width, 64), val);
					}
					else if (item is TextBox textBox)
					{
						int height2 = (textBox.Multiline ? (num * 4 + 14) : (num + 12));
						textBox.MinimumSize = new Size(textBox.MinimumSize.Width, height2);
						if (!textBox.Multiline)
						{
							textBox.Height = height2;
						}
						A_m_1(textBox, 8, 8);
					}
					else if (item is ComboBox comboBox)
					{
						int num2 = 0;
						foreach (object item2 in comboBox.Items)
						{
							num2 = Math.Max(num2, TextRenderer.MeasureText((item2 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).ToString(), comboBox.Font).Width + 48);
						}
						comboBox.Width = Math.Max(comboBox.MinimumSize.Width, num2);
					}
					else if (item is FlowLayoutPanel { WrapContents: not false } flowLayoutPanel)
					{
						int width = ((flowLayoutPanel.Parent == null) ? 600 : Math.Max(240, flowLayoutPanel.Parent.ClientSize.Width - flowLayoutPanel.Margin.Horizontal - 10));
						flowLayoutPanel.MaximumSize = new Size(width, 0);
					}
					else if (item is Label label)
					{
						if (A_34.Contains(label))
						{
							int width2 = ((label.Parent == null) ? 320 : Math.Max(200, label.Parent.ClientSize.Width - label.Margin.Horizontal - 6));
							label.MaximumSize = new Size(width2, 0);
						}
						else if (!label.AutoSize)
						{
							label.MinimumSize = new Size(label.MinimumSize.Width, num + 6);
							label.Height = num + 6;
						}
					}
				}
				if (A_29 != null)
				{
					A_29.Height = Math.Max(12, num / 2 + 4);
				}
				if (C_3 != null)
				{
					C_3.Width = Math.Max(180, TextRenderer.MeasureText(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aaX(), font).Width + 60);
				}
				if (A_26 != null)
				{
					int num3 = 0;
					if (C_1 != null)
					{
						num3 += C_1.Width + C_1.Margin.Horizontal;
					}
					if (H_1 != null)
					{
						num3 += H_1.Width + H_1.Margin.Horizontal;
					}
					if (h_1 != null)
					{
						num3 += h_1.Width + h_1.Margin.Horizontal;
					}
					if (c_1 != null)
					{
						num3 += c_1.Width + c_1.Margin.Horizontal;
					}
					if (D_1 != null)
					{
						num3 += D_1.Width + D_1.Margin.Horizontal;
					}
					int num4 = ((D_2 != null) ? (D_2.Width + D_2.Margin.Horizontal) : 0);
					A_26.Width = Math.Max(200, ClientSize.Width - num3 - num4 - 80);
				}
				if (A_31 != null)
				{
					A_31.RowStyles[0].Height = Math.Max(130, num * 5);
				}
				if (a_8 != null)
				{
					a_8.RowStyles[4].Height = C_m_1();
					a_8.RowStyles[8].Height = b_m_1();
				}
			}
			finally
			{
				ResumeLayout(performLayout: true);
			}
			c_m_1();
		}

		private int b_m_1()
		{
			return Math.Max(360, A_m_1(A_m_1(10f)) * 18);
		}

		private int C_m_1()
		{
			int val = ((A_32 != null) ? A_32.PreferredSize.Height : 0);
			int val2 = ((a_7 != null) ? a_7.Padding.Vertical : 0);
			return b_m_1() + Math.Max(0, val) + Math.Max(0, val2) + 8;
		}

		private void c_m_1()
		{
			if (C_4 || A_35 == null || a_8 == null || IsDisposed)
			{
				return;
			}
			C_4 = true;
			try
			{
				int num = 0;
				for (int num2 = 0; num2 < a_8.RowCount; num2++)
				{
					if (a_8.RowStyles[num2].SizeType == SizeType.Absolute)
					{
						num += (int)a_8.RowStyles[num2].Height;
					}
					else if (num2 != 4 && num2 != 8)
					{
						num += a_8.GetRowHeights()[num2];
					}
				}
				int num3 = A_35.ClientSize.Height - (num + a_8.Padding.Vertical) - 2;
				if (num3 > 4)
				{
					int num4 = C_m_1();
					int num5 = b_m_1();
					int num6 = (int)((double)num3 * 0.55);
					a_8.RowStyles[4].Height = num4 + num6;
					a_8.RowStyles[8].Height = num5 + (num3 - num6);
					a_8.PerformLayout();
				}
			}
			finally
			{
				C_4 = false;
			}
		}

		private static TableLayoutPanel A_m_1(int P_0, params float[] heights)
		{
			TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
			{
				Dock = DockStyle.Fill,
				ColumnCount = P_0,
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				Margin = new Padding(0)
			};
			for (int num = 0; num < P_0; num++)
			{
				tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / (float)P_0));
			}
			tableLayoutPanel.ColumnStyles[0] = new ColumnStyle(SizeType.AutoSize);
			int num2 = (tableLayoutPanel.RowCount = ((heights == null || heights.Length == 0) ? 1 : heights.Length));
			if (num2 > 1)
			{
				foreach (float height in heights)
				{
					tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, height));
				}
			}
			else
			{
				tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			}
			return tableLayoutPanel;
		}

		private void D_m_1()
		{
			SuspendLayout();
			Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ty();
			Icon = global::A.R.App;
			StartPosition = FormStartPosition.CenterParent;
			Font = A_m_1(10f);
			AutoScaleMode = AutoScaleMode.Font;
			float num = ((global::B.Q.A_1 > 0f) ? global::B.Q.A_1 : 1f);
			ClientSize = new Size((int)(1040f * num), (int)(1010f * num));
			MinimumSize = new Size((int)(920f * num), (int)(760f * num));
			DoubleBuffered = true;
			Panel panel = (A_35 = new Panel
			{
				Dock = DockStyle.Fill,
				AutoScroll = true,
				Margin = new Padding(0),
				Padding = new Padding(0),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jp()
			});
			TableLayoutPanel tableLayoutPanel = (a_8 = new TableLayoutPanel
			{
				Dock = DockStyle.Top,
				ColumnCount = 1,
				RowCount = 9,
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				Padding = new Padding(14, 12, 14, 10),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jp()
			});
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			for (int num2 = 0; num2 < 9; num2++)
			{
				tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			}
			tableLayoutPanel.RowStyles[4] = new RowStyle(SizeType.Absolute, b_m_1());
			tableLayoutPanel.RowStyles[8] = new RowStyle(SizeType.Absolute, b_m_1());
			panel.Controls.Add(tableLayoutPanel);
			Controls.Add(panel);
			panel.Resize += delegate
			{
				c_m_1();
			};
			Label control = a_m_1(global::a.Q.A_m_1((A_4.Id == global::A.v.a) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ur() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.us()), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BH());
			tableLayoutPanel.Controls.Add(control, 0, 0);
			TableLayoutPanel tableLayoutPanel2 = new TableLayoutPanel
			{
				Dock = DockStyle.Fill,
				ColumnCount = 3,
				RowCount = 2,
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				Margin = new Padding(0)
			};
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			for (int num3 = 0; num3 < 2; num3++)
			{
				tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			}
			Label control2 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ub(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
			tableLayoutPanel2.Controls.Add(control2, 0, 0);
			A_21 = new ComboBox
			{
				DropDownStyle = ComboBoxStyle.DropDownList,
				Width = 248,
				MinimumSize = new Size(248, 0),
				Font = A_m_1(10f),
				Margin = new Padding(0, 5, 10, 5)
			};
			global::A.W[] array = global::A.w.A_1;
			foreach (global::A.W w2 in array)
			{
				A_21.Items.Add(w2.DisplayName);
			}
			tableLayoutPanel2.Controls.Add(A_21, 1, 0);
			C_2 = a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BH());
			tableLayoutPanel2.Controls.Add(C_2, 0, 1);
			tableLayoutPanel2.SetColumnSpan(C_2, 3);
			tableLayoutPanel.Controls.Add(tableLayoutPanel2, 0, 1);
			TableLayoutPanel tableLayoutPanel3 = A_m_1(4, Array.Empty<float>());
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			Label control3 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.uU(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
			tableLayoutPanel3.Controls.Add(control3, 0, 0);
			A_20 = A_m_1(false);
			A_20.Margin = new Padding(0, 4, 8, 4);
			tableLayoutPanel3.Controls.Add(A_20, 1, 0);
			tableLayoutPanel3.SetColumnSpan(A_20, 2);
			A_22 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.NN(), 88, false);
			A_22.Margin = new Padding(0, 4, 0, 4);
			A_22.Click += delegate
			{
				E_m_1();
			};
			tableLayoutPanel3.Controls.Add(A_22, 3, 0);
			tableLayoutPanel.Controls.Add(tableLayoutPanel3, 0, 2);
			A_27 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.uV());
			TableLayoutPanel tableLayoutPanel4 = new TableLayoutPanel
			{
				Dock = DockStyle.Fill,
				ColumnCount = 4,
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				Margin = new Padding(0)
			};
			for (int num5 = 0; num5 < 4; num5++)
			{
				tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));
			}
			tableLayoutPanel4.ColumnStyles[0] = new ColumnStyle(SizeType.AutoSize);
			tableLayoutPanel4.ColumnStyles[1] = new ColumnStyle(SizeType.Percent, 100f);
			for (int num6 = 0; num6 < 4; num6++)
			{
				tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			}
			Label control4 = (c_2 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.uW(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()));
			tableLayoutPanel4.Controls.Add(control4, 0, 0);
			a_1 = A_m_1(true);
			a_1.Margin = new Padding(0, 5, 8, 5);
			tableLayoutPanel4.Controls.Add(a_1, 1, 0);
			tableLayoutPanel4.SetColumnSpan(a_1, 3);
			FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel
			{
				FlowDirection = FlowDirection.LeftToRight,
				WrapContents = true,
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				Margin = new Padding(0, 2, 0, 2)
			};
			g_1 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Uc(), 84, true);
			g_1.Click += delegate
			{
				F_m_1();
			};
			a_2 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.uZ(), 104, false);
			a_2.Click += delegate
			{
				A_m_1(() => f_m_1());
			};
			b_2 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bx(), 92, false);
			b_2.Click += delegate
			{
				A_m_1(G_m_1);
			};
			B_2 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.VG(), 104, false);
			B_2.Click += delegate
			{
				H_m_1();
			};
			flowLayoutPanel.Controls.Add(g_1);
			flowLayoutPanel.Controls.Add(a_2);
			flowLayoutPanel.Controls.Add(b_2);
			flowLayoutPanel.Controls.Add(B_2);
			tableLayoutPanel4.Controls.Add(flowLayoutPanel, 0, 1);
			tableLayoutPanel4.SetColumnSpan(flowLayoutPanel, 4);
			A_25 = B_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.VH(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Fh());
			A_25.Margin = new Padding(2, 2, 8, 2);
			tableLayoutPanel4.Controls.Add(A_25, 0, 2);
			tableLayoutPanel4.SetColumnSpan(A_25, 4);
			Label control5 = a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aax(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BH());
			tableLayoutPanel4.Controls.Add(control5, 0, 3);
			tableLayoutPanel4.SetColumnSpan(control5, 4);
			A_27.Controls.Add(tableLayoutPanel4);
			tableLayoutPanel.Controls.Add(A_27, 0, 3);
			GroupBox groupBox = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.vS());
			groupBox.AutoSize = false;
			a_7 = groupBox;
			TableLayoutPanel tableLayoutPanel5 = new TableLayoutPanel
			{
				Dock = DockStyle.Fill,
				ColumnCount = 1,
				RowCount = 2,
				Margin = new Padding(0),
				Padding = new Padding(0)
			};
			tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 140f));
			tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			A_31 = tableLayoutPanel5;
			A_28 = new ListView
			{
				Dock = DockStyle.Fill,
				View = View.Details,
				FullRowSelect = true,
				HideSelection = false,
				MultiSelect = false,
				HeaderStyle = ColumnHeaderStyle.Nonclickable,
				Margin = new Padding(0, 2, 0, 6)
			};
			A_28.Columns.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Vt(), 620);
			A_28.Columns.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.VU(), 110, HorizontalAlignment.Right);
			A_28.Columns.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aaY(), 140, HorizontalAlignment.Right);
			A_28.DoubleClick += delegate
			{
				j_m_1();
			};
			A_28.KeyDown += (object P_0, KeyEventArgs P_1) =>
			{
				A_m_1(P_0, P_1);
			};
			tableLayoutPanel5.Controls.Add(A_28, 0, 0);
			Panel panel2 = new Panel
			{
				Dock = DockStyle.Fill,
				Margin = new Padding(0)
			};
			a_4 = new ListView
			{
				Dock = DockStyle.Fill,
				View = View.Details,
				FullRowSelect = true,
				HideSelection = false,
				MultiSelect = false,
				HeaderStyle = ColumnHeaderStyle.Clickable,
				Margin = new Padding(0)
			};
			a_4.Columns.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Td(), 500);
			a_4.Columns.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Kd(), 100, HorizontalAlignment.Right);
			a_4.Columns.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.KE(), 160, HorizontalAlignment.Right);
			a_4.Columns.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aaY(), 130, HorizontalAlignment.Right);
			a_4.ColumnClick += (object P_0, ColumnClickEventArgs P_1) =>
			{
				a_m_1(P_1.Column);
			};
			panel2.Controls.Add(a_4);
			d_2 = B_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Fh());
			d_2.Dock = DockStyle.Bottom;
			d_2.Margin = new Padding(2, 2, 8, 0);
			A_m_1(d_2);
			panel2.Controls.Add(d_2);
			FlowLayoutPanel flowLayoutPanel2 = new FlowLayoutPanel
			{
				Dock = DockStyle.Top,
				FlowDirection = FlowDirection.LeftToRight,
				WrapContents = false,
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				Margin = new Padding(0),
				Padding = new Padding(0)
			};
			Label label = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Vp(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
			label.Margin = new Padding(2, 5, 6, 4);
			C_3 = A_m_1(false);
			C_3.Dock = DockStyle.None;
			C_3.Width = 220;
			C_3.Margin = new Padding(0, 3, 6, 3);
			C_3.TextChanged += delegate
			{
				a_6 = 0;
				A_m_1(A_11);
			};
			flowLayoutPanel2.Controls.Add(label);
			flowLayoutPanel2.Controls.Add(C_3);
			panel2.Controls.Add(flowLayoutPanel2);
			tableLayoutPanel5.Controls.Add(panel2, 0, 1);
			groupBox.Controls.Add(tableLayoutPanel5);
			FlowLayoutPanel flowLayoutPanel3 = new FlowLayoutPanel
			{
				Dock = DockStyle.Top,
				FlowDirection = FlowDirection.LeftToRight,
				WrapContents = true,
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				Margin = new Padding(0),
				Padding = new Padding(0)
			};
			D_2 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.VW(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
			D_2.Margin = new Padding(2, 6, 6, 6);
			flowLayoutPanel3.Controls.Add(D_2);
			A_26 = new global::A.s(A_2)
			{
				Width = Math.Max(220, ClientSize.Width - 600),
				Height = A_m_1(A_m_1(10f)) + 8,
				Anchor = AnchorStyles.Left,
				Margin = new Padding(2, 5, 8, 5),
				TabStop = false
			};
			A_26.CrumbClicked += (int P_0) =>
			{
				A_m_1(P_0);
			};
			A_m_1(A_26);
			flowLayoutPanel3.Controls.Add(A_26);
			C_1 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.VV(), 104, false);
			C_1.Click += delegate
			{
				A_m_1(() => a_m_1(true));
			};
			H_1 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Vl(), 84, false);
			H_1.Enabled = false;
			H_1.Click += delegate
			{
				N();
			};
			h_1 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Vm(), 84, false);
			h_1.Enabled = false;
			h_1.Click += delegate
			{
				n();
			};
			c_1 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Vs(), 84, false);
			c_1.Enabled = false;
			c_1.Click += delegate
			{
				K_m_1();
			};
			D_1 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jg(), 116, false);
			D_1.Enabled = false;
			D_1.Click += delegate
			{
				A_m_1(() => M());
			};
			flowLayoutPanel3.Controls.Add(C_1);
			flowLayoutPanel3.Controls.Add(H_1);
			flowLayoutPanel3.Controls.Add(h_1);
			flowLayoutPanel3.Controls.Add(c_1);
			flowLayoutPanel3.Controls.Add(D_1);
			groupBox.Controls.Add(flowLayoutPanel3);
			A_32 = flowLayoutPanel3;
			tableLayoutPanel.RowStyles[4].Height = C_m_1();
			tableLayoutPanel.Controls.Add(groupBox, 0, 4);
			GroupBox groupBox2 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.vT());
			TableLayoutPanel tableLayoutPanel6 = new TableLayoutPanel
			{
				Dock = DockStyle.Fill,
				ColumnCount = 4,
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				Margin = new Padding(0)
			};
			tableLayoutPanel6.ColumnStyles.Clear();
			tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40f));
			tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60f));
			tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			Label control6 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.vU(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
			tableLayoutPanel6.Controls.Add(control6, 0, 0);
			B_1 = A_m_1(false);
			B_1.Margin = new Padding(0, 4, 8, 4);
			B_1.TextChanged += delegate
			{
				i_m_1();
			};
			tableLayoutPanel6.Controls.Add(B_1, 1, 0);
			Label control7 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.vV(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
			tableLayoutPanel6.Controls.Add(control7, 2, 0);
			f_1 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aay(), 78, false);
			f_1.Margin = new Padding(0, 5, 0, 5);
			f_1.Click += delegate
			{
				e_m_1();
			};
			tableLayoutPanel6.Controls.Add(f_1, 3, 0);
			b_1 = A_m_1(false);
			b_1.Margin = new Padding(0, 4, 8, 4);
			b_1.TextChanged += delegate
			{
				i_m_1();
			};
			tableLayoutPanel6.Controls.Add(b_1, 0, 1);
			tableLayoutPanel6.SetColumnSpan(b_1, 3);
			FlowLayoutPanel flowLayoutPanel4 = new FlowLayoutPanel
			{
				AutoSize = true,
				Margin = new Padding(0),
				FlowDirection = FlowDirection.LeftToRight
			};
			F_1 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.vW(), 150, false);
			F_1.Click += delegate
			{
				J_m_1();
			};
			flowLayoutPanel4.Controls.Add(F_1);
			tableLayoutPanel6.Controls.Add(flowLayoutPanel4, 3, 1);
			a_3 = a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BH());
			tableLayoutPanel6.Controls.Add(a_3, 0, 2);
			tableLayoutPanel6.SetColumnSpan(a_3, 4);
			groupBox2.Controls.Add(tableLayoutPanel6);
			tableLayoutPanel.Controls.Add(groupBox2, 0, 5);
			FlowLayoutPanel flowLayoutPanel5 = new FlowLayoutPanel
			{
				Dock = DockStyle.Top,
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				WrapContents = true,
				Margin = new Padding(0, 2, 0, 0),
				Padding = new Padding(0)
			};
			d_1 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.vX(), 104, false);
			d_1.Click += delegate
			{
				A_m_1(() => B_m_1(true));
			};
			E_1 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.vY(), 112, true);
			E_1.Click += delegate
			{
				A_m_1(() => Q());
			};
			e_1 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jY(), 84, false);
			e_1.Enabled = false;
			e_1.Click += delegate
			{
				R();
			};
			G_1 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bl(), 84, false);
			G_1.Click += delegate
			{
				Close();
			};
			Label value = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.wr(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Fh());
			int num7 = A_3.LanzouUploadWorkers;
			if (num7 < 1)
			{
				num7 = 1;
			}
			if (num7 > 5)
			{
				num7 = 5;
			}
			A_23 = new NumericUpDown
			{
				Minimum = 1m,
				Maximum = 5m,
				Value = num7,
				Width = 56,
				Font = A_m_1(10f),
				TextAlign = HorizontalAlignment.Center,
				Margin = new Padding(0, 6, 12, 8)
			};
			A_23.ValueChanged += delegate
			{
				A_3.LanzouUploadWorkers = (int)A_23.Value;
				global::A.Y.A_m_1(A_3);
			};
			A_24 = new CheckBox
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ws(),
				AutoSize = true,
				Font = A_m_1(10f),
				Padding = new Padding(0, 0, 3, 0),
				Margin = new Padding(0, 7, 10, 8),
				Checked = A_3.LanzouForceReupload
			};
			A_24.CheckedChanged += delegate
			{
				A_3.LanzouForceReupload = A_24.Checked;
				global::A.Y.A_m_1(A_3);
			};
			flowLayoutPanel5.Controls.Add(d_1);
			flowLayoutPanel5.Controls.Add(E_1);
			flowLayoutPanel5.Controls.Add(e_1);
			flowLayoutPanel5.Controls.Add(value);
			flowLayoutPanel5.Controls.Add(A_23);
			flowLayoutPanel5.Controls.Add(A_24);
			flowLayoutPanel5.Controls.Add(G_1);
			tableLayoutPanel.Controls.Add(flowLayoutPanel5, 0, 6);
			TableLayoutPanel tableLayoutPanel7 = new TableLayoutPanel
			{
				Dock = DockStyle.Fill,
				ColumnCount = 1,
				RowCount = 3,
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				Margin = new Padding(0)
			};
			tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			b_3 = B_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Fh());
			b_3.Margin = new Padding(2, 0, 8, 0);
			tableLayoutPanel7.Controls.Add(b_3, 0, 0);
			A_29 = new ProgressBar
			{
				Dock = DockStyle.Fill,
				Height = 14,
				Maximum = 1000,
				Margin = new Padding(0, 2, 0, 2)
			};
			A_29.Maximum = 1000;
			tableLayoutPanel7.Controls.Add(A_29, 0, 1);
			B_3 = B_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mK(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Fh());
			B_3.Margin = new Padding(2, 1, 8, 0);
			tableLayoutPanel7.Controls.Add(B_3, 0, 2);
			tableLayoutPanel.Controls.Add(tableLayoutPanel7, 0, 7);
			GroupBox groupBox3 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.vZ());
			groupBox3.AutoSize = false;
			B_4 = new ListView
			{
				Dock = DockStyle.Fill,
				View = View.Details,
				FullRowSelect = true,
				HideSelection = false,
				MultiSelect = false,
				HeaderStyle = ColumnHeaderStyle.Nonclickable,
				Margin = new Padding(0)
			};
			B_4.Columns.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.WA(), 280);
			B_4.Columns.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Kd(), 90, HorizontalAlignment.Right);
			B_4.Columns.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.WB(), 150);
			B_4.Columns.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.WC(), 300);
			B_4.Columns.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.WD(), 120);
			groupBox3.Controls.Add(B_4);
			tableLayoutPanel.Controls.Add(groupBox3, 0, 8);
			ResumeLayout(performLayout: true);
			B_m_1();
			Shown += delegate
			{
				B_m_1();
				PerformLayout();
			};
			DpiChanged += delegate
			{
				B_m_1();
			};
		}

		private void d_m_1()
		{
			if (A_28 != null && A_28.Columns.Count >= 3)
			{
				A_28.Columns[0].Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Vt());
				A_28.Columns[1].Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.VU());
				A_28.Columns[2].Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aaY();
			}
			if (a_4 != null && a_4.Columns.Count >= 4)
			{
				a_4.Columns[0].Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Td());
				a_4.Columns[1].Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Kd());
				a_4.Columns[2].Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.KE());
				a_4.Columns[3].Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aaY();
			}
			if (B_4 != null && B_4.Columns.Count >= 5)
			{
				B_4.Columns[0].Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.WA());
				B_4.Columns[1].Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Kd());
				B_4.Columns[2].Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.WB());
				B_4.Columns[3].Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.WC());
				B_4.Columns[4].Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.WD());
			}
		}

		private void E_m_1()
		{
			using FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			folderBrowserDialog.Description = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.WE());
			if (Directory.Exists(A_20.Text))
			{
				folderBrowserDialog.SelectedPath = A_20.Text;
			}
			if (folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
			{
				A_20.Text = folderBrowserDialog.SelectedPath;
				i_m_1();
			}
		}

		private void e_m_1()
		{
			using FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			folderBrowserDialog.Description = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.WF());
			if (Directory.Exists(b_1.Text))
			{
				folderBrowserDialog.SelectedPath = b_1.Text;
			}
			else if (Directory.Exists(A_20.Text))
			{
				folderBrowserDialog.SelectedPath = Path.GetDirectoryName(Path.GetFullPath(A_20.Text));
			}
			if (folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
			{
				b_1.Text = folderBrowserDialog.SelectedPath;
			}
		}

		private void F_m_1()
		{
			if (A_15 || !global::b.G.A_m_1(this, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aaZ(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aaz()))
			{
				return;
			}
			using global::B.b b2 = new global::B.b(A_4, A_2);
			if (b2.ShowDialog(this) == DialogResult.OK && b2.Result != null)
			{
				global::B.A A_1 = b2.Result;
				A_m_1(() => A_m_1(A_1));
			}
		}

		private async Task A_m_1(global::B.A P_0)
		{
			if (P_0 == null || !P_0.A_m_1(A_4))
			{
				return;
			}
			A_5 = P_0;
			RemoteClient.A(P_0);
			b_m_1(true);
			B_3.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.vC());
			try
			{
				global::a.s s2 = await RemoteClient.B(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iZ(), CancellationToken.None);
				if (!IsDisposed)
				{
					B_5 = true;
					if (!global::B.a.A_m_1(A_4, P_0))
					{
						MessageBox.Show(this, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.un()), global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bB()), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
					a_m_1(P_0);
					A_m_1(s2);
					B_3.Text = (s2.IsEmpty ? global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.vE()) : global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.vF(), s2.FolderCount, s2.FileCount));
					if (A_4.Experimental)
					{
						b_3.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.vR());
					}
					global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNc() + A_4.DisplayName + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Q() + P_0.a_m_1(A_4) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ln());
				}
			}
			catch (global::a.v v2)
			{
				RemoteClient.A();
				A_5 = null;
				B_5 = false;
				a_m_1((global::B.A)null);
				A_m_1(v2, true);
			}
			finally
			{
				b_m_1(false);
			}
		}

		private async Task f_m_1()
		{
			if (!global::b.G.A_m_1(this, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNg(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNH()))
			{
				return;
			}
			if (A_4.Id == global::A.v.a)
			{
				List<KeyValuePair<string, string>> list = global::A.X.A(a_1.Text);
				bool flag = false;
				foreach (KeyValuePair<string, string> item in list)
				{
					if (string.Equals(item.Key, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iu(), StringComparison.OrdinalIgnoreCase))
					{
						flag = true;
					}
				}
				bool flag2 = list.Count == 0 && !string.IsNullOrWhiteSpace(a_1.Text);
				if (!flag && !flag2)
				{
					MessageBox.Show(this, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Uu()), global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.WH()), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
			}
			global::B.A a2 = global::a.z.A(A_4, a_1.Text);
			if (a2 == null)
			{
				MessageBox.Show(this, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.uo(), A_4.RequiredCookieHint), global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.WH()), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			A_5 = a2;
			RemoteClient.A(a2);
			b_m_1(true);
			B_3.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.vD());
			try
			{
				global::a.s s2 = await RemoteClient.B(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iZ(), CancellationToken.None);
				if (!IsDisposed)
				{
					B_5 = true;
					if (!global::B.a.A_m_1(A_4, a2))
					{
						MessageBox.Show(this, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.VE()), global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bB()), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
					a_m_1(a2);
					a_1.Clear();
					A_m_1(s2);
					B_3.Text = (s2.IsEmpty ? global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.vG()) : global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.vH(), s2.FolderCount, s2.FileCount));
					if (A_4.Experimental)
					{
						b_3.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.vR());
					}
					global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNh() + a2.a_m_1(A_4) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ln());
				}
			}
			catch (global::a.v v2)
			{
				RemoteClient.A();
				A_5 = null;
				B_5 = false;
				a_m_1((global::B.A)null);
				A_m_1(v2, true);
			}
			finally
			{
				b_m_1(false);
			}
		}

		private async Task G_m_1()
		{
			if (!HasCookie)
			{
				MessageBox.Show(this, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ui()), global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bB()), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			b_m_1(true);
			B_3.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.VA());
			try
			{
				global::a.s s2 = await RemoteClient.B(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iZ(), CancellationToken.None);
				if (!IsDisposed)
				{
					B_5 = true;
					B_3.Text = (s2.IsEmpty ? global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.vI()) : global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.vJ(), s2.FolderCount, s2.FileCount));
					MessageBox.Show(this, B_3.Text, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bx()), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
			}
			catch (global::a.v v2)
			{
				B_5 = false;
				A_m_1(v2);
			}
			finally
			{
				b_m_1(false);
			}
		}

		private bool g_m_1()
		{
			if (!HasCookie)
			{
				MessageBox.Show(this, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ui()), global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bB()), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return false;
			}
			if (!B_5)
			{
				MessageBox.Show(this, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBA()), global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.XA()), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			return true;
		}

		private void H_m_1()
		{
			if (MessageBox.Show(this, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.up(), A_4.DisplayName), global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.VG()), MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				global::B.a.b(A_4);
				RemoteClient.A();
				A_5 = null;
				B_5 = false;
				a_m_1((global::B.A)null);
				A_28.Items.Clear();
				A_13.Clear();
				B_4.Items.Clear();
				A_11 = null;
				A_12 = global::a.t.A_m_1();
				b_3.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
				B_3.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.uj());
				b_m_1(false);
			}
		}

		private void a_m_1(global::B.A P_0)
		{
			if (P_0 == null || !P_0.A_m_1(A_4))
			{
				A_25.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.VH());
			}
			else
			{
				A_25.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.WK()) + P_0.a_m_1(A_4);
			}
		}

		private static global::B.C h_m_1()
		{
			return new global::B.C
			{
				A = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iZ(),
				a = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Dw())
			};
		}

		private void A_m_1(global::a.s P_0)
		{
			A_9.Clear();
			A_9.Add(h_m_1());
			A_10 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iZ();
			a_6 = 0;
			A_12 = global::a.t.A_m_1(P_0);
			A_m_1(P_0.Folders);
			A_11 = P_0.Files;
			A_m_1(A_11);
			I_m_1();
		}

		private void A_m_1(List<global::a.W> P_0)
		{
			A_28.Items.Clear();
			List<global::a.W> list = P_0 ?? new List<global::a.W>();
			if (A_12 != null && A_12.Failed)
			{
				a_m_1(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.VY()));
				return;
			}
			if (list.Count == 0)
			{
				if (A_12 != null && A_12.State != global::a.T.A)
				{
					a_m_1(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.VX()));
				}
				return;
			}
			foreach (global::a.W item in list)
			{
				ListViewItem listViewItem = new ListViewItem(item.Name ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
				listViewItem.SubItems.Add((item.ItemCount >= 0) ? item.ItemCount.ToString() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bE());
				listViewItem.SubItems.Add(item.Id ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
				listViewItem.Tag = item;
				A_28.Items.Add(listViewItem);
			}
		}

		private void a_m_1(string P_0)
		{
			ListViewItem listViewItem = new ListViewItem(P_0);
			listViewItem.SubItems.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
			listViewItem.SubItems.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
			listViewItem.ForeColor = SystemColors.GrayText;
			A_28.Items.Add(listViewItem);
		}

		private static string B_m_1(string P_0)
		{
			if (!string.IsNullOrWhiteSpace(P_0))
			{
				return P_0.Trim();
			}
			return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bE();
		}

		private void I_m_1()
		{
			if (A_26 != null)
			{
				A_26.A_m_1(A_9);
				A_26.Enabled = !A_15;
				c_1.Enabled = !A_15 && A_9.Count > 1;
				if (D_1 != null)
				{
					bool supportsCreateFolder = RemoteClient.SupportsCreateFolder;
					D_1.Enabled = (!A_15 && HasCookie) & supportsCreateFolder;
					A_33.SetToolTip(D_1, supportsCreateFolder ? global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Xi()) : global::a.Q.A_m_1(RemoteClient.CreateFolderUnsupportedReason));
				}
			}
		}

		private void i_m_1()
		{
			if (a_3 == null)
			{
				return;
			}
			string text = A_20.Text;
			if (string.IsNullOrWhiteSpace(text) || !Directory.Exists(text))
			{
				a_3.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.WM());
				return;
			}
			string text2 = global::a.Z.A_m_1(text, b_1.Text, B_1.Text);
			a_3.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.WL()) + text2;
			if (F_1 != null)
			{
				F_1.Enabled = Directory.Exists(text2);
			}
		}

		private void J_m_1()
		{
			string text = A_20.Text;
			if (string.IsNullOrWhiteSpace(text) || !Directory.Exists(text))
			{
				return;
			}
			string text2 = global::a.Z.A_m_1(text, b_1.Text, B_1.Text);
			try
			{
				if (!Directory.Exists(text2))
				{
					Directory.CreateDirectory(text2);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(this, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.WN()) + ex.Message, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bB()), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			Action<string> action = A_1;
			if (action != null)
			{
				action(text2);
				return;
			}
			try
			{
				Process.Start(new ProcessStartInfo
				{
					FileName = text2,
					UseShellExecute = true
				});
			}
			catch (Exception ex2)
			{
				MessageBox.Show(this, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.WO()) + ex2.Message, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bB()), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private async Task a_m_1(bool P_0)
		{
			if (!HasCookie)
			{
				if (P_0)
				{
					MessageBox.Show(this, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ui()), global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bB()), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				return;
			}
			b_m_1(true);
			try
			{
				global::a.s s2 = await RemoteClient.B(A_10, CancellationToken.None);
				if (!IsDisposed)
				{
					B_5 = true;
					A_12 = global::a.t.A_m_1(s2);
					A_11 = s2.Files;
					A_m_1(s2.Folders);
					A_m_1(s2.Files);
					if (s2.IsEmpty)
					{
						B_3.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.vA());
						return;
					}
					B_3.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.vB(), s2.FolderCount, s2.FileCount);
				}
			}
			catch (global::a.v v2)
			{
				A_m_1(v2, false);
			}
			finally
			{
				b_m_1(false);
				I_m_1();
			}
		}

		private void A_m_1(global::a.v P_0, bool P_1)
		{
			A_12 = global::a.t.A_m_1(global::a.u.A(P_0, A_4.Experimental));
			if (P_1 || A_28.Items.Count == 0)
			{
				A_m_1(new List<global::a.W>());
			}
			if (P_1 || A_11 == null || A_11.Count == 0)
			{
				A_11 = new List<global::a.w>();
				A_m_1(A_11);
			}
			A_m_1(P_0);
		}

		private void A_m_1(object P_0, KeyEventArgs P_1)
		{
			if (P_1 != null && P_1.KeyCode == Keys.Return)
			{
				P_1.Handled = true;
				j_m_1();
			}
		}

		private void j_m_1()
		{
			if (A_15 || A_28.SelectedItems.Count == 0)
			{
				return;
			}
			global::a.W w2 = A_28.SelectedItems[0].Tag as global::a.W;
			if (global::B.c.A_m_1(A_9, w2))
			{
				A_10 = w2.Id;
				a_6 = 0;
				I_m_1();
				A_m_1(() => a_m_1(false));
			}
		}

		private void K_m_1()
		{
			if (!A_15 && global::B.c.A_m_1(A_9))
			{
				A_10 = A_9[A_9.Count - 1].A;
				a_6 = 0;
				I_m_1();
				A_m_1(() => a_m_1(false));
			}
		}

		private void A_m_1(int P_0)
		{
			if (!A_15 && global::B.c.A_m_1(A_9, P_0))
			{
				A_10 = A_9[A_9.Count - 1].A;
				a_6 = 0;
				I_m_1();
				A_m_1(() => a_m_1(false));
			}
		}

		private List<global::B.C> k_m_1()
		{
			List<global::B.C> list = global::B.c.A_m_1(A_3.LanzouLastFolderChain);
			if (list.Count <= 1 && !string.IsNullOrWhiteSpace(A_3.LanzouLastFolderId) && !string.Equals(A_3.LanzouLastFolderId, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iZ(), StringComparison.Ordinal))
			{
				list.Add(new global::B.C
				{
					A = A_3.LanzouLastFolderId,
					a = A_3.LanzouLastFolderName
				});
			}
			list[0] = h_m_1();
			return list;
		}

		private async Task L_m_1()
		{
			if (!HasCookie)
			{
				I_m_1();
				return;
			}
			List<global::B.C> list = k_m_1();
			if (list.Count > 1)
			{
				B_3.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Xm());
				b_m_1(true);
				global::B.c.A a2;
				try
				{
					a2 = await global::B.c.A_m_1(list, (string P_0) => RemoteClient.A(P_0, CancellationToken.None));
				}
				catch (global::a.v v2)
				{
					b_m_1(false);
					A_m_1(v2, true);
					return;
				}
				finally
				{
					if (!IsDisposed)
					{
						b_m_1(false);
					}
				}
				if (IsDisposed)
				{
					return;
				}
				A_9.Clear();
				A_9.AddRange(a2.A_f_1);
				A_10 = A_9[A_9.Count - 1].A;
				a_6 = 0;
				I_m_1();
				if (a2.A_f_2)
				{
					MessageBox.Show(this, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Xn()), global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bB()), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
			}
			await a_m_1(false);
		}

		private IEnumerable<string> l()
		{
			foreach (ListViewItem item in A_28.Items)
			{
				if (item.Tag is global::a.W w2)
				{
					yield return w2.Name;
				}
			}
		}

		private async Task M()
		{
			if (A_15)
			{
				return;
			}
			if (!HasCookie)
			{
				MessageBox.Show(this, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ui()), global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bB()), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			global::B.d remoteClient = RemoteClient;
			if (!remoteClient.SupportsCreateFolder)
			{
				MessageBox.Show(this, global::a.Q.A_m_1(remoteClient.CreateFolderUnsupportedReason), global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jg()), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			string a_ = A_10;
			string text = global::B.c.A_m_1((IEnumerable<global::B.C>)A_9);
			string text2;
			using (global::A.z z2 = new global::A.z(A_2, text, l))
			{
				if (z2.ShowDialog(this) != DialogResult.OK)
				{
					return;
				}
				text2 = z2.A_3;
			}
			if (global::B.D.A_m_1(text2, l()) != null)
			{
				return;
			}
			b_m_1(true);
			try
			{
				string text3 = await remoteClient.A(a_, text2, CancellationToken.None);
				if (IsDisposed)
				{
					return;
				}
				if (string.IsNullOrWhiteSpace(text3))
				{
					List<global::a.W> list = await remoteClient.A(a_, CancellationToken.None);
					if (IsDisposed)
					{
						return;
					}
					foreach (global::a.W item in list)
					{
						if (item != null && string.Equals(item.Name, text2, StringComparison.OrdinalIgnoreCase))
						{
							text3 = item.Id;
							break;
						}
					}
				}
				if (string.IsNullOrWhiteSpace(text3))
				{
					B_3.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Xk(), text2);
					global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNf() + text + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Dv() + text2);
					await a_m_1(false);
					return;
				}
				A_9.Add(new global::B.C
				{
					A = text3,
					a = text2
				});
				A_10 = text3;
				a_6 = 0;
				I_m_1();
				B_3.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Xj(), text2);
				global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNG() + text + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Dv() + text2);
			}
			catch (global::a.v v2)
			{
				string text4 = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Xl()) + v2.Message;
				B_3.Text = text4;
				MessageBox.Show(this, text4, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jg()), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBi(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jg(), text + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Dv() + text2, v2.Message, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf());
				return;
			}
			catch (Exception ex)
			{
				string text5 = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Xl()) + ex.Message;
				B_3.Text = text5;
				MessageBox.Show(this, text5, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jg()), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBi(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jg(), text + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Dv() + text2, ex.Message, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf());
				return;
			}
			finally
			{
				if (!IsDisposed)
				{
					b_m_1(false);
				}
			}
			await a_m_1(false);
		}

		private int m()
		{
			List<global::a.w> list = A_11 ?? new List<global::a.w>();
			string A = ((C_3 == null) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D() : C_3.Text.Trim());
			if (A.Length == 0)
			{
				return list.Count;
			}
			return Enumerable.Count(list, (global::a.w P_0) => P_0.Name != null && P_0.Name.IndexOf(A, StringComparison.OrdinalIgnoreCase) >= 0);
		}

		private void A_m_1(List<global::a.w> P_0)
		{
			if (a_4 == null || IsDisposed)
			{
				return;
			}
			List<global::a.w> list = P_0 ?? new List<global::a.w>();
			string A = ((C_3 == null) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D() : C_3.Text.Trim());
			List<global::a.w> list2 = list;
			if (A.Length > 0)
			{
				list2 = list.Where((global::a.w w3) => w3.Name != null && w3.Name.IndexOf(A, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
			}
			if (B_6 == 0)
			{
				list2 = (b_4 ? list2.OrderBy((global::a.w w3) => w3.Name ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(), StringComparer.CurrentCultureIgnoreCase).ToList() : list2.OrderByDescending((global::a.w w3) => w3.Name ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(), StringComparer.CurrentCultureIgnoreCase).ToList());
			}
			else if (B_6 == 1)
			{
				list2 = (b_4 ? list2.OrderBy((global::a.w w3) => w3.SizeBytes).ToList() : list2.OrderByDescending((global::a.w w3) => w3.SizeBytes).ToList());
			}
			else if (B_6 == 2)
			{
				list2 = (b_4 ? list2.OrderBy((global::a.w w3) => w3.Time ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(), StringComparer.OrdinalIgnoreCase).ToList() : list2.OrderByDescending((global::a.w w3) => w3.Time ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(), StringComparer.OrdinalIgnoreCase).ToList());
			}
			else if (B_6 == 3)
			{
				list2 = (b_4 ? list2.OrderBy((global::a.w w3) => w3.Id ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(), StringComparer.OrdinalIgnoreCase).ToList() : list2.OrderByDescending((global::a.w w3) => w3.Id ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(), StringComparer.OrdinalIgnoreCase).ToList());
			}
			int count = list2.Count;
			int num = Math.Max(1, (count + 50 - 1) / 50);
			if (a_6 >= num)
			{
				a_6 = num - 1;
			}
			if (a_6 < 0)
			{
				a_6 = 0;
			}
			bool flag = A_12 != null && A_12.Failed;
			string text;
			if (list.Count != 0)
			{
				text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Vr());
			}
			else
			{
				text = (flag ? global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.VZ(), A_12.Error) : global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Vq()));
			}
			a_4.BeginUpdate();
			try
			{
				a_4.Items.Clear();
				if (count == 0)
				{
					ListViewItem listViewItem = new ListViewItem(text);
					listViewItem.ForeColor = (flag ? Color.IndianRed : Color.Gray);
					a_4.Items.Add(listViewItem);
				}
				else
				{
					int num2 = a_6 * 50;
					int num3 = Math.Min(num2 + 50, count);
					for (int num4 = num2; num4 < num3; num4++)
					{
						global::a.w w2 = list2[num4];
						ListViewItem listViewItem2 = new ListViewItem(w2.Name ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
						listViewItem2.SubItems.Add(A_m_1(w2.SizeBytes));
						listViewItem2.SubItems.Add(B_m_1(w2.Time));
						listViewItem2.SubItems.Add(w2.Id ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
						listViewItem2.Tag = w2;
						a_4.Items.Add(listViewItem2);
					}
				}
			}
			finally
			{
				a_4.EndUpdate();
			}
			H_1.Enabled = !A_15 && a_6 > 0;
			h_1.Enabled = !A_15 && a_6 < num - 1;
			if (list.Count == 0)
			{
				d_2.Text = text;
				return;
			}
			if (count == 0)
			{
				d_2.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Vr());
				return;
			}
			string text2 = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Vn(), a_6 + 1, num, list.Count);
			if (A.Length > 0)
			{
				text2 += global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Vo(), count);
			}
			d_2.Text = text2;
		}

		private void N()
		{
			if (!A_15 && a_6 > 0)
			{
				a_6--;
				A_m_1(A_11);
			}
		}

		private void n()
		{
			if (!A_15)
			{
				int num = Math.Max(1, (m() + 50 - 1) / 50);
				if (a_6 < num - 1)
				{
					a_6++;
					A_m_1(A_11);
				}
			}
		}

		private void a_m_1(int P_0)
		{
			if (!A_15 && P_0 >= 0 && P_0 <= 3)
			{
				if (B_6 == P_0)
				{
					b_4 = !b_4;
				}
				else
				{
					B_6 = P_0;
					b_4 = true;
				}
				A_m_1(A_11);
			}
		}

		private bool O()
		{
			string text = A_20.Text;
			if (string.IsNullOrWhiteSpace(text) || !Directory.Exists(text))
			{
				MessageBox.Show(this, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.WS()), global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bB()), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return false;
			}
			return true;
		}

		private bool o()
		{
			if (!A_3.LanzouDisclaimerAccepted)
			{
				string text = P();
				if (MessageBox.Show(this, text, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.WT()), MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) != DialogResult.OK)
				{
					return false;
				}
				A_3.LanzouDisclaimerAccepted = true;
				A_3.LanzouUploadEnabled = true;
				global::A.Y.A_m_1(A_3);
			}
			if (!A_3.LanzouUploadEnabled)
			{
				if (MessageBox.Show(this, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.WU()), global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.WV()), MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
				{
					return false;
				}
				A_3.LanzouUploadEnabled = true;
				global::A.Y.A_m_1(A_3);
			}
			return true;
		}

		private string P()
		{
			if (global::a.Q.EnMode)
			{
				if (A_4.Id == global::A.v.a)
				{
					return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBa();
				}
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBB();
			}
			if (A_4.Id == global::A.v.a)
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBb();
			}
			return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBC();
		}

		private async Task<bool> B_m_1(bool P_0)
		{
			if (!g_m_1())
			{
				return false;
			}
			if (!O())
			{
				return false;
			}
			string text = A_20.Text;
			string text2 = global::a.Z.A_m_1(text, b_1.Text, B_1.Text);
			List<FileInfo> list = new List<FileInfo>();
			FileInfo[] files = new DirectoryInfo(text).GetFiles();
			foreach (FileInfo fileInfo in files)
			{
				if (!global::a.a.A(fileInfo.FullName, text2, false))
				{
					list.Add(fileInfo);
				}
			}
			b_m_1(true);
			B_3.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.WW());
			A_29.Value = 0;
			CancellationTokenSource cancellationTokenSource = (A_14 = new CancellationTokenSource());
			try
			{
				A_11 = await RemoteClient.a(A_10, cancellationTokenSource.Token);
				if (IsDisposed)
				{
					return false;
				}
				A_m_1(A_11);
				A_13.Clear();
				foreach (FileInfo item in list)
				{
					global::a.w a_f_ = global::a.Z.A_m_1(item.Name, item.Length, A_11);
					A_13.Add(new A
					{
						A_f_1 = item.FullName,
						a = item.Name,
						A_f_2 = item.Length,
						A_f_3 = a_f_,
						A_f_4 = (A_4.Id != global::A.v.a && item.Length > 104857600)
					});
				}
				p();
				int num2 = Enumerable.Count(A_13, (A a2) => a2.A_f_3 != null);
				int num3 = Enumerable.Count(A_13, (A a2) => a2.A_f_3 == null && a2.A_f_4);
				int num4 = A_13.Count - num2 - num3;
				b_3.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.WX(), A_13.Count, num2, num4, num3);
				B_3.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.WY(), A_11.Count);
				return true;
			}
			catch (OperationCanceledException)
			{
				B_3.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.qG());
				return false;
			}
			catch (global::a.v v2)
			{
				A_m_1(v2);
				return false;
			}
			catch (Exception ex2)
			{
				MessageBox.Show(this, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.WZ()) + ex2.Message, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.or()), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBi(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aaE(), A_20.Text, ex2.Message, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf());
				return false;
			}
			finally
			{
				if (A_14 == cancellationTokenSource)
				{
					A_14 = null;
				}
				cancellationTokenSource.Dispose();
				b_m_1(false);
			}
		}

		private void p()
		{
			B_4.Items.Clear();
			foreach (A item in A_13)
			{
				ListViewItem listViewItem = new ListViewItem(item.a);
				listViewItem.SubItems.Add(A_m_1(item.A_f_2));
				if (item.A_f_3 != null)
				{
					listViewItem.SubItems.Add(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.wA()));
					listViewItem.SubItems.Add(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.wB()));
					listViewItem.SubItems.Add(item.A_f_3.Id ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
				}
				else if (item.A_f_4)
				{
					listViewItem.SubItems.Add(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.wC()));
					listViewItem.SubItems.Add(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.wD()));
					listViewItem.SubItems.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
				}
				else
				{
					listViewItem.SubItems.Add(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.wE()));
					listViewItem.SubItems.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
					listViewItem.SubItems.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
				}
				listViewItem.Tag = item;
				B_4.Items.Add(listViewItem);
			}
		}

		private async Task Q()
		{
			if (!O() || !o() || !g_m_1() || !(await B_m_1(false)))
			{
				return;
			}
			q();
			global::a.U u2 = global::a.U.A_m_1(A_10, A_9);
			string A_1 = u2.FolderId;
			string a2 = u2.Path;
			string text = A_20.Text;
			string B = global::a.Z.A_m_1(text, b_1.Text, this.B_1.Text);
			string b2 = this.A_4.Key;
			bool A_2 = A_24 != null && A_24.Checked;
			int B_1 = A_13.Count;
			int num = global::B.g.A_m_1(this.A_3.LanzouUploadWorkers, B_1);
			global::B.h A_3 = global::B.h.A_m_1();
			int a_1 = 0;
			int A_4 = 0;
			A_19 = new w(false, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNi());
			global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNJ() + this.A_4.DisplayName + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNj() + a2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNK() + text + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNk() + B_1 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNL() + num + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNl());
			b_m_1(true);
			CancellationTokenSource cancellationTokenSource = (A_14 = new CancellationTokenSource());
			CancellationToken token = cancellationTokenSource.Token;
			A_29.Value = 0;
			A_16 = true;
			A_17 = 0L;
			b_3.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ww(), 0, B_1);
			B_3.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.wu());
			try
			{
				global::B.G g2 = await global::B.g.A_m_1(A_13, num, (A P_0, CancellationToken P_1) => A_m_1(P_0, A_1, a2, B, b2, A_2, A_3, P_1), (A P_0, global::B.f P_1, Exception P_2) =>
				{
					if (P_2 is global::a.v && ((global::a.v)P_2).Kind == global::a.V.a)
					{
						Interlocked.Exchange(ref A_4, 1);
					}
					int A_5 = 0;
					if (P_1 != global::B.f.D)
					{
						A_5 = Interlocked.Increment(ref a_1);
					}
					try
					{
						Invoke(() =>
						{
							if (!IsDisposed)
							{
								P_0.a_1 = true;
								A_m_1(P_0, P_1, P_2, a2);
								if (A_29 != null && A_5 > 0)
								{
									A_29.Value = Math.Min(A_29.Maximum, A_5 * A_29.Maximum / Math.Max(1, B_1));
								}
								if (b_3 != null && A_16)
								{
									b_3.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ww(), A_5, B_1);
								}
							}
						});
					}
					catch
					{
					}
				}, token);
				A_16 = false;
				b_m_1(a2);
				string text2 = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.wj(), g2.a, g2.B, g2.b + g2.C, g2.D, g2.d, g2.c);
				b_3.Text = text2;
				B_3.Text = ((g2.d > 0) ? global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.wx(), g2.Completed, B_1) : global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jv()));
				if (A_29 != null)
				{
					A_29.Value = Math.Min(A_29.Maximum, g2.Completed * A_29.Maximum / Math.Max(1, B_1));
				}
				global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNM() + text2);
				if (Interlocked.CompareExchange(ref A_4, 0, 0) != 0)
				{
					r();
					string text3 = (this.A_4.Experimental ? global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNN()) : global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNm()));
					MessageBox.Show(this, text3, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNn()), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
			finally
			{
				A_16 = false;
				if (A_19 != null)
				{
					A_19.Dispose();
					A_19 = null;
				}
				if (A_14 == cancellationTokenSource)
				{
					A_14 = null;
				}
				cancellationTokenSource.Dispose();
				if (!IsDisposed && !Disposing)
				{
					b_m_1(false);
				}
			}
		}

		private async Task<global::B.f> A_m_1(A P_0, string P_1, string P_2, string P_3, string P_4, bool P_5, global::B.h P_6, CancellationToken P_7)
		{
			if (P_0.A_f_3 != null)
			{
				string text;
				lock (A_18)
				{
					text = global::a.Z.a(P_0.A_f_1, P_3);
				}
				P_0.B = P_0.A_f_3.Id ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
				P_0.b = P_3;
				global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNO() + P_0.A_f_1 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHr() + text);
				return global::B.f.C;
			}
			if (P_0.A_f_4)
			{
				P_0.b = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.wD());
				global::B.p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNo() + P_0.A_f_1);
				return global::B.f.b;
			}
			FileInfo fileInfo = new FileInfo(P_0.A_f_1);
			if (!fileInfo.Exists)
			{
				throw new global::a.v(global::a.V.C, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNP());
			}
			long length = fileInfo.Length;
			long ticks = fileInfo.LastWriteTimeUtc.Ticks;
			string text2 = global::B.F.c(P_0.A_f_1);
			global::B.H h2 = P_6.A_m_1(P_5, P_4, P_1, P_0.A_f_1, length, ticks, text2);
			if (h2 != null)
			{
				P_0.B = h2.RemoteId ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
				P_0.b = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.wm());
				global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNp() + P_0.A_f_1);
				return global::B.f.B;
			}
			P_7.ThrowIfCancellationRequested();
			global::a.X x2 = await RemoteClient.A(P_0.A_f_1, P_1, P_0.a, P_7, (long num, long num2) =>
			{
				A_m_1(P_0, num, num2);
			}, text2).ConfigureAwait(continueOnCapturedContext: false);
			if (x2 == null)
			{
				throw new global::a.v(global::a.V.C, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNQ());
			}
			if (x2.SkippedTooLarge)
			{
				P_0.b = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.wD());
				return global::B.f.b;
			}
			if (!x2.Success)
			{
				throw new global::a.v(global::a.V.b, x2.Reason ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.wy());
			}
			P_0.B = x2.FileId ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			P_0.b = (x2.Instant ? global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.wn()) : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
			P_6.A_m_1(P_4, P_1, P_0.A_f_1, length, ticks, text2, P_0.B);
			global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNq() + (x2.Instant ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNr() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNR()) + P_0.A_f_1 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHr() + P_2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNS() + P_0.B);
			return x2.Instant ? global::B.f.a : global::B.f.A;
		}

		private void A_m_1(A P_0, long P_1, long P_2)
		{
			if (!A_16)
			{
				return;
			}
			long tickCount = Environment.TickCount64;
			if (tickCount - A_17 < 200 && P_1 < P_2)
			{
				return;
			}
			A_17 = tickCount;
			try
			{
				BeginInvoke(() =>
				{
					if (!IsDisposed && A_16 && B_3 != null)
					{
						B_3.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.wv(), P_0.a, A_m_1(P_1), A_m_1(P_2));
					}
				});
			}
			catch
			{
			}
		}

		private void A_m_1(A P_0, global::B.f P_1, Exception P_2, string P_3)
		{
			ListViewItem listViewItem = A_m_1(P_0);
			string text = P_0.b ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			string text2 = P_0.B ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			string text3 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBc();
			string text4 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.IK();
			string text5;
			string text6;
			switch (P_1)
			{
			case global::B.f.A:
				text5 = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.wi());
				text6 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBD() + P_0.A_f_2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBd() + text2;
				break;
			case global::B.f.a:
				text5 = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.wk());
				text6 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBE() + P_0.A_f_2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBd() + text2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBe();
				break;
			case global::B.f.B:
				text5 = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.wl());
				text3 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBF();
				text4 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBF();
				text6 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBf() + P_0.A_f_2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBd() + text2;
				break;
			case global::B.f.b:
				text5 = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.wh());
				text3 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBF();
				text4 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBF();
				text6 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBG() + P_0.A_f_2;
				break;
			case global::B.f.C:
				text5 = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.wf());
				text3 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBg();
				text6 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBH() + text + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBd() + text2;
				break;
			case global::B.f.c:
				text5 = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf());
				text = ((P_2 == null) ? global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.wy()) : P_2.Message);
				text2 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
				text4 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBh();
				text6 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBI() + text;
				global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBi(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBJ(), P_0.A_f_1, text, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf());
				break;
			default:
				text5 = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.wo());
				text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.wp());
				text2 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
				text4 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBj();
				text6 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBK();
				break;
			}
			if (listViewItem != null && listViewItem.SubItems.Count >= 5)
			{
				listViewItem.SubItems[2].Text = text5;
				listViewItem.SubItems[3].Text = text;
				listViewItem.SubItems[4].Text = text2;
			}
			A_m_1(text3, P_0.A_f_1, P_3, text4, text6);
		}

		private void b_m_1(string P_0)
		{
			if (B_4 == null)
			{
				return;
			}
			foreach (ListViewItem item in B_4.Items)
			{
				if (item.Tag is A { a_1: false } a2)
				{
					a2.a_1 = true;
					if (item.SubItems.Count >= 5)
					{
						item.SubItems[2].Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.wo());
						item.SubItems[3].Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.wq());
						item.SubItems[4].Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
					}
					A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBc(), a2.A_f_1, P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBj(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBk());
				}
			}
		}

		private ListViewItem A_m_1(A P_0)
		{
			if (B_4 == null)
			{
				return null;
			}
			foreach (ListViewItem item in B_4.Items)
			{
				if (item.Tag == P_0)
				{
					return item;
				}
			}
			return null;
		}

		private void A_m_1(string P_0, string P_1, string P_2, string P_3, string P_4)
		{
			if (A_19 != null)
			{
				A_19.A_m_1(P_0, P_1, P_2, P_3, P_4);
			}
		}

		private void q()
		{
			A_3.LanzouLastLocalDir = A_20.Text;
			if (A_9.Count > 0)
			{
				A_3.LanzouLastFolderId = A_9[A_9.Count - 1].A;
				A_3.LanzouLastFolderName = A_9[A_9.Count - 1].a;
				A_3.LanzouLastFolderChain = global::B.c.a_m_1(A_9);
			}
			A_3.NetworkDuplicateFolderName = (string.IsNullOrWhiteSpace(B_1.Text) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iy() : B_1.Text.Trim());
			A_3.NetworkDuplicateFolderPath = b_1.Text.Trim();
			if (A_23 != null)
			{
				A_3.LanzouUploadWorkers = (int)A_23.Value;
			}
			if (A_24 != null)
			{
				A_3.LanzouForceReupload = A_24.Checked;
			}
			global::A.Y.A_m_1(A_3);
		}

		private void R()
		{
			if (A_14 != null)
			{
				A_14.Cancel();
			}
			B_3.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Nv());
		}

		private void r()
		{
			A_6.B_m_1();
			A_7.A_m_1();
			if (A_8 != null)
			{
				A_8.A();
			}
			A_5 = null;
			B_5 = false;
			global::B.a.b(A_4);
			a_m_1((global::B.A)null);
		}

		private void A_m_1(global::a.v P_0)
		{
			string text = global::a.u.A(P_0, A_4.Experimental);
			string text2;
			if (P_0.Kind == global::a.V.a)
			{
				text2 = text;
				r();
				b_m_1(false);
			}
			else
			{
				text2 = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.uf(), A_4.DisplayName) + text;
			}
			B_3.Text = text2;
			if (!a_5)
			{
				MessageBox.Show(this, text2, global::a.Q.A_m_1(A_4.DisplayName), MessageBoxButtons.OK, (P_0.Kind == global::a.V.a) ? MessageBoxIcon.Exclamation : MessageBoxIcon.Hand);
			}
			global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBi(), A_4.DisplayName + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBL(), A_20.Text, text2, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf());
		}

		private void A_m_1(Func<Task> P_0)
		{
			if (!A_15)
			{
				a_m_1(P_0);
			}
		}

		private async void a_m_1(Func<Task> P_0)
		{
			try
			{
				await P_0();
			}
			catch (OperationCanceledException)
			{
				if (B_3 != null && !IsDisposed && !Disposing)
				{
					B_3.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.qG());
				}
			}
			catch (Exception ex2)
			{
				if (!IsDisposed && !Disposing)
				{
					global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBi(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNI(), A_20.Text, ex2.Message, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf());
					MessageBox.Show(this, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.XD()) + ex2.Message, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.or()), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
		}

		private void b_m_1(bool P_0)
		{
			A_15 = P_0;
			bool hasCookie = HasCookie;
			A_22.Enabled = !P_0;
			a_2.Enabled = !P_0;
			B_2.Enabled = !P_0 & hasCookie;
			g_1.Enabled = !P_0;
			if (A_21 != null)
			{
				A_21.Enabled = !P_0;
			}
			b_2.Enabled = !P_0 & hasCookie;
			C_1.Enabled = !P_0 & hasCookie;
			d_1.Enabled = (!P_0 & hasCookie) && B_5;
			E_1.Enabled = (!P_0 & hasCookie) && B_5;
			e_1.Enabled = P_0;
			G_1.Enabled = !P_0;
			f_1.Enabled = !P_0;
			F_1.Enabled = !P_0;
			A_20.Enabled = !P_0;
			a_1.Enabled = !P_0;
			B_1.Enabled = !P_0;
			b_1.Enabled = !P_0;
			if (A_23 != null)
			{
				A_23.Enabled = !P_0;
			}
			if (A_24 != null)
			{
				A_24.Enabled = !P_0;
			}
			A_28.Enabled = !P_0;
			a_4.Enabled = !P_0;
			C_3.Enabled = !P_0;
			if (a_4 != null && A_11 != null)
			{
				A_m_1(A_11);
			}
			I_m_1();
		}

		private static string A_m_1(long P_0)
		{
			if (P_0 < 0)
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.DW();
			}
			if (P_0 >= 1073741824)
			{
				return ((double)P_0 / 1024.0 / 1024.0 / 1024.0).ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aat()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bf();
			}
			if (P_0 >= 1048576)
			{
				return ((double)P_0 / 1024.0 / 1024.0).ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aat()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Be();
			}
			if (P_0 >= 1024)
			{
				return ((double)P_0 / 1024.0).ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aat()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BE();
			}
			return P_0 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bd();
		}

		[CompilerGenerated]
		private void A_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			a_m_1();
		}

		[CompilerGenerated]
		private void a_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			if (A_5 != null)
			{
				B_3.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.VB());
				A_m_1(() => L_m_1());
			}
			else if (A_8 == null && global::A.T.IsTestBuild && A_4.Id == global::A.v.a)
			{
				A_m_1();
			}
		}

		[CompilerGenerated]
		private Task S()
		{
			return L_m_1();
		}

		[CompilerGenerated]
		private void A_m_1(object? _003Cp0_003E, FormClosingEventArgs P_1)
		{
			if (A_14 != null)
			{
				A_14.Cancel();
			}
			q();
			// C-19：统一判空后再释放，避免 q() 内部置空导致的空引用。
			A_6?.Dispose();
			A_7?.Dispose();
			A_8?.Dispose();
		}

		[CompilerGenerated]
		private Task s()
		{
			return L_m_1();
		}

		[CompilerGenerated]
		private void B_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			c_m_1();
		}

		[CompilerGenerated]
		private void b_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			E_m_1();
		}

		[CompilerGenerated]
		private void C_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			F_m_1();
		}

		[CompilerGenerated]
		private void c_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			A_m_1(() => f_m_1());
		}

		[CompilerGenerated]
		private Task T()
		{
			return f_m_1();
		}

		[CompilerGenerated]
		private void D_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			A_m_1(G_m_1);
		}

		[CompilerGenerated]
		private void d_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			H_m_1();
		}

		[CompilerGenerated]
		private void E_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			j_m_1();
		}

		[CompilerGenerated]
		private void a_m_1(object P_0, KeyEventArgs P_1)
		{
			A_m_1(P_0, P_1);
		}

		[CompilerGenerated]
		private void A_m_1(object P_0, ColumnClickEventArgs P_1)
		{
			a_m_1(P_1.Column);
		}

		[CompilerGenerated]
		private void e_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			a_6 = 0;
			A_m_1(A_11);
		}

		[CompilerGenerated]
		private void B_m_1(int P_0)
		{
			A_m_1(P_0);
		}

		[CompilerGenerated]
		private void F_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			A_m_1(() => a_m_1(true));
		}

		[CompilerGenerated]
		private Task t()
		{
			return a_m_1(true);
		}

		[CompilerGenerated]
		private void f_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			N();
		}

		[CompilerGenerated]
		private void G_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			n();
		}

		[CompilerGenerated]
		private void g_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			K_m_1();
		}

		[CompilerGenerated]
		private void H_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			A_m_1(() => M());
		}

		[CompilerGenerated]
		private Task U()
		{
			return M();
		}

		[CompilerGenerated]
		private void h_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			i_m_1();
		}

		[CompilerGenerated]
		private void I_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			e_m_1();
		}

		[CompilerGenerated]
		private void i_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			i_m_1();
		}

		[CompilerGenerated]
		private void J_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			J_m_1();
		}

		[CompilerGenerated]
		private void j_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			A_m_1(() => B_m_1(true));
		}

		[CompilerGenerated]
		private Task u()
		{
			return B_m_1(true);
		}

		[CompilerGenerated]
		private void K_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			A_m_1(() => Q());
		}

		[CompilerGenerated]
		private Task V()
		{
			return Q();
		}

		[CompilerGenerated]
		private void k_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			R();
		}

		[CompilerGenerated]
		private void L_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			Close();
		}

		[CompilerGenerated]
		private void l(object? _003Cp0_003E, EventArgs P_1)
		{
			A_3.LanzouUploadWorkers = (int)A_23.Value;
			global::A.Y.A_m_1(A_3);
		}

		[CompilerGenerated]
		private void M(object? _003Cp0_003E, EventArgs P_1)
		{
			A_3.LanzouForceReupload = A_24.Checked;
			global::A.Y.A_m_1(A_3);
		}

		[CompilerGenerated]
		private void m(object? _003Cp0_003E, EventArgs P_1)
		{
			B_m_1();
			PerformLayout();
		}

		[CompilerGenerated]
		private void A_m_1(object? _003Cp0_003E, DpiChangedEventArgs P_1)
		{
			B_m_1();
		}

		[CompilerGenerated]
		private Task v()
		{
			return a_m_1(false);
		}

		[CompilerGenerated]
		private Task W()
		{
			return a_m_1(false);
		}

		[CompilerGenerated]
		private Task w()
		{
			return a_m_1(false);
		}

		[CompilerGenerated]
		private Task<List<global::a.W>> C_m_1(string P_0)
		{
			return RemoteClient.A(P_0, CancellationToken.None);
		}
	}
	public static class i
	{
		private const string A = "0123456789ABCDEFGHJKMNPQRSTVWXYZ";

		private static readonly sbyte[] A_1 = A_m_1();

		private static sbyte[] A_m_1()
		{
			sbyte[] array = new sbyte[128];
			for (int num = 0; num < array.Length; num++)
			{
				array[num] = -1;
			}
			for (int num2 = 0; num2 < _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBl().Length; num2++)
			{
				array[(uint)_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBl()[num2]] = (sbyte)num2;
				array[(uint)char.ToLowerInvariant(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBl()[num2])] = (sbyte)num2;
			}
			array[73] = 1;
			array[105] = 1;
			array[76] = 1;
			array[108] = 1;
			array[79] = 0;
			array[111] = 0;
			return array;
		}

		public static string A_m_1(byte[] P_0)
		{
			if (P_0 == null || P_0.Length == 0)
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}
			StringBuilder stringBuilder = new StringBuilder((P_0.Length * 8 + 4) / 5);
			int num = 0;
			int num2 = 0;
			foreach (byte b2 in P_0)
			{
				num = (num << 8) | b2;
				for (num2 += 8; num2 >= 5; num2 -= 5)
				{
					stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBl()[(num >> num2 - 5) & 0x1F]);
				}
			}
			if (num2 > 0)
			{
				stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBl()[(num << 5 - num2) & 0x1F]);
			}
			return stringBuilder.ToString();
		}

		public static byte[] A_m_1(string P_0)
		{
			if (string.IsNullOrEmpty(P_0))
			{
				return null;
			}
			List<byte> list = new List<byte>(P_0.Length);
			ulong num = 0uL;
			int num2 = 0;
			foreach (char c2 in P_0)
			{
				if (c2 != '-' && c2 != ' ' && c2 != '\r' && c2 != '\n' && c2 != '\t' && c2 != '_' && c2 != '.')
				{
					if (c2 >= '\u0080')
					{
						return null;
					}
					sbyte b2 = A_1[(uint)c2];
					if (b2 < 0)
					{
						return null;
					}
					num = (num << 5) | (byte)b2;
					num2 += 5;
					if (num2 >= 8)
					{
						list.Add((byte)((num >> num2 - 8) & 0xFF));
						num2 -= 8;
					}
				}
			}
			num = 0uL;
			return list.ToArray();
		}
	}
}
namespace b
{
	public sealed class I
	{
		public string A;

		public string a;

		public DateTime? A_1;
	}
	public sealed class i
	{
		public string A;

		public string a;

		public string B;

		public DateTime? A_1;
	}
}
