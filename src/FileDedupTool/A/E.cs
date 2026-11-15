using System;
using System.Buffers;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007B1262ED64_002DD0A6_002D499E_002D9510_002DF2240F018DBB_007D;
using B;
using a;
using b;

namespace A
{
	public static class E
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class A
		{
			public static readonly A A_f_1 = new A();

			public static Func<KeyValuePair<int, global::b.q>, long> A_f_2;

			public static Func<KeyValuePair<int, global::b.q>, int> A_f_3;

			public static Func<int, int> A_f_4;

			public static Func<int, string> A_f_5;

			public static Func<int, int> a;

			internal long A_m_1(KeyValuePair<int, global::b.q> P_0)
			{
				return P_0.Value.WastedBytes;
			}

			internal int a_m_1(KeyValuePair<int, global::b.q> P_0)
			{
				return P_0.Key;
			}

			internal int A_m_1(int P_0)
			{
				return P_0;
			}

			internal string a_m_1(int P_0)
			{
				return P_0.ToString();
			}

			internal int B(int P_0)
			{
				return P_0;
			}
		}

		[CompilerGenerated]
		private sealed class a
		{
			public Dictionary<int, c> A;

			internal bool A_m_1(int P_0)
			{
				return !A.ContainsKey(P_0);
			}

			internal c a_m_1(int P_0)
			{
				return A[P_0];
			}
		}

		[CompilerGenerated]
		private sealed class B
		{
			public string A;

			internal bool A_m_1(global::b.Q P_0)
			{
				return string.Equals(P_0.A, A, StringComparison.OrdinalIgnoreCase);
			}
		}

		[CompilerGenerated]
		private sealed class b
		{
			public string A;

			internal bool A_m_1(global::b.Q P_0)
			{
				return string.Equals(P_0.A, A, StringComparison.OrdinalIgnoreCase);
			}
		}

		internal static readonly HttpClient A_1 = new HttpClient();

		public static bool A_m_1(x P_0)
		{
			if (P_0 != null && P_0.AiEnabled && !string.IsNullOrWhiteSpace(P_0.AiBaseUrl))
			{
				return !string.IsNullOrWhiteSpace(P_0.AiModel);
			}
			return false;
		}

