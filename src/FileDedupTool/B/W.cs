using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
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
	public sealed class W : Form
	{
		internal const string A = "本软件的部分实现参考了以下开源项目（均为 MIT License）：\n\n1. Lanzou-Next\n   https://github.com/Jursin/lanzou-next\n   Copyright (c) 2026 Jursin\n\n2. lanzouyun-disk\n   https://github.com/chenhb23/lanzouyun-disk\n   Copyright (c) 2020 chenhb23\n\n3. LanZouCloud-API\n   https://github.com/zaxtyson/LanZouCloud-API\n   Copyright (c) 2019 zaxtyson\n\n------------------------------------------------------------------------\nMIT License\n\nCopyright (c) 2026 Jursin\n\nPermission is hereby granted, free of charge, to any person obtaining a copy\nof this software and associated documentation files (the \"Software\"), to deal\nin the Software without restriction, including without limitation the rights\nto use, copy, modify, merge, publish, distribute, sublicense, and/or sell\ncopies of the Software, and to permit persons to whom the Software is\nfurnished to do so, subject to the following conditions:\n\nThe above copyright notice and this permission notice shall be included in all\ncopies or substantial portions of the Software.\n\nTHE SOFTWARE IS PROVIDED \"AS IS\", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR\nIMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,\nFITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE\nAUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER\nLIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,\nOUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE\nSOFTWARE.\n\n------------------------------------------------------------------------\nMIT License\n\nCopyright (c) 2020 chenhb23\n\nPermission is hereby granted, free of charge, to any person obtaining a copy\nof this software and associated documentation files (the \"Software\"), to deal\nin the Software without restriction, including without limitation the rights\nto use, copy, modify, merge, publish, distribute, sublicense, and/or sell\ncopies of the Software, and to permit persons to whom the Software is\nfurnished to do so, subject to the following conditions:\n\nThe above copyright notice and this permission notice shall be included in all\ncopies or substantial portions of the Software.\n\nTHE SOFTWARE IS PROVIDED \"AS IS\", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR\nIMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,\nFITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE\nAUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER\nLIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,\nOUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE\nSOFTWARE.\n\n------------------------------------------------------------------------\nMIT License\n\nCopyright (c) 2019 zaxtyson\n\nPermission is hereby granted, free of charge, to any person obtaining a copy\nof this software and associated documentation files (the \"Software\"), to deal\nin the Software without restriction, including without limitation the rights\nto use, copy, modify, merge, publish, distribute, sublicense, and/or sell\ncopies of the Software, and to permit persons to whom the Software is\nfurnished to do so, subject to the following conditions:\n\nThe above copyright notice and this permission notice shall be included in all\ncopies or substantial portions of the Software.\n\nTHE SOFTWARE IS PROVIDED \"AS IS\", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR\nIMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,\nFITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE\nAUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER\nLIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,\nOUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE\nSOFTWARE.\n";

		internal TextBox A_1;

		public W(global::b.Y P_0)
		{
			global::b.Y y2 = P_0 ?? global::b.Y.A_m_1();
			Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGg();
			Icon = global::A.R.App;
			Font = Q.A_m_1(10f);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(820, 620);
			MinimumSize = new Size(720, 520);
			BackColor = y2.A;
			ForeColor = y2.b;
			StartPosition = FormStartPosition.CenterParent;
			MaximizeBox = true;
			MinimizeBox = false;
			ShowInTaskbar = false;
			TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
			{
				Dock = DockStyle.Fill,
				ColumnCount = 1,
				RowCount = 3,
				Padding = new Padding(16, 14, 16, 12)
			};
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			Controls.Add(tableLayoutPanel);
			Label control = new Label
			{
				AutoSize = true,
				MaximumSize = new Size(780, 0),
				ForeColor = y2.I,
				Margin = new Padding(0, 0, 0, 8),
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGH()
			};
			tableLayoutPanel.Controls.Add(control, 0, 0);
			A_1 = new TextBox
			{
				Dock = DockStyle.Fill,
				Multiline = true,
				ReadOnly = true,
				WordWrap = true,
				ScrollBars = ScrollBars.Vertical,
				Font = new Font(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ME(), 9.5f),
				BackColor = y2.c,
				ForeColor = y2.D,
				BorderStyle = BorderStyle.FixedSingle,
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGh(),
				Margin = new Padding(0, 0, 0, 8)
			};
			tableLayoutPanel.Controls.Add(A_1, 0, 1);
			FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel
			{
				Dock = DockStyle.Fill,
				AutoSize = true,
				FlowDirection = FlowDirection.RightToLeft,
				WrapContents = false
			};
			Button button = new Button
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bl(),
				AutoSize = true,
				MinimumSize = new Size(100, 36),
				FlatStyle = FlatStyle.Flat,
				BackColor = y2.E,
				ForeColor = y2.e
			};
			button.FlatAppearance.BorderColor = y2.B;
			button.Click += delegate
			{
				Close();
			};
			flowLayoutPanel.Controls.Add(button);
			tableLayoutPanel.Controls.Add(flowLayoutPanel, 0, 2);
		}

		[CompilerGenerated]
		private void A_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			Close();
		}
	}
	public sealed class w : IDisposable
	{
		public sealed class A
		{
			public int A_f_1;

			public int a;

			public int B;

			public int b;

			public int C;

			public int c;

			public int D;

			public int d;

			public int E;

			public int e;

			public int F;

			public int f;

			public bool A_f_2;

			public override string ToString()
			{
				string text = string.Format(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anD(), A_f_1, a, B, b, C, c);
				if (f > 0)
				{
					text += string.Format(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.and(), f);
				}
				if (C > 0)
				{
					text += _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anE();
				}
				if (A_f_2)
				{
					text += string.Format(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ane(), D, d, E, e, F);
				}
				return text;
			}

			public string A_m_1()
			{
				if (!global::a.Q.EnMode)
				{
					return ToString();
				}
				string text = string.Format(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anF(), A_f_1, a, B, b, C, c);
				if (f > 0)
				{
					text += string.Format(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anf(), f);
				}
				if (A_f_2)
				{
					text += string.Format(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anG(), D, d, E, e, F);
				}
				return text;
			}
		}

		[Serializable]
		[CompilerGenerated]
		private sealed class a
		{
			public static readonly a A = new a();

			public static Func<string, bool> A_1;

			public static Func<string, DateTime> A_2;

			internal bool A_m_1(string P_0)
			{
				return !Path.GetFileName(P_0).StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGi(), StringComparison.OrdinalIgnoreCase);
			}

			internal DateTime a_m_1(string P_0)
			{
				return File.GetLastWriteTime(P_0);
			}
		}

		private static readonly object A_1 = new object();

		private StreamWriter A_2;

		[CompilerGenerated]
		private string A_3;

		[CompilerGenerated]
		private bool A_4;

		[CompilerGenerated]
		private int A_5;

		public string FilePath
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

		public bool DryRun
		{
			[CompilerGenerated]
			get
			{
				return A_4;
			}
			[CompilerGenerated]
			private set
			{
				A_4 = value;
			}
		}

		public int Count
		{
			[CompilerGenerated]
			get
			{
				return A_5;
			}
			[CompilerGenerated]
			private set
			{
				A_5 = value;
			}
		}

		public w(bool P_0)
			: this(P_0, null)
		{
		}

		public w(bool P_0, string P_1)
		{
			DryRun = P_0;
			string path = ((!string.IsNullOrWhiteSpace(P_1)) ? P_1 : (P_0 ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGi() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGI())) + DateTime.Now.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGJ()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kF();
			FilePath = Path.Combine(p.OpsDir, path);
			try
			{
				A_2 = new StreamWriter(FilePath, append: false, new UTF8Encoding(encoderShouldEmitUTF8Identifier: true));
				A_2.WriteLine(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGj());
				A_2.Flush();
			}
			catch
			{
				A_2 = null;
			}
		}

		public void A_m_1(string P_0, string P_1, string P_2, string P_3)
		{
			A_m_1(P_0, P_1, P_2, P_3, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
		}

		public void A_m_1(string P_0, string P_1, string P_2, string P_3, string P_4)
		{
			Count++;
			if (A_2 == null)
			{
				return;
			}
			try
			{
				if (string.Equals(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jc(), StringComparison.Ordinal) && string.Equals(P_3, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.IK(), StringComparison.OrdinalIgnoreCase) && P_4 != null && P_4.IndexOf(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGK(), StringComparison.Ordinal) < 0)
				{
					P_4 = ((P_4.Length > 0) ? (P_4 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAc()) : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGK() + DateTime.Now.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CI());
				}
				lock (A_1)
				{
					A_2.WriteLine(string.Join(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Kn(), A_m_1(DateTime.Now.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGk())), A_m_1(P_0), A_m_1(P_1 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()), A_m_1(P_2 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()), A_m_1(P_3), A_m_1(P_4 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D())));
					A_2.Flush();
				}
			}
			catch
			{
				A_2 = null;
			}
		}

		public void Dispose()
		{
			try
			{
				if (A_2 != null)
				{
					A_2.Flush();
					A_2.Dispose();
				}
			}
			catch
			{
			}
			A_2 = null;
		}

		private static string A_m_1(string P_0)
		{
			if (P_0 == null)
			{
				P_0 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}
			if (P_0.IndexOfAny(new char[4] { ',', '"', '\n', '\r' }) >= 0)
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JX() + P_0.Replace(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JX(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lk()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JX();
			}
			return P_0;
		}

		public static string A_m_1()
		{
			try
			{
				List<string> list = (from P_0 in Directory.GetFiles(p.OpsDir, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGL())
					where !Path.GetFileName(P_0).StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGi(), StringComparison.OrdinalIgnoreCase)
					orderby File.GetLastWriteTime(P_0) descending
					select P_0).ToList();
				return (list.Count > 0) ? list[0] : null;
			}
			catch
			{
				return null;
			}
		}

		public static A A_m_1(string P_0, CancellationToken P_1)
		{
			return A_m_1(P_0, false, P_1);
		}

		public static A A_m_1(string P_0, bool P_1, CancellationToken P_2)
		{
			A a2 = new A();
			List<string[]> list = B(P_0);
			List<global::b.I> list2 = new List<global::b.I>();
			DateTime? dateTime = a_m_1(P_0);
			int num = list.Count - 1;
			while (num >= 0 && !P_2.IsCancellationRequested)
			{
				string[] array = list[num];
				if (array.Length >= 5)
				{
					string text = array[1];
					string text2 = array[2];
					string text3 = array[3];
					string text4 = array[4];
					string text5 = ((array.Length > 5) ? array[5] : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
					if (text == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jc())
					{
						if (string.Equals(text4, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jd(), StringComparison.OrdinalIgnoreCase) || (text5 != null && text5.StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ci(), StringComparison.Ordinal)))
						{
							a2.f++;
							p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGl() + text2);
						}
						else if (string.Equals(text4, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.IK(), StringComparison.OrdinalIgnoreCase))
						{
							if (!P_1)
							{
								a2.C++;
							}
							else
							{
								global::b.I i2 = A_m_1(text2, text5, array[0], dateTime);
								if (i2 != null)
								{
									list2.Add(i2);
								}
								else
								{
									a2.C++;
								}
							}
						}
					}
					else if (text == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGM())
					{
						a2.c++;
					}
					else if ((!(text != _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGm()) || !(text != _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGN())) && string.Equals(text4, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.IK(), StringComparison.OrdinalIgnoreCase))
					{
						try
						{
							bool flag = File.Exists(global::a.a.A(text2));
							bool flag2 = File.Exists(global::a.a.A(text3));
							if (flag)
							{
								a2.B++;
							}
							else if (!flag2)
							{
								a2.a++;
							}
							else
							{
								global::a.a.a_m_1(text3, text2);
								a2.A_f_1++;
								p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGn() + text3 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.IS() + text2);
							}
						}
						catch (Exception ex)
						{
							a2.b++;
							p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGO(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.nc(), text3, ex.Message, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf());
						}
					}
				}
				num--;
			}
			if (list2.Count > 0)
			{
				a2.A_f_2 = true;
				global::b.K k2 = global::b.L.A_m_1(list2, P_2);
				a2.D += k2.A;
				a2.d += k2.a;
				a2.E += k2.B;
				a2.e += k2.b;
				a2.F += k2.C;
				foreach (global::b.j item in k2.A_1)
				{
					string text6 = item.A.A;
					switch (item.A_1)
					{
					case global::b.J.A:
						p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGo() + text6);
						break;
					case global::b.J.a:
						p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGP() + text6);
						break;
					case global::b.J.B:
						p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGp() + text6);
						break;
					case global::b.J.C:
						p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGO(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGQ(), text6, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGq(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf());
						break;
					default:
						p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGO(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGQ(), text6, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGR() + (item.A_2 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGr()), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf());
						break;
					}
				}
			}
			return a2;
		}

		private static global::b.I A_m_1(string P_0, string P_1, string P_2, DateTime? P_3)
		{
			if (string.IsNullOrEmpty(P_0))
			{
				return null;
			}
			string text = null;
			DateTime? a_ = null;
			string[] array = (P_1 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).Split(new char[1] { ';' }, StringSplitOptions.RemoveEmptyEntries);
			for (int num = 0; num < array.Length; num++)
			{
				string text2 = array[num].Trim();
				DateTime result;
				if (text2.StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jF(), StringComparison.Ordinal))
				{
					text = text2.Substring(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jF().Length).Trim();
				}
				else if (text2.StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGK(), StringComparison.Ordinal) && DateTime.TryParse(text2.Substring(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGK().Length).Trim(), out result))
				{
					a_ = result;
				}
			}
			if (!a_.HasValue && P_3.HasValue && TimeSpan.TryParse(P_2, out var result2))
			{
				a_ = P_3.Value.Date + result2;
			}
			return new global::b.I
			{
				A = P_0,
				a = (string.IsNullOrEmpty(text) ? P_0 : text),
				A_1 = a_
			};
		}

		private static DateTime? a_m_1(string P_0)
		{
			try
			{
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(P_0);
				if (!fileNameWithoutExtension.StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGI(), StringComparison.OrdinalIgnoreCase))
				{
					return null;
				}
				string text = fileNameWithoutExtension.Substring(4);
				if (text.StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGS(), StringComparison.OrdinalIgnoreCase))
				{
					return null;
				}
				if (text.Length >= 8 && DateTime.TryParseExact(text.Substring(0, 8), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acc(), CultureInfo.InvariantCulture, DateTimeStyles.None, out var result))
				{
					return result;
				}
			}
			catch
			{
			}
			return null;
		}

		private static List<string[]> B(string P_0)
		{
			List<string[]> list = new List<string[]>();
			try
			{
				string[] array = File.ReadAllLines(P_0, Encoding.UTF8);
				foreach (string text in array)
				{
					if (text.Trim().Length != 0 && !text.StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGs()))
					{
						list.Add(b(text));
					}
				}
			}
			catch (Exception ex)
			{
				p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGT() + ex.Message);
			}
			return list;
		}

		private static string[] b(string P_0)
		{
			List<string> list = new List<string>();
			StringBuilder stringBuilder = new StringBuilder();
			bool flag = false;
			for (int num = 0; num < P_0.Length; num++)
			{
				char c2 = P_0[num];
				if (flag)
				{
					if (c2 == '"')
					{
						if (num + 1 < P_0.Length && P_0[num + 1] == '"')
						{
							stringBuilder.Append('"');
							num++;
						}
						else
						{
							flag = false;
						}
					}
					else
					{
						stringBuilder.Append(c2);
					}
					continue;
				}
				switch (c2)
				{
				case '"':
					flag = true;
					break;
				case ',':
					list.Add(stringBuilder.ToString());
					stringBuilder.Clear();
					break;
				default:
					stringBuilder.Append(c2);
					break;
				}
			}
			list.Add(stringBuilder.ToString());
			return list.ToArray();
		}
	}
}
namespace b
{
	public static class W
	{
		private const string A = "搜索的使用说明\n\n一、搜索从哪里找文件（三层后端，逐级降级）\n  1. Everything IPC（首选）\n     直接调用正在运行的 Everything，速度最快，可搜全盘；本程序不打包、不附带任何 Everything 文件。\n  2. Everything 的 es.exe 命令行（第二层）\n     当 IPC 不可用或超时时启用；只在常见安装目录与 PATH 中查找，不下载、不安装。\n  3. 当前处理位置的本地扫描（兜底）\n     未检测到 Everything 时，只扫描「源文件夹」（处理位置）里的文件名，可随时取消。\n  降级提示会写明当前用的是哪一层；三层都不可用时写明原因，不会假装搜到了结果。\n\n二、搜索语法\n  · 直接输入文件名或片段：报告、2024-01、发票\n  · * 匹配任意多个字符：*.pdf、IMG_2024*.jpg\n  · ? 匹配任意单个字符：IMG_????.jpg、报告-?.docx\n  · 只按文件名匹配，不搜索文件内容；大小写不敏感\n\n三、结果与上限\n  · 结果在搜索框下方展开，列为：文件名 / 路径 / 大小 / 修改时间\n  · 每次最多显示 1000 条，超过时会明确提示「结果超过 1000 条，仅显示前 1000 条」\n  · 搜索在后台线程执行，可点【取消搜索】随时中止，界面不会卡住\n\n四、结果行操作\n  · 双击一行：用系统默认程序打开该文件\n  · 选中一行后点【设为处理位置】：把该文件所在文件夹填进「源文件夹」\n  · 选中一行后点【打开所在文件夹】：在资源管理器中定位到该文件\n\n五、搜索不可用怎么办\n  · 没有任何后端时，状态行会显示「搜索不可用」及原因；先设置「源文件夹」即可退回本地扫描。\n  · 想全盘、秒级搜索，可安装 Everything（免费）：\n        https://www.voidtools.com/downloads/\n  · 安装后保持 Everything 在后台运行即可，程序会自动检测，无需额外配置。\n  · 程序本身不依赖 Everything，不安装也能完成去重与整理。\n\n六、安全说明\n  · 搜索只读取文件名、大小与修改时间，不修改、不删除任何文件。\n  · 搜索与去重、整理流程相互独立。";

