using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using _003CPrivateImplementationDetails_003E_007B1262ED64_002DD0A6_002D499E_002D9510_002DF2240F018DBB_007D;
using a;

namespace A
{
	public static class Y
	{
		[CompilerGenerated]
		private static Action<bool> A;

		private static readonly JsonSerializerOptions A_1 = new JsonSerializerOptions
		{
			WriteIndented = true,
			Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
		};

		// 24：只读路径的失败只记一条，避免扫描时逐文件刷屏；写路径逐条记录。
		private static int A_2;

		private static int A_3;

		public static string Dir
		{
			get
			{
				string environmentVariable = Environment.GetEnvironmentVariable(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JA());
				string text = (string.IsNullOrWhiteSpace(environmentVariable) ? Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.DA()) : environmentVariable);
				try
				{
					Directory.CreateDirectory(text);
				}
				catch (Exception ex)
				{
					if (Interlocked.Exchange(ref A_2, 1) == 0)
					{
						global::B.p.a_m_1("创建配置目录失败：" + text + "；" + ex.GetType().Name + "：" + ex.Message);
					}
				}
				return text;
			}
		}

		public static string FilePath => Path.Combine(Dir, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ja());

		public static event Action<bool> AutoOpenFolderChanged
		{
			[CompilerGenerated]
			add
			{
				Action<bool> action = A;
				Action<bool> action2;
				do
				{
					action2 = action;
					Action<bool> value2 = (Action<bool>)Delegate.Combine(action2, value);
					action = Interlocked.CompareExchange(ref A, value2, action2);
				}
				while ((object)action != action2);
			}
			[CompilerGenerated]
			remove
			{
				Action<bool> action = A;
				Action<bool> action2;
				do
				{
					action2 = action;
					Action<bool> value2 = (Action<bool>)Delegate.Remove(action2, value);
					action = Interlocked.CompareExchange(ref A, value2, action2);
				}
				while ((object)action != action2);
			}
		}

		public static void A_m_1(x P_0, bool P_1)
		{
			if (P_0 != null)
			{
				P_0.OrganizeAutoOpenFolder = P_1;
				A_m_1(P_0);
			}
			A?.Invoke(P_1);
		}

		public static x A_m_1()
		{
			if (global::a.j.DevSwitch(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JB()))
			{
				return new x();
			}
			try
			{
				if (File.Exists(FilePath))
				{
					x x2 = JsonSerializer.Deserialize<x>(File.ReadAllText(FilePath));
					if (x2 != null)
					{
						return x2;
					}
				}
			}
			catch (Exception ex)
			{
				if (Interlocked.Exchange(ref A_3, 1) == 0)
				{
					global::B.p.a_m_1("读取配置失败，已使用默认配置：" + ex.GetType().Name + "：" + ex.Message);
				}
			}
			return new x();
		}

