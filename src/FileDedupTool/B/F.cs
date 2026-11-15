using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007B1262ED64_002DD0A6_002D499E_002D9510_002DF2240F018DBB_007D;
using A;
using B;
using a;

namespace B
{
	internal static class F
	{
		internal static JsonElement A(string P_0, string P_1)
		{
			string text = (P_0 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).Trim();
			if (text.Length == 0)
			{
				throw new global::a.v(global::a.V.B, P_1 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zr());
			}
			if (text[0] == '<' || text.IndexOf(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zS(), StringComparison.OrdinalIgnoreCase) >= 0 || text.IndexOf(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zs(), StringComparison.OrdinalIgnoreCase) >= 0)
			{
				throw new global::a.v(global::a.V.a, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aaC());
			}
			try
			{
				return JsonDocument.Parse(text).RootElement;
			}
			catch (JsonException)
			{
				throw new global::a.v(global::a.V.C, P_1 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zt() + global::a.y.A(text) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ln());
			}
		}

		internal static void A(JsonElement P_0, string P_1)
		{
			int num = A(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAX(), 0);
			if (num == 0 || num == 200)
			{
				return;
			}
			string text = a(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAx());
			string text2 = (string.IsNullOrWhiteSpace(text) ? "（服务端未返回 msg）" : text.Trim());
			string text3 = "code=" + num.ToString(CultureInfo.InvariantCulture) + "，操作：" + P_1 + "，服务端原文：" + text2;
			if (num == -1 || num == -2)
			{
				if (a_m_2(text2))
				{
					throw new global::a.v(global::a.V.C, "容量不足：" + text3);
				}
				if (a_m_3(text2))
				{
					throw new global::a.v(global::a.V.a, text3);
				}
			}
			throw new global::a.v(global::a.V.b, "蓝奏接口业务失败：" + text3);
		}

		private static bool a_m_2(string P_0)
		{
			return P_0.IndexOf("容量", StringComparison.Ordinal) >= 0 || P_0.IndexOf("空间不足", StringComparison.Ordinal) >= 0 || P_0.IndexOf("配额", StringComparison.Ordinal) >= 0 || P_0.IndexOf("存储不足", StringComparison.Ordinal) >= 0 || P_0.IndexOf("已满", StringComparison.Ordinal) >= 0;
		}

		private static bool a_m_3(string P_0)
		{
			return P_0.IndexOf("登录", StringComparison.Ordinal) >= 0 || P_0.IndexOf("登陆", StringComparison.Ordinal) >= 0 || P_0.IndexOf("未授权", StringComparison.Ordinal) >= 0 || P_0.IndexOf("token", StringComparison.OrdinalIgnoreCase) >= 0 || P_0.IndexOf("凭证", StringComparison.Ordinal) >= 0;
		}

		internal static int A(string P_0, out List<E> P_1)
		{
			P_1 = new List<E>();
			JsonElement jsonElement = A(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aaE());
			A(jsonElement, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aaE());
			int result = A(jsonElement, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aae(), 1);
			if (jsonElement.TryGetProperty(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aaF(), out var value) && value.ValueKind == JsonValueKind.Array)
			{
				foreach (JsonElement item in value.EnumerateArray())
				{
					E e2 = A(item);
					if (e2 != null)
					{
						P_1.Add(e2);
					}
				}
			}
			return result;
		}

		internal static int A(string P_0, out List<global::a.W> P_1)
		{
			P_1 = new List<global::a.W>();
			JsonElement jsonElement = A(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zu());
			A(jsonElement, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zu());
			int result = A(jsonElement, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aae(), 1);
			if (jsonElement.TryGetProperty(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aaF(), out var value) && value.ValueKind == JsonValueKind.Array)
			{
				foreach (JsonElement item in value.EnumerateArray())
				{
					if (item.ValueKind == JsonValueKind.Object)
					{
						string text = a(item, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aaf());
						string text2 = a(item, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aaG());
						if (string.IsNullOrEmpty(text2))
						{
							text2 = a(item, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aag());
						}
						if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(text2))
						{
							P_1.Add(new global::a.W
							{
								Id = text,
								Name = text2,
								ItemCount = -1
							});
						}
					}
				}
			}
			return result;
		}

