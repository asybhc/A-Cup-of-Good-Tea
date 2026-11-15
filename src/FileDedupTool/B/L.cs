using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007B1262ED64_002DD0A6_002D499E_002D9510_002DF2240F018DBB_007D;
using A;
using C;
using Microsoft.CSharp.RuntimeBinder;
using a;
using b;

namespace B
{
	public static class L
	{
		public const string A = "MFkwEwYHKoZIzj0CAQYIKoZIzj0DAQcDQgAEnoZ/chqgxBdKJIPvLE68X8fDdre1Y1t+PCnyCbVF3BF7x3o0FH5/V37jZWwB1DYd9tBpyCiF3cjnH+CqSvBPWQ==";

		public const int A_1 = 64;

		public static string A_m_1(string P_0)
		{
			if (string.IsNullOrEmpty(P_0))
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}
			StringBuilder stringBuilder = new StringBuilder(P_0.Length);
			for (int num = 0; num < P_0.Length; num++)
			{
				char c2 = char.ToUpperInvariant(P_0[num]);
				switch (c2)
				{
				case 'I':
				case 'L':
					c2 = '1';
					break;
				case 'O':
					c2 = '0';
					break;
				}
				if ((c2 >= '0' && c2 <= '9') || (c2 >= 'A' && c2 <= 'Z'))
				{
					stringBuilder.Append(c2);
				}
			}
			return stringBuilder.ToString();
		}

		public static string a(string P_0)
		{
			string text = A_m_1(P_0);
			StringBuilder stringBuilder = new StringBuilder(text.Length + text.Length / 4);
			for (int num = 0; num < text.Length; num++)
			{
				if (num > 0 && num % 4 == 0)
				{
					stringBuilder.Append('-');
				}
				stringBuilder.Append(text[num]);
			}
			return stringBuilder.ToString();
		}

		public static ECDsa b(string P_0)
		{
			ECDsa eCDsa = ECDsa.Create();
			eCDsa.ImportSubjectPublicKeyInfo(Convert.FromBase64String(C(P_0)), out var _);
			return eCDsa;
		}