		public static void A_m_1(x P_0)
		{
			if (global::a.j.DevSwitch(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JB()))
			{
				return;
			}
			List<x> list = new List<x>();
			if (P_0.Profiles != null)
			{
				if (P_0.Profiles.Count == 0)
				{
					P_0.Profiles = null;
					list.Add(P_0);
				}
				else
				{
					foreach (KeyValuePair<string, x> profile in P_0.Profiles)
					{
						if (profile.Value != null && profile.Value.Profiles != null && profile.Value.Profiles.Count == 0)
						{
							profile.Value.Profiles = null;
							list.Add(profile.Value);
						}
					}
				}
			}
			try
			{
				File.WriteAllText(FilePath, JsonSerializer.Serialize(P_0, A_1));
			}
			catch (Exception ex)
			{
				global::B.p.a_m_1("保存配置失败：" + FilePath + "；" + ex.GetType().Name + "：" + ex.Message);
			}
			finally
			{
				foreach (x item in list)
				{
					item.Profiles = new Dictionary<string, x>();
				}
			}
		}
	}
	public static class y
	{
		// 24：逐文件只读探测失败只记一条，避免大目录扫描时刷屏。
		private static int A_1;

		private static int a;
		[CompilerGenerated]
		private sealed class A
		{
			public bool A_f_1;

			public Action<string> A_f_2;

			public string[] A_f_3;

			public long A_f_4;

			internal bool A_m_1(string P_0)
			{
				if (A_f_1 && y.A_m_1(P_0))
				{
					A_f_2?.Invoke(P_0 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMQ());
					return false;
				}
				if (y.A_m_1(P_0, A_f_3))
				{
					A_f_2?.Invoke(P_0 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMq());
					return false;
				}
				if (!y.A_m_1(P_0, A_f_4))
				{
					A_f_2?.Invoke(P_0 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMR());
					return false;
				}
				return true;
			}
		}

		public static bool A_m_1(string P_0)
		{
			try
			{
				return (File.GetAttributes(global::a.a.A(P_0)) & (FileAttributes.Hidden | FileAttributes.System)) != 0;
			}
			catch (Exception ex)
			{
				if (Interlocked.Exchange(ref A_1, 1) == 0)
				{
					global::B.p.a_m_1("读取文件属性失败（按隐藏文件处理）：" + P_0 + "；" + ex.GetType().Name + "：" + ex.Message);
				}
				return true;
			}
		}

		public static bool A_m_1(string P_0, string[] P_1)
		{
			if (P_1 == null || P_1.Length == 0)
			{
				return false;
			}
			string text = P_0.Replace('/', '\\');
			for (int num = 0; num < P_1.Length; num++)
			{
				string text2 = (P_1[num] ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).Trim().TrimEnd('\\');
				if (text2.Length == 0)
				{
					continue;
				}
				if (text2.IndexOf('\\') >= 0 || text2.IndexOf(':') >= 0)
				{
					if (text.StartsWith(text2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jb(), StringComparison.OrdinalIgnoreCase) || string.Equals(text, text2, StringComparison.OrdinalIgnoreCase))
					{
						return true;
					}
					continue;
				}
				string[] array = (Path.GetDirectoryName(text) ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).Split('\\');
				for (int num2 = 0; num2 < array.Length; num2++)
				{
					if (string.Equals(array[num2], text2, StringComparison.OrdinalIgnoreCase))
					{
						return true;
					}
				}
			}
			return false;
		}

		public static bool A_m_1(string P_0, long P_1)
		{
			if (P_1 <= 0)
			{
				return true;
			}
			try
			{
				return new FileInfo(global::a.a.A(P_0)).Length >= P_1;
			}
			catch (Exception ex)
			{
				if (Interlocked.Exchange(ref a, 1) == 0)
				{
					global::B.p.a_m_1("读取文件大小失败（按不满足处理）：" + P_0 + "；" + ex.GetType().Name + "：" + ex.Message);
				}
				return false;
			}
		}

		public static List<string> A_m_1(List<string> P_0, string[] P_1, long P_2, bool P_3, Action<string> P_4)
		{
			return P_0.Where((string text) =>
			{
				if (P_3 && A_m_1(text))
				{
					P_4?.Invoke(text + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMQ());
					return false;
				}
				if (A_m_1(text, P_1))
				{
					P_4?.Invoke(text + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMq());
					return false;
				}
				if (!A_m_1(text, P_2))
				{
					P_4?.Invoke(text + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMR());
					return false;
				}
				return true;
			}).ToList();
		}
	}
}
namespace a
{
	internal sealed class Y : Stream
	{
		private readonly Stream A_1;

		private readonly long A_2;

		private readonly Action<long, long> A_3;

		private long a;

		public override bool CanRead => true;

		public override bool CanSeek => false;

		public override bool CanWrite => false;

		public override long Length => A_2;

		public override long Position
		{
			get
			{
				return a;
			}
			set
			{
				throw new NotSupportedException();
			}
		}

		internal Y(Stream P_0, long P_1, Action<long, long> P_2)
		{
			A_1 = P_0;
			A_2 = P_1;
			A_3 = P_2;
		}

