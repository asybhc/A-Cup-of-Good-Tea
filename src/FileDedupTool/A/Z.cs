using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007B1262ED64_002DD0A6_002D499E_002D9510_002DF2240F018DBB_007D;
using A;
using B;
using a;
using b;

namespace A
{
	public sealed class Z
	{
		/// <summary>
		/// R9 / C-03：扫描期快照登记表（路径 → 扫描时的文件身份快照）。
		/// 原实现的复核只挂在“清理预览”对话框上，真正的删除路径（A\A.A 删除原语）完全没有复核，
		/// 扫描后被替换/追加写入的文件仍会被删除。这里把快照在扫描期登记下来，
		/// 由删除原语统一复核，确保“预览复核”与“实际删除”使用同一套判定。
		/// </summary>
		private static readonly System.Collections.Concurrent.ConcurrentDictionary<string, Z> A_4 = new System.Collections.Concurrent.ConcurrentDictionary<string, Z>(StringComparer.OrdinalIgnoreCase);

		public long A;

		public DateTime A_1;

		public string A_2;

		public bool A_3;

		/// <summary>R9 / C-03：登记扫描期快照，供删除原语复核使用。</summary>
		internal static void a_m_1(string P_0, Z P_1)
		{
			if (string.IsNullOrEmpty(P_0) || P_1 == null)
			{
				return;
			}
			string text;
			try
			{
				text = global::a.a.A(P_0);
			}
			catch
			{
				return;
			}
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
			if (A_4.Count > 200000)
			{
				A_4.Clear();
			}
			A_4[text] = P_1;
		}

		/// <summary>R9 / C-03：删除成功后移除登记项，避免同一路径残留旧快照。</summary>
		internal static void a_m_1(string P_0)
		{
			if (string.IsNullOrEmpty(P_0))
			{
				return;
			}
			try
			{
				A_4.TryRemove(global::a.a.A(P_0), out var _);
			}
			catch
			{
			}
		}

		/// <summary>R9 / C-03：按路径取扫描期快照。</summary>
		internal static Z B_m_1(string P_0)
		{
			if (string.IsNullOrEmpty(P_0))
			{
				return null;
			}
			try
			{
				if (A_4.TryGetValue(global::a.a.A(P_0), out var value))
				{
					return value;
				}
			}
			catch
			{
			}
			return null;
		}

		/// <summary>
		/// R9 / C-03：删除前复核。无登记快照时返回 true（保持原有行为，不阻断未登记路径的删除）；
		/// 有快照时按 大小/哈希/修改时间 复核，失败返回 false 并给出原因。
		/// </summary>
		internal static bool C_m_1(string P_0, out string P_1)
		{
			P_1 = null;
			Z z2 = B_m_1(P_0);
			if (z2 == null)
			{
				return true;
			}
			P_1 = z2.A_m_1(P_0);
			return P_1 == null;
		}

		public static Z A_m_1(string P_0, bool P_1 = true, string P_2 = null)
		{
			Z z2 = new Z();
			try
			{
				FileInfo fileInfo = new FileInfo(global::a.a.A(P_0));
				if (!fileInfo.Exists)
				{
					return z2;
				}
				z2.A_3 = true;
				z2.A = fileInfo.Length;
				z2.A_1 = fileInfo.LastWriteTimeUtc;
				if (P_1)
				{
					if (!string.IsNullOrEmpty(P_2))
					{
						z2.A_2 = P_2;
					}
					else
					{
						try
						{
							z2.A_2 = a.k.A_m_1(P_0);
						}
						catch
						{
							z2.A_2 = null;
						}
					}
				}
			}
			catch
			{
			}
			return z2;
		}

