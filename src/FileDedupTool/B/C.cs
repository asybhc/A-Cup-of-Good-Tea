using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007B1262ED64_002DD0A6_002D499E_002D9510_002DF2240F018DBB_007D;
using B;
using a;

namespace B
{
	internal sealed class C
	{
		public string A;

		public string a;
	}
	internal static class c
	{
		internal sealed class A
		{
			public List<C> A_f_1;

			public bool A_f_2;
		}

		internal const string A_1 = "-1";

		internal const string a_1 = "根目录";

		internal static List<C> A_m_1()
		{
			return new List<C>
			{
				new C
				{
					A = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iZ(),
					a = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Dw()
				}
			};
		}

		internal static string A_m_1(IEnumerable<C> P_0)
		{
			if (P_0 == null)
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Dw();
			}
			List<string> list = new List<string>();
			foreach (C item in P_0)
			{
				if (item != null && !string.IsNullOrWhiteSpace(item.a))
				{
					list.Add(item.a.Trim());
				}
			}
			if (list.Count != 0)
			{
				return string.Join(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Dv(), list.ToArray());
			}
			return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Dw();
		}

		internal static int A_m_1(IEnumerable<global::a.W> P_0, string P_1)
		{
			if (P_0 == null || string.IsNullOrWhiteSpace(P_1))
			{
				return -1;
			}
			int num = 0;
			foreach (global::a.W item in P_0)
			{
				if (item != null && string.Equals(item.Id, P_1, StringComparison.Ordinal))
				{
					return num;
				}
				num++;
			}
			return -1;
		}

		internal static List<C> A_m_1(IList<C> P_0, int P_1)
		{
			if (P_0 == null || P_0.Count == 0)
			{
				return A_m_1();
			}
			int num = ((P_1 >= 0) ? ((P_1 >= P_0.Count) ? (P_0.Count - 1) : P_1) : 0);
			List<C> list = new List<C>();
			for (int num2 = 0; num2 <= num; num2++)
			{
				list.Add(P_0[num2]);
			}
			return list;
		}

		internal static bool A_m_1(List<C> P_0, global::a.W P_1)
		{
			if (P_0 == null || P_1 == null || string.IsNullOrWhiteSpace(P_1.Id))
			{
				return false;
			}
			P_0.Add(new C
			{
				A = P_1.Id,
				a = (P_1.Name ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D())
			});
			return true;
		}

		internal static bool A_m_1(List<C> P_0)
		{
			if (P_0 == null || P_0.Count <= 1)
			{
				return false;
			}
			P_0.RemoveAt(P_0.Count - 1);
			return true;
		}

		internal static bool A_m_1(List<C> P_0, int P_1)
		{
			if (P_0 == null || P_1 < 0 || P_1 >= P_0.Count - 1)
			{
				return false;
			}
			List<C> collection = A_m_1((IList<C>)P_0, P_1);
			P_0.Clear();
			P_0.AddRange(collection);
			return true;
		}

