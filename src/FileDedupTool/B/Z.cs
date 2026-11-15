using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007B1262ED64_002DD0A6_002D499E_002D9510_002DF2240F018DBB_007D;
using B;
using Microsoft.Win32;

namespace B
{
	public enum Z
	{
		A,
		a,
		B,
		b,
		C
	}
	public sealed class z
	{
		public string A = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		public string a = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		public x A_1;

		public Y A_2;

		public y A_3;

		public bool A_4;

		public bool a_1;

		public Func<string, List<N>, bool> A_5;
	}
}
namespace b
{
	public static class Z
	{
		private sealed class A : ProfessionalColorTable
		{
			private readonly Y A_f_1;

			public override Color MenuItemSelected => A_f_1.F;

			public override Color MenuItemSelectedGradientBegin => A_f_1.F;

			public override Color MenuItemSelectedGradientEnd => A_f_1.F;

			public override Color MenuItemPressedGradientBegin => A_f_1.F;

			public override Color MenuItemPressedGradientEnd => A_f_1.F;

			public override Color MenuItemBorder => A_f_1.B;

			public override Color MenuBorder => A_f_1.B;

			public override Color ToolStripDropDownBackground => A_f_1.a;

			public override Color ImageMarginGradientBegin => A_f_1.a;

			public override Color ImageMarginGradientMiddle => A_f_1.a;

			public override Color ImageMarginGradientEnd => A_f_1.a;

			public override Color SeparatorDark => A_f_1.B;

			public override Color SeparatorLight => A_f_1.B;

			public override Color CheckBackground => A_f_1.f;

			public override Color CheckSelectedBackground => A_f_1.g;

			public override Color CheckPressedBackground => A_f_1.f;

			public A(Y P_0)
			{
				A_f_1 = P_0;
				UseSystemColors = false;
			}
		}

		public static bool A_m_1()
		{
			try
			{
				using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLW());
				object obj = registryKey?.GetValue(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLw());
				if (obj is int)
				{
					return (int)obj == 0;
				}
			}
			catch
			{
			}
			return false;
		}

		public static y A_m_1(string P_0)
		{
			if (P_0 == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aco())
			{
				return y.a;
			}
			if (P_0 == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ad())
			{
				return y.B;
			}
			return y.A;
		}

		public static string A_m_1(y P_0)
		{
			return P_0 switch
			{
				y.B => _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ad(), 
				y.a => _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aco(), 
				_ => _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iY(), 
			};
		}

		public static Y a(y P_0)
		{
			if (P_0 != y.a && (P_0 != y.B || !A_m_1()))
			{
				return Y.A_m_1();
			}
			return Y.a_m_1();
		}

		public static void A_m_1(Control P_0, Y P_1, Control P_2)
		{
			a(P_0, P_1, P_2);
			foreach (Control control in P_0.Controls)
			{
				A_m_1(control, P_1, P_2);
			}
			if (!(P_0 is Form form))
			{
				return;
			}
			z.A(form.Handle, P_1.IsDark);
			if (form.MainMenuStrip != null)
			{
				A_m_1(form.MainMenuStrip, P_1);
			}
			foreach (Control control2 in form.Controls)
			{
				ContextMenuStrip contextMenuStrip = control2.ContextMenuStrip;
				if (contextMenuStrip != null)
				{
					A_m_1(contextMenuStrip, P_1);
				}
			}
		}

		public static void A_m_1(ToolStrip P_0, Y P_1)
		{
			if (P_0 == null)
			{
				return;
			}
			P_0.BackColor = P_1.a;
			P_0.ForeColor = P_1.b;
			P_0.RenderMode = ToolStripRenderMode.System;
			P_0.Renderer = new ToolStripProfessionalRenderer(new A(P_1));
			foreach (ToolStripItem item in P_0.Items)
			{
				A_m_1(item, P_1);
			}
		}

