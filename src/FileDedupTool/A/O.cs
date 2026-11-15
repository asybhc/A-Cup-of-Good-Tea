using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007B1262ED64_002DD0A6_002D499E_002D9510_002DF2240F018DBB_007D;
using B;
using a;
using b;

namespace A
{
	public static class O
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class A
		{
			public static readonly A A_f_1 = new A();

			public static Func<b.Q, long> A_f_2;

			internal long A_m_1(b.Q P_0)
			{
				return P_0.A_1;
			}
		}

		public static J A_m_1(b.R P_0)
		{
			if (P_0 == null)
			{
				return null;
			}
			J j2 = new J
			{
				Source = P_0.A_4,
				Time = P_0.A_5.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CI()),
				FilesScanned = P_0.A_2,
				ScannedBytes = P_0.A_3,
				GroupCount = P_0.A_1.Count,
				DuplicateFileCount = P_0.DupFileCount,
				ReclaimableBytes = P_0.WastedBytes,
				Warnings = new List<string>(P_0.A_6)
			};
			foreach (b.q item in P_0.A_1)
			{
				i i2 = new i
				{
					Kind = item.A_1,
					KindText = item.a,
					Key = item.B,
					Count = item.A_2.Count,
					TotalSize = item.A_2.Sum((b.Q q2) => q2.A_1),
					ReclaimableBytes = item.WastedBytes
				};
				foreach (b.Q item2 in item.A_2)
				{
					i2.Keep = i2.Keep ?? (item2.A_3 ? item2.A : null);
					i2.Items.Add(new I
					{
						Path = item2.A,
						Size = item2.A_1,
						Modified = item2.A_2.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CI()),
						IsKeep = item2.A_3,
						Sha256 = ((item2.A_4 == null) ? null : item2.A_4.A_2)
					});
				}
				j2.Groups.Add(i2);
			}
			return j2;
		}

		public static j A_m_1(b.E P_0)
		{
			if (P_0 == null)
			{
				return null;
			}
			return new j
			{
				Renamed = P_0.A,
				Deleted = P_0.a,
				Moved = P_0.B,
				Skipped = P_0.b,
				ReadOnlyCleared = P_0.C,
				MoveSkipped = P_0.c,
				HashRemoved = P_0.D,
				ImageRemoved = P_0.d,
				DirsRemoved = P_0.E_f_1,
				Protected = P_0.e,
				AudioRemoved = P_0.F,
				Hardlinked = P_0.f,
				Excluded = P_0.G,
				DryRun = P_0.A_1
			};
		}

		public static N A_m_1(b.a P_0, b.B P_1)
		{
			if (P_0 == null)
			{
				return null;
			}
			N n2 = new N
			{
				Granularity = global::b.b.a_m_1(P_0.A_2),
				Mode = ((P_0.A_3 == B.Y.a) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CJ() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ci()),
				Conflict = ((P_0.A_4 == B.y.B) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ck() : ((P_0.A_4 == B.y.a) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CK() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cj())),
				FileCount = P_0.FileCount,
				TotalBytes = P_0.TotalBytes,
				Conflicts = P_0.ConflictCount,
				DuplicateDeletes = P_0.PredictedDeleteCount,
				ReclaimableBytes = P_0.PredictedDeleteBytes,
				Renamed = P_0.RenameCount,
				Unknown = P_0.UnknownCount,
				DryRun = P_0.A_5,
				PlanSummary = P_0.a_m_1()
			};
			if (P_1 != null)
			{
				n2.Succeeded = P_1.a;
				n2.Failed = P_1.B_f_1;
				n2.Skipped = P_1.b;
				n2.DuplicateDeleted = P_1.d;
				n2.DuplicateSkipped = P_1.E;
				n2.ReclaimedBytes = P_1.A_1;
			}
			foreach (KeyValuePair<string, int> item in P_0.A_m_1())
			{
				n2.Groups.Add(new M
				{
					Dir = item.Key,
					Count = item.Value
				});
			}
			foreach (b.A item2 in P_0.A_6)
			{
				n2.Items.Add(new m
				{
					Source = item2.A_f_1,
					Target = item2.B,
					Time = (item2.A_f_3.HasValue ? item2.A_f_3.Value.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CI()) : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()),
					TimeSource = global::b.b.A_m_1(item2.A_f_4),
					Size = item2.A_f_2,
					Renamed = item2.B_1,
					Duplicate = item2.a_1,
					Md5 = item2.c,
					Result = item2.d,
					Error = item2.E
				});
			}
			return n2;
		}

		public static k A_m_1()
		{
			B.k current = a.j.Current;
			k k2 = new k
			{
				Active = a.j.Active,
				Pro = a.j.Pro,
				MachineCode = a.j.MachineCode,
				Status = a.j.StatusText
			};
			if (current != null && current.A_2 != null)
			{
				k2.Edition = current.A_2.EditionName;
				k2.IsForever = current.IsForever;
				k2.Expiry = (current.IsForever ? null : current.Expiry.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CL()));
				k2.DaysLeft = a.j.DaysLeft;
			}
			else
			{
				k2.Edition = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cl();
			}
			return k2;
		}
	}
	internal static class o
	{
		public static JsonElement A(JsonElement P_0, params string[] names)
		{
			foreach (string propertyName in names)
			{
				if (P_0.ValueKind == JsonValueKind.Object && P_0.TryGetProperty(propertyName, out var value))
				{
					return value;
				}
			}
			return default;
		}

		public static string A(JsonElement P_0, string P_1, params string[] names)
		{
			JsonElement jsonElement = A(P_0, names);
			if (jsonElement.ValueKind == JsonValueKind.String)
			{
				return jsonElement.GetString();
			}
			if (jsonElement.ValueKind == JsonValueKind.Number)
			{
				return jsonElement.ToString();
			}
			return P_1;
		}

		public static bool A(JsonElement P_0, bool P_1, params string[] names)
		{
			JsonElement jsonElement = A(P_0, names);
			if (jsonElement.ValueKind == JsonValueKind.True)
			{
				return true;
			}
			if (jsonElement.ValueKind == JsonValueKind.False)
			{
				return false;
			}
			if (jsonElement.ValueKind == JsonValueKind.String)
			{
				string text = jsonElement.GetString();
				if (text == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CM() || string.Equals(text, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cm(), StringComparison.OrdinalIgnoreCase))
				{
					return true;
				}
				if (text == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CN() || string.Equals(text, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cn(), StringComparison.OrdinalIgnoreCase))
				{
					return false;
				}
			}
			if (jsonElement.ValueKind == JsonValueKind.Number)
			{
				return jsonElement.GetDouble() != 0.0;
			}
			return P_1;
		}

		public static long A(JsonElement P_0, long P_1, params string[] names)
		{
			JsonElement jsonElement = A(P_0, names);
			if (jsonElement.ValueKind == JsonValueKind.Number)
			{
				return jsonElement.GetInt64();
			}
			if (jsonElement.ValueKind == JsonValueKind.String && long.TryParse(jsonElement.GetString(), out var result))
			{
				return result;
			}
			return P_1;
		}

		public static int A(JsonElement P_0, int P_1, params string[] names)
		{
			JsonElement jsonElement = A(P_0, names);
			if (jsonElement.ValueKind == JsonValueKind.Number)
			{
				return jsonElement.GetInt32();
			}
			if (jsonElement.ValueKind == JsonValueKind.String && int.TryParse(jsonElement.GetString(), out var result))
			{
				return result;
			}
			return P_1;
		}
	}
}
namespace a
{
	internal static class O
	{
		internal static void A(RichTextBox P_0, string P_1, global::b.Y P_2)
		{
			if (P_0 == null)
			{
				return;
			}
			List<l> list = n.A_m_1(P_1);
			Font font = P_0.Font;
			Font font2 = new Font(font.FontFamily, font.Size + 5f, FontStyle.Bold);
			Font font3 = new Font(font.FontFamily, font.Size + 3f, FontStyle.Bold);
			Font font4 = new Font(font.FontFamily, font.Size + 1.5f, FontStyle.Bold);
			Font font5 = new Font(font, FontStyle.Bold);
			Font font6 = new Font(font, FontStyle.Italic);
			Font font7 = new Font(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ME(), font.Size, FontStyle.Regular);
			Font font8 = new Font(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Me(), font.Size, FontStyle.Regular);
			try
			{
				P_0.SuspendLayout();
				P_0.Clear();
				foreach (l item in list)
				{
					A(P_0, item, P_2, font, font2, font3, font4, font5, font6, font7, font8);
				}
				P_0.SelectionStart = 0;
				P_0.SelectionLength = 0;
				P_0.ScrollToCaret();
			}
			finally
			{
				P_0.ResumeLayout();
				font2.Dispose();
				font3.Dispose();
				font4.Dispose();
				font5.Dispose();
				font6.Dispose();
				font7.Dispose();
				font8.Dispose();
			}
		}