		private static E A(JsonElement P_0)
		{
			if (P_0.ValueKind != JsonValueKind.Object)
			{
				return null;
			}
			bool flag = A(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aaH(), -1) == 2;
			string text = (flag ? a(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aaf()) : a(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aah()));
			string text2 = (flag ? a(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aaG()) : a(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aag()));
			if (string.IsNullOrEmpty(text2))
			{
				text2 = (flag ? a(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aag()) : a(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aaG()));
			}
			if (string.IsNullOrEmpty(text2))
			{
				return null;
			}
			long num = A(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aaI(), -1L);
			return new E
			{
				FileId = (text ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()),
				Name = text2,
				IsFolder = flag,
				SizeBytes = ((flag || num < 0) ? (-1) : (num * 1024)),
				Time = a(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aai())
			};
		}

		internal static void a(string P_0, string P_1)
		{
			A(A(P_0, P_1), P_1);
		}

		internal static void A(JsonElement P_0, out string P_1, out string P_2)
		{
			P_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			P_2 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			if (P_0.TryGetProperty(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aaJ(), out var value) && value.ValueKind == JsonValueKind.Object)
			{
				P_1 = a(value, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aaj());
				P_2 = a(value, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aaK());
			}
		}

		internal static string A(string P_0)
		{
			JsonElement jsonElement = A(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aak());
			A(jsonElement, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aak());
			string text = a(jsonElement, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aaL());
			if (text.Length == 0 && jsonElement.TryGetProperty(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CE(), out var value) && value.ValueKind == JsonValueKind.Object)
			{
				text = a(value, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aaL());
			}
			if (text.Length == 0)
			{
				throw new global::a.v(global::a.V.C, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aal());
			}
			return text;
		}

		internal static string a(string P_0)
		{
			if (A(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aak()).TryGetProperty(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aaJ(), out var value) && value.ValueKind == JsonValueKind.Object)
			{
				return a(value, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aah());
			}
			return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
		}

		internal static string B(string P_0)
		{
			string text = a(A(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aaM()), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aam());
			if (text.Length == 0)
			{
				throw new global::a.v(global::a.V.C, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aaN());
			}
			return text;
		}

		internal static e B(string P_0, string P_1)
		{
			JsonElement jsonElement = A(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aan());
			A(jsonElement, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aan());
			e e2 = new e();
			if (!jsonElement.TryGetProperty(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aaF(), out var value) || value.ValueKind != JsonValueKind.Array)
			{
				return e2;
			}
			e e3 = null;
			e e4 = null;
			foreach (JsonElement item in value.EnumerateArray())
			{
				if (item.ValueKind != JsonValueKind.Object)
				{
					continue;
				}
				string text = a(item, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aag());
				e e5 = new e
				{
					Found = true,
					FileId = a(item, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aah()),
					FileName = text,
					Message = a(item, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAx()),
					Success = (A(item, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aaO(), 0) == 1)
				};
				if (e3 == null)
				{
					e3 = e5;
				}
				if (string.IsNullOrEmpty(P_1) || string.IsNullOrEmpty(text) || string.Equals(text, P_1, StringComparison.OrdinalIgnoreCase))
				{
					if (e5.Success)
					{
						return e5;
					}
					if (e4 == null)
					{
						e4 = e5;
					}
				}
			}
			return e4 ?? e3 ?? e2;
		}

		internal static string A(string P_0, DateTimeOffset P_1, long P_2, string P_3)
		{
			string text = (string.IsNullOrEmpty(P_0) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CN() : P_0);
			string text2 = (string.IsNullOrEmpty(P_3) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CN() : P_3.ToLowerInvariant());
			return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aao() + P_1.Year.ToString(CultureInfo.InvariantCulture) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aA() + P_1.Month.ToString(CultureInfo.InvariantCulture) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aA() + P_1.Day.ToString(CultureInfo.InvariantCulture) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aA() + text + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aA() + P_2.ToString(CultureInfo.InvariantCulture) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aaP() + text2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aap();
		}