		private static string C(string P_0)
		{
			if (P_0 == null)
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}
			StringBuilder stringBuilder = new StringBuilder(P_0.Length);
			foreach (char c2 in P_0)
			{
				if (!char.IsWhiteSpace(c2) && c2 != '\r' && c2 != '\n')
				{
					stringBuilder.Append(c2);
				}
			}
			return stringBuilder.ToString();
		}

		public static j A_m_1(string P_0, out bool P_1)
		{
			P_1 = false;
			byte[] array = i.A_m_1(A_m_1(P_0));
			if (array == null || array.Length < 81)
			{
				return null;
			}
			int num = array.Length - 64;
			if (num != 18 && num != 17)
			{
				return null;
			}
			P_1 = true;
			return j.A_m_1(array, 0, num);
		}

		public static k A_m_1(string P_0, byte[] P_1, DateTime P_2, string P_3)
		{
			k k2 = new k();
			string text = (k2.A_1 = A_m_1(P_0));
			if (text.Length == 0)
			{
				k2.A = K.a;
				k2.a = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBV();
				return k2;
			}
			byte[] array = i.A_m_1(text);
			if (array == null)
			{
				k2.A = K.B;
				k2.a = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBv();
				return k2;
			}
			int num = array.Length - 64;
			if (num != 18 && num != 17)
			{
				bool flag = array.Length == 78;
				k2.A = (flag ? K.D : K.B);
				k2.a = (flag ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBW() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBv());
				return k2;
			}
			byte[] array2 = new byte[num];
			byte[] array3 = new byte[64];
			Buffer.BlockCopy(array, 0, array2, 0, num);
			Buffer.BlockCopy(array, num, array3, 0, 64);
			k2.A_2 = j.A_m_1(array, 0, num);
			bool flag2 = false;
			try
			{
				using ECDsa eCDsa = b(P_3);
				flag2 = eCDsa.VerifyData(array2, array3, HashAlgorithmName.SHA256, DSASignatureFormat.IeeeP1363FixedFieldConcatenation);
			}
			catch
			{
				flag2 = false;
			}
			if (!flag2)
			{
				k2.A = K.b;
				k2.a = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBw();
				return k2;
			}
			if (k2.A_2.b_1 != 2)
			{
				k2.A = K.D;
				k2.a = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBX() + (byte)2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBx();
				return k2;
			}
			if (k2.A_2.a_2 != 20261101)
			{
				k2.A = K.D;
				k2.a = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBY() + k2.A_2.a_2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBy() + 20261101u + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBZ();
				return k2;
			}
			if (P_1 != null && P_1.Length == 10)
			{
				for (int num2 = 0; num2 < 10; num2++)
				{
					if (P_1[num2] != k2.A_2.A_4[num2])
					{
						k2.A = K.C;
						k2.a = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBz() + k2.A_2.MachineCode + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abA() + i.A_m_1(P_1) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aba();
						return k2;
					}
				}
			}
			if (!k2.A_2.IsForever && P_2.Date > k2.A_2.Expiry)
			{
				k2.A = K.c;
				k2.a = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abB() + k2.A_2.Expiry.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CL()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abb();
				return k2;
			}
			k2.A = K.A;
			k2.a = (k2.A_2.IsForever ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abc() : (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abC() + k2.A_2.Expiry.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CL()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.hP()));
			return k2;
		}

		public static k c(string P_0)
		{
			return A_m_1(P_0, J.Id, DateTime.Now, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lw());
		}
	}
	public sealed class l : Form
	{
		[CompilerGenerated]
		private sealed class A
		{
			public bool A_f_1;

			public bool a;

			public l A_f_2;

			internal void A_m_1(object P_0, FormClosingEventArgs P_1)
			{
				if (!A_f_1 && !a && !global::a.j.Active && A_f_2.DialogResult != DialogResult.OK)
				{
					A_f_2.DialogResult = DialogResult.Cancel;
				}
			}
		}

		private readonly global::b.Y A_1;

		private readonly bool A_2;

		private readonly bool a;

		private readonly string A_3;

		private readonly string a_1;

		private Label A_4;

		private Label a_2;

		private Label B;

		private Label b;

		private Label C;

		private Label c;

		private Label D;

		private Label d;

		private TextBox A_5;

		private TextBox a_3;

		private TextBox B_1;

		private FlowLayoutPanel A_6;

		private Button A_7;

		private Button a_4;

		private Button B_2;

		private Button b_1;

		private Button C_1;

		private Button c_1;

		private Button D_1;

		private Button d_1;

		private Button E;

		public l()
			: this(false, false, null, null)
		{
		}

		public l(bool P_0)
			: this(P_0, false, null, null)
		{
		}

		public l(bool P_0, bool P_1)
			: this(P_0, P_1, null, null)
		{
		}

		public l(bool P_0, bool P_1, string P_2, string P_3)
		{
			l A_f_2 = this;
			global::A.x x2 = null;
			try
			{
				x2 = global::A.Y.A_m_1();
			}
			catch
			{
			}
			global::b.y y2 = ((x2 != null) ? global::b.Z.A_m_1(x2.ThemeMode) : global::b.y.A);
			if (x2 != null && x2.Dark && y2 == global::b.y.A)
			{
				y2 = global::b.y.a;
			}
			A_1 = global::b.Z.a(y2);
			A_2 = P_0;
			a = P_1;
			A_3 = P_2;
			a_1 = P_3;
			bool flag = !P_0 && !P_1 && !string.IsNullOrEmpty(P_2);
			if (P_1)
			{
				Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.RO()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abD();
			}
			else if (flag)
			{
				Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abd()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abE();
			}
			else
			{
				Text = (P_0 ? global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.RH()) : global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.RG())) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abE();
			}
			StartPosition = ((!(P_0 | P_1)) ? FormStartPosition.CenterScreen : FormStartPosition.CenterParent);
			Icon = global::A.R.App;
			Font = Q.A_m_1(10f);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(780, 720);
			MinimumSize = new Size(700, 640);
			BackColor = A_1.A;
			ForeColor = A_1.b;
			MaximizeBox = false;
			MinimizeBox = false;
			ShowInTaskbar = !(P_0 | P_1);
			A_m_1();
			global::b.Z.A_m_1(this, A_1, c_1);
			global::a.Q.A_m_1(this);
			a_m_1();
			FormClosing += delegate
			{
				if (!P_0 && !P_1 && !global::a.j.Active && A_f_2.DialogResult != DialogResult.OK)
				{
					A_f_2.DialogResult = DialogResult.Cancel;
				}
			};
		}

		private void A_m_1()
		{
			TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
			{
				Dock = DockStyle.Fill,
				ColumnCount = 1,
				RowCount = 15,
				Padding = new Padding(20, 16, 20, 14),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jp()
			};
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			for (int num = 0; num < 15; num++)
			{
				tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			}
			tableLayoutPanel.RowStyles[13] = new RowStyle(SizeType.Percent, 100f);
			Controls.Add(tableLayoutPanel);
			string text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.RG();
			if (a)
			{
				text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.OE();
			}
			else if (A_2)
			{
				text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.RH();
			}
			else if (!string.IsNullOrEmpty(A_3))
			{
				text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abd();
			}
			A_4 = new Label
			{
				Text = text,
				AutoSize = true,
				Font = new Font(Q.A_m_1(16f).FontFamily, 16f, FontStyle.Bold),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abe(),
				Margin = new Padding(0, 0, 0, 4)
			};
			a_2 = new Label
			{
				Text = (a ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abG() : ((!string.IsNullOrEmpty(A_3)) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abf() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abF())),
				AutoSize = true,
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Fh(),
				Margin = new Padding(0, 0, 0, 10)
			};
			tableLayoutPanel.Controls.Add(A_4, 0, 0);
			tableLayoutPanel.Controls.Add(a_2, 0, 1);
			c = new Label
			{
				Text = (global::a.Q.EnMode ? (a_1 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()) : (A_3 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D())),
				AutoSize = true,
				MaximumSize = new Size(720, 0),
				Font = new Font(Q.A_m_1(10f).FontFamily, 10f, FontStyle.Bold),
				Margin = new Padding(0, 0, 0, 12),
				Visible = !string.IsNullOrEmpty(A_3)
			};
			tableLayoutPanel.Controls.Add(c, 0, 2);
			C = new Label
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.RI(),
				AutoSize = true,
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Fh(),
				Margin = new Padding(0, 0, 0, 4)
			};
			tableLayoutPanel.Controls.Add(C, 0, 3);
			A_5 = new TextBox
			{
				ReadOnly = true,
				TextAlign = HorizontalAlignment.Center,
				Font = new Font(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ME(), 14f, FontStyle.Bold),
				Height = 40,
				Anchor = (AnchorStyles.Left | AnchorStyles.Right),
				Margin = new Padding(0, 0, 0, 8),
				BackColor = A_1.a,
				ForeColor = A_1.C
			};
			tableLayoutPanel.Controls.Add(A_5, 0, 4);
			FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel
			{
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				WrapContents = false,
				Margin = new Padding(0, 0, 0, 12)
			};
			A_7 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.OA(), 120);
			A_7.Click += delegate
			{
				B_m_1();
			};
			a_4 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abg(), 134);
			a_4.Click += delegate
			{
				b_m_1();
			};
			B_2 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.OB(), 148);
			B_2.Click += delegate
			{
				C_m_1();
			};
			flowLayoutPanel.Controls.Add(A_7);
			flowLayoutPanel.Controls.Add(a_4);
			flowLayoutPanel.Controls.Add(B_2);
			tableLayoutPanel.Controls.Add(flowLayoutPanel, 0, 5);
			A_6 = flowLayoutPanel;
			TableLayoutPanel tableLayoutPanel2 = new TableLayoutPanel
			{
				ColumnCount = 2,
				RowCount = 1,
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				Dock = DockStyle.Fill,
				Margin = new Padding(0, 0, 0, 12)
			};
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			D = new Label
			{
				Text = (global::a.Q.EnMode ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abh() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abH()),
				AutoSize = true,
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Fh(),
				Anchor = AnchorStyles.Left,
				Margin = new Padding(0, 4, 8, 0)
			};
			a_3 = new TextBox
			{
				ReadOnly = true,
				Text = global::A.r.A_m_1(global::a.Q.EnMode),
				Dock = DockStyle.Fill,
				Margin = new Padding(0, 0, 0, 0),
				BackColor = A_1.a,
				ForeColor = A_1.b
			};
			tableLayoutPanel2.Controls.Add(D, 0, 0);
			tableLayoutPanel2.Controls.Add(a_3, 1, 0);
			tableLayoutPanel.Controls.Add(tableLayoutPanel2, 0, 6);
			tableLayoutPanel.Controls.Add(new Label
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.RK(),
				AutoSize = true,
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Fh(),
				Margin = new Padding(0, 0, 0, 4)
			}, 0, 7);
			B_1 = new TextBox
			{
				Multiline = true,
				WordWrap = true,
				ScrollBars = ScrollBars.Vertical,
				Font = new Font(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ME(), 10f),
				Height = 108,
				Anchor = (AnchorStyles.Left | AnchorStyles.Right),
				Margin = new Padding(0, 0, 0, 8)
			};
			tableLayoutPanel.Controls.Add(B_1, 0, 8);
			FlowLayoutPanel flowLayoutPanel2 = new FlowLayoutPanel
			{
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				WrapContents = false,
				Margin = new Padding(0, 0, 0, 8)
			};
			b_1 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.nx(), 96);
			b_1.Click += delegate
			{
				c_m_1();
			};
			C_1 = A_m_1((!string.IsNullOrEmpty(A_3)) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abI() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.OC(), 138);
			C_1.Click += delegate
			{
				D_m_1();
			};
			flowLayoutPanel2.Controls.Add(b_1);
			flowLayoutPanel2.Controls.Add(C_1);
			tableLayoutPanel.Controls.Add(flowLayoutPanel2, 0, 9);
			B = new Label
			{
				AutoSize = true,
				MaximumSize = new Size(720, 0),
				Margin = new Padding(0, 6, 0, 6)
			};
			tableLayoutPanel.Controls.Add(B, 0, 10);
			b = new Label
			{
				AutoSize = true,
				MaximumSize = new Size(720, 0),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BH(),
				Margin = new Padding(0, 0, 0, 8)
			};
			tableLayoutPanel.Controls.Add(b, 0, 11);
			d = new Label
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abi() + global::A.r.c + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abJ() + global::A.r.A_m_1(global::a.Q.EnMode) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abj(),
				AutoSize = true,
				MaximumSize = new Size(720, 0),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BH(),
				Margin = new Padding(0, 0, 0, 8),
				Visible = A_2
			};
			tableLayoutPanel.Controls.Add(d, 0, 12);
			FlowLayoutPanel flowLayoutPanel3 = new FlowLayoutPanel
			{
				Dock = DockStyle.Fill,
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				FlowDirection = FlowDirection.RightToLeft,
				WrapContents = false,
				Margin = new Padding(0)
			};
			d_1 = A_m_1(A_2 ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bl() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.nw(), 110);
			d_1.Click += delegate
			{
				e();
			};
			c_1 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ny(), 130, true);
			c_1.Click += delegate
			{
				d_m_1();
			};
			D_1 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.OD(), 150);
			D_1.Click += delegate
			{
				E_m_1();
			};
			E = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abK(), 130);
			E.Visible = A_2;
			E.Click += delegate
			{
				new W(A_1).ShowDialog(this);
			};
			flowLayoutPanel3.Controls.Add(d_1);
			flowLayoutPanel3.Controls.Add(c_1);
			flowLayoutPanel3.Controls.Add(D_1);
			flowLayoutPanel3.Controls.Add(E);
			tableLayoutPanel.Controls.Add(flowLayoutPanel3, 0, 14);
		}

		private Button A_m_1(string P_0, int P_1, bool P_2 = false)
		{
			return new Button
			{
				Text = P_0,
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				MinimumSize = new Size(P_1, 38),
				Font = Q.A_m_1(10f),
				Margin = new Padding(0, 0, 10, 0),
				FlatStyle = FlatStyle.Flat,
				UseVisualStyleBackColor = false
			};
		}

		private void a_m_1()
		{
			A_5.Text = J.Formatted;
			a_3.Text = global::A.r.A_m_1(global::a.Q.EnMode);
			d.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abi() + global::A.r.c + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abJ() + global::A.r.A_m_1(global::a.Q.EnMode) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abj();
			k current = global::a.j.Current;
			if (global::a.j.Active)
			{
				B_1.Text = L.a(current.A_1);
				B.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abk() + global::a.j.StatusText;
				B.ForeColor = A_1.j;
				c_1.Text = (a ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.OE() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abL());
				D_1.Visible = !a;
				b.Text = (global::a.j.DebuggerDetected ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abM() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abl());
			}
			else
			{
				if (current != null && current.A != K.a && !string.IsNullOrEmpty(current.A_1))
				{
					B_1.Text = L.a(current.A_1);
				}
				B.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abm() + ((current == null || string.IsNullOrEmpty(current.a)) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abN() : current.a);
				B.ForeColor = A_1.J;
				c_1.Text = (a ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.OE() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ny());
				D_1.Visible = false;
				b.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.RP();
			}
			if (A_2)
			{
				c_1.Visible = !global::a.j.Active;
				d_1.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bl();
			}
			if (a)
			{
				C.Visible = false;
				A_5.Visible = false;
				A_6.Visible = false;
				D_1.Visible = false;
				c_1.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.OE();
				d_1.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bl();
				a_2.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abn() + J.Formatted;
			}
		}

		private void A_m_1(string P_0, bool P_1)
		{
			B.Text = (P_1 ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abk() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abm()) + P_0;
			B.ForeColor = (P_1 ? A_1.j : A_1.J);
		}

		private void B_m_1()
		{
			try
			{
				Clipboard.SetText(J.Formatted);
				A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abO(), true);
			}
			catch
			{
				A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abo(), false);
			}
		}

		private void b_m_1()
		{
			try
			{
				Clipboard.SetText(global::A.r.A_m_1(global::a.Q.EnMode));
				A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abP(), true);
			}
			catch
			{
				A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abp(), false);
			}
		}

		private void C_m_1()
		{
			using SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Title = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.RJ();
			saveFileDialog.Filter = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abQ();
			saveFileDialog.FileName = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abq() + J.Code + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abR();
			if (saveFileDialog.ShowDialog(this) != DialogResult.OK)
			{
				return;
			}
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abr());
			stringBuilder.AppendLine(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abS());
			stringBuilder.AppendLine(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.le() + J.Formatted);
			stringBuilder.AppendLine(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abH() + global::A.r.A_m_1(global::a.Q.EnMode));
			stringBuilder.AppendLine(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abs() + Environment.MachineName);
			stringBuilder.AppendLine(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abT() + Environment.OSVersion.VersionString);
			stringBuilder.AppendLine(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abt() + DateTime.Now.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CI()));
			stringBuilder.AppendLine();
			stringBuilder.AppendLine(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abU());
			stringBuilder.AppendLine();
			try
			{
				File.WriteAllText(saveFileDialog.FileName, stringBuilder.ToString(), Encoding.UTF8);
				A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abu() + saveFileDialog.FileName, true);
			}
			catch (Exception ex)
			{
				A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abV() + ex.Message, false);
			}
		}

		private void c_m_1()
		{
			try
			{
				if (Clipboard.ContainsText())
				{
					B_1.Text = L.a(Clipboard.GetText());
					A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abv(), true);
				}
				else
				{
					A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abW(), false);
				}
			}
			catch
			{
				A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abw(), false);
			}
		}

		private void D_m_1()
		{
			using OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.RL();
			openFileDialog.Filter = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abX();
			if (openFileDialog.ShowDialog(this) != DialogResult.OK)
			{
				return;
			}
			try
			{
				string text = File.ReadAllText(openFileDialog.FileName);
				B_1.Text = L.a(text);
				A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.WK() + Path.GetFileName(openFileDialog.FileName) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abx(), true);
			}
			catch (Exception ex)
			{
				A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abY() + ex.Message, false);
			}
		}

		private void d_m_1()
		{
			string text = L.A_m_1(B_1.Text);
			if (text.Length == 0)
			{
				A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aby(), false);
				B_1.Focus();
				return;
			}
			Cursor = Cursors.WaitCursor;
			bool flag;
			string text2;
			try
			{
				flag = (a ? global::a.j.a_m_1(text, out text2) : global::a.j.A_m_1(text, out text2));
			}
			finally
			{
				Cursor = Cursors.Default;
			}
			if (!flag)
			{
				A_m_1(text2, false);
				return;
			}
			a_m_1();
			A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abZ() + global::a.j.StatusText, true);
			if (a)
			{
				if (!global::a.j.Pro)
				{
					A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abz(), false);
					return;
				}
				MessageBox.Show(this, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCA() + global::a.j.StatusText + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCa(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCB(), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				DialogResult = DialogResult.OK;
				Close();
			}
			else
			{
				MessageBox.Show(this, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCb() + global::a.j.StatusText, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCC(), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				DialogResult = DialogResult.OK;
				Close();
			}
		}

		private void E_m_1()
		{
			if (MessageBox.Show(this, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCc(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCD(), MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
			{
				global::a.j.b_m_1();
				B_1.Clear();
				a_m_1();
				A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lD(), false);
			}
		}

		private void e()
		{
			if (!A_2 && !global::a.j.Active)
			{
				if (MessageBox.Show(this, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCd(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bB(), MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
				{
					return;
				}
				DialogResult = DialogResult.Cancel;
			}
			else
			{
				DialogResult = (global::a.j.Active ? DialogResult.OK : DialogResult.Cancel);
			}
			Close();
		}

		[CompilerGenerated]
		private void A_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			B_m_1();
		}

		[CompilerGenerated]
		private void a_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			b_m_1();
		}

		[CompilerGenerated]
		private void B_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			C_m_1();
		}

		[CompilerGenerated]
		private void b_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			c_m_1();
		}

		[CompilerGenerated]
		private void C_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			D_m_1();
		}

		[CompilerGenerated]
		private void c_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			e();
		}

		[CompilerGenerated]
		private void D_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			d_m_1();
		}

		[CompilerGenerated]
		private void d_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			E_m_1();
		}

		[CompilerGenerated]
		private void E_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			new W(A_1).ShowDialog(this);
		}
	}
}
namespace b
{
	public static class L
	{
		[CompilerGenerated]
		private sealed class A
		{
			public IList<I> A_f_1;