		public static string A_m_1(string P_0)
		{
			string text = (P_0 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).Trim().TrimEnd('/');
			if (text.Length == 0)
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}
			if (text.EndsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.H(), StringComparison.OrdinalIgnoreCase))
			{
				return text;
			}
			return text + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.H();
		}

		public static bool A_m_1(x P_0, out string P_1)
		{
			P_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			if (!A_m_1(P_0))
			{
				P_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.h();
				return false;
			}
			string text = A_m_1(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.I(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.i(), out var text2, CancellationToken.None);
			if (text == null)
			{
				P_1 = text2;
				return false;
			}
			P_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.J() + ((text.Length > 60) ? (text.Substring(0, 60) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.j()) : text);
			return true;
		}

		public static string A_m_1()
		{
			return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.K();
		}

		public static string A_m_1(global::b.R P_0, int P_1)
		{
			if (P_1 <= 0)
			{
				P_1 = 30;
			}
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.k());
			stringBuilder.AppendLine(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.L());
			stringBuilder.AppendLine(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.l());
			stringBuilder.AppendLine(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.M());
			stringBuilder.AppendLine();
			foreach (KeyValuePair<int, global::b.q> item in a_m_1(P_0, P_1))
			{
				global::b.q value = item.Value;
				stringBuilder.AppendLine(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.m() + (item.Key + 1) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.N() + value.a + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.n() + A_m_1(value.WastedBytes) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.O() + value.A_2.Count);
				int num = 0;
				foreach (global::b.Q item2 in value.A_2)
				{
					num++;
					stringBuilder.AppendLine(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.o() + num + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.P() + item2.A + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.p() + A_m_1(item2.A_1) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Q() + item2.A_2.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.q()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.R());
					string text = A_m_1(item2);
					if (text.Length > 0)
					{
						stringBuilder.AppendLine(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.r() + text);
					}
				}
			}
			stringBuilder.AppendLine();
			stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.S());
			return stringBuilder.ToString();
		}

		public static List<KeyValuePair<int, global::b.q>> a_m_1(global::b.R P_0, int P_1)
		{
			List<KeyValuePair<int, global::b.q>> list = new List<KeyValuePair<int, global::b.q>>();
			if (P_0 == null)
			{
				return list;
			}
			if (P_1 <= 0)
			{
				P_1 = 30;
			}
			for (int num = 0; num < P_0.A_1.Count; num++)
			{
				list.Add(new KeyValuePair<int, global::b.q>(num, P_0.A_1[num]));
			}
			return (from keyValuePair in list.OrderByDescending((KeyValuePair<int, global::b.q> keyValuePair) => keyValuePair.Value.WastedBytes).Take(P_1)
				orderby keyValuePair.Key
				select keyValuePair).ToList();
		}

		private static string A_m_1(global::b.Q P_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			try
			{
				string extension = Path.GetExtension(P_0.A ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
				if (!string.IsNullOrEmpty(extension))
				{
					stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.s() + extension + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.T());
				}
				string text = a_m_1(P_0.A);
				if (!string.IsNullOrEmpty(text))
				{
					stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.t() + text + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.T());
				}
				stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.U() + b_m_1(P_0.A) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.T());
				string text2 = B_m_1(P_0.A);
				if (!string.IsNullOrEmpty(text2))
				{
					stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.u() + text2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.T());
				}
				if (global::a.q.A_m_1(P_0.A, out var num, out var num2))
				{
					stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.V() + num + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.v() + num2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.T());
				}
				if (S.A_m_1(P_0.A))
				{
					double? num3 = S.a(P_0.A);
					if (num3.HasValue)
					{
						stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.W() + num3.Value.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.w(), CultureInfo.InvariantCulture) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.X());
					}
				}
			}
			catch
			{
			}
			string text3 = stringBuilder.ToString().TrimEnd();
			if (text3.EndsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.x()))
			{
				text3 = text3.Substring(0, text3.Length - 1).TrimEnd();
			}
			return text3;
		}

		private static string a_m_1(string P_0)
		{
			try
			{
				if (string.IsNullOrEmpty(P_0))
				{
					return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
				}
				return Path.GetDirectoryName(P_0) ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}
			catch
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}
		}

		private static string B_m_1(string P_0)
		{
			try
			{
				if (string.IsNullOrEmpty(P_0))
				{
					return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
				}
				FileAttributes attributes = File.GetAttributes(global::a.a.A(P_0));
				List<string> list = new List<string>();
				if ((attributes & FileAttributes.ReadOnly) != 0)
				{
					list.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Y());
				}
				if ((attributes & FileAttributes.Hidden) != 0)
				{
					list.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.y());
				}
				if ((attributes & FileAttributes.System) != 0)
				{
					list.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Z());
				}
				if ((attributes & FileAttributes.Archive) != 0)
				{
					list.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.z());
				}
				return (list.Count == 0) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D() : string.Join(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aA(), list.ToArray());
			}
			catch
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}
		}

		private static int b_m_1(string P_0)
		{
			if (string.IsNullOrEmpty(P_0))
			{
				return 0;
			}
			int num = 0;
			foreach (char c2 in P_0)
			{
				if (c2 == '\\' || c2 == '/')
				{
					num++;
				}
			}
			if (num <= 0)
			{
				return 0;
			}
			return num - 1;
		}

		public static string A_m_1(x P_0, string P_1, string P_2, out string P_3, CancellationToken P_4)
		{
			P_3 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			string text = A_m_1((P_0 == null) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D() : P_0.AiBaseUrl);
			if (text.Length == 0)
			{
				P_3 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aa();
				return null;
			}
			try
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aB(), P_0.AiModel);
				dictionary.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ab(), 0.2);
				dictionary.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aC(), false);
				dictionary.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ac(), new object[2]
				{
					new Dictionary<string, string>
					{
						{
							_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aD(),
							_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ad()
						},
						{
							_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aE(),
							P_1
						}
					},
					new Dictionary<string, string>
					{
						{
							_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aD(),
							_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ae()
						},
						{
							_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aE(),
							P_2
						}
					}
				});
				string content = JsonSerializer.Serialize(dictionary);
				using HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, text);
				httpRequestMessage.Content = new StringContent(content, Encoding.UTF8, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aF());
				if (!string.IsNullOrWhiteSpace(P_0.AiApiKey))
				{
					httpRequestMessage.Headers.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.af(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aG() + P_0.AiApiKey.Trim());
				}
				int num = ((P_0.AiTimeoutSec <= 0) ? 30 : P_0.AiTimeoutSec);
				using CancellationTokenSource cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(P_4);
				cancellationTokenSource.CancelAfter(TimeSpan.FromSeconds(num));
				using HttpResponseMessage httpResponseMessage = A_1.SendAsync(httpRequestMessage, cancellationTokenSource.Token).GetAwaiter().GetResult();
				string result = httpResponseMessage.Content.ReadAsStringAsync().GetAwaiter().GetResult();
				if (!httpResponseMessage.IsSuccessStatusCode)
				{
					P_3 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ag() + (int)httpResponseMessage.StatusCode + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aH() + httpResponseMessage.ReasonPhrase + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ah() + A_m_1(result, 200);
					return null;
				}
				return A_m_1(result, out P_3);
			}
			catch (OperationCanceledException)
			{
				P_3 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aI();
				return null;
			}
			catch (Exception ex2)
			{
				P_3 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ai() + ex2.Message;
				return null;
			}
		}

		private static string A_m_1(string P_0, out string P_1)
		{
			P_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			try
			{
				using JsonDocument jsonDocument = JsonDocument.Parse(P_0);
				if (jsonDocument.RootElement.TryGetProperty(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJ(), out var value) && value.GetArrayLength() > 0)
				{
					if (value[0].TryGetProperty(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aj(), out var value2) && value2.TryGetProperty(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aE(), out var value3))
					{
						string text = ((value3.ValueKind == JsonValueKind.String) ? value3.GetString() : value3.ToString());
						if (!string.IsNullOrWhiteSpace(text))
						{
							return text;
						}
					}
					if (value[0].TryGetProperty(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aK(), out var value4) && value4.ValueKind == JsonValueKind.String)
					{
						return value4.GetString();
					}
				}
				P_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ak() + A_m_1(P_0, 200);
				return null;
			}
			catch (Exception ex)
			{
				P_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aL() + ex.Message;
				return null;
			}
		}

		public static d A_m_1(string P_0, global::b.R P_1, int P_2)
		{
			d d2 = new d
			{
				a = (P_0 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D())
			};
			if (string.IsNullOrWhiteSpace(P_0))
			{
				d2.A_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.al();
				return d2;
			}
			string text = c(P_0);
			if (text == null)
			{
				d2.A_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aM() + A_m_1(P_0, 160);
				return d2;
			}
			try
			{
				using JsonDocument jsonDocument = JsonDocument.Parse(text);
				JsonElement rootElement = jsonDocument.RootElement;
				JsonElement value;
				if (rootElement.ValueKind == JsonValueKind.Array)
				{
					value = rootElement;
				}
				else if (!rootElement.TryGetProperty(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.am(), out value) && !rootElement.TryGetProperty(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aN(), out value))
				{
					d2.A_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.an();
					return d2;
				}
				foreach (JsonElement item in value.EnumerateArray())
				{
					int num = A_m_1(item);
					if (num >= 1 && num <= P_1.A_1.Count)
					{
						global::b.q q2 = P_1.A_1[num - 1];
						string text2 = A_m_1(item, q2);
						if (text2 != null)
						{
							c c2 = new c
							{
								A = num,
								A_1 = q2.B,
								a = text2
							};
							c2.B = A_m_1(item, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aO());
							c2.b = A_m_1(A_m_1(item, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ao()), false);
							d2.A_2.Add(c2);
						}
					}
				}
			}
			catch (Exception ex)
			{
				d2.A_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aP() + ex.Message;
				return d2;
			}
			if (d2.A_2.Count == 0)
			{
				d2.A_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ap();
				return d2;
			}
			d2.A = true;
			return d2;
		}

		public static d a_m_1(string P_0, global::b.R P_1, int P_2)
		{
			d d2 = new d
			{
				a = (P_0 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D())
			};
			if (string.IsNullOrWhiteSpace(P_0))
			{
				d2.A_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.al();
				return d2;
			}
			string text = c(P_0);
			if (text == null)
			{
				d2.A_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aM() + A_m_1(P_0, 160);
				return d2;
			}
			List<KeyValuePair<int, global::b.q>> list = a_m_1(P_1, P_2);
			if (list.Count == 0)
			{
				d2.A_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aQ();
				return d2;
			}
			Dictionary<int, global::b.q> dictionary = new Dictionary<int, global::b.q>();
			foreach (KeyValuePair<int, global::b.q> item in list)
			{
				dictionary[item.Key + 1] = item.Value;
			}
			Dictionary<int, c> A = new Dictionary<int, c>();
			try
			{
				using JsonDocument jsonDocument = JsonDocument.Parse(text);
				JsonElement rootElement = jsonDocument.RootElement;
				JsonElement value;
				if (rootElement.ValueKind == JsonValueKind.Array)
				{
					value = rootElement;
				}
				else if (!rootElement.TryGetProperty(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.am(), out value) && !rootElement.TryGetProperty(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aN(), out value))
				{
					d2.A_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.an();
					return d2;
				}
				if (value.ValueKind != JsonValueKind.Array)
				{
					d2.A_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aq();
					return d2;
				}
				foreach (JsonElement item2 in value.EnumerateArray())
				{
					int num = A_m_1(item2);
					if (num < 1 || !dictionary.ContainsKey(num))
					{
						d2.A_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aR() + num + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ar() + dictionary.Count + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aS() + dictionary.Keys.Min() + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.@as() + dictionary.Keys.Max() + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aT();
						return d2;
					}
					if (A.ContainsKey(num))
					{
						d2.A_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.at() + num + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aU();
						return d2;
					}
					global::b.q q2 = dictionary[num];
					string text2 = A_m_1(item2, q2);
					if (text2 == null)
					{
						d2.A_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.au() + num + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aV() + q2.A_2.Count + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.av();
						return d2;
					}
					c c2 = new c
					{
						A = num,
						A_1 = q2.B,
						a = text2
					};
					c2.B = A_m_1(item2, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aO());
					c2.b = A_m_1(A_m_1(item2, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ao()), true);
					A[num] = c2;
				}
			}
			catch (Exception ex)
			{
				d2.A_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aP() + ex.Message;
				return d2;
			}
			List<int> list2 = (from result in dictionary.Keys
				where !A.ContainsKey(result)
				orderby result
				select result).ToList();
			if (list2.Count > 0)
			{
				d2.A_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aW() + string.Join(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aw(), list2.Select((int num2) => num2.ToString()).ToArray()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aX() + dictionary.Count + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ax();
				return d2;
			}
			d2.A_2 = (from key in dictionary.Keys
				orderby key
				select A[key]).ToList();
			d2.A = true;
			return d2;
		}

		private static int A_m_1(JsonElement P_0)
		{
			int result = 0;
			if (!P_0.TryGetProperty(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aY(), out var value))
			{
				return 0;
			}
			if (value.ValueKind == JsonValueKind.Number)
			{
				try
				{
					result = value.GetInt32();
				}
				catch
				{
					result = 0;
				}
			}
			else
			{
				int.TryParse(value.ToString(), out result);
			}
			return result;
		}

		private static string A_m_1(JsonElement P_0, string P_1)
		{
			if (!P_0.TryGetProperty(P_1, out var value))
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}
			if (value.ValueKind != JsonValueKind.String)
			{
				return value.ToString();
			}
			return value.GetString() ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
		}

		private static string A_m_1(JsonElement P_0, global::b.q P_1)
		{
			if (P_0.TryGetProperty(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ay(), out var value) && value.ValueKind == JsonValueKind.String)
			{
				string A = value.GetString();
				return P_1.A_2.FirstOrDefault((global::b.Q q2) => string.Equals(q2.A, A, StringComparison.OrdinalIgnoreCase))?.A;
			}
			if (!P_0.TryGetProperty(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aZ(), out value))
			{
				return null;
			}
			if (value.ValueKind == JsonValueKind.Number)
			{
				int @int;
				try
				{
					@int = value.GetInt32();
				}
				catch
				{
					return null;
				}
				if (@int < 1 || @int > P_1.A_2.Count)
				{
					return null;
				}
				return P_1.A_2[@int - 1].A;
			}
			if (value.ValueKind == JsonValueKind.String)
			{
				string A2 = value.GetString() ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
				if (int.TryParse(A2, out var result))
				{
					if (result < 1 || result > P_1.A_2.Count)
					{
						return null;
					}
					return P_1.A_2[result - 1].A;
				}
				return P_1.A_2.FirstOrDefault((global::b.Q q2) => string.Equals(q2.A, A2, StringComparison.OrdinalIgnoreCase))?.A;
			}
			return null;
		}

		private static string A_m_1(string P_0, bool P_1)
		{
			string text = (P_0 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).Trim().ToLowerInvariant();
			if (text.StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.C()) || text.StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.az()))
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.C();
			}
			if (text.StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.c()) || text.StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BA()) || text.StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ba()))
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.c();
			}
			if (text.StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.d()) || text.StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BB()))
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.d();
			}
			if (!P_1)
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.d();
			}
			return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.c();
		}

		public static d A_m_1(x P_0, global::b.R P_1, CancellationToken P_2)
		{
			if (!A_m_1(P_0))
			{
				return new d
				{
					A = false,
					A_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bb()
				};
			}
			if (P_1 == null || P_1.A_1.Count == 0)
			{
				return new d
				{
					A = false,
					A_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BC()
				};
			}
			string text = A_m_1();
			string text2 = A_m_1(P_1, P_0.AiMaxGroups);
			string text3 = A_m_1(P_0, text, text2, out var a_, P_2);
			if (text3 == null)
			{
				return new d
				{
					A = false,
					A_1 = a_
				};
			}
			d d2 = a_m_1(text3, P_1, P_0.AiMaxGroups);
			d2.A_3.A = C(text) + C(text2);
			d2.A_3.a = C(text3);
			d2.A_3.A_2 = P_0.AiPriceInPerMillion > 0.0 || P_0.AiPriceOutPerMillion > 0.0;
			d2.A_3.A_1 = A_m_1(d2.A_3.A, d2.A_3.a, P_0.AiPriceInPerMillion, P_0.AiPriceOutPerMillion);
			return d2;
		}

		public static int C(string P_0)
		{
			if (string.IsNullOrEmpty(P_0))
			{
				return 0;
			}
			int num = 0;
			int num2 = 0;
			foreach (char c2 in P_0)
			{
				if ((c2 >= '一' && c2 <= '鿿') || (c2 >= '\u3000' && c2 <= '〿') || (c2 >= '\uff00' && c2 <= '\uffef'))
				{
					num++;
				}
				else
				{
					num2++;
				}
			}
			return num + (num2 + 3) / 4;
		}

		public static double A_m_1(int P_0, int P_1, double P_2, double P_3)
		{
			if (P_2 <= 0.0 && P_3 <= 0.0)
			{
				return 0.0;
			}
			return (double)P_0 / 1000000.0 * P_2 + (double)P_1 / 1000000.0 * P_3;
		}

		private static string c(string P_0)
		{
			int num = P_0.IndexOf('{');
			int num2 = P_0.LastIndexOf('}');
			if (num >= 0 && num2 > num)
			{
				return P_0.Substring(num, num2 - num + 1);
			}
			num = P_0.IndexOf('[');
			num2 = P_0.LastIndexOf(']');
			if (num >= 0 && num2 > num)
			{
				return P_0.Substring(num, num2 - num + 1);
			}
			return null;
		}

		private static string A_m_1(string P_0, int P_1)
		{
			if (string.IsNullOrEmpty(P_0))
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}
			P_0 = P_0.Replace(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bc(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aH()).Replace(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BD(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aH());
			if (P_0.Length > P_1)
			{
				return P_0.Substring(0, P_1) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.j();
			}
			return P_0;
		}

		public static string A_m_1(long P_0)
		{
			double num = P_0;
			if (num < 1024.0)
			{
				return P_0 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bd();
			}
			if (num < 1048576.0)
			{
				return (num / 1024.0).ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.w(), CultureInfo.InvariantCulture) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BE();
			}
			if (num < 1073741824.0)
			{
				return (num / 1024.0 / 1024.0).ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.w(), CultureInfo.InvariantCulture) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Be();
			}
			return (num / 1024.0 / 1024.0 / 1024.0).ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BF(), CultureInfo.InvariantCulture) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bf();
		}
	}
	public sealed class e : Form
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class A
		{
			public static readonly A A_f_1 = new A();

			public static Func<c, bool> A_f_2;

			public static Func<c, int> A_f_3;

			internal bool A_m_1(c P_0)
			{
				return P_0.IsHigh;
			}

			internal int a(c P_0)
			{
				return P_0.A;
			}
		}

		[CompilerGenerated]
		private sealed class a
		{
			public e A;

			public CancellationToken A_1;

			internal d A_m_1()
			{
				return E.A_m_1(A.A_1, A.A_2, A_1);
			}
		}

		private readonly x A_1;

		private readonly global::b.R A_2;

		private readonly global::b.Y A_3;

		private ListView A_4;

		private Label A_5;

		private Button A_6;

		private Button a_1;

		private CancellationTokenSource A_7;

		public List<c> A_8 = new List<c>();

		public bool A_9;

		public e(x P_0, global::b.R P_1, global::b.Y P_2)
		{
			A_1 = P_0;
			A_2 = P_1;
			A_3 = P_2;
			Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BG(), P_1.A_1.Count);
			StartPosition = FormStartPosition.CenterParent;
			Icon = R.App;
			Font = global::B.Q.A_m_1(10f);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(980, 600);
			MinimumSize = new Size(760, 460);
			BackColor = P_2.A;
			ForeColor = P_2.b;
			A_m_1();
			global::b.Z.A_m_1(this, P_2, A_6);
			global::a.Q.A_m_1(this);
			Shown += delegate
			{
				if (A_1.AiAutoRun)
				{
					a_m_1();
				}
			};
			FormClosing += delegate
			{
				if (A_7 != null)
				{
					A_7.Cancel();
				}
			};
		}

		private void A_m_1()
		{
			TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
			{
				Dock = DockStyle.Fill,
				ColumnCount = 1,
				RowCount = 3,
				Padding = new Padding(12),
				Margin = new Padding(0)
			};
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			A_5 = new Label
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bg(),
				AutoSize = true,
				MaximumSize = new Size(900, 0),
				Margin = new Padding(2, 0, 2, 8),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BH()
			};
			tableLayoutPanel.Controls.Add(A_5, 0, 0);
			A_4 = new ListView
			{
				Dock = DockStyle.Fill,
				View = View.Details,
				FullRowSelect = true,
				MultiSelect = false,
				HideSelection = false,
				BorderStyle = BorderStyle.FixedSingle,
				Font = global::B.Q.A_m_1(9.5f),
				BackColor = A_3.c,
				ForeColor = A_3.D
			};
			A_4.Columns.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bh(), 56);
			A_4.Columns.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BI(), 80);
			A_4.Columns.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bi(), 380);
			A_4.Columns.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BJ(), 300);
			A_4.Columns.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bj(), 60);
			tableLayoutPanel.Controls.Add(A_4, 0, 1);
			TableLayoutPanel tableLayoutPanel2 = new TableLayoutPanel
			{
				Dock = DockStyle.Fill,
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				ColumnCount = 4,
				RowCount = 1,
				Margin = new Padding(0, 10, 0, 0)
			};
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			A_6 = new Button
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BK(),
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				MinimumSize = new Size(120, 36),
				Padding = new Padding(10, 2, 10, 2),
				Margin = new Padding(0, 0, 8, 0),
				Enabled = false,
				Font = global::B.Q.A_m_1(10.5f, FontStyle.Bold)
			};
			A_6.Click += delegate
			{
				if (A_8.Count != 0)
				{
					A_9 = true;
					DialogResult = DialogResult.OK;
					Close();
				}
			};
			tableLayoutPanel2.Controls.Add(A_6, 0, 0);
			a_1 = new Button
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bk(),
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				MinimumSize = new Size(110, 36),
				Padding = new Padding(10, 2, 10, 2),
				Margin = new Padding(0, 0, 8, 0),
				Font = global::B.Q.A_m_1(10f)
			};
			a_1.Click += delegate
			{
				a_m_1();
			};
			tableLayoutPanel2.Controls.Add(a_1, 1, 0);
			Label control = new Label
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BL(),
				AutoSize = true,
				MaximumSize = new Size(520, 0),
				Anchor = AnchorStyles.Left,
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BH(),
				Margin = new Padding(8, 10, 8, 0)
			};
			tableLayoutPanel2.Controls.Add(control, 2, 0);
			Button button = new Button
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bl(),
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				MinimumSize = new Size(110, 36),
				Padding = new Padding(10, 2, 10, 2),
				Font = global::B.Q.A_m_1(10f)
			};
			button.Click += delegate
			{
				DialogResult = DialogResult.Cancel;
				Close();
			};
			tableLayoutPanel2.Controls.Add(button, 3, 0);
			tableLayoutPanel.Controls.Add(tableLayoutPanel2, 0, 2);
			Controls.Add(tableLayoutPanel);
			CancelButton = button;
		}

		private async void a_m_1()
		{
			if (A_7 != null)
			{
				A_7.Cancel();
			}
			A_7 = new CancellationTokenSource();
			CancellationToken A_1 = A_7.Token;
			A_4.Items.Clear();
			A_6.Enabled = false;
			a_1.Enabled = false;
			A_5.ForeColor = A_3.I;
			A_5.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.RD() + this.A_1.AiModel + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.qU() + this.A_1.AiMaxGroups + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMM();
			Cursor = Cursors.WaitCursor;
			d d2;
			try
			{
				d2 = await Task.Run(() => E.A_m_1(this.A_1, A_2, A_1), A_1);
			}
			catch (OperationCanceledException)
			{
				A_5.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ia();
				a_1.Enabled = true;
				Cursor = Cursors.Default;
				return;
			}
			catch (Exception ex2)
			{
				d2 = new d
				{
					A = false,
					A_1 = ex2.Message
				};
			}
			Cursor = Cursors.Default;
			a_1.Enabled = true;
			if (d2 == null)
			{
				A_5.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.RB();
				return;
			}
			if (!d2.A)
			{
				A_5.ForeColor = A_3.J;
				A_5.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.qZ() + d2.A_1 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMm();
				return;
			}
			A_8 = d2.A_2;
			A_m_1(d2);
			A_6.Enabled = A_8.Count > 0;
			A_5.ForeColor = A_3.j;
			A_5.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.RC() + A_8.Count + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMN() + Enumerable.Count(A_8, (c P_0) => P_0.IsHigh) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMn() + ((d2.A_3 == null) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D() : d2.A_3.A_m_1()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMO();
			if (this.A_1.AiAutoApply && A_8.Count > 0)
			{
				A_9 = true;
				DialogResult = DialogResult.OK;
				Close();
			}
		}

		private void A_m_1(d P_0)
		{
			A_4.BeginUpdate();
			A_4.Items.Clear();
			foreach (c item in P_0.A_2.OrderBy((c c2) => c2.A))
			{
				global::b.q q2 = ((item.A - 1 < A_2.A_1.Count) ? A_2.A_1[item.A - 1] : null);
				ListViewItem listViewItem = new ListViewItem(item.A.ToString());
				listViewItem.SubItems.Add((q2 == null) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D() : q2.a);
				listViewItem.SubItems.Add(item.a);
				listViewItem.SubItems.Add(item.B);
				listViewItem.SubItems.Add(item.b);
				if (item.IsHigh)
				{
					listViewItem.ForeColor = A_3.J;
				}
				else if (item.IsMid)
				{
					listViewItem.ForeColor = A_3.i;
				}
				else
				{
					listViewItem.ForeColor = A_3.j;
				}
				A_4.Items.Add(listViewItem);
			}
			A_4.EndUpdate();
		}

		[CompilerGenerated]
		private void A_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			if (A_1.AiAutoRun)
			{
				a_m_1();
			}
		}

		[CompilerGenerated]
		private void A_m_1(object? _003Cp0_003E, FormClosingEventArgs P_1)
		{
			if (A_7 != null)
			{
				A_7.Cancel();
			}
		}

		[CompilerGenerated]
		private void a_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			if (A_8.Count != 0)
			{
				A_9 = true;
				DialogResult = DialogResult.OK;
				Close();
			}
		}

		[CompilerGenerated]
		private void B_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			a_m_1();
		}

		[CompilerGenerated]
		private void b(object? _003Cp0_003E, EventArgs P_1)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
