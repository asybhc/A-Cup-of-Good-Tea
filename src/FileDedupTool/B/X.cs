using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007B1262ED64_002DD0A6_002D499E_002D9510_002DF2240F018DBB_007D;
using A;
using B;
using a;
using b;

namespace B
{
	public sealed class X : Form
	{
		internal sealed class A : Form
		{
			[CompilerGenerated]
			private sealed class A_1
			{
				public A A;

				public Action A_1_f_1;

				internal void A_m_1(object? _003Cp0_003E, EventArgs P_1)
				{
					A.Close();
				}

				internal void a(object? _003Cp0_003E, EventArgs P_1)
				{
					A_1_f_1();
					A.Close();
				}
			}

			[CompilerGenerated]
			private Button A_f_1;

			internal Button OpenButton
			{
				[CompilerGenerated]
				get
				{
					return A_f_1;
				}
				[CompilerGenerated]
				private set
				{
					A_f_1 = value;
				}
			}

			internal A(global::b.Y P_0, string P_1, string P_2, string P_3, Action P_4)
			{
				A A = this;
				Text = P_1;
				StartPosition = FormStartPosition.CenterParent;
				FormBorderStyle = FormBorderStyle.FixedDialog;
				MaximizeBox = false;
				MinimizeBox = false;
				ShowInTaskbar = false;
				ClientSize = new Size(640, 260);
				MinimumSize = new Size(640, 220);
				Font = Q.A_m_1(10.5f);
				DoubleBuffered = true;
				TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
				{
					Dock = DockStyle.Fill,
					ColumnCount = 1,
					RowCount = 3,
					Padding = new Padding(18, 16, 18, 14),
					Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jp()
				};
				tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
				tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
				tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
				tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
				Label control = new Label
				{
					Text = P_2,
					AutoSize = true,
					MaximumSize = new Size(600, 0),
					Margin = new Padding(0, 0, 0, 10),
					Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BH()
				};
				tableLayoutPanel.Controls.Add(control, 0, 0);
				Label control2 = new Label
				{
					Text = P_3,
					AutoSize = true,
					MaximumSize = new Size(600, 0),
					Margin = new Padding(0, 0, 0, 6),
					Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Fh()
				};
				tableLayoutPanel.Controls.Add(control2, 0, 1);
				FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel
				{
					Dock = DockStyle.Fill,
					AutoSize = true,
					AutoSizeMode = AutoSizeMode.GrowAndShrink,
					FlowDirection = FlowDirection.RightToLeft,
					WrapContents = false,
					Margin = new Padding(0, 12, 0, 0)
				};
				Button button = A_m_1(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bl()), 84);
				button.Click += delegate
				{
					A.Close();
				};
				OpenButton = A_m_1(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.rJ()), 150, true);
				OpenButton.Click += delegate
				{
					P_4();
					A.Close();
				};
				flowLayoutPanel.Controls.Add(button);
				flowLayoutPanel.Controls.Add(OpenButton);
				tableLayoutPanel.Controls.Add(flowLayoutPanel, 0, 2);
				Controls.Add(tableLayoutPanel);
				global::b.Z.A_m_1(this, P_0, OpenButton);
			}
		}

		[CompilerGenerated]
		private sealed class a
		{
			public X A;

			public string A_1;

			public List<N> A_2;

			internal bool A_m_1()
			{
				using o o2 = new o(A.A_13, A_1, A_2);
				return o2.ShowDialog(A) == DialogResult.OK;
			}
		}

		[CompilerGenerated]
		private sealed class B
		{
			public z A;

			public CancellationToken A_1;

			public X A_2;

			public Action<string, int, int, string> A_3;

			internal void A_m_1()
			{
				global::b.a A_1 = null;
				Exception A = null;
				try
				{
					A_1 = global::b.b.A_m_1(this.A, this.A_1, (string P_0, int P_1, int P_2, string P_3) =>
					{
						A_2.A_m_1(() =>
						{
							A_2.a_m_1(P_0, P_1, P_2);
						});
					});
				}
				catch (Exception ex)
				{
					A = ex;
				}
				A_2.A_m_1(() =>
				{
					A_2.A_12 = false;
					A_2.a_m_1(false);
					if (A != null)
					{
						p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agi(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHp(), A_2.A_1.Text.Trim(), A.Message, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf());
						A_2.A_5.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.QQ() + A.Message;
						A_2.a_5.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.QP();
						A_2.B_2.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mK();
					}
					else
					{
						A_2.A_9 = A_1;
						A_2.a_m_1(A_1);
						A_2.A_5.Text = A_1.a_m_1() + A_2.A_m_1(A_1);
						A_2.B_2.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.QG();
						A_2.a_5.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.QH() + A_1.FileCount + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGz();
						A_2.B_1.Enabled = true;
						A_2.b_1.Enabled = A_1.FileCount > 0;
						A_2.D_1.Enabled = A_1.FileCount > 0;
						p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ang() + A_1.a_m_1());
					}
				});
			}

			internal void A_m_1(string P_0, int P_1, int P_2, string P_3)
			{
				A_2.A_m_1(() =>
				{
					A_2.a_m_1(P_0, P_1, P_2);
				});
			}
		}

		[CompilerGenerated]
		private sealed class b
		{
			public Exception A;

			public global::b.a A_1;

			public B A_2;

			internal void A_m_1()
			{
				A_2.A_2.A_12 = false;
				A_2.A_2.a_m_1(false);
				if (A != null)
				{
					p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agi(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHp(), A_2.A_2.A_1.Text.Trim(), A.Message, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf());
					A_2.A_2.A_5.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.QQ() + A.Message;
					A_2.A_2.a_5.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.QP();
					A_2.A_2.B_2.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mK();
					return;
				}
				A_2.A_2.A_9 = A_1;
				A_2.A_2.a_m_1(A_1);
				A_2.A_2.A_5.Text = A_1.a_m_1() + A_2.A_2.A_m_1(A_1);
				A_2.A_2.B_2.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.QG();
				A_2.A_2.a_5.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.QH() + A_1.FileCount + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGz();
				A_2.A_2.B_1.Enabled = true;
				A_2.A_2.b_1.Enabled = A_1.FileCount > 0;
				A_2.A_2.D_1.Enabled = A_1.FileCount > 0;
				p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ang() + A_1.a_m_1());
			}
		}

		[CompilerGenerated]
		private sealed class C
		{
			public string A;

			public int A_1;

			public int a;

			public B A_2;

			internal void A_m_1()
			{
				A_2.A_2.a_m_1(A, A_1, a);
			}
		}

		[CompilerGenerated]
		private sealed class c
		{
			public z A;

			public X A_1;

			public CancellationToken A_2;

			public Action<string, int, int, string> A_3;

			internal void A_m_1()
			{
				global::b.B A = null;
				string A_1 = null;
				Exception A_2 = null;
				try
				{
					A = global::b.b.A_m_1(this.A, this.A_1.A_9, this.A_2, (string P_0, int P_1, int P_2, string P_3) =>
					{
						this.A_1.A_m_1(() =>
						{
							this.A_1.a_m_1(P_0, P_1, P_2);
						});
					}, out A_1);
				}
				catch (Exception ex)
				{
					A_2 = ex;
				}
				this.A_1.A_m_1(() =>
				{
					this.A_1.A_m_1(A, A_1, A_2, this.A_2.IsCancellationRequested);
				});
			}

			internal void A_m_1(string P_0, int P_1, int P_2, string P_3)
			{
				A_1.A_m_1(() =>
				{
					A_1.a_m_1(P_0, P_1, P_2);
				});
			}
		}

		[CompilerGenerated]
		private sealed class D
		{
			public global::b.B A;

			public string A_1;

			public Exception A_2;

			public c A_3;

			internal void A_m_1()
			{
				A_3.A_1.A_m_1(A, A_1, A_2, A_3.A_2.IsCancellationRequested);
			}
		}

		[CompilerGenerated]
		private sealed class d
		{
			public string A;

			public int A_1;

			public int a;

			public c A_2;

			internal void A_m_1()
			{
				A_2.A_1.a_m_1(A, A_1, a);
			}
		}

		[CompilerGenerated]
		private sealed class E
		{
			public X A;

			public A A_1;

			internal void A_m_1(object? _003Cp0_003E, FormClosedEventArgs P_1)
			{
				if (A.A_15 == A_1)
				{
					A.A_15 = null;
				}
			}
		}

		[CompilerGenerated]
		private sealed class e
		{
			public X A;

			public bool A_1;

			internal void A_m_1()
			{
				w.A A = null;
				try
				{
					A = w.A_m_1(this.A.A_10, A_1, CancellationToken.None);
				}
				catch (Exception ex)
				{
					p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGO(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.nc(), this.A.A_10, ex.Message, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf());
				}
				this.A.A_m_1(() =>
				{
					this.A.A_12 = false;
					this.A.a_m_1(false);
					if (A != null)
					{
						this.A.a_5.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.qL() + A.A_m_1();
						this.A.A_5.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.qK() + A.A_m_1();
						this.A.A_m_1(A);
						p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anH() + A.ToString());
					}
				});
			}
		}

		[CompilerGenerated]
		private sealed class F
		{
			public w.A A;

			public e A_1;

			internal void A_m_1()
			{
				A_1.A.A_12 = false;
				A_1.A.a_m_1(false);
				if (A != null)
				{
					A_1.A.a_5.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.qL() + A.A_m_1();
					A_1.A.A_5.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.qK() + A.A_m_1();
					A_1.A.A_m_1(A);
					p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anH() + A.ToString());
				}
			}
		}

		private TextBox A_1;

		private TextBox a_1;

		private Button A_2;

		private Button a_2;

		private ComboBox A_3;

		private ComboBox a_3;

		private RadioButton A_4;

		private RadioButton a_4;

		private Button B_1;

		private Button b_1;

		private Button C_1;

		private Button c_1;

		private Button D_1;

		private Button d_1;

		private Label A_5;

		private Label a_5;

		private Label B_2;

		private ProgressBar A_6;

		private ListView A_7;

		private CheckBox A_8;

		private global::b.a A_9;

		private string A_10;

		private CancellationTokenSource A_11;

		private bool A_12;

		private bool a_6;

		private readonly global::b.Y A_13;

		private readonly global::A.x A_14;

		private A A_15;

		internal static Action<string> A_16;

		private ToolTip A_17 = new ToolTip
		{
			AutoPopDelay = 20000,
			InitialDelay = 320,
			ReshowDelay = 100,
			ShowAlways = true
		};

		private static string Title => global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.RT()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGt();

		internal global::b.a CurrentPlan => A_9;

		internal Form DonePrompt => A_15;

		public X(global::b.Y P_0, string P_1, string P_2)
			: this(P_0, P_1, P_2, global::A.Y.A_m_1())
		{
		}

		public X(global::b.Y P_0, string P_1, string P_2, global::A.x P_3)
		{
			A_13 = P_0 ?? global::b.Y.A_m_1();
			A_14 = P_3 ?? new global::A.x();
			A_m_1();
			A_1.Text = P_1 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			a_1.Text = P_2 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			a_6 = true;
			try
			{
				A_8.Checked = A_14.OrganizeAutoOpenFolder;
			}
			finally
			{
				a_6 = false;
			}
			global::A.Y.AutoOpenFolderChanged += A_m_1;
			FormClosed += delegate
			{
				global::A.Y.AutoOpenFolderChanged -= A_m_1;
			};
			global::b.Z.A_m_1(this, A_13, b_1);
			global::a.Q.A_m_1(this);
		}

		private void A_m_1(bool P_0)
		{
			if (A_8 == null || A_8.IsDisposed)
			{
				return;
			}
			a_6 = true;
			try
			{
				A_8.Checked = P_0;
				A_14.OrganizeAutoOpenFolder = P_0;
			}
			finally
			{
				a_6 = false;
			}
		}

		private void A_m_1()
		{
			SuspendLayout();
			Text = Title;
			StartPosition = FormStartPosition.CenterParent;
			Icon = global::A.R.App;
			Font = Q.A_m_1(10.5f);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1060, 700);
			MinimumSize = new Size(920, 560);
			DoubleBuffered = true;
			TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
			{
				Dock = DockStyle.Fill,
				ColumnCount = 1,
				RowCount = 6,
				Padding = new Padding(18, 14, 18, 14),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jp()
			};
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			A_m_1(tableLayoutPanel, 0, SizeType.AutoSize);
			A_m_1(tableLayoutPanel, 1, SizeType.AutoSize);
			A_m_1(tableLayoutPanel, 2, SizeType.AutoSize);
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			A_m_1(tableLayoutPanel, 4, SizeType.AutoSize);
			A_m_1(tableLayoutPanel, 5, SizeType.AutoSize);
			Controls.Add(tableLayoutPanel);
			GroupBox groupBox = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.MW());
			TableLayoutPanel tableLayoutPanel2 = A_m_1(3, 2);
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			tableLayoutPanel2.Controls.Add(a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.MZ()), 0, 0);
			A_1 = a_m_1();
			tableLayoutPanel2.Controls.Add(A_1, 1, 0);
			A_2 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.NN(), 84);
			A_2.Click += delegate
			{
				A_m_1(A_1);
			};
			tableLayoutPanel2.Controls.Add(A_2, 2, 0);
			tableLayoutPanel2.Controls.Add(a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mA()), 0, 1);
			a_1 = a_m_1();
			tableLayoutPanel2.Controls.Add(a_1, 1, 1);
			a_2 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.NN(), 84);
			a_2.Click += delegate
			{
				A_m_1(a_1);
			};
			tableLayoutPanel2.Controls.Add(a_2, 2, 1);
			groupBox.Controls.Add(tableLayoutPanel2);
			tableLayoutPanel.Controls.Add(groupBox, 0, 0);
			GroupBox groupBox2 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.MX());
			TableLayoutPanel tableLayoutPanel3 = A_m_1(6, 2);
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			tableLayoutPanel3.Controls.Add(a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.RV()), 0, 0);
			A_3 = new q
			{
				DropDownStyle = ComboBoxStyle.DropDownList,
				Margin = new Padding(0, 6, 14, 6),
				Anchor = AnchorStyles.Left,
				Width = 150
			};
			A_3.Items.AddRange(new object[4]
			{
				_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.RW(),
				_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.RX(),
				_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.RY(),
				_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.RZ()
			});
			A_3.SelectedIndex = 0;
			tableLayoutPanel3.Controls.Add(A_3, 1, 0);
			A_4 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ox(), true);
			a_4 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Oy(), false);
			tableLayoutPanel3.Controls.Add(A_4, 2, 0);
			tableLayoutPanel3.Controls.Add(a_4, 3, 0);
			tableLayoutPanel3.Controls.Add(a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.rB()), 4, 0);
			a_3 = new q
			{
				DropDownStyle = ComboBoxStyle.DropDownList,
				Margin = new Padding(0, 6, 0, 6),
				Anchor = AnchorStyles.Left,
				Width = 240
			};
			a_3.Items.AddRange(new object[3]
			{
				_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGU(),
				_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.oA(),
				_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.If()
			});
			a_3.SelectedIndex = 0;
			tableLayoutPanel3.Controls.Add(a_3, 5, 0);
			A_8 = new CheckBox
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.rH(),
				AutoSize = true,
				Anchor = AnchorStyles.Left,
				Margin = new Padding(2, 8, 10, 2),
				Font = Q.A_m_1(10.5f)
			};
			A_8.CheckedChanged += delegate
			{
				if (a_6)
				{
					return;
				}
				a_6 = true;
				try
				{
					global::A.Y.A_m_1(A_14, A_8.Checked);
				}
				finally
				{
					a_6 = false;
				}
			};
			tableLayoutPanel3.Controls.Add(A_8, 0, 1);
			tableLayoutPanel3.SetColumnSpan(A_8, 6);
			A_m_1(A_3, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGu());
			A_m_1(A_4, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGV());
			A_m_1(a_4, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGv());
			A_m_1(a_3, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGW());
			A_m_1(A_8, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.rI()));
			groupBox2.Controls.Add(tableLayoutPanel3);
			tableLayoutPanel.Controls.Add(groupBox2, 0, 1);
			A_5 = new Label
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.qD(),
				AutoSize = true,
				Anchor = AnchorStyles.Left,
				Margin = new Padding(2, 4, 2, 8),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BH()
			};
			tableLayoutPanel.Controls.Add(A_5, 0, 2);
			GroupBox groupBox3 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.MY());
			A_7 = new ListView
			{
				Dock = DockStyle.Fill,
				View = View.Details,
				FullRowSelect = true,
				GridLines = false,
				HideSelection = false,
				BorderStyle = BorderStyle.None,
				Font = Q.A_m_1(9.5f)
			};
			A_7.Columns.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGw(), 250);
			A_7.Columns.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.rC(), 100);
			A_7.Columns.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGX(), 150);
			A_7.Columns.Add(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.rD()), 250);
			A_7.Columns.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGx(), 210);
			A_7.Columns.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGY(), 160);
			groupBox3.Controls.Add(A_7);
			tableLayoutPanel.Controls.Add(groupBox3, 0, 3);
			FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel
			{
				Dock = DockStyle.Fill,
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				WrapContents = false,
				Margin = new Padding(0, 8, 0, 0)
			};
			B_1 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Oj(), 108);
			B_1.Click += delegate
			{
				C_m_1();
			};
			b_1 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ok(), 116, true);
			b_1.Enabled = false;
			b_1.Click += delegate
			{
				D_m_1();
			};
			C_1 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jY(), 84);
			C_1.Enabled = false;
			C_1.Click += delegate
			{
				E_m_1();
			};
			A_m_1(C_1, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Nu()));
			c_1 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.OF(), 124);
			c_1.Enabled = false;
			c_1.Click += delegate
			{
				g();
			};
			D_1 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.OI(), 100);
			D_1.Enabled = false;
			D_1.Click += delegate
			{
				h();
			};
			d_1 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bl(), 84);
			d_1.Click += delegate
			{
				Close();
			};
			flowLayoutPanel.Controls.Add(B_1);
			flowLayoutPanel.Controls.Add(b_1);
			flowLayoutPanel.Controls.Add(C_1);
			flowLayoutPanel.Controls.Add(c_1);
			flowLayoutPanel.Controls.Add(D_1);
			flowLayoutPanel.Controls.Add(d_1);
			tableLayoutPanel.Controls.Add(flowLayoutPanel, 0, 4);
			TableLayoutPanel tableLayoutPanel4 = A_m_1(2, 2);
			tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			B_2 = new Label
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mK(),
				AutoSize = true,
				Anchor = AnchorStyles.Left,
				Margin = new Padding(2, 0, 8, 2),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Fh()
			};
			a_5 = new Label
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mK(),
				AutoSize = true,
				Anchor = AnchorStyles.Right,
				TextAlign = ContentAlignment.MiddleRight,
				Margin = new Padding(0, 0, 2, 2),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Fh()
			};
			A_6 = new ProgressBar
			{
				Dock = DockStyle.Fill,
				Height = 12,
				Maximum = 1000,
				Margin = new Padding(0)
			};
			tableLayoutPanel4.Controls.Add(B_2, 0, 0);
			tableLayoutPanel4.Controls.Add(a_5, 1, 0);
			tableLayoutPanel4.Controls.Add(A_6, 0, 1);
			tableLayoutPanel4.SetColumnSpan(A_6, 2);
			tableLayoutPanel.Controls.Add(tableLayoutPanel4, 0, 5);
			FormClosing += (object P_0, FormClosingEventArgs P_1) =>
			{
				if (A_12)
				{
					if (MessageBox.Show(this, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agu(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.oQ(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
					{
						P_1.Cancel = true;
					}
					else if (A_11 != null)
					{
						A_11.Cancel();
					}
				}
			};
			ResumeLayout(performLayout: true);
		}

		private static void A_m_1(TableLayoutPanel P_0, int P_1, SizeType P_2)
		{
			P_0.RowStyles.Add(new RowStyle(P_2));
		}

		private void A_m_1(Control P_0, string P_1)
		{
			A_17.SetToolTip(P_0, P_1);
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
				Margin = new Padding(0, 0, 0, 10),
				Font = Q.A_m_1(10.5f)
			};
		}

		private static TableLayoutPanel A_m_1(int P_0, int P_1)
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

		private static TextBox a_m_1()
		{
			return new TextBox
			{
				Dock = DockStyle.Fill,
				Font = Q.A_m_1(10.5f),
				Margin = new Padding(0, 5, 10, 5),
				BorderStyle = BorderStyle.FixedSingle
			};
		}

		private static Button A_m_1(string P_0, int P_1, bool P_2 = false)
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
				Font = Q.A_m_1(P_2 ? 10.5f : 10f, P_2 ? FontStyle.Bold : FontStyle.Regular),
				Cursor = Cursors.Hand
			};
		}

		private static RadioButton A_m_1(string P_0, bool P_1)
		{
			return new RadioButton
			{
				Text = P_0,
				Checked = P_1,
				AutoSize = true,
				Margin = new Padding(2, 6, 10, 6),
				FlatStyle = FlatStyle.Standard,
				Font = Q.A_m_1(10.5f)
			};
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

		private x B_m_1()
		{
			return A_3.SelectedIndex switch
			{
				1 => x.a, 
				2 => x.B, 
				3 => x.b, 
				_ => x.A, 
			};
		}

		private z b_m_1()
		{
			return new z
			{
				A = A_1.Text.Trim().Trim('"'),
				a = a_1.Text.Trim().Trim('"'),
				A_1 = B_m_1(),
				A_2 = (a_4.Checked ? Y.a : Y.A),
				A_3 = ((a_3.SelectedIndex != 0) ? ((a_3.SelectedIndex == 1) ? y.a : y.B) : y.A),
				a_1 = (A_14 != null && A_14.AutoReleaseLock),
				A_5 = A_m_1
			};
		}

		private bool A_m_1(string P_0, List<N> P_1)
		{
			if (Q.A_38 != null)
			{
				return Q.A_38(P_0, P_1);
			}
			if (IsDisposed || !IsHandleCreated)
			{
				return false;
			}
			try
			{
				return Invoke(() =>
				{
					using o o2 = new o(A_13, P_0, P_1);
					return o2.ShowDialog(this) == DialogResult.OK;
				});
			}
			catch
			{
				return false;
			}
		}

		private bool A_m_1(out z P_0)
		{
			P_0 = b_m_1();
			if (!global::b.b.A_m_1(P_0, out var text))
			{
				MessageBox.Show(this, text, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bB(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			return true;
		}

		private void C_m_1()
		{
			if (A_12 || !global::a.j.A_m_1(this, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGy(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGZ()) || !A_m_1(out var A))
			{
				return;
			}
			e_m_1();
			A_12 = true;
			a_m_1(true);
			A_9 = null;
			b_1.Enabled = false;
			c_1.Enabled = false;
			D_1.Enabled = false;
			A_7.Items.Clear();
			A_5.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Qt();
			B_2.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.QV();
			a_5.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Qq();
			A_6.Value = 0;
			A_11 = new CancellationTokenSource();
			CancellationToken A_1 = A_11.Token;
			Task.Run(() =>
			{
				global::b.a A_2 = null;
				Exception A2 = null;
				try
				{
					A_2 = global::b.b.A_m_1(A, A_1, (string P_0, int P_1, int P_2, string P_3) =>
					{
						A_m_1(() =>
						{
							a_m_1(P_0, P_1, P_2);
						});
					});
				}
				catch (Exception ex)
				{
					A2 = ex;
				}
				A_m_1(() =>
				{
					A_12 = false;
					a_m_1(false);
					if (A2 != null)
					{
						p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agi(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHp(), this.A_1.Text.Trim(), A2.Message, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf());
						A_5.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.QQ() + A2.Message;
						a_5.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.QP();
						B_2.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mK();
					}
					else
					{
						A_9 = A_2;
						a_m_1(A_2);
						A_5.Text = A_2.a_m_1() + A_m_1(A_2);
						B_2.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.QG();
						a_5.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.QH() + A_2.FileCount + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGz();
						B_1.Enabled = true;
						b_1.Enabled = A_2.FileCount > 0;
						D_1.Enabled = A_2.FileCount > 0;
						p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ang() + A_2.a_m_1());
					}
				});
			});
		}

		internal global::b.a c_m_1()
		{
			z z2 = b_m_1();
			if (!global::b.b.A_m_1(z2, out var message))
			{
				throw new InvalidOperationException(message);
			}
			A_9 = global::b.b.A_m_1(z2, CancellationToken.None, null);
			a_m_1(A_9);
			A_5.Text = A_9.a_m_1() + A_m_1(A_9);
			B_2.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.QG();
			a_5.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.QH() + A_9.FileCount + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGz();
			b_1.Enabled = A_9.FileCount > 0;
			c_1.Enabled = false;
			D_1.Enabled = A_9.FileCount > 0;
			return A_9;
		}

		private string A_m_1(global::b.a P_0)
		{
			List<KeyValuePair<string, int>> list = P_0.A_m_1();
			if (list.Count == 0)
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}
			StringBuilder stringBuilder = new StringBuilder(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agA());
			int num = 0;
			foreach (KeyValuePair<string, int> item in list)
			{
				if (num >= 6)
				{
					stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aga());
					break;
				}
				if (num > 0)
				{
					stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bH());
				}
				stringBuilder.Append(item.Key).Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aH()).Append(item.Value);
				num++;
			}
			return stringBuilder.ToString();
		}

		private void a_m_1(global::b.a P_0)
		{
			A_7.BeginUpdate();
			A_7.Items.Clear();
			foreach (global::b.A item in P_0.A_6)
			{
				ListViewItem listViewItem = new ListViewItem(Path.GetFileName(item.A_f_1));
				listViewItem.SubItems.Add(global::b.b.A_m_1(item.A_f_4));
				listViewItem.SubItems.Add(item.A_f_3.HasValue ? item.A_f_3.Value.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CI()) : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
				listViewItem.SubItems.Add(Path.GetFileName(item.B));
				listViewItem.SubItems.Add(item.a);
				listViewItem.SubItems.Add((item.d.Length == 0) ? A_m_1(item, P_0) : item.d);
				listViewItem.Tag = item;
				A_7.Items.Add(listViewItem);
			}
			A_7.EndUpdate();
		}

		private static string A_m_1(global::b.A P_0, global::b.a P_1)
		{
			if (P_0.C_1)
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agB();
			}
			if (P_0.a_1)
			{
				if (P_1.A_3 != Y.a)
				{
					return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agb();
				}
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agC();
			}
			if (P_0.B_1)
			{
				if (!P_0.b_1)
				{
					return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agc();
				}
				return global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.rF());
			}
			if (P_0.b_1)
			{
				return global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.rE());
			}
			return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agD();
		}

		private void D_m_1()
		{
			if (A_12 || A_9 == null || !global::a.j.A_m_1(this, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agd(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agE()) || !A_m_1(out var A))
			{
				return;
			}
			e_m_1();
			if (A.A_2 != A_9.A_3 || A.A_1 != A_9.A_2 || A.A_3 != A_9.A_4 || !string.Equals(A.a.TrimEnd('\\'), A_9.a_f_1.TrimEnd('\\'), StringComparison.OrdinalIgnoreCase))
			{
				MessageBox.Show(this, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.age(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bB(), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			string text;
			if (A.A_3 != y.A)
			{
				text = ((A.A_3 != y.B) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.oA() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.If());
			}
			else
			{
				text = ((A.A_2 == Y.a) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agF() : string.Format(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.IH(), A_9.PredictedDeleteCount, global::b.a.A_m_1(A_9.PredictedDeleteBytes)));
			}
			string text2 = ((A.A_2 == Y.a) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ii() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agf());
			string text3 = string.Format(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agG(), (A.A_2 == Y.a) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.IE() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Id(), A_9.FileCount, global::b.a.A_m_1(A_9.TotalBytes), A_9.a_m_1(), A.a, text, text2);
			if (MessageBox.Show(this, text3, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.sX(), MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
			{
				return;
			}
			A_12 = true;
			a_m_1(true);
			B_2.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.QW();
			a_5.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.QX();
			A_6.Value = 0;
			A_11 = new CancellationTokenSource();
			CancellationToken A_2 = A_11.Token;
			Task.Run(() =>
			{
				global::b.B A2 = null;
				string A_3 = null;
				Exception A_4 = null;
				try
				{
					A2 = global::b.b.A_m_1(A, A_9, A_2, (string P_0, int P_1, int P_2, string P_3) =>
					{
						A_m_1(() =>
						{
							a_m_1(P_0, P_1, P_2);
						});
					}, out A_3);
				}
				catch (Exception ex)
				{
					A_4 = ex;
				}
				A_m_1(() =>
				{
					A_m_1(A2, A_3, A_4, A_2.IsCancellationRequested);
				});
			});
		}

		internal global::b.B d_m_1()
		{
			return A_m_1(CancellationToken.None);
		}

		internal global::b.B A_m_1(CancellationToken P_0)
		{
			if (A_9 == null)
			{
				throw new InvalidOperationException(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agg());
			}
			global::b.B b2 = global::b.b.A_m_1(b_m_1(), A_9, P_0, null, out var text);
			A_m_1(b2, text, null, P_0.IsCancellationRequested);
			return b2;
		}

		internal void A_m_1(global::b.B P_0, Exception P_1, bool P_2)
		{
			A_m_1(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agH(), P_1, P_2);
		}

		internal void E_m_1()
		{
			if (A_11 != null && !A_11.IsCancellationRequested)
			{
				A_11.Cancel();
				a_5.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Nv());
				p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agh());
			}
		}

		private void A_m_1(global::b.B P_0, string P_1, Exception P_2, bool P_3)
		{
			A_12 = false;
			a_m_1(false);
			A_10 = P_1;
			if (P_2 != null)
			{
				A_5.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.qA() + P_2.Message;
				a_5.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.QZ();
				B_2.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mK();
				p.B(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agI() + P_2.Message);
				p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agi(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agJ(), F_m_1(), P_2.Message, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf());
				a_m_1(P_0, P_1, P_2, false);
				return;
			}
			if (P_0 == null)
			{
				P_0 = new global::b.B();
			}
			G();
			A_5.Text = P_0.A_m_1() + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bA() + global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.IB()) + P_1;
			Label b_ = B_2;
			string text;
			if (P_3)
			{
				text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jt());
			}
			else
			{
				text = (P_0.A_2 ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.SX() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.QY());
			}
			b_.Text = text;
			a_5.Text = (P_3 ? global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jt()) : P_0.A_m_1());
			if (P_3)
			{
				p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agi(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agJ(), P_0.a + P_0.b + P_0.B_f_1, P_0.A);
			}
			c_1.Enabled = !P_0.a_2 && P_0.e > 0;
			D_1.Enabled = true;
			b_1.Enabled = false;
			p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agj() + P_0.ToString() + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agK() + P_1 + (P_3 ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agk() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()));
			a_m_1(P_0, P_1, null, P_3);
		}

		private void e_m_1()
		{
			A a_ = A_15;
			A_15 = null;
			if (a_ != null && !a_.IsDisposed)
			{
				a_.Close();
				a_.Dispose();
			}
		}

		private bool A_m_1(global::b.B P_0, Exception P_1, bool P_2, string P_3)
		{
			if (!A_14.OrganizeAutoOpenFolder)
			{
				return false;
			}
			if (((P_1 != null) | P_2) || P_0 == null)
			{
				return false;
			}
			if (P_0.A_2 || P_0.a <= 0)
			{
				return false;
			}
			if (!string.IsNullOrWhiteSpace(P_3))
			{
				return Directory.Exists(P_3);
			}
			return false;
		}

		private string F_m_1()
		{
			if (A_9 != null && !string.IsNullOrWhiteSpace(A_9.a_f_1))
			{
				return A_9.a_f_1;
			}
			return (a_1.Text ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).Trim().Trim('"');
		}

		private void a_m_1(global::b.B P_0, string P_1, Exception P_2, bool P_3)
		{
			e_m_1();
			string text = F_m_1();
			if (A_m_1(P_0, P_2, P_3, text))
			{
				f();
				return;
			}
			string text2;
			if (P_2 != null)
			{
				text2 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.QZ();
			}
			else
			{
				text2 = (P_3 ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jt() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.QY());
			}
			string text3;
			if (P_2 != null)
			{
				text3 = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.qA()) + P_2.Message;
			}
			else
			{
				text3 = (P_0 ?? new global::b.B()).A_m_1();
				if (P_3)
				{
					text3 = text3 + Environment.NewLine + global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.rt());
				}
				if (!string.IsNullOrEmpty(P_1))
				{
					text3 = text3 + Environment.NewLine + global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.IB()) + P_1;
				}
			}
			A A_1 = new A(A_13, global::a.Q.A_m_1(text2), text3, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.rr()) + text, f);
			A_15 = A_1;
			A_1.FormClosed += delegate
			{
				if (A_15 == A_1)
				{
					A_15 = null;
				}
			};
			A_1.Show(this);
		}

		internal void f()
		{
			string text = F_m_1();
			if (string.IsNullOrWhiteSpace(text))
			{
				return;
			}
			if (A_16 != null)
			{
				A_16(text);
				return;
			}
			if (!Directory.Exists(text))
			{
				MessageBox.Show(this, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.rs()), global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bB()), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			try
			{
				Process.Start(new ProcessStartInfo(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDI(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JX() + text + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JX())
				{
					UseShellExecute = true
				});
				p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agL() + text);
			}
			catch (Exception ex)
			{
				p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adj() + ex.Message);
				MessageBox.Show(this, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.TX(), ex.Message), global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bB()), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void G()
		{
			if (A_9 == null)
			{
				return;
			}
			A_7.BeginUpdate();
			foreach (ListViewItem item in A_7.Items)
			{
				if (item.Tag is global::b.A a2)
				{
					item.SubItems[3].Text = Path.GetFileName(a2.B);
					item.SubItems[4].Text = a2.a;
					string text = ((a2.d.Length == 0) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agl() : a2.d);
					if (a2.E.Length > 0)
					{
						text = text + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ah() + a2.E;
					}
					else if (a2.D.Length > 0)
					{
						text = text + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ah() + a2.D;
					}
					item.SubItems[5].Text = text;
				}
			}
			A_7.EndUpdate();
		}

		internal void A_m_1(string P_0, int P_1, int P_2)
		{
			a_m_1(P_0, P_1, P_2);
		}

		private void a_m_1(string P_0, int P_1, int P_2)
		{
			B_2.Text = P_0 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aH() + P_1 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Dv() + P_2;
			a_5.Text = P_0;
			int num = (int)((P_2 > 0) ? Math.Min(1000L, (long)P_1 * 1000L / P_2) : 0);
			if (num >= 0 && num <= A_6.Maximum)
			{
				A_6.Value = num;
			}
		}

		private void a_m_1(bool P_0)
		{
			B_1.Enabled = !P_0;
			b_1.Enabled = !P_0 && A_9 != null && A_9.FileCount > 0;
			C_1.Enabled = P_0;
			c_1.Enabled = !P_0 && !string.IsNullOrEmpty(A_10);
			D_1.Enabled = !P_0 && A_9 != null && A_9.FileCount > 0;
			d_1.Enabled = true;
			TextBox textBox = A_1;
			TextBox textBox2 = a_1;
			Button button = A_2;
			bool flag = (a_2.Enabled = !P_0);
			bool flag3 = (button.Enabled = flag);
			bool enabled = (textBox2.Enabled = flag3);
			textBox.Enabled = enabled;
			ComboBox comboBox = A_3;
			ComboBox comboBox2 = a_3;
			RadioButton radioButton = A_4;
			flag = (a_4.Enabled = !P_0);
			flag3 = (radioButton.Enabled = flag);
			enabled = (comboBox2.Enabled = flag3);
			comboBox.Enabled = enabled;
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

		private void g()
		{
			if (A_12 || string.IsNullOrEmpty(A_10) || !global::a.j.A_m_1(this, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agM(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agm()))
			{
				return;
			}
			bool A_1 = A_14 == null || A_14.UndoRestoreRecycle;
			string text = (global::a.Q.EnMode ? (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agP() + A_10 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agp() + (A_1 ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agq() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agQ()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adQ()) : (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agN() + A_10 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agn() + (A_1 ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ago() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agO()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adO()));
			if (MessageBox.Show(this, text, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.OF()), MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) != DialogResult.OK)
			{
				return;
			}
			A_12 = true;
			a_m_1(true);
			a_5.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.qH();
			Task.Run(() =>
			{
				w.A A = null;
				try
				{
					A = w.A_m_1(A_10, A_1, CancellationToken.None);
				}
				catch (Exception ex)
				{
					p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGO(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.nc(), A_10, ex.Message, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf());
				}
				A_m_1(() =>
				{
					A_12 = false;
					a_m_1(false);
					if (A != null)
					{
						a_5.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.qL() + A.A_m_1();
						A_5.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.qK() + A.A_m_1();
						A_m_1(A);
						p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anH() + A.ToString());
					}
				});
			});
		}

		internal w.A H()
		{
			if (string.IsNullOrEmpty(A_10))
			{
				throw new InvalidOperationException(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agR());
			}
			bool flag = A_14 == null || A_14.UndoRestoreRecycle;
			w.A a2 = w.A_m_1(A_10, flag, CancellationToken.None);
			a_5.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.qL() + a2.A_m_1();
			A_5.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.qK() + a2.A_m_1();
			A_m_1(a2);
			return a2;
		}

		private void A_m_1(w.A P_0)
		{
			B_2.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.qJ();
			if (A_9 == null || P_0.A_f_1 <= 0)
			{
				return;
			}
			A_7.BeginUpdate();
			foreach (ListViewItem item in A_7.Items)
			{
				if (item.Tag is global::b.A a2 && a2.d == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.IK())
				{
					item.SubItems[5].Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.qM();
				}
			}
			A_7.EndUpdate();
		}

		private void h()
		{
			if (A_9 == null)
			{
				return;
			}
			global::a.I i2 = global::b.G.B(this, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agr(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agS());
			if (!i2.A)
			{
				return;
			}
			using SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Title = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.OJ();
			saveFileDialog.Filter = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ags();
			saveFileDialog.FileName = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agT() + DateTime.Now.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGJ()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kF();
			if (saveFileDialog.ShowDialog(this) != DialogResult.OK)
			{
				return;
			}
			if (!i2.A_m_1())
			{
				try
				{
					p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agt());
				}
				catch
				{
				}
				MessageBox.Show(this, global::a.Q.EnMode ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kj() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kJ(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bB(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			try
			{
				A_9.A_m_1(saveFileDialog.FileName, i2.a(64));
				p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agU() + saveFileDialog.FileName);
				a_5.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.qN();
			}
			catch (Exception ex)
			{
				MessageBox.Show(this, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kg() + ex.Message, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bB(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		[CompilerGenerated]
		private void A_m_1(object? _003Cp0_003E, FormClosedEventArgs P_1)
		{
			global::A.Y.AutoOpenFolderChanged -= A_m_1;
		}

		[CompilerGenerated]
		private void A_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			A_m_1(A_1);
		}

		[CompilerGenerated]
		private void a_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			A_m_1(a_1);
		}

		[CompilerGenerated]
		private void B_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			if (a_6)
			{
				return;
			}
			a_6 = true;
			try
			{
				global::A.Y.A_m_1(A_14, A_8.Checked);
			}
			finally
			{
				a_6 = false;
			}
		}

		[CompilerGenerated]
		private void b_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			C_m_1();
		}

		[CompilerGenerated]
		private void C_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			D_m_1();
		}

		[CompilerGenerated]
		private void c_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			E_m_1();
		}

		[CompilerGenerated]
		private void D_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			g();
		}

		[CompilerGenerated]
		private void d_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			h();
		}

		[CompilerGenerated]
		private void E_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			Close();
		}

		[CompilerGenerated]
		private void A_m_1(object P_0, FormClosingEventArgs P_1)
		{
			if (A_12)
			{
				if (MessageBox.Show(this, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agu(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.oQ(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
				{
					P_1.Cancel = true;
				}
				else if (A_11 != null)
				{
					A_11.Cancel();
				}
			}
		}
	}
	public enum x
	{
		A,
		a,
		B,
		b
	}
}
namespace b
{
	public sealed class X : Form
	{
		private readonly global::B.V A;

		private readonly Y A_1;

		private readonly DataGridView A_2;

		private readonly Label A_3;

		private readonly HashSet<string> A_4 = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

		public HashSet<string> a = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

		public int SuspectCount
		{
			get
			{
				if (A != null)
				{
					return A.a.Count;
				}
				return 0;
			}
		}

		public X(global::B.V P_0, Y P_1)
		{
			A = P_0 ?? new global::B.V();
			A_1 = P_1 ?? Y.A_m_1();
			Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.xa();
			StartPosition = FormStartPosition.CenterParent;
			Icon = global::A.R.App;
			Font = global::B.Q.A_m_1(10f);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1180, 720);
			MinimumSize = new Size(1000, 600);
			ShowInTaskbar = false;
			TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
			{
				Dock = DockStyle.Fill,
				ColumnCount = 1,
				RowCount = 3,
				Padding = new Padding(12, 10, 12, 10)
			};
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			Controls.Add(tableLayoutPanel);
			A_3 = new Label
			{
				AutoSize = true,
				MaximumSize = new Size(1140, 0),
				Margin = new Padding(2, 0, 2, 8),
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLu()
			};
			tableLayoutPanel.Controls.Add(A_3, 0, 0);
			A_2 = new DataGridView
			{
				Dock = DockStyle.Fill,
				AllowUserToAddRows = false,
				AllowUserToDeleteRows = false,
				AllowUserToResizeRows = false,
				RowHeadersVisible = false,
				SelectionMode = DataGridViewSelectionMode.FullRowSelect,
				MultiSelect = true,
				AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
				BackgroundColor = A_1.a,
				BorderStyle = BorderStyle.None,
				EnableHeadersVisualStyles = false,
				Margin = new Padding(0)
			};
			A_2.Columns.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLV(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.xb());
			A_2.Columns.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKr(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ot());
			A_2.Columns.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zP(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Td());
			A_2.Columns.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cp(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Te());
			A_2.Columns.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zZ(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Kd());
			A_2.Columns.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aO(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.xc());
			A_2.Columns[_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLV()].Width = 90;
			A_2.Columns[_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKr()].Width = 62;
			A_2.Columns[_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zP()].FillWeight = 26f;
			A_2.Columns[_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cp()].FillWeight = 46f;
			A_2.Columns[_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zZ()].Width = 92;
			A_2.Columns[_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aO()].FillWeight = 28f;
			A_2.Columns[_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zP()].DefaultCellStyle.WrapMode = DataGridViewTriState.False;
			A_2.RowTemplate.Height = 26;
			A_m_1();
			tableLayoutPanel.Controls.Add(A_2, 0, 1);
			FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel
			{
				Dock = DockStyle.Fill,
				FlowDirection = FlowDirection.LeftToRight,
				AutoSize = true,
				Margin = new Padding(0, 8, 0, 0)
			};
			Button button = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.xD());
			button.Click += delegate
			{
				A_m_1(true);
			};
			Button button2 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.xE());
			button2.Click += delegate
			{
				A_m_1(false);
			};
			Button button3 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.xF());
			button3.Click += delegate
			{
				b();
				DialogResult = DialogResult.OK;
				Close();
			};
			Button button4 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.xG());
			button4.Click += delegate
			{
				C();
			};
			Button button5 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.xH());
			button5.Click += delegate
			{
				c();
			};
			Button button6 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.xI());
			button6.Click += delegate
			{
				a.Clear();
				DialogResult = DialogResult.Cancel;
				Close();
			};
			flowLayoutPanel.Controls.Add(button);
			flowLayoutPanel.Controls.Add(button2);
			flowLayoutPanel.Controls.Add(button3);
			flowLayoutPanel.Controls.Add(button4);
			flowLayoutPanel.Controls.Add(button5);
			flowLayoutPanel.Controls.Add(button6);
			tableLayoutPanel.Controls.Add(flowLayoutPanel, 0, 2);
			A_2.CurrentCellDirtyStateChanged += delegate
			{
				if (A_2.IsCurrentCellDirty)
				{
					A_2.CommitEdit(DataGridViewDataErrorContexts.Commit);
				}
			};
			A_2.CellContentClick += (object obj, DataGridViewCellEventArgs e2) =>
			{
				if (e2.ColumnIndex == 1 && e2.RowIndex >= 0)
				{
					BeginInvoke(new MethodInvoker(a_m_1));
				}
			};
			A_2.CellValueChanged += delegate
			{
				a_m_1();
			};
			Z.A_m_1(this, A_1, button3);
			global::a.Q.A_m_1(this);
			a_m_1();
			B();
		}

		private Button A_m_1(string P_0)
		{
			return new Button
			{
				Text = P_0,
				AutoSize = true,
				MinimumSize = new Size(110, 34),
				Margin = new Padding(4, 6, 4, 0),
				Font = global::B.Q.A_m_1(10f)
			};
		}

		private void A_m_1()
		{
			foreach (global::B.u item in A.A)
			{
				A_m_1(item, true);
			}
			foreach (global::B.u item2 in A.a)
			{
				A_m_1(item2, false);
			}
		}

		private void A_m_1(global::B.u P_0, bool P_1)
		{
			int index = A_2.Rows.Add();
			DataGridViewRow dataGridViewRow = A_2.Rows[index];
			dataGridViewRow.Cells[0].Value = (P_1 ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.xJ() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.xK());
			dataGridViewRow.Cells[1] = new DataGridViewCheckBoxCell
			{
				Value = P_1
			};
			dataGridViewRow.Cells[1].ReadOnly = P_1;
			dataGridViewRow.Cells[2].Value = Path.GetFileName(P_0.A);
			dataGridViewRow.Cells[3].Value = P_0.A;
			dataGridViewRow.Cells[4].Value = A_m_1(P_0.A_1);
			dataGridViewRow.Cells[5].Value = A_m_1(P_0.A_2);
			dataGridViewRow.Tag = P_0;
			if (P_1)
			{
				dataGridViewRow.DefaultCellStyle.ForeColor = A_1.J;
			}
			else
			{
				dataGridViewRow.DefaultCellStyle.ForeColor = A_1.i;
			}
		}

		private static string A_m_1(global::B.s P_0)
		{
			string text = global::a.Q.A_m_1(P_0.a);
			return text + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.IF() + P_0.A_2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLv() + P_0.A_1 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ln();
		}

		private void A_m_1(bool P_0)
		{
			foreach (DataGridViewRow item in (IEnumerable)A_2.Rows)
			{
				if (item.Tag is global::B.u u2 && u2.A_2.A == global::B.r.B && !A_4.Contains(e.b_m_1(u2.A)))
				{
					item.Cells[1].Value = P_0;
				}
			}
			A_2.EndEdit();
			a_m_1();
		}

		private void a_m_1()
		{
			foreach (DataGridViewRow item in (IEnumerable)A_2.Rows)
			{
				if (item.Tag is global::B.u u2)
				{
					Convert.ToBoolean(item.Cells[1].Value ?? ((object)false));
					if (u2.A_2.A == global::B.r.a)
					{
						item.Cells[0].Value = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.xJ();
					}
					else if (A_4.Contains(e.b_m_1(u2.A)))
					{
						item.Cells[0].Value = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.xL();
					}
					else
					{
						item.Cells[0].Value = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.xK();
					}
				}
			}
		}

		private void B()
		{
			A_3.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.xM(), A.a.Count, A.A.Count);
		}

		private void b()
		{
			a.Clear();
			foreach (DataGridViewRow item in (IEnumerable)A_2.Rows)
			{
				if (item.Tag is global::B.u u2 && u2.A_2.A == global::B.r.B && Convert.ToBoolean(item.Cells[1].Value ?? ((object)false)) && !A_4.Contains(e.b_m_1(u2.A)))
				{
					a.Add(e.b_m_1(u2.A));
				}
			}
		}

		private void C()
		{
			int num = 0;
			foreach (DataGridViewRow selectedRow in A_2.SelectedRows)
			{
				if (selectedRow.Tag is global::B.u u2 && global::B.U.a(Path.GetFileNameWithoutExtension(u2.A)))
				{
					num++;
					A_4.Add(e.b_m_1(u2.A));
					selectedRow.Cells[1].Value = false;
				}
			}
			if (num == 0)
			{
				MessageBox.Show(this, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.YI()), global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.YJ()), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			A_2.EndEdit();
			a_m_1();
			B();
		}

		private void c()
		{
			List<string> list = global::B.U.a();
			string text = ((list.Count == 0) ? global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.YK()) : global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.YL(), list.Count, string.Join(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BD(), list.GetRange(0, Math.Min(list.Count, 30)))));
			if (list.Count == 0)
			{
				MessageBox.Show(this, text, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.xH()), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else if (MessageBox.Show(this, text, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.xH()), MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				global::B.U.B();
				A_4.Clear();
				MessageBox.Show(this, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.YM()), global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.xH()), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				B();
			}
		}

		private static string A_m_1(long P_0)
		{
			if (P_0 <= 0)
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bE();
			}
			if (P_0 < 1024)
			{
				return P_0 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bd();
			}
			if (P_0 < 1048576)
			{
				return ((double)P_0 / 1024.0).ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.w()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BE();
			}
			if (P_0 < 1073741824)
			{
				return ((double)P_0 / 1024.0 / 1024.0).ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.w()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Be();
			}
			return ((double)P_0 / 1024.0 / 1024.0 / 1024.0).ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.w()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bf();
		}

		[CompilerGenerated]
		private void A_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			A_m_1(true);
		}

		[CompilerGenerated]
		private void a_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			A_m_1(false);
		}

		[CompilerGenerated]
		private void B(object? _003Cp0_003E, EventArgs P_1)
		{
			b();
			DialogResult = DialogResult.OK;
			Close();
		}

		[CompilerGenerated]
		private void b(object? _003Cp0_003E, EventArgs P_1)
		{
			C();
		}

		[CompilerGenerated]
		private void C(object? _003Cp0_003E, EventArgs P_1)
		{
			c();
		}

		[CompilerGenerated]
		private void c(object? _003Cp0_003E, EventArgs P_1)
		{
			a.Clear();
			DialogResult = DialogResult.Cancel;
			Close();
		}

		[CompilerGenerated]
		private void D(object? _003Cp0_003E, EventArgs P_1)
		{
			if (A_2.IsCurrentCellDirty)
			{
				A_2.CommitEdit(DataGridViewDataErrorContexts.Commit);
			}
		}

		[CompilerGenerated]
		private void A_m_1(object P_0, DataGridViewCellEventArgs P_1)
		{
			if (P_1.ColumnIndex == 1 && P_1.RowIndex >= 0)
			{
				BeginInvoke(new MethodInvoker(a_m_1));
			}
		}

		[CompilerGenerated]
		private void a_m_1(object? _003Cp0_003E, DataGridViewCellEventArgs P_1)
		{
			a_m_1();
		}
	}
	internal static class x
	{
		internal static readonly byte[] A = new byte[0];
	}
}
