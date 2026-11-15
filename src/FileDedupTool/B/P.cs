using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007B1262ED64_002DD0A6_002D499E_002D9510_002DF2240F018DBB_007D;
using A;
using B;
using C;
using a;

namespace B
{
	public enum P
	{
		A,
		a,
		B
	}
	public static class p
	{
		private static readonly object A = new object();

		private static string A_1;

		private static string a;

		[CompilerGenerated]
		private static Action<string, P> A_2;

		public static string LogDir
		{
			get
			{
				if (A_1 == null)
				{
					string text = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aca());
					try
					{
						Directory.CreateDirectory(text);
						A_1 = text;
					}
					catch (Exception ex)
					{
						// 24：日志自身不能调用日志，避免递归；用 Debug 输出记录降级原因。
						Debug.WriteLine("创建日志目录失败，回退到临时目录：" + text + "；" + ex.GetType().Name + "：" + ex.Message);
						A_1 = Path.Combine(Path.GetTempPath(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acB());
						Directory.CreateDirectory(A_1);
					}
				}
				return A_1;
			}
		}

		public static string OpsDir
		{
			get
			{
				if (a == null)
				{
					a = Path.Combine(LogDir, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acb());
					try
					{
						Directory.CreateDirectory(a);
					}
					catch (Exception ex)
					{
						Debug.WriteLine("创建操作日志目录失败：" + a + "；" + ex.GetType().Name + "：" + ex.Message);
					}
				}
				return a;
			}
		}

		public static string CurrentLogFile => Path.Combine(LogDir, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acC() + DateTime.Now.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acc()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acD());

		public static event Action<string, P> Line
		{
			[CompilerGenerated]
			add
			{
				Action<string, P> action = A_2;
				Action<string, P> action2;
				do
				{
					action2 = action;
					Action<string, P> value2 = (Action<string, P>)Delegate.Combine(action2, value);
					action = Interlocked.CompareExchange(ref A_2, value2, action2);
				}
				while ((object)action != action2);
			}
			[CompilerGenerated]
			remove
			{
				Action<string, P> action = A_2;
				Action<string, P> action2;
				do
				{
					action2 = action;
					Action<string, P> value2 = (Action<string, P>)Delegate.Remove(action2, value);
					action = Interlocked.CompareExchange(ref A_2, value2, action2);
				}
				while ((object)action != action2);
			}
		}

		public static void A_m_1(string P_0)
		{
			A_m_1(P_0, P.A);
		}

		public static void a_m_1(string P_0)
		{
			A_m_1(P_0, P.a);
		}

		public static void B(string P_0)
		{
			A_m_1(P_0, P.B);
		}

		public static void A_m_1(string P_0, string P_1, string P_2, string P_3, string P_4)
		{
			a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acd() + P_0 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acE() + P_1 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ace() + P_4 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acF() + P_2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acf() + P_3);
		}

		public static void A_m_1(string P_0, string P_1, int P_2, int P_3)
		{
			int num = Math.Max(0, P_3 - P_2);
			a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acG() + P_0 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acE() + P_1 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acg() + P_2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acH() + num + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ach() + P_3);
		}

		public static void A_m_1(string P_0, P P_1)
		{
			string arg = string.Format(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acI(), DateTime.Now, A_m_1(P_1), P_0);
			try
			{
				lock (A)
				{
					b(string.Format(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aci(), DateTime.Now, arg));
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine("写入日志失败：" + ex.GetType().Name + "：" + ex.Message + "；原文：" + arg);
			}
			Action<string, P> a_ = A_2;
			if (a_ != null)
			{
				try
				{
					a_(arg, P_1);
				}
				catch (Exception ex)
				{
					Debug.WriteLine("日志订阅者回调失败：" + ex.GetType().Name + "：" + ex.Message);
				}
			}
		}

		private static string A_m_1(P P_0)
		{
			return P_0 switch
			{
				P.a => _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Iv(), 
				P.B => _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.or(), 
				_ => _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acJ(), 
			};
		}

		private static void b(string P_0)
		{
			string currentLogFile = CurrentLogFile;
			C(currentLogFile);
			if (!File.Exists(currentLogFile))
			{
				File.AppendAllText(currentLogFile, global::C.f.LogHeader + Environment.NewLine, Encoding.UTF8);
			}
			File.AppendAllText(currentLogFile, P_0 + Environment.NewLine, Encoding.UTF8);
		}

		private static void C(string P_0)
		{
			if (!File.Exists(P_0) || new FileInfo(P_0).Length < 1048576)
			{
				return;
			}
			try
			{
				string text = P_0 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acj();
				if (File.Exists(text))
				{
					File.Delete(text);
				}
				if (File.Exists(P_0 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acK()))
				{
					File.Move(P_0 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acK(), text);
				}
				if (File.Exists(P_0 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ack()))
				{
					File.Move(P_0 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ack(), P_0 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acK());
				}
				File.Move(P_0, P_0 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ack());
			}
			catch (Exception ex)
			{
				Debug.WriteLine("日志滚动失败：" + P_0 + "；" + ex.GetType().Name + "：" + ex.Message);
			}
		}
	}
}
namespace b
{
	public sealed class P : Form
	{
		private sealed class A
		{
			public q A_f_1;

