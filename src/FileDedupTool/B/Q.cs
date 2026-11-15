using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007B1262ED64_002DD0A6_002D499E_002D9510_002DF2240F018DBB_007D;
using A;
using C;
using a;
using b;

namespace B
{
	public sealed class Q : Form
	{
		private enum A
		{
			A_f_1,
			a,
			B,
			b,
			C
		}

		internal delegate global::A.u a(IWin32Window P_0, global::b.Y P_1, out bool P_2);

		private sealed class B : IMessageFilter
		{
			private const int A = 513;

			private const int a = 516;

			private readonly Q A_1;

			public B(Q P_0)
			{
				A_1 = P_0;
			}

			public bool PreFilterMessage(ref Message P_0)
			{
				if (P_0.Msg != 513 && P_0.Msg != 516)
				{
					return false;
				}
				Point pt = ((A_28 != null) ? A_28() : Control.MousePosition);
				if (A_1.A_13 != null && A_1.A_13.Visible && A_1.A_13.RectangleToScreen(A_1.A_13.ClientRectangle).Contains(pt))
				{
					return false;
				}
				if (A_1.A_15 != null && A_1.A_15.Visible && A_1.A_15.RectangleToScreen(A_1.A_15.ClientRectangle).Contains(pt))
				{
					return false;
				}
				if (A_1.k.RectangleToScreen(A_1.k.ClientRectangle).Contains(pt))
				{
					return false;
				}
				if (A_1.L.RectangleToScreen(A_1.L.ClientRectangle).Contains(pt))
				{
					return false;
				}
				if (A_1.D_4.RectangleToScreen(A_1.D_4.ClientRectangle).Contains(pt))
				{
					return false;
				}
				if (A_1.l.RectangleToScreen(A_1.l.ClientRectangle).Contains(pt))
				{
					return false;
				}
				A_1.E_m_1();
				A_1.f_m_1();
				return false;
			}
		}

		[Serializable]
		[CompilerGenerated]
		private sealed class b
		{
			public static readonly b A = new b();

			public static EventHandler A_1;

			public static Func<string, string> A_2;

			internal void A_m_1(object? _003Cp0_003E, EventArgs P_1)
			{
				foreach (string item in aC())
				{
					global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acO() + item);
				}
			}

			internal string A_m_1(string P_0)
			{
				return P_0;
			}
		}

		[CompilerGenerated]
		private sealed class C
		{
			public bool A;

			internal global::C.D A_m_1()
			{
				return global::C.E.A_m_1(A, CancellationToken.None);
			}
		}

		[CompilerGenerated]
		private sealed class c
		{
			public global::b.d A;

			public CancellationToken A_1;

			public Q A_2;