		private const string a = "Search help\n\n1. Where results come from (three backends, degrading in order)\n  1. Everything IPC (preferred)\n     Talks to a running Everything instance for instant whole-disk results.\n     This app does not bundle or redistribute any Everything files.\n  2. Everything es.exe command line (second layer)\n     Used when IPC is unavailable or times out; looked up only in common install\n     folders and PATH — nothing is downloaded or installed.\n  3. Local scan of the current source folder (fallback)\n     With no Everything detected, only file names under the source folder are scanned;\n     the scan can be cancelled at any time.\n  The status line always states which backend was used; if all three fail it states\n  the reason instead of pretending to have results.\n\n2. Syntax\n  · Type a file name or fragment: report, 2024-01, invoice\n  · * matches any number of characters: *.pdf, IMG_2024*.jpg\n  · ? matches exactly one character: IMG_????.jpg, report-?.docx\n  · File names only (content is not indexed); case-insensitive\n\n3. Results and limits\n  · The result list drops down below the search box with columns:\n    File name / Path / Size / Modified\n  · At most 1000 rows are shown; when exceeded, the status line says so explicitly\n  · Searching runs on a background thread; use Cancel search to stop without freezing the UI\n\n4. Row actions\n  · Double-click a row: open the file with its default application\n  · Select a row, then Set as source folder: use its folder as the source folder\n  · Select a row, then Open containing folder: reveal it in File Explorer\n\n5. If search is unavailable\n  · With no backend at all, the status line shows “Search unavailable” and the reason.\n    Set a source folder to fall back to a local scan.\n  · For instant whole-disk search, install Everything (free):\n        https://www.voidtools.com/downloads/\n  · Keep Everything running in the background after installation; this app detects it\n    automatically, with no extra configuration.\n  · Everything is optional: dedup and organisation work without it.\n\n6. Safety\n  · Search only reads names, sizes and modification times; it never modifies or deletes files.\n  · Search is independent from dedup and organisation.";