namespace a
{
	public sealed class E
	{
		private struct A
		{
			public long A_f_1;

			public long a;

			public int A_f_2;

			public int a_1;

			public int B;
		}

		private struct a
		{
			public int A;

			public int a_f_1;

			public int B;
		}

		private struct B
		{
			public int A;

			public int a;

			public int B_f_1;
		}

		private sealed class b : IComparer<A>
		{
			public static readonly b A = new b();

			public int Compare(A P_0, A P_1)
			{
				int num = P_0.A_f_1.CompareTo(P_1.A_f_1);
				if (num == 0)
				{
					return P_0.B.CompareTo(P_1.B);
				}
				return num;
			}
		}

		[Serializable]
		[CompilerGenerated]
		private sealed class C
		{
			public static readonly C A = new C();

			public static Comparison<a> A_1;

			public static Comparison<B> A_2;

			public static Comparison<global::a.c> A_3;

			public static Func<global::a.C, string> A_4;

			internal int A_m_1(a P_0, a P_1)
			{
				return P_0.B.CompareTo(P_1.B);
			}

			internal int A_m_1(B P_0, B P_1)
			{
				return P_0.A.CompareTo(P_1.A);
			}

			internal int A_m_1(global::a.c P_0, global::a.c P_1)
			{
				int num = P_1.Wasted.CompareTo(P_0.Wasted);
				if (num == 0)
				{
					return P_1.A_1.CompareTo(P_0.A_1);
				}
				return num;
			}