		private static void A(RichTextBox P_0, l P_1, global::b.Y P_2, Font P_3, Font P_4, Font P_5, Font P_6, Font P_7, Font P_8, Font P_9, Font P_10)
		{
			switch (P_1.A)
			{
			case L.A:
			{
				RichTextBox richTextBox3 = P_0;
				string text5 = P_1.a + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.MF();
				Font font3;
				if (P_1.A_1 <= 1)
				{
					font3 = P_4;
				}
				else
				{
					font3 = ((P_1.A_1 == 2) ? P_5 : P_6);
				}
				RichTextBox richTextBox4 = richTextBox3;
				string text6 = text5;
				Font font4 = font3;
				Color color;
				if (P_1.A_1 == 2)
				{
					color = P_2.f;
				}
				else
				{
					color = ((P_1.A_1 <= 1) ? P_2.C : P_2.b);
				}
				A(richTextBox4, text6, font4, color);
				break;
			}
			case L.a:
				foreach (M item in n.B_m_1(P_1.a))
				{
					RichTextBox richTextBox2 = P_0;
					string text4 = item.A;
					Font font2;
					if (item.a)
					{
						font2 = P_9;
					}
					else
					{
						font2 = (item.A_1 ? P_7 : P_3);
					}
					A(richTextBox2, text4, font2, item.a ? P_2.I : P_2.h);
				}
				A(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BD(), P_3, P_2.h);
				break;
			case L.B:
				P_0.SelectionIndent = 14;
				A(P_0, n.b_m_1(P_1.a) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BD(), P_8, P_2.I);
				P_0.SelectionIndent = 0;
				break;
			case L.b:
				P_0.SelectionIndent = 10 + P_1.A_1 * 18;
				P_0.SelectionHangingIndent = 14;
				A(P_0, P_1.A_2 ? (P_1.A_3 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aH()) : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Mf(), P_3, P_2.h);
				foreach (M item2 in n.B_m_1(P_1.a))
				{
					RichTextBox richTextBox = P_0;
					string text2 = item2.A;
					Font font;
					if (item2.a)
					{
						font = P_9;
					}
					else
					{
						font = (item2.A_1 ? P_7 : P_3);
					}
					A(richTextBox, text2, font, item2.a ? P_2.I : P_2.h);
				}
				A(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BD(), P_3, P_2.h);
				P_0.SelectionIndent = 0;
				P_0.SelectionHangingIndent = 0;
				break;
			case L.C:
			{
				string[] array = n.A_m_1(P_1.A_4).TrimEnd('\n').Split('\n');
				foreach (string text3 in array)
				{
					A(P_0, text3 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BD(), P_10, P_2.h);
				}
				A(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BD(), P_3, P_2.h);
				break;
			}
			case L.c:
			{
				P_0.SelectionIndent = 14;
				string[] array = P_1.B.Split('\n');
				foreach (string text in array)
				{
					A(P_0, text + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BD(), P_9, P_2.b);
				}
				P_0.SelectionIndent = 0;
				A(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BD(), P_3, P_2.h);
				break;
			}
			case L.D:
				A(P_0, new string('─', 36) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.MF(), P_3, P_2.B);
				break;
			}
		}

		private static void A(RichTextBox P_0, string P_1, Font P_2, Color P_3)
		{
			if (!string.IsNullOrEmpty(P_1))
			{
				P_0.SelectionStart = P_0.TextLength;
				P_0.SelectionLength = 0;
				P_0.SelectionFont = P_2;
				P_0.SelectionColor = P_3;
				P_0.SelectionBackColor = P_0.BackColor;
				P_0.AppendText(P_1);
			}
		}
	}
	internal static class o
	{
		internal static List<m> A(string P_0, string P_1)
		{
			List<m> list = new List<m>();
			if (string.IsNullOrEmpty(P_0) || string.IsNullOrEmpty(P_1))
			{
				return list;
			}
			int num = 0;
			while (num <= P_0.Length - P_1.Length)
			{
				int num2 = P_0.IndexOf(P_1, num, StringComparison.CurrentCultureIgnoreCase);
				if (num2 < 0)
				{
					break;
				}
				list.Add(new m
				{
					A = num2,
					a = P_1.Length
				});
				num = num2 + Math.Max(1, P_1.Length);
			}
			return list;
		}
	}
}