		public static string A_m_1()
		{
			if (!global::a.Q.EnMode)
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLT();
			}
			return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLt();
		}
	}
	public sealed class w : Panel
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class A
		{
			public static readonly A A_f_1 = new A();

			public static LinkLabelLinkClickedEventHandler A_f_2;

			internal void A_m_1(object? _003Cp0_003E, LinkLabelLinkClickedEventArgs P_1)
			{
				try
				{
					Process.Start(new ProcessStartInfo(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOD())
					{
						UseShellExecute = true
					});
				}
				catch
				{
				}
			}
		}

		[CompilerGenerated]
		private sealed class a
		{
			public string A;

			public string a_f_1;

			public CancellationToken A_1;

			public w A_2;

			internal T A_m_1()
			{
				return V.A_m_1(A, a_f_1, 1000, A_1);
			}

			internal void A_m_1(Task<T> P_0)
			{
				if (A_2.IsDisposed)
				{
					return;
				}
				T A = null;
				try
				{
					A = P_0.Result;
				}
				catch (Exception ex)
				{
					A = new T
					{
						A_3 = ex.Message
					};
				}
				try
				{
					if (A_2.IsHandleCreated)
					{
						A_2.BeginInvoke(() =>
						{
							A_2.A_m_1(A, this.A);
						});
					}
				}
				catch
				{
				}
			}
		}

		[CompilerGenerated]
		private sealed class B
		{
			public T A;

			public a A_1;

			internal void A_m_1()
			{
				A_1.A_2.A_m_1(A, A_1.A);
			}
		}

		private Button A_1;

		private Button a_1;

		private Button B_1;

		private Label A_2;

		private LinkLabel A_3;

		private DataGridView A_4;

		private CancellationTokenSource A_5;

		private bool A_6;

		private T A_7;

		private string A_8 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		private string a_2 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		[CompilerGenerated]
		private Action<string> A_9;

		[CompilerGenerated]
		private Action<string, string> A_10;

		public bool Searching => A_6;

		public string LastQuery => a_2;

		public event Action<string> SetLocationRequested
		{
			[CompilerGenerated]
			add
			{
				Action<string> action = A_9;
				Action<string> action2;
				do
				{
					action2 = action;
					Action<string> value2 = (Action<string>)Delegate.Combine(action2, value);
					action = Interlocked.CompareExchange(ref A_9, value2, action2);
				}
				while ((object)action != action2);
			}
			[CompilerGenerated]
			remove
			{
				Action<string> action = A_9;
				Action<string> action2;
				do
				{
					action2 = action;
					Action<string> value2 = (Action<string>)Delegate.Remove(action2, value);
					action = Interlocked.CompareExchange(ref A_9, value2, action2);
				}
				while ((object)action != action2);
			}
		}

		public event Action<string, string> RememberRequested
		{
			[CompilerGenerated]
			add
			{
				Action<string, string> action = A_10;
				Action<string, string> action2;
				do
				{
					action2 = action;
					Action<string, string> value2 = (Action<string, string>)Delegate.Combine(action2, value);
					action = Interlocked.CompareExchange(ref A_10, value2, action2);
				}
				while ((object)action != action2);
			}
			[CompilerGenerated]
			remove
			{
				Action<string, string> action = A_10;
				Action<string, string> action2;
				do
				{
					action2 = action;
					Action<string, string> value2 = (Action<string, string>)Delegate.Remove(action2, value);
					action = Interlocked.CompareExchange(ref A_10, value2, action2);
				}
				while ((object)action != action2);
			}
		}

		public w()
		{
			Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acx();
			BorderStyle = BorderStyle.FixedSingle;
			Padding = new Padding(10, 6, 10, 6);
			DoubleBuffered = true;
			A_m_1();
		}

		private void A_m_1()
		{
			TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
			{
				Dock = DockStyle.Fill,
				ColumnCount = 1,
				RowCount = 4,
				Margin = new Padding(0),
				Padding = new Padding(0)
			};
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			Controls.Add(tableLayoutPanel);
			A_2 = new Label
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(),
				AutoSize = false,
				Height = 22,
				Dock = DockStyle.Fill,
				AutoEllipsis = true,
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BH(),
				TextAlign = ContentAlignment.MiddleLeft,
				Margin = new Padding(2, 0, 0, 4)
			};
			tableLayoutPanel.Controls.Add(A_2, 0, 0);
			A_4 = new DataGridView
			{
				Dock = DockStyle.Fill,
				Margin = new Padding(0, 0, 0, 6),
				ReadOnly = true,
				AllowUserToAddRows = false,
				AllowUserToDeleteRows = false,
				AllowUserToResizeRows = false,
				RowHeadersVisible = false,
				SelectionMode = DataGridViewSelectionMode.FullRowSelect,
				MultiSelect = true,
				AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
				BorderStyle = BorderStyle.FixedSingle,
				BackgroundColor = SystemColors.Window
			};
			A_4.Columns.Add(A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Td(), 30, 140));
			A_4.Columns.Add(A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Te(), 42, 200));
			A_4.Columns.Add(A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Kd(), 13, 70));
			A_4.Columns.Add(A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.KE(), 15, 130));
			A_4.CellDoubleClick += (object P_0, DataGridViewCellEventArgs P_1) =>
			{
				if (P_1.RowIndex >= 0)
				{
					d();
				}
			};
			tableLayoutPanel.Controls.Add(A_4, 0, 1);
			FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel
			{
				Dock = DockStyle.Fill,
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				WrapContents = true,
				FlowDirection = FlowDirection.LeftToRight,
				Margin = new Padding(0)
			};
			A_1 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLU(), 108);
			A_1.Enabled = false;
			A_1.Click += delegate
			{
				a_m_1();
			};
			a_1 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Tf(), 124);
			a_1.Click += delegate
			{
				c();
			};
			B_1 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Tg(), 136);
			B_1.Click += delegate
			{
				D();
			};
			a_1.Margin = new Padding(0, 0, 8, 4);
			B_1.Margin = new Padding(0, 0, 8, 4);
			flowLayoutPanel.Controls.Add(A_1);
			flowLayoutPanel.Controls.Add(a_1);
			flowLayoutPanel.Controls.Add(B_1);
			tableLayoutPanel.Controls.Add(flowLayoutPanel, 0, 2);
			A_3 = new LinkLabel
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Th(),
				AutoSize = true,
				Margin = new Padding(2, 2, 0, 0),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BH()
			};
			A_3.LinkClicked += delegate
			{
				try
				{
					Process.Start(new ProcessStartInfo(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOD())
					{
						UseShellExecute = true
					});
				}
				catch
				{
				}
			};
			tableLayoutPanel.Controls.Add(A_3, 0, 3);
			b();
		}

		private static DataGridViewTextBoxColumn A_m_1(string P_0, int P_1, int P_2)
		{
			return new DataGridViewTextBoxColumn
			{
				HeaderText = P_0,
				FillWeight = P_1,
				MinimumWidth = P_2,
				SortMode = DataGridViewColumnSortMode.NotSortable,
				ReadOnly = true
			};
		}

		private static Button A_m_1(string P_0, int P_1)
		{
			return new Button
			{
				Text = P_0,
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				MinimumSize = new Size(P_1, 32),
				Padding = new Padding(8, 0, 8, 0),
				FlatStyle = FlatStyle.Flat,
				UseVisualStyleBackColor = false,
				Font = global::B.Q.A_m_1(10f),
				Cursor = Cursors.Hand,
				Margin = new Padding(0, 4, 8, 4)
			};
		}

		public void A_m_1(string P_0)
		{
			A_8 = P_0 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
		}

		public void a_m_1(string P_0)
		{
			A_2.Text = P_0 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
		}

		public void a_m_1()
		{
			if (A_5 != null)
			{
				try
				{
					A_5.Cancel();
				}
				catch
				{
				}
				A_2.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bD());
			}
		}

		public void B_m_1()
		{
			b();
		}

		public void A_m_1(Y P_0)
		{
			if (A_3 != null)
			{
				A_3.LinkColor = P_0.f;
			}
		}

		public void B_m_1(string P_0)
		{
			string A = (P_0 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).Trim();
			if (A.Length == 0)
			{
				A_2.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Tj());
			}
			else
			{
				if (A_6)
				{
					return;
				}
				A_6 = true;
				a_2 = A;
				A_7 = null;
				A_5 = new CancellationTokenSource();
				CancellationToken A_1 = A_5.Token;
				this.A_1.Enabled = true;
				a_1.Enabled = false;
				B_1.Enabled = false;
				A_4.Rows.Clear();
				b();
				string a_f_1 = A_8;
				Task.Run(() => V.A_m_1(A, a_f_1, 1000, A_1)).ContinueWith((Task<T> task) =>
				{
					if (IsDisposed)
					{
						return;
					}
					T A2 = null;
					try
					{
						A2 = task.Result;
					}
					catch (Exception ex)
					{
						A2 = new T
						{
							A_3 = ex.Message
						};
					}
					try
					{
						if (IsHandleCreated)
						{
							BeginInvoke(() =>
							{
								A_m_1(A2, A);
							});
						}
					}
					catch
					{
					}
				});
			}
		}

		private void A_m_1(T P_0, string P_1)
		{
			if (IsDisposed)
			{
				return;
			}
			A_6 = false;
			A_5 = null;
			A_7 = P_0;
			A_1.Enabled = false;
			a_1.Enabled = true;
			B_1.Enabled = true;
			A_4.SuspendLayout();
			A_4.Rows.Clear();
			if (P_0 != null && !P_0.a)
			{
				foreach (S item in P_0.A_1)
				{
					A_4.Rows.Add(item.A, item.a, (item.A_1 < 0) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bE() : A_m_1(item.A_1), (item.A_2 == DateTime.MinValue) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bE() : item.A_2.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.q()));
				}
			}
			A_4.ResumeLayout();
			b();
			if (P_0 == null || P_0.A == s.A)
			{
				return;
			}
			try
			{
				A_10?.Invoke(P_1, P_0.BackendKey);
			}
			catch
			{
			}
		}

		private void b()
		{
			if (A_6)
			{
				A_2.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Tk());
				return;
			}
			if (A_7 == null)
			{
				A_2.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Tc());
				return;
			}
			if (A_7.a)
			{
				A_2.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.TM());
				return;
			}
			string text = A_m_1(A_7);
			if (A_7.A == s.A)
			{
				A_2.Text = text + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.o() + global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.TP(), A_7.A_3 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
				return;
			}
			string text2 = text + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.o() + global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.TN(), A_7.A_1.Count);
			if (A_7.A_2)
			{
				text2 = text2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.o() + global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.TO(), 1000);
			}
			A_2.Text = text2;
		}

		private static string A_m_1(T P_0)
		{
			return P_0.A switch
			{
				s.a => P_0.a_1 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLq(), 
				s.B => _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLJ(), 
				s.b => global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.TS()), 
				_ => global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.TT()), 
			};
		}

		internal static string A_m_1(long P_0)
		{
			if (P_0 < 1024)
			{
				return P_0 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bd();
			}
			double num = (double)P_0 / 1024.0;
			if (num < 1024.0)
			{
				return num.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.w()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BE();
			}
			num /= 1024.0;
			if (num < 1024.0)
			{
				return num.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.w()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Be();
			}
			return (num / 1024.0).ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.w()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bf();
		}

		private S C()
		{
			if (A_4.SelectedRows.Count == 0)
			{
				return null;
			}
			int index = A_4.SelectedRows[0].Index;
			if (A_7 == null || index < 0 || index >= A_7.A_1.Count)
			{
				return null;
			}
			return A_7.A_1[index];
		}

		private void c()
		{
			S s2 = C();
			if (s2 == null)
			{
				A_2.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.TV());
				return;
			}
			string text;
			if (s2.A_3)
			{
				text = s2.B;
			}
			else
			{
				text = (string.IsNullOrEmpty(s2.a) ? Path.GetDirectoryName(s2.B) : s2.a);
			}
			if (string.IsNullOrEmpty(text) || !Directory.Exists(text))
			{
				A_2.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.TW());
				return;
			}
			try
			{
				A_9?.Invoke(text);
			}
			catch
			{
			}
		}

		private void D()
		{
			S s2 = C();
			if (s2 == null)
			{
				A_2.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.TV());
				return;
			}
			try
			{
				string arguments = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDi() + s2.B + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JX();
				Process.Start(new ProcessStartInfo(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDI(), arguments)
				{
					UseShellExecute = true
				});
			}
			catch (Exception ex)
			{
				A_2.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.TX(), ex.Message);
			}
		}

		private void d()
		{
			S s2 = C();
			if (s2 == null)
			{
				return;
			}
			try
			{
				if (s2.A_3)
				{
					Process.Start(new ProcessStartInfo(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDI(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JX() + s2.B + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JX())
					{
						UseShellExecute = true
					});
				}
				else
				{
					Process.Start(new ProcessStartInfo(s2.B)
					{
						UseShellExecute = true
					});
				}
			}
			catch (Exception ex)
			{
				A_2.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.TX(), ex.Message);
			}
		}

		[CompilerGenerated]
		private void A_m_1(object P_0, DataGridViewCellEventArgs P_1)
		{
			if (P_1.RowIndex >= 0)
			{
				d();
			}
		}

		[CompilerGenerated]
		private void A_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			a_m_1();
		}

		[CompilerGenerated]
		private void a_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			c();
		}

		[CompilerGenerated]
		private void B_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			D();
		}
	}
}
