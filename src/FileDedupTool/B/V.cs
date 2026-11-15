using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007B1262ED64_002DD0A6_002D499E_002D9510_002DF2240F018DBB_007D;
using A;
using B;
using a;
using b;

namespace B
{
	public sealed class V
	{
		public List<u> A = new List<u>();

		public List<u> a = new List<u>();

		public int A_1;
	}
	public static class v
	{
		public static V A(global::b.d P_0, S? P_1 = null)
		{
			V v2 = new V();
			T t2 = new T
			{
				A = P_0.C,
				A_1 = (S)(((int?)P_1) ?? Math.Max(0, Math.Min(2, P_0.B_2)))
			};
			List<string> list = global::b.e.A_m_1(P_0);
			v2.A_1 = list.Count;
			foreach (string item2 in list)
			{
				s s2 = t.a_m_1(Path.GetFileNameWithoutExtension(item2), t2);
				if (s2.A != r.A)
				{
					long a_ = 0L;
					try
					{
						a_ = global::a.k.c(item2);
					}
					catch
					{
					}
					u item = new u
					{
						A = item2,
						A_1 = a_,
						A_2 = s2
					};
					if (s2.A == r.a)
					{
						v2.A.Add(item);
					}
					else
					{
						v2.a.Add(item);
					}
				}
			}
			return v2;
		}
	}
}
namespace b
{
	public static class V
	{
		[CompilerGenerated]
		private static class A
		{
			public static Func<string, int, CancellationToken, T> A_f_1;

			public static Func<string, int, CancellationToken, T> a;

			public static Func<string, string, int, CancellationToken, T> A_f_2;
		}

		[CompilerGenerated]
		private sealed class a
		{
			public string A;

			public int A_1;

			public CancellationToken A_2;

			public string a_f_1;

			internal T A_m_1()
			{
				return V.A_2(A, A_1, A_2);
			}

			internal T a_m_1()
			{
				return a_1(A, A_1, A_2);
			}

			internal T B()
			{
				return A_3(a_f_1, A, A_1, A_2);
			}
		}

		public const int A_1 = 1000;

		internal static Func<string, int, CancellationToken, T> A_2 = t.A_m_1;

		internal static Func<string, int, CancellationToken, T> a_1 = U.A_m_1;

		internal static Func<string, string, int, CancellationToken, T> A_3 = u.A_m_1;

		internal static void A_m_1()
		{
			A_2 = t.A_m_1;
			a_1 = U.A_m_1;
			A_3 = u.A_m_1;
		}

		private static s a_m_1()
		{
			string environmentVariable = Environment.GetEnvironmentVariable(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLP());
			if (string.IsNullOrWhiteSpace(environmentVariable))
			{
				return (s)(-1);
			}
			string text = environmentVariable.Trim().ToLowerInvariant();
			if (!(text == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akW()))
			{
				if (!(text == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akw()))
				{
					if (!(text == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akX()))
					{
						if (!(text == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akx()))
						{
							if (text == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLp())
							{
								return (s)(-1);
							}
							return (s)(-1);
						}
						return s.A;
					}
					return s.b;
				}
				return s.B;
			}
			return s.a;
		}