		public string A_m_1(string P_0)
		{
			FileInfo fileInfo;
			try
			{
				fileInfo = new FileInfo(global::a.a.A(P_0));
			}
			catch (Exception ex)
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JC() + ex.Message;
			}
			if (!fileInfo.Exists)
			{
				if (!A_3)
				{
					return null;
				}
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jc();
			}
			if (!A_3)
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JD();
			}
			if (fileInfo.Length != A)
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jd() + A + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JE() + fileInfo.Length + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Je();
			}
			if (!string.IsNullOrEmpty(A_2))
			{
				string text;
				try
				{
					text = a.k.b(P_0);
				}
				catch (Exception ex2)
				{
					return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JF() + ex2.Message;
				}
				if (!string.Equals(text, A_2, StringComparison.OrdinalIgnoreCase))
				{
					return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jf();
				}
				return null;
			}
			if (fileInfo.LastWriteTimeUtc != A_1)
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JG();
			}
			return null;
		}
	}
	internal sealed class z : Form
	{
		internal TextBox A;

		internal Button A_1;

		internal Button a;

		internal Label A_2;

		internal string A_3 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		private readonly Func<IEnumerable<string>> A_4;

		internal z(b.Y P_0, string P_1, Func<IEnumerable<string>> P_2)
		{
			A_4 = P_2;
			b.Y y2 = P_0 ?? b.Y.A_m_1();
			Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jg());
			StartPosition = FormStartPosition.CenterParent;
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			MinimizeBox = false;
			ShowInTaskbar = false;
			AutoScaleMode = AutoScaleMode.Font;
			Font = global::B.Q.A_m_1(10f);
			ClientSize = new Size(480, 190);
			BackColor = y2.A;
			ForeColor = y2.b;
			TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
			{
				Dock = DockStyle.Fill,
				ColumnCount = 1,
				RowCount = 4,
				Padding = new Padding(16, 14, 16, 12)
			};
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			Label control = new Label
			{
				Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JH(), P_1 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Dw()),
				AutoSize = true,
				MaximumSize = new Size(440, 0),
				Margin = new Padding(0, 0, 0, 8)
			};
			tableLayoutPanel.Controls.Add(control, 0, 0);
			A = new TextBox
			{
				Dock = DockStyle.Top,
				Font = global::B.Q.A_m_1(10.5f),
				Margin = new Padding(0)
			};
			A.TextChanged += delegate
			{
				A_m_1();
			};
			tableLayoutPanel.Controls.Add(A, 0, 1);
			A_2 = new Label
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(),
				AutoSize = true,
				MaximumSize = new Size(440, 0),
				ForeColor = y2.J,
				Margin = new Padding(0, 6, 0, 0)
			};
			tableLayoutPanel.Controls.Add(A_2, 0, 2);
			FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel
			{
				FlowDirection = FlowDirection.RightToLeft,
				Dock = DockStyle.Fill,
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				WrapContents = false,
				Margin = new Padding(0, 4, 0, 0)
			};
			A_1 = new Button
			{
				Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jh()),
				Width = 96,
				Height = 32,
				Enabled = false,
				Font = global::B.Q.A_m_1(10.5f, FontStyle.Bold),
				Margin = new Padding(8, 0, 0, 0)
			};
			A_1.Click += delegate
			{
				string text = global::B.D.A_m_1(A.Text);
				if (global::B.D.A_m_1(text, A_4()) != null)
				{
					A_m_1();
				}
				else
				{
					A_3 = text;
					DialogResult = DialogResult.OK;
					Close();
				}
			};
			a = new Button
			{
				Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BX()),
				Width = 96,
				Height = 32,
				DialogResult = DialogResult.Cancel,
				Margin = new Padding(0)
			};
			flowLayoutPanel.Controls.Add(A_1);
			flowLayoutPanel.Controls.Add(a);
			tableLayoutPanel.Controls.Add(flowLayoutPanel, 0, 3);
			Controls.Add(tableLayoutPanel);
			AcceptButton = A_1;
			CancelButton = a;
			b.Z.A_m_1(this, y2, A_1);
			global::a.Q.A_m_1(this);
			Shown += delegate
			{
				A.Focus();
			};
		}

		private void A_m_1()
		{
			string text = global::B.D.A_m_1(A.Text);
			string text2 = global::B.D.A_m_1(text, A_4());
			A_2.Text = ((text.Length == 0) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D() : global::B.D.a(text2));
			A_1.Enabled = text.Length > 0 && text2 == null;
		}

		[CompilerGenerated]
		private void A_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			A_m_1();
		}

		[CompilerGenerated]
		private void a_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			string text = global::B.D.A_m_1(A.Text);
			if (global::B.D.A_m_1(text, A_4()) != null)
			{
				A_m_1();
				return;
			}
			A_3 = text;
			DialogResult = DialogResult.OK;
			Close();
		}

		[CompilerGenerated]
		private void B(object? _003Cp0_003E, EventArgs P_1)
		{
			A.Focus();
		}
	}
}
namespace a
{
	internal static class Z
	{
		internal const long A = 104857600L;

		internal const string A_1 = "网盘重复文件";

		internal static long A_m_1(string P_0)
		{
			string text = (P_0 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).Trim().ToUpperInvariant();
			if (text.Length == 0)
			{
				return -1L;
			}
			int num;
			for (num = 0; num < text.Length && (char.IsDigit(text[num]) || text[num] == '.'); num++)
			{
			}
			if (num == 0)
			{
				return -1L;
			}
			if (!double.TryParse(text.Substring(0, num), NumberStyles.Float, CultureInfo.InvariantCulture, out var result))
			{
				return -1L;
			}
			string text2 = text.Substring(num).Trim();
			if (text2.IndexOf(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAB(), StringComparison.Ordinal) >= 0)
			{
				return (long)(result * 1024.0 * 1024.0 * 1024.0);
			}
			if (text2.IndexOf(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAb(), StringComparison.Ordinal) >= 0)
			{
				return (long)(result * 1024.0 * 1024.0);
			}
			if (text2.IndexOf(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAC(), StringComparison.Ordinal) >= 0)
			{
				return (long)(result * 1024.0);
			}
			return (long)result;
		}

		internal static string a(string P_0)
		{
			return (P_0 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).Trim();
		}

		internal static bool A_m_1(string P_0, string P_1)
		{
			return string.Equals(a(P_0), a(P_1), StringComparison.OrdinalIgnoreCase);
		}