			public Q A_f_2;
		}

		[Serializable]
		[CompilerGenerated]
		private sealed class a
		{
			public static readonly a A = new a();

			public static Func<q, b<q, long>> A_1;

			public static Func<b<q, long>, long> A_2;

			public static Func<Q, bool> A_3;

			internal b<q, long> A_m_1(q P_0)
			{
				return new b<q, long>(P_0, P_0.WastedBytes);
			}

			internal long A_m_1(b<q, long> P_0)
			{
				return P_0.W;
			}

			internal bool A_m_1(Q P_0)
			{
				return P_0.A_3;
			}
		}

		[CompilerGenerated]
		private sealed class B
		{
			public global::A.c A;

			internal bool A_m_1(Q P_0)
			{
				return string.Equals(P_0.A, A.a, StringComparison.OrdinalIgnoreCase);
			}
		}

		private readonly R A_1;

		private readonly Y A_2;

		private readonly global::A.x A_3;

		private DataGridView A_4;

		private CheckBox A_5;

		private Label A_6;

		private TextBox A_7;

		private FlowLayoutPanel A_8;

		private Label a_1;

		private RadioButton A_9;

		private RadioButton a_2;

		private Button A_10;

		private Button a_3;

		private Button B_1;

		private Button b;

		private bool A_11;

		public Dictionary<string, string> A_12;

		public Dictionary<string, global::A.Z> A_13;

		public bool a_4 = true;

		public bool B_2;