		internal static string a_m_1(IEnumerable<C> P_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (P_0 == null)
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}
			foreach (C item in P_0)
			{
				if (item != null && !string.IsNullOrWhiteSpace(item.A))
				{
					if (stringBuilder.Length > 0)
					{
						stringBuilder.Append(';');
					}
					stringBuilder.Append(item.A).Append('|').Append(Convert.ToBase64String(Encoding.UTF8.GetBytes(item.a ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D())));
				}
			}
			return stringBuilder.ToString();
		}

		internal static List<C> A_m_1(string P_0)
		{
			List<C> list = new List<C>();
			if (!string.IsNullOrWhiteSpace(P_0))
			{
				string[] array = P_0.Split(';');
				foreach (string text in array)
				{
					int num2 = text.IndexOf('|');
					if (num2 <= 0)
					{
						continue;
					}
					string text2 = text.Substring(0, num2).Trim();
					if (text2.Length != 0)
					{
						string text3 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
						try
						{
							text3 = Encoding.UTF8.GetString(Convert.FromBase64String(text.Substring(num2 + 1)));
						}
						catch
						{
							text3 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
						}
						list.Add(new C
						{
							A = text2,
							a = text3
						});
					}
				}
			}
			if (list.Count == 0)
			{
				return A_m_1();
			}
			if (!string.Equals(list[0].A, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iZ(), StringComparison.Ordinal))
			{
				list.Insert(0, new C
				{
					A = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iZ(),
					a = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Dw()
				});
			}
			if (string.IsNullOrWhiteSpace(list[0].a))
			{
				list[0].a = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Dw();
			}
			return list;
		}

		internal static async Task<A> A_m_1(IList<C> P_0, Func<string, Task<List<global::a.W>>> P_1, CancellationToken P_2 = default(CancellationToken))
		{
			A a2 = new A
			{
				A_f_1 = A_m_1(),
				A_f_2 = false
			};
			if (P_0 == null || P_0.Count <= 1)
			{
				return a2;
			}
			for (int num = 1; num < P_0.Count; num++)
			{
				C c2 = P_0[num];
				if (c2 != null && !string.IsNullOrWhiteSpace(c2.A))
				{
					List<global::a.W> list;
					try
					{
						list = await P_1(a2.A_f_1[a2.A_f_1.Count - 1].A).ConfigureAwait(continueOnCapturedContext: false);
					}
					catch
					{
						list = null;
					}
					P_2.ThrowIfCancellationRequested();
					int num2 = A_m_1(list, c2.A);
					if (list == null || num2 < 0)
					{
						a2.A_f_2 = true;
						a2.A_f_1 = A_m_1();
						return a2;
					}
					string name = list[num2].Name;
					a2.A_f_1.Add(new C
					{
						A = c2.A,
						a = ((!string.IsNullOrWhiteSpace(name)) ? name : (string.IsNullOrWhiteSpace(c2.a) ? c2.A : c2.a))
					});
				}
			}
			return a2;
		}
	}
}
namespace b
{
	internal sealed class C
	{
		public int A;

		public long A_1;

		public int a;

		public int B;
	}
	internal sealed class c : Form
	{
		internal Label A;

		internal CheckBox A_1;

		internal Button A_2;

		internal Button a;

		internal c(string P_0, C P_1)
		{
			Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ye());
			StartPosition = FormStartPosition.CenterParent;
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MinimizeBox = false;
			MaximizeBox = false;
			ShowInTaskbar = false;
			AutoScaleMode = AutoScaleMode.Font;
			Font = global::B.Q.A_m_1(10f);
			ClientSize = new Size(620, 340);
			TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
			{
				Dock = DockStyle.Fill,
				ColumnCount = 1,
				RowCount = 3,
				Padding = new Padding(16)
			};
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			A = new Label
			{
				Text = (P_0 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()),
				Dock = DockStyle.Fill,
				AutoSize = false,
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahj()
			};
			tableLayoutPanel.Controls.Add(A, 0, 0);
			A_1 = new CheckBox
			{
				Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.yf()),
				AutoSize = true,
				Margin = new Padding(0, 12, 0, 8),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahK()
			};
			tableLayoutPanel.Controls.Add(A_1, 0, 1);
			FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel
			{
				FlowDirection = FlowDirection.RightToLeft,
				Dock = DockStyle.Fill,
				AutoSize = true,
				WrapContents = false
			};
			a = new Button
			{
				Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BX()),
				Width = 90,
				Height = 32,
				DialogResult = DialogResult.Cancel,
				Margin = new Padding(6, 0, 0, 0)
			};
			A_2 = new Button
			{
				Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.yg()),
				Width = 130,
				Height = 32,
				Enabled = false,
				DialogResult = DialogResult.OK,
				Margin = new Padding(0)
			};
			flowLayoutPanel.Controls.Add(a);
			flowLayoutPanel.Controls.Add(A_2);
			tableLayoutPanel.Controls.Add(flowLayoutPanel, 0, 2);
			Controls.Add(tableLayoutPanel);
			A_1.CheckedChanged += delegate
			{
				A_2.Enabled = A_1.Checked;
			};
			AcceptButton = A_2;
			CancelButton = a;
		}

		internal static bool A_m_1(IWin32Window P_0, string P_1, C P_2)
		{
			using c c2 = new c(P_1, P_2);
			return c2.ShowDialog(P_0) == DialogResult.OK;
		}

		[CompilerGenerated]
		private void A_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			A_2.Enabled = A_1.Checked;
		}
	}
}
