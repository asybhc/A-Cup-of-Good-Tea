using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007B1262ED64_002DD0A6_002D499E_002D9510_002DF2240F018DBB_007D;
using A;
using B;
using a;

namespace C;

internal sealed class F : Form
{
	internal RadioButton A;

	internal RadioButton a;

	internal Label A_1;

	internal Button A_2;

	internal Button a_1;

	internal Button B;

	[CompilerGenerated]
	private bool A_3;

	internal bool CheckRequested
	{
		[CompilerGenerated]
		get
		{
			return A_3;
		}
		[CompilerGenerated]
		private set
		{
			A_3 = value;
		}
	}

	internal string SelectedMode
	{
		get
		{
			if (a == null || !a.Checked)
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iz();
			}
			return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDl();
		}
	}

	internal F(global::A.x P_0)
	{
		Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMc());
		StartPosition = FormStartPosition.CenterParent;
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MinimizeBox = false;
		MaximizeBox = false;
		ShowInTaskbar = false;
		AutoScaleMode = AutoScaleMode.Font;
		Font = global::B.Q.A_m_1(10f);
		ClientSize = new Size(600, 300);
		TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
		{
			Dock = DockStyle.Fill,
			ColumnCount = 1,
			RowCount = 3,
			Padding = new Padding(18, 16, 18, 16)
		};
		tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
		tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
		GroupBox groupBox = new GroupBox
		{
			Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMD()),
			Dock = DockStyle.Fill,
			AutoSize = true,
			AutoSizeMode = AutoSizeMode.GrowAndShrink,
			Padding = new Padding(14, 28, 14, 12),
			Margin = new Padding(0, 0, 0, 10)
		};
		FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel
		{
			Dock = DockStyle.Fill,
			FlowDirection = FlowDirection.TopDown,
			WrapContents = false,
			AutoSize = true,
			AutoSizeMode = AutoSizeMode.GrowAndShrink,
			Margin = new Padding(0)
		};
		A = new RadioButton
		{
			Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMd()),
			AutoSize = true,
			Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aME(),
			Margin = new Padding(0, 4, 0, 8)
		};
		a = new RadioButton
		{
			Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMe()),
			AutoSize = true,
			Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMF(),
			Margin = new Padding(0, 0, 0, 0)
		};
		bool flag = !E.B_m_1(P_0?.UpdateCheckMode);
		a.Checked = flag;
		A.Checked = !flag;
		flowLayoutPanel.Controls.Add(A);
		flowLayoutPanel.Controls.Add(a);
		groupBox.Controls.Add(flowLayoutPanel);
		tableLayoutPanel.Controls.Add(groupBox, 0, 0);
		A_1 = new Label
		{
			Dock = DockStyle.Fill,
			AutoSize = false,
			Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMf(),
			Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMG()),
			Margin = new Padding(2, 0, 2, 10)
		};
		tableLayoutPanel.Controls.Add(A_1, 0, 1);
		FlowLayoutPanel flowLayoutPanel2 = new FlowLayoutPanel
		{
			FlowDirection = FlowDirection.RightToLeft,
			Dock = DockStyle.Fill,
			AutoSize = true,
			WrapContents = false,
			Margin = new Padding(0)
		};
		B = new Button
		{
			Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BX()),
			Width = 90,
			Height = 32,
			DialogResult = DialogResult.Cancel,
			Margin = new Padding(6, 0, 0, 0)
		};
		a_1 = new Button
		{
			Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bw()),
			Width = 96,
			Height = 32,
			DialogResult = DialogResult.OK,
			Margin = new Padding(6, 0, 0, 0)
		};
		A_2 = new Button
		{
			Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMg()),
			Width = 130,
			Height = 32,
			Margin = new Padding(0)
		};
		A_2.Click += delegate
		{
			CheckRequested = true;
			DialogResult = DialogResult.OK;
			Close();
		};
		flowLayoutPanel2.Controls.Add(B);
		flowLayoutPanel2.Controls.Add(a_1);
		flowLayoutPanel2.Controls.Add(A_2);
		tableLayoutPanel.Controls.Add(flowLayoutPanel2, 0, 2);
		Controls.Add(tableLayoutPanel);
		AcceptButton = a_1;
		CancelButton = B;
	}

	[CompilerGenerated]
	private void A_m_1(object? _003Cp0_003E, EventArgs P_1)
	{
		CheckRequested = true;
		DialogResult = DialogResult.OK;
		Close();
	}
}
internal static class f
{
	internal static string Tag
	{
		get
		{
			try
			{
				string code = global::B.J.Code;
				if (string.IsNullOrEmpty(code))
				{
					return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMH();
				}
				return (code.Length >= 4) ? code.Substring(code.Length - 4) : code;
			}
			catch
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMH();
			}
		}
	}

	internal static string CsvHeaderSuffix
	{
		get
		{
			if (!global::a.Q.EnMode)
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMh() + Tag + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ln();
			}
			return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMI() + Tag + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.R();
		}
	}

	internal static string HtmlLine
	{
		get
		{
			string text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMi() + global::A.r.c;
			if (!global::a.Q.EnMode)
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMJ() + text + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMj() + Tag;
			}
			return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMK() + text + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMk() + Tag;
		}
	}

	internal static string LogHeader => _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aML() + Tag + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMl() + global::A.r.c;
}
