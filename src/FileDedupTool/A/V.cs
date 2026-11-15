using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007B1262ED64_002DD0A6_002D499E_002D9510_002DF2240F018DBB_007D;
using B;
using a;
using b;

namespace A
{
	public sealed class V : Form
	{
		[CompilerGenerated]
		private u A;

		private readonly CheckBox A_1;

		private readonly Button A_2;

		private readonly Button a;

		private readonly Button B;

		private readonly b.Y A_3;

		public u Choice
		{
			[CompilerGenerated]
			get
			{
				return A;
			}
			[CompilerGenerated]
			private set
			{
				A = value;
			}
		}

		public bool Remember => A_1.Checked;

		public V(b.Y P_0)
		{
			A_3 = P_0 ?? b.Y.A_m_1();
			Choice = u.A;
			Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iM());
			FormBorderStyle = FormBorderStyle.FixedDialog;
			StartPosition = FormStartPosition.CenterParent;
			MaximizeBox = false;
			MinimizeBox = false;
			ShowInTaskbar = false;
			Font = global::B.Q.A_m_1(10.5f);
			AutoScaleMode = AutoScaleMode.Font;
			Icon = R.App;
			ClientSize = new Size(468, 190);
			Padding = new Padding(18, 16, 18, 14);
			TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
			{
				Dock = DockStyle.Fill,
				ColumnCount = 1,
				RowCount = 3,
				Padding = new Padding(0)
			};
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			Label control = new Label
			{
				Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.im()),
				AutoSize = false,
				Dock = DockStyle.Fill,
				TextAlign = ContentAlignment.MiddleLeft,
				Margin = new Padding(0, 0, 0, 8)
			};
			A_1 = new CheckBox
			{
				Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iN()),
				AutoSize = true,
				Checked = false,
				Margin = new Padding(2, 6, 0, 10)
			};
			FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel
			{
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				WrapContents = false,
				FlowDirection = FlowDirection.RightToLeft,
				Dock = DockStyle.Fill,
				Margin = new Padding(0)
			};
			B = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BX(), 92);
			B.DialogResult = DialogResult.Cancel;
			a = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.@in(), 110);
			A_2 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iO(), 148, true);
			A_2.Click += delegate
			{
				A_m_1(u.a);
			};
			a.Click += delegate
			{
				A_m_1(u.B);
			};
			B.Click += delegate
			{
				A_m_1(u.A);
			};
			flowLayoutPanel.Controls.Add(B);
			flowLayoutPanel.Controls.Add(a);
			flowLayoutPanel.Controls.Add(A_2);
			tableLayoutPanel.Controls.Add(control, 0, 0);
			tableLayoutPanel.Controls.Add(A_1, 0, 1);
			tableLayoutPanel.Controls.Add(flowLayoutPanel, 0, 2);
			Controls.Add(tableLayoutPanel);
			CancelButton = B;
			AcceptButton = A_2;
			b.Z.A_m_1(this, A_3, A_2);
			global::a.Q.A_m_1(this);
		}

		private static Button A_m_1(string P_0, int P_1, bool P_2 = false)
		{
			return new Button
			{
				Text = global::a.Q.A_m_1(P_0),
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				MinimumSize = new Size(P_1, 36),
				Padding = new Padding(12, 0, 12, 0),
				Margin = new Padding(8, 0, 0, 0),
				FlatStyle = FlatStyle.Flat,
				UseVisualStyleBackColor = false,
				Font = global::B.Q.A_m_1(10.5f, P_2 ? FontStyle.Bold : FontStyle.Regular),
				Cursor = Cursors.Hand
			};
		}

		private void A_m_1(u P_0)
		{
			Choice = P_0;
			DialogResult = ((P_0 != u.A) ? DialogResult.OK : DialogResult.Cancel);
			Close();
		}

		public static u A_m_1(IWin32Window P_0, b.Y P_1, out bool P_2)
		{
			P_2 = false;
			using V v2 = new V(P_1);
			v2.ShowDialog(P_0);
			P_2 = v2.Remember;
			return v2.Choice;
		}

		[CompilerGenerated]
		private void A_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			A_m_1(u.a);
		}

		[CompilerGenerated]
		private void a_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			A_m_1(u.B);
		}

		[CompilerGenerated]
		private void B_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			A_m_1(u.A);
		}
	}
	internal enum v
	{
		A,
		a
	}
}
namespace a
{
	internal enum V
	{
		A,
		a,
		B,
		b,
		C,
		c,
		D
	}
	internal sealed class v : Exception
	{
		[CompilerGenerated]
		private V A;

		public V Kind
		{
			[CompilerGenerated]
			get
			{
				return A;
			}
			[CompilerGenerated]
			private set
			{
				A = value;
			}
		}

		public v(V P_0, string P_1)
			: base(P_1)
		{
			Kind = P_0;
		}
	}
}