		internal static string A(DateTimeOffset P_0)
		{
			return P_0.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CI(), CultureInfo.InvariantCulture);
		}

		internal static string b(string P_0)
		{
			string text = a(A(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aaQ()), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aaq());
			if (text.Length == 0)
			{
				throw new global::a.v(global::a.V.C, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aaR());
			}
			return text;
		}

		internal static string C(string P_0)
		{
			string text = a(A(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aar()), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aaS());
			if (text.Length == 0)
			{
				throw new global::a.v(global::a.V.C, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aas());
			}
			return text;
		}

		internal static string A(long P_0)
		{
			using Aes aes = Aes.Create();
			aes.Key = Encoding.UTF8.GetBytes(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aaT());
			aes.Mode = CipherMode.ECB;
			aes.Padding = PaddingMode.PKCS7;
			using ICryptoTransform cryptoTransform = aes.CreateEncryptor();
			byte[] bytes = Encoding.UTF8.GetBytes(P_0.ToString(CultureInfo.InvariantCulture));
			return Convert.ToHexString(cryptoTransform.TransformFinalBlock(bytes, 0, bytes.Length)).ToLowerInvariant();
		}

		internal static string c(string P_0)
		{
			using MD5 mD = MD5.Create();
			using FileStream inputStream = File.OpenRead(P_0);
			return Convert.ToHexString(mD.ComputeHash(inputStream)).ToLowerInvariant();
		}

		internal static string a(long P_0)
		{
			if (P_0 < 0)
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}
			if (P_0 >= 1073741824)
			{
				return ((double)P_0 / 1024.0 / 1024.0 / 1024.0).ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aat()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bf();
			}
			if (P_0 >= 1048576)
			{
				return ((double)P_0 / 1024.0 / 1024.0).ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aat()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Be();
			}
			if (P_0 >= 1024)
			{
				return ((double)P_0 / 1024.0).ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aat()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BE();
			}
			return P_0 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bd();
		}

		internal static string a(JsonElement P_0, string P_1)
		{
			if (P_0.ValueKind != JsonValueKind.Object || !P_0.TryGetProperty(P_1, out var value))
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}
			if (value.ValueKind == JsonValueKind.String)
			{
				return value.GetString() ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}
			if (value.ValueKind == JsonValueKind.Number)
			{
				return value.GetRawText();
			}
			return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
		}

		internal static int A(JsonElement P_0, string P_1, int P_2)
		{
			long num = A(P_0, P_1, long.MinValue);
			if (num != long.MinValue)
			{
				return (int)num;
			}
			return P_2;
		}

		internal static long A(JsonElement P_0, string P_1, long P_2)
		{
			if (P_0.ValueKind != JsonValueKind.Object || !P_0.TryGetProperty(P_1, out var value))
			{
				return P_2;
			}
			if (value.ValueKind == JsonValueKind.Number)
			{
				if (!value.TryGetInt64(out var value2))
				{
					return P_2;
				}
				return value2;
			}
			if (value.ValueKind == JsonValueKind.String)
			{
				if (!long.TryParse(value.GetString(), NumberStyles.Integer, CultureInfo.InvariantCulture, out var result))
				{
					return P_2;
				}
				return result;
			}
			return P_2;
		}
	}
	internal enum f
	{
		A,
		a,
		B,
		b,
		C,
		c,
		D
	}
}
namespace b
{
	public sealed class F : Form
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class A
		{
			public static readonly A A_f_1 = new A();

			public static Func<KeyValuePair<string, global::A.x>, string> A_f_2;

			internal string A_m_1(KeyValuePair<string, global::A.x> P_0)
			{
				return P_0.Key;
			}
		}

		private readonly Dictionary<string, global::A.x> A_1;

		private readonly global::A.x A_2;

		private readonly Y A_3;

		private readonly ListView A_4;

		private readonly Label A_5;

		[CompilerGenerated]
		private string A_6;

		[CompilerGenerated]
		private bool A_7;

		public string AppliedName
		{
			[CompilerGenerated]
			get
			{
				return A_6;
			}
			[CompilerGenerated]
			private set
			{
				A_6 = value;
			}
		}

		public bool Changed
		{
			[CompilerGenerated]
			get
			{
				return A_7;
			}
			[CompilerGenerated]
			private set
			{
				A_7 = value;
			}
		}