		public static T A_m_1(string P_0, string P_1, int P_2, CancellationToken P_3)
		{
			s s2 = a_m_1();
			bool flag = s2 == (s)(-1) || s2 == s.a;
			bool flag2 = s2 == (s)(-1) || s2 == s.B;
			bool flag3 = s2 == (s)(-1) || s2 == s.b;
			if (Environment.GetEnvironmentVariable(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLQ()) == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CM())
			{
				flag = false;
			}
			T t2 = new T();
			if (flag)
			{
				t2 = A_m_1(() => A_2(P_0, P_2, P_3), s.a);
				if (t2 != null && t2.a)
				{
					return A_m_1(t2, P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLq());
				}
				if (t2 != null && t2.A_3 != null)
				{
					global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Mh(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLq(), P_1, t2.A_3, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf());
				}
				if (t2 != null && t2.A == s.a && t2.A_3 == null)
				{
					return t2;
				}
			}
			if (flag2)
			{
				t2 = A_m_1(() => a_1(P_0, P_2, P_3), s.B);
				if (t2 != null && t2.a)
				{
					return A_m_1(t2, P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLC());
				}
				if (t2 != null && t2.A_3 != null)
				{
					global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Mh(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLC(), P_1, t2.A_3, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf());
				}
				if (t2 != null && t2.A == s.B && t2.A_3 == null)
				{
					return t2;
				}
			}
			if (flag3)
			{
				t2 = A_m_1(() => A_3(P_1, P_0, P_2, P_3), s.b);
				if (t2 != null && t2.a)
				{
					return A_m_1(t2, P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLR());
				}
				if (t2 != null && t2.A_3 != null)
				{
					global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Mh(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLR(), P_1, t2.A_3, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf());
				}
				if (t2 != null && t2.A_3 == null)
				{
					if (!string.IsNullOrEmpty(t2.a_1))
					{
						t2.a_1 = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.TS());
					}
					return t2;
				}
			}
			T t3 = new T
			{
				A = s.A
			};
			t3.A_3 = ((t2 != null && t2.A_3 != null) ? t2.A_3 : global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.TR()));
			t3.a_1 = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.TS());
			global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Mh(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLr(), P_1, t3.A_3, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf());
			return t3;
		}

		private static T A_m_1(T P_0, string P_1, string P_2)
		{
			global::B.p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLS() + P_2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLs() + P_1);
			return P_0;
		}

		private static T A_m_1(Func<T> P_0, s P_1)
		{
			try
			{
				return P_0();
			}
			catch (OperationCanceledException)
			{
				return new T
				{
					A = P_1,
					a = true
				};
			}
			catch (Exception ex2)
			{
				return new T
				{
					A = P_1,
					A_3 = ex2.Message
				};
			}
		}
	}
	public sealed class v : Form
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class A
		{
			public static readonly A A_f_1 = new A();

			public static LinkClickedEventHandler A_f_2;

			public static EventHandler A_f_3;

			internal void A_m_1(object P_0, LinkClickedEventArgs P_1)
			{
				try
				{
					Process.Start(new ProcessStartInfo(P_1.LinkText)
					{
						UseShellExecute = true
					});
				}
				catch
				{
				}
			}

			internal void A_m_1(object? _003Cp0_003E, EventArgs P_1)
			{
				try
				{
					Process.Start(new ProcessStartInfo(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOD())
					{
						UseShellExecute = true
					});
				}
				catch
				{
				}
			}
		}

		private readonly RichTextBox A_1;

		private readonly Button A_2;

		private readonly Button a;

		private readonly Button B;

		private readonly Label A_3;

		public v(Y P_0)
		{
			Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.tO());
			StartPosition = FormStartPosition.CenterParent;
			Icon = global::A.R.App;
			Font = global::B.Q.A_m_1(10f);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(760, 680);
			MinimumSize = new Size(620, 480);
			BackColor = P_0.A;
			ForeColor = P_0.b;
			MaximizeBox = false;
			MinimizeBox = false;
			ShowInTaskbar = false;
			A_1 = new RichTextBox
			{
				Dock = DockStyle.Fill,
				ReadOnly = true,
				BackColor = P_0.H,
				ForeColor = P_0.h,
				BorderStyle = BorderStyle.None,
				WordWrap = true,
				Font = global::B.Q.A_m_1(10f),
				Text = W.A_m_1(),
				DetectUrls = true,
				ScrollBars = RichTextBoxScrollBars.Vertical,
				Margin = new Padding(0)
			};
			A_1.LinkClicked += (object obj2, LinkClickedEventArgs e2) =>
			{
				try
				{
					Process.Start(new ProcessStartInfo(e2.LinkText)
					{
						UseShellExecute = true
					});
				}
				catch
				{
				}
			};
			FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel
			{
				Dock = DockStyle.Bottom,
				FlowDirection = FlowDirection.RightToLeft,
				AutoSize = true,
				Padding = new Padding(12, 8, 12, 10),
				BackColor = P_0.A
			};
			B = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bl(), 96);
			B.Click += delegate
			{
				Close();
			};
			a = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.tu(), 176);
			a.Click += delegate
			{
				try
				{
					Process.Start(new ProcessStartInfo(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOD())
					{
						UseShellExecute = true
					});
				}
				catch
				{
				}
			};
			A_2 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Mj(), 112);
			A_2.Click += delegate
			{
				try
				{
					Clipboard.SetText(A_1.Text);
					A_3.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.tp());
				}
				catch
				{
					A_3.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.tq());
				}
			};
			A_3 = new Label
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(),
				AutoSize = true,
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BH(),
				Margin = new Padding(0, 10, 8, 0)
			};
			flowLayoutPanel.Controls.Add(B);
			flowLayoutPanel.Controls.Add(a);
			flowLayoutPanel.Controls.Add(A_2);
			flowLayoutPanel.Controls.Add(A_3);
			Panel panel = new Panel
			{
				Dock = DockStyle.Fill,
				Padding = new Padding(12, 12, 12, 0),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jp()
			};
			panel.Controls.Add(A_1);
			Controls.Add(panel);
			Controls.Add(flowLayoutPanel);
			Z.A_m_1(this, P_0, B);
			global::a.Q.A_m_1(this);
			A_1.BackColor = P_0.H;
			A_1.ForeColor = P_0.h;
		}

		private static Button A_m_1(string P_0, int P_1)
		{
			return new Button
			{
				Text = P_0,
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				MinimumSize = new Size(P_1, 34),
				Font = global::B.Q.A_m_1(10f),
				Margin = new Padding(8, 0, 0, 0),
				FlatStyle = FlatStyle.Flat,
				UseVisualStyleBackColor = false,
				Cursor = Cursors.Hand
			};
		}

		[CompilerGenerated]
		private void A_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			Close();
		}

		[CompilerGenerated]
		private void a_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			try
			{
				Clipboard.SetText(A_1.Text);
				A_3.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.tp());
			}
			catch
			{
				A_3.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.tq());
			}
		}
	}
}