			public CancellationToken A_f_2;

			public K A_f_3;

			public Exception A_f_4;

			internal void A_m_1()
			{
				try
				{
					L.A_m_1(A_f_1, A_f_2, A_f_3);
				}
				catch (Exception a_f_)
				{
					A_f_4 = a_f_;
				}
			}
		}

		[CompilerGenerated]
		private static class a
		{
			public static CallSite<Func<CallSite, object, int, object>> A;

			public static CallSite<Func<CallSite, object, object, object>> A_1;

			public static CallSite<Func<CallSite, object, bool>> A_2;

			public static CallSite<Func<CallSite, object, object>> A_3;

			public static CallSite<Func<CallSite, object, object>> a_f_1;

			public static CallSite<Func<CallSite, object, int>> A_4;

			public static CallSite<Func<CallSite, object, int, object>> a_f_2;

			public static CallSite<Func<CallSite, Type, object, string, object>> A_5;

			public static CallSite<Func<CallSite, Type, object, object>> A_6;

			public static CallSite<Func<CallSite, object, string>> A_7;

			public static CallSite<Func<CallSite, Type, object, string, object>> a_f_3;

			public static CallSite<Func<CallSite, Type, object, object>> a_f_4;

			public static CallSite<Func<CallSite, object, string>> a_f_5;