		internal static bool A_m_1(long P_0, long P_1)
		{
			if (P_1 < 0 || P_0 < 0)
			{
				return false;
			}
			return Math.Abs(P_0 - P_1) <= Math.Max(2048L, P_0 / 100);
		}

		internal static w A_m_1(string P_0, long P_1, IList<w> P_2)
		{
			if (P_2 == null)
			{
				return null;
			}
			foreach (w item in P_2)
			{
				if (item != null && A_m_1(P_0, item.Name) && A_m_1(P_1, item.SizeBytes))
				{
					return item;
				}
			}
			return null;
		}

		internal static string A_m_1(string P_0, string P_1, string P_2)
		{
			if (!string.IsNullOrWhiteSpace(P_1))
			{
				return Path.GetFullPath(P_1);
			}
			string path = (string.IsNullOrWhiteSpace(P_2) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iy() : P_2.Trim());
			string fullPath = Path.GetFullPath(P_0 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
			string directoryName = Path.GetDirectoryName(fullPath);
			if (string.IsNullOrEmpty(directoryName))
			{
				return Path.Combine(fullPath, path);
			}
			return Path.Combine(directoryName, path);
		}

		internal static string a(string P_0, string P_1)
		{
			Directory.CreateDirectory(global::a.a.a_m_1(P_1));
			string text = Path.Combine(P_1, Path.GetFileName(P_0));
			text = global::a.a.E(text);
			global::a.a.a_m_1(P_0, text);
			return text;
		}
	}
	internal static class z
	{
		internal static global::B.A A(string P_0)
		{
			string text = (P_0 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).Trim();
			if (text.Length == 0)
			{
				return null;
			}
			if (text.StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ix(), StringComparison.OrdinalIgnoreCase))
			{
				text = text.Substring(7).Trim();
			}
			text = text.Trim('"', '\'', '{', '}');
			string text2 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			string text3 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			string[] array = text.Split(new char[3] { ';', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
			for (int num = 0; num < array.Length; num++)
			{
				string text4 = array[num].Trim().TrimEnd(',');
				int num2 = text4.IndexOf('=');
				if (num2 > 0)
				{
					string text5 = text4.Substring(0, num2).Trim().Trim('"');
					string text6 = text4.Substring(num2 + 1).Trim().Trim('"');
					if (string.Equals(text5, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iV(), StringComparison.OrdinalIgnoreCase))
					{
						text2 = text6;
					}
					else if (string.Equals(text5, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iv(), StringComparison.OrdinalIgnoreCase))
					{
						text3 = text6;
					}
				}
			}
			if (text2.Length == 0 || text3.Length == 0)
			{
				return null;
			}
			return new global::B.A
			{
				Ylogin = text2,
				PhpdiskInfo = text3
			};
		}

		internal static string a(string P_0)
		{
			if (string.IsNullOrEmpty(P_0))
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}
			if (P_0.Length < 4)
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bw();
			}
			return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bw() + P_0.Substring(P_0.Length - 4);
		}

		internal static global::B.A A(global::A.W P_0, string P_1)
		{
			if (P_0 != null && P_0.Id == global::A.v.a)
			{
				global::B.A a2 = A(P_0, global::A.X.A(P_1));
				if (a2 != null)
				{
					return a2;
				}
				string text = (P_1 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).Trim().Trim('"', '\'', '{', '}', ';', ',');
				if (text.Length > 0 && !text.Contains(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zI()) && !text.Contains(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAc()))
				{
					return new global::B.A
					{
						AppToken = text,
						Extra = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iW() + text
					};
				}
				return null;
			}
			return A(P_1);
		}

		internal static global::B.A A(global::A.W P_0, IEnumerable<KeyValuePair<string, string>> P_1)
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
			StringBuilder stringBuilder = new StringBuilder();
			if (P_1 != null)
			{
				foreach (KeyValuePair<string, string> item in P_1)
				{
					if (!string.IsNullOrEmpty(item.Key) && !string.IsNullOrEmpty(item.Value))
					{
						dictionary[item.Key.Trim()] = item.Value.Trim();
						if (stringBuilder.Length > 0)
						{
							stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAD());
						}
						stringBuilder.Append(item.Key.Trim()).Append('=').Append(item.Value.Trim());
					}
				}
			}
			if (P_0 != null && P_0.Id == global::A.v.a)
			{
				if (!dictionary.TryGetValue(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iu(), out var value) || value.Length == 0)
				{
					return null;
				}
				dictionary.TryGetValue(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAd(), out var value2);
				return new global::B.A
				{
					AppToken = value,
					Uuid = (value2 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()),
					Extra = stringBuilder.ToString()
				};
			}
			if (!dictionary.TryGetValue(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iV(), out var value3) || !dictionary.TryGetValue(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iv(), out var value4))
			{
				return null;
			}
			return new global::B.A
			{
				Ylogin = value3,
				PhpdiskInfo = value4
			};
		}

		internal static string B(string P_0)
		{
			string text = P_0 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			if (text.Length == 0)
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}
			if (text.Length <= 4)
			{
				return new string('*', Math.Max(2, text.Length));
			}
			return text.Substring(0, 2) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bw() + text.Substring(text.Length - 2, 2);
		}
	}
}