		public P(R P_0, Y P_1, global::A.x P_2 = null)
		{
			A_1 = P_0;
			A_2 = P_1;
			A_3 = P_2;
			Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Sa(), P_0.A_1.Count, A_m_1(P_0.WastedBytes));
			StartPosition = FormStartPosition.CenterParent;
			Icon = global::A.R.App;
			Font = global::B.Q.A_m_1(10f);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1280, 820);
			MinimumSize = new Size(1000, 640);
			A_m_1();
			Z.A_m_1(this, P_1, A_10);
			global::a.Q.A_m_1(this);
			Shown += delegate
			{
				if (!A_11 && global::a.j.Pro && A_3 != null && global::A.E.A_m_1(A_3) && A_3.AiAutoRun)
				{
					A_11 = true;
					C();
				}
			};
		}

		private void A_m_1()
		{
			SuspendLayout();
			TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
			{
				Dock = DockStyle.Fill,
				ColumnCount = 2,
				RowCount = 2,
				Margin = new Padding(0)
			};
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 340f));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			Controls.Add(tableLayoutPanel);
			A_4 = new DataGridView
			{
				Dock = DockStyle.Fill,
				AllowUserToAddRows = false,
				AllowUserToDeleteRows = false,
				AllowUserToResizeRows = false,
				ReadOnly = false,
				RowHeadersVisible = false,
				SelectionMode = DataGridViewSelectionMode.CellSelect,
				MultiSelect = false,
				AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
				BackgroundColor = A_2.a,
				BorderStyle = BorderStyle.None,
				EnableHeadersVisualStyles = false
			};
			A_4.Columns.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKr(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ot());
			A_4.Columns.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKS(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bh());
			A_4.Columns.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKs(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BI());
			A_4.Columns.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cp(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Le());
			A_4.Columns.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zZ(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Kd());
			A_4.Columns.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKT(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.KE());
			A_4.Columns[0].Width = 56;
			A_4.Columns[1].Width = 60;
			A_4.Columns[2].Width = 92;
			A_4.Columns[4].Width = 90;
			A_4.Columns[5].Width = 130;
			A_4.Columns[3].FillWeight = 100f;
			int num = 0;
			foreach (q item in A_1.A_1)
			{
				num++;
				foreach (Q item2 in item.A_2)
				{
					int index = A_4.Rows.Add();
					DataGridViewRow dataGridViewRow = A_4.Rows[index];
					DataGridViewCheckBoxCell dataGridViewCheckBoxCell = new DataGridViewCheckBoxCell
					{
						Value = (item2.a && !item2.A_3)
					};
					dataGridViewRow.Cells[0] = dataGridViewCheckBoxCell;
					dataGridViewCheckBoxCell.ReadOnly = item2.A_3;
					dataGridViewRow.Cells[1].Value = (item2.A_3 ? item.B : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
					dataGridViewRow.Cells[2].Value = (item2.A_3 ? global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mB()) : global::a.Q.A_m_1(item.a));
					dataGridViewRow.Cells[3].Value = item2.A;
					dataGridViewRow.Cells[4].Value = A_m_1(item2.A_1);
					dataGridViewRow.Cells[5].Value = item2.A_2.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.q());
					dataGridViewRow.Tag = new A
					{
						A_f_1 = item,
						A_f_2 = item2
					};
					if (item2.A_3)
					{
						dataGridViewRow.DefaultCellStyle.ForeColor = A_2.j;
					}
					dataGridViewRow.Cells[0].Tag = item2;
				}
			}
			A_4.CellContentClick += (object P_0, DataGridViewCellEventArgs P_1) =>
			{
				if (P_1.ColumnIndex == 0 && P_1.RowIndex >= 0)
				{
					A_4.EndEdit();
					a_m_1();
				}
			};
			A_4.SelectionChanged += delegate
			{
				b_m_1();
			};
			A_4.CellDoubleClick += (object P_0, DataGridViewCellEventArgs P_1) =>
			{
				if (P_1.RowIndex >= 0)
				{
					string text = Convert.ToString(A_4.Rows[P_1.RowIndex].Cells[3].Value);
					if (File.Exists(global::a.a.A(text)))
					{
						try
						{
							Process.Start(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDI(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDi() + text + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JX());
						}
						catch
						{
						}
					}
				}
			};
			A_5 = new CheckBox
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.OL(),
				AutoSize = true,
				Margin = new Padding(6, 8, 6, 4),
				Font = global::B.Q.A_m_1(10f)
			};
			A_5.CheckedChanged += delegate
			{
				foreach (DataGridViewRow item3 in (IEnumerable)A_4.Rows)
				{
					if (item3.Tag is A a2 && !a2.A_f_2.A_3)
					{
						item3.Cells[0].Value = A_5.Checked;
					}
				}
				A_4.EndEdit();
				a_m_1();
			};
			TableLayoutPanel tableLayoutPanel2 = new TableLayoutPanel
			{
				Dock = DockStyle.Fill,
				ColumnCount = 1,
				RowCount = 2,
				Margin = new Padding(0)
			};
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			tableLayoutPanel2.Controls.Add(A_5, 0, 0);
			tableLayoutPanel2.Controls.Add(A_4, 0, 1);
			tableLayoutPanel.Controls.Add(tableLayoutPanel2, 0, 0);
			TableLayoutPanel tableLayoutPanel3 = new TableLayoutPanel
			{
				Dock = DockStyle.Fill,
				ColumnCount = 1,
				RowCount = 3,
				Padding = new Padding(10, 4, 4, 4)
			};
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 55f));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 45f));
			A_6 = new Label
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(),
				AutoSize = true,
				Font = global::B.Q.A_m_1(10f),
				Margin = new Padding(4, 6, 4, 10),
				MaximumSize = new Size(320, 0)
			};
			tableLayoutPanel3.Controls.Add(A_6, 0, 0);
			a_1 = new Label
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.QJ(),
				AutoSize = true,
				Font = global::B.Q.A_m_1(9.5f, FontStyle.Bold),
				Margin = new Padding(4, 4, 4, 4)
			};
			A_8 = new FlowLayoutPanel
			{
				Dock = DockStyle.Fill,
				AutoScroll = true,
				BorderStyle = BorderStyle.FixedSingle
			};
			TableLayoutPanel tableLayoutPanel4 = new TableLayoutPanel
			{
				Dock = DockStyle.Fill,
				ColumnCount = 1,
				RowCount = 2,
				Margin = new Padding(0)
			};
			tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			tableLayoutPanel4.Controls.Add(a_1, 0, 0);
			tableLayoutPanel4.Controls.Add(A_8, 0, 1);
			tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 1);
			TableLayoutPanel tableLayoutPanel5 = new TableLayoutPanel
			{
				Dock = DockStyle.Fill,
				ColumnCount = 1,
				RowCount = 2,
				Margin = new Padding(0)
			};
			tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			Label control = new Label
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.QI(),
				AutoSize = true,
				Font = global::B.Q.A_m_1(9.5f, FontStyle.Bold),
				Margin = new Padding(4, 8, 4, 4)
			};
			A_7 = new TextBox
			{
				Dock = DockStyle.Fill,
				Multiline = true,
				ReadOnly = true,
				ScrollBars = ScrollBars.Vertical
			};
			tableLayoutPanel5.Controls.Add(control, 0, 0);
			tableLayoutPanel5.Controls.Add(A_7, 0, 1);
			tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 0, 2);
			tableLayoutPanel.Controls.Add(tableLayoutPanel3, 1, 0);
			FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel
			{
				Dock = DockStyle.Fill,
				FlowDirection = FlowDirection.LeftToRight,
				AutoSize = true,
				Margin = new Padding(0),
				Padding = new Padding(8, 8, 8, 8)
			};
			A_9 = new RadioButton
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.OM(),
				AutoSize = true,
				Checked = true,
				Margin = new Padding(3, 10, 3, 3),
				Font = global::B.Q.A_m_1(10f)
			};
			a_2 = new RadioButton
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ON(),
				AutoSize = true,
				Margin = new Padding(3, 10, 16, 3),
				Font = global::B.Q.A_m_1(10f)
			};
			A_10 = new Button
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.OO(),
				AutoSize = true,
				Margin = new Padding(6, 4, 6, 4),
				MinimumSize = new Size(120, 36),
				Font = global::B.Q.A_m_1(10.5f, FontStyle.Bold)
			};
			A_10.Click += delegate
			{
				c();
			};
			a_3 = new Button
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.OG(),
				AutoSize = true,
				Margin = new Padding(6, 4, 6, 4),
				MinimumSize = new Size(130, 36),
				Font = global::B.Q.A_m_1(10f)
			};
			a_3.Click += delegate
			{
				A_m_1(true);
			};
			B_1 = new Button
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.OH(),
				AutoSize = true,
				Margin = new Padding(6, 4, 6, 4),
				MinimumSize = new Size(120, 36),
				Font = global::B.Q.A_m_1(10f)
			};
			B_1.Click += delegate
			{
				A_m_1(false);
			};
			b = new Button
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.OU(),
				AutoSize = true,
				Margin = new Padding(6, 4, 6, 4),
				MinimumSize = new Size(120, 36),
				Font = global::B.Q.A_m_1(10f)
			};
			b.Click += delegate
			{
				if (G.A_m_1(this, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEt(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEU()))
				{
					C();
				}
			};
			Button button = new Button
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.OP(),
				AutoSize = true,
				Margin = new Padding(6, 4, 6, 4),
				MinimumSize = new Size(120, 36),
				Font = global::B.Q.A_m_1(10f)
			};
			button.Click += delegate
			{
				DialogResult = DialogResult.Cancel;
				Close();
			};
			flowLayoutPanel.Controls.Add(A_9);
			flowLayoutPanel.Controls.Add(a_2);
			flowLayoutPanel.Controls.Add(A_10);
			flowLayoutPanel.Controls.Add(b);
			flowLayoutPanel.Controls.Add(a_3);
			flowLayoutPanel.Controls.Add(B_1);
			flowLayoutPanel.Controls.Add(button);
			tableLayoutPanel.Controls.Add(flowLayoutPanel, 0, 1);
			tableLayoutPanel.SetColumnSpan(flowLayoutPanel, 2);
			a_m_1();
			B_m_1();
			ResumeLayout();
		}

		private void a_m_1()
		{
			int num = 0;
			long num2 = 0L;
			foreach (DataGridViewRow item in (IEnumerable)A_4.Rows)
			{
				if (item.Tag is A a2 && !a2.A_f_2.A_3 && item.Cells[0].Value as bool? == true)
				{
					num++;
					num2 += a2.A_f_2.A_1;
				}
			}
			A_6.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Sb(), A_1.A_2, A_1.A_1.Count, A_1.DupFileCount, A_m_1(A_1.WastedBytes)) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kk() + global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Sc(), num, A_m_1(num2)) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kk() + global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Sd());
		}

		private void B_m_1()
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (b<q, long> item in (from P_0 in A_1.A_1
				select new b<q, long>(P_0, P_0.WastedBytes) into P_0
				orderby P_0.W descending
				select P_0).Take(10))
			{
				stringBuilder.AppendLine(string.Format(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKt(), A_m_1(item.W), item.G.a, item.G.A_2[0].A));
			}
			if (stringBuilder.Length == 0)
			{
				stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Sf());
			}
			A_7.Text = stringBuilder.ToString();
		}

		private void b_m_1()
		{
			A_8.Controls.Clear();
			a_1.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.QJ();
			foreach (DataGridViewCell selectedCell in A_4.SelectedCells)
			{
				_ = selectedCell;
			}
			int num = ((A_4.CurrentCell == null) ? (-1) : A_4.CurrentCell.RowIndex);
			if (num < 0 || !(A_4.Rows[num].Tag is A a2) || a2.A_f_1.A_1 != _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CU())
			{
				return;
			}
			a_1.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Se(), a2.A_f_1.B, A_m_1(a2.A_f_1.WastedBytes));
			foreach (Q item in a2.A_f_1.A_2.Take(6))
			{
				try
				{
					Image image;
					using (FileStream stream = File.OpenRead(global::a.a.A(item.A)))
					{
						image = Image.FromStream(stream);
					}
					int num2 = image.Width;
					int num3 = image.Height;
					int num4 = 190;
					if (num2 > num4 || num3 > num4)
					{
						double num5 = Math.Min((double)num4 / (double)num2, (double)num4 / (double)num3);
						num2 = Math.Max(1, (int)((double)num2 * num5));
						num3 = Math.Max(1, (int)((double)num3 * num5));
					}
					PictureBox control = new PictureBox
					{
						Image = new Bitmap(image, num2, num3),
						Size = new Size(num2, num3),
						SizeMode = PictureBoxSizeMode.StretchImage,
						Margin = new Padding(6),
						BorderStyle = BorderStyle.FixedSingle
					};
					image.Dispose();
					TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
					{
						ColumnCount = 1,
						RowCount = 2,
						AutoSize = true,
						Margin = new Padding(2)
					};
					tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
					tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
					Label label = new Label();
					label.Text = (item.A_3 ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abk() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()) + Path.GetFileName(item.A) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JL() + A_m_1(item.A_1) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.R();
					label.AutoSize = true;
					label.MaximumSize = new Size(num4 + 12, 0);
					label.Font = global::B.Q.A_m_1(8.5f);
					label.Margin = new Padding(2);
					Label control2 = label;
					tableLayoutPanel.Controls.Add(control, 0, 0);
					tableLayoutPanel.Controls.Add(control2, 0, 1);
					A_8.Controls.Add(tableLayoutPanel);
				}
				catch
				{
				}
			}
		}

		private void C()
		{
			if (A_3 == null || !global::A.E.A_m_1(A_3))
			{
				MessageBox.Show(this, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.SO()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKU() + global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.SP()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKU() + global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.SQ()), global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.SK()), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			using global::A.e e2 = new global::A.e(A_3, A_1, A_2);
			e2.ShowDialog(this);
			if (e2.A_9 && e2.A_8.Count > 0)
			{
				A_m_1(e2.A_8);
			}
		}

		private void A_m_1(List<global::A.c> P_0)
		{
			A_4.EndEdit();
			int num = 0;
			foreach (global::A.c A in P_0)
			{
				if (A.A < 1 || A.A > A_1.A_1.Count)
				{
					continue;
				}
				q q2 = A_1.A_1[A.A - 1];
				Q q3 = q2.A_2.FirstOrDefault((Q q4) => string.Equals(q4.A, A.a, StringComparison.OrdinalIgnoreCase));
				if (q3 == null)
				{
					continue;
				}
				foreach (Q item in q2.A_2)
				{
					item.A_3 = item == q3;
				}
				num++;
			}
			if (num == 0)
			{
				return;
			}
			foreach (DataGridViewRow item2 in (IEnumerable)A_4.Rows)
			{
				if (item2.Tag is A a2)
				{
					bool flag = a2.A_f_2.A_3;
					item2.Cells[0].Value = !flag;
					item2.Cells[0].ReadOnly = flag;
					item2.Cells[1].Value = (flag ? a2.A_f_1.B : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
					item2.Cells[2].Value = (flag ? global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mB()) : global::a.Q.A_m_1(a2.A_f_1.a));
					item2.DefaultCellStyle.ForeColor = (flag ? A_2.j : A_2.b);
				}
			}
			A_5.Checked = false;
			a_m_1();
			MessageBox.Show(this, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.SM(), num) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKU() + global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.SN()), global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.SL()), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		private void c()
		{
			if (!global::a.j.A_m_1(this, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKu(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKV()))
			{
				return;
			}
			A_4.EndEdit();
			Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
			Dictionary<string, global::A.Z> dictionary2 = new Dictionary<string, global::A.Z>(StringComparer.OrdinalIgnoreCase);
			foreach (DataGridViewRow item in (IEnumerable)A_4.Rows)
			{
				if (!(item.Tag is A a2) || a2.A_f_2.A_3 || item.Cells[0].Value as bool? != true)
				{
					continue;
				}
				Q q2 = a2.A_f_1.A_2.FirstOrDefault((Q P_0) => P_0.A_3);
				if (q2 != null)
				{
					dictionary[A_m_1(a2.A_f_2.A)] = q2.A;
					global::A.Z z2 = a2.A_f_2.A_4;
					if (z2 == null)
					{
						z2 = global::A.Z.A_m_1(a2.A_f_2.A, true, null);
					}
					dictionary2[A_m_1(a2.A_f_2.A)] = z2;
				}
			}
			if (dictionary.Count == 0 && a_2.Checked)
			{
				MessageBox.Show(this, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Sg()), global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bB()), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			A_12 = dictionary;
			A_13 = dictionary2;
			a_4 = A_9.Checked;
			B_2 = true;
			DialogResult = DialogResult.OK;
			Close();
		}

		private void A_m_1(bool P_0)
		{
			global::a.I i2 = G.B(this, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKv(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKW());
			if (!i2.A)
			{
				return;
			}
			try
			{
				using SaveFileDialog saveFileDialog = new SaveFileDialog();
				saveFileDialog.Filter = (P_0 ? global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.SR()) : global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.SS()));
				saveFileDialog.FileName = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.SU()) + DateTime.Now.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGJ()) + (P_0 ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ki() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kF());
				if (saveFileDialog.ShowDialog(this) != DialogResult.OK)
				{
					return;
				}
				if (!i2.A_m_1())
				{
					try
					{
						global::B.p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKw());
					}
					catch
					{
					}
					MessageBox.Show(this, D(), global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKX()), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				int num = i2.a(256);
				if (P_0)
				{
					File.WriteAllText(saveFileDialog.FileName, o.A_m_1(A_1, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKx() + global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ST()), num), new UTF8Encoding(encoderShouldEmitUTF8Identifier: true));
				}
				else
				{
					o.a(A_1, saveFileDialog.FileName, num);
				}
				MessageBox.Show(this, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Sh(), saveFileDialog.FileName), global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Si()), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			catch (Exception ex)
			{
				MessageBox.Show(this, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kg() + ex.Message, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.or(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private static string D()
		{
			if (!global::a.Q.EnMode)
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kJ();
			}
			return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kj();
		}

		private static string A_m_1(string P_0)
		{
			try
			{
				return Path.GetFullPath(P_0).TrimEnd('\\').ToLowerInvariant();
			}
			catch
			{
				return (P_0 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).TrimEnd('\\').ToLowerInvariant();
			}
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

		[CompilerGenerated]
		private void A_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			if (!A_11 && global::a.j.Pro && A_3 != null && global::A.E.A_m_1(A_3) && A_3.AiAutoRun)
			{
				A_11 = true;
				C();
			}
		}

		[CompilerGenerated]
		private void A_m_1(object P_0, DataGridViewCellEventArgs P_1)
		{
			if (P_1.ColumnIndex == 0 && P_1.RowIndex >= 0)
			{
				A_4.EndEdit();
				a_m_1();
			}
		}

		[CompilerGenerated]
		private void a_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			b_m_1();
		}

		[CompilerGenerated]
		private void a_m_1(object P_0, DataGridViewCellEventArgs P_1)
		{
			if (P_1.RowIndex < 0)
			{
				return;
			}
			string text = Convert.ToString(A_4.Rows[P_1.RowIndex].Cells[3].Value);
			if (File.Exists(global::a.a.A(text)))
			{
				try
				{
					Process.Start(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDI(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDi() + text + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JX());
				}
				catch
				{
				}
			}
		}

		[CompilerGenerated]
		private void B_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			foreach (DataGridViewRow item in (IEnumerable)A_4.Rows)
			{
				if (item.Tag is A a2 && !a2.A_f_2.A_3)
				{
					item.Cells[0].Value = A_5.Checked;
				}
			}
			A_4.EndEdit();
			a_m_1();
		}

		[CompilerGenerated]
		private void b_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			c();
		}

		[CompilerGenerated]
		private void C(object? _003Cp0_003E, EventArgs P_1)
		{
			A_m_1(true);
		}

		[CompilerGenerated]
		private void c(object? _003Cp0_003E, EventArgs P_1)
		{
			A_m_1(false);
		}

		[CompilerGenerated]
		private void D(object? _003Cp0_003E, EventArgs P_1)
		{
			if (G.A_m_1(this, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEt(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEU()))
			{
				C();
			}
		}

		[CompilerGenerated]
		private void d(object? _003Cp0_003E, EventArgs P_1)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
	public sealed class p : Form
	{
		private readonly TextBox A;

		private readonly RichTextBox A_1;

		private readonly Label A_2;

		public p(Y P_0)
		{
			Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.pW();
			StartPosition = FormStartPosition.CenterParent;
			Icon = global::A.R.App;
			ClientSize = new Size(720, 520);
			MinimumSize = new Size(520, 400);
			Font = new Font(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acL(), 9f);
			ShowInTaskbar = false;
			TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
			{
				Dock = DockStyle.Fill,
				ColumnCount = 1,
				RowCount = 6,
				Padding = new Padding(14, 12, 14, 12),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jp()
			};
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			Controls.Add(tableLayoutPanel);
			tableLayoutPanel.Controls.Add(new Label
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.pY(),
				AutoSize = true,
				Margin = new Padding(2, 0, 0, 4),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Fh()
			}, 0, 0);
			A = new TextBox
			{
				Dock = DockStyle.Fill,
				Font = new Font(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acL(), 10f),
				BorderStyle = BorderStyle.FixedSingle,
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKY(),
				Margin = new Padding(0, 0, 0, 8)
			};
			A.TextChanged += delegate
			{
				B();
			};
			tableLayoutPanel.Controls.Add(A, 0, 1);
			tableLayoutPanel.Controls.Add(new Label
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKy(),
				AutoSize = true,
				MaximumSize = new Size(680, 0),
				Margin = new Padding(2, 0, 0, 6),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BH()
			}, 0, 2);
			A_2 = new Label
			{
				AutoSize = true,
				Font = new Font(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acL(), 10f, FontStyle.Bold),
				Margin = new Padding(2, 0, 0, 6),
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()
			};
			tableLayoutPanel.Controls.Add(A_2, 0, 3);
			A_1 = new RichTextBox
			{
				Dock = DockStyle.Fill,
				ReadOnly = true,
				BorderStyle = BorderStyle.None,
				Font = new Font(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ME(), 10f),
				WordWrap = false,
				Margin = new Padding(0)
			};
			tableLayoutPanel.Controls.Add(A_1, 0, 4);
			FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel
			{
				Dock = DockStyle.Fill,
				FlowDirection = FlowDirection.LeftToRight,
				AutoSize = true,
				Margin = new Padding(0, 8, 0, 0)
			};
			Button button = new Button
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.YJ(),
				AutoSize = true,
				MinimumSize = new Size(110, 32),
				Margin = new Padding(0, 0, 8, 0)
			};
			button.Click += delegate
			{
				A_m_1();
			};
			Button button2 = new Button
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKZ(),
				AutoSize = true,
				MinimumSize = new Size(130, 32)
			};
			button2.Click += delegate
			{
				a();
			};
			flowLayoutPanel.Controls.Add(button);
			flowLayoutPanel.Controls.Add(button2);
			tableLayoutPanel.Controls.Add(flowLayoutPanel, 0, 5);
			Z.A_m_1(this, P_0, button);
			global::a.Q.A_m_1(this);
			B();
		}

		private void A_m_1()
		{
			string text = global::B.t.A_m_1(Path.GetFileNameWithoutExtension((A.Text ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).Trim()));
			if (text.Length == 0)
			{
				MessageBox.Show(this, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKz(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.YJ(), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			bool flag = global::B.U.a(text);
			MessageBox.Show(this, flag ? (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akB() + text + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akb()) : (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akA() + text + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aka()), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.YJ(), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			B();
		}

		private void a()
		{
			List<string> list = global::B.U.a();
			if (list.Count == 0)
			{
				MessageBox.Show(this, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akC(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.xH(), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			string text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akc() + list.Count + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akD() + string.Join(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BD(), list.GetRange(0, Math.Min(list.Count, 30))) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akd();
			if (MessageBox.Show(this, text, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.xH(), MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				global::B.U.B();
				MessageBox.Show(this, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.YM(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.xH(), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				B();
			}
		}

		private void B()
		{
			string text = (A.Text ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).Trim();
			if (text.Length == 0)
			{
				A_1.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
				A_2.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
				return;
			}
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text);
			string extension = Path.GetExtension(text);
			string text2 = global::B.R.a_m_1(fileNameWithoutExtension);
			string text3 = global::B.R.B_m_1(text2);
			global::B.s s2 = global::B.t.a_m_1(fileNameWithoutExtension, global::B.T.Default);
			string text4;
			if (s2.A == global::B.r.a)
			{
				text4 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.YP();
			}
			else
			{
				text4 = ((s2.A == global::B.r.B) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.YQ() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mB());
			}
			A_2.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akE() + text4 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ake() + global::a.Q.A_m_1(s2.a) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akF() + s2.A_2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akf() + s2.A_1;
			Label a_ = A_2;
			Color foreColor;
			if (s2.A == global::B.r.a)
			{
				foreColor = Color.FromArgb(200, 60, 60);
			}
			else
			{
				foreColor = ((s2.A == global::B.r.B) ? Color.FromArgb(190, 130, 0) : Color.FromArgb(40, 140, 80));
			}
			a_.ForeColor = foreColor;
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akG() + text);
			stringBuilder.AppendLine(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akg() + fileNameWithoutExtension + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akH() + ((extension.Length > 0) ? extension : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akh()));
			stringBuilder.AppendLine(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akI() + ((s2.B.Length > 0) ? s2.B : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aki()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akJ());
			stringBuilder.AppendLine();
			stringBuilder.AppendLine(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akj() + text2 + extension);
			stringBuilder.AppendLine(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akK() + text3 + extension);
			stringBuilder.AppendLine();
			stringBuilder.AppendLine(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akk());
			stringBuilder.AppendLine(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akL() + (s2.A_3 ? (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akM() + global::a.Q.A_m_1(s2.a) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akm()) : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akl()));
			A_m_1(stringBuilder, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.xW(), global::B.R.b_m_1(s2.B) && !global::B.R.h_m_1(s2.B));
			A_m_1(stringBuilder, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.xX(), global::B.R.c_m_1(s2.B));
			A_m_1(stringBuilder, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.xY(), global::B.R.C_m_1(s2.B));
			A_m_1(stringBuilder, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.xZ(), global::B.R.D_m_1(s2.B));
			A_m_1(stringBuilder, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.YA(), global::B.R.d_m_1(s2.B));
			A_m_1(stringBuilder, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.YB(), global::B.R.E_m_1(s2.B));
			A_m_1(stringBuilder, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.YC(), global::B.R.f_m_1(s2.B));
			A_m_1(stringBuilder, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.YD(), global::B.R.F_m_1(s2.B));
			A_m_1(stringBuilder, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.YE(), global::B.R.e_m_1(s2.B));
			stringBuilder.AppendLine(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akN() + ((s2.A_1.StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akn()) || s2.A_1 == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aeM()) ? (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ako() + global::a.Q.A_m_1(s2.a) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akP()) : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akO()));
			stringBuilder.AppendLine();
			stringBuilder.AppendLine(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akp() + global::A.t.a_m_1(text));
			stringBuilder.AppendLine(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akQ() + global::A.t.B(text) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akq());
			stringBuilder.AppendLine();
			if (text3 == fileNameWithoutExtension)
			{
				stringBuilder.AppendLine(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akR());
			}
			else
			{
				stringBuilder.AppendLine(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akr() + text3 + extension + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akm());
			}
			A_1.Text = stringBuilder.ToString();
		}

		private static void A_m_1(StringBuilder P_0, string P_1, bool P_2)
		{
			P_0.AppendLine(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akS() + P_1.PadRight(24) + (P_2 ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aks() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akO()));
		}

		[CompilerGenerated]
		private void A_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			B();
		}

		[CompilerGenerated]
		private void a(object? _003Cp0_003E, EventArgs P_1)
		{
			A_m_1();
		}

		[CompilerGenerated]
		private void B(object? _003Cp0_003E, EventArgs P_1)
		{
			a();
		}
	}
}