			internal string A_m_1(global::a.C P_0)
			{
				return P_0.A;
			}
		}

		[CompilerGenerated]
		private sealed class c
		{
			public byte[] A;

			internal int A_m_1(int P_0, int P_1)
			{
				int num = E.A_m_1(A, P_0, P_1);
				if (num == 0)
				{
					return P_0.CompareTo(P_1);
				}
				return num;
			}
		}

		[CompilerGenerated]
		private sealed class D
		{
			public FileInfo A;

			internal DateTime A_m_1()
			{
				return A.LastWriteTime;
			}
		}

		[CompilerGenerated]
		private sealed class d
		{
			public global::a.C A;

			internal DateTime A_m_1()
			{
				return File.GetCreationTime(A.A);
			}
		}

		private const int A_1 = 65536;

		private const int a_1 = 1048576;

		private const int B_1 = 32;

		private const int b_1 = 40000;

		private const int C_1 = 20;

		private const int c_1 = 1048576;

		private const int D_1 = 1048575;

		private readonly global::a.b A_2;

		private volatile bool A_3;

		private volatile bool a_2;

		private Action<global::a.D> A_4;

		private readonly List<global::a.c> A_5 = new List<global::a.c>();

		private A[] A_6 = Array.Empty<A>();

		private int d_1;

