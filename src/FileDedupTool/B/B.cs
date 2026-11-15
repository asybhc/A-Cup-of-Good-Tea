using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007B1262ED64_002DD0A6_002D499E_002D9510_002DF2240F018DBB_007D;
using A;
using B;
using a;
using b;
using c;

namespace B
{
	internal sealed class B : IDisposable
	{
		private sealed class A
		{
			internal string A_f_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

			internal string a;

			internal int A_f_2 = 200;
		}

		internal const string A_1 = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/147.0.0.0 Safari/537.36";

		internal const string a_1 = "https://accounts.woozooo.com/accounts.php?action=login&ref=up.woozooo.com";

		internal const string B_f_1 = "https://accounts.woozooo.com/accounts.php?action=login";

		internal const string b_1 = "https://accounts.woozooo.com/";

		internal const string C_1 = "https://api.ilanzou.com";

		internal const int A_2 = 30;

		internal const int a_2 = 10;

		private readonly HttpClient A_3;

		private readonly bool A_4;

		private static readonly int[] A_5 = new int[40]
		{
			15, 35, 29, 24, 33, 16, 1, 38, 10, 9,
			19, 31, 40, 27, 22, 23, 25, 13, 6, 11,
			39, 18, 20, 8, 14, 21, 32, 26, 2, 30,
			7, 4, 17, 5, 3, 28, 34, 37, 12, 36
		};

		private static readonly string c_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAy();

		internal B()
			: this(null)
		{
		}

		internal B(HttpMessageHandler P_0)
		{
			if (P_0 == null)
			{
				P_0 = new HttpClientHandler
				{
					AllowAutoRedirect = false,
					UseCookies = false,
					AutomaticDecompression = (DecompressionMethods.GZip | DecompressionMethods.Deflate)
				};
				A_4 = true;
			}
			A_3 = new HttpClient(P_0);
			A_3.Timeout = TimeSpan.FromSeconds(30.0);
		}

		public void Dispose()
		{
			if (A_4)
			{
				A_3.Dispose();
			}
		}