		public override int Read(byte[] P_0, int P_1, int P_2)
		{
			int num = A_1.Read(P_0, P_1, P_2);
			if (num > 0)
			{
				a += num;
				if (A_3 != null)
				{
					A_3(a, A_2);
				}
			}
			return num;
		}

		public override async Task<int> ReadAsync(byte[] P_0, int P_1, int P_2, CancellationToken P_3)
		{
			int num = await A_1.ReadAsync(P_0, P_1, P_2, P_3).ConfigureAwait(continueOnCapturedContext: false);
			if (num > 0)
			{
				a += num;
				if (A_3 != null)
				{
					A_3(a, A_2);
				}
			}
			return num;
		}

		public override void Flush()
		{
		}

		public override long Seek(long P_0, SeekOrigin P_1)
		{
			throw new NotSupportedException();
		}

		public override void SetLength(long P_0)
		{
			throw new NotSupportedException();
		}

		public override void Write(byte[] P_0, int P_1, int P_2)
		{
			throw new NotSupportedException();
		}

		protected override void Dispose(bool P_0)
		{
			if (P_0)
			{
				A_1.Dispose();
			}
			base.Dispose(P_0);
		}
	}
	internal static class y
	{
		private static JsonElement A(string P_0, string P_1)
		{
			string text = (P_0 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).Trim();
			if (text.Length == 0)
			{
				throw new v(V.B, P_1 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zr());
			}
			if (text[0] == '<' || text.IndexOf(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zS(), StringComparison.OrdinalIgnoreCase) >= 0 || text.IndexOf(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zs(), StringComparison.OrdinalIgnoreCase) >= 0)
			{
				throw new v(V.a, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zT());
			}
			try
			{
				// C-21：JsonDocument 使用池化缓冲，必须释放；RootElement 先 Clone 再返回，保证释放后仍可用。
				using JsonDocument jsonDocument = JsonDocument.Parse(text);
				return jsonDocument.RootElement.Clone();
			}
			catch (JsonException)
			{
				throw new v(V.C, P_1 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zt() + A(text) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ln());
			}
		}

		private static void A(JsonElement P_0)
		{
			if (P_0.ValueKind == JsonValueKind.Object && P_0.TryGetProperty(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zU(), out var value) && value.ValueKind == JsonValueKind.Number)
			{
				int num = 0;
				try
				{
					num = value.GetInt32();
				}
				catch
				{
				}
				if (num == 9)
				{
					throw new v(V.a, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zT());
				}
			}
		}