		private List<char[]> A_7 = new List<char[]>(4);

		private int E_f_1;

		[CompilerGenerated]
		private long A_8;

		[CompilerGenerated]
		private long a_3;

		[CompilerGenerated]
		private bool A_9;

		[CompilerGenerated]
		private bool a_4;

		public List<global::a.c> Groups => A_5;

		public long ScannedFiles
		{
			[CompilerGenerated]
			get
			{
				return A_8;
			}
			[CompilerGenerated]
			private set
			{
				A_8 = value;
			}
		}

		public long SkippedDirs
		{
			[CompilerGenerated]
			get
			{
				return a_3;
			}
			[CompilerGenerated]
			private set
			{
				a_3 = value;
			}
		}

		public bool UsedEverything
		{
			[CompilerGenerated]
			get
			{
				return A_9;
			}
			[CompilerGenerated]
			private set
			{
				A_9 = value;
			}
		}

		public bool Canceled
		{
			[CompilerGenerated]
			get
			{
				return a_4;
			}
			[CompilerGenerated]
			private set
			{
				a_4 = value;
			}
		}

		public E(global::a.b P_0)
		{
			A_2 = P_0 ?? new global::a.b();
		}

		public void A_m_1()
		{
			A_3 = true;
		}

		public void a_m_1()
		{
			A_3 = false;
		}

		public void B_m_1()
		{
			a_2 = true;
			A_3 = false;
		}

