using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007B1262ED64_002DD0A6_002D499E_002D9510_002DF2240F018DBB_007D;
using B;
using a;
using b;

namespace A
{
	public sealed class F : Form
	{
		private sealed class A
		{
			public string A_f_1;

			public string a;

			public string B;

			public string b;

			public override string ToString()
			{
				return A_f_1;
			}
		}

		private readonly global::b.Y A_1;

		private readonly x A_2;

		private CheckBox A_3;

		private ComboBox A_4;

		private TextBox A_5;

		private TextBox a_1;

		private TextBox B_1;

		private NumericUpDown A_6;

		private NumericUpDown a_2;

		private CheckBox a_3;

		private CheckBox B_2;

		private NumericUpDown B_3;

		private NumericUpDown b;

		private Button A_7;

		private Button a_4;

		private Label A_8;

		private CancellationTokenSource A_9;

		private bool A_10;

		private bool a_5;

		private static readonly A[] A_11 = new A[7]
		{
			new A
			{
				A_f_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bh(),
				a = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BP(),
				B = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bI(),
				b = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bi()
			},
			new A
			{
				A_f_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bJ(),
				a = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bj(),
				B = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bK(),
				b = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bk()
			},
			new A
			{
				A_f_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bL(),
				a = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bl(),
				B = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bM(),
				b = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bm()
			},
			new A
			{
				A_f_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bN(),
				a = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bn(),
				B = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bO(),
				b = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bo()
			},
			new A
			{
				A_f_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bP(),
				a = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bp(),
				B = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bQ(),
				b = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bq()
			},
			new A
			{
				A_f_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bR(),
				a = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.br(),
				B = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bS(),
				b = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bs()
			},
			new A
			{
				A_f_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bT(),
				a = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bt(),
				B = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bU(),
				b = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bu()
			}
		};

		private Button B_4;

		public x Result => A_2;

		public F(x P_0, global::b.Y P_1)
		{
			A_2 = P_0.A_m_1();
			A_1 = P_1;
			Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BM();
			StartPosition = FormStartPosition.CenterParent;
			Icon = R.App;
			Font = global::B.Q.A_m_1(10f);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(760, 640);
			MinimumSize = new Size(680, 580);
			BackColor = P_1.A;
			ForeColor = P_1.b;
			A_m_1();
			A_m_1(A_2);
			global::b.Z.A_m_1(this, P_1, B_4);
			global::a.Q.A_m_1(this);
		}