		internal async Task<global::B.A> A_m_1(string P_0, string P_1, CancellationToken P_2)
		{
			if (string.IsNullOrWhiteSpace(P_0) || string.IsNullOrWhiteSpace(P_1))
			{
				throw new global::a.v(global::a.V.C, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMX());
			}
			Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
			string text = A_m_1((await A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMx(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMY(), dictionary, P_2).ConfigureAwait(continueOnCapturedContext: false)).A_f_1);
			if (!string.IsNullOrEmpty(text))
			{
				dictionary[_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMy()] = a_m_1(text);
				_ = (await A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMx(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMY(), dictionary, P_2).ConfigureAwait(continueOnCapturedContext: false)).A_f_1;
			}
			string text2 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMZ() + Uri.EscapeDataString(P_0) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMz() + Uri.EscapeDataString(P_1) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amA() + Uri.EscapeDataString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ama());
			A a2 = await A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amB(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMx(), text2, dictionary, P_2).ConfigureAwait(continueOnCapturedContext: false);
			string a_f_ = a2.A_f_1;
			int num;
			string text3;
			string text4;
			try
			{
				using JsonDocument jsonDocument = JsonDocument.Parse(c_m_1(a_f_));
				num = A_m_1(jsonDocument.RootElement, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zU(), -999);
				text3 = A_m_1(jsonDocument.RootElement, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amb());
				text4 = A_m_1(jsonDocument.RootElement, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zv());
			}
			catch (Exception ex) when (!(ex is global::a.v))
			{
				throw new global::a.v(global::a.V.D, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amC() + a2.A_f_2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amc());
			}
			if (num != 1)
			{
				string text5 = ((!string.IsNullOrEmpty(text4)) ? text4 : (text3 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()));
				throw new global::a.v(global::a.V.D, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amD() + a2.A_f_2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ln() + ((text5.Length > 0) ? (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ah() + A_m_1(text5, 160)) : (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amd() + num + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ln())));
			}
			string text6 = text3;
			int num2 = 0;
			while (!string.IsNullOrEmpty(text6) && num2 < 10)
			{
				string text7 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amB(), text6);
				A a3 = await A_m_1(text7, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMx(), dictionary, P_2).ConfigureAwait(continueOnCapturedContext: false);
				num2++;
				if (!string.IsNullOrEmpty(a3.a))
				{
					text6 = a3.a;
					continue;
				}
				string text8 = C_m_1(a3.A_f_1);
				if (string.IsNullOrEmpty(text8))
				{
					break;
				}
				text6 = text8;
			}
			if (!dictionary.ContainsKey(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iV()) || !dictionary.ContainsKey(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iv()))
			{
				throw new global::a.v(global::a.V.a, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amE() + a2.A_f_2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ame());
			}
			return new global::B.A
			{
				Ylogin = dictionary[_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iV()],
				PhpdiskInfo = dictionary[_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iv()]
			};
		}

		internal async Task<global::B.A> a_m_1(string P_0, string P_1, CancellationToken P_2)
		{
			if (string.IsNullOrWhiteSpace(P_0) || string.IsNullOrWhiteSpace(P_1))
			{
				throw new global::a.v(global::a.V.C, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amF());
			}
			long num = DateTimeOffset.Now.ToUnixTimeMilliseconds();
			string text = Guid.NewGuid().ToString();
			string requestUri = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amf() + global::c.m.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(), text, num);
			string content = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amG() + D_m_1(P_0) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amg() + D_m_1(P_1) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amH();
			using HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
			A_m_1(httpRequestMessage);
			httpRequestMessage.Content = new StringContent(content, Encoding.UTF8, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aF());
			A a2 = await A_m_1(httpRequestMessage, P_2, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amh()).ConfigureAwait(continueOnCapturedContext: false);
			string text2;
			int num2;
			string text3;
			try
			{
				text2 = A_m_1(a2.A_f_1, out num2, out text3);
			}
			catch (Exception ex) when (!(ex is global::a.v))
			{
				throw new global::a.v(global::a.V.D, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amI() + a2.A_f_2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ami() + A_m_1(a2.A_f_1, 120));
			}
			if (string.IsNullOrEmpty(text2))
			{
				string text4 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amJ();
				if (num2 == -1 || num2 == -2 || num2 == 403)
				{
					text4 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amj();
				}
				throw new global::a.v(global::a.V.D, text4 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amK() + a2.A_f_2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amk() + num2 + (string.IsNullOrEmpty(text3) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D() : (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Q() + A_m_1(text3, 160))) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ln());
			}
			return new global::B.A
			{
				AppToken = text2,
				Uuid = text
			};
		}

		private void A_m_1(HttpRequestMessage P_0)
		{
			P_0.Headers.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAf(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAG());
			P_0.Headers.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAg(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAH());
			P_0.Headers.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAh(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAI());
			P_0.Headers.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAi(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAJ());
			P_0.Headers.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAj(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.it());
		}

		private void A_m_1(HttpRequestMessage P_0, string P_1)
		{
			P_0.Headers.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAf(), P_1);
			P_0.Headers.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAg(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAK());
			P_0.Headers.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAh(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAk());
			P_0.Headers.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAL(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAl());
			P_0.Headers.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAM(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAl());
			P_0.Headers.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAm(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CM());
			P_0.Headers.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAN(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CM());
			P_0.Headers.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAn(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAO());
			P_0.Headers.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAo(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAP());
			P_0.Headers.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAp(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAQ());
			P_0.Headers.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAq(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAR());
			P_0.Headers.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAr(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAS());
			P_0.Headers.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAs(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAT());
		}

		private static void A_m_1(HttpRequestMessage P_0, Dictionary<string, string> P_1)
		{
			if (P_1 == null || P_1.Count == 0)
			{
				return;
			}
			StringBuilder stringBuilder = new StringBuilder();
			foreach (KeyValuePair<string, string> item in P_1)
			{
				if (!string.IsNullOrEmpty(item.Key) && !string.IsNullOrEmpty(item.Value))
				{
					if (stringBuilder.Length > 0)
					{
						stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAD());
					}
					stringBuilder.Append(item.Key).Append('=').Append(item.Value);
				}
			}
			if (stringBuilder.Length > 0)
			{
				P_0.Headers.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAt(), stringBuilder.ToString());
			}
		}

		private async Task<A> A_m_1(string P_0, string P_1, Dictionary<string, string> P_2, CancellationToken P_3)
		{
			using HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, P_0);
			A_m_1(httpRequestMessage, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMW());
			if (!string.IsNullOrEmpty(P_1))
			{
				httpRequestMessage.Headers.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAj(), P_1);
			}
			A_m_1(httpRequestMessage, P_2);
			return await A_m_1(httpRequestMessage, P_2, P_3, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMw()).ConfigureAwait(continueOnCapturedContext: false);
		}

		private async Task<A> A_m_1(string P_0, string P_1, string P_2, Dictionary<string, string> P_3, CancellationToken P_4)
		{
			using HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, P_0);
			A_m_1(httpRequestMessage, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amL());
			if (!string.IsNullOrEmpty(P_1))
			{
				httpRequestMessage.Headers.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAj(), P_1);
			}
			httpRequestMessage.Headers.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAi(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aml());
			httpRequestMessage.Headers.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMS(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMs());
			A_m_1(httpRequestMessage, P_3);
			httpRequestMessage.Content = new StringContent(P_2, Encoding.UTF8, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amM());
			return await A_m_1(httpRequestMessage, P_3, P_4, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMw()).ConfigureAwait(continueOnCapturedContext: false);
		}

		private async Task<A> A_m_1(HttpRequestMessage P_0, Dictionary<string, string> P_1, CancellationToken P_2, string P_3)
		{
			A a2 = new A();
			HttpResponseMessage httpResponseMessage;
			try
			{
				httpResponseMessage = await A_3.SendAsync(P_0, HttpCompletionOption.ResponseContentRead, P_2).ConfigureAwait(continueOnCapturedContext: false);
			}
			catch (OperationCanceledException)
			{
				throw new global::a.v(global::a.V.B, P_3 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amN() + 30 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amn());
			}
			catch (Exception ex2)
			{
				throw new global::a.v(global::a.V.B, P_3 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amO() + ex2.Message);
			}
			using (httpResponseMessage)
			{
				int num = (a2.A_f_2 = (int)httpResponseMessage.StatusCode);
				A_m_1(httpResponseMessage, P_1);
				if (httpResponseMessage.Headers.Location != null)
				{
					a2.a = httpResponseMessage.Headers.Location.ToString();
				}
				if (num >= 300 && num < 400)
				{
					return a2;
				}
				string text;
				try
				{
					text = await httpResponseMessage.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);
				}
				catch (Exception ex3)
				{
					throw new global::a.v(global::a.V.B, P_3 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amo() + ex3.Message);
				}
				if (!httpResponseMessage.IsSuccessStatusCode)
				{
					string text2 = ((httpResponseMessage.StatusCode == HttpStatusCode.Forbidden) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amP() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
					throw new global::a.v(global::a.V.D, P_3 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amp() + (int)httpResponseMessage.StatusCode + text2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ah() + A_m_1(text, 120));
				}
				a2.A_f_1 = text;
				return a2;
			}
		}

		private async Task<A> A_m_1(HttpRequestMessage P_0, CancellationToken P_1, string P_2)
		{
			A a2 = await A_m_1(P_0, null, P_1, P_2).ConfigureAwait(continueOnCapturedContext: false);
			if (!string.IsNullOrEmpty(a2.a))
			{
				throw new global::a.v(global::a.V.D, P_2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amm() + a2.A_f_2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.IQ() + a2.a);
			}
			return a2;
		}

		internal static void A_m_1(HttpResponseMessage P_0, Dictionary<string, string> P_1)
		{
			if (P_0 == null || P_1 == null || !P_0.Headers.TryGetValues(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAU(), out IEnumerable<string> values))
			{
				return;
			}
			foreach (string item in values)
			{
				if (string.IsNullOrEmpty(item))
				{
					continue;
				}
				string text = item.Split(';')[0];
				int num = text.IndexOf('=');
				if (num > 0)
				{
					string text2 = text.Substring(0, num).Trim();
					string value = text.Substring(num + 1).Trim();
					if (text2.Length > 0)
					{
						P_1[text2] = value;
					}
				}
			}
		}

		internal static string A_m_1(string P_0)
		{
			if (string.IsNullOrEmpty(P_0))
			{
				return null;
			}
			Match match = Regex.Match(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAu(), RegexOptions.IgnoreCase);
			if (!match.Success)
			{
				return null;
			}
			StringBuilder stringBuilder = new StringBuilder();
			string value = match.Groups[1].Value;
			foreach (char c2 in value)
			{
				if ((c2 >= '0' && c2 <= '9') || (c2 >= 'a' && c2 <= 'f') || (c2 >= 'A' && c2 <= 'F'))
				{
					stringBuilder.Append(c2);
				}
			}
			if (stringBuilder.Length != 0)
			{
				return stringBuilder.ToString();
			}
			return null;
		}

		internal static string a_m_1(string P_0)
		{
			string text = P_0 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			if (text.IndexOf('<') >= 0 || text.IndexOf('=') >= 0)
			{
				text = A_m_1(text) ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}
			if (text.Length == 0)
			{
				return null;
			}
			return b_m_1(B_m_1(text));
		}

		internal static string B_m_1(string P_0)
		{
			string text = P_0 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			char[] array = new char[40];
			for (int num = 0; num < array.Length; num++)
			{
				array[num] = ' ';
			}
			for (int num2 = 0; num2 < text.Length; num2++)
			{
				for (int num3 = 0; num3 < A_5.Length; num3++)
				{
					if (A_5[num3] == num2 + 1)
					{
						array[num3] = text[num2];
						break;
					}
				}
			}
			return new string(array);
		}

		internal static string b_m_1(string P_0)
		{
			string text = P_0 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			StringBuilder stringBuilder = new StringBuilder(40);
			for (int num = 0; num + 1 < text.Length && num + 1 < c_1.Length; num += 2)
			{
				int num2 = A_m_1(text[num]);
				int num3 = A_m_1(text[num + 1]);
				int num4 = A_m_1(c_1[num]);
				int num5 = A_m_1(c_1[num + 1]);
				stringBuilder.Append(((num2 ^ num4) * 16 + (num3 ^ num5)).ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lp()));
			}
			return stringBuilder.ToString();
		}

		private static int A_m_1(char P_0)
		{
			if (P_0 >= '0' && P_0 <= '9')
			{
				return P_0 - 48;
			}
			if (P_0 >= 'a' && P_0 <= 'f')
			{
				return P_0 - 97 + 10;
			}
			if (P_0 >= 'A' && P_0 <= 'F')
			{
				return P_0 - 65 + 10;
			}
			return 0;
		}

		internal static string C_m_1(string P_0)
		{
			if (string.IsNullOrEmpty(P_0))
			{
				return null;
			}
			string[] array = new string[4]
			{
				_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAV(),
				_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAv(),
				_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAW(),
				_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAw()
			};
			foreach (string pattern in array)
			{
				Match match = Regex.Match(P_0, pattern, RegexOptions.IgnoreCase);
				if (match.Success)
				{
					return match.Groups[1].Value;
				}
			}
			return null;
		}

		internal static string A_m_1(string P_0, string P_1)
		{
			if (string.IsNullOrEmpty(P_1))
			{
				return P_0;
			}
			if (P_1.StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bb(), StringComparison.OrdinalIgnoreCase) || P_1.StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bC(), StringComparison.OrdinalIgnoreCase))
			{
				return P_1;
			}
			try
			{
				return new Uri(new Uri(P_0), P_1).ToString();
			}
			catch
			{
				return P_1;
			}
		}

		internal static string A_m_1(string P_0, out int P_1, out string P_2)
		{
			P_1 = -999;
			P_2 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			using JsonDocument jsonDocument = JsonDocument.Parse(c_m_1(P_0));
			JsonElement rootElement = jsonDocument.RootElement;
			P_1 = A_m_1(rootElement, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAX(), -999);
			P_2 = A_m_1(rootElement, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAx());
			if (string.IsNullOrEmpty(P_2))
			{
				P_2 = A_m_1(rootElement, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aj());
			}
			string result = A_m_1(rootElement, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iu());
			if (rootElement.TryGetProperty(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CE(), out var value) && value.ValueKind == JsonValueKind.Object)
			{
				string text = A_m_1(value, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iu());
				if (!string.IsNullOrEmpty(text))
				{
					result = text;
				}
			}
			return result;
		}

		internal static string c_m_1(string P_0)
		{
			if (string.IsNullOrEmpty(P_0))
			{
				return P_0;
			}
			int num = P_0.IndexOf('{');
			int num2 = P_0.LastIndexOf('}');
			if (num >= 0 && num2 > num)
			{
				return P_0.Substring(num, num2 - num + 1);
			}
			return P_0;
		}

		private static int A_m_1(JsonElement P_0, string P_1, int P_2)
		{
			if (!P_0.TryGetProperty(P_1, out var value))
			{
				return P_2;
			}
			if (value.ValueKind == JsonValueKind.Number)
			{
				return value.GetInt32();
			}
			if (value.ValueKind == JsonValueKind.String && int.TryParse(value.GetString(), out var result))
			{
				return result;
			}
			return P_2;
		}

		private static string A_m_1(JsonElement P_0, string P_1)
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
				return value.ToString();
			}
			return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
		}

		private static string D_m_1(string P_0)
		{
			return (P_0 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).Replace(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jb(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ji()).Replace(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JX(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAY());
		}

		internal static string A_m_1(string P_0, int P_1)
		{
			string text = (P_0 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).Replace(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bc(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aH()).Replace(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BD(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aH()).Trim();
			if (text.Length > P_1)
			{
				return text.Substring(0, P_1) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.j();
			}
			return text;
		}
	}
	internal sealed class b : Form
	{
		private readonly global::A.W A_1;

		private readonly global::b.Y A_2;

		private B A_3;

		private bool A_4;

		internal TextBox A_5;

		internal TextBox a;

		internal TextBox B;

		internal Button A_6;

		internal Button a_1;

		internal Button B_1;

		internal Button b_f_1;

		internal Label A_7;

		internal Label a_2;

		internal CheckBox A_8;

		[CompilerGenerated]
		private global::B.A A_9;

		private bool a_3;

		public global::B.A Result
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

		public b(global::A.W P_0, global::b.Y P_1)
		{
			A_1 = P_0 ?? global::A.w.A;
			A_2 = P_1 ?? global::b.Y.A_m_1();
			A_3 = new B();
			Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAZ() + A_1.DisplayName;
			Icon = global::A.R.App;
			Font = Q.A_m_1(10f);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(760, 540);
			MinimumSize = new Size(680, 500);
			BackColor = A_2.A;
			ForeColor = A_2.b;
			StartPosition = FormStartPosition.CenterParent;
			MaximizeBox = false;
			MinimizeBox = false;
			ShowInTaskbar = false;
			A_m_1();
			if (A_1.Id == global::A.v.a && global::A.T.IsTestBuild && global::A.T.A_m_1(out var text, out var text2))
			{
				A_5.Text = text;
				a.Text = text2;
				a_2.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAz());
				Shown += delegate
				{
					if (!a_3)
					{
						a_3 = true;
						A_m_1(null, EventArgs.Empty);
					}
				};
			}
			FormClosing += delegate
			{
				if (A_3 != null)
				{
					A_3.Dispose();
					A_3 = null;
				}
			};
		}

		private void A_m_1()
		{
			TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
			{
				Dock = DockStyle.Fill,
				ColumnCount = 1,
				RowCount = 6,
				Padding = new Padding(24, 20, 24, 18)
			};
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			Controls.Add(tableLayoutPanel);
			a_2 = new Label
			{
				AutoSize = true,
				MaximumSize = new Size(700, 0),
				ForeColor = A_2.I,
				Margin = new Padding(0, 0, 0, 12),
				Text = (A_1.Experimental ? global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Uo()) : global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Up()))
			};
			tableLayoutPanel.Controls.Add(a_2, 0, 0);
			tableLayoutPanel.Controls.Add(a_m_1(), 0, 1);
			tableLayoutPanel.Controls.Add(B_m_1(), 0, 2);
			A_7 = new Label
			{
				AutoSize = true,
				MaximumSize = new Size(700, 0),
				ForeColor = A_2.I,
				Margin = new Padding(0, 8, 0, 8),
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()
			};
			tableLayoutPanel.Controls.Add(A_7, 0, 3);
			FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel
			{
				AutoSize = true,
				Dock = DockStyle.Fill,
				FlowDirection = FlowDirection.LeftToRight,
				WrapContents = true
			};
			A_6 = B_m_1(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Uc()));
			A_6.Click += A_m_1;
			B_1 = a_m_1(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Uq()));
			B_1.Click += delegate
			{
				b_m_1();
			};
			flowLayoutPanel.Controls.Add(A_6);
			flowLayoutPanel.Controls.Add(B_1);
			tableLayoutPanel.Controls.Add(flowLayoutPanel, 0, 4);
			FlowLayoutPanel flowLayoutPanel2 = new FlowLayoutPanel
			{
				AutoSize = true,
				Dock = DockStyle.Fill,
				FlowDirection = FlowDirection.LeftToRight,
				WrapContents = true
			};
			a_1 = a_m_1(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aaA()));
			a_1.Click += a_m_1;
			b_f_1 = a_m_1(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BX()));
			b_f_1.Click += delegate
			{
				DialogResult = DialogResult.Cancel;
				Close();
			};
			flowLayoutPanel2.Controls.Add(a_1);
			flowLayoutPanel2.Controls.Add(b_f_1);
			tableLayoutPanel.Controls.Add(flowLayoutPanel2, 0, 5);
		}

		private Control a_m_1()
		{
			GroupBox groupBox = new GroupBox
			{
				Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ui()),
				Dock = DockStyle.Top,
				AutoSize = true,
				ForeColor = A_2.b,
				Padding = new Padding(12, 10, 12, 12),
				Margin = new Padding(0, 0, 0, 10)
			};
			TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
			{
				Dock = DockStyle.Top,
				AutoSize = true,
				ColumnCount = 2,
				RowCount = 2
			};
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 88f));
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel.Controls.Add(A_m_1(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Uj())), 0, 0);
			A_5 = A_m_1(false);
			tableLayoutPanel.Controls.Add(A_5, 1, 0);
			tableLayoutPanel.Controls.Add(A_m_1(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Uk())), 0, 1);
			a = A_m_1(true);
			tableLayoutPanel.Controls.Add(a, 1, 1);
			groupBox.Controls.Add(tableLayoutPanel);
			return groupBox;
		}

		private Control B_m_1()
		{
			GroupBox groupBox = new GroupBox
			{
				Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ul()),
				Dock = DockStyle.Fill,
				ForeColor = A_2.b,
				Padding = new Padding(12, 10, 12, 12),
				Margin = new Padding(0, 0, 0, 6)
			};
			TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
			{
				Dock = DockStyle.Fill,
				ColumnCount = 1,
				RowCount = 4
			};
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			Label control = new Label
			{
				AutoSize = true,
				MaximumSize = new Size(660, 0),
				ForeColor = A_2.I,
				Text = ((A_1.Id == global::A.v.a) ? global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Uz()) : global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Um())),
				Margin = new Padding(0, 0, 0, 6)
			};
			tableLayoutPanel.Controls.Add(control, 0, 0);
			B = new TextBox
			{
				Dock = DockStyle.Fill,
				Multiline = true,
				ScrollBars = ScrollBars.Vertical,
				Height = 130,
				BackColor = A_2.c,
				ForeColor = A_2.D,
				BorderStyle = BorderStyle.FixedSingle,
				Font = Q.A_m_1(9.5f),
				Margin = new Padding(0, 0, 0, 6)
			};
			tableLayoutPanel.Controls.Add(B, 0, 1);
			A_8 = new CheckBox
			{
				AutoSize = true,
				Visible = (A_1.Id == global::A.v.a),
				ForeColor = A_2.b,
				Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Uv()),
				Margin = new Padding(0, 0, 0, 4)
			};
			tableLayoutPanel.Controls.Add(A_8, 0, 2);
			Label control2 = new Label
			{
				AutoSize = true,
				MaximumSize = new Size(660, 0),
				ForeColor = A_2.I,
				Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Uw())
			};
			tableLayoutPanel.Controls.Add(control2, 0, 3);
			groupBox.Controls.Add(tableLayoutPanel);
			return groupBox;
		}

		private Label A_m_1(string P_0)
		{
			return new Label
			{
				AutoSize = true,
				Text = P_0,
				ForeColor = A_2.b,
				Margin = new Padding(0, 6, 8, 6)
			};
		}

		private TextBox A_m_1(bool P_0)
		{
			TextBox textBox = new TextBox
			{
				Dock = DockStyle.Top,
				BackColor = A_2.c,
				ForeColor = A_2.D,
				BorderStyle = BorderStyle.FixedSingle,
				Font = Q.A_m_1(10f),
				Margin = new Padding(0, 4, 0, 4)
			};
			if (P_0)
			{
				textBox.UseSystemPasswordChar = true;
			}
			return textBox;
		}

		private Button a_m_1(string P_0)
		{
			Button button = new Button();
			button.Text = P_0;
			button.AutoSize = true;
			button.MinimumSize = new Size(0, 34);
			button.Padding = new Padding(12, 4, 12, 4);
			button.BackColor = A_2.E;
			button.ForeColor = A_2.e;
			button.FlatStyle = FlatStyle.Flat;
			button.Margin = new Padding(0, 4, 10, 0);
			button.FlatAppearance.BorderColor = A_2.B;
			return button;
		}

		private Button B_m_1(string P_0)
		{
			Button button = a_m_1(P_0);
			button.BackColor = A_2.f;
			button.ForeColor = A_2.G;
			button.FlatAppearance.BorderColor = A_2.f;
			return button;
		}

		private void A_m_1(bool P_0, string P_1)
		{
			A_4 = P_0;
			A_5.Enabled = !P_0;
			a.Enabled = !P_0;
			B.Enabled = !P_0;
			A_6.Enabled = !P_0;
			a_1.Enabled = !P_0;
			B_1.Enabled = !P_0;
			b_f_1.Enabled = !P_0;
			if (P_1 != null)
			{
				A_7.Text = P_1;
				A_7.ForeColor = A_2.I;
			}
		}

		private async void A_m_1(object P_0, EventArgs P_1)
		{
			if (A_4)
			{
				return;
			}
			string text = A_5.Text.Trim();
			string text2 = a.Text;
			if (text.Length == 0 || text2.Length == 0)
			{
				b_m_1(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Uh()));
				return;
			}
			A_m_1(true, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ug()));
			try
			{
				global::B.A a2 = ((A_1.Id != global::A.v.a) ? (await A_3.A_m_1(text, text2, CancellationToken.None)) : (await A_3.a_m_1(text, text2, CancellationToken.None)));
				global::B.A a3 = a2;
				if (a3 == null || !a3.A_m_1(A_1))
				{
					throw new global::a.v(global::a.V.a, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ur()));
				}
				A_5.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
				a.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
				Result = a3;
				A_7.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amQ());
				A_7.ForeColor = A_2.j;
				DialogResult = DialogResult.OK;
				Close();
			}
			catch (global::a.v v2)
			{
				b_m_1(v2.Message);
			}
			catch (Exception ex)
			{
				b_m_1(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Us()) + ex.Message);
			}
			finally
			{
				if (!IsDisposed)
				{
					A_m_1(false, null);
				}
			}
		}

		private void a_m_1(object P_0, EventArgs P_1)
		{
			if (A_4)
			{
				return;
			}
			string text = B.Text.Trim();
			if (text.Length == 0)
			{
				b_m_1(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ut()));
				return;
			}
			global::B.A a2 = null;
			if (A_1.Id == global::A.v.a && A_8.Checked)
			{
				string text2 = text;
				if (text2.StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iW(), StringComparison.OrdinalIgnoreCase))
				{
					text2 = text2.Substring(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iW().Length);
				}
				text2 = text2.Trim().Trim('"', '\'', ';', ',');
				if (text2.Length == 0 || text2.Contains(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAc()))
				{
					b_m_1(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ux()));
					return;
				}
				a2 = new global::B.A
				{
					AppToken = text2,
					Extra = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iW() + text2
				};
			}
			else
			{
				a2 = global::a.z.A(A_1, text);
			}
			if (a2 == null || !a2.A_m_1(A_1))
			{
				b_m_1((A_1.Id == global::A.v.a) ? global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Uy()) : global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ua()));
				return;
			}
			Result = a2;
			B.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			DialogResult = DialogResult.OK;
			Close();
		}

		private void b_m_1(string P_0)
		{
			A_7.Text = P_0;
			A_7.ForeColor = A_2.J;
		}

		private void b_m_1()
		{
			try
			{
				Process.Start(new ProcessStartInfo
				{
					FileName = A_1.LoginUrl,
					UseShellExecute = true
				});
			}
			catch (Exception ex)
			{
				b_m_1(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ub()) + ex.Message);
			}
		}

		[CompilerGenerated]
		private void B_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			if (!a_3)
			{
				a_3 = true;
				A_m_1(null, EventArgs.Empty);
			}
		}

		[CompilerGenerated]
		private void A_m_1(object? _003Cp0_003E, FormClosingEventArgs P_1)
		{
			if (A_3 != null)
			{
				A_3.Dispose();
				A_3 = null;
			}
		}

		[CompilerGenerated]
		private void b_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			b_m_1();
		}

		[CompilerGenerated]
		private void C(object? _003Cp0_003E, EventArgs P_1)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