			public static CallSite<Func<CallSite, Type, object, string, object>> B;

			public static CallSite<Func<CallSite, Type, object, object>> B_1;

			public static CallSite<Func<CallSite, object, string>> B_2;

			public static CallSite<Func<CallSite, Type, object, string, object>> b;

			public static CallSite<Func<CallSite, Type, object, object>> b_1;

			public static CallSite<Func<CallSite, object, string>> b_2;

			public static CallSite<Func<CallSite, Type, object, string, object>> C;

			public static CallSite<Func<CallSite, Type, object, object>> C_1;

			public static CallSite<Func<CallSite, object, DateTime?>> A_8;

			public static CallSite<Action<CallSite, List<object>, object>> A_9;

			public static CallSite<Action<CallSite, Type, object>> A_10;

			public static CallSite<C<CallSite, Type, object, I, string, object>> A_11;

			public static CallSite<Func<CallSite, object, bool>> a_f_6;

			public static CallSite<Action<CallSite, Type, object>> a_f_7;

			public static CallSite<Action<CallSite, Type, object>> B_3;

			public static CallSite<Action<CallSite, Type, object>> b_3;
		}

		[CompilerGenerated]
		private static class B
		{
			public static CallSite<Func<CallSite, object, object>> A;

			public static CallSite<Func<CallSite, Type, object, CultureInfo, object>> A_1;