		private void A_m_1()
		{
			TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
			{
				Dock = DockStyle.Fill,
				ColumnCount = 2,
				RowCount = 14,
				Padding = new Padding(16),
				Margin = new Padding(0)
			};
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			for (int num = 0; num < 14; num++)
			{
				tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			}
			A_3 = new CheckBox
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bm(),
				AutoSize = true,
				Font = global::B.Q.A_m_1(10.5f, FontStyle.Bold),
				Margin = new Padding(2, 2, 2, 12)
			};
			tableLayoutPanel.Controls.Add(A_3, 0, 0);
			tableLayoutPanel.SetColumnSpan(A_3, 2);
			Label control = new Label
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BN(),
				AutoSize = true,
				MaximumSize = new Size(680, 0),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BH(),
				Margin = new Padding(2, 0, 2, 12)
			};
			tableLayoutPanel.Controls.Add(control, 0, 1);
			tableLayoutPanel.SetColumnSpan(control, 2);
			tableLayoutPanel.Controls.Add(A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bn()), 0, 2);
			A_4 = new ComboBox
			{
				DropDownStyle = ComboBoxStyle.DropDownList,
				Dock = DockStyle.Fill,
				Margin = new Padding(0, 4, 0, 10),
				FlatStyle = FlatStyle.Flat
			};
			A[] a_ = A_11;
			foreach (A item in a_)
			{
				A_4.Items.Add(item);
			}
			A_4.Items.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BO());
			A_4.SelectedIndex = A_11.Length;
			A_4.SelectedIndexChanged += delegate
			{
				B_m_1();
			};
			tableLayoutPanel.Controls.Add(A_4, 1, 2);
			tableLayoutPanel.Controls.Add(A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bo()), 0, 3);
			A_5 = a_m_1();
			A_5.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BP();
			tableLayoutPanel.Controls.Add(A_5, 1, 3);
			Label control2 = new Label
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bp(),
				AutoSize = true,
				MaximumSize = new Size(620, 0),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BH(),
				Margin = new Padding(92, 0, 2, 10)
			};
			tableLayoutPanel.Controls.Add(control2, 0, 4);
			tableLayoutPanel.SetColumnSpan(control2, 2);
			tableLayoutPanel.Controls.Add(A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BQ()), 0, 5);
			a_1 = a_m_1();
			a_1.UseSystemPasswordChar = true;
			tableLayoutPanel.Controls.Add(a_1, 1, 5);
			tableLayoutPanel.Controls.Add(A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bq()), 0, 6);
			B_1 = a_m_1();
			tableLayoutPanel.Controls.Add(B_1, 1, 6);
			tableLayoutPanel.Controls.Add(A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BR()), 0, 7);
			A_6 = new NumericUpDown
			{
				Minimum = 5m,
				Maximum = 300m,
				Value = 15m,
				Width = 100,
				Margin = new Padding(0, 6, 0, 10)
			};
			tableLayoutPanel.Controls.Add(A_6, 1, 7);
			tableLayoutPanel.Controls.Add(A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Br()), 0, 8);
			a_2 = new NumericUpDown
			{
				Minimum = 1m,
				Maximum = 200m,
				Value = 40m,
				Width = 100,
				Margin = new Padding(0, 6, 0, 10)
			};
			Label control3 = new Label
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BS(),
				AutoSize = true,
				MaximumSize = new Size(440, 0),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BH(),
				Margin = new Padding(10, 8, 0, 4)
			};
			TableLayoutPanel tableLayoutPanel2 = new TableLayoutPanel
			{
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				ColumnCount = 2,
				RowCount = 1,
				Margin = new Padding(0, 4, 0, 6)
			};
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			tableLayoutPanel2.Controls.Add(a_2, 0, 0);
			tableLayoutPanel2.Controls.Add(control3, 1, 0);
			tableLayoutPanel.Controls.Add(tableLayoutPanel2, 1, 8);
			tableLayoutPanel.Controls.Add(A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bs()), 0, 9);
			B_3 = new NumericUpDown
			{
				Minimum = 0m,
				Maximum = 10000m,
				DecimalPlaces = 4,
				Increment = 0.5m,
				Value = 0m,
				Width = 110,
				Margin = new Padding(0, 6, 0, 2)
			};
			b = new NumericUpDown
			{
				Minimum = 0m,
				Maximum = 10000m,
				DecimalPlaces = 4,
				Increment = 0.5m,
				Value = 0m,
				Width = 110,
				Margin = new Padding(0, 6, 0, 2)
			};
			TableLayoutPanel tableLayoutPanel3 = new TableLayoutPanel
			{
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				ColumnCount = 4,
				RowCount = 1,
				Margin = new Padding(0, 4, 0, 2)
			};
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			tableLayoutPanel3.Controls.Add(new Label
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BT(),
				AutoSize = true,
				Margin = new Padding(0, 8, 4, 0)
			}, 0, 0);
			tableLayoutPanel3.Controls.Add(B_3, 1, 0);
			tableLayoutPanel3.Controls.Add(new Label
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bt(),
				AutoSize = true,
				Margin = new Padding(12, 8, 4, 0)
			}, 2, 0);
			tableLayoutPanel3.Controls.Add(b, 3, 0);
			tableLayoutPanel.Controls.Add(tableLayoutPanel3, 1, 9);
			Label control4 = new Label
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BU(),
				AutoSize = true,
				MaximumSize = new Size(620, 0),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BH(),
				Margin = new Padding(92, 0, 2, 8)
			};
			tableLayoutPanel.Controls.Add(control4, 0, 10);
			tableLayoutPanel.SetColumnSpan(control4, 2);
			a_3 = new CheckBox
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bu(),
				AutoSize = true,
				Margin = new Padding(2, 2, 2, 2)
			};
			B_2 = new CheckBox
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BV(),
				AutoSize = true,
				Margin = new Padding(2, 2, 2, 2)
			};
			TableLayoutPanel tableLayoutPanel4 = new TableLayoutPanel
			{
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				ColumnCount = 1,
				RowCount = 2,
				Margin = new Padding(0, 2, 0, 8)
			};
			tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel4.Controls.Add(a_3, 0, 0);
			tableLayoutPanel4.Controls.Add(B_2, 0, 1);
			tableLayoutPanel.Controls.Add(tableLayoutPanel4, 1, 11);
			A_8 = new Label
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bv(),
				AutoSize = true,
				MaximumSize = new Size(700, 0),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BH(),
				Name = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BW(),
				Margin = new Padding(2, 4, 2, 4)
			};
			tableLayoutPanel.Controls.Add(A_8, 0, 12);
			tableLayoutPanel.SetColumnSpan(A_8, 2);
			FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel
			{
				FlowDirection = FlowDirection.RightToLeft,
				Dock = DockStyle.Fill,
				AutoSize = true,
				Margin = new Padding(0, 8, 0, 0)
			};
			B_4 = new Button
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bw(),
				AutoSize = true,
				MinimumSize = new Size(110, 36),
				Padding = new Padding(10, 2, 10, 2),
				Font = global::B.Q.A_m_1(10.5f, FontStyle.Bold),
				Margin = new Padding(8, 0, 0, 0)
			};
			B_4.Click += delegate
			{
				if (a_m_1(A_2))
				{
					DialogResult = DialogResult.OK;
					Close();
				}
			};
			Button button = new Button
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BX(),
				AutoSize = true,
				MinimumSize = new Size(110, 36),
				Padding = new Padding(10, 2, 10, 2),
				Font = global::B.Q.A_m_1(10f)
			};
			button.Click += delegate
			{
				DialogResult = DialogResult.Cancel;
				Close();
			};
			A_7 = new Button
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bx(),
				AutoSize = true,
				MinimumSize = new Size(110, 36),
				Padding = new Padding(10, 2, 10, 2),
				Font = global::B.Q.A_m_1(10f),
				Margin = new Padding(8, 0, 0, 0)
			};
			A_7.Click += async delegate
			{
				await b_m_1();
			};
			a_4 = new Button
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BY(),
				AutoSize = true,
				MinimumSize = new Size(96, 36),
				Padding = new Padding(10, 2, 10, 2),
				Font = global::B.Q.A_m_1(10f),
				Margin = new Padding(8, 0, 0, 0),
				Visible = false,
				Enabled = false
			};
			a_4.Click += delegate
			{
				C();
			};
			flowLayoutPanel.Controls.Add(B_4);
			flowLayoutPanel.Controls.Add(button);
			flowLayoutPanel.Controls.Add(A_7);
			flowLayoutPanel.Controls.Add(a_4);
			tableLayoutPanel.Controls.Add(flowLayoutPanel, 0, 13);
			tableLayoutPanel.SetColumnSpan(flowLayoutPanel, 2);
			Controls.Add(tableLayoutPanel);
			AcceptButton = B_4;
			CancelButton = button;
		}

		private Label A_m_1(string P_0)
		{
			return new Label
			{
				Text = P_0,
				AutoSize = true,
				Anchor = AnchorStyles.Left,
				Margin = new Padding(2, 8, 12, 8)
			};
		}

		private TextBox a_m_1()
		{
			return new TextBox
			{
				Dock = DockStyle.Fill,
				BorderStyle = BorderStyle.FixedSingle,
				Font = global::B.Q.A_m_1(10f),
				Margin = new Padding(0, 4, 0, 10)
			};
		}

		private void B_m_1()
		{
			if (!a_5 && A_4.SelectedItem is A a2)
			{
				A_5.Text = a2.a;
				B_1.Text = a2.B;
				A_8.Text = (a2.a.Contains(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.By()) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bz() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BZ()) + (string.IsNullOrEmpty(a2.b) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D() : (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bA() + a2.b));
			}
		}

		private void A_m_1(x P_0)
		{
			a_5 = true;
			try
			{
				A_3.Checked = P_0.AiEnabled;
				A_5.Text = P_0.AiBaseUrl;
				a_1.Text = P_0.AiApiKey;
				B_1.Text = P_0.AiModel;
				A_6.Value = Math.Max(A_6.Minimum, Math.Min(A_6.Maximum, P_0.AiTimeoutSec));
				a_2.Value = Math.Max(a_2.Minimum, Math.Min(a_2.Maximum, P_0.AiMaxGroups));
				B_3.Value = A_m_1(B_3, P_0.AiPriceInPerMillion);
				b.Value = A_m_1(b, P_0.AiPriceOutPerMillion);
				a_3.Checked = P_0.AiAutoRun;
				B_2.Checked = P_0.AiAutoApply;
				int selectedIndex = A_11.Length;
				for (int num = 0; num < A_11.Length; num++)
				{
					if (string.Equals(A_11[num].a, P_0.AiBaseUrl, StringComparison.OrdinalIgnoreCase) && string.Equals(A_11[num].B, P_0.AiModel, StringComparison.OrdinalIgnoreCase))
					{
						selectedIndex = num;
						break;
					}
				}
				A_4.SelectedIndex = selectedIndex;
			}
			finally
			{
				a_5 = false;
			}
		}

		private bool a_m_1(x P_0)
		{
			string text = A_5.Text.Trim();
			string text2 = B_1.Text.Trim();
			if (A_3.Checked)
			{
				if (text.Length == 0 || text2.Length == 0)
				{
					MessageBox.Show(this, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ba(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bB(), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return false;
				}
				if (!text.StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bb(), StringComparison.OrdinalIgnoreCase) && !text.StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bC(), StringComparison.OrdinalIgnoreCase))
				{
					MessageBox.Show(this, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bc(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bB(), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return false;
				}
			}
			P_0.AiEnabled = A_3.Checked;
			P_0.AiBaseUrl = text;
			P_0.AiApiKey = a_1.Text.Trim();
			P_0.AiModel = text2;
			P_0.AiTimeoutSec = (int)A_6.Value;
			P_0.AiMaxGroups = (int)a_2.Value;
			P_0.AiPriceInPerMillion = (double)B_3.Value;
			P_0.AiPriceOutPerMillion = (double)b.Value;
			P_0.AiAutoRun = a_3.Checked;
			P_0.AiAutoApply = B_2.Checked;
			return true;
		}

		private static decimal A_m_1(NumericUpDown P_0, double P_1)
		{
			if (P_1 <= 0.0)
			{
				return P_0.Minimum;
			}
			if (P_1 > (double)P_0.Maximum)
			{
				return P_0.Maximum;
			}
			return (decimal)P_1;
		}

		private async Task b_m_1()
		{
			if (A_10 || !global::b.G.A_m_1(this, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMo(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMP()))
			{
				return;
			}
			x x2 = A_2.A_m_1();
			x2.AiEnabled = true;
			x2.AiBaseUrl = A_5.Text.Trim();
			x2.AiApiKey = a_1.Text.Trim();
			x2.AiModel = B_1.Text.Trim();
			x2.AiTimeoutSec = (int)A_6.Value;
			if (x2.AiBaseUrl.Length == 0 || x2.AiApiKey.Length == 0)
			{
				A_m_1(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.pN()), A_1.J);
				return;
			}
			A_10 = true;
			A_7.Enabled = false;
			A_7.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.pk());
			a_4.Visible = true;
			a_4.Enabled = true;
			A_m_1(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.pO()), A_1.I);
			Cursor = Cursors.WaitCursor;
			A_9 = new CancellationTokenSource();
			try
			{
				A_m_1(await H.A_m_1(x2, A_9.Token));
			}
			catch (Exception ex)
			{
				A_m_1(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bG()) + H.A_m_1(ex.Message, x2.AiApiKey), A_1.J);
			}
			finally
			{
				A_10 = false;
				Cursor = Cursors.Default;
				A_9 = null;
				A_7.Enabled = true;
				A_7.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bx());
				a_4.Visible = false;
				a_4.Enabled = false;
			}
		}

		private void C()
		{
			if (A_9 == null)
			{
				return;
			}
			a_4.Enabled = false;
			A_m_1(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bD()), A_1.I);
			try
			{
				A_9.Cancel();
			}
			catch
			{
			}
		}

		private void A_m_1(G P_0)
		{
			if (P_0 == null)
			{
				A_m_1(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bd()), A_1.J);
				return;
			}
			if (P_0.A)
			{
				string text = (string.IsNullOrWhiteSpace(P_0.A_3) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bE() : P_0.A_3);
				A_m_1(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.be(), P_0.A_2, text), A_1.j);
				return;
			}
			if (P_0.A_1 == f.F)
			{
				A_m_1(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bF()), A_1.I);
				return;
			}
			if (P_0.A_1 == f.a)
			{
				A_m_1(global::a.Q.A_m_1(P_0.a_1), A_1.J);
				return;
			}
			string text2 = ((P_0.A_1 == f.d) ? global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bf(), P_0.B_1) : global::a.Q.A_m_1(P_0.a_1));
			string text3 = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bG()) + text2;
			if (P_0.a > 0)
			{
				text3 = text3 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bg() + P_0.a;
			}
			if (!string.IsNullOrEmpty(P_0.B))
			{
				text3 = text3 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bH() + P_0.B;
			}
			A_m_1(text3, A_1.J);
		}

		private void A_m_1(string P_0, Color P_1)
		{
			A_8.Text = P_0 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			A_8.ForeColor = P_1;
		}

		[CompilerGenerated]
		private void A_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			B_m_1();
		}

		[CompilerGenerated]
		private void a_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			if (a_m_1(A_2))
			{
				DialogResult = DialogResult.OK;
				Close();
			}
		}

		[CompilerGenerated]
		private void B_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		[CompilerGenerated]
		private async void b_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			await b_m_1();
		}

		[CompilerGenerated]
		private void C(object? _003Cp0_003E, EventArgs P_1)
		{
			C();
		}
	}
	public enum f
	{
		A,
		a,
		B,
		b,
		C,
		c,
		D,
		d,
		E,
		e,
		F,
		f_f_1
	}
}
namespace a
{
	public enum F
	{
		A,
		a,
		B
	}
	public sealed class f
	{
		public int A;

		public int a;

		public int B;

		public long A_1;

		public long a_1;
	}
}