		public F(Dictionary<string, global::A.x> P_0, global::A.x P_1, Y P_2)
		{
			A_1 = P_0 ?? new Dictionary<string, global::A.x>();
			A_2 = P_1;
			A_3 = P_2;
			Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.RQ();
			StartPosition = FormStartPosition.CenterParent;
			Icon = global::A.R.App;
			Font = global::B.Q.A_m_1(10f);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(940, 520);
			MinimumSize = new Size(760, 420);
			BackColor = P_2.A;
			ForeColor = P_2.b;
			TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
			{
				Dock = DockStyle.Fill,
				ColumnCount = 1,
				RowCount = 4,
				Padding = new Padding(12),
				Margin = new Padding(0)
			};
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			Label control = new Label
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.RS(),
				AutoSize = true,
				MaximumSize = new Size(700, 0),
				Margin = new Padding(2, 2, 2, 10),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BH()
			};
			tableLayoutPanel.Controls.Add(control, 0, 0);
			A_4 = new ListView
			{
				Dock = DockStyle.Fill,
				View = View.Details,
				FullRowSelect = true,
				GridLines = false,
				MultiSelect = false,
				HideSelection = false,
				BorderStyle = BorderStyle.FixedSingle,
				Font = global::B.Q.A_m_1(10f),
				BackColor = P_2.c,
				ForeColor = P_2.D
			};
			A_4.Columns.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ais(), 190);
			A_4.Columns.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.MZ(), 240);
			A_4.Columns.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.mA(), 240);
			A_4.Columns.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aiT(), 120);
			A_4.Columns.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ait(), 150);
			A_4.DoubleClick += delegate
			{
				B();
			};
			A_4.SelectedIndexChanged += delegate
			{
				a();
			};
			tableLayoutPanel.Controls.Add(A_4, 0, 1);
			TableLayoutPanel tableLayoutPanel2 = new TableLayoutPanel
			{
				Dock = DockStyle.Fill,
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				ColumnCount = 5,
				RowCount = 1,
				Margin = new Padding(0, 10, 0, 0),
				Padding = new Padding(0)
			};
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			Button button = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.OT(), 130);
			button.Click += delegate
			{
				B();
			};
			tableLayoutPanel2.Controls.Add(button, 0, 0);
			Button button2 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.OS(), 150);
			button2.Click += delegate
			{
				b();
			};
			tableLayoutPanel2.Controls.Add(button2, 1, 0);
			Button button3 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.OR(), 100);
			button3.Click += delegate
			{
				C();
			};
			tableLayoutPanel2.Controls.Add(button3, 2, 0);
			Button button4 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ot(), 90);
			button4.Click += delegate
			{
				c();
			};
			tableLayoutPanel2.Controls.Add(button4, 3, 0);
			tableLayoutPanel.Controls.Add(tableLayoutPanel2, 0, 2);
			TableLayoutPanel tableLayoutPanel3 = new TableLayoutPanel
			{
				Dock = DockStyle.Fill,
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				ColumnCount = 2,
				RowCount = 1,
				Margin = new Padding(0, 10, 0, 0),
				Padding = new Padding(0)
			};
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			A_5 = new Label
			{
				AutoSize = true,
				Anchor = AnchorStyles.Left,
				Margin = new Padding(2, 8, 8, 0),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BH()
			};
			tableLayoutPanel3.Controls.Add(A_5, 0, 0);
			Button button5 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bl(), 100);
			button5.Click += delegate
			{
				Close();
			};
			tableLayoutPanel3.Controls.Add(button5, 1, 0);
			tableLayoutPanel.Controls.Add(tableLayoutPanel3, 0, 3);
			Controls.Add(tableLayoutPanel);
			Z.A_m_1(this, P_2, button);
			global::a.Q.A_m_1(this);
			A_4.BackColor = P_2.c;
			A_4.ForeColor = P_2.D;
			A_m_1((string)null);
		}

		private Button A_m_1(string P_0, int P_1)
		{
			return new Button
			{
				Text = P_0,
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				MinimumSize = new Size(P_1, 34),
				Padding = new Padding(10, 2, 10, 2),
				Margin = new Padding(0, 0, 8, 0),
				Font = global::B.Q.A_m_1(10f)
			};
		}

		private void A_m_1(string P_0 = null)
		{
			A_4.BeginUpdate();
			A_4.Items.Clear();
			foreach (KeyValuePair<string, global::A.x> item in A_1.OrderBy((KeyValuePair<string, global::A.x> keyValuePair) => keyValuePair.Key, StringComparer.OrdinalIgnoreCase))
			{
				ListViewItem listViewItem = new ListViewItem(item.Key);
				listViewItem.SubItems.Add(string.IsNullOrWhiteSpace(item.Value.Source) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bE() : item.Value.Source);
				listViewItem.SubItems.Add(string.IsNullOrWhiteSpace(item.Value.Target) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bE() : item.Value.Target);
				listViewItem.SubItems.Add(A_m_1(item.Value));
				listViewItem.SubItems.Add(string.IsNullOrWhiteSpace(item.Value.SavedAt) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bE() : item.Value.SavedAt);
				listViewItem.Tag = item.Key;
				A_4.Items.Add(listViewItem);
				if (P_0 != null && string.Equals(P_0, item.Key, StringComparison.OrdinalIgnoreCase))
				{
					listViewItem.Selected = true;
				}
			}
			A_4.EndUpdate();
			if (A_4.SelectedItems.Count == 0 && A_4.Items.Count > 0)
			{
				A_4.Items[0].Selected = true;
			}
			a();
		}

		private static string A_m_1(global::A.x P_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (P_0.Step1)
			{
				stringBuilder.Append('①');
			}
			if (P_0.Step2)
			{
				stringBuilder.Append('②');
			}
			if (P_0.Step3)
			{
				stringBuilder.Append('③');
			}
			if (P_0.Step4)
			{
				stringBuilder.Append('④');
			}
			if (P_0.Step5)
			{
				stringBuilder.Append('⑤');
			}
			if (stringBuilder.Length == 0)
			{
				stringBuilder.Append('—');
			}
			if (P_0.HashDedup)
			{
				stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aiU());
			}
			if (P_0.ImageDedup)
			{
				stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aiu());
			}
			if (P_0.AudioDedup)
			{
				stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aiV());
			}
			if (P_0.Hardlink)
			{
				stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aiv());
			}
			return stringBuilder.ToString();
		}

		private string A_m_1()
		{
			if (A_4.SelectedItems.Count <= 0)
			{
				return null;
			}
			return A_4.SelectedItems[0].Tag as string;
		}

		private void a()
		{
			if (A_5 != null)
			{
				string text = A_m_1();
				A_5.Text = ((text == null) ? (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aiW() + A_1.Count + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aiX()) : (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aiW() + A_1.Count + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aiw() + text));
			}
		}

		private void B()
		{
			string text = A_m_1();
			if (text == null)
			{
				MessageBox.Show(this, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aix(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bB(), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			AppliedName = text;
			DialogResult = DialogResult.OK;
		}

		private void b()
		{
			string text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adf() + (A_1.Count + 1);
			string text2 = f.A_m_1(this, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aiY(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aiy(), text, A_3, A_1.Keys);
			if (text2 != null && (!A_1.ContainsKey(text2) || MessageBox.Show(this, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.adD() + text2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aiZ(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aiz(), MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK))
			{
				global::A.x x2 = A_2.A_m_1();
				x2.SavedAt = DateTime.Now.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.q());
				A_1[text2] = x2;
				Changed = true;
				A_m_1(text2);
			}
		}

		private void C()
		{
			string text = A_m_1();
			if (text == null)
			{
				MessageBox.Show(this, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJA(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bB(), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			string text2 = f.A_m_1(this, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJa(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJB(), text, A_3, null);
			if (text2 != null && !(text2 == text))
			{
				if (A_1.ContainsKey(text2))
				{
					MessageBox.Show(this, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJb(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bB(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				global::A.x value = A_1[text];
				A_1.Remove(text);
				A_1[text2] = value;
				Changed = true;
				A_m_1(text2);
			}
		}

		private void c()
		{
			string text = A_m_1();
			if (text == null)
			{
				MessageBox.Show(this, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJC(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bB(), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else if (MessageBox.Show(this, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJc() + text + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJD(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kB(), MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				A_1.Remove(text);
				Changed = true;
				A_m_1((string)null);
				if (A_1.Count == 0)
				{
					Close();
				}
			}
		}

		[CompilerGenerated]
		private void A_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			B();
		}

		[CompilerGenerated]
		private void a(object? _003Cp0_003E, EventArgs P_1)
		{
			a();
		}

		[CompilerGenerated]
		private void B(object? _003Cp0_003E, EventArgs P_1)
		{
			B();
		}

		[CompilerGenerated]
		private void b(object? _003Cp0_003E, EventArgs P_1)
		{
			b();
		}

		[CompilerGenerated]
		private void C(object? _003Cp0_003E, EventArgs P_1)
		{
			C();
		}

		[CompilerGenerated]
		private void c(object? _003Cp0_003E, EventArgs P_1)
		{
			c();
		}

		[CompilerGenerated]
		private void D(object? _003Cp0_003E, EventArgs P_1)
		{
			Close();
		}
	}
	public static class f
	{
		[CompilerGenerated]
		private sealed class A
		{
			public Form A_f_1;

			public TextBox A_f_2;

			public string A_f_3;

			internal void A_m_1(object? _003Cp0_003E, EventArgs P_1)
			{
				string text = (A_f_2.Text ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).Trim();
				if (text.Length == 0)
				{
					MessageBox.Show(A_f_1, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anh(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bB(), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					A_f_2.Focus();
					return;
				}
				if (text.Length > 40)
				{
					text = text.Substring(0, 40);
				}
				char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
				foreach (char oldChar in invalidFileNameChars)
				{
					text = text.Replace(oldChar, '_');
				}
				A_f_3 = text.Trim();
				A_f_1.DialogResult = DialogResult.OK;
			}
		}

		public static string A_m_1(IWin32Window P_0, string P_1, string P_2, string P_3, Y P_4, IEnumerable<string> P_5)
		{
			Form A_f_1 = new Form();
			try
			{
				A_f_1.Text = P_1;
				A_f_1.StartPosition = FormStartPosition.CenterParent;
				A_f_1.FormBorderStyle = FormBorderStyle.FixedDialog;
				A_f_1.MinimizeBox = false;
				A_f_1.MaximizeBox = false;
				A_f_1.ShowInTaskbar = false;
				A_f_1.Font = global::B.Q.A_m_1(10f);
				A_f_1.AutoScaleMode = AutoScaleMode.Font;
				A_f_1.ClientSize = new Size(460, 170);
				A_f_1.BackColor = P_4.A;
				A_f_1.ForeColor = P_4.b;
				TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
				{
					Dock = DockStyle.Fill,
					ColumnCount = 1,
					RowCount = 4,
					Padding = new Padding(16),
					Margin = new Padding(0)
				};
				tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
				Label control = new Label
				{
					Text = P_2,
					AutoSize = true,
					Margin = new Padding(2, 0, 2, 8)
				};
				tableLayoutPanel.Controls.Add(control, 0, 0);
				TextBox A_f_2 = new TextBox
				{
					Text = (P_3 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()),
					Dock = DockStyle.Fill,
					BorderStyle = BorderStyle.FixedSingle,
					Font = global::B.Q.A_m_1(10f),
					Margin = new Padding(2, 0, 2, 6)
				};
				A_f_2.SelectAll();
				tableLayoutPanel.Controls.Add(A_f_2, 0, 1);
				Label control2 = new Label
				{
					Text = ((P_5 == null || !P_5.Any()) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJE() : (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJd() + string.Join(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aw(), P_5.Take(6)) + ((P_5.Count() > 6) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aga() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()))),
					AutoSize = true,
					MaximumSize = new Size(420, 0),
					Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BH(),
					Margin = new Padding(2, 0, 2, 10)
				};
				tableLayoutPanel.Controls.Add(control2, 0, 2);
				FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel
				{
					FlowDirection = FlowDirection.RightToLeft,
					Dock = DockStyle.Fill,
					AutoSize = true,
					Margin = new Padding(0)
				};
				Button button = new Button
				{
					Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.os(),
					AutoSize = true,
					MinimumSize = new Size(96, 34),
					Padding = new Padding(8, 2, 8, 2),
					Font = global::B.Q.A_m_1(10f)
				};
				Button button2 = new Button
				{
					Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BX(),
					AutoSize = true,
					MinimumSize = new Size(96, 34),
					Padding = new Padding(8, 2, 8, 2),
					Font = global::B.Q.A_m_1(10f)
				};
				string A_f_3 = null;
				button.Click += delegate
				{
					string text = (A_f_2.Text ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).Trim();
					if (text.Length == 0)
					{
						MessageBox.Show(A_f_1, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anh(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bB(), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						A_f_2.Focus();
					}
					else
					{
						if (text.Length > 40)
						{
							text = text.Substring(0, 40);
						}
						char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
						foreach (char oldChar in invalidFileNameChars)
						{
							text = text.Replace(oldChar, '_');
						}
						A_f_3 = text.Trim();
						A_f_1.DialogResult = DialogResult.OK;
					}
				};
				button2.DialogResult = DialogResult.Cancel;
				flowLayoutPanel.Controls.Add(button);
				flowLayoutPanel.Controls.Add(button2);
				tableLayoutPanel.Controls.Add(flowLayoutPanel, 0, 3);
				A_f_1.Controls.Add(tableLayoutPanel);
				A_f_1.AcceptButton = button;
				A_f_1.CancelButton = button2;
				Z.A_m_1(A_f_1, P_4, button);
				return (A_f_1.ShowDialog(P_0) == DialogResult.OK) ? A_f_3 : null;
			}
			finally
			{
				if (A_f_1 != null)
				{
					((IDisposable)A_f_1).Dispose();
				}
			}
		}
	}
}