			public static CallSite<Func<CallSite, object, string>> A_2;

			public static CallSite<Action<CallSite, object>> A_3;

			public static CallSite<Func<CallSite, object, object>> a;

			public static CallSite<Func<CallSite, object, IEnumerable>> A_4;
		}

		[CompilerGenerated]
		private static class b
		{
			public static CallSite<Func<CallSite, object, string, object>> A;
		}

		public static K A_m_1(IList<I> P_0, CancellationToken P_1)
		{
			K A_f_3 = new K();
			if (P_0 == null || P_0.Count == 0)
			{
				return A_f_3;
			}
			Exception A_f_4 = null;
			Thread thread = new Thread(() =>
			{
				try
				{
					A_m_1(P_0, P_1, A_f_3);
				}
				catch (Exception ex)
				{
					A_f_4 = ex;
				}
			});
			thread.SetApartmentState(ApartmentState.STA);
			thread.IsBackground = true;
			thread.Start();
			thread.Join();
			if (A_f_4 != null && A_f_3.A_1.Count == 0)
			{
				foreach (I item in P_0)
				{
					A_f_3.b++;
					A_f_3.A_1.Add(new j
					{
						A = item,
						A_1 = J.b,
						A_2 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajH() + A_f_4.Message
					});
				}
			}
			return A_f_3;
		}

