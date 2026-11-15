using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007B1262ED64_002DD0A6_002D499E_002D9510_002DF2240F018DBB_007D;
using A;
using B;
using b;

namespace A
{
	public sealed class P
	{
		public string A = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		public string a = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		public bool A_1 = true;

		public bool a_1;

		public bool B;

		public long A_2;

		public string B_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		public bool b = true;

		public int A_3 = 8;

		public int a_2 = 2;

		public string b_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.cA();

		public static P A_m_1(string P_0)
		{
			P p2 = new P();
			if (string.IsNullOrWhiteSpace(P_0))
			{
				return p2;
			}
			using JsonDocument jsonDocument = JsonDocument.Parse(P_0);
			JsonElement rootElement = jsonDocument.RootElement;
			if (rootElement.ValueKind != JsonValueKind.Object)
			{
				throw new ArgumentException(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CO());
			}
			p2.A = o.A(rootElement, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Co(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CP(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cp(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CQ());
			p2.a = o.A(rootElement, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cq(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CR(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cr());
			p2.A_1 = o.A(rootElement, true, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CS(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cs(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CT());
			p2.a_1 = o.A(rootElement, false, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ct(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CU());
			p2.B = o.A(rootElement, false, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cu(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CV());
			p2.A_2 = o.A(rootElement, 0L, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cv(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CW());
			p2.B_1 = o.A(rootElement, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cw(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CX());
			p2.b = o.A(rootElement, true, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cx());
			p2.A_3 = o.A(rootElement, 8, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CY(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cy());
			p2.a_2 = o.A(rootElement, 2, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CZ(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cz());
			p2.b_1 = o.A(rootElement, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.cA(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ca(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.cB());
			return p2;
		}

		public global::b.d A_m_1()
		{
			return new global::b.d
			{
				A = A,
				a = a,
				d_f_1 = A_1,
				E = a_1,
				f = B,
				A_6 = A_2,
				d_f_2 = B_1,
				F = b,
				A_5 = A_3,
				a_2 = a_2,
				D_1 = b_1,
				A_1 = false,
				a_1 = false,
				B_1 = false,
				b_1 = false,
				C_1 = false
			};
		}
	}
	public sealed class p
	{
		public string A = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		public string a = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
	}
}
namespace a
{
	public sealed class P : Form
	{
		private readonly global::b.Y A;

		private RichTextBox A_1;

		private TextBox A_2;

		private Label A_3;

		private Button A_4;

		private Button a;

		private List<m> A_5 = new List<m>();

		private int A_6 = -1;

		internal RichTextBox ContentBox => A_1;

		internal TextBox SearchBox => A_2;

		internal Label SearchStatus => A_3;

		public P(global::b.Y P_0)
		{
			A = P_0 ?? global::b.Y.A_m_1();
			A_m_1();
			a_m_1();
		}

		private void A_m_1()
		{
			SuspendLayout();
			Text = (Q.EnMode ? (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.MH() + global::A.r.c) : (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.MG() + global::A.r.c + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Mg()));
			StartPosition = FormStartPosition.CenterParent;
			Icon = global::A.R.App;
			Font = global::B.Q.A_m_1(10f);
			AutoScaleMode = AutoScaleMode.Font;
			Size = new Size(1040, 860);
			MinimumSize = new Size(760, 580);
			A_1 = new RichTextBox
			{
				Dock = DockStyle.Fill,
				ReadOnly = true,
				BorderStyle = BorderStyle.None,
				WordWrap = true,
				DetectUrls = false,
				BackColor = A.H,
				ForeColor = A.h,
				Font = global::B.Q.A_m_1(10f),
				ScrollBars = RichTextBoxScrollBars.Vertical,
				HideSelection = false
			};
			FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel
			{
				Dock = DockStyle.Top,
				FlowDirection = FlowDirection.LeftToRight,
				WrapContents = false,
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				Padding = new Padding(10, 9, 10, 4),
				Margin = new Padding(0)
			};
			Label value = new Label
			{
				Text = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Mh()),
				AutoSize = true,
				Font = global::B.Q.A_m_1(10f),
				Margin = new Padding(0, 6, 8, 4)
			};
			A_2 = new TextBox
			{
				Width = 300,
				Font = global::B.Q.A_m_1(10f),
				BorderStyle = BorderStyle.FixedSingle,
				Margin = new Padding(0, 3, 10, 3)
			};
			A_2.PlaceholderText = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.MI());
			A_2.TextChanged += delegate
			{
				B();
			};
			A_2.KeyDown += (object P_0, KeyEventArgs P_1) =>
			{
				if (P_1.KeyCode == Keys.Return)
				{
					P_1.SuppressKeyPress = true;
					b();
				}
			};
			flowLayoutPanel.Controls.Add(value);
			flowLayoutPanel.Controls.Add(A_2);
			A_3 = new Label
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(),
				AutoSize = true,
				Font = global::B.Q.A_m_1(9.5f),
				ForeColor = A.I,
				Margin = new Padding(0, 7, 0, 4)
			};
			flowLayoutPanel.Controls.Add(A_3);
			TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
			{
				Dock = DockStyle.Bottom,
				ColumnCount = 2,
				RowCount = 1,
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				Padding = new Padding(10, 6, 10, 9),
				Margin = new Padding(0)
			};
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			Label control = new Label
			{
				Text = (Q.EnMode ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.MJ() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Mi()),
				AutoSize = true,
				Font = global::B.Q.A_m_1(9f),
				ForeColor = A.I,
				Margin = new Padding(0, 9, 8, 0)
			};
			FlowLayoutPanel flowLayoutPanel2 = new FlowLayoutPanel
			{
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				FlowDirection = FlowDirection.RightToLeft,
				WrapContents = false,
				Margin = new Padding(0)
			};
			a = new Button
			{
				Text = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bl()),
				AutoSize = false,
				Font = global::B.Q.A_m_1(10f),
				Margin = new Padding(8, 0, 0, 0),
				Padding = new Padding(10, 0, 10, 0)
			};
			a.Click += delegate
			{
				Close();
			};
			A_4 = new Button
			{
				Text = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Mj()),
				AutoSize = false,
				Font = global::B.Q.A_m_1(10f),
				Margin = new Padding(0),
				Padding = new Padding(10, 0, 10, 0)
			};
			A_4.Click += delegate
			{
				C();
			};
			flowLayoutPanel2.Controls.Add(a);
			flowLayoutPanel2.Controls.Add(A_4);
			tableLayoutPanel.Controls.Add(control, 0, 0);
			tableLayoutPanel.Controls.Add(flowLayoutPanel2, 1, 0);
			Controls.Add(A_1);
			Controls.Add(tableLayoutPanel);
			Controls.Add(flowLayoutPanel);
			global::b.Z.A_m_1(this, A, A_4);
			A_m_1(A_4);
			A_m_1(a);
			A_1.BackColor = A.H;
			A_1.ForeColor = A.h;
			ResumeLayout(performLayout: true);
		}

		private static void A_m_1(Button P_0)
		{
			Font font = P_0.Font;
			int num = Math.Max(TextRenderer.MeasureText(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.MK(), font).Height, font.Height);
			P_0.Height = num + 14;
			P_0.Width = Math.Max(96, TextRenderer.MeasureText(P_0.Text, font).Width + P_0.Padding.Horizontal + 10);
		}

		private void a_m_1()
		{
			O.A(A_1, N.b(Q.EnMode), A);
			A_5.Clear();
			A_6 = -1;
			if (A_2 != null && A_2.TextLength > 0)
			{
				B();
			}
		}

		private void B()
		{
			if (A_1 == null || A_2 == null)
			{
				return;
			}
			A_1.SelectAll();
			A_1.SelectionBackColor = A.H;
			A_1.SelectionLength = 0;
			A_1.SelectionStart = 0;
			string text = A_2.Text.Trim();
			A_5 = o.A(A_1.Text, text);
			A_6 = -1;
			if (text.Length == 0)
			{
				A_3.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
				A_3.ForeColor = A.I;
				return;
			}
			Color selectionBackColor = (A.IsDark ? Color.FromArgb(100, 76, 30) : Color.FromArgb(255, 235, 156));
			foreach (m item in A_5)
			{
				A_1.Select(item.A, item.a);
				A_1.SelectionBackColor = selectionBackColor;
			}
			A_1.SelectionStart = 0;
			A_1.SelectionLength = 0;
			if (A_5.Count == 0)
			{
				A_3.Text = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Mk());
				A_3.ForeColor = A.J;
			}
			else
			{
				A_3.Text = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ML(), A_5.Count);
				A_3.ForeColor = A.j;
			}
		}

		private void b()
		{
			if (A_5.Count != 0)
			{
				A_6 = (A_6 + 1) % A_5.Count;
				m m2 = A_5[A_6];
				A_1.Select(m2.A, m2.a);
				A_1.ScrollToCaret();
				A_1.Focus();
				A_3.Text = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ml(), A_6 + 1, A_5.Count);
				A_3.ForeColor = A.j;
			}
		}

		private void C()
		{
			try
			{
				Clipboard.SetText(A_1.Text);
				A_3.Text = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.MM());
				A_3.ForeColor = A.j;
			}
			catch (Exception ex)
			{
				A_3.Text = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Mm()) + ex.Message;
				A_3.ForeColor = A.J;
			}
		}

		[CompilerGenerated]
		private void A_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			B();
		}

		[CompilerGenerated]
		private void A_m_1(object P_0, KeyEventArgs P_1)
		{
			if (P_1.KeyCode == Keys.Return)
			{
				P_1.SuppressKeyPress = true;
				b();
			}
		}

		[CompilerGenerated]
		private void a_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			Close();
		}

		[CompilerGenerated]
		private void B(object? _003Cp0_003E, EventArgs P_1)
		{
			C();
		}
	}
	public static class p
	{
		public static string Current => N.C(Q.EnMode);

		public static string Usage
		{
			get
			{
				if (!Q.EnMode)
				{
					return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.MN();
				}
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Mn();
			}
		}
	}
}