		private static void A_m_1(ToolStripItem P_0, Y P_1)
		{
			P_0.BackColor = P_1.a;
			P_0.ForeColor = P_1.b;
			if (!(P_0 is ToolStripMenuItem { DropDown: not null } toolStripMenuItem))
			{
				return;
			}
			toolStripMenuItem.DropDown.BackColor = P_1.a;
			toolStripMenuItem.DropDown.ForeColor = P_1.b;
			toolStripMenuItem.DropDown.Renderer = new ToolStripProfessionalRenderer(new A(P_1));
			foreach (ToolStripItem item in toolStripMenuItem.DropDown.Items)
			{
				A_m_1(item, P_1);
			}
		}

		private static string A_m_1(Control P_0)
		{
			return (P_0.Tag as string) ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
		}

		private static void a(Control P_0, Y P_1, Control P_2)
		{
			string text = A_m_1(P_0);
			if (P_0 is Form form)
			{
				form.BackColor = P_1.A;
				form.ForeColor = P_1.b;
			}
			else if (P_0 is GroupBox groupBox)
			{
				groupBox.BackColor = P_1.a;
				groupBox.ForeColor = P_1.I;
			}
			else if (P_0 is TableLayoutPanel tableLayoutPanel)
			{
				TableLayoutPanel tableLayoutPanel2 = tableLayoutPanel;
				Color backColor;
				if (text == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jp())
				{
					backColor = P_1.A;
				}
				else
				{
					backColor = ((P_0.Parent == null || P_0.Parent is Form) ? P_1.A : P_1.a);
				}
				tableLayoutPanel2.BackColor = backColor;
				tableLayoutPanel.ForeColor = P_1.b;
			}
			else if (P_0 is FlowLayoutPanel flowLayoutPanel)
			{
				flowLayoutPanel.BackColor = ((P_0.Parent != null) ? P_0.Parent.BackColor : P_1.a);
			}
			else if (P_0 is Panel panel)
			{
				if (text == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acP())
				{
					panel.BackColor = P_1.f;
				}
				else if (text == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acx())
				{
					panel.BackColor = P_1.a;
				}
				else if (text == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLX())
				{
					panel.BackColor = P_1.B;
				}
				else
				{
					panel.BackColor = ((P_0.Parent != null && !(P_0.Parent is Form)) ? P_0.Parent.BackColor : P_1.A);
				}
			}
			else if (P_0 is Button button)
			{
				if (text == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acZ())
				{
					button.FlatStyle = FlatStyle.Flat;
					button.FlatAppearance.BorderSize = 0;
					button.BackColor = ((P_0.Parent != null) ? P_0.Parent.BackColor : P_1.a);
					button.ForeColor = P_1.b;
					button.FlatAppearance.MouseOverBackColor = P_1.F;
					button.FlatAppearance.MouseDownBackColor = P_1.F;
					button.UseVisualStyleBackColor = false;
				}
				else
				{
					bool flag = button == P_2;
					button.FlatStyle = FlatStyle.Flat;
					button.FlatAppearance.BorderSize = ((!flag) ? 1 : 0);
					button.FlatAppearance.BorderColor = (flag ? P_1.f : P_1.B);
					button.BackColor = (flag ? P_1.f : P_1.E);
					button.ForeColor = (flag ? P_1.G : P_1.e);
					button.FlatAppearance.MouseOverBackColor = (flag ? P_1.g : P_1.F);
					button.FlatAppearance.MouseDownBackColor = (flag ? P_1.g : P_1.F);
					button.UseVisualStyleBackColor = false;
				}
			}
			else if (P_0 is RichTextBox richTextBox)
			{
				richTextBox.BackColor = P_1.H;
				richTextBox.ForeColor = P_1.h;
				richTextBox.BorderStyle = BorderStyle.None;
			}
			else if (P_0 is TextBox textBox)
			{
				bool flag2 = textBox.Multiline && textBox.ReadOnly;
				textBox.BackColor = (flag2 ? P_1.H : P_1.c);
				textBox.ForeColor = (flag2 ? P_1.h : P_1.D);
				textBox.BorderStyle = BorderStyle.FixedSingle;
			}
			else if (P_0 is ComboBox comboBox)
			{
				comboBox.BackColor = P_1.c;
				comboBox.ForeColor = P_1.D;
				comboBox.FlatStyle = FlatStyle.Flat;
				if (comboBox is global::B.q q2)
				{
					q2.BorderColor = P_1.d;
					q2.Invalidate();
				}
			}
			else if (P_0 is NumericUpDown numericUpDown)
			{
				numericUpDown.BackColor = P_1.c;
				numericUpDown.ForeColor = P_1.D;
			}
			else if (P_0 is ProgressBar progressBar)
			{
				if (progressBar.IsHandleCreated)
				{
					z.A(progressBar.Handle);
				}
				progressBar.BackColor = P_1.H;
				progressBar.ForeColor = P_1.f;
			}
			else if (P_0 is Label label)
			{
				label.BackColor = ((P_0.Parent != null) ? P_0.Parent.BackColor : P_1.a);
				if (text == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abe())
				{
					label.ForeColor = P_1.C;
				}
				else if (text == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Fh() || text == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BH())
				{
					label.ForeColor = P_1.I;
				}
				else
				{
					label.ForeColor = P_1.b;
				}
			}
			else if (P_0 is CheckBox checkBox)
			{
				checkBox.BackColor = ((text == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acZ() && P_0.Parent != null) ? P_0.Parent.BackColor : P_1.a);
				checkBox.ForeColor = P_1.b;
				checkBox.FlatStyle = FlatStyle.Standard;
			}
			else if (P_0 is RadioButton radioButton)
			{
				radioButton.BackColor = P_1.a;
				radioButton.ForeColor = P_1.b;
				radioButton.FlatStyle = FlatStyle.Standard;
			}
			else if (P_0 is ListView listView)
			{
				listView.BackColor = P_1.c;
				listView.ForeColor = P_1.D;
			}
			else if (P_0 is DataGridView dataGridView)
			{
				dataGridView.BackgroundColor = P_1.a;
				dataGridView.ForeColor = P_1.b;
				dataGridView.GridColor = P_1.B;
				dataGridView.DefaultCellStyle.BackColor = P_1.c;
				dataGridView.DefaultCellStyle.ForeColor = P_1.D;
				dataGridView.DefaultCellStyle.SelectionBackColor = P_1.f;
				dataGridView.DefaultCellStyle.SelectionForeColor = P_1.G;
				dataGridView.ColumnHeadersDefaultCellStyle.BackColor = P_1.a;
				dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = P_1.b;
				dataGridView.EnableHeadersVisualStyles = false;
				dataGridView.RowHeadersDefaultCellStyle.BackColor = P_1.a;
				dataGridView.RowHeadersDefaultCellStyle.ForeColor = P_1.b;
			}
			else if (P_0 is TabControl tabControl)
			{
				tabControl.BackColor = P_1.A;
				tabControl.ForeColor = P_1.b;
			}
			else if (P_0 is TabPage tabPage)
			{
				tabPage.BackColor = P_1.a;
				tabPage.ForeColor = P_1.b;
			}
		}
	}
	internal static class z
	{
		[DllImport("uxtheme.dll", CharSet = CharSet.Unicode, EntryPoint = "SetWindowTheme")]
		private static extern int A(nint P_0, string P_1, string P_2);

		[DllImport("dwmapi.dll", EntryPoint = "DwmSetWindowAttribute")]
		private static extern int A(nint P_0, int P_1, ref int P_2, int P_3);

		public static void A(nint P_0)
		{
			try
			{
				A(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
			}
			catch
			{
			}
		}

		public static void A(nint P_0, bool P_1)
		{
			try
			{
				int num = (P_1 ? 1 : 0);
				A(P_0, 20, ref num, 4);
			}
			catch
			{
			}
		}
	}
}