namespace b
{
	public sealed class B
	{
		public int A;

		public int a;

		public int B_f_1;

		public int b;

		public int C;

		public int c;

		public int D;

		public int d;

		public int E;

		public long A_1;

		public int e;

		public long a_1;

		public bool A_2;

		public bool a_2;

		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agZ(), A_2 ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agz() : (a_2 ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.IE() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Id()), a, B_f_1, b, C, c);
			if (d > 0)
			{
				stringBuilder.AppendFormat(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHA(), d, global::b.a.A_m_1(A_1));
			}
			if (E > 0)
			{
				stringBuilder.AppendFormat(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHa(), E);
			}
			if (A_2)
			{
				stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHB());
			}
			return stringBuilder.ToString();
		}

		public string A_m_1()
		{
			if (!global::a.Q.EnMode)
			{
				return ToString();
			}
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHb(), A_2 ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHD() : (a_2 ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHc() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHC()), a, B_f_1, b, C, c);
			if (d > 0)
			{
				stringBuilder.AppendFormat(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHd(), d, global::b.a.A_m_1(A_1));
			}
			if (E > 0)
			{
				stringBuilder.AppendFormat(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHE(), E);
			}
			if (A_2)
			{
				stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHe());
			}
			return stringBuilder.ToString();
		}
	}
	public static class b
	{
		private static readonly HashSet<string> A = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
		{
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ef(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.EG(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.EI(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ei(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Eg(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Eh(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.EH(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.EJ()
		};

		private static readonly HashSet<string> a = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
		{
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.eT(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.eU(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ew(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahJ(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.eY()
		};

		public const string A_1 = "未知时间";

		public static string A_m_1(global::B.x P_0)
		{
			return P_0 switch
			{
				global::B.x.a => _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.RX(), 
				global::B.x.B => _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.RY(), 
				global::B.x.b => _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.RZ(), 
				_ => _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.RW(), 
			};
		}

		public static string a_m_1(global::B.x P_0)
		{
			return P_0 switch
			{
				global::B.x.a => _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHF(), 
				global::B.x.B => _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHf(), 
				global::B.x.b => _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHG(), 
				_ => _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHg(), 
			};
		}

		public static bool A_m_1(string P_0, out global::B.x P_1)
		{
			P_1 = global::B.x.A;
			if (string.IsNullOrWhiteSpace(P_0))
			{
				return false;
			}
			string text = P_0.Trim().ToLowerInvariant();
			if (text != null)
			{
				switch (text.Length)
				{
				case 1:
				{
					char c2 = text[0];
					if ((uint)c2 <= 24180u)
					{
						if (c2 == '周')
						{
							goto IL_015e;
						}
						if (c2 != '年')
						{
							break;
						}
						goto IL_0168;
					}
					if (c2 == '日')
					{
						goto IL_0159;
					}
					if (c2 != '月')
					{
						break;
					}
					goto IL_0163;
				}
				case 2:
				{
					char c2 = text[1];
					if ((uint)c2 <= 24180u)
					{
						if (c2 != '周')
						{
							if (c2 != '年' || !(text == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.RZ()))
							{
								break;
							}
							goto IL_0168;
						}
						if (!(text == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.RX()))
						{
							break;
						}
						goto IL_015e;
					}
					if (c2 != '日')
					{
						if (c2 != '月' || !(text == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.RY()))
						{
							break;
						}
						goto IL_0163;
					}
					if (!(text == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.RW()))
					{
						break;
					}
					goto IL_0159;
				}
				case 4:
				{
					char c2 = text[0];
					if (c2 != 'w')
					{
						if (c2 != 'y' || !(text == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHG()))
						{
							break;
						}
						goto IL_0168;
					}
					if (!(text == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHF()))
					{
						break;
					}
					goto IL_015e;
				}
				case 3:
					if (!(text == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHg()))
					{
						break;
					}
					goto IL_0159;
				case 5:
					{
						if (!(text == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHf()))
						{
							break;
						}
						goto IL_0163;
					}
					IL_0159:
					P_1 = global::B.x.A;
					return true;
					IL_015e:
					P_1 = global::B.x.a;
					return true;
					IL_0163:
					P_1 = global::B.x.B;
					return true;
					IL_0168:
					P_1 = global::B.x.b;
					return true;
				}
			}
			return false;
		}

		public static string A_m_1(DateTime? P_0, global::B.x P_1)
		{
			if (!P_0.HasValue || !A_m_1(P_0.Value))
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHH();
			}
			DateTime value = P_0.Value;
			switch (P_1)
			{
			case global::B.x.b:
				return value.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHh(), CultureInfo.InvariantCulture);
			case global::B.x.B:
				return value.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHh(), CultureInfo.InvariantCulture) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aA() + value.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHI(), CultureInfo.InvariantCulture);
			case global::B.x.a:
			{
				int year = ISOWeek.GetYear(value);
				int weekOfYear = ISOWeek.GetWeekOfYear(value);
				string text = year.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHi(), CultureInfo.InvariantCulture);
				return text + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aA() + text + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHJ() + weekOfYear.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHj(), CultureInfo.InvariantCulture);
			}
			default:
				return value.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHh(), CultureInfo.InvariantCulture) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aA() + value.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHI(), CultureInfo.InvariantCulture) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aA() + value.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CL(), CultureInfo.InvariantCulture);
			}
		}

		public static string A_m_1(global::B.Z P_0)
		{
			return P_0 switch
			{
				global::B.Z.A => _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHK(), 
				global::B.Z.a => _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHk(), 
				global::B.Z.B => _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHL(), 
				global::B.Z.b => _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHl(), 
				_ => _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHH(), 
			};
		}

		public static bool A_m_1(DateTime P_0)
		{
			if (P_0.Year >= 1900)
			{
				return P_0.Year <= 2100;
			}
			return false;
		}

		public static global::B.Z A_m_1(DateTime? P_0, DateTime? P_1, DateTime? P_2, DateTime? P_3, out DateTime? P_4)
		{
			if (P_0.HasValue && A_m_1(P_0.Value))
			{
				P_4 = P_0;
				return global::B.Z.A;
			}
			if (P_1.HasValue && A_m_1(P_1.Value))
			{
				P_4 = P_1;
				return global::B.Z.a;
			}
			if (P_2.HasValue && A_m_1(P_2.Value))
			{
				P_4 = P_2;
				return global::B.Z.B;
			}
			if (P_3.HasValue && A_m_1(P_3.Value))
			{
				P_4 = P_3;
				return global::B.Z.b;
			}
			P_4 = null;
			return global::B.Z.C;
		}

		public static global::B.Z A_m_1(string P_0, out DateTime? P_1)
		{
			string text = Path.GetExtension(P_0) ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			text = text.TrimStart('.').ToLowerInvariant();
			DateTime? dateTime = null;
			if (A.Contains(text))
			{
				dateTime = A_m_1(P_0);
			}
			DateTime? dateTime2 = null;
			if (a.Contains(text))
			{
				dateTime2 = a_m_1(P_0);
			}
			DateTime? dateTime3 = A_m_1(P_0, false);
			DateTime? dateTime4 = A_m_1(P_0, true);
			return A_m_1(dateTime, dateTime2, dateTime3, dateTime4, out P_1);
		}

		private static DateTime? A_m_1(string P_0, bool P_1)
		{
			try
			{
				DateTime dateTime = (P_1 ? File.GetCreationTime(global::a.a.A(P_0)) : File.GetLastWriteTime(global::a.a.A(P_0)));
				return A_m_1(dateTime) ? new DateTime?(dateTime) : ((DateTime?)null);
			}
			catch
			{
				return null;
			}
		}

		public static DateTime? A_m_1(string P_0)
		{
			try
			{
				using FileStream stream = new FileStream(global::a.a.A(P_0), FileMode.Open, FileAccess.Read, FileShare.Read);
				using Image image = Image.FromStream(stream, useEmbeddedColorManagement: false, validateImageData: false);
				int[] array = new int[3] { 36867, 36868, 306 };
				PropertyItem[] propertyItems = image.PropertyItems;
				int[] array2 = array;
				foreach (int num2 in array2)
				{
					PropertyItem[] array3 = propertyItems;
					foreach (PropertyItem propertyItem in array3)
					{
						if (propertyItem.Id == num2 && propertyItem.Value != null)
						{
							DateTime dateTime = A_m_1(propertyItem.Value);
							if (A_m_1(dateTime))
							{
								return dateTime;
							}
						}
					}
				}
			}
			catch
			{
			}
			return null;
		}

		private static DateTime A_m_1(byte[] P_0)
		{
			string text = Encoding.ASCII.GetString(P_0).Trim('\0', ' ', '\r', '\n');
			string[] formats = new string[4]
			{
				_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHM(),
				_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CI(),
				_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHm(),
				_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CL()
			};
			if (DateTime.TryParseExact(text, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out var result))
			{
				return result;
			}
			if (DateTime.TryParse(text, CultureInfo.InvariantCulture, DateTimeStyles.None, out result))
			{
				return result;
			}
			return DateTime.MinValue;
		}

		public static DateTime? a_m_1(string P_0)
		{
			try
			{
				using FileStream fileStream = new FileStream(global::a.a.A(P_0), FileMode.Open, FileAccess.Read, FileShare.Read);
				long length = fileStream.Length;
				long num = 0L;
				for (int num2 = 0; num2 < 64; num2++)
				{
					if (num + 8 > length)
					{
						break;
					}
					fileStream.Position = num;
					long num3 = A_m_1(fileStream);
					string text = B(fileStream);
					long num4 = 8L;
					switch (num3)
					{
					case 1L:
						if (num + 16 <= length)
						{
							num3 = a_m_1(fileStream);
							num4 = 16L;
							break;
						}
						goto end_IL_01a1;
					case 0L:
						num3 = length - num;
						break;
					}
					if (num3 < num4 || num + num3 > length)
					{
						break;
					}
					if (text == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHN())
					{
						long num5 = num + num3;
						long num6 = num + num4;
						for (int num7 = 0; num7 < 64; num7++)
						{
							if (num6 + 8 > num5)
							{
								break;
							}
							fileStream.Position = num6;
							long num8 = A_m_1(fileStream);
							string text2 = B(fileStream);
							if (num8 < 8 || num6 + num8 > num5)
							{
								break;
							}
							if (text2 == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHn())
							{
								fileStream.Position = num6 + 8;
								byte b2 = (byte)fileStream.ReadByte();
								fileStream.Position = num6 + 8 + 4;
								long num9 = ((b2 == 1) ? a_m_1(fileStream) : A_m_1(fileStream));
								if (num9 <= 0)
								{
									return null;
								}
								DateTime dateTime = new DateTime(1904, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(num9).ToLocalTime();
								return A_m_1(dateTime) ? new DateTime?(dateTime) : ((DateTime?)null);
							}
							num6 += num8;
						}
						return null;
					}
					num += num3;
					continue;
					end_IL_01a1:
					break;
				}
			}
			catch
			{
			}
			return null;
		}

		private static long A_m_1(FileStream P_0)
		{
			byte[] array = new byte[4];
			if (P_0.Read(array, 0, 4) < 4)
			{
				return 0L;
			}
			return (long)(((ulong)array[0] << 24) | ((ulong)array[1] << 16) | ((ulong)array[2] << 8) | array[3]);
		}

		private static long a_m_1(FileStream P_0)
		{
			byte[] array = new byte[8];
			if (P_0.Read(array, 0, 8) < 8)
			{
				return 0L;
			}
			long num = (long)(((ulong)array[0] << 24) | ((ulong)array[1] << 16) | ((ulong)array[2] << 8) | array[3]);
			long num2 = (long)(((ulong)array[4] << 24) | ((ulong)array[5] << 16) | ((ulong)array[6] << 8) | array[7]);
			if (num < 0 || num2 < 0)
			{
				return 0L;
			}
			return (num << 32) | num2;
		}

		private static string B(FileStream P_0)
		{
			byte[] array = new byte[4];
			if (P_0.Read(array, 0, 4) < 4)
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}
			return new string(new char[4]
			{
				(char)array[0],
				(char)array[1],
				(char)array[2],
				(char)array[3]
			});
		}

		public static bool A_m_1(global::B.z P_0, out string P_1)
		{
			P_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			if (P_0 == null)
			{
				P_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHO();
				return false;
			}
			string text = (P_0.A ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).Trim().Trim('"');
			string text2 = (P_0.a ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).Trim().Trim('"');
			if (text.Length == 0 || !Directory.Exists(global::a.a.A(text)))
			{
				P_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.hl() + text;
				return false;
			}
			if (text2.Length == 0)
			{
				P_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHo();
				return false;
			}
			string fullPath;
			try
			{
				fullPath = Path.GetFullPath(text);
			}
			catch
			{
				P_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.hm() + text;
				return false;
			}
			string fullPath2;
			try
			{
				fullPath2 = Path.GetFullPath(text2);
			}
			catch
			{
				P_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.hp() + text2;
				return false;
			}
			string pathRoot = Path.GetPathRoot(fullPath);
			if (!string.IsNullOrEmpty(pathRoot) && string.Equals(fullPath.TrimEnd('\\'), pathRoot.TrimEnd('\\'), StringComparison.OrdinalIgnoreCase))
			{
				P_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHP() + text;
				return false;
			}
			if (string.Equals(fullPath.TrimEnd('\\'), fullPath2.TrimEnd('\\'), StringComparison.OrdinalIgnoreCase))
			{
				P_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.hq();
				return false;
			}
			if (global::a.a.A(fullPath2, fullPath, false))
			{
				P_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.hS() + text2;
				return false;
			}
			return true;
		}

		public static a A_m_1(global::B.z P_0, CancellationToken P_1, Action<string, int, int, string> P_2)
		{
			a a2 = new a
			{
				A_1 = P_0.A,
				a_f_1 = P_0.a,
				A_2 = P_0.A_1,
				A_3 = P_0.A_2,
				A_4 = P_0.A_3,
				A_5 = P_0.A_4
			};
			if (!A_m_1(P_0, out var item))
			{
				a2.A_7.Add(item);
				return a2;
			}
			P_2?.Invoke(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHp(), 0, 0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHQ());
			List<string> list = e.B_m_1(Path.GetFullPath(P_0.A));
			list.Sort(StringComparer.OrdinalIgnoreCase);
			string fullPath = Path.GetFullPath(P_0.a);
			Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
			Dictionary<string, Dictionary<string, string>> dictionary4 = new Dictionary<string, Dictionary<string, string>>(StringComparer.OrdinalIgnoreCase);
			int arg = Math.Max(1, list.Count);
			int num = 0;
			foreach (string item2 in list)
			{
				if (P_1.IsCancellationRequested)
				{
					break;
				}
				global::B.Z a_f_ = A_m_1(item2, out DateTime? dateTime);
				A a3 = new A
				{
					A_f_1 = item2,
					A_f_2 = b_m_1(item2),
					A_f_3 = dateTime,
					A_f_4 = a_f_,
					a = A_m_1(dateTime, P_0.A_1)
				};
				a3.b = A_m_1(fullPath, a3.a, global::B.R.g_m_1(Path.GetFileName(item2)));
				a3.B = a3.b;
				a3.b_1 = global::B.R.H_m_1(Path.GetFileName(item2));
				switch (P_0.A_3)
				{
				case global::B.y.B:
					a3.A_f_5 = A_m_1(a3.b, dictionary, dictionary2, dictionary3, dictionary4) != null;
					a3.C_1 = a3.A_f_5;
					if (!a3.C_1)
					{
						A_m_1(a3, dictionary, dictionary2, dictionary3);
					}
					break;
				case global::B.y.a:
					a3.A_f_5 = A_m_1(a3.b, dictionary, dictionary2, dictionary3, dictionary4) != null;
					A_m_1(a3, dictionary);
					A_m_1(a3, dictionary, dictionary2, dictionary3);
					break;
				default:
				{
					string text = A_m_1(a3.b, dictionary, dictionary2, dictionary3, dictionary4, out var value);
					if (text == null)
					{
						A_m_1(a3, dictionary, dictionary2, dictionary3);
						break;
					}
					a3.A_f_5 = true;
					a3.C = text;
					bool flag = A_m_1(item2, a3.A_f_2, text, out var text2);
					a3.c = text2;
					if (flag)
					{
						a3.a_1 = true;
						if (!string.IsNullOrEmpty(value))
						{
							a3.B = value;
						}
						break;
					}
					if (File.Exists(global::a.a.A(a3.b)) || dictionary.ContainsKey(a3.b))
					{
						a3.B = A_m_1(a3.b, dictionary);
						a3.B_1 = true;
					}
					A_m_1(a3, dictionary, dictionary2, dictionary3);
					break;
				}
				}
				a2.A_6.Add(a3);
				P_2?.Invoke(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHp(), ++num, arg, Path.GetFileName(item2));
			}
			P_2?.Invoke(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Qs(), num, list.Count, a2.a_m_1());
			return a2;
		}

		internal static void A_m_1(A P_0, IDictionary<string, string> P_1)
		{
			string path = (P_0.B = (string.IsNullOrEmpty(P_0.b) ? P_0.B : P_0.b));
			string path2 = Path.GetDirectoryName(path) ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(path);
			string extension = Path.GetExtension(path);
			int num = 0;
			while (File.Exists(global::a.a.A(P_0.B)) || P_1.ContainsKey(P_0.B))
			{
				num++;
				P_0.B = Path.Combine(path2, fileNameWithoutExtension + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JL() + num + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.R() + extension);
				if (num > 9998)
				{
					break;
				}
			}
			P_0.B_1 = num > 0;
		}

		private static void A_m_1(A P_0, IDictionary<string, string> P_1, IDictionary<string, string> P_2, IDictionary<string, string> P_3)
		{
			P_1[P_0.B] = P_0.A_f_1;
			string key = B(P_0.B);
			P_2[key] = P_0.A_f_1;
			P_3[key] = P_0.B;
		}

		internal static string B(string P_0)
		{
			string text = Path.GetDirectoryName(P_0) ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(P_0);
			string text2 = Path.GetExtension(P_0).ToLowerInvariant();
			return (text + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHq() + global::B.R.G_m_1(fileNameWithoutExtension) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHq() + text2).ToLowerInvariant();
		}

		private static string A_m_1(string P_0, IDictionary<string, string> P_1, IDictionary<string, string> P_2, IDictionary<string, string> P_3, IDictionary<string, Dictionary<string, string>> P_4, out string P_5)
		{
			P_5 = P_0;
			if (File.Exists(global::a.a.A(P_0)))
			{
				return P_0;
			}
			if (P_1.TryGetValue(P_0, out var value))
			{
				return value;
			}
			string key = B(P_0);
			if (P_2.TryGetValue(key, out value))
			{
				P_5 = (P_3.TryGetValue(key, out P_5) ? P_5 : P_0);
				return value;
			}
			string text = Path.GetDirectoryName(P_0) ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			if (Directory.Exists(global::a.a.A(text)))
			{
				if (!P_4.TryGetValue(text, out var value2))
				{
					value2 = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
					try
					{
						foreach (string item in Directory.EnumerateFiles(global::a.a.A(text)))
						{
							string text2 = global::a.a.a_m_1(item);
							string key2 = B(text2);
							if (!value2.ContainsKey(key2))
							{
								value2[key2] = text2;
							}
						}
					}
					catch
					{
					}
					P_4[text] = value2;
				}
				if (value2.TryGetValue(key, out value))
				{
					P_5 = value;
					return value;
				}
			}
			return null;
		}

		private static string A_m_1(string P_0, IDictionary<string, string> P_1, IDictionary<string, string> P_2, IDictionary<string, string> P_3, IDictionary<string, Dictionary<string, string>> P_4)
		{
			string text;
			return A_m_1(P_0, P_1, P_2, P_3, P_4, out text);
		}

		private static string A_m_1(string P_0, IDictionary<string, string> P_1)
		{
			string path = Path.GetDirectoryName(P_0) ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(P_0);
			string extension = Path.GetExtension(P_0);
			for (int num = 1; num < 9999; num++)
			{
				string text = Path.Combine(path, fileNameWithoutExtension + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JL() + num + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.R() + extension);
				if (!File.Exists(global::a.a.A(text)) && !P_1.ContainsKey(text))
				{
					return text;
				}
			}
			return Path.Combine(path, fileNameWithoutExtension + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JL() + Guid.NewGuid().ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.cL()).Substring(0, 6) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.R() + extension);
		}

		private static bool A_m_1(string P_0, long P_1, string P_2, out string P_3)
		{
			P_3 = null;
			long num = b_m_1(P_2);
			if (P_1 != num)
			{
				return false;
			}
			try
			{
				P_3 = global::a.k.a(P_0);
				string text = global::a.k.a(P_2);
				return string.Equals(P_3, text, StringComparison.OrdinalIgnoreCase);
			}
			catch
			{
				return false;
			}
		}

		private static string A_m_1(string P_0, string P_1, string P_2)
		{
			string path = P_0;
			string[] array = P_1.Split('/');
			foreach (string text in array)
			{
				if (text.Length > 0)
				{
					path = Path.Combine(path, text);
				}
			}
			return Path.Combine(path, P_2);
		}

		private static long b_m_1(string P_0)
		{
			try
			{
				return new FileInfo(global::a.a.A(P_0)).Length;
			}
			catch
			{
				return 0L;
			}
		}

		internal static string A_m_1(A P_0)
		{
			if (P_0 == null || !P_0.b_1)
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}
			string? fileNameWithoutExtension = Path.GetFileNameWithoutExtension(P_0.A_f_1);
			string fileNameWithoutExtension2 = Path.GetFileNameWithoutExtension(P_0.B);
			if (string.Equals(fileNameWithoutExtension, fileNameWithoutExtension2, StringComparison.Ordinal))
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}
			return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHR() + Path.GetFileName(P_0.A_f_1) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHr() + Path.GetFileName(P_0.B);
		}

		public static B A_m_1(global::B.z P_0, a P_1, CancellationToken P_2, Action<string, int, int, string> P_3, out string P_4)
		{
			B b2 = new B
			{
				A = (P_1?.FileCount ?? 0),
				A_2 = P_0.A_4,
				a_2 = (P_0.A_2 == global::B.Y.a),
				C = (P_1?.RenameCount ?? 0),
				c = (P_1?.UnknownCount ?? 0),
				D = (P_1?.ConflictCount ?? 0),
				a_1 = (P_1?.TotalBytes ?? 0)
			};
			P_4 = null;
			if (P_1 == null)
			{
				return b2;
			}
			try
			{
				global::a.j.C_m_1();
			}
			catch (global::a.J j2)
			{
				global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agi(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHS(), P_1.a_f_1, j2.Message, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf());
				return b2;
			}
			global::B.w w2 = new global::B.w(P_0.A_4);
			P_4 = w2.FilePath;
			try
			{
				global::B.p.A_m_1(new string('#', 56));
				global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHs() + DateTime.Now.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CI()) + (P_0.A_4 ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHT() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()));
				global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHt() + P_0.A + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHU() + P_0.a + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHu() + A_m_1(P_0.A_1) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHV() + ((P_0.A_2 == global::B.Y.a) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.IE() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Id()));
				global::B.p.A_m_1(P_1.a_m_1());
				int arg = Math.Max(1, P_1.A_6.Count);
				int num = 0;
				foreach (A item in P_1.A_6)
				{
					if (P_2.IsCancellationRequested)
					{
						break;
					}
					P_3?.Invoke(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agJ(), ++num, arg, Path.GetFileName(item.A_f_1));
					if (item.C_1 || !File.Exists(global::a.a.A(item.A_f_1)))
					{
						item.d = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBF();
						item.E = ((!File.Exists(global::a.a.A(item.A_f_1))) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHW() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHv());
						b2.b++;
						w2.A_m_1((P_0.A_2 == global::B.Y.a) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGM() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGN(), item.A_f_1, item.B, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aeY());
						global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agi(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agJ(), item.A_f_1, item.E, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ip());
						continue;
					}
					bool flag = false;
					string text = null;
					if (P_0.A_3 == global::B.y.A)
					{
						string text2 = null;
						if (File.Exists(global::a.a.A(item.B)) && !item.a_1)
						{
							text2 = item.B;
						}
						else if (item.a_1)
						{
							text2 = (File.Exists(global::a.a.A(item.B)) ? item.B : null);
						}
						if (text2 == null && File.Exists(global::a.a.A(item.b)))
						{
							text2 = item.b;
						}
						if (text2 != null)
						{
							item.A_f_5 = true;
							long num2 = (item.A_f_2 = b_m_1(item.A_f_1));
							bool flag2 = A_m_1(item.A_f_1, num2, text2, out var text3);
							item.c = text3;
							if (flag2)
							{
								flag = true;
								text = text2;
								item.a_1 = true;
								item.C = text2;
								item.B = text2;
								item.B_1 = false;
							}
							else
							{
								item.a_1 = false;
								item.B_1 = false;
								item.B = A_m_1(item.b, new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase));
								item.B_1 = !string.Equals(item.B, item.b, StringComparison.OrdinalIgnoreCase);
							}
						}
						else
						{
							item.a_1 = false;
							item.C = null;
							if (item.B_1 && !File.Exists(global::a.a.A(item.B)))
							{
								item.B = item.b;
							}
						}
					}
					if (flag)
					{
						string text4 = A_m_1(item, text);
						if (P_0.A_2 == global::B.Y.a)
						{
							item.d = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBF();
							item.E = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHw();
							b2.b++;
							b2.E++;
							w2.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGM(), item.A_f_1, item.B, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aeY(), text4);
							global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHX() + item.A_f_1 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Iq() + text + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.IR() + item.c);
							continue;
						}
						if (P_0.A_4)
						{
							item.d = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ik();
							item.E = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHx();
							b2.a++;
							w2.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jc(), item.A_f_1, text ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ik(), text4);
							global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHY() + item.A_f_1 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHy() + text + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHZ() + item.c);
							continue;
						}
						if (global::a.a.F(item.A_f_1))
						{
							if (global::B.O.A_m_1(item.A_f_1, P_0.a_1, P_0.A_5, out var text5) != global::B.n.a)
							{
								item.d = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jD();
								item.E = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHz() + ((text5.Length > 0) ? (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ah() + text5) : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
								b2.B_f_1++;
								w2.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jc(), item.A_f_1, text ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahA(), text4);
								global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agi(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aha(), item.A_f_1, item.E, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf());
								continue;
							}
							global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahB() + item.A_f_1 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.DG() + text5);
						}
						if (!global::a.a.A(item.A_f_1, global::a.A.A_f_1, out var text6, out var text7))
						{
							item.d = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jD();
							item.E = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahb() + text6;
							b2.B_f_1++;
							w2.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jc(), item.A_f_1, text ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jD(), text4);
							global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agi(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aha(), item.A_f_1, item.E, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf());
							continue;
						}
						item.d = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jc();
						item.E = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahC() + text + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ln();
						b2.a++;
						b2.d++;
						b2.A_1 += item.A_f_2;
						string text8 = text4;
						if (!string.IsNullOrEmpty(text7) && !global::a.a.A(text7, item.A_f_1))
						{
							text8 = ((text8.Length > 0) ? (text8 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAc()) : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jF() + text7;
						}
						w2.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jc(), item.A_f_1, text ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.IK(), text8);
						global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahc() + item.A_f_1 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHy() + text + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHZ() + item.c);
						continue;
					}
					if (P_0.A_3 == global::B.y.a && File.Exists(global::a.a.A(item.B)))
					{
						Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
						A_m_1(item, dictionary);
					}
					if (File.Exists(global::a.a.A(item.B)))
					{
						item.d = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBF();
						item.E = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHv();
						b2.b++;
						w2.A_m_1((P_0.A_2 == global::B.Y.a) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGM() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGN(), item.A_f_1, item.B, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aeY());
						global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agi(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Id(), item.A_f_1, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHv(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ip());
						continue;
					}
					if (!A_m_1(item.B, out string text9))
					{
						item.d = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jD();
						item.E = text9;
						b2.B_f_1++;
						w2.A_m_1((P_0.A_2 == global::B.Y.a) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGM() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGN(), item.A_f_1, item.B, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jD());
						global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agi(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahD(), item.B, text9, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf());
						continue;
					}
					if (P_0.A_4)
					{
						item.d = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ik();
						b2.a++;
						string text10 = A_m_1(item);
						w2.A_m_1((P_0.A_2 == global::B.Y.a) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGM() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGN(), item.A_f_1, item.B, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ik(), text10);
						global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahd() + ((P_0.A_2 == global::B.Y.a) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.IE() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Id()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ah() + item.A_f_1 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.IS() + item.B + ((text10.Length > 0) ? (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.IF() + text10 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ln()) : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()));
						continue;
					}
					if (global::a.a.F(item.A_f_1))
					{
						if (global::B.O.A_m_1(item.A_f_1, P_0.a_1, P_0.A_5, out var text11) != global::B.n.a)
						{
							item.d = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jD();
							item.E = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHz() + ((text11.Length > 0) ? (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ah() + text11) : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
							b2.B_f_1++;
							w2.A_m_1((P_0.A_2 == global::B.Y.a) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGM() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGN(), item.A_f_1, item.B, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahA());
							global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agi(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahE(), item.A_f_1, item.E, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf());
							continue;
						}
						global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahe() + item.A_f_1 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.DG() + text11);
					}
					try
					{
						if (C(item.A_f_1) && P_0.A_2 == global::B.Y.A)
						{
							global::a.a.d(item.A_f_1);
							global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahF() + item.A_f_1);
						}
						if (P_0.A_2 == global::B.Y.a)
						{
							File.Copy(global::a.a.A(item.A_f_1), global::a.a.A(item.B), overwrite: false);
							try
							{
								File.SetLastWriteTime(global::a.a.A(item.B), File.GetLastWriteTime(global::a.a.A(item.A_f_1)));
							}
							catch
							{
							}
						}
						else
						{
							global::a.a.a_m_1(item.A_f_1, item.B);
						}
						item.d = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.IK();
						item.E = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
						b2.a++;
						if (P_0.A_2 == global::B.Y.A)
						{
							b2.e++;
						}
						string text12 = A_m_1(item);
						if (text12.Length > 0)
						{
							item.D = text12;
						}
						w2.A_m_1((P_0.A_2 == global::B.Y.a) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGM() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGN(), item.A_f_1, item.B, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.IK(), text12);
						global::B.p.A_m_1(((P_0.A_2 == global::B.Y.a) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahG() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahf()) + item.A_f_1 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.IS() + item.B + ((text12.Length > 0) ? (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.IF() + text12 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ln()) : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()));
					}
					catch (Exception ex)
					{
						item.d = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jD();
						item.E = ex.Message;
						b2.B_f_1++;
						w2.A_m_1((P_0.A_2 == global::B.Y.a) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGM() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGN(), item.A_f_1, item.B, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jD());
						global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agi(), (P_0.A_2 == global::B.Y.a) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.IE() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Id(), item.A_f_1, ex.Message, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf());
					}
				}
				global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahg() + b2.ToString());
				if (b2.B_f_1 > 0 || b2.b > 0)
				{
					global::B.p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahH() + b2.B_f_1 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahh() + b2.b + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahI());
				}
			}
			finally
			{
				w2.Dispose();
			}
			P_3?.Invoke(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jv(), 1, 1, b2.ToString());
			return b2;
		}

		private static string A_m_1(A P_0, string P_1)
		{
			return string.Format(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahi(), P_0.A_f_2, P_0.c ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(), P_1 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(), P_0.A_f_3.HasValue ? P_0.A_f_3.Value.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CI(), CultureInfo.InvariantCulture) : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
		}

		private static bool A_m_1(string P_0, out string P_1)
		{
			P_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			try
			{
				string directoryName = Path.GetDirectoryName(P_0);
				if (!string.IsNullOrEmpty(directoryName))
				{
					Directory.CreateDirectory(global::a.a.A(directoryName));
				}
				return true;
			}
			catch (Exception ex)
			{
				P_1 = ex.Message;
				return false;
			}
		}

		private static bool C(string P_0)
		{
			try
			{
				return (File.GetAttributes(global::a.a.A(P_0)) & FileAttributes.ReadOnly) != 0;
			}
			catch
			{
				return false;
			}
		}
	}
}