			internal void A_m_1()
			{
				global::b.R A = null;
				Exception A_1 = null;
				try
				{
					A = global::b.r.A_m_1(this.A, this.A_1, A_2.A_m_1);
				}
				catch (Exception ex)
				{
					A_1 = ex;
				}
				A_2.A_m_1(() =>
				{
					if (this.A_1.IsCancellationRequested)
					{
						int num = ((A != null) ? A.A_1.Count : 0);
						int num2 = ((A != null) ? A.A_2 : 0);
						global::B.p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNT() + num + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNt() + num2);
						A_2.A_32 = false;
						A_2.B_m_1(false);
						A_2.A_m_1(Q.A.b, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
						A_2.A_18.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mK());
						A_2.A_17.Value = 0;
					}
					else
					{
						if (A_1 == null)
						{
							A_2.A_m_1(Q.A.B, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ne(), A.A_2));
							A_2.A_18.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.SV(), A.A_1.Count);
							A_2.A_17.Value = 0;
							using global::b.P p2 = new global::b.P(A, A_2.A_33, A_2.r());
							if (p2.ShowDialog(A_2) == DialogResult.OK && p2.B_2)
							{
								this.A.A_8 = p2.A_12 ?? new Dictionary<string, string>();
								this.A.A_9 = p2.A_13;
								if (!p2.a_4)
								{
									this.A.A_1 = (this.A.a_1 = (this.A.B_1 = (this.A.b_1 = (this.A.C_1 = false))));
									global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNU());
								}
								else
								{
									global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNu());
								}
								A_2.A_32 = false;
								A_2.a_m_1(this.A);
							}
							else
							{
								global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNV());
								A_2.A_32 = false;
								A_2.B_m_1(false);
								A_2.A_m_1(Q.A.b, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
								A_2.A_18.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mK();
								A_2.A_17.Value = 0;
							}
							return;
						}
						global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Oj(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHp(), this.A.A, A_1.Message, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf());
						A_2.A_32 = false;
						A_2.B_m_1(false);
						A_2.A_m_1(Q.A.C, A_1.Message);
						A_2.A_18.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mK());
					}
				});
			}
		}

		[CompilerGenerated]
		private sealed class D
		{
			public global::b.R A;

			public Exception A_1;

			public c A_2;

			internal void A_m_1()
			{
				if (A_2.A_1.IsCancellationRequested)
				{
					int num = ((A != null) ? A.A_1.Count : 0);
					int num2 = ((A != null) ? A.A_2 : 0);
					global::B.p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNT() + num + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNt() + num2);
					A_2.A_2.A_32 = false;
					A_2.A_2.B_m_1(false);
					A_2.A_2.A_m_1(Q.A.b, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
					A_2.A_2.A_18.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mK());
					A_2.A_2.A_17.Value = 0;
					return;
				}
				if (A_1 != null)
				{
					global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Oj(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHp(), A_2.A.A, A_1.Message, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf());
					A_2.A_2.A_32 = false;
					A_2.A_2.B_m_1(false);
					A_2.A_2.A_m_1(Q.A.C, A_1.Message);
					A_2.A_2.A_18.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mK());
					return;
				}
				A_2.A_2.A_m_1(Q.A.B, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ne(), A.A_2));
				A_2.A_2.A_18.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.SV(), A.A_1.Count);
				A_2.A_2.A_17.Value = 0;
				using global::b.P p2 = new global::b.P(A, A_2.A_2.A_33, A_2.A_2.r());
				if (p2.ShowDialog(A_2.A_2) == DialogResult.OK && p2.B_2)
				{
					A_2.A.A_8 = p2.A_12 ?? new Dictionary<string, string>();
					A_2.A.A_9 = p2.A_13;
					if (!p2.a_4)
					{
						A_2.A.A_1 = (A_2.A.a_1 = (A_2.A.B_1 = (A_2.A.b_1 = (A_2.A.C_1 = false))));
						global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNU());
					}
					else
					{
						global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNu());
					}
					A_2.A_2.A_32 = false;
					A_2.A_2.a_m_1(A_2.A);
				}
				else
				{
					global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNV());
					A_2.A_2.A_32 = false;
					A_2.A_2.B_m_1(false);
					A_2.A_2.A_m_1(Q.A.b, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
					A_2.A_2.A_18.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mK();
					A_2.A_2.A_17.Value = 0;
				}
			}
		}

		[CompilerGenerated]
		private sealed class d
		{
			public global::b.d A;

			public Q A_1;

			public CancellationToken A_2;

			public MethodInvoker A_3;

			internal void A_m_1()
			{
				bool flag = true;
				int A = 0;
				try
				{
					A = global::b.e.B_m_1(this.A.A).Count;
				}
				catch (Exception ex)
				{
					global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Oj(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNv(), this.A_1.A_3.Text, ex.Message, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf());
				}
				this.A.A_7 = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
				this.A_1.c_6 = this.A.g;
				if (this.A.B_1 && A > 0)
				{
					try
					{
						V A2 = global::B.v.A(this.A);
						if (A2.a.Count > 0 && this.A.g)
						{
							HashSet<string> hashSet = this.A_1.A_m_1(() =>
							{
								using global::b.X x2 = new global::b.X(A2, this.A_1.A_33);
								x2.ShowDialog(this.A_1);
								return new HashSet<string>(x2.a, StringComparer.OrdinalIgnoreCase);
							});
							if (hashSet != null)
							{
								this.A.A_7 = hashSet;
							}
						}
						else if (A2.a.Count > 0)
						{
							global::B.p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNW() + A2.a.Count + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNw());
						}
					}
					catch (Exception ex2)
					{
						global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNX(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNx(), this.A.A, ex2.Message, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf());
					}
				}
				if (!this.A.c_1 && A > 0)
				{
					flag = this.A_1.A_m_1(() =>
					{
						string text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNy(), A, global::a.Q.A_m_1(Q.A_m_1(this.A.A_2)), global::a.Q.A_m_1((this.A.A_3 == global::a.A.A_f_1) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.sZ() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ci()));
						return MessageBox.Show(this.A_1, text, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.sX()), MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK;
					});
				}
				if (!flag)
				{
					global::B.p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNY() + A);
					this.A_1.A_m_1(() =>
					{
						this.A_1.A_32 = false;
						this.A_1.B_m_1(false);
						this.A_1.A_m_1(Q.A.b, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
						this.A_1.A_18.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mK();
					});
					return;
				}
				global::b.E A_1 = null;
				Exception A_2 = null;
				try
				{
					global::b.e e2 = new global::b.e(this.A)
					{
						A_7 = this.A_1.A_m_1
					};
					A_1 = e2.A_m_1(this.A_2);
				}
				catch (Exception ex3)
				{
					Exception ex4 = (A_2 = ex3);
					global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahn(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lJ(), this.A.A, ex4.Message, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf());
				}
				finally
				{
					this.A_1.A_m_1(() =>
					{
						bool isCancellationRequested = this.A_2.IsCancellationRequested;
						int num = ((A_1 != null) ? (A_1.A + A_1.a + A_1.B + A_1.D + A_1.d + A_1.F + A_1.f + A_1.C + A_1.c + A_1.b) : 0);
						this.A_1.A_32 = false;
						this.A_1.B_m_1(false);
						this.A_1.A_17.Value = 0;
						if (isCancellationRequested)
						{
							string text = (string.IsNullOrWhiteSpace(this.A_1.A_36) ? global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lJ()) : this.A_1.A_36);
							global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahn(), text, num, A);
							this.A_1.A_m_1(Q.A.b, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
							this.A_1.A_18.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mK());
						}
						else
						{
							if (A_2 != null)
							{
								this.A_1.A_m_1(Q.A.C, A_2.Message);
							}
							else
							{
								this.A_1.A_m_1(Q.A.B, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.nd(), num));
							}
							this.A_1.A_18.Text = ((A_1 != null && A_1.A_1) ? global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.SX()) : global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mK()));
							this.A_1.F_m_1((A_1 != null) ? A_1.ToString() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.rp());
							this.A_1.A_m_1(A_1, A_2);
						}
					});
				}
			}

			internal void a()
			{
				A_1.A_32 = false;
				A_1.B_m_1(false);
				A_1.A_m_1(Q.A.b, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
				A_1.A_18.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mK();
			}
		}

		[CompilerGenerated]
		private sealed class E
		{
			public int A;

			public global::b.E A_1;

			public Exception A_2;

			public d A_3;

			internal bool A_m_1()
			{
				string text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNy(), A, global::a.Q.A_m_1(Q.A_m_1(A_3.A.A_2)), global::a.Q.A_m_1((A_3.A.A_3 == global::a.A.A_f_1) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.sZ() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ci()));
				return MessageBox.Show(A_3.A_1, text, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.sX()), MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK;
			}

			internal void a()
			{
				bool isCancellationRequested = A_3.A_2.IsCancellationRequested;
				int num = ((A_1 != null) ? (A_1.A + A_1.a + A_1.B + A_1.D + A_1.d + A_1.F + A_1.f + A_1.C + A_1.c + A_1.b) : 0);
				A_3.A_1.A_32 = false;
				A_3.A_1.B_m_1(false);
				A_3.A_1.A_17.Value = 0;
				if (isCancellationRequested)
				{
					string text = (string.IsNullOrWhiteSpace(A_3.A_1.A_36) ? global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lJ()) : A_3.A_1.A_36);
					global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahn(), text, num, A);
					A_3.A_1.A_m_1(Q.A.b, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
					A_3.A_1.A_18.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mK());
					return;
				}
				if (A_2 != null)
				{
					A_3.A_1.A_m_1(Q.A.C, A_2.Message);
				}
				else
				{
					A_3.A_1.A_m_1(Q.A.B, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.nd(), num));
				}
				A_3.A_1.A_18.Text = ((A_1 != null && A_1.A_1) ? global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.SX()) : global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mK()));
				A_3.A_1.F_m_1((A_1 != null) ? A_1.ToString() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.rp());
				A_3.A_1.A_m_1(A_1, A_2);
			}
		}

		[CompilerGenerated]
		private sealed class e
		{
			public V A;

			public E A_1;

			internal HashSet<string> A_m_1()
			{
				using global::b.X x2 = new global::b.X(A, A_1.A_3.A_1.A_33);
				x2.ShowDialog(A_1.A_3.A_1);
				return new HashSet<string>(x2.a, StringComparer.OrdinalIgnoreCase);
			}
		}

		[CompilerGenerated]
		private sealed class F
		{
			public Q A;

			public string A_1;

			public X.A A_2;

			internal void A_m_1()
			{
				A.e_m_1(A_1);
			}

			internal void A_m_1(object? _003Cp0_003E, FormClosedEventArgs P_1)
			{
				if (A.A_8 == A_2)
				{
					A.A_8 = null;
				}
			}
		}

		[CompilerGenerated]
		private sealed class f
		{
			public string A;

			public bool A_1;

			public CancellationToken A_2;

			public Q A_3;

			internal void A_m_1()
			{
				w.A A = null;
				try
				{
					A = global::B.w.A_m_1(this.A, A_1, A_2);
				}
				catch (Exception ex)
				{
					global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGO(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.nc(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(), ex.Message, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf());
				}
				finally
				{
					A_3.A_m_1(() =>
					{
						A_3.A_32 = false;
						A_3.B_m_1(false);
						if (A != null)
						{
							A_3.A_m_1(Q.A.B, A.A_m_1());
						}
						else
						{
							A_3.A_m_1(Q.A.C, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.SY()));
						}
					});
				}
			}
		}

		[CompilerGenerated]
		private sealed class G
		{
			public w.A A;

			public f A_1;

			internal void A_m_1()
			{
				A_1.A_3.A_32 = false;
				A_1.A_3.B_m_1(false);
				if (A != null)
				{
					A_1.A_3.A_m_1(Q.A.B, A.A_m_1());
				}
				else
				{
					A_1.A_3.A_m_1(Q.A.C, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.SY()));
				}
			}
		}

		[CompilerGenerated]
		private sealed class g
		{
			public Q A;

			public string A_1;

			public List<N> A_2;

			internal bool A_m_1()
			{
				using o o2 = new o(A.A_33, A_1, A_2);
				return o2.ShowDialog(A) == DialogResult.OK;
			}
		}

		public static float A_1 = 1f;

		private const int A_2 = 800;

		private TextBox A_3;

		private TextBox a_1;

		private TextBox B_1;

		private TextBox b_1;

		private TextBox C_1;

		private Button A_4;

		private Button a_2;

		private Button B_2;

		private CheckBox A_5;

		private CheckBox a_3;

		private CheckBox B_3;

		private CheckBox b_2;

		private CheckBox C_2;

		private CheckBox c_1;

		private CheckBox D_1;

		private CheckBox d_1;

		private CheckBox E_1;

		private CheckBox e_1;

		private CheckBox F_1;

		private CheckBox f_1;

		private ComboBox A_6;

		private CheckBox G_1;

		private CheckBox g_1;

		private CheckBox H_1;

		private CheckBox h;

		private CheckBox I;

		private CheckBox i;

		private bool A_7;

		private X.A A_8;

		internal static Action<string> A_9 = null;

		private ComboBox a_4;

		private NumericUpDown A_10;

		private NumericUpDown a_5;

		private NumericUpDown B_4;

		private TextBox c_2;

		private ComboBox B_5;

		// C-15：图片独立保留规则下拉。
		private ComboBox A_39;

		private Button b_3;

		private Button C_3;

		private Button c_3;

		private Button D_2;

		private Button d_2;

		private Button E_2;

		private RadioButton A_11;

		private RadioButton a_6;

		private RadioButton B_6;

		private RadioButton b_4;

		private RadioButton C_4;

		private RadioButton c_4;

		private RadioButton D_3;

		private RadioButton d_3;

		private RadioButton E_3;

		private RadioButton e_2;

		private Button e_3;

		private Button F_2;

		private Button f_2;

		private Button G_2;

		private Button g_2;

		private Button H_2;

		private Button h_1;

		private Button I_1;

		private Button i_1;

		private Button J;

		private Button j;

		private Button K;

		private Button k;

		private Button L;

		private Button l;

		private Button M;

		private Button m;

		private Button N;

		private Button n;

		private bool a_7;

		private TextBox D_4;

		internal static Action A_12 = null;

		private Panel A_13;

		private B A_14;

		private global::b.w A_15;

		private B a_8;

		private RichTextBox A_16;

		private ProgressBar A_17;

		private Label A_18;

		private Label a_9;

		private Label B_7;

		private Label b_5;

		private Label C_5;

		private Label c_5;

		private Label D_5;

		private Label d_4;

		private Label E_4;

		private Panel a_10;

		private Panel B_8;

		private A A_19;

		private string A_20 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		private DateTime A_21 = DateTime.MinValue;

		private readonly ToolTip A_22 = new ToolTip
		{
			AutoPopDelay = 20000,
			InitialDelay = 320,
			ReshowDelay = 100,
			ShowAlways = true
		};

		private NotifyIcon A_23;

		private ContextMenuStrip A_24;

		private ToolStripMenuItem A_25;

		private ToolStripMenuItem a_11;

		private ToolStripMenuItem B_9;

		private ToolStripMenuItem b_6;

		private ToolStripMenuItem C_6;

		private bool B_10;

		private bool b_7;

		private bool C_7;

		internal static Func<IWin32Window, DialogResult> A_26 = null;

		internal static a A_27 = null;

		internal static Action a_12 = null;

		internal static Func<Point> A_28 = null;

		private readonly ConcurrentQueue<KeyValuePair<string, P>> A_29 = new ConcurrentQueue<KeyValuePair<string, P>>();

		private readonly System.Windows.Forms.Timer A_30 = new System.Windows.Forms.Timer();

		private CancellationTokenSource A_31;

		private volatile bool A_32;

		private bool c_6 = true;

		private bool D_6;

		private global::b.Y A_33;

		private global::A.x A_34;

		private global::b.y A_35;

		private bool d_5;

		private string a_13;

		private DateTime a_14;

		private System.Windows.Forms.Timer a_15;

		private volatile string A_36 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		private volatile string a_16 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		private volatile int A_37;

		private volatile int a_17;

		internal static Func<string, List<N>, bool> A_38 = null;

		private static Font A_m_1(float P_0, FontStyle P_1 = FontStyle.Regular, string P_2 = "Microsoft YaHei UI")
		{
			return new Font(P_2, P_0 * A_1, P_1);
		}

		internal static Font A_m_1(float P_0, FontStyle P_1 = FontStyle.Regular)
		{
			return A_m_1(P_0, P_1, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acL());
		}

		public Q()
		{
			A_34 = global::A.Y.A_m_1();
			if (A_34.Profiles == null)
			{
				A_34.Profiles = new Dictionary<string, global::A.x>();
			}
			A_m_1();
			global::a.Q.Lang = A_34.Lang;
			B_m_1();
			A_35 = a_m_1();
			D_6 = A_35 == global::b.y.a || (A_35 == global::b.y.B && global::b.Z.A_m_1());
			A_33 = (D_6 ? global::b.Y.a_m_1() : global::b.Y.A_m_1());
			A_m_1(A_34);
			C_m_1((string.IsNullOrWhiteSpace(A_34.LastProfile) || !A_34.Profiles.ContainsKey(A_34.LastProfile)) ? null : A_34.LastProfile);
			global::b.Z.A_m_1(this, A_33, e_3);
			J_m_1();
			global::B.p.Line += A_m_1;
			A_30.Interval = 120;
			A_30.Tick += A_m_1;
			A_30.Start();
			a_15 = new System.Windows.Forms.Timer
			{
				Interval = 1200000
			};
			a_15.Tick += delegate
			{
				O();
			};
			a_15.Start();
			Q_m_1();
			p();
			global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abD() + global::A.r.TitleSuffix + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acl() + global::B.p.LogDir);
			global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acM() + global::B.p.OpsDir + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acm());
			global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acN() + global::a.j.StatusText + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acn() + global::C.f.Tag);
			foreach (string item in aC())
			{
				global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acO() + item);
			}
			y();
			global::b.Z.A_m_1(A_24, A_33);
			global::a.Q.A_m_1(A_24.Items);
			DpiChanged += delegate
			{
				Z();
			};
			FormClosing += A_m_1;
			global::C.E.A_m_1();
			Shown += delegate
			{
				a_m_1(false);
			};
		}

		private void A_m_1()
		{
			if (A_34.CloseToTray)
			{
				A_34.CloseToTray = false;
				A_34.ClosePrompt = false;
				A_34.CloseRememberToTray = true;
			}
			if (A_34.Dark && (A_34.ThemeMode == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iY() || string.IsNullOrEmpty(A_34.ThemeMode)))
			{
				A_34.ThemeMode = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aco();
			}
		}

		private global::b.y a_m_1()
		{
			string text = ((A_34 == null) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D() : A_34.ThemeMode);
			if (text == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aco())
			{
				return global::b.y.a;
			}
			if (text == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ad())
			{
				return global::b.y.B;
			}
			if (A_34 == null || !A_34.Dark)
			{
				return global::b.y.A;
			}
			return global::b.y.a;
		}

		protected override void OnLoad(EventArgs P_0)
		{
			base.OnLoad(P_0);
			Rectangle workingArea = Screen.FromControl(this).WorkingArea;
			int num = Math.Min(Width, workingArea.Width - 20);
			int num2 = Math.Min(Height, workingArea.Height - 20);
			if (num != Width || num2 != Height)
			{
				Width = num;
				Height = num2;
				Location = new Point(workingArea.Left + (workingArea.Width - Width) / 2, workingArea.Top + (workingArea.Height - Height) / 2);
			}
		}

		private void B_m_1()
		{
			SuspendLayout();
			Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abD() + global::A.r.TitleSuffix;
			Icon = global::A.R.App;
			StartPosition = FormStartPosition.CenterScreen;
			Font = A_m_1(10.5f, FontStyle.Regular, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acL());
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1440, 980);
			MinimumSize = new Size(1280, 800);
			DoubleBuffered = true;
			AllowDrop = true;
			DragEnter += A_m_1;
			DragDrop += a_m_1;
			Shown += delegate
			{
				PerformLayout();
			};
			TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
			{
				Dock = DockStyle.Fill,
				ColumnCount = 1,
				RowCount = 4,
				Padding = new Padding(16, 0, 16, 10),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jp()
			};
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			Controls.Add(tableLayoutPanel);
			a_10 = new Panel
			{
				Dock = DockStyle.Fill,
				Height = 4,
				Margin = new Padding(0),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acP()
			};
			tableLayoutPanel.Controls.Add(a_10, 0, 0);
			TableLayoutPanel tableLayoutPanel2 = new TableLayoutPanel
			{
				Dock = DockStyle.Fill,
				ColumnCount = 3,
				RowCount = 2,
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				Margin = new Padding(0, 8, 0, 6)
			};
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			B_7 = new Label
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abD(),
				Font = A_m_1(17f, FontStyle.Bold, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acL()),
				AutoSize = true,
				Anchor = (AnchorStyles.Bottom | AnchorStyles.Left),
				Margin = new Padding(0, 0, 14, 0),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abe()
			};
			b_5 = new Label
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acp() + global::A.r.c + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Dr(),
				Font = A_m_1(10f, FontStyle.Regular, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acL()),
				AutoSize = true,
				Anchor = (AnchorStyles.Bottom | AnchorStyles.Left),
				Margin = new Padding(0, 0, 12, 5),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Fh()
			};
			tableLayoutPanel2.Controls.Add(B_7, 0, 0);
			FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel
			{
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				WrapContents = false,
				Anchor = (AnchorStyles.Bottom | AnchorStyles.Left),
				Margin = new Padding(0)
			};
			flowLayoutPanel.Controls.Add(b_5);
			B_8 = new Panel
			{
				Size = new Size(28, 28),
				Margin = new Padding(0, 0, 0, 3),
				Cursor = Cursors.Hand,
				BackColor = Color.Transparent,
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acQ()
			};
			B_8.Paint += (object P_0, PaintEventArgs P_1) =>
			{
				global::b.Y y2 = A_33 ?? global::b.Y.A_m_1();
				P_1.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
				Rectangle rectangle = new Rectangle(0, 0, B_8.Width - 1, B_8.Height - 1);
				using (SolidBrush brush = new SolidBrush(y2.f))
				{
					P_1.Graphics.FillEllipse(brush, rectangle);
				}
				using (Pen pen = new Pen(y2.g, 1f))
				{
					P_1.Graphics.DrawEllipse(pen, rectangle);
				}
				TextRenderer.DrawText(P_1.Graphics, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aET(), A_m_1(8f, FontStyle.Bold, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acL()), rectangle, y2.G, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);
			};
			B_8.Click += delegate
			{
				P();
			};
			A_22.SetToolTip(B_8, global::a.Q.EnMode ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acR() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acq());
			flowLayoutPanel.Controls.Add(B_8);
			tableLayoutPanel2.Controls.Add(flowLayoutPanel, 1, 0);
			E_4 = new Label
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.TZ(),
				AutoSize = true,
				Anchor = (AnchorStyles.Bottom | AnchorStyles.Right),
				Margin = new Padding(14, 0, 0, 5),
				Font = A_m_1(9.5f, FontStyle.Regular, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acL()),
				Cursor = Cursors.Hand,
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Fh()
			};
			E_4.Click += delegate
			{
				o();
			};
			tableLayoutPanel2.Controls.Add(E_4, 2, 0);
			TableLayoutPanel tableLayoutPanel3 = new TableLayoutPanel
			{
				Dock = DockStyle.Fill,
				ColumnCount = 3,
				RowCount = 1,
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				Margin = new Padding(0, 4, 0, 0)
			};
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			L = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.tN(), 96);
			L.Margin = new Padding(0, 0, 6, 0);
			L.Click += delegate
			{
				e_m_1();
			};
			tableLayoutPanel3.Controls.Add(L, 0, 0);
			D_4 = new TextBox
			{
				Dock = DockStyle.Fill,
				AutoSize = false,
				Height = 30,
				Font = A_m_1(10.5f, FontStyle.Regular, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acL()),
				BorderStyle = BorderStyle.FixedSingle,
				Margin = new Padding(0, 4, 6, 4)
			};
			D_4.KeyDown += (object P_0, KeyEventArgs P_1) =>
			{
				if (P_1.KeyCode == Keys.Return)
				{
					P_1.SuppressKeyPress = true;
					e_m_1();
				}
			};
			tableLayoutPanel3.Controls.Add(D_4, 1, 0);
			l = new Button
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.DW(),
				AutoSize = false,
				Size = new Size(36, 38),
				Font = A_m_1(12f, FontStyle.Bold, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acL()),
				FlatStyle = FlatStyle.Flat,
				UseVisualStyleBackColor = false,
				Cursor = Cursors.Hand,
				Margin = new Padding(0)
			};
			l.Click += delegate
			{
				G_m_1();
			};
			tableLayoutPanel3.Controls.Add(l, 2, 0);
			tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
			tableLayoutPanel2.SetColumnSpan(tableLayoutPanel3, 3);
			tableLayoutPanel.Controls.Add(tableLayoutPanel2, 0, 1);
			TableLayoutPanel tableLayoutPanel4 = new TableLayoutPanel
			{
				Dock = DockStyle.Fill,
				ColumnCount = 2,
				RowCount = 1,
				Margin = new Padding(0)
			};
			tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 760f));
			tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			tableLayoutPanel.Controls.Add(tableLayoutPanel4, 0, 2);
			Panel panel = new Panel
			{
				Dock = DockStyle.Fill,
				AutoScroll = true,
				Margin = new Padding(0, 0, 12, 0),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jp()
			};
			tableLayoutPanel4.Controls.Add(panel, 0, 0);
			TableLayoutPanel tableLayoutPanel5 = new TableLayoutPanel
			{
				Dock = DockStyle.Top,
				ColumnCount = 1,
				RowCount = 7,
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				Margin = new Padding(0),
				Padding = new Padding(0)
			};
			tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			for (int num = 0; num < 7; num++)
			{
				tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			}
			panel.Controls.Add(tableLayoutPanel5);
			GroupBox groupBox = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.MO());
			TableLayoutPanel tableLayoutPanel6 = A_m_1(3, 2);
			tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			tableLayoutPanel6.Controls.Add(a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.MZ()), 0, 0);
			A_3 = C_m_1();
			A_3.AllowDrop = false;
			tableLayoutPanel6.Controls.Add(A_3, 1, 0);
			A_4 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.NN(), 84);
			A_4.Click += delegate
			{
				A_m_1(A_3);
			};
			tableLayoutPanel6.Controls.Add(A_4, 2, 0);
			tableLayoutPanel6.Controls.Add(a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mA()), 0, 1);
			a_1 = C_m_1();
			tableLayoutPanel6.Controls.Add(a_1, 1, 1);
			a_2 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.NN(), 84);
			a_2.Click += delegate
			{
				A_m_1(a_1);
			};
			tableLayoutPanel6.Controls.Add(a_2, 2, 1);
			groupBox.Controls.Add(tableLayoutPanel6);
			tableLayoutPanel5.Controls.Add(groupBox, 0, 0);
			GroupBox groupBox2 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.MP());
			TableLayoutPanel tableLayoutPanel7 = A_m_1(2, 3);
			tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
			tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
			A_5 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mL(), true);
			a_3 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mM(), true);
			B_3 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mN(), false);
			b_2 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mO(), true);
			C_2 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mP(), true);
			C_2.CheckedChanged += delegate
			{
				g_m_1();
			};
			tableLayoutPanel7.Controls.Add(A_5, 0, 0);
			tableLayoutPanel7.Controls.Add(a_3, 1, 0);
			tableLayoutPanel7.Controls.Add(B_3, 0, 1);
			tableLayoutPanel7.Controls.Add(b_2, 1, 1);
			tableLayoutPanel7.Controls.Add(C_2, 0, 2);
			A_22.SetToolTip(A_5, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Pj());
			A_22.SetToolTip(a_3, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Pk());
			A_22.SetToolTip(B_3, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acr());
			A_22.SetToolTip(b_2, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Pm());
			A_22.SetToolTip(C_2, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Pn());
			groupBox2.Controls.Add(tableLayoutPanel7);
			tableLayoutPanel5.Controls.Add(groupBox2, 0, 1);
			GroupBox groupBox3 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.MQ());
			TableLayoutPanel tableLayoutPanel8 = A_m_1(4, 9);
			tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			c_1 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mQ(), false);
			c_1.CheckedChanged += delegate
			{
				g_m_1();
			};
			tableLayoutPanel8.Controls.Add(c_1, 0, 0);
			c_5 = new Label
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mB(),
				AutoSize = true,
				Anchor = AnchorStyles.Left,
				Margin = new Padding(6, 8, 4, 8),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BH()
			};
			tableLayoutPanel8.Controls.Add(c_5, 1, 0);
			a_4 = new q
			{
				DropDownStyle = ComboBoxStyle.DropDownList,
				Margin = new Padding(0, 5, 2, 5),
				Anchor = AnchorStyles.Left,
				FlatStyle = FlatStyle.Flat
			};
			a_4.Items.AddRange(new object[4]
			{
				_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.cA(),
				_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.hf(),
				_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.hG(),
				_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.hg()
			});
			a_4.SelectedIndex = 0;
			a_4.Width = b_m_1();
			tableLayoutPanel8.Controls.Add(a_4, 2, 0);
			D_1 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mR(), false);
			D_1.CheckedChanged += delegate
			{
				g_m_1();
			};
			tableLayoutPanel8.Controls.Add(D_1, 0, 1);
			Label control = new Label
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mC(),
				AutoSize = true,
				Anchor = AnchorStyles.Left,
				Margin = new Padding(6, 8, 6, 8),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BH()
			};
			tableLayoutPanel8.Controls.Add(control, 1, 1);
			A_10 = new NumericUpDown
			{
				Minimum = 0m,
				Maximum = 20m,
				Value = 8m,
				Width = 56,
				Margin = new Padding(0, 6, 2, 6),
				Anchor = AnchorStyles.Left
			};
			tableLayoutPanel8.Controls.Add(A_10, 2, 1);
			// C-15：图片独立保留规则，紧跟相似阈值一行，默认“体积最大”。
			Label labelImageKeep = new Label
			{
				Text = "图片保留",
				AutoSize = true,
				Anchor = AnchorStyles.Left,
				Margin = new Padding(6, 8, 6, 8),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BH()
			};
			tableLayoutPanel8.Controls.Add(labelImageKeep, 1, 2);
			A_39 = new q
			{
				DropDownStyle = ComboBoxStyle.DropDownList,
				Margin = new Padding(0, 5, 2, 5),
				Anchor = AnchorStyles.Left,
				FlatStyle = FlatStyle.Flat
			};
			A_39.Items.AddRange(new object[5]
			{
				_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aia(),
				_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.hf(),
				_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.hG(),
				_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.hg(),
				_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.cA()
			});
			A_39.SelectedIndex = 0;
			A_39.Width = b_m_1();
			tableLayoutPanel8.Controls.Add(A_39, 2, 2);
			d_1 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mS(), false);
			tableLayoutPanel8.Controls.Add(d_1, 0, 3);
			g_1 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mT(), true);
			tableLayoutPanel8.Controls.Add(g_1, 0, 4);
			H_1 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mU(), false);
			tableLayoutPanel8.Controls.Add(H_1, 0, 5);
			h = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mV(), false);
			h.CheckedChanged += delegate
			{
				g_m_1();
			};
			tableLayoutPanel8.Controls.Add(h, 0, 6);
			Label control2 = new Label
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mD(),
				AutoSize = true,
				Anchor = AnchorStyles.Left,
				Margin = new Padding(6, 8, 6, 8),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BH()
			};
			tableLayoutPanel8.Controls.Add(control2, 1, 6);
			B_4 = new NumericUpDown
			{
				Minimum = 0m,
				Maximum = 60m,
				Value = 2m,
				Width = 56,
				Margin = new Padding(0, 6, 2, 6),
				Anchor = AnchorStyles.Left
			};
			tableLayoutPanel8.Controls.Add(B_4, 2, 6);
			G_1 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mW(), true);
			tableLayoutPanel8.Controls.Add(G_1, 0, 7);
			Label control3 = new Label
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mE(),
				AutoSize = true,
				Anchor = AnchorStyles.Left,
				Margin = new Padding(6, 8, 6, 8),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BH()
			};
			tableLayoutPanel8.Controls.Add(control3, 1, 7);
			a_5 = new NumericUpDown
			{
				Minimum = 0m,
				Maximum = 1000000m,
				Value = 0m,
				Width = 84,
				Margin = new Padding(0, 6, 2, 6),
				Anchor = AnchorStyles.Left
			};
			tableLayoutPanel8.Controls.Add(a_5, 2, 7);
			Label control4 = new Label
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mF(),
				AutoSize = true,
				Anchor = AnchorStyles.Left,
				Margin = new Padding(2, 8, 6, 8),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BH()
			};
			tableLayoutPanel8.Controls.Add(control4, 0, 8);
			c_2 = C_m_1();
			c_2.Width = 260;
			c_2.Dock = DockStyle.Fill;
			tableLayoutPanel8.Controls.Add(c_2, 1, 8);
			tableLayoutPanel8.SetColumnSpan(c_2, 3);
			A_22.SetToolTip(c_1, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ox());
			A_22.SetToolTip(c_5, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.oX());
			A_22.SetToolTip(a_4, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.oW());
			A_22.SetToolTip(D_1, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.oy());
			A_22.SetToolTip(A_10, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.oz());
			A_22.SetToolTip(labelImageKeep, "图片去重时每组保留哪一张，默认“体积最大”；该设置独立于内容去重和音频去重。");
			A_22.SetToolTip(A_39, "图片去重时每组保留哪一张，默认“体积最大”；该设置独立于内容去重和音频去重。");
			A_22.SetToolTip(d_1, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Pc());
			A_22.SetToolTip(g_1, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Pd());
			A_22.SetToolTip(H_1, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acS());
			A_22.SetToolTip(h, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Pa());
			A_22.SetToolTip(B_4, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Pb());
			A_22.SetToolTip(G_1, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Pf());
			A_22.SetToolTip(a_5, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Pg());
			A_22.SetToolTip(control4, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acs());
			A_22.SetToolTip(c_2, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acT());
			groupBox3.Controls.Add(tableLayoutPanel8);
			tableLayoutPanel5.Controls.Add(groupBox3, 0, 5);
			GroupBox groupBox4 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.MR());
			TableLayoutPanel tableLayoutPanel9 = A_m_1(2, 3);
			tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			I = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mX(), false);
			I.CheckedChanged += delegate
			{
				if (I.Checked && !global::a.j.Pro)
				{
					I.Checked = false;
					global::b.G.A_m_1(this, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEt(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEU());
					R();
				}
				else
				{
					R();
					if (I.Checked && I.Focused && !global::A.E.A_m_1(A_34))
					{
						q();
					}
				}
			};
			tableLayoutPanel9.Controls.Add(I, 0, 0);
			d_2 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.NO(), 110);
			d_2.Click += delegate
			{
				if (global::b.G.A_m_1(this, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEu(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEV()))
				{
					q();
				}
			};
			tableLayoutPanel9.Controls.Add(d_2, 1, 0);
			d_4 = new Label
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(),
				AutoSize = true,
				Anchor = AnchorStyles.Left,
				Margin = new Padding(2, 4, 2, 2),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BH()
			};
			tableLayoutPanel9.Controls.Add(d_4, 0, 1);
			tableLayoutPanel9.SetColumnSpan(d_4, 2);
			E_2 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.NP(), 140);
			E_2.Click += delegate
			{
				if (global::a.j.a_m_1(this))
				{
					R();
				}
			};
			tableLayoutPanel9.Controls.Add(E_2, 0, 2);
			E_2.Visible = !global::a.j.Pro;
			A_22.SetToolTip(I, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Pz());
			A_22.SetToolTip(d_2, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.pg());
			A_22.SetToolTip(E_2, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.RN());
			if (!global::a.j.Pro)
			{
				I.Enabled = true;
				d_2.Enabled = true;
				d_4.Cursor = Cursors.Hand;
				d_4.Click += delegate
				{
					if (global::b.G.A_m_1(this, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEt(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEU()))
					{
						R();
					}
				};
			}
			groupBox4.Controls.Add(tableLayoutPanel9);
			tableLayoutPanel5.Controls.Add(groupBox4, 0, 3);
			GroupBox groupBox5 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.MS());
			TableLayoutPanel tableLayoutPanel10 = A_m_1(4, 2);
			tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			B_5 = new q
			{
				DropDownStyle = ComboBoxStyle.DropDownList,
				Margin = new Padding(0, 5, 6, 5),
				Anchor = (AnchorStyles.Left | AnchorStyles.Right),
				FlatStyle = FlatStyle.Flat
			};
			tableLayoutPanel10.Controls.Add(B_5, 0, 0);
			b_3 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.NQ(), 92);
			b_3.Click += delegate
			{
				T();
			};
			tableLayoutPanel10.Controls.Add(b_3, 1, 0);
			C_3 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.NR(), 92);
			C_3.Click += delegate
			{
				t();
			};
			tableLayoutPanel10.Controls.Add(C_3, 2, 0);
			c_3 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.NS(), 104);
			c_3.Click += delegate
			{
				u();
			};
			tableLayoutPanel10.Controls.Add(c_3, 3, 0);
			D_5 = new Label
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(),
				AutoSize = true,
				Anchor = AnchorStyles.Left,
				Margin = new Padding(2, 4, 2, 2),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BH()
			};
			tableLayoutPanel10.Controls.Add(D_5, 0, 1);
			tableLayoutPanel10.SetColumnSpan(D_5, 4);
			A_22.SetToolTip(B_5, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.RR());
			A_22.SetToolTip(b_3, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Pw());
			A_22.SetToolTip(C_3, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Px());
			A_22.SetToolTip(c_3, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Py());
			B_5.SelectedIndexChanged += delegate
			{
				if (d_5)
				{
					return;
				}
				d_5 = true;
				try
				{
					E_m_1(B_5.SelectedItem as string);
				}
				finally
				{
					d_5 = false;
				}
			};
			groupBox5.Controls.Add(tableLayoutPanel10);
			tableLayoutPanel5.Controls.Add(groupBox5, 0, 4);
			GroupBox groupBox6 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.MT());
			TableLayoutPanel tableLayoutPanel11 = A_m_1(3, 9);
			tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			A_11 = a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mz(), true);
			a_6 = a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Na(), false);
			B_6 = a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Nb(), false);
			b_4 = a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Nc(), false);
			C_4 = a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Nd(), false);
			tableLayoutPanel11.Controls.Add(A_11, 0, 0);
			tableLayoutPanel11.SetColumnSpan(A_11, 3);
			tableLayoutPanel11.Controls.Add(a_6, 0, 1);
			tableLayoutPanel11.SetColumnSpan(a_6, 3);
			tableLayoutPanel11.Controls.Add(B_6, 0, 2);
			tableLayoutPanel11.SetColumnSpan(B_6, 3);
			tableLayoutPanel11.Controls.Add(b_4, 0, 3);
			tableLayoutPanel11.SetColumnSpan(b_4, 3);
			tableLayoutPanel11.Controls.Add(C_4, 0, 4);
			tableLayoutPanel11.SetColumnSpan(C_4, 3);
			tableLayoutPanel11.Controls.Add(a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mG()), 0, 5);
			B_1 = C_m_1();
			tableLayoutPanel11.Controls.Add(B_1, 1, 5);
			B_2 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.NN(), 84);
			B_2.Click += delegate
			{
				A_m_1(B_1);
			};
			tableLayoutPanel11.Controls.Add(B_2, 2, 5);
			tableLayoutPanel11.Controls.Add(a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mH()), 0, 6);
			b_1 = C_m_1();
			tableLayoutPanel11.Controls.Add(b_1, 1, 6);
			C_5 = new Label
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mI(),
				Font = A_m_1(9.5f, FontStyle.Regular, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acL()),
				AutoSize = true,
				Anchor = AnchorStyles.Left,
				Margin = new Padding(8, 8, 2, 8),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BH()
			};
			tableLayoutPanel11.Controls.Add(C_5, 2, 6);
			j = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ng(), 124);
			j.Margin = new Padding(0, 10, 10, 6);
			j.Anchor = AnchorStyles.Left;
			j.Click += delegate
			{
				l_m_1();
			};
			tableLayoutPanel11.Controls.Add(j, 0, 7);
			tableLayoutPanel11.SetColumnSpan(j, 3);
			M = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.act(), 116);
			M.Margin = new Padding(0, 0, 10, 6);
			M.Anchor = AnchorStyles.Left;
			M.Click += delegate
			{
				M_m_1();
			};
			tableLayoutPanel11.Controls.Add(M, 0, 8);
			tableLayoutPanel11.SetColumnSpan(M, 3);
			A_22.SetToolTip(A_11, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Po());
			A_22.SetToolTip(a_6, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Pp());
			A_22.SetToolTip(B_6, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acU());
			A_22.SetToolTip(B_1, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acU());
			A_22.SetToolTip(b_1, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acu());
			groupBox6.Controls.Add(tableLayoutPanel11);
			tableLayoutPanel5.Controls.Add(groupBox6, 0, 2);
			GroupBox groupBox7 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.MU());
			TableLayoutPanel tableLayoutPanel12 = A_m_1(3, 9);
			tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			c_4 = a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ne(), true);
			D_3 = a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Nf(), false);
			tableLayoutPanel12.Controls.Add(c_4, 0, 0);
			tableLayoutPanel12.Controls.Add(D_3, 1, 0);
			d_3 = a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ng(), false);
			tableLayoutPanel12.Controls.Add(d_3, 0, 1);
			E_1 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.my(), false);
			tableLayoutPanel12.Controls.Add(E_1, 0, 2);
			tableLayoutPanel12.SetColumnSpan(E_1, 3);
			E_3 = a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Nh(), true);
			e_2 = a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ci(), false);
			tableLayoutPanel12.Controls.Add(E_3, 0, 3);
			tableLayoutPanel12.SetColumnSpan(E_3, 2);
			tableLayoutPanel12.Controls.Add(e_2, 2, 3);
			tableLayoutPanel12.Controls.Add(a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mJ()), 0, 4);
			C_1 = C_m_1();
			tableLayoutPanel12.Controls.Add(C_1, 1, 4);
			tableLayoutPanel12.SetColumnSpan(C_1, 2);
			e_1 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.NJ(), false);
			tableLayoutPanel12.Controls.Add(e_1, 0, 5);
			tableLayoutPanel12.SetColumnSpan(e_1, 3);
			F_1 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.NK(), true);
			tableLayoutPanel12.Controls.Add(F_1, 0, 6);
			tableLayoutPanel12.SetColumnSpan(F_1, 3);
			A_22.SetToolTip(F_1, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.NL()));
			f_1 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Xv(), true);
			tableLayoutPanel12.Controls.Add(f_1, 0, 7);
			tableLayoutPanel12.SetColumnSpan(f_1, 3);
			A_22.SetToolTip(f_1, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acV());
			Label control5 = a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Xw());
			tableLayoutPanel12.Controls.Add(control5, 0, 8);
			A_6 = new ComboBox
			{
				DropDownStyle = ComboBoxStyle.DropDownList,
				Dock = DockStyle.Fill,
				Margin = new Padding(4, 3, 4, 3),
				Font = A_m_1(10f, FontStyle.Regular, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acL())
			};
			A_6.Items.AddRange(new object[3]
			{
				_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Xx(),
				_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Xy(),
				_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Xz()
			});
			A_6.SelectedIndex = 1;
			tableLayoutPanel12.Controls.Add(A_6, 1, 8);
			tableLayoutPanel12.SetColumnSpan(A_6, 2);
			A_22.SetToolTip(A_6, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acv());
			A_22.SetToolTip(e_1, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.NM());
			A_22.SetToolTip(c_4, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.pZ());
			A_22.SetToolTip(D_3, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.QA());
			A_22.SetToolTip(d_3, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.QB());
			A_22.SetToolTip(E_1, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acW());
			A_22.SetToolTip(E_3, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.QC());
			A_22.SetToolTip(e_2, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.QD());
			A_22.SetToolTip(C_1, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Pi());
			groupBox7.Controls.Add(tableLayoutPanel12);
			tableLayoutPanel5.Controls.Add(groupBox7, 0, 6);
			TableLayoutPanel tableLayoutPanel13 = new TableLayoutPanel
			{
				Dock = DockStyle.Fill,
				ColumnCount = 1,
				RowCount = 2,
				Margin = new Padding(0)
			};
			tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel4.Controls.Add(tableLayoutPanel13, 1, 0);
			GroupBox groupBox8 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.MV());
			groupBox8.Margin = new Padding(0);
			A_16 = new RichTextBox
			{
				Dock = DockStyle.Fill,
				ReadOnly = true,
				ScrollBars = RichTextBoxScrollBars.Vertical,
				WordWrap = false,
				BorderStyle = BorderStyle.None,
				Font = A_m_1(10f, FontStyle.Regular, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ME()),
				DetectUrls = false,
				HideSelection = false,
				Margin = new Padding(0)
			};
			groupBox8.Padding = new Padding(14, 28, 14, 12);
			groupBox8.Controls.Add(A_16);
			tableLayoutPanel13.Controls.Add(groupBox8, 0, 0);
			TableLayoutPanel tableLayoutPanel14 = new TableLayoutPanel
			{
				Dock = DockStyle.Fill,
				ColumnCount = 2,
				RowCount = 2,
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				Margin = new Padding(0, 8, 0, 0)
			};
			tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60f));
			tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40f));
			tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			int height = Math.Max(TextRenderer.MeasureText(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.MK(), A_m_1(10f, FontStyle.Regular, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acL())).Height, A_m_1(10f, FontStyle.Regular, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acL()).Height) + 6;
			A_18 = new Label
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mK(),
				AutoSize = false,
				AutoEllipsis = true,
				Dock = DockStyle.Fill,
				Height = height,
				MinimumSize = new Size(0, height),
				TextAlign = ContentAlignment.MiddleLeft,
				Margin = new Padding(2, 0, 8, 2),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Fh()
			};
			A_18.MouseHover += delegate
			{
				A_22.SetToolTip(A_18, A_18.Text);
			};
			a_9 = new Label
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acw(),
				AutoSize = false,
				AutoEllipsis = true,
				Dock = DockStyle.Fill,
				Height = height,
				MinimumSize = new Size(0, height),
				TextAlign = ContentAlignment.MiddleRight,
				Margin = new Padding(0, 0, 2, 2),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Fh()
			};
			a_9.MouseHover += delegate
			{
				A_22.SetToolTip(a_9, a_9.Text);
			};
			A_17 = new ProgressBar
			{
				Dock = DockStyle.Fill,
				Height = 12,
				Maximum = 1000,
				Margin = new Padding(0, 0, 0, 0)
			};
			tableLayoutPanel14.Controls.Add(A_18, 0, 0);
			tableLayoutPanel14.Controls.Add(a_9, 1, 0);
			tableLayoutPanel14.Controls.Add(A_17, 0, 1);
			tableLayoutPanel14.SetColumnSpan(A_17, 2);
			tableLayoutPanel13.Controls.Add(tableLayoutPanel14, 0, 1);
			FlowLayoutPanel flowLayoutPanel2 = new FlowLayoutPanel
			{
				Dock = DockStyle.Top,
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				WrapContents = true,
				FlowDirection = FlowDirection.LeftToRight,
				Margin = new Padding(0, 8, 0, 0),
				Padding = new Padding(0)
			};
			e_3 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.NT(), 132, true);
			e_3.Click += delegate
			{
				V();
			};
			F_2 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jY(), 92);
			F_2.Enabled = false;
			F_2.Click += delegate
			{
				X();
			};
			A_22.SetToolTip(F_2, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Nu()));
			f_2 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.nf(), 128);
			f_2.Click += delegate
			{
				w();
			};
			K = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ty(), 112);
			K.Click += delegate
			{
				m_m_1();
			};
			m = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acX(), 112);
			m.Click += delegate
			{
				N_m_1();
			};
			G_2 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.nh(), 112);
			G_2.Click += delegate
			{
				k_m_1();
			};
			g_2 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ns(), 100);
			g_2.Click += delegate
			{
				foreach (string item in aC())
				{
					global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acO() + item);
				}
			};
			this.I_1 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.nt(), 100);
			this.I_1.Click += delegate
			{
				K_m_1();
			};
			i_1 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.nu(), 100);
			i_1.Click += delegate
			{
				A_16.Clear();
			};
			k = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.no(), 96);
			k.Click += delegate
			{
				c_m_1();
			};
			Button[] array = new Button[10] { e_3, F_2, f_2, K, m, G_2, g_2, this.I_1, i_1, k };
			foreach (Button button in array)
			{
				button.Margin = new Padding(0, 0, 10, 6);
				flowLayoutPanel2.Controls.Add(button);
			}
			tableLayoutPanel.Controls.Add(flowLayoutPanel2, 0, 3);
			A_13 = new Panel
			{
				Visible = false,
				AutoSize = false,
				BorderStyle = BorderStyle.FixedSingle,
				Padding = new Padding(8, 6, 8, 6),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acx()
			};
			FlowLayoutPanel flowLayoutPanel3 = new FlowLayoutPanel
			{
				FlowDirection = FlowDirection.TopDown,
				WrapContents = false,
				AutoSize = false,
				Dock = DockStyle.Top,
				Margin = new Padding(0)
			};
			H_2 = B_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.oc());
			H_2.Click += delegate
			{
				H_m_1();
			};
			h_1 = B_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ob());
			h_1.Click += delegate
			{
				i_m_1();
			};
			J = B_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.np());
			J.Click += delegate
			{
				o();
			};
			D_2 = B_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ni());
			D_2.Click += delegate
			{
				L_m_1();
			};
			N = B_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acY());
			N.Click += delegate
			{
				a_m_1(true);
			};
			n = B_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acy());
			n.Click += delegate
			{
				n_m_1();
			};
			i = new CheckBox
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.rK(),
				AutoSize = false,
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acZ(),
				Margin = new Padding(2, 0, 2, 0),
				Font = A_m_1(10f, FontStyle.Regular)
			};
			i.CheckedChanged += delegate
			{
				if (A_7)
				{
					return;
				}
				A_7 = true;
				try
				{
					global::A.Y.A_m_1(A_34, i.Checked);
				}
				finally
				{
					A_7 = false;
				}
			};
			global::A.Y.AutoOpenFolderChanged += A_m_1;
			FormClosed += delegate
			{
				global::A.Y.AutoOpenFolderChanged -= A_m_1;
			};
			flowLayoutPanel3.Controls.Add(H_2);
			flowLayoutPanel3.Controls.Add(h_1);
			flowLayoutPanel3.Controls.Add(J);
			flowLayoutPanel3.Controls.Add(D_2);
			flowLayoutPanel3.Controls.Add(n);
			flowLayoutPanel3.Controls.Add(N);
			flowLayoutPanel3.Controls.Add(i);
			A_13.Controls.Add(flowLayoutPanel3);
			Controls.Add(A_13);
			A_13.BringToFront();
			Deactivate += delegate
			{
				E_m_1();
			};
			Resize += delegate
			{
				E_m_1();
				f_m_1();
			};
			A_15 = new global::b.w();
			A_15.Visible = false;
			A_15.SetLocationRequested += (string P_0) =>
			{
				A_3.Text = P_0;
				f_m_1();
				global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEv() + P_0);
			};
			A_15.RememberRequested += (string P_0, string P_1) =>
			{
				try
				{
					A_34.LastSearchKeyword = P_0;
					A_34.SearchBackend = P_1;
					global::A.Y.A_m_1(A_34);
				}
				catch
				{
				}
			};
			Controls.Add(A_15);
			A_15.BringToFront();
			A_22.SetToolTip(f_2, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acz());
			A_22.SetToolTip(j, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.RU());
			A_22.SetToolTip(M, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDA());
			A_22.SetToolTip(K, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDa());
			A_22.SetToolTip(G_2, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.pX());
			A_22.SetToolTip(D_2, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Pq());
			A_22.SetToolTip(N, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDB());
			A_22.SetToolTip(n, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDb());
			A_22.SetToolTip(m, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDC());
			A_22.SetToolTip(J, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Pr());
			A_22.SetToolTip(E_4, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.tK());
			A_22.SetToolTip(L, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.tv());
			A_22.SetToolTip(D_4, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.tw());
			A_22.SetToolTip(l, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.tx());
			A_22.SetToolTip(k, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDc());
			A_22.SetToolTip(i, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.rk()));
			A_22.SetToolTip(A_3, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDD());
			KeyPreview = true;
			KeyDown += (object P_0, KeyEventArgs P_1) =>
			{
				if (P_1.KeyCode == Keys.F1 && !A_32)
				{
					L_m_1();
					P_1.Handled = true;
				}
				if (P_1.KeyCode == Keys.Escape)
				{
					bool flag = false;
					if (A_15 != null && A_15.Visible)
					{
						f_m_1();
						flag = true;
					}
					if (A_13.Visible)
					{
						E_m_1();
						flag = true;
					}
					if (flag)
					{
						P_1.Handled = true;
					}
				}
			};
			g_m_1();
			ResumeLayout(performLayout: true);
		}

		private GroupBox A_m_1(string P_0)
		{
			return new GroupBox
			{
				Text = P_0,
				Dock = DockStyle.Fill,
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				Padding = new Padding(14, 28, 14, 12),
				Margin = new Padding(0, 0, 0, 12),
				Font = A_m_1(10.5f, FontStyle.Regular, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acL())
			};
		}

		private int b_m_1()
		{
			using Font font = A_m_1(10.5f, FontStyle.Regular, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acL());
			int num = 0;
			foreach (object item in a_4.Items)
			{
				num = Math.Max(num, TextRenderer.MeasureText(item.ToString(), font).Width);
			}
			return Math.Max(120, num + 42);
		}

		private TableLayoutPanel A_m_1(int P_0, int P_1)
		{
			TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
			{
				Dock = DockStyle.Fill,
				ColumnCount = P_0,
				RowCount = P_1,
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				Margin = new Padding(0)
			};
			for (int num = 0; num < P_1; num++)
			{
				tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			}
			return tableLayoutPanel;
		}

		private static Label a_m_1(string P_0)
		{
			return new Label
			{
				Text = P_0,
				AutoSize = true,
				Anchor = AnchorStyles.Left,
				Margin = new Padding(2, 9, 12, 9)
			};
		}

		private TextBox C_m_1()
		{
			return new TextBox
			{
				Dock = DockStyle.Fill,
				Font = A_m_1(10.5f, FontStyle.Regular, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acL()),
				Margin = new Padding(0, 5, 10, 5),
				BorderStyle = BorderStyle.FixedSingle
			};
		}

		private Button A_m_1(string P_0, int P_1, bool P_2 = false)
		{
			return new Button
			{
				Text = P_0,
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				MinimumSize = new Size(P_1, 38),
				Padding = new Padding(10, 0, 10, 0),
				Margin = new Padding(0, 0, 10, 0),
				FlatStyle = FlatStyle.Flat,
				UseVisualStyleBackColor = false,
				Font = A_m_1(P_2 ? 10.5f : 10f, P_2 ? FontStyle.Bold : FontStyle.Regular, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acL()),
				Cursor = Cursors.Hand
			};
		}

		private Button B_m_1(string P_0)
		{
			Font font = A_m_1(10f, FontStyle.Regular, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acL());
			int height = Math.Max(TextRenderer.MeasureText(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.MK(), font).Height + 12, 32);
			Button button = new Button();
			button.Text = P_0;
			button.AutoSize = false;
			button.MinimumSize = new Size(0, height);
			button.Height = height;
			button.Width = 170;
			button.Padding = new Padding(12, 0, 12, 0);
			button.Margin = new Padding(0, 0, 0, 6);
			button.TextAlign = ContentAlignment.MiddleLeft;
			button.FlatStyle = FlatStyle.Flat;
			button.UseVisualStyleBackColor = false;
			button.Font = font;
			button.Cursor = Cursors.Hand;
			button.Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acZ();
			button.FlatAppearance.BorderSize = 0;
			return button;
		}

		private void c_m_1()
		{
			if (A_13.Visible)
			{
				E_m_1();
			}
			else
			{
				D_m_1();
			}
		}

		private void D_m_1()
		{
			f_m_1();
			A_13.Visible = true;
			A_13.BringToFront();
			d_m_1();
			if (A_14 == null)
			{
				A_14 = new B(this);
			}
			Application.AddMessageFilter(A_14);
		}

		private void d_m_1()
		{
			if (A_13 == null)
			{
				return;
			}
			Control control = ((A_13.Controls.Count > 0) ? A_13.Controls[0] : null);
			if (control == null || control.Controls.Count == 0)
			{
				return;
			}
			Font font = A_m_1(10f, FontStyle.Regular, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acL());
			int num = Math.Max(TextRenderer.MeasureText(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.MK(), font).Height, font.Height);
			int val = 150;
			foreach (Control control4 in control.Controls)
			{
				int width = TextRenderer.MeasureText(control4.Text, control4.Font).Width;
				int num2 = ((control4 is CheckBox) ? 34 : (((Button)control4).Padding.Horizontal + 10));
				val = Math.Max(val, width + num2);
				int height = (control4.Height = ((control4 is CheckBox) ? Math.Max(num + 12, 30) : Math.Max(num + 12, 32)));
				control4.MinimumSize = new Size(0, height);
				control4.Margin = new Padding(0, 0, 0, 0);
			}
			int num4 = Math.Max(val, 150);
			int num5 = 0;
			int count = control.Controls.Count;
			for (int num6 = 0; num6 < count; num6++)
			{
				Control control3 = control.Controls[num6];
				control3.Width = num4;
				control3.Margin = new Padding(0, 0, 0, (num6 != count - 1) ? 6 : 0);
				num5 += control3.Height + control3.Margin.Top + control3.Margin.Bottom;
			}
			control.Height = num5;
			int num7 = num4 + A_13.Padding.Horizontal;
			int num8 = num5 + A_13.Padding.Vertical;
			A_13.Size = new Size(num7 + 2, num8 + 2);
			Point point = PointToClient(k.PointToScreen(new Point(0, 0)));
			int val2 = point.X + k.Width - A_13.Width;
			int val3 = point.Y - A_13.Height - 6;
			val2 = Math.Max(8, Math.Min(val2, ClientSize.Width - A_13.Width - 8));
			val3 = Math.Max(8, Math.Min(val3, ClientSize.Height - A_13.Height - 8));
			A_13.Location = new Point(val2, val3);
		}

		private void E_m_1()
		{
			if (A_13 != null && A_13.Visible)
			{
				A_13.Visible = false;
				if (A_14 != null)
				{
					Application.RemoveMessageFilter(A_14);
				}
			}
		}

		private void A_m_1(bool P_0)
		{
			if (i == null || i.IsDisposed)
			{
				return;
			}
			A_7 = true;
			try
			{
				i.Checked = P_0;
				if (A_34 != null)
				{
					A_34.OrganizeAutoOpenFolder = P_0;
				}
			}
			finally
			{
				A_7 = false;
			}
		}

		private void e_m_1()
		{
			if (A_32 || !global::b.G.A_m_1(this, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDd(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDE()))
			{
				return;
			}
			E_m_1();
			if (A_15 != null)
			{
				if (!A_15.Visible)
				{
					F_m_1();
				}
				string text = D_4.Text.Trim();
				if (text.Length == 0)
				{
					A_15.a_m_1(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Tj()));
					D_4.Focus();
				}
				else
				{
					A_15.B_m_1(text);
				}
			}
		}

		private void F_m_1()
		{
			E_m_1();
			if (D_4.Text.Length == 0 && !string.IsNullOrWhiteSpace(A_34.LastSearchKeyword))
			{
				D_4.Text = A_34.LastSearchKeyword;
			}
			A_15.A_m_1(A_3.Text.Trim());
			Point point = PointToClient(D_4.PointToScreen(Point.Empty));
			int num = Math.Max(8, point.X);
			int num2 = point.Y + D_4.Height + 5;
			int num3 = ClientSize.Width - num - 8;
			if (num3 < 360)
			{
				num = 8;
				num3 = ClientSize.Width - 16;
			}
			int width = Math.Min(Math.Max(480, D_4.Width), num3);
			int num4 = ClientSize.Height - num2 - 12;
			int num5 = Math.Max(140, Math.Min(430, num4));
			if (num5 > num4)
			{
				num5 = Math.Max(80, num4);
			}
			A_15.Size = new Size(width, num5);
			A_15.Location = new Point(num, num2);
			A_15.Visible = true;
			A_15.BringToFront();
			if (a_8 == null)
			{
				a_8 = new B(this);
			}
			Application.AddMessageFilter(a_8);
		}

		private void f_m_1()
		{
			if (A_15 != null && A_15.Visible)
			{
				A_15.a_m_1();
				A_15.Visible = false;
				if (a_8 != null)
				{
					Application.RemoveMessageFilter(a_8);
				}
			}
		}

		private void G_m_1()
		{
			if (A_12 != null)
			{
				A_12();
				return;
			}
			using global::b.v v2 = new global::b.v(A_33 ?? global::b.Y.A_m_1());
			v2.ShowDialog(this);
		}

		private CheckBox A_m_1(string P_0, bool P_1)
		{
			return new CheckBox
			{
				Text = P_0,
				Checked = P_1,
				AutoSize = true,
				Anchor = AnchorStyles.Left,
				Margin = new Padding(2, 6, 10, 6),
				FlatStyle = FlatStyle.Standard,
				Font = A_m_1(10.5f, FontStyle.Regular, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acL())
			};
		}

		private RadioButton a_m_1(string P_0, bool P_1)
		{
			return new RadioButton
			{
				Text = P_0,
				Checked = P_1,
				AutoSize = true,
				Margin = new Padding(2, 6, 10, 6),
				FlatStyle = FlatStyle.Standard,
				Font = A_m_1(10.5f, FontStyle.Regular, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acL())
			};
		}

		private void g_m_1()
		{
			bool enabled = C_2 == null || C_2.Checked;
			Control[] array = new Control[9] { A_11, a_6, B_6, b_4, C_4, B_1, b_1, B_2, C_5 };
			foreach (Control control in array)
			{
				if (control != null)
				{
					control.Enabled = enabled;
				}
			}
			if (a_4 != null)
			{
				bool enabled2 = !A_32 && c_1.Checked;
				a_4.Enabled = enabled2;
				if (c_5 != null)
				{
					c_5.Enabled = enabled2;
				}
			}
			if (A_10 != null)
			{
				A_10.Enabled = !A_32 && D_1.Checked;
			}
			if (A_39 != null)
			{
				A_39.Enabled = !A_32 && D_1.Checked;
			}
			if (B_4 != null)
			{
				B_4.Enabled = !A_32 && h.Checked;
			}
		}

		private void A_m_1(TextBox P_0)
		{
			using FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			folderBrowserDialog.Description = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.qE();
			folderBrowserDialog.ShowNewFolderButton = true;
			if (Directory.Exists(P_0.Text))
			{
				folderBrowserDialog.SelectedPath = P_0.Text;
			}
			if (folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
			{
				P_0.Text = folderBrowserDialog.SelectedPath;
			}
		}

		private void A_m_1(object P_0, DragEventArgs P_1)
		{
			if (P_1.Data.GetDataPresent(DataFormats.FileDrop) && P_1.Data.GetData(DataFormats.FileDrop) is string[] array && array.Length != 0 && Directory.Exists(array[0]))
			{
				P_1.Effect = DragDropEffects.Copy;
			}
			else
			{
				P_1.Effect = DragDropEffects.None;
			}
		}

		private void a_m_1(object P_0, DragEventArgs P_1)
		{
			if (P_1.Data.GetData(DataFormats.FileDrop) is string[] array && array.Length != 0)
			{
				if (Directory.Exists(array[0]))
				{
					A_3.Text = array[0];
					global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDe() + array[0]);
				}
				else
				{
					global::B.p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDF() + array[0]);
				}
			}
		}

		private void H_m_1()
		{
			A_35 = (global::b.y)((int)(A_35 + 1) % 3);
			if (A_34 != null)
			{
				A_34.ThemeMode = global::b.Z.A_m_1(A_35);
				A_34.Dark = A_35 == global::b.y.a;
				global::A.Y.A_m_1(A_34);
			}
			I_m_1();
			global::B.p.A_m_1(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.rX(), global::a.Q.A_m_1(h_m_1())));
		}

		private string h_m_1()
		{
			if (A_35 == global::b.y.a)
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.od();
			}
			if (A_35 == global::b.y.B)
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.oe();
			}
			return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.oc();
		}

		public void I_m_1()
		{
			A_33 = global::b.Z.a(A_35);
			D_6 = A_33.IsDark;
			global::b.Z.A_m_1(this, A_33, e_3);
			global::b.Z.A_m_1(A_24, A_33);
			if (A_15 != null)
			{
				A_15.A_m_1(A_33);
			}
			if (B_8 != null)
			{
				B_8.Invalidate();
			}
			j_m_1();
			R();
			A_m_1(A_19, A_20);
		}

		private void i_m_1()
		{
			if (global::a.Q.EnMode)
			{
				global::a.Q.Lang = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.HK();
			}
			else
			{
				global::a.Q.Lang = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Hk();
			}
			if (A_34 != null)
			{
				A_34.Lang = global::a.Q.Lang;
				global::A.Y.A_m_1(A_34);
			}
			J_m_1();
			global::B.p.A_m_1(global::a.Q.EnMode ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDG() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDf());
		}

		public void J_m_1()
		{
			global::a.Q.A_m_1(this);
			global::a.Q.A_m_1((A_24 != null) ? A_24.Items : null);
			global::a.Q.A_m_1(this, A_22);
			if (A_15 != null)
			{
				A_15.B_m_1();
			}
			if (a_4 != null)
			{
				a_4.Width = b_m_1();
			}
			j_m_1();
			d_m_1();
			if (!A_32)
			{
				A_18.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mK());
				A_m_1(A_19, A_20);
			}
			R();
		}

		private void j_m_1()
		{
			Text = (global::a.Q.EnMode ? (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDg() + global::A.r.c + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ls()) : (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abD() + global::A.r.TitleSuffix));
			if (b_5 != null)
			{
				b_5.Text = (global::a.Q.EnMode ? (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDH() + global::A.r.c + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ls()) : (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acp() + global::A.r.c + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Dr()));
			}
			if (H_2 != null)
			{
				H_2.Text = global::a.Q.A_m_1(h_m_1());
			}
			if (h_1 != null)
			{
				h_1.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ob());
			}
			if (B_8 != null)
			{
				A_22.SetToolTip(B_8, global::a.Q.EnMode ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acR() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acq());
			}
			if (A_23 != null)
			{
				A_23.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abD();
			}
			Q_m_1();
		}

		private void K_m_1()
		{
			try
			{
				if (!File.Exists(global::B.p.CurrentLogFile))
				{
					global::B.p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDh() + global::B.p.CurrentLogFile);
				}
				else
				{
					Process.Start(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDI(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDi() + global::B.p.CurrentLogFile + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JX());
				}
			}
			catch (Exception ex)
			{
				global::B.p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDJ() + ex.Message);
			}
		}

		private void k_m_1()
		{
			using global::b.p p2 = new global::b.p(A_33);
			p2.ShowDialog(this);
		}

		private void L_m_1()
		{
			using global::a.P p2 = new global::a.P(A_33);
			p2.ShowDialog(this);
		}

		private void l_m_1()
		{
			using X x2 = new X(A_33, A_3.Text.Trim(), a_1.Text.Trim(), A_34);
			x2.ShowDialog(this);
		}

		private void M_m_1()
		{
			if (!global::b.G.A_m_1(this, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jP(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.YR()))
			{
				return;
			}
			using global::a.H h2 = new global::a.H(A_33, A_34);
			h2.ShowDialog(this);
		}

		private void m_m_1()
		{
			if (!global::b.G.A_m_1(this, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ty(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDj()))
			{
				return;
			}
			using I i2 = new I(A_33, A_34, A_3.Text.Trim());
			i2.ShowDialog(this);
		}

		private void N_m_1()
		{
			if (!global::b.G.A_m_1(this, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDK(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDk()))
			{
				return;
			}
			using global::b.O o2 = new global::b.O(A_33, A_34);
			o2.ShowDialog(this);
		}

		private void n_m_1()
		{
			using global::C.F f2 = new global::C.F(A_34);
			if (f2.ShowDialog(this) == DialogResult.OK)
			{
				A_34.UpdateCheckMode = f2.SelectedMode;
				global::A.Y.A_m_1(A_34);
				global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDL() + ((f2.SelectedMode == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDl()) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDm() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDM()));
				if (f2.CheckRequested)
				{
					a_m_1(true);
				}
			}
		}

		private async void a_m_1(bool P_0)
		{
			if (a_7 || (!P_0 && !global::C.E.B_m_1((A_34 == null) ? null : A_34.UpdateCheckMode)) || global::a.j.DevSwitch(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNZ()) || global::a.j.DevSwitch(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JB()))
			{
				return;
			}
			a_7 = true;
			if (N != null)
			{
				N.Enabled = false;
			}
			global::C.D d2 = null;
			try
			{
				d2 = await Task.Run(() => global::C.E.A_m_1(P_0, CancellationToken.None));
			}
			catch (Exception ex)
			{
				d2 = new global::C.D
				{
					Error = ex.Message
				};
			}
			finally
			{
				a_7 = false;
				if (N != null && !N.IsDisposed)
				{
					N.Enabled = true;
				}
			}
			if (d2.Error != null)
			{
				global::B.p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNz() + d2.Error);
				if (A_22 != null && N != null && !N.IsDisposed)
				{
					A_22.SetToolTip(N, d2.Error + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alH());
				}
				if (P_0 && !IsDisposed)
				{
					MessageBox.Show(this, d2.Error + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anA(), global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alg()), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
			else if (global::C.E.A_m_1(d2.Info, A_34))
			{
				global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ana() + d2.Info.Version + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anB() + global::A.r.c + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ln() + (d2.FromCache ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anb() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()));
				if (!IsDisposed)
				{
					using (global::C.e e2 = new global::C.e(d2.Info, A_34, A_33))
					{
						e2.ShowDialog(this);
					}
				}
			}
			else if (P_0)
			{
				string text = ((d2.Info == null) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bE() : d2.Info.Version);
				string text2 = ((d2.Info != null && string.Equals(A_34.SkippedVersion, d2.Info.Version, StringComparison.OrdinalIgnoreCase)) ? global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anC()) : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
				MessageBox.Show(this, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anc(), global::A.r.c, text, text2), global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acY()), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		private void O()
		{
			global::a.j.B_m_1();
			Q_m_1();
			R();
			if (!global::a.j.Pro && I != null && I.Checked)
			{
				I.Checked = false;
			}
		}

		private void o()
		{
			if (a_12 != null)
			{
				a_12();
				return;
			}
			using (l l2 = new l(true))
			{
				l2.ShowDialog(this);
			}
			p();
		}

		private void P()
		{
			string text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDN();
			if (!b_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDn() + text + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDO()) && !b_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDo() + text + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDP()))
			{
				try
				{
					Clipboard.SetText(text);
				}
				catch
				{
				}
				string text2 = (global::a.Q.EnMode ? (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDQ() + text) : (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDp() + text));
				MessageBox.Show(this, text2, global::a.Q.EnMode ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDR() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDq(), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		private static bool b_m_1(string P_0)
		{
			try
			{
				Process.Start(new ProcessStartInfo
				{
					FileName = P_0,
					UseShellExecute = true
				});
				return true;
			}
			catch
			{
				return false;
			}
		}

		private void p()
		{
			if (!global::a.j.Active || global::a.j.IsForever)
			{
				Q_m_1();
				return;
			}
			int daysLeft = global::a.j.DaysLeft;
			if (daysLeft <= 15 && daysLeft >= 0 && a_14 != DateTime.Today)
			{
				a_14 = DateTime.Today;
				global::B.p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDr() + global::a.j.Current.Expiry.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CL()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDS() + daysLeft + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDs());
			}
			Q_m_1();
		}

		private void Q_m_1()
		{
			if (J == null)
			{
				return;
			}
			if (global::a.j.Licensed)
			{
				J.Text = (global::a.j.IsForever ? global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.nq()) : global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.nr(), global::a.j.DaysLeft));
			}
			else if (global::a.j.TrialActive)
			{
				J.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.tF(), global::a.j.TrialDaysLeft);
			}
			else
			{
				J.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.np());
			}
			A_22.SetToolTip(J, global::a.j.StatusText + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDT() + global::B.J.Formatted + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDt());
			if (E_4 == null)
			{
				return;
			}
			if (!global::a.j.Licensed && !global::a.j.TrialActive)
			{
				E_4.Text = global::a.Q.A_m_1(global::a.j.TrialExpired ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDu() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDU());
				E_4.Font = A_m_1(9.5f, FontStyle.Regular, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acL());
				if (A_33 != null)
				{
					E_4.ForeColor = A_33.I;
				}
			}
			else if (global::a.j.TrialActive)
			{
				E_4.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.tE(), global::a.j.TrialDaysLeft);
				E_4.Font = A_m_1(9.5f, FontStyle.Bold, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acL());
				if (A_33 != null)
				{
					E_4.ForeColor = A_33.f;
				}
			}
			else
			{
				string text = (global::a.j.IsForever ? null : global::a.j.Current.Expiry.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CL()));
				if (global::a.j.IsForever)
				{
					E_4.Text = global::a.Q.A_m_1(global::a.j.Pro ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.tA() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.tB());
				}
				else
				{
					E_4.Text = (global::a.j.Pro ? global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.tC(), text) : global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.tD(), text));
				}
				E_4.Font = A_m_1(9.5f, FontStyle.Regular, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acL());
				if (A_33 != null)
				{
					E_4.ForeColor = A_33.j;
				}
			}
			A_22.SetToolTip(E_4, global::a.j.StatusText + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDT() + global::B.J.Formatted + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDV());
		}

		private void q()
		{
			using global::A.F f2 = new global::A.F(A_34, A_33);
			if (f2.ShowDialog(this) == DialogResult.OK)
			{
				global::A.x result = f2.Result;
				A_34.AiEnabled = result.AiEnabled;
				A_34.AiBaseUrl = result.AiBaseUrl;
				A_34.AiApiKey = result.AiApiKey;
				A_34.AiModel = result.AiModel;
				A_34.AiTimeoutSec = result.AiTimeoutSec;
				A_34.AiMaxGroups = result.AiMaxGroups;
				A_34.AiPriceInPerMillion = result.AiPriceInPerMillion;
				A_34.AiPriceOutPerMillion = result.AiPriceOutPerMillion;
				A_34.AiAutoRun = result.AiAutoRun;
				A_34.AiAutoApply = result.AiAutoApply;
				I.Checked = result.AiEnabled;
				global::A.Y.A_m_1(A_34);
				R();
				global::B.p.A_m_1(result.AiEnabled ? (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDW() + result.AiModel + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.IF() + global::A.E.A_m_1(result.AiBaseUrl) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ln()) : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDv());
			}
		}

		private void R()
		{
			if (d_4 == null)
			{
				return;
			}
			if (E_2 != null)
			{
				E_2.Visible = !global::a.j.Pro;
			}
			if (!global::a.j.Pro)
			{
				d_4.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDw());
				d_4.ForeColor = A_33.f;
				return;
			}
			d_4.ForeColor = A_33.I;
			if (I == null || !I.Checked)
			{
				d_4.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.RA());
				return;
			}
			if (!global::A.E.A_m_1(A_34))
			{
				d_4.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDX());
				return;
			}
			d_4.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDx(), A_34.AiModel, A_34.AiMaxGroups);
		}

		private global::A.x r()
		{
			global::A.x x2 = A_34.A_m_1();
			x2.AiEnabled = I != null && I.Checked && global::a.j.Pro;
			return x2;
		}

		private void C_m_1(string P_0 = null)
		{
			string text = P_0 ?? a_13;
			d_5 = true;
			try
			{
				B_5.Items.Clear();
				if (A_34.Profiles != null)
				{
					foreach (string item in A_34.Profiles.Keys.OrderBy((string result) => result, StringComparer.OrdinalIgnoreCase).ToList())
					{
						B_5.Items.Add(item);
					}
				}
				B_5.DropDownStyle = ComboBoxStyle.DropDownList;
				if (text != null && B_5.Items.Contains(text))
				{
					B_5.SelectedItem = text;
					a_13 = text;
				}
				else
				{
					B_5.SelectedIndex = -1;
					a_13 = null;
				}
			}
			finally
			{
				d_5 = false;
			}
			S();
		}

		private void S()
		{
			if (D_5 != null)
			{
				int num = ((A_34.Profiles != null) ? A_34.Profiles.Count : 0);
				string text = ((num == 0) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adA() : (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDY() + num + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDy() + ((a_13 == null) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDz() : (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDZ() + a_13))));
				D_5.Text = text;
			}
		}

		private global::A.x s()
		{
			a_m_1(A_34);
			return A_34.A_m_1();
		}

		private void T()
		{
			string text = a_13 ?? (B_5.SelectedItem as string);
			if (string.IsNullOrWhiteSpace(text))
			{
				t();
			}
			else if (!c_m_1(text))
			{
				t();
			}
			else
			{
				D_m_1(text);
			}
		}

		private void t()
		{
			global::A.x x2 = s();
			string text = U();
			string text2 = global::b.f.A_m_1(this, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ada(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adB(), text, A_33, A_34.Profiles.Keys);
			if (!string.IsNullOrWhiteSpace(text2) && (!A_34.Profiles.ContainsKey(text2) || c_m_1(text2)))
			{
				x2.SavedAt = DateTime.Now.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.q());
				A_34.Profiles[text2] = x2;
				d_m_1(text2);
				global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adb() + text2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adC() + A_34.Profiles.Count + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adc());
			}
		}

		private bool c_m_1(string P_0)
		{
			if (A_34.Profiles == null || !A_34.Profiles.ContainsKey(P_0))
			{
				return true;
			}
			return MessageBox.Show(this, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adD() + P_0 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.add(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adE(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
		}

		private void D_m_1(string P_0)
		{
			global::A.x x2 = s();
			x2.SavedAt = DateTime.Now.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.q());
			A_34.Profiles[P_0] = x2;
			d_m_1(P_0);
			global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ade() + P_0 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adF());
		}

		private void d_m_1(string P_0)
		{
			A_34.LastProfile = P_0;
			global::A.Y.A_m_1(A_34);
			C_m_1(P_0);
			S();
		}

		private string U()
		{
			int num = ((A_34.Profiles != null) ? A_34.Profiles.Count : 0) + 1;
			string text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adf() + num;
			while (A_34.Profiles.ContainsKey(text))
			{
				text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adf() + ++num;
			}
			return text;
		}

		private void u()
		{
			global::A.x x2 = s();
			using global::b.F f2 = new global::b.F(A_34.Profiles, x2, A_33);
			f2.ShowDialog(this);
			if (f2.Changed)
			{
				A_34.LastProfile = f2.AppliedName ?? A_34.LastProfile;
				global::A.Y.A_m_1(A_34);
				global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adG() + A_34.Profiles.Count + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adg());
			}
			C_m_1(f2.AppliedName ?? a_13);
			if (!string.IsNullOrEmpty(f2.AppliedName))
			{
				E_m_1(f2.AppliedName);
			}
		}

		private void E_m_1(string P_0)
		{
			if (!string.IsNullOrEmpty(P_0) && A_34.Profiles != null && A_34.Profiles.ContainsKey(P_0))
			{
				global::A.x x2 = A_34.Profiles[P_0];
				A_34.Source = x2.Source;
				A_34.Target = x2.Target;
				A_34.SpecDir = x2.SpecDir;
				A_34.Keyword = x2.Keyword;
				A_34.Whitelist = x2.Whitelist;
				A_34.Step1 = x2.Step1;
				A_34.Step2 = x2.Step2;
				A_34.Step3 = x2.Step3;
				A_34.Step4 = x2.Step4;
				A_34.Step5 = x2.Step5;
				A_34.HashDedup = x2.HashDedup;
				A_34.HashKeep = x2.HashKeep;
				A_34.ImageDedup = x2.ImageDedup;
				A_34.ImageThreshold = x2.ImageThreshold;
				A_34.ImageKeep = x2.ImageKeep;
				A_34.AudioDedup = x2.AudioDedup;
				A_34.AudioToleranceSec = x2.AudioToleranceSec;
				A_34.Hardlink = x2.Hardlink;
				A_34.CleanEmptyDirs = x2.CleanEmptyDirs;
				A_34.PreviewScan = x2.PreviewScan;
				A_34.DryRun = x2.DryRun;
				A_34.MinSizeKB = x2.MinSizeKB;
				A_34.ExcludeFolders = x2.ExcludeFolders;
				A_34.SkipHidden = x2.SkipHidden;
				A_34.Conflict = x2.Conflict;
				A_34.DeleteMode = x2.DeleteMode;
				A_34.Mode = x2.Mode;
				A_34.AutoReleaseLock = x2.AutoReleaseLock;
				A_34.SuspectConfirm = x2.SuspectConfirm;
				A_34.NameScorePreset = x2.NameScorePreset;
				A_34.LastProfile = P_0;
				A_m_1(A_34);
				a_13 = P_0;
				if (B_5 != null && !d_5)
				{
					C_m_1(P_0);
				}
				S();
				global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adH() + P_0);
			}
		}

		private void V()
		{
			if (A_32)
			{
				return;
			}
			if (!global::a.j.A_m_1(this, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adh(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adI()))
			{
				global::B.p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adi());
				return;
			}
			string text = A_3.Text.Trim().Trim('"');
			string text2 = a_1.Text.Trim().Trim('"');
			if (!Directory.Exists(text))
			{
				MessageBox.Show(this, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.sq()), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bB(), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			string pathRoot = Path.GetPathRoot(Path.GetFullPath(text));
			if (string.Equals(Path.GetFullPath(text).TrimEnd('\\'), pathRoot.TrimEnd('\\'), StringComparison.OrdinalIgnoreCase))
			{
				MessageBox.Show(this, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.sr()), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bB(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if (C_2.Checked)
			{
				if (text2.Length == 0 || !Directory.Exists(text2))
				{
					MessageBox.Show(this, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ss()), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bB(), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				if (string.Equals(Path.GetFullPath(text).TrimEnd('\\'), Path.GetFullPath(text2).TrimEnd('\\'), StringComparison.OrdinalIgnoreCase))
				{
					MessageBox.Show(this, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.hq()), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bB(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				if (global::a.a.A(text2, text, false))
				{
					MessageBox.Show(this, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.sU()), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bB(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
			}
			global::b.d d2 = A_m_1(text, text2);
			if (g_1.Checked && (d2.d_f_1 || d2.E || d2.f))
			{
				A_m_1(d2);
			}
			else
			{
				a_m_1(d2);
			}
		}

		private void A_m_1(global::b.d P_0)
		{
			A_31 = new CancellationTokenSource();
			A_32 = true;
			B_m_1(true);
			A_m_1(A.a, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Oj()));
			A_18.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.QU());
			A_17.Value = 0;
			CancellationToken A_1 = A_31.Token;
			Task.Run(() =>
			{
				global::b.R R_result = null;
				Exception A_2 = null;
				try
				{
					R_result = global::b.r.A_m_1(P_0, A_1, A_m_1);
				}
				catch (Exception ex)
				{
					A_2 = ex;
				}
				A_m_1(() =>
				{
					if (A_1.IsCancellationRequested)
					{
						int num = ((R_result != null) ? R_result.A_1.Count : 0);
						int num2 = ((R_result != null) ? R_result.A_2 : 0);
						global::B.p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNT() + num + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNt() + num2);
						A_32 = false;
						B_m_1(false);
						A_m_1(A.b, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
						A_18.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mK());
						A_17.Value = 0;
					}
					else
					{
						if (A_2 == null)
						{
							A_m_1(A.B, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ne(), R_result.A_2));
							A_18.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.SV(), R_result.A_1.Count);
							A_17.Value = 0;
							using global::b.P p2 = new global::b.P(R_result, A_33, r());
							if (p2.ShowDialog(this) == DialogResult.OK && p2.B_2)
							{
								P_0.A_8 = p2.A_12 ?? new Dictionary<string, string>();
								P_0.A_9 = p2.A_13;
								if (!p2.a_4)
								{
									P_0.A_1 = (P_0.a_1 = (P_0.B_1 = (P_0.b_1 = (P_0.C_1 = false))));
									global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNU());
								}
								else
								{
									global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNu());
								}
								A_32 = false;
								a_m_1(P_0);
							}
							else
							{
								global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNV());
								A_32 = false;
								B_m_1(false);
								A_m_1(A.b, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
								A_18.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mK();
								A_17.Value = 0;
							}
							return;
						}
						global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Oj(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHp(), P_0.A, A_2.Message, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf());
						A_32 = false;
						B_m_1(false);
						A_m_1(A.C, A_2.Message);
						A_18.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mK());
					}
				});
			});
		}

		private void a_m_1(global::b.d P_0)
		{
			A_31 = new CancellationTokenSource();
			A_32 = true;
			B_m_1(true);
			A_m_1(A.a, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lJ()));
			A_18.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.QU());
			A_36 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			A_17.Value = 0;
			CancellationToken A_2 = A_31.Token;
			Task.Run(() =>
			{
				bool flag = true;
				int count_found = 0;
				try
				{
					count_found = global::b.e.B_m_1(P_0.A).Count;
				}
				catch (Exception ex)
				{
					global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Oj(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNv(), this.A_3.Text, ex.Message, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf());
				}
				P_0.A_7 = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
				c_6 = P_0.g;
				if (P_0.B_1 && count_found > 0)
				{
					try
					{
						V A2 = global::B.v.A(P_0);
						if (A2.a.Count > 0 && P_0.g)
						{
							HashSet<string> hashSet = A_m_1(() =>
							{
								using global::b.X x2 = new global::b.X(A2, A_33);
								x2.ShowDialog(this);
								return new HashSet<string>(x2.a, StringComparer.OrdinalIgnoreCase);
							});
							if (hashSet != null)
							{
								P_0.A_7 = hashSet;
							}
						}
						else if (A2.a.Count > 0)
						{
							global::B.p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNW() + A2.a.Count + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNw());
						}
					}
					catch (Exception ex2)
					{
						global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNX(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNx(), P_0.A, ex2.Message, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf());
					}
				}
				if (!P_0.c_1 && count_found > 0)
				{
					flag = A_m_1(() =>
					{
						string text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNy(), count_found, global::a.Q.A_m_1(A_m_1(P_0.A_2)), global::a.Q.A_m_1((P_0.A_3 == global::a.A.A_f_1) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.sZ() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ci()));
						return MessageBox.Show(this, text, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.sX()), MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK;
					});
				}
				if (!flag)
				{
					global::B.p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNY() + count_found);
					A_m_1(() =>
					{
						A_32 = false;
						B_m_1(false);
						A_m_1(A.b, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
						A_18.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mK();
					});
					return;
				}
				global::b.E A_3 = null;
				Exception A_4 = null;
				try
				{
					global::b.e e2 = new global::b.e(P_0)
					{
						A_7 = A_m_1
					};
					A_3 = e2.A_m_1(A_2);
				}
				catch (Exception ex3)
				{
					Exception ex4 = (A_4 = ex3);
					global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahn(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lJ(), P_0.A, ex4.Message, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf());
				}
				finally
				{
					A_m_1(() =>
					{
						bool isCancellationRequested = A_2.IsCancellationRequested;
						int num = ((A_3 != null) ? (A_3.A + A_3.a + A_3.B + A_3.D + A_3.d + A_3.F + A_3.f + A_3.C + A_3.c + A_3.b) : 0);
						A_32 = false;
						B_m_1(false);
						A_17.Value = 0;
						if (isCancellationRequested)
						{
							string text = (string.IsNullOrWhiteSpace(A_36) ? global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lJ()) : A_36);
							global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahn(), text, num, count_found);
							A_m_1(A.b, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
							A_18.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mK());
						}
						else
						{
							if (A_4 != null)
							{
								A_m_1(A.C, A_4.Message);
							}
							else
							{
								A_m_1(A.B, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.nd(), num));
							}
							A_18.Text = ((A_3 != null && A_3.A_1) ? global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.SX()) : global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mK()));
							F_m_1((A_3 != null) ? A_3.ToString() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.rp());
							A_m_1(A_3, A_4);
						}
					});
				}
			});
		}

		private void A_m_1(global::b.E P_0, Exception P_1)
		{
			v();
			string A_1 = W();
			if (P_1 == null && P_0 != null && !P_0.A_1 && A_m_1(P_0) && A_34 != null && A_34.OrganizeAutoOpenFolder && A_1 != null)
			{
				e_m_1(A_1);
				return;
			}
			string text;
			if (P_1 != null)
			{
				text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.rM();
			}
			else
			{
				text = ((P_0 != null && P_0.A_1) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.rn() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.rl());
			}
			string text2;
			if (P_1 != null)
			{
				text2 = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.rN()) + P_1.Message;
			}
			else
			{
				text2 = ((P_0 != null) ? P_0.A_m_1() : global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.rp()));
			}
			if (P_0 != null && P_0.A_1)
			{
				text2 = text2 + Environment.NewLine + global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ro());
			}
			if (P_0 != null && P_0.g > 0)
			{
				text2 = text2 + Environment.NewLine + (c_6 ? global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.YN(), P_0.g) : global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.YO(), P_0.g));
			}
			X.A A_2 = new X.A(A_33, global::a.Q.A_m_1(text), text2, (A_1 == null) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D() : (global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.rq()) + A_1), () =>
			{
				e_m_1(A_1);
			});
			A_8 = A_2;
			A_2.FormClosed += delegate
			{
				if (A_8 == A_2)
				{
					A_8 = null;
				}
			};
			A_2.Show(this);
		}

		private static bool A_m_1(global::b.E P_0)
		{
			if (P_0 != null)
			{
				return P_0.A + P_0.a + P_0.B + P_0.C + P_0.D + P_0.d + P_0.F + P_0.f + P_0.E_f_1 > 0;
			}
			return false;
		}

		private void v()
		{
			X.A a2 = A_8;
			A_8 = null;
			if (a2 != null && !a2.IsDisposed)
			{
				a2.Close();
				a2.Dispose();
			}
		}

		private string W()
		{
			string text = (A_3.Text ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).Trim().Trim('"');
			string text2 = (a_1.Text ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).Trim().Trim('"');
			if (C_2 != null && C_2.Checked && !string.IsNullOrWhiteSpace(text2) && Directory.Exists(global::a.a.A(text2)))
			{
				return text2;
			}
			if (!string.IsNullOrWhiteSpace(text) && Directory.Exists(global::a.a.A(text)))
			{
				return text;
			}
			return null;
		}

		private void e_m_1(string P_0)
		{
			if (string.IsNullOrWhiteSpace(P_0))
			{
				return;
			}
			if (A_9 != null)
			{
				A_9(P_0);
				return;
			}
			try
			{
				Process.Start(new ProcessStartInfo(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDI(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JX() + P_0 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JX())
				{
					UseShellExecute = true
				});
				global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adJ() + P_0);
			}
			catch (Exception ex)
			{
				global::B.p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adj() + ex.Message);
				MessageBox.Show(this, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.TX(), ex.Message), global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bB()), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private global::b.d A_m_1(string P_0, string P_1)
		{
			return new global::b.d
			{
				A = P_0,
				a = P_1,
				A_1 = A_5.Checked,
				a_1 = a_3.Checked,
				B_1 = B_3.Checked,
				b_1 = b_2.Checked,
				C_1 = C_2.Checked,
				A_2 = (D_3.Checked ? global::b.D.a : (d_3.Checked ? global::b.D.B : global::b.D.A)),
				A_3 = (e_2.Checked ? global::a.A.a : global::a.A.A_f_1),
				c_1 = E_1.Checked,
				D = e_1.Checked,
				g = f_1.Checked,
				B_2 = Math.Max(0, A_6.SelectedIndex),
				A_4 = A_m_1,
				d_f_1 = c_1.Checked,
				D_1 = ((a_4.SelectedItem as string) ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.cA()),
				E = D_1.Checked,
				A_5 = (int)A_10.Value,
				h_2 = ((A_39.SelectedItem as string) ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aia()),
				f = h.Checked,
				a_2 = (int)B_4.Value,
				G = H_1.Checked,
				e = d_1.Checked,
				C = C_1.Text.Trim(),
				A_6 = (long)a_5.Value * 1024,
				d_f_2 = c_2.Text.Trim(),
				F = G_1.Checked,
				c = (A_11.Checked ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.hF() : (a_6.Checked ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.hB() : (B_6.Checked ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.hC() : (b_4.Checked ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.hD() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.he())))),
				B = B_1.Text.Trim(),
				b = b_1.Text.Trim()
			};
		}

		private static string A_m_1(global::b.D P_0)
		{
			return P_0 switch
			{
				global::b.D.a => _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adK(), 
				global::b.D.B => _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adk(), 
				_ => _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adL(), 
			};
		}

		private void w()
		{
			if (A_32 || !global::a.j.A_m_1(this, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.nf(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adl()))
			{
				return;
			}
			string A = global::B.w.A_m_1();
			if (A == null)
			{
				MessageBox.Show(this, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.sW()), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adM(), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			bool A_1 = F_1.Checked;
			string text = (global::a.Q.EnMode ? (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ado() + A + (A_1 ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adp() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adP()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adQ()) : (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adm() + A + (A_1 ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adn() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adN()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adO()));
			if (MessageBox.Show(this, text, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.nf()), MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) != DialogResult.OK)
			{
				return;
			}
			A_32 = true;
			B_m_1(true);
			A_m_1(Q.A.a, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.nc()));
			CancellationToken A_2 = CancellationToken.None;
			Task.Run(() =>
			{
				w.A A2 = null;
				try
				{
					A2 = global::B.w.A_m_1(A, A_1, A_2);
				}
				catch (Exception ex)
				{
					global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGO(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.nc(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(), ex.Message, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf());
				}
				finally
				{
					A_m_1(() =>
					{
						A_32 = false;
						B_m_1(false);
						if (A2 != null)
						{
							A_m_1(Q.A.B, A2.A_m_1());
						}
						else
						{
							A_m_1(Q.A.C, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.SY()));
						}
					});
				}
			});
		}

		private void A_m_1(A P_0, string P_1)
		{
			A_19 = P_0;
			A_20 = P_1 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			A_21 = DateTime.UtcNow;
			if (a_9 != null)
			{
				string text;
				Color foreColor;
				switch (P_0)
				{
				case A.a:
					text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adq();
					foreColor = A_33.i;
					break;
				case A.B:
					text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adR();
					foreColor = A_33.j;
					break;
				case A.b:
					text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adr();
					foreColor = A_33.I;
					break;
				case A.C:
					text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adS();
					foreColor = A_33.J;
					break;
				default:
					text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ads();
					foreColor = A_33.I;
					break;
				}
				string text2 = P_0 switch
				{
					A.a => global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.NX()) + (string.IsNullOrWhiteSpace(A_20) ? global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.nB()) : A_20), 
					A.B => string.IsNullOrWhiteSpace(A_20) ? global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.NY()) : (global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.NY()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bH() + A_20), 
					A.C => global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.NZ()) + (string.IsNullOrWhiteSpace(A_20) ? global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.nA()) : A_20), 
					A.b => global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jt()), 
					_ => global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mK()), 
				};
				a_9.ForeColor = foreColor;
				a_9.Text = text + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aH() + text2;
			}
		}

		private void X()
		{
			if (A_31 != null && !A_31.IsCancellationRequested)
			{
				A_31.Cancel();
				A_m_1(A.a, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Nv()));
				global::B.p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adT());
			}
		}

		private bool A_m_1(string P_0, List<N> P_1)
		{
			if (A_38 != null)
			{
				return A_38(P_0, P_1);
			}
			if (IsDisposed || !IsHandleCreated)
			{
				return false;
			}
			try
			{
				return Invoke(() =>
				{
					using o o2 = new o(A_33, P_0, P_1);
					return o2.ShowDialog(this) == DialogResult.OK;
				});
			}
			catch
			{
				return false;
			}
		}

		private void B_m_1(bool P_0)
		{
			e_3.Enabled = !P_0;
			F_2.Enabled = P_0;
			f_2.Enabled = !P_0;
			j.Enabled = !P_0;
			M.Enabled = !P_0;
			K.Enabled = !P_0;
			G_2.Enabled = !P_0;
			D_2.Enabled = !P_0;
			g_2.Enabled = !P_0;
			i_1.Enabled = !P_0;
			A_4.Enabled = !P_0;
			a_2.Enabled = !P_0;
			B_2.Enabled = !P_0 && C_2.Checked;
			CheckBox checkBox = A_5;
			CheckBox checkBox2 = a_3;
			CheckBox checkBox3 = B_3;
			CheckBox checkBox4 = b_2;
			bool flag = (C_2.Enabled = !P_0);
			bool flag3 = (checkBox4.Enabled = flag);
			bool flag5 = (checkBox3.Enabled = flag3);
			bool enabled = (checkBox2.Enabled = flag5);
			checkBox.Enabled = enabled;
			CheckBox checkBox5 = c_1;
			CheckBox checkBox6 = D_1;
			CheckBox checkBox7 = d_1;
			flag3 = (E_1.Enabled = !P_0);
			flag5 = (checkBox7.Enabled = flag3);
			enabled = (checkBox6.Enabled = flag5);
			checkBox5.Enabled = enabled;
			CheckBox checkBox8 = G_1;
			CheckBox checkBox9 = g_1;
			CheckBox checkBox10 = H_1;
			flag3 = (h.Enabled = !P_0);
			flag5 = (checkBox10.Enabled = flag3);
			enabled = (checkBox9.Enabled = flag5);
			checkBox8.Enabled = enabled;
			CheckBox checkBox11 = I;
			enabled = (d_2.Enabled = !P_0);
			checkBox11.Enabled = enabled;
			NumericUpDown numericUpDown = a_5;
			enabled = (B_4.Enabled = !P_0);
			numericUpDown.Enabled = enabled;
			c_2.Enabled = !P_0;
			ComboBox comboBox = B_5;
			Button button = b_3;
			Button button2 = C_3;
			flag3 = (c_3.Enabled = !P_0);
			flag5 = (button2.Enabled = flag3);
			enabled = (button.Enabled = flag5);
			comboBox.Enabled = enabled;
			C_1.Enabled = !P_0;
			RadioButton radioButton = c_4;
			RadioButton radioButton2 = D_3;
			flag5 = (d_3.Enabled = !P_0);
			enabled = (radioButton2.Enabled = flag5);
			radioButton.Enabled = enabled;
			RadioButton radioButton3 = E_3;
			enabled = (e_2.Enabled = !P_0);
			radioButton3.Enabled = enabled;
			e_1.Enabled = !P_0;
			if (F_1 != null)
			{
				F_1.Enabled = !P_0;
			}
			TextBox textBox = A_3;
			enabled = (a_1.Enabled = !P_0);
			textBox.Enabled = enabled;
			if (P_0)
			{
				RadioButton radioButton4 = A_11;
				RadioButton radioButton5 = a_6;
				RadioButton radioButton6 = B_6;
				RadioButton radioButton7 = b_4;
				flag = (C_4.Enabled = false);
				flag3 = (radioButton7.Enabled = flag);
				flag5 = (radioButton6.Enabled = flag3);
				enabled = (radioButton5.Enabled = flag5);
				radioButton4.Enabled = enabled;
				TextBox textBox2 = B_1;
				enabled = (b_1.Enabled = false);
				textBox2.Enabled = enabled;
				ComboBox comboBox2 = a_4;
				enabled = (A_10.Enabled = false);
				comboBox2.Enabled = enabled;
				if (A_39 != null)
				{
					A_39.Enabled = false;
				}
			}
			else
			{
				g_m_1();
				TextBox textBox3 = B_1;
				TextBox textBox4 = b_1;
				RadioButton radioButton8 = A_11;
				RadioButton radioButton9 = a_6;
				RadioButton radioButton10 = B_6;
				RadioButton radioButton11 = b_4;
				bool flag29 = (C_4.Enabled = C_2.Checked);
				bool flag31 = (radioButton11.Enabled = flag29);
				flag = (radioButton10.Enabled = flag31);
				flag3 = (radioButton9.Enabled = flag);
				flag5 = (radioButton8.Enabled = flag3);
				enabled = (textBox4.Enabled = flag5);
				textBox3.Enabled = enabled;
				A_10.Enabled = D_1.Checked;
				if (A_39 != null)
				{
					A_39.Enabled = D_1.Checked;
				}
				B_4.Enabled = h.Checked;
				a_4.Enabled = c_1.Checked;
			}
		}

		private void A_m_1(MethodInvoker P_0)
		{
			try
			{
				if (!IsDisposed && IsHandleCreated)
				{
					if (InvokeRequired)
					{
						BeginInvoke(P_0);
					}
					else
					{
						P_0();
					}
				}
			}
			catch
			{
			}
		}

		private A A_m_1<A>(Func<A> P_0)
		{
			try
			{
				if (IsDisposed || !IsHandleCreated)
				{
					return default;
				}
				if (InvokeRequired)
				{
					return Invoke(P_0);
				}
				return P_0();
			}
			catch
			{
				return default;
			}
		}

		protected override void OnResize(EventArgs P_0)
		{
			base.OnResize(P_0);
			if (!b_7 && WindowState == FormWindowState.Minimized && A_23 != null && A_23.Visible)
			{
				aA();
			}
		}

		private void A_m_1(object P_0, FormClosingEventArgs P_1)
		{
			if (B_10 || P_1.CloseReason != CloseReason.UserClosing)
			{
				Y();
				return;
			}
			if (A_32 && ((A_26 != null) ? A_26(this) : MessageBox.Show(this, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.oo()), global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.oQ()), MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)) != DialogResult.Yes)
			{
				P_1.Cancel = true;
				return;
			}
			if (A_34 != null && !A_34.ClosePrompt)
			{
				if (A_34.CloseRememberToTray && A_23 != null && A_23.Visible)
				{
					P_1.Cancel = true;
					aA();
				}
				else
				{
					x();
					Y();
				}
				return;
			}
			bool flag = false;
			global::A.u u2 = ((A_27 != null) ? A_27(this, A_33, out flag) : global::A.V.A_m_1(this, A_33, out flag));
			if (flag)
			{
				A_34.ClosePrompt = false;
				A_34.CloseRememberToTray = u2 == global::A.u.a;
				global::A.Y.A_m_1(A_34);
			}
			switch (u2)
			{
			case global::A.u.a:
				P_1.Cancel = true;
				aA();
				break;
			case global::A.u.A:
				P_1.Cancel = true;
				break;
			default:
				x();
				Y();
				break;
			}
		}

		private void x()
		{
			if (A_31 != null)
			{
				try
				{
					A_31.Cancel();
				}
				catch
				{
				}
			}
		}

		private void Y()
		{
			ab();
			A_30.Stop();
			if (a_15 != null)
			{
				a_15.Stop();
			}
			aB();
		}

		private void y()
		{
			A_25 = new ToolStripMenuItem(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.of());
			A_25.Click += delegate
			{
				z();
			};
			a_11 = new ToolStripMenuItem(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.og());
			a_11.Click += delegate
			{
				aA();
			};
			B_9 = new ToolStripMenuItem(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.oJ());
			B_9.CheckOnClick = true;
			B_9.Click += delegate
			{
				b_m_1(B_9.Checked);
			};
			b_6 = new ToolStripMenuItem(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.oh());
			b_6.CheckOnClick = true;
			b_6.Click += delegate
			{
				C_m_1(b_6.Checked);
			};
			C_6 = new ToolStripMenuItem(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.oi());
			C_6.Click += delegate
			{
				aa();
			};
			A_24 = new ContextMenuStrip();
			A_24.Items.AddRange(new ToolStripItem[7]
			{
				A_25,
				a_11,
				new ToolStripSeparator(),
				B_9,
				b_6,
				new ToolStripSeparator(),
				C_6
			});
			A_24.Opening += delegate
			{
				A_25.Enabled = !Visible;
				a_11.Enabled = Visible;
				B_9.Checked = A_34 != null && A_34.ClosePrompt;
				b_6.Checked = A_34 != null && A_34.TrayBalloon;
			};
			A_23 = new NotifyIcon
			{
				Icon = global::A.R.A_m_1(),
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abD(),
				Visible = true,
				ContextMenuStrip = A_24
			};
			A_23.DoubleClick += delegate
			{
				z();
			};
			A_23.BalloonTipClicked += delegate
			{
				z();
			};
		}

		private void Z()
		{
			if (A_23 == null)
			{
				return;
			}
			try
			{
				A_23.Icon = global::A.R.A_m_1();
			}
			catch
			{
			}
		}

		public void z()
		{
			if (IsDisposed)
			{
				return;
			}
			b_7 = true;
			try
			{
				ShowInTaskbar = true;
				if (!Visible)
				{
					Show();
				}
				if (WindowState == FormWindowState.Minimized)
				{
					WindowState = FormWindowState.Normal;
				}
				Activate();
				BringToFront();
			}
			finally
			{
				b_7 = false;
			}
		}

		public void aA()
		{
			if (A_23 != null && A_23.Visible)
			{
				Hide();
				if (!C_7)
				{
					C_7 = true;
					a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.om(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.on());
				}
			}
		}

		private void a_m_1(string P_0, string P_1)
		{
			if (A_23 == null || !A_23.Visible)
			{
				return;
			}
			try
			{
				A_23.BalloonTipTitle = global::a.Q.A_m_1(P_0);
				A_23.BalloonTipText = global::a.Q.A_m_1(P_1);
				A_23.BalloonTipIcon = ToolTipIcon.Info;
				A_23.ShowBalloonTip(3000);
			}
			catch
			{
			}
		}

		public void aa()
		{
			if (A_32)
			{
				if (((A_26 != null) ? A_26(this) : MessageBox.Show(this, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.oo()), global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.oQ()), MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)) != DialogResult.Yes)
				{
					return;
				}
				x();
			}
			B_10 = true;
			Close();
		}

		private void aB()
		{
			if (A_23 != null)
			{
				try
				{
					A_23.Visible = false;
					A_23.Dispose();
				}
				catch
				{
				}
				A_23 = null;
			}
		}

		private void b_m_1(bool P_0)
		{
			if (A_34 != null)
			{
				A_34.ClosePrompt = P_0;
				if (!P_0)
				{
					A_34.CloseRememberToTray = false;
				}
				global::A.Y.A_m_1(A_34);
				global::B.p.A_m_1(P_0 ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adU() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adt());
			}
		}

		private void C_m_1(bool P_0)
		{
			if (A_34 != null)
			{
				A_34.TrayBalloon = P_0;
				global::A.Y.A_m_1(A_34);
				global::B.p.A_m_1(P_0 ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adV() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adu());
			}
		}

		private void F_m_1(string P_0)
		{
			if (A_34 != null && A_34.TrayBalloon && A_23 != null && A_23.Visible && !Visible)
			{
				a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abD(), P_0 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adv());
			}
		}

		private void A_m_1(global::A.x P_0)
		{
			A_3.Text = P_0.Source;
			a_1.Text = P_0.Target;
			B_1.Text = P_0.SpecDir;
			b_1.Text = P_0.Keyword;
			C_1.Text = P_0.Whitelist;
			A_5.Checked = P_0.Step1;
			a_3.Checked = P_0.Step2;
			B_3.Checked = P_0.Step3;
			b_2.Checked = P_0.Step4;
			C_2.Checked = P_0.Step5;
			c_1.Checked = P_0.HashDedup;
			if (P_0.HashKeep >= 0 && P_0.HashKeep < a_4.Items.Count)
			{
				a_4.SelectedIndex = P_0.HashKeep;
			}
			D_1.Checked = P_0.ImageDedup;
			A_10.Value = Math.Max(A_10.Minimum, Math.Min(A_10.Maximum, P_0.ImageThreshold));
			// C-15：旧配置没有该键时 ImageKeep 为 0，等价“体积最大”，行为与升级前一致。
			A_39.SelectedIndex = Math.Max(0, Math.Min(A_39.Items.Count - 1, P_0.ImageKeep));
			d_1.Checked = P_0.CleanEmptyDirs;
			g_1.Checked = P_0.PreviewScan;
			I.Checked = P_0.AiEnabled;
			R();
			H_1.Checked = P_0.Hardlink;
			h.Checked = P_0.AudioDedup;
			B_4.Value = Math.Max(B_4.Minimum, Math.Min(B_4.Maximum, P_0.AudioToleranceSec));
			a_5.Value = Math.Max(a_5.Minimum, Math.Min(a_5.Maximum, P_0.MinSizeKB));
			c_2.Text = P_0.ExcludeFolders ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			G_1.Checked = P_0.SkipHidden;
			c_4.Checked = P_0.Conflict == 0;
			D_3.Checked = P_0.Conflict == 1;
			d_3.Checked = P_0.Conflict == 2;
			E_3.Checked = P_0.DeleteMode == 0;
			e_2.Checked = P_0.DeleteMode == 1;
			E_1.Checked = P_0.DryRun;
			e_1.Checked = P_0.AutoReleaseLock;
			F_1.Checked = P_0.UndoRestoreRecycle;
			f_1.Checked = P_0.SuspectConfirm;
			A_6.SelectedIndex = Math.Max(0, Math.Min(2, P_0.NameScorePreset));
			if (i != null)
			{
				A_7 = true;
				try
				{
					i.Checked = P_0.OrganizeAutoOpenFolder;
				}
				finally
				{
					A_7 = false;
				}
			}
			A_11.Checked = P_0.Mode == 0;
			a_6.Checked = P_0.Mode == 4;
			B_6.Checked = P_0.Mode == 1;
			b_4.Checked = P_0.Mode == 2;
			C_4.Checked = P_0.Mode == 3;
			if (P_0.WinW >= MinimumSize.Width && P_0.WinH >= MinimumSize.Height)
			{
				ClientSize = new Size(P_0.WinW, P_0.WinH);
			}
		}

		private void ab()
		{
			try
			{
				global::A.x x2 = A_34 ?? new global::A.x();
				x2.Source = A_3.Text;
				x2.Target = a_1.Text;
				x2.SpecDir = B_1.Text;
				x2.Keyword = b_1.Text;
				x2.Whitelist = C_1.Text;
				x2.Step1 = A_5.Checked;
				x2.Step2 = a_3.Checked;
				x2.Step3 = B_3.Checked;
				x2.Step4 = b_2.Checked;
				x2.Step5 = C_2.Checked;
				x2.HashDedup = c_1.Checked;
				x2.HashKeep = a_4.SelectedIndex;
				x2.ImageDedup = D_1.Checked;
				x2.ImageThreshold = (int)A_10.Value;
				x2.ImageKeep = A_39.SelectedIndex;
				x2.CleanEmptyDirs = d_1.Checked;
				x2.Conflict = (D_3.Checked ? 1 : (d_3.Checked ? 2 : 0));
				x2.DeleteMode = (e_2.Checked ? 1 : 0);
				x2.AutoReleaseLock = e_1.Checked;
				x2.UndoRestoreRecycle = F_1.Checked;
				x2.SuspectConfirm = f_1.Checked;
				x2.NameScorePreset = Math.Max(0, A_6.SelectedIndex);
				x2.OrganizeAutoOpenFolder = i != null && i.Checked;
				x2.DryRun = E_1.Checked;
				x2.Mode = (a_6.Checked ? 4 : (B_6.Checked ? 1 : (b_4.Checked ? 2 : (C_4.Checked ? 3 : 0))));
				x2.Dark = D_6;
				x2.ThemeMode = global::b.Z.A_m_1(A_35);
				x2.Lang = global::a.Q.Lang;
				x2.AiEnabled = I != null && I.Checked;
				x2.LastProfile = a_13 ?? x2.LastProfile;
				x2.WinW = ClientSize.Width;
				x2.WinH = ClientSize.Height;
				x2.MinSizeKB = (long)a_5.Value;
				x2.ExcludeFolders = c_2.Text;
				x2.SkipHidden = G_1.Checked;
				x2.Hardlink = H_1.Checked;
				x2.AudioDedup = h.Checked;
				x2.AudioToleranceSec = (int)B_4.Value;
				x2.PreviewScan = g_1.Checked;
				global::A.Y.A_m_1(x2);
			}
			catch
			{
			}
		}

		private void a_m_1(global::A.x P_0)
		{
			try
			{
				P_0.Source = A_3.Text;
				P_0.Target = a_1.Text;
				P_0.SpecDir = B_1.Text;
				P_0.Keyword = b_1.Text;
				P_0.Whitelist = C_1.Text;
				P_0.Step1 = A_5.Checked;
				P_0.Step2 = a_3.Checked;
				P_0.Step3 = B_3.Checked;
				P_0.Step4 = b_2.Checked;
				P_0.Step5 = C_2.Checked;
				P_0.HashDedup = c_1.Checked;
				P_0.HashKeep = a_4.SelectedIndex;
				P_0.ImageDedup = D_1.Checked;
				P_0.ImageThreshold = (int)A_10.Value;
				P_0.ImageKeep = A_39.SelectedIndex;
				P_0.CleanEmptyDirs = d_1.Checked;
				P_0.Conflict = (D_3.Checked ? 1 : (d_3.Checked ? 2 : 0));
				P_0.DeleteMode = (e_2.Checked ? 1 : 0);
				P_0.AutoReleaseLock = e_1.Checked;
				P_0.UndoRestoreRecycle = F_1.Checked;
				P_0.SuspectConfirm = f_1.Checked;
				P_0.NameScorePreset = Math.Max(0, A_6.SelectedIndex);
				P_0.OrganizeAutoOpenFolder = i != null && i.Checked;
				P_0.DryRun = E_1.Checked;
				P_0.Mode = (a_6.Checked ? 4 : (B_6.Checked ? 1 : (b_4.Checked ? 2 : (C_4.Checked ? 3 : 0))));
				P_0.MinSizeKB = (long)a_5.Value;
				P_0.ExcludeFolders = c_2.Text;
				P_0.SkipHidden = G_1.Checked;
				P_0.Hardlink = H_1.Checked;
				P_0.AudioDedup = h.Checked;
				P_0.AudioToleranceSec = (int)B_4.Value;
				P_0.PreviewScan = g_1.Checked;
				P_0.AiEnabled = I != null && I.Checked;
			}
			catch
			{
			}
		}

		private void A_m_1(string P_0, P P_1)
		{
			A_29.Enqueue(new KeyValuePair<string, P>(P_0, P_1));
		}

		private void A_m_1(string P_0, int P_1, int P_2, string P_3)
		{
			A_36 = P_0;
			A_37 = P_1;
			a_17 = P_2;
			a_16 = P_3 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
		}

		private void A_m_1(object P_0, EventArgs P_1)
		{
			if (!A_29.IsEmpty)
			{
				int num = 0;
				KeyValuePair<string, P> result;
				while (num++ < 300 && A_29.TryDequeue(out result))
				{
					if (A_16.TextLength == 0)
					{
						A_16.SelectionStart = 0;
						A_16.SelectionLength = 0;
						A_16.SelectionColor = A_m_1(result.Value);
						A_16.AppendText(result.Key);
					}
					else
					{
						A_16.SelectionStart = A_16.TextLength;
						A_16.SelectionLength = 0;
						A_16.SelectionColor = A_m_1(result.Value);
						A_16.AppendText(Environment.NewLine + result.Key);
					}
				}
				int num2 = A_16.Lines.Length;
				if (num2 > 800)
				{
					int firstCharIndexFromLine = A_16.GetFirstCharIndexFromLine(num2 - 800);
					if (firstCharIndexFromLine > 0)
					{
						A_16.ReadOnly = false;
						A_16.Select(0, firstCharIndexFromLine);
						A_16.SelectedText = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
						A_16.ReadOnly = true;
					}
				}
				A_16.SelectionStart = A_16.TextLength;
				A_16.SelectionLength = 0;
				A_16.ScrollToCaret();
			}
			if (!string.IsNullOrEmpty(A_36) && a_17 > 0)
			{
				int num3 = (int)Math.Min(1000L, (long)A_37 * 1000L / a_17);
				if (A_17.Value != num3)
				{
					A_17.Value = num3;
				}
				string text = global::a.Q.A_m_1(A_36) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.o() + A_37 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Dv() + a_17;
				if (!string.IsNullOrEmpty(a_16))
				{
					text = text + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adW() + a_16;
				}
				if (A_18.Text != text)
				{
					A_18.Text = text;
				}
			}
			if (A_19 != A.a)
			{
				return;
			}
			if (A_32 && !string.IsNullOrEmpty(A_36))
			{
				string text2 = global::a.Q.A_m_1(A_36);
				if (text2 != A_20)
				{
					A_m_1(A.a, text2);
				}
			}
			else if (!A_32 && (DateTime.UtcNow - A_21).TotalSeconds >= 1.5)
			{
				A_m_1(A.A_f_1, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
			}
		}

		private Color A_m_1(P P_0)
		{
			return P_0 switch
			{
				global::B.P.a => A_33.i, 
				global::B.P.B => A_33.J, 
				_ => A_33.h, 
			};
		}

		private static List<string> aC()
		{
			List<string> list = new List<string>();
			try
			{
				Version version = Environment.OSVersion.Version;
				string text;
				if (version.Build >= 22000)
				{
					text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adx();
				}
				else
				{
					text = ((version.Major == 10) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adX() : (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adw() + version.Major));
				}
				list.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adY() + text + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ady() + version.Build + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Q() + (Environment.Is64BitOperatingSystem ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adz() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adZ()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ln());
			}
			catch
			{
				list.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEA());
			}
			list.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEa() + RuntimeInformation.FrameworkDescription + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.IF() + RuntimeInformation.ProcessArchitecture.ToString() + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ln());
			list.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEB() + AppDomain.CurrentDomain.BaseDirectory);
			list.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEb() + global::B.p.LogDir);
			list.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acM() + global::B.p.OpsDir);
			list.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEC() + global::A.Y.FilePath);
			try
			{
				string path = Path.Combine(global::B.p.LogDir, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEc());
				File.WriteAllText(path, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aED());
				File.Delete(path);
				list.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEd());
			}
			catch (Exception ex)
			{
				list.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEE() + ex.Message + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ln());
			}
			try
			{
				string pathRoot = Path.GetPathRoot(AppDomain.CurrentDomain.BaseDirectory);
				if (!string.IsNullOrEmpty(pathRoot))
				{
					DriveInfo driveInfo = new DriveInfo(pathRoot);
					if (driveInfo.IsReady)
					{
						list.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEe() + pathRoot + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.IQ() + ((double)driveInfo.AvailableFreeSpace / 1024.0 / 1024.0 / 1024.0).ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.w()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bf());
					}
				}
			}
			catch
			{
			}
			try
			{
				string text2 = Path.Combine(Path.GetTempPath(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEF() + Guid.NewGuid().ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.cL()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lm());
				File.WriteAllText(global::a.a.A(text2), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEf());
				bool flag = global::b.h.A_m_1(text2);
				if (File.Exists(global::a.a.A(text2)))
				{
					File.Delete(global::a.a.A(text2));
				}
				List<string> list2 = list;
				string text3 = (global::a.Q.EnMode ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEg() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEG());
				string text4;
				if (flag)
				{
					text4 = (global::a.Q.EnMode ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEi() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEI());
				}
				else
				{
					text4 = (global::a.Q.EnMode ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEh() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEH());
				}
				list2.Add(text3 + text4);
			}
			catch
			{
				list.Add(global::a.Q.EnMode ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEj() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEJ());
			}
			try
			{
				bool flag2 = global::a.a.A();
				string text5 = Path.Combine(global::B.p.LogDir, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEK() + Guid.NewGuid().ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.cL()).Substring(0, 6));
				string text6 = text5;
				for (int num = 0; num < 10; num++)
				{
					text6 = Path.Combine(text6, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEk() + num);
				}
				string text7 = Path.Combine(text6, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEL());
				int length = text7.Length;
				string text8;
				try
				{
					Directory.CreateDirectory(global::a.a.A(text6));
					File.WriteAllText(global::a.a.A(text7), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aED());
					if (File.Exists(global::a.a.A(text7)))
					{
						text8 = (global::a.Q.EnMode ? (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEn() + length + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEO()) : (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEm() + length + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEN()));
					}
					else
					{
						text8 = (global::a.Q.EnMode ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEM() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEl());
					}
				}
				catch (Exception ex2)
				{
					text8 = (global::a.Q.EnMode ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEP() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEo()) + ex2.Message;
				}
				finally
				{
					global::a.a.e(text5, text5);
				}
				string text9;
				if (flag2)
				{
					text9 = (global::a.Q.EnMode ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aER() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEq());
				}
				else
				{
					text9 = (global::a.Q.EnMode ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEQ() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEp());
				}
				list.Add(text9 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.DG() + text8);
			}
			catch (Exception ex3)
			{
				list.Add((global::a.Q.EnMode ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aES() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEr()) + ex3.Message);
			}
			list.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEs());
			return list;
		}

		[CompilerGenerated]
		private void a_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			O();
		}

		[CompilerGenerated]
		private void A_m_1(object? _003Cp0_003E, DpiChangedEventArgs P_1)
		{
			Z();
		}

		[CompilerGenerated]
		private void B_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			a_m_1(false);
		}

		[CompilerGenerated]
		private void b_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			PerformLayout();
		}

		[CompilerGenerated]
		private void A_m_1(object P_0, PaintEventArgs P_1)
		{
			global::b.Y y2 = A_33 ?? global::b.Y.A_m_1();
			P_1.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			Rectangle rectangle = new Rectangle(0, 0, B_8.Width - 1, B_8.Height - 1);
			using (SolidBrush brush = new SolidBrush(y2.f))
			{
				P_1.Graphics.FillEllipse(brush, rectangle);
			}
			using (Pen pen = new Pen(y2.g, 1f))
			{
				P_1.Graphics.DrawEllipse(pen, rectangle);
			}
			TextRenderer.DrawText(P_1.Graphics, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aET(), A_m_1(8f, FontStyle.Bold, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acL()), rectangle, y2.G, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);
		}

		[CompilerGenerated]
		private void C_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			P();
		}

		[CompilerGenerated]
		private void c_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			o();
		}

		[CompilerGenerated]
		private void D_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			e_m_1();
		}

		[CompilerGenerated]
		private void A_m_1(object P_0, KeyEventArgs P_1)
		{
			if (P_1.KeyCode == Keys.Return)
			{
				P_1.SuppressKeyPress = true;
				e_m_1();
			}
		}

		[CompilerGenerated]
		private void d_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			G_m_1();
		}

		[CompilerGenerated]
		private void E_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			A_m_1(A_3);
		}

		[CompilerGenerated]
		private void e_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			A_m_1(a_1);
		}

		[CompilerGenerated]
		private void F_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			g_m_1();
		}

		[CompilerGenerated]
		private void f_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			g_m_1();
		}

		[CompilerGenerated]
		private void G_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			g_m_1();
		}

		[CompilerGenerated]
		private void g_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			g_m_1();
		}

		[CompilerGenerated]
		private void H_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			if (I.Checked && !global::a.j.Pro)
			{
				I.Checked = false;
				global::b.G.A_m_1(this, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEt(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEU());
				R();
				return;
			}
			R();
			if (I.Checked && I.Focused && !global::A.E.A_m_1(A_34))
			{
				q();
			}
		}

		[CompilerGenerated]
		private void h_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			if (global::b.G.A_m_1(this, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEu(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEV()))
			{
				q();
			}
		}

		[CompilerGenerated]
		private void I_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			if (global::a.j.a_m_1(this))
			{
				R();
			}
		}

		[CompilerGenerated]
		private void i_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			if (global::b.G.A_m_1(this, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEt(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEU()))
			{
				R();
			}
		}

		[CompilerGenerated]
		private void J_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			T();
		}

		[CompilerGenerated]
		private void j_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			t();
		}

		[CompilerGenerated]
		private void K_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			u();
		}

		[CompilerGenerated]
		private void k_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			if (d_5)
			{
				return;
			}
			d_5 = true;
			try
			{
				E_m_1(B_5.SelectedItem as string);
			}
			finally
			{
				d_5 = false;
			}
		}

		[CompilerGenerated]
		private void L_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			A_m_1(B_1);
		}

		[CompilerGenerated]
		private void l_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			l_m_1();
		}

		[CompilerGenerated]
		private void M_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			M_m_1();
		}

		[CompilerGenerated]
		private void m_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			A_22.SetToolTip(A_18, A_18.Text);
		}

		[CompilerGenerated]
		private void N_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			A_22.SetToolTip(a_9, a_9.Text);
		}

		[CompilerGenerated]
		private void n_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			V();
		}

		[CompilerGenerated]
		private void O(object? _003Cp0_003E, EventArgs P_1)
		{
			X();
		}

		[CompilerGenerated]
		private void o(object? _003Cp0_003E, EventArgs P_1)
		{
			w();
		}

		[CompilerGenerated]
		private void P(object? _003Cp0_003E, EventArgs P_1)
		{
			m_m_1();
		}

		[CompilerGenerated]
		private void p(object? _003Cp0_003E, EventArgs P_1)
		{
			N_m_1();
		}

		[CompilerGenerated]
		private void Q_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			k_m_1();
		}

		[CompilerGenerated]
		private void q(object? _003Cp0_003E, EventArgs P_1)
		{
			K_m_1();
		}

		[CompilerGenerated]
		private void R(object? _003Cp0_003E, EventArgs P_1)
		{
			A_16.Clear();
		}

		[CompilerGenerated]
		private void r(object? _003Cp0_003E, EventArgs P_1)
		{
			c_m_1();
		}

		[CompilerGenerated]
		private void S(object? _003Cp0_003E, EventArgs P_1)
		{
			H_m_1();
		}

		[CompilerGenerated]
		private void s(object? _003Cp0_003E, EventArgs P_1)
		{
			i_m_1();
		}

		[CompilerGenerated]
		private void T(object? _003Cp0_003E, EventArgs P_1)
		{
			o();
		}

		[CompilerGenerated]
		private void t(object? _003Cp0_003E, EventArgs P_1)
		{
			L_m_1();
		}

		[CompilerGenerated]
		private void U(object? _003Cp0_003E, EventArgs P_1)
		{
			a_m_1(true);
		}

		[CompilerGenerated]
		private void u(object? _003Cp0_003E, EventArgs P_1)
		{
			n_m_1();
		}

		[CompilerGenerated]
		private void V(object? _003Cp0_003E, EventArgs P_1)
		{
			if (A_7)
			{
				return;
			}
			A_7 = true;
			try
			{
				global::A.Y.A_m_1(A_34, i.Checked);
			}
			finally
			{
				A_7 = false;
			}
		}

		[CompilerGenerated]
		private void A_m_1(object? _003Cp0_003E, FormClosedEventArgs P_1)
		{
			global::A.Y.AutoOpenFolderChanged -= A_m_1;
		}

		[CompilerGenerated]
		private void v(object? _003Cp0_003E, EventArgs P_1)
		{
			E_m_1();
		}

		[CompilerGenerated]
		private void W(object? _003Cp0_003E, EventArgs P_1)
		{
			E_m_1();
			f_m_1();
		}

		[CompilerGenerated]
		private void f_m_1(string P_0)
		{
			A_3.Text = P_0;
			f_m_1();
			global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEv() + P_0);
		}

		[CompilerGenerated]
		private void B_m_1(string P_0, string P_1)
		{
			try
			{
				A_34.LastSearchKeyword = P_0;
				A_34.SearchBackend = P_1;
				global::A.Y.A_m_1(A_34);
			}
			catch
			{
			}
		}

		[CompilerGenerated]
		private void a_m_1(object P_0, KeyEventArgs P_1)
		{
			if (P_1.KeyCode == Keys.F1 && !A_32)
			{
				L_m_1();
				P_1.Handled = true;
			}
			if (P_1.KeyCode == Keys.Escape)
			{
				bool flag = false;
				if (A_15 != null && A_15.Visible)
				{
					f_m_1();
					flag = true;
				}
				if (A_13.Visible)
				{
					E_m_1();
					flag = true;
				}
				if (flag)
				{
					P_1.Handled = true;
				}
			}
		}

		[CompilerGenerated]
		private void w(object? _003Cp0_003E, EventArgs P_1)
		{
			z();
		}

		[CompilerGenerated]
		private void X(object? _003Cp0_003E, EventArgs P_1)
		{
			aA();
		}

		[CompilerGenerated]
		private void x(object? _003Cp0_003E, EventArgs P_1)
		{
			b_m_1(B_9.Checked);
		}

		[CompilerGenerated]
		private void Y(object? _003Cp0_003E, EventArgs P_1)
		{
			C_m_1(b_6.Checked);
		}

		[CompilerGenerated]
		private void y(object? _003Cp0_003E, EventArgs P_1)
		{
			aa();
		}

		[CompilerGenerated]
		private void A_m_1(object? _003Cp0_003E, CancelEventArgs P_1)
		{
			A_25.Enabled = !Visible;
			a_11.Enabled = Visible;
			B_9.Checked = A_34 != null && A_34.ClosePrompt;
			b_6.Checked = A_34 != null && A_34.TrayBalloon;
		}

		[CompilerGenerated]
		private void Z(object? _003Cp0_003E, EventArgs P_1)
		{
			z();
		}

		[CompilerGenerated]
		private void z(object? _003Cp0_003E, EventArgs P_1)
		{
			z();
		}
	}
	public sealed class q : ComboBox
	{
		[CompilerGenerated]
		private Color A = global::b.Y.A_m_1().d;

		public Color BorderColor
		{
			[CompilerGenerated]
			get
			{
				return A;
			}
			[CompilerGenerated]
			set
			{
				A = value;
			}
		}

		protected override void WndProc(ref Message P_0)
		{
			base.WndProc(ref P_0);
			if (P_0.Msg != 15)
			{
				return;
			}
			try
			{
				using Pen pen = new Pen(BorderColor);
				using Graphics graphics = CreateGraphics();
				graphics.DrawRectangle(pen, 0, 0, Width - 1, Height - 1);
			}
			catch
			{
			}
		}
	}
}
namespace b
{
	public sealed class Q
	{
		public string A;

		public long A_1;

		public DateTime A_2;

		public bool A_3;

		public bool a = true;

		public global::A.Z A_4;
	}
	public sealed class q
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class A
		{
			public static readonly A A_f_1 = new A();

			public static Func<Q, long> A_f_2;

			public static Func<Q, long> a;

			internal long A_m_1(Q P_0)
			{
				return P_0.A_1;
			}

			internal long a_m_1(Q P_0)
			{
				return P_0.A_1;
			}
		}

		public string A_1;

		public string a;

		public string B;

		public List<Q> A_2 = new List<Q>();

		public long WastedBytes
		{
			get
			{
				long num = A_2.Sum((Q P_0) => P_0.A_1);
				if (A_2.Count <= 1)
				{
					return 0L;
				}
				return num - A_2.Max((Q P_0) => P_0.A_1);
			}
		}
	}
}