		internal static string A(string P_0)
		{
			P_0 = (P_0 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).Replace(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bc(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aH()).Replace(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BD(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aH());
			if (P_0.Length > 80)
			{
				return P_0.Substring(0, 80) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.j();
			}
			return P_0;
		}

		internal static List<W> a(string P_0)
		{
			JsonElement jsonElement = A(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zu());
			A(jsonElement);
			List<W> list = new List<W>();
			if (!jsonElement.TryGetProperty(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aK(), out var value) || value.ValueKind != JsonValueKind.Array)
			{
				return list;
			}
			foreach (JsonElement item in value.EnumerateArray())
			{
				string text = A(item, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zV());
				string name = A(item, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zP());
				if (!string.IsNullOrEmpty(text))
				{
					list.Add(new W
					{
						Id = text,
						Name = name
					});
				}
			}
			return list;
		}

		internal static string B(string P_0)
		{
			JsonElement jsonElement = A(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jg());
			A(jsonElement);
			int num = 0;
			if (jsonElement.TryGetProperty(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zU(), out var value) && value.ValueKind == JsonValueKind.Number)
			{
				try
				{
					num = value.GetInt32();
				}
				catch
				{
				}
			}
			if (num != 1)
			{
				string text = A(jsonElement, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zv());
				if (text.Length == 0)
				{
					text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zW();
				}
				throw new v(V.b, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Xl() + text);
			}
			string text2 = A(jsonElement, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zV());
			if (text2.Length == 0 && jsonElement.TryGetProperty(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aK(), out var value2) && value2.ValueKind == JsonValueKind.Array && value2.GetArrayLength() > 0)
			{
				text2 = A(value2[0], _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zV());
			}
			return text2;
		}

		internal static void b(string P_0)
		{
			JsonElement jsonElement = A(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ot());
			A(jsonElement);
			int num = 0;
			if (jsonElement.TryGetProperty(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zU(), out var value) && value.ValueKind == JsonValueKind.Number)
			{
				try
				{
					num = value.GetInt32();
				}
				catch
				{
				}
			}
			string text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			if (jsonElement.TryGetProperty(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zv(), out var value2))
			{
				if (value2.ValueKind == JsonValueKind.String)
				{
					text = value2.GetString() ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
				}
				else if (value2.ValueKind == JsonValueKind.Array && value2.GetArrayLength() > 0 && value2[0].ValueKind == JsonValueKind.String)
				{
					text = value2[0].GetString() ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
				}
			}
			if (num == 1 || text.IndexOf(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.hy(), StringComparison.Ordinal) >= 0 || text.IndexOf(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zw(), StringComparison.Ordinal) >= 0 || text.IndexOf(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zX(), StringComparison.Ordinal) >= 0)
			{
				return;
			}
			throw new v(V.b, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Zo() + ((text.Length > 0) ? text : (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zx() + num)));
		}

		internal static List<w> C(string P_0)
		{
			JsonElement jsonElement = A(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zY());
			A(jsonElement);
			List<w> list = new List<w>();
			if (!jsonElement.TryGetProperty(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aK(), out var value) || value.ValueKind != JsonValueKind.Array)
			{
				return list;
			}
			foreach (JsonElement item in value.EnumerateArray())
			{
				string text = A(item, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ce());
				string text2 = WebUtility.HtmlDecode(A(item, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zy()));
				if (string.IsNullOrEmpty(text2))
				{
					text2 = WebUtility.HtmlDecode(A(item, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zP()));
				}
				string text3 = A(item, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zZ()).Replace(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Kn(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
				if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(text2))
				{
					list.Add(new w
					{
						Id = text,
						Name = text2,
						SizeText = text3,
						SizeBytes = Z.A_m_1(text3),
						Time = A(item, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zz())
					});
				}
			}
			return list;
		}

		internal static X c(string P_0)
		{
			JsonElement jsonElement = A(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAA());
			A(jsonElement);
			int num = 0;
			if (jsonElement.TryGetProperty(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zU(), out var value) && value.ValueKind == JsonValueKind.Number)
			{
				try
				{
					num = value.GetInt32();
				}
				catch
				{
				}
			}
			if (num != 1 && num != 2)
			{
				string text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
				if (jsonElement.TryGetProperty(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zv(), out var value2))
				{
					if (value2.ValueKind == JsonValueKind.String)
					{
						text = value2.GetString();
					}
					else if (value2.ValueKind == JsonValueKind.Array && value2.GetArrayLength() > 0)
					{
						text = ((value2[0].ValueKind == JsonValueKind.String) ? value2[0].GetString() : value2[0].GetRawText());
					}
				}
				throw new v(V.b, (text.Length > 0) ? text : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.wy());
			}
			string text2 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			if (jsonElement.TryGetProperty(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aK(), out var value3) && value3.ValueKind == JsonValueKind.Array && value3.GetArrayLength() > 0)
			{
				JsonElement jsonElement2 = value3[0];
				text2 = A(jsonElement2, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ce());
				if (text2.Length == 0)
				{
					text2 = A(jsonElement2, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAa());
				}
			}
			return new X
			{
				Success = true,
				FileId = text2
			};
		}

		private static string A(JsonElement P_0, string P_1)
		{
			if (!P_0.TryGetProperty(P_1, out var value))
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
	}
}