		public void A_m_1(Action<global::a.D> P_0, CancellationToken P_1)
		{
			A_4 = P_0;
			DateTime now = DateTime.Now;
			foreach (string item in A_2.A)
			{
				if (P_1.IsCancellationRequested || a_2)
				{
					break;
				}
				if (Directory.Exists(global::a.a.A(item)))
				{
					bool flag = false;
					if (A_2.B)
					{
						flag = a_m_1(item, now, P_1);
					}
					if (!flag)
					{
						A_m_1(item, now, P_1);
					}
				}
			}
			if (P_1.IsCancellationRequested || a_2)
			{
				Canceled = true;
				A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jt(), now, 0L, 0L, false, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
				c_m_1();
				C_m_1();
				return;
			}
			a[] array = b_m_1();
			int num = d_1;
			int[] array2 = new int[num];
			int num2 = 0;
			a[] array3 = array;
			for (int num3 = 0; num3 < array3.Length; num3++)
			{
				a a2 = array3[num3];
				for (int num4 = a2.A; num4 < a2.A + a2.a_f_1; num4++)
				{
					array2[num2++] = num4;
				}
			}
			byte[] array4 = ArrayPool<byte>.Shared.Rent(num * 32);
			int[] array5 = Array.Empty<int>();
			int num5 = 0;
			bool flag2 = false;
			B[] array6;
			try
			{
				for (int num6 = 0; num6 < num; num6++)
				{
					if (A_m_1(P_1, now, num5, num))
					{
						flag2 = true;
						break;
					}
					A a3 = A_6[array2[num6]];
					string text = A_m_1(a3);
					try
					{
						A_m_1(text, a3.A_f_1, array4, num6 * 32);
					}
					catch
					{
						a_m_1(array4, num6 * 32, num6);
					}
					num5++;
					if ((num5 & 0x3F) == 0)
					{
						A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JU() + num5 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aA() + num, now, num5, num, true, text);
					}
				}
				array6 = (flag2 ? Array.Empty<B>() : A_m_1(array4, num, out array5));
			}
			finally
			{
				ArrayPool<byte>.Shared.Return(array4);
			}
			if (flag2 || A_m_1(P_1, now, num5, num5))
			{
				a_m_1(now);
				C_m_1();
				return;
			}
			if (A_2.a)
			{
				B[] array7 = array6;
				for (int num3 = 0; num3 < array7.Length; num3++)
				{
					B b2 = array7[num3];
					Array.Sort(array5, b2.a, b2.B_f_1);
					// C-05：快筛模式（只比对前 64KB）产出的分组不再直接当作最终重复组，
					// 标记为“未全量校验”，删除前一律用全量 SHA-256 与组内保留文件复核。
					global::a.c c4 = A_m_1(A_m_1(array5, b2.a, b2.B_f_1, array2));
					c4.b = true;
					A_5.Add(c4);
				}
			}
			else
			{
				long num7 = 0L;
				B[] array7 = array6;
				for (int num3 = 0; num3 < array7.Length; num3++)
				{
					B b3 = array7[num3];
					num7 += b3.B_f_1;
				}
				long num8 = 0L;
				array7 = array6;
				for (int num3 = 0; num3 < array7.Length; num3++)
				{
					B b4 = array7[num3];
					if (P_1.IsCancellationRequested || a_2)
					{
						break;
					}
					byte[] array8 = ArrayPool<byte>.Shared.Rent(b4.B_f_1 * 32);
					try
					{
						int num9 = 0;
						for (int num10 = 0; num10 < b4.B_f_1; num10++)
						{
							if (A_m_1(P_1, now, num8, num7))
							{
								break;
							}
							int num11 = array5[b4.a + num10];
							A a4 = A_6[array2[num11]];
							string text2 = A_m_1(a4);
							try
							{
								A_m_1(text2, a4.A_f_1, P_1, array8, num10 * 32);
							}
							catch
							{
								a_m_1(array8, num10 * 32, num10);
							}
							num9 = num10 + 1;
							num8++;
							if ((num8 & 0xF) == 0L)
							{
								A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ju() + num8 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aA() + num7, now, num8, num7, true, text2);
							}
						}
						B[] array9 = A_m_1(array8, num9, out var array10);
						for (int num12 = 0; num12 < array9.Length; num12++)
						{
							B b5 = array9[num12];
							int[] array11 = new int[b5.B_f_1];
							for (int num13 = 0; num13 < b5.B_f_1; num13++)
							{
								array11[num13] = array5[b4.a + array10[b5.a + num13]];
							}
							Array.Sort(array11);
							A_5.Add(A_m_1(A_m_1(array11, 0, array11.Length, array2)));
						}
					}
					finally
					{
						ArrayPool<byte>.Shared.Return(array8);
					}
					if (P_1.IsCancellationRequested || a_2)
					{
						break;
					}
				}
			}
			if (P_1.IsCancellationRequested || a_2)
			{
				Canceled = true;
				c_m_1();
				A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JV(), now, 0L, 0L, false, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
				C_m_1();
			}
			else
			{
				c_m_1();
				C_m_1();
				A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jv(), now, 0L, 0L, false, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
			}
		}

		private a[] b_m_1()
		{
			int num = d_1;
			Array.Sort(A_6, 0, num, b.A);
			List<a> list = new List<a>();
			int num2 = 0;
			int num3 = 0;
			while (num3 < num)
			{
				int num4;
				for (num4 = num3 + 1; num4 < num && A_6[num4].A_f_1 == A_6[num3].A_f_1; num4++)
				{
				}
				int num5 = num4 - num3;
				if (num5 >= 2)
				{
					if (num2 != num3)
					{
						for (int num6 = num3; num6 < num4; num6++)
						{
							A_6[num2 + (num6 - num3)] = A_6[num6];
						}
					}
					list.Add(new a
					{
						A = num2,
						a_f_1 = num5,
						B = A_6[num2].B
					});
					num2 += num5;
				}
				num3 = num4;
			}
			d_1 = num2;
			a[] array = list.ToArray();
			Array.Sort(array, (a P_0, a P_1) => P_0.B.CompareTo(P_1.B));
			return array;
		}

		private void C_m_1()
		{
			A_6 = Array.Empty<A>();
			d_1 = 0;
			A_7 = null;
			E_f_1 = 0;
			try
			{
				GCSettings.LargeObjectHeapCompactionMode = GCLargeObjectHeapCompactionMode.CompactOnce;
				GC.Collect(2, GCCollectionMode.Forced, blocking: true, compacting: true);
			}
			catch
			{
			}
		}

		private string A_m_1(A P_0)
		{
			int num = P_0.a_1;
			if (num <= 0)
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}
			return new string(A_7[P_0.A_f_2 >> 20], P_0.A_f_2 & 0xFFFFF, num);
		}

		private int A_m_1(string P_0)
		{
			int length = P_0.Length;
			int num = E_f_1 >> 20;
			int num2 = E_f_1 & 0xFFFFF;
			if (num2 + length > 1048576)
			{
				num++;
				num2 = 0;
				E_f_1 = num << 20;
			}
			while (A_7.Count <= num)
			{
				A_7.Add(new char[1048576]);
			}
			P_0.CopyTo(0, A_7[num], num2, length);
			int e_f_ = E_f_1;
			E_f_1 += length;
			return e_f_;
		}

		private void A_m_1(string P_0, long P_1, long P_2)
		{
			if (d_1 == A_6.Length)
			{
				Array.Resize(ref A_6, (A_6.Length == 0) ? 4096 : (A_6.Length * 2));
			}
			int a_f_ = A_m_1(P_0);
			A_6[d_1] = new A
			{
				A_f_1 = P_1,
				a = P_2,
				A_f_2 = a_f_,
				a_1 = P_0.Length,
				B = d_1
			};
			d_1++;
		}

		private static long A_m_1(DateTime P_0)
		{
			if (!(P_0 == DateTime.MinValue))
			{
				return P_0.Ticks;
			}
			return 0L;
		}

		private static DateTime A_m_1(long P_0)
		{
			if (P_0 != 0L)
			{
				return new DateTime(P_0, DateTimeKind.Local);
			}
			return DateTime.MinValue;
		}

		private List<global::a.C> A_m_1(int[] P_0, int P_1, int P_2, int[] P_3)
		{
			List<global::a.C> list = new List<global::a.C>(P_2);
			for (int num = P_1; num < P_1 + P_2; num++)
			{
				int num2 = P_3[P_0[num]];
				A a2 = A_6[num2];
				list.Add(new global::a.C
				{
					A = A_m_1(a2),
					A_1 = a2.A_f_1,
					A_2 = A_m_1(a2.a),
					a = DateTime.MinValue
				});
				A_6[num2].a_1 = 0;
			}
			return list;
		}

		private static B[] A_m_1(byte[] P_0, int P_1, out int[] P_2)
		{
			P_2 = new int[P_1];
			for (int num = 0; num < P_1; num++)
			{
				P_2[num] = num;
			}
			if (P_1 <= 24)
			{
				for (int num2 = 1; num2 < P_1; num2++)
				{
					int num3 = P_2[num2];
					int num4 = num2 - 1;
					while (num4 >= 0 && A_m_1(P_0, num3, P_2[num4]) < 0)
					{
						P_2[num4 + 1] = P_2[num4];
						num4--;
					}
					P_2[num4 + 1] = num3;
				}
			}
			else
			{
				Array.Sort(P_2, (int num11, int num12) =>
				{
					int num10 = A_m_1(P_0, num11, num12);
					return (num10 == 0) ? num11.CompareTo(num12) : num10;
				});
			}
			List<B> list = new List<B>();
			int num5 = 0;
			while (num5 < P_1)
			{
				int num6;
				for (num6 = num5 + 1; num6 < P_1 && A_m_1(P_0, P_2[num5], P_2[num6]) == 0; num6++)
				{
				}
				int num7 = num6 - num5;
				if (num7 >= 2)
				{
					int num8 = P_2[num5];
					for (int num9 = num5 + 1; num9 < num6; num9++)
					{
						if (P_2[num9] < num8)
						{
							num8 = P_2[num9];
						}
					}
					list.Add(new B
					{
						A = num8,
						a = num5,
						B_f_1 = num7
					});
				}
				num5 = num6;
			}
			B[] array = list.ToArray();
			Array.Sort(array, (B b2, B b3) => b2.A.CompareTo(b3.A));
			return array;
		}

		private static int A_m_1(byte[] P_0, int P_1, int P_2)
		{
			int num = P_1 * 32;
			int num2 = P_2 * 32;
			for (int num3 = 0; num3 < 32; num3++)
			{
				byte b2 = P_0[num + num3];
				byte b3 = P_0[num2 + num3];
				if (b2 != b3)
				{
					if (b2 >= b3)
					{
						return 1;
					}
					return -1;
				}
			}
			return 0;
		}

		private static void a_m_1(byte[] P_0, int P_1, int P_2)
		{
			for (int num = 0; num < 32; num++)
			{
				P_0[P_1 + num] = byte.MaxValue;
			}
			P_0[P_1] = (byte)(P_2 & 0xFF);
			P_0[P_1 + 1] = (byte)((P_2 >> 8) & 0xFF);
			P_0[P_1 + 2] = (byte)((P_2 >> 16) & 0xFF);
			P_0[P_1 + 3] = (byte)((P_2 >> 24) & 0xFF);
		}

		private void c_m_1()
		{
			A_5.Sort((global::a.c P_0, global::a.c P_1) =>
			{
				int num2 = P_1.Wasted.CompareTo(P_0.Wasted);
				return (num2 == 0) ? P_1.A_1.CompareTo(P_0.A_1) : num2;
			});
			for (int num = 0; num < A_5.Count; num++)
			{
				A_5[num].A = num + 1;
			}
		}

		private bool A_m_1(CancellationToken P_0)
		{
			while (A_3 && !a_2 && !P_0.IsCancellationRequested)
			{
				Thread.Sleep(60);
			}
			if (!a_2)
			{
				return P_0.IsCancellationRequested;
			}
			return true;
		}

		private bool A_m_1(CancellationToken P_0, DateTime P_1, long P_2, long P_3)
		{
			while (A_3 && !a_2 && !P_0.IsCancellationRequested)
			{
				A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JW(), P_1, P_2, P_3, true, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
				Thread.Sleep(60);
			}
			if (!a_2)
			{
				return P_0.IsCancellationRequested;
			}
			return true;
		}

		private void a_m_1(DateTime P_0)
		{
			Canceled = true;
			A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jt(), P_0, 0L, 0L, false, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
		}

		private void A_m_1(string P_0, DateTime P_1, long P_2, long P_3, bool P_4, string P_5 = "")
		{
			global::a.D obj = new global::a.D
			{
				A = P_0,
				A_1 = ScannedFiles,
				a = SkippedDirs,
				A_2 = Groups.Count,
				a_1 = (P_5 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()),
				A_3 = DateTime.Now - P_1,
				B = P_2,
				b = P_3,
				A_4 = Canceled
			};
			try
			{
				A_4?.Invoke(obj);
			}
			catch
			{
			}
		}

		private void A_m_1(string P_0, DateTime P_1, CancellationToken P_2)
		{
			Stack<string> stack = new Stack<string>();
			stack.Push(global::a.a.A(P_0));
			long num = 0L;
			while (stack.Count > 0)
			{
				if (A_m_1(P_2))
				{
					return;
				}
				string text = stack.Pop();
				if (global::a.B.a_m_1(text))
				{
					continue;
				}
				string[] array;
				try
				{
					array = Directory.GetFiles(text);
				}
				catch
				{
					array = Array.Empty<string>();
				}
				string[] array2 = array;
				foreach (string text2 in array2)
				{
					if (A_m_1(P_2))
					{
						return;
					}
					a_m_1(text2);
				}
				string[] directories;
				try
				{
					directories = Directory.GetDirectories(text);
				}
				catch
				{
					SkippedDirs++;
					continue;
				}
				array2 = directories;
				foreach (string text3 in array2)
				{
					if (global::a.B.a_m_1(text3))
					{
						continue;
					}
					try
					{
						if ((File.GetAttributes(text3) & FileAttributes.ReparsePoint) != 0)
						{
							continue;
						}
					}
					catch
					{
						continue;
					}
					stack.Push(text3);
				}
				num++;
				if ((num & 0x1F) == 0L)
				{
					A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jw(), P_1, 0L, 0L, false, global::a.a.a_m_1(text));
				}
			}
			A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jw(), P_1, 0L, 0L, false, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
		}

		private void a_m_1(string P_0)
		{
			string text = global::a.a.a_m_1(P_0);
			if (global::a.B.A_m_1(text))
			{
				return;
			}
			FileInfo A;
			try
			{
				A = new FileInfo(P_0);
			}
			catch
			{
				return;
			}
			if (!A.Exists)
			{
				return;
			}
			long length;
			try
			{
				length = A.Length;
			}
			catch
			{
				return;
			}
			if ((length != 0L || A_2.A_1) && (length <= 0 || A_2.MinBytes <= 0 || length >= A_2.MinBytes) && (A.Attributes & FileAttributes.ReparsePoint) == 0)
			{
				A_m_1(text, length, A_m_1(A_m_1(() => A.LastWriteTime)));
				ScannedFiles++;
			}
		}

		private void A_m_1(string P_0, CancellationToken P_1)
		{
			if (global::a.B.a_m_1(P_0))
			{
				return;
			}
			string[] files;
			try
			{
				files = Directory.GetFiles(global::a.a.A(P_0));
			}
			catch
			{
				return;
			}
			string[] array = files;
			foreach (string text in array)
			{
				if (A_m_1(P_1))
				{
					break;
				}
				a_m_1(text);
			}
		}

		private static string[] B_m_1(string P_0)
		{
			try
			{
				string[] directories = Directory.GetDirectories(global::a.a.A(P_0));
				for (int num = 0; num < directories.Length; num++)
				{
					directories[num] = global::a.a.a_m_1(directories[num]);
				}
				return directories;
			}
			catch
			{
				return Array.Empty<string>();
			}
		}

		private static bool A_m_1(string P_0, string P_1)
		{
			string text = P_1.TrimEnd('\\', '/');
			if (text.Length == 0 || P_0.Length <= text.Length)
			{
				return false;
			}
			if (!P_0.StartsWith(text, StringComparison.OrdinalIgnoreCase))
			{
				return false;
			}
			char c2 = P_0[text.Length];
			if (c2 != '\\')
			{
				return c2 == '/';
			}
			return true;
		}

		private bool a_m_1(string P_0, DateTime P_1, CancellationToken P_2)
		{
			try
			{
				if (!global::b.t.A_m_1(out var _))
				{
					return false;
				}
				int num = d_1;
				bool usedEverything = true;
				Stack<string> stack = new Stack<string>();
				stack.Push(P_0);
				while (stack.Count > 0)
				{
					if (P_2.IsCancellationRequested || a_2)
					{
						return false;
					}
					string text2 = stack.Pop();
					if (global::a.B.a_m_1(text2))
					{
						continue;
					}
					global::b.T t2 = global::b.t.A_m_1((text2.Length >= 2 && text2[text2.Length - 1] == '\\') ? (text2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JY()) : (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JX() + text2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jx()), 40001, P_2);
					if (t2 == null || t2.A_3 != null || t2.a)
					{
						usedEverything = false;
						A_m_1(text2, P_1, P_2);
						continue;
					}
					if (t2.A_1.Count > 40000)
					{
						A_m_1(text2, P_2);
						string[] array = B_m_1(text2);
						foreach (string text3 in array)
						{
							if (!global::a.B.a_m_1(text3))
							{
								stack.Push(text3);
							}
						}
						continue;
					}
					foreach (global::b.S item in t2.A_1)
					{
						if (P_2.IsCancellationRequested || a_2)
						{
							return false;
						}
						string text4 = item.B;
						if (!string.IsNullOrEmpty(text4) && A_m_1(text4, text2) && !global::a.B.A_m_1(text4) && !global::a.B.a_m_1(Path.GetDirectoryName(text4) ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()) && item.A_1 >= 0 && (item.A_1 != 0L || A_2.A_1) && (item.A_1 <= 0 || A_2.MinBytes <= 0 || item.A_1 >= A_2.MinBytes) && File.Exists(global::a.a.A(text4)) && !global::a.a.D(text4))
						{
							A_m_1(text4, item.A_1, A_m_1((item.A_2 == default(DateTime)) ? DateTime.MinValue : item.A_2));
							ScannedFiles++;
						}
					}
				}
				if (d_1 == num)
				{
					return false;
				}
				UsedEverything = usedEverything;
				A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jy(), P_1, 0L, 0L, false, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
				return true;
			}
			catch
			{
				return false;
			}
		}

		private static DateTime A_m_1(Func<DateTime> P_0)
		{
			try
			{
				return P_0();
			}
			catch
			{
				return DateTime.MinValue;
			}
		}

		private global::a.c A_m_1(List<global::a.C> P_0)
		{
			global::a.c c2 = new global::a.c
			{
				A_1 = P_0[0].A_1
			};
			c2.A_2 = P_0.OrderBy((global::a.C c3) => c3.A, StringComparer.OrdinalIgnoreCase).ToList();
			foreach (global::a.C A in c2.A_2)
			{
				if (A.a == DateTime.MinValue)
				{
					A.a = A_m_1(() => File.GetCreationTime(A.A));
				}
			}
			c2.a = a_m_1(c2.A_2);
			return c2;
		}

		public static int a_m_1(List<global::a.C> P_0)
		{
			if (P_0 == null || P_0.Count == 0)
			{
				return -1;
			}
			int num = 0;
			for (int num2 = 1; num2 < P_0.Count; num2++)
			{
				if (A_m_1(P_0[num2], P_0[num]) < 0)
				{
					num = num2;
				}
			}
			return num;
		}

		private static int A_m_1(global::a.C P_0, global::a.C P_1)
		{
			int num = b_m_1(P_0.A).CompareTo(b_m_1(P_1.A));
			if (num != 0)
			{
				return num;
			}
			num = C_m_1(P_0.A).CompareTo(C_m_1(P_1.A));
			if (num != 0)
			{
				return num;
			}
			num = P_0.A.Length.CompareTo(P_1.A.Length);
			if (num != 0)
			{
				return num;
			}
			num = Path.GetFileName(P_0.A).Length.CompareTo(Path.GetFileName(P_1.A).Length);
			if (num != 0)
			{
				return num;
			}
			return P_1.A_2.CompareTo(P_0.A_2);
		}

		private static bool b_m_1(string P_0)
		{
			string text = (Path.GetFileName(P_0) ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).ToLowerInvariant();
			if (!text.Contains(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JZ()) && !text.Contains(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jz()) && !text.Contains(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CJ()))
			{
				return text.Contains(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jA());
			}
			return true;
		}

		private static int C_m_1(string P_0)
		{
			return global::a.a.a_m_1(P_0).Split(new char[2] { '\\', '/' }, StringSplitOptions.RemoveEmptyEntries).Length;
		}

		private static void A_m_1(string P_0, long P_1, byte[] P_2, int P_3)
		{
			int num = (int)Math.Min(65536L, P_1);
			byte[] array = ArrayPool<byte>.Shared.Rent(65536);
			try
			{
				int num2 = 0;
				using (FileStream fileStream = new FileStream(global::a.a.A(P_0), FileMode.Open, FileAccess.Read, FileShare.Read, 4096, FileOptions.SequentialScan))
				{
					int num3;
					for (; num2 < num; num2 += num3)
					{
						num3 = fileStream.Read(array, num2, num - num2);
						if (num3 <= 0)
						{
							break;
						}
					}
				}
				SHA256.HashData(array.AsSpan(0, num2), P_2.AsSpan(P_3, 32));
			}
			finally
			{
				ArrayPool<byte>.Shared.Return(array);
			}
		}

		private static void A_m_1(string P_0, long P_1, CancellationToken P_2, byte[] P_3, int P_4)
		{
			byte[] array = ArrayPool<byte>.Shared.Rent(1048576);
			try
			{
				using FileStream fileStream = new FileStream(global::a.a.A(P_0), FileMode.Open, FileAccess.Read, FileShare.Read, 4096, FileOptions.SequentialScan);
				using IncrementalHash incrementalHash = IncrementalHash.CreateHash(HashAlgorithmName.SHA256);
				long num = 0L;
				do
				{
					P_2.ThrowIfCancellationRequested();
					int num2 = fileStream.Read(array, 0, 1048576);
					if (num2 <= 0)
					{
						break;
					}
					incrementalHash.AppendData(array, 0, num2);
					num += num2;
				}
				while (num <= P_1);
				incrementalHash.GetHashAndReset(P_3.AsSpan(P_4, 32));
			}
			finally
			{
				ArrayPool<byte>.Shared.Return(array);
			}
		}
	}
	public static class e
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class A
		{
			public static readonly A A_f_1 = new A();

			public static Func<C, bool> A_f_2;

			internal bool A_m_1(C P_0)
			{
				return P_0.A_3;
			}
		}

		[CompilerGenerated]
		private sealed class a
		{
			public Func<C, bool> A;

			internal int A_m_1(c P_0)
			{
				return Enumerable.Count(P_0.A_2, A);
			}
		}

		public static d A_m_1(IEnumerable<c> P_0, CancellationToken P_1)
		{
			return A_m_1(P_0, null, false, P_1);
		}

		public static d A_m_1(IEnumerable<c> P_0, Func<C, bool> P_1, CancellationToken P_2)
		{
			return A_m_1(P_0, P_1, false, P_2);
		}

		public static d A_m_1(IEnumerable<c> P_0, Func<C, bool> P_1, bool P_2, CancellationToken P_3)
		{
			d d2 = new d();
			List<c> list = ((P_0 == null) ? new List<c>() : P_0.ToList());
			Func<C, bool> A = P_1 ?? ((Func<C, bool>)((C c2) => c2.A_3));
			foreach (c item in list)
			{
				int num = Enumerable.Count(item.A_2, A);
				if (num > 0 && num >= item.A_2.Count)
				{
					d2.A_1 = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ja());
					return d2;
				}
			}
			if (list.Sum((c c2) => Enumerable.Count(c2.A_2, A)) == 0)
			{
				d2.A_1 = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jB());
				return d2;
			}
			global::B.w w2 = null;
			try
			{
				w2 = new global::B.w(false, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jb());
				d2.a_1 = w2.FilePath;
				Dictionary<string, Tuple<F, string>> dictionary = new Dictionary<string, Tuple<F, string>>(StringComparer.OrdinalIgnoreCase);
				foreach (c item2 in list)
				{
					foreach (C item3 in item2.A_2.Where(A))
					{
						if (P_3.IsCancellationRequested)
						{
							break;
						}
						// C-05：快筛分组（只比对前 64KB）在删除前用全量 SHA-256 与组内保留文件复核，
						// 内容不一致的成员一律跳过，避免“前 64KB 相同”造成误删。
						if (!A_m_1(item2, item3, A, P_3, out string text5))
						{
							d2.A_4.Add(item3.A + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ah() + text5);
							w2.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jc(), item3.A, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jD(), text5);
							continue;
						}
						string key;
						try
						{
							key = Path.GetPathRoot(global::a.a.a_m_1(item3.A)) ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
						}
						catch
						{
							key = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
						}
						if (!dictionary.TryGetValue(key, out var value))
						{
							value = (dictionary[key] = Tuple.Create(g.A_m_1(item3.A, P_2, out var text), text ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()));
						}
						if (value.Item1 == F.B)
						{
							string text2 = (string.IsNullOrEmpty(value.Item2) ? Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jC()) : value.Item2);
							d2.A_4.Add(item3.A + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ah() + text2);
							w2.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jc(), item3.A, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jD(), text2);
							continue;
						}
						if (value.Item1 == F.a)
						{
							string text3 = A_m_1(item3.A);
							if (text3 == null)
							{
								w2.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jc(), item3.A, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jd(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jE() + item3.A_1 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.je() + item2.A);
								d2.a++;
								d2.A_3 += item3.A_1;
							}
							else
							{
								d2.A_4.Add(item3.A + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ah() + text3);
								w2.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jc(), item3.A, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jD(), text3);
							}
							continue;
						}
						global::b.H h2 = global::b.h.a_m_1(item3.A);
						if (h2.A)
						{
							w2.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jc(), item3.A, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.IK(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jF() + (h2.a ?? item3.A) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jf() + item3.A_1 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.je() + item2.A);
							d2.A_2++;
							d2.A_3 += item3.A_1;
						}
						else
						{
							d2.A_4.Add(item3.A + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ah() + (h2.A_1 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jG()));
							w2.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jc(), item3.A, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jD(), h2.A_1 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
						}
					}
				}
				d2.A = d2.A_2 + d2.a > 0;
				if (!d2.A && d2.A_1 == null)
				{
					d2.A_1 = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jg());
				}
				return d2;
			}
			catch (Exception ex)
			{
				d2.A_1 = ex.Message;
				return d2;
			}
			finally
			{
				w2?.Dispose();
			}
		}

		/// <summary>
		/// C-05 / C-03：全盘扫描结果的删除前内容复核。以组内不会被删除的文件为参照，
		/// 用全量 SHA-256 比对；内容不一致或复核失败时拒绝删除该成员。
		/// 快筛模式（只比对前 64KB）的分组会额外给出“未通过全量校验”的说明。
		/// </summary>
		private static bool A_m_1(c P_0, C P_1, Func<C, bool> P_2, CancellationToken P_4, out string P_3)
		{
			P_3 = null;
			if (P_0 == null || P_1 == null)
			{
				return true;
			}
			try
			{
				C c2 = null;
				foreach (C item in P_0.A_2)
				{
					if (item != null && !object.ReferenceEquals(item, P_1) && (P_2 == null || !P_2(item)) && File.Exists(global::a.a.A(item.A)))
					{
						c2 = item;
						break;
					}
				}
				if (c2 == null)
				{
					return true;
				}
				string text = global::a.k.A_m_1(c2.A, P_4);
				string text2 = global::a.k.A_m_1(P_1.A, P_4);
				if (!string.Equals(text, text2, StringComparison.OrdinalIgnoreCase))
				{
					P_3 = (P_0.b ? "快筛结果未通过全量校验（仅前 64KB 相同），已跳过删除；保留文件：" : "内容与保留文件不一致，已跳过删除；保留文件：") + c2.A;
					return false;
				}
				return true;
			}
			catch (Exception ex)
			{
				P_3 = "删除前内容复核失败，已跳过删除：" + P_1.A + "（" + ex.Message + "）";
				return false;
			}
		}

		internal static string A_m_1(string P_0)
		{
			try
			{
				string path = global::a.a.A(P_0);
				if (!File.Exists(path))
				{
					return Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jH());
				}
				FileAttributes attributes = File.GetAttributes(path);
				if ((attributes & FileAttributes.ReadOnly) != 0)
				{
					File.SetAttributes(path, attributes & ~FileAttributes.ReadOnly);
				}
				File.Delete(path);
				return File.Exists(path) ? Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jh()) : null;
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
	}
}