		private static void A_m_1(IList<I> P_0, CancellationToken P_1, K P_2)
		{
			object obj = null;
			dynamic val = null;
			object obj2 = null;
			List<i> list = new List<i>();
			List<object> list2 = new List<object>();
			bool flag = false;
			try
			{
				Type typeFromProgID = Type.GetTypeFromProgID(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajh());
				if (typeFromProgID == null)
				{
					A_m_1(P_0, P_2, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajI());
					return;
				}
				obj = Activator.CreateInstance(typeFromProgID);
				if (a.A == null)
				{
					a.A = CallSite<Func<CallSite, object, int, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aji(), null, typeof(L), new CSharpArgumentInfo[2]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				val = a.A.Target(a.A, obj, 10);
				if (val == null)
				{
					A_m_1(P_0, P_2, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajJ());
					return;
				}
				if (a.A_3 == null)
				{
					a.A_3 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Vu(), null, typeof(L), new CSharpArgumentInfo[1] { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null) }));
				}
				obj2 = a.A_3.Target(a.A_3, (object)val);
				if (a.a_f_1 == null)
				{
					a.a_f_1 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.sG(), typeof(L), new CSharpArgumentInfo[1] { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null) }));
				}
				int num = (int)(dynamic)a.a_f_1.Target(a.a_f_1, obj2);
				flag = num == 0;
				for (int num2 = 0; num2 < num; num2++)
				{
					if (a.a_f_2 == null)
					{
						a.a_f_2 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajj(), null, typeof(L), new CSharpArgumentInfo[2]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
						}));
					}
					object arg = a.a_f_2.Target(a.a_f_2, obj2, num2);
					if (a.A_6 == null)
					{
						a.A_6 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajK(), null, typeof(L), new CSharpArgumentInfo[2]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, Type, object, object> target = a.A_6.Target;
					CallSite<Func<CallSite, Type, object, object>> a_ = a.A_6;
					Type? typeFromHandle = typeof(L);
					if (a.A_5 == null)
					{
						a.A_5 = CallSite<Func<CallSite, Type, object, string, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajk(), null, typeof(L), new CSharpArgumentInfo[3]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					string value = (dynamic)target(a_, typeFromHandle, a.A_5.Target(a.A_5, typeof(L), arg, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajL()));
					if (a.a_f_4 == null)
					{
						a.a_f_4 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajK(), null, typeof(L), new CSharpArgumentInfo[2]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, Type, object, object> target2 = a.a_f_4.Target;
					CallSite<Func<CallSite, Type, object, object>> a_f_ = a.a_f_4;
					Type? typeFromHandle2 = typeof(L);
					if (a.a_f_3 == null)
					{
						a.a_f_3 = CallSite<Func<CallSite, Type, object, string, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajk(), null, typeof(L), new CSharpArgumentInfo[3]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					string value2 = (dynamic)target2(a_f_, typeFromHandle2, a.a_f_3.Target(a.a_f_3, typeof(L), arg, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajl()));
					if (string.IsNullOrEmpty(value2))
					{
						if (a.B_1 == null)
						{
							a.B_1 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajK(), null, typeof(L), new CSharpArgumentInfo[2]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, Type, object, object> target3 = a.B_1.Target;
						CallSite<Func<CallSite, Type, object, object>> b_ = a.B_1;
						Type? typeFromHandle3 = typeof(L);
						if (a.B == null)
						{
							a.B = CallSite<Func<CallSite, Type, object, string, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajk(), null, typeof(L), new CSharpArgumentInfo[3]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						value2 = (dynamic)target3(b_, typeFromHandle3, a.B.Target(a.B, typeof(L), arg, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajM()));
					}
					if (!string.IsNullOrEmpty(value) && !string.IsNullOrEmpty(value2))
					{
						i i2 = new i
						{
							A = value,
							a = value2
						};
						if (a.b_1 == null)
						{
							a.b_1 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajK(), null, typeof(L), new CSharpArgumentInfo[2]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, Type, object, object> target4 = a.b_1.Target;
						CallSite<Func<CallSite, Type, object, object>> b_2 = a.b_1;
						Type? typeFromHandle4 = typeof(L);
						if (a.b == null)
						{
							a.b = CallSite<Func<CallSite, Type, object, string, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajk(), null, typeof(L), new CSharpArgumentInfo[3]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						i2.B = (dynamic)target4(b_2, typeFromHandle4, a.b.Target(a.b, typeof(L), arg, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajm()));
						if (a.C_1 == null)
						{
							a.C_1 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajN(), null, typeof(L), new CSharpArgumentInfo[2]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, Type, object, object> target5 = a.C_1.Target;
						CallSite<Func<CallSite, Type, object, object>> c_ = a.C_1;
						Type? typeFromHandle5 = typeof(L);
						if (a.C == null)
						{
							a.C = CallSite<Func<CallSite, Type, object, string, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajk(), null, typeof(L), new CSharpArgumentInfo[3]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						i2.A_1 = (dynamic)target5(c_, typeFromHandle5, a.C.Target(a.C, typeof(L), arg, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajn()));
						list.Add(i2);
						if (a.A_9 == null)
						{
							a.A_9 = CallSite<Action<CallSite, List<object>, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajO(), null, typeof(L), new CSharpArgumentInfo[2]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						a.A_9.Target(a.A_9, list2, arg);
					}
				}
			}
			catch (Exception ex)
			{
				A_m_1(P_0, P_2, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajo() + ex.Message);
				if (a.A_10 == null)
				{
					a.A_10 = CallSite<Action<CallSite, Type, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajP(), null, typeof(L), new CSharpArgumentInfo[2]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				a.A_10.Target(a.A_10, typeof(L), obj);
				return;
			}
			foreach (I item in P_0)
			{
				if (P_1.IsCancellationRequested)
				{
					P_2.b++;
					P_2.A_1.Add(new j
					{
						A = item,
						A_1 = J.b,
						A_2 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jt()
					});
					continue;
				}
				if (flag)
				{
					P_2.B++;
					P_2.A_1.Add(new j
					{
						A = item,
						A_1 = J.B
					});
					continue;
				}
				int num3 = k.A_m_1(item, list);
				if (num3 < 0)
				{
					P_2.a++;
					P_2.A_1.Add(new j
					{
						A = item,
						A_1 = J.a
					});
					continue;
				}
				if (File.Exists(global::a.a.A(item.A)) || Directory.Exists(global::a.a.A(item.A)))
				{
					P_2.C++;
					P_2.A_1.Add(new j
					{
						A = item,
						A_1 = J.C,
						A_2 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajp()
					});
					continue;
				}
				string a_2 = null;
				bool flag2;
				try
				{
					if (a.A_11 == null)
					{
						a.A_11 = CallSite<C<CallSite, Type, object, I, string, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajQ(), null, typeof(L), new CSharpArgumentInfo[4]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsOut, null)
						}));
					}
					flag2 = (dynamic)a.A_11.Target(a.A_11, typeof(L), list2[num3], item, ref a_2);
				}
				catch (Exception ex2)
				{
					flag2 = false;
					a_2 = ex2.Message;
				}
				if (flag2)
				{
					P_2.A++;
					P_2.A_1.Add(new j
					{
						A = item,
						A_1 = J.A
					});
				}
				else
				{
					P_2.b++;
					P_2.A_1.Add(new j
					{
						A = item,
						A_1 = J.b,
						A_2 = a_2
					});
				}
			}
			for (int num4 = 0; num4 < list2.Count; num4++)
			{
				B_m_1(list2[num4]);
			}
			if (a.a_f_7 == null)
			{
				a.a_f_7 = CallSite<Action<CallSite, Type, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajP(), null, typeof(L), new CSharpArgumentInfo[2]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			a.a_f_7.Target(a.a_f_7, typeof(L), obj2);
			if (a.B_3 == null)
			{
				a.B_3 = CallSite<Action<CallSite, Type, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajP(), null, typeof(L), new CSharpArgumentInfo[2]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			a.B_3.Target(a.B_3, typeof(L), (object)val);
			if (a.b_3 == null)
			{
				a.b_3 = CallSite<Action<CallSite, Type, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajP(), null, typeof(L), new CSharpArgumentInfo[2]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			a.b_3.Target(a.b_3, typeof(L), obj);
		}

		private static bool A_m_1(dynamic item, I P_1, out string P_2)
		{
			P_2 = null;
			string text = P_1.a ?? P_1.A;
			bool flag = !global::a.a.A(text, P_1.A);
			bool flag2 = false;
			try
			{
				if (B.a == null)
				{
					B.a = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajq(), null, typeof(L), new CSharpArgumentInfo[1] { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null) }));
				}
				foreach (object item2 in (dynamic)B.a.Target(B.a, (object)item))
				{
					string text2;
					try
					{
						if (B.A_1 == null)
						{
							B.A_1 = CallSite<Func<CallSite, Type, object, CultureInfo, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajR(), null, typeof(L), new CSharpArgumentInfo[3]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
							}));
						}
						Func<CallSite, Type, object, CultureInfo, object> target = B.A_1.Target;
						CallSite<Func<CallSite, Type, object, CultureInfo, object>> a_ = B.A_1;
						Type? typeFromHandle = typeof(Convert);
						if (B.A == null)
						{
							B.A = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajM(), typeof(L), new CSharpArgumentInfo[1] { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null) }));
						}
						text2 = (dynamic)target(a_, typeFromHandle, B.A.Target(B.A, item2), CultureInfo.CurrentCulture);
					}
					catch
					{
						continue;
					}
					if (text2 == null)
					{
						continue;
					}
					text2 = text2.Replace(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LL(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
					if (text2.IndexOf(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajr(), StringComparison.OrdinalIgnoreCase) >= 0 || text2.IndexOf(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajS(), StringComparison.Ordinal) >= 0 || text2.IndexOf(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajs(), StringComparison.Ordinal) >= 0)
					{
						if (B.A_3 == null)
						{
							B.A_3 = CallSite<Action<CallSite, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajT(), null, typeof(L), new CSharpArgumentInfo[1] { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null) }));
						}
						B.A_3.Target(B.A_3, item2);
						flag2 = true;
						break;
					}
				}
			}
			catch (Exception ex)
			{
				P_2 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajt() + ex.Message;
				return false;
			}
			if (!flag2)
			{
				P_2 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajU();
				return false;
			}
			string text3 = null;
			for (int num = 0; num < 40; num++)
			{
				if (File.Exists(global::a.a.A(P_1.A)))
				{
					text3 = P_1.A;
					break;
				}
				if (flag && File.Exists(global::a.a.A(text)))
				{
					text3 = text;
					break;
				}
				Thread.Sleep(125);
			}
			if (text3 == null)
			{
				P_2 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aju();
				return false;
			}
			if (!flag || global::a.a.A(text3, P_1.A))
			{
				return true;
			}
			try
			{
				string directoryName = Path.GetDirectoryName(P_1.A);
				if (!string.IsNullOrEmpty(directoryName))
				{
					Directory.CreateDirectory(global::a.a.A(directoryName));
				}
				global::a.a.a_m_1(text, P_1.A);
				try
				{
					Directory.Delete(global::a.a.A(Path.GetDirectoryName(text)), recursive: false);
				}
				catch
				{
				}
				return true;
			}
			catch (Exception ex2)
			{
				P_2 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajV() + ex2.Message + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajv() + global::a.a.a_m_1(text) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ln();
				return false;
			}
		}

		private static void A_m_1(IList<I> P_0, K P_1, string P_2)
		{
			foreach (I item in P_0)
			{
				P_1.b++;
				P_1.A_1.Add(new j
				{
					A = item,
					A_1 = J.b,
					A_2 = P_2
				});
			}
		}

		private static object A_m_1(dynamic obj, string P_1)
		{
			try
			{
				if (b.A == null)
				{
					b.A = CallSite<Func<CallSite, object, string, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajW(), null, typeof(L), new CSharpArgumentInfo[2]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				return b.A.Target(b.A, (object)obj, P_1);
			}
			catch
			{
				return null;
			}
		}

		private static string A_m_1(object P_0)
		{
			if (P_0 != null)
			{
				return Convert.ToString(P_0, CultureInfo.CurrentCulture);
			}
			return null;
		}

		private static DateTime? a_m_1(object P_0)
		{
			if (P_0 == null)
			{
				return null;
			}
			DateTime result;
			if (P_0 is DateTime)
			{
				result = (DateTime)P_0;
			}
			else
			{
				string value = Convert.ToString(P_0, CultureInfo.CurrentCulture);
				if (string.IsNullOrEmpty(value))
				{
					return null;
				}
				bool flag = DateTime.TryParse(value, CultureInfo.CurrentCulture, DateTimeStyles.None, out result);
				if (!flag)
				{
					flag = DateTime.TryParse(value, CultureInfo.InvariantCulture, DateTimeStyles.None, out result);
				}
				if (!flag)
				{
					return null;
				}
			}
			if (result.Kind == DateTimeKind.Local)
			{
				return result;
			}
			return DateTime.SpecifyKind(result, DateTimeKind.Utc).ToLocalTime();
		}

		private static void B_m_1(object P_0)
		{
			if (P_0 == null)
			{
				return;
			}
			try
			{
				if (Marshal.IsComObject(P_0))
				{
					Marshal.FinalReleaseComObject(P_0);
				}
			}
			catch
			{
			}
		}
	}
	internal sealed class l
	{
		[CompilerGenerated]
		private string A;

		[CompilerGenerated]
		private string a;

		[CompilerGenerated]
		private string B;

		[CompilerGenerated]
		private string b;

		[CompilerGenerated]
		private long A_1;

		[CompilerGenerated]
		private string C;

		[CompilerGenerated]
		private bool A_2;

		[CompilerGenerated]
		private int A_3;

		public string Id
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

		public string Name
		{
			[CompilerGenerated]
			get
			{
				return a;
			}
			[CompilerGenerated]
			set
			{
				a = value;
			}
		}

		public string Path
		{
			[CompilerGenerated]
			get
			{
				return B;
			}
			[CompilerGenerated]
			set
			{
				B = value;
			}
		}

		public string DirPath
		{
			[CompilerGenerated]
			get
			{
				return b;
			}
			[CompilerGenerated]
			set
			{
				b = value;
			}
		}

		public long Size
		{
			[CompilerGenerated]
			get
			{
				return A_1;
			}
			[CompilerGenerated]
			set
			{
				A_1 = value;
			}
		}

		public string Time
		{
			[CompilerGenerated]
			get
			{
				return C;
			}
			[CompilerGenerated]
			set
			{
				C = value;
			}
		}

		public bool IsFolder
		{
			[CompilerGenerated]
			get
			{
				return A_2;
			}
			[CompilerGenerated]
			set
			{
				A_2 = value;
			}
		}

		public int Depth
		{
			[CompilerGenerated]
			get
			{
				return A_3;
			}
			[CompilerGenerated]
			set
			{
				A_3 = value;
			}
		}

		public string SizeText
		{
			get
			{
				if (Size >= 0)
				{
					return global::C.E.A_m_1(Size);
				}
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bE();
			}
		}
	}
}
