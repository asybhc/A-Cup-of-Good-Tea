using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using _003CPrivateImplementationDetails_003E_007B1262ED64_002DD0A6_002D499E_002D9510_002DF2240F018DBB_007D;
using B;
using a;

namespace c
{
	internal sealed class G : IDisposable, global::B.d
	{
		[CompilerGenerated]
		private static class A
		{
			public static Func<int, Task> A_f_1;
		}

		internal const string A_1 = "https://pc.woozooo.com";

		internal const int A_2 = 18;

		internal const long A_3 = 104857600L;

		internal const int a_1 = 1500;

		internal const int B_1 = 2;

		private const int b_1 = 2000;

		private const string a_2 = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/147.0.0.0 Safari/537.36";

		private readonly HttpClient A_4;

		private readonly string B_2;

		private readonly int C_1;

		private readonly Func<int, Task> A_5;

		private readonly bool A_6;

		private long a_3 = long.MinValue;

		private readonly SemaphoreSlim A_7 = new SemaphoreSlim(1, 1);

		private volatile string A_8 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		public string CookieHeader => A_8;

		internal bool HasCookie => !string.IsNullOrEmpty(A_8);

		internal bool SupportsRecycleBin => true;

		internal string DeleteCapabilityText => _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMv();

		bool global::B.d.HasCookie => HasCookie;

		bool global::B.d.SupportsCreateFolder => true;

		string global::B.d.CreateFolderUnsupportedReason => _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		internal G()
			: this(null, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aav(), 1500, null)
		{
		}

		internal G(HttpMessageHandler P_0, string P_1, int P_2, Func<int, Task> P_3)
		{
			B_2 = (string.IsNullOrWhiteSpace(P_1) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aav() : P_1.TrimEnd('/'));
			C_1 = ((P_2 >= 0) ? P_2 : 0);
			A_5 = P_3 ?? new Func<int, Task>(A_m_1);
			A_6 = P_0 == null;
			if (P_0 != null)
			{
				A_4 = new HttpClient(P_0, disposeHandler: false);
			}
			else
			{
				HttpClientHandler handler = new HttpClientHandler
				{
					AutomaticDecompression = (DecompressionMethods.GZip | DecompressionMethods.Deflate)
				};
				A_4 = new HttpClient(handler, disposeHandler: true);
			}
			A_4.Timeout = TimeSpan.FromMinutes(30.0);
			A_4.DefaultRequestHeaders.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAh(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAk());
			A_4.DefaultRequestHeaders.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAg(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAH());
		}

		internal void A_m_1(string P_0, string P_1)
		{
			string text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			if (!string.IsNullOrEmpty(P_0))
			{
				text = text + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iw() + P_0 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAD();
			}
			if (!string.IsNullOrEmpty(P_1))
			{
				text = text + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iX() + P_1 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAD();
			}
			A_8 = text.TrimEnd();
		}

		internal void A_m_1(string P_0)
		{
			A_8 = (P_0 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).Trim();
		}

		private static Task A_m_1(int P_0)
		{
			if (P_0 > 0)
			{
				return Task.Delay(P_0);
			}
			return Task.CompletedTask;
		}

		private async Task A_m_1(CancellationToken P_0)
		{
			P_0.ThrowIfCancellationRequested();
			await A_7.WaitAsync(P_0).ConfigureAwait(continueOnCapturedContext: false);
			try
			{
				if (C_1 > 0 && a_3 != long.MinValue)
				{
					long tickCount = Environment.TickCount64;
					long num = C_1 - (tickCount - a_3);
					if (num > 0)
					{
						await A_5((int)num).ConfigureAwait(continueOnCapturedContext: false);
					}
				}
				P_0.ThrowIfCancellationRequested();
				a_3 = Environment.TickCount64;
			}
			finally
			{
				A_7.Release();
			}
		}

		private void A_m_1(HttpRequestMessage P_0, string P_1)
		{
			P_0.Headers.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAf(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMr());
			P_0.Headers.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMS(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMs());
			P_0.Headers.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAi(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aav());
			P_0.Headers.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAj(), P_1 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMT());
			if (!string.IsNullOrEmpty(A_8))
			{
				P_0.Headers.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAt(), A_8);
			}
		}

		private static string A_m_1(IEnumerable<KeyValuePair<string, string>> P_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (KeyValuePair<string, string> item in P_0)
			{
				if (stringBuilder.Length > 0)
				{
					stringBuilder.Append('&');
				}
				stringBuilder.Append(Uri.EscapeDataString(item.Key ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()));
				stringBuilder.Append('=');
				stringBuilder.Append(Uri.EscapeDataString(item.Value ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()));
			}
			return stringBuilder.ToString();
		}

		private async Task<string> A_m_1(string P_0, IEnumerable<KeyValuePair<string, string>> P_1, string P_2, CancellationToken P_3)
		{
			if (string.IsNullOrEmpty(A_8))
			{
				throw new global::a.v(global::a.V.a, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOm());
			}
			string content = A_m_1(P_1);
			string requestUri = B_2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aA() + P_0;
			Exception ex = null;
			for (int num = 0; num <= 2; num++)
			{
				P_3.ThrowIfCancellationRequested();
				await A_m_1(P_3);
				try
				{
					using HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
					A_m_1(httpRequestMessage, P_2);
					httpRequestMessage.Content = new StringContent(content, Encoding.UTF8, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amM());
					using CancellationTokenSource cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(60.0));
					using CancellationTokenSource cancellationTokenSource2 = CancellationTokenSource.CreateLinkedTokenSource(P_3, cancellationTokenSource.Token);
					using HttpResponseMessage httpResponseMessage = await A_4.SendAsync(httpRequestMessage, HttpCompletionOption.ResponseContentRead, cancellationTokenSource2.Token).ConfigureAwait(continueOnCapturedContext: false);
					if (httpResponseMessage.StatusCode == HttpStatusCode.Unauthorized || httpResponseMessage.StatusCode == HttpStatusCode.Forbidden)
					{
						throw new global::a.v(global::a.V.a, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aON() + (int)httpResponseMessage.StatusCode);
					}
					string result = await httpResponseMessage.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);
					if (!httpResponseMessage.IsSuccessStatusCode)
					{
						ex = new global::a.v(global::a.V.b, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aON() + (int)httpResponseMessage.StatusCode);
						if (num >= 2)
						{
							throw ex;
						}
						continue;
					}
					return result;
				}
				catch (global::a.v)
				{
					throw;
				}
				catch (OperationCanceledException)
				{
					if (P_3.IsCancellationRequested)
					{
						throw;
					}
					ex = new global::a.v(global::a.V.B, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.by());
					if (num >= 2)
					{
						throw ex;
					}
				}
				catch (Exception ex3) when (ex3 is HttpRequestException || ex3 is IOException)
				{
					ex = ex3;
					if (num >= 2)
					{
						throw new global::a.v(global::a.V.B, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.vK() + ex3.Message);
					}
				}
			}
			throw new global::a.v(global::a.V.B, (ex == null) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOn() : ex.Message);
		}

		public async Task<List<global::a.W>> A_m_1(string P_0, CancellationToken P_1)
		{
			string value = (string.IsNullOrWhiteSpace(P_0) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iZ() : P_0);
			string text = global::B.a.A_m_1(A_8);
			string text2 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOI() + (string.IsNullOrEmpty(text) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D() : (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOi() + Uri.EscapeDataString(text)));
			List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>
			{
				new KeyValuePair<string, string>(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zM(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOM()),
				new KeyValuePair<string, string>(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMV(), value)
			};
			return global::a.y.a(await A_m_1(text2, list, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMT(), P_1).ConfigureAwait(continueOnCapturedContext: false));
		}

		Task<List<global::a.W>> global::B.d.A(string P_0, CancellationToken P_1)
		{
			//ILSpy generated this explicit interface implementation from .override directive in A_m_1
			return this.A_m_1(P_0, P_1);
		}

		public async Task<string> a_m_1(string P_0, string P_1, CancellationToken P_2)
		{
			string value = (string.IsNullOrWhiteSpace(P_0) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iZ() : P_0);
			string text = global::B.a.A_m_1(A_8);
			string text2 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOI() + (string.IsNullOrEmpty(text) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D() : (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOi() + Uri.EscapeDataString(text)));
			List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>
			{
				new KeyValuePair<string, string>(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zM(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zN()),
				new KeyValuePair<string, string>(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMV(), value),
				new KeyValuePair<string, string>(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOJ(), P_1),
				new KeyValuePair<string, string>(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOj(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D())
			};
			return global::a.y.B(await A_m_1(text2, list, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMT(), P_2).ConfigureAwait(continueOnCapturedContext: false));
		}

		public async Task<List<global::a.w>> a_m_1(string P_0, CancellationToken P_1)
		{
			string value = (string.IsNullOrWhiteSpace(P_0) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iZ() : P_0);
			List<global::a.w> list = new List<global::a.w>();
			for (int num = 1; num <= 200; num++)
			{
				P_1.ThrowIfCancellationRequested();
				List<KeyValuePair<string, string>> list2 = new List<KeyValuePair<string, string>>
				{
					new KeyValuePair<string, string>(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zM(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOL()),
					new KeyValuePair<string, string>(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMV(), value),
					new KeyValuePair<string, string>(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOl(), num.ToString())
				};
				List<global::a.w> list3 = global::a.y.C(await A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOI(), list2, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMT(), P_1).ConfigureAwait(continueOnCapturedContext: false));
				if (list3.Count == 0)
				{
					break;
				}
				list.AddRange(list3);
				if (list3.Count < 18)
				{
					break;
				}
			}
			return list;
		}

		Task<List<global::a.w>> global::B.d.a(string P_0, CancellationToken P_1)
		{
			//ILSpy generated this explicit interface implementation from .override directive in a_m_1
			return this.a_m_1(P_0, P_1);
		}

		public async Task<global::a.s> B_m_1(string P_0, CancellationToken P_1)
		{
			string text = (string.IsNullOrWhiteSpace(P_0) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iZ() : P_0);
			List<global::a.W> folders = await A_m_1(text, P_1).ConfigureAwait(continueOnCapturedContext: false);
			List<global::a.w> files = await a_m_1(text, P_1).ConfigureAwait(continueOnCapturedContext: false);
			return new global::a.s
			{
				Folders = folders,
				Files = files
			};
		}

		Task<global::a.s> global::B.d.B(string P_0, CancellationToken P_1)
		{
			//ILSpy generated this explicit interface implementation from .override directive in B_m_1
			return this.B_m_1(P_0, P_1);
		}

		internal async Task A_m_1(string P_0, bool P_1, CancellationToken P_2)
		{
			if (string.IsNullOrWhiteSpace(P_0))
			{
				throw new global::a.v(global::a.V.C, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOK() + (P_1 ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Vt() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.WA()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOk());
			}
			global::a.y.b(await A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOI(), A_m_1(P_0, P_1), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMT(), P_2).ConfigureAwait(continueOnCapturedContext: false));
		}

		internal static List<KeyValuePair<string, string>> A_m_1(string P_0, bool P_1)
		{
			return new List<KeyValuePair<string, string>>
			{
				new KeyValuePair<string, string>(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zM(), P_1 ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMU() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMt()),
				new KeyValuePair<string, string>(P_1 ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMV() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMu(), P_0 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D())
			};
		}

		public async Task<global::a.X> A_m_1(string P_0, string P_1, string P_2, CancellationToken P_3, Action<long, long> P_4, string P_5 = null)
		{
			FileInfo fileInfo = new FileInfo(P_0);
			if (!fileInfo.Exists)
			{
				throw new global::a.v(global::a.V.C, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNP());
			}
			if (fileInfo.Length > 104857600)
			{
				return new global::a.X
				{
					Success = false,
					SkippedTooLarge = true,
					Reason = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.wD()
				};
			}
			if (string.IsNullOrEmpty(A_8))
			{
				throw new global::a.v(global::a.V.a, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOm());
			}
			string text = (string.IsNullOrEmpty(P_2) ? fileInfo.Name : P_2);
			string text2 = (string.IsNullOrWhiteSpace(P_1) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iZ() : P_1);
			Exception ex = null;
			for (int num = 0; num <= 2; num++)
			{
				P_3.ThrowIfCancellationRequested();
				await A_m_1(P_3);
				try
				{
					using HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, B_2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOO());
					A_m_1(httpRequestMessage, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMT());
					httpRequestMessage.Content = global::a.x.A(text, text2, P_0, fileInfo.Length, P_4);
					using HttpResponseMessage httpResponseMessage = await A_4.SendAsync(httpRequestMessage, HttpCompletionOption.ResponseContentRead, P_3).ConfigureAwait(continueOnCapturedContext: false);
					if (httpResponseMessage.StatusCode == HttpStatusCode.Unauthorized || httpResponseMessage.StatusCode == HttpStatusCode.Forbidden || httpResponseMessage.StatusCode == HttpStatusCode.TooManyRequests)
					{
						if ((httpResponseMessage.StatusCode != HttpStatusCode.Forbidden && httpResponseMessage.StatusCode != HttpStatusCode.TooManyRequests) || num != 0)
						{
							if (httpResponseMessage.StatusCode == HttpStatusCode.TooManyRequests)
							{
								throw new global::a.v(global::a.V.b, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOo());
							}
							throw new global::a.v(global::a.V.a, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOP() + (int)httpResponseMessage.StatusCode + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOp());
						}
						await A_5(2000).ConfigureAwait(continueOnCapturedContext: false);
						continue;
					}
					string text3 = await httpResponseMessage.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);
					if (!httpResponseMessage.IsSuccessStatusCode)
					{
						ex = new global::a.v(global::a.V.b, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aON() + (int)httpResponseMessage.StatusCode);
						if (num >= 2)
						{
							throw ex;
						}
						continue;
					}
					return global::a.y.c(text3);
				}
				catch (global::a.v)
				{
					throw;
				}
				catch (OperationCanceledException)
				{
					if (P_3.IsCancellationRequested)
					{
						throw;
					}
					ex = new global::a.v(global::a.V.B, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOQ());
					if (num >= 2)
					{
						throw ex;
					}
				}
				catch (Exception ex3) when (ex3 is HttpRequestException || ex3 is IOException)
				{
					ex = ex3;
					if (num >= 2)
					{
						throw new global::a.v(global::a.V.B, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOq() + ex3.Message);
					}
				}
			}
			throw new global::a.v(global::a.V.B, (ex == null) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.wy() : ex.Message);
		}

		Task<global::a.X> global::B.d.A(string P_0, string P_1, string P_2, CancellationToken P_3, Action<long, long> P_4, string P_5 = null)
		{
			//ILSpy generated this explicit interface implementation from .override directive in A_m_1
			return this.A_m_1(P_0, P_1, P_2, P_3, P_4, P_5);
		}

		public void Dispose()
		{
			if (A_6)
			{
				A_4.Dispose();
			}
		}

		private Task<string> B_m_1(string P_0, string P_1, CancellationToken P_2)
		{
			return a_m_1(P_0, P_1, P_2);
		}

		Task<string> global::B.d.A(string P_0, string P_1, CancellationToken P_2)
		{
			//ILSpy generated this explicit interface implementation from .override directive in B_m_1
			return this.B_m_1(P_0, P_1, P_2);
		}

		private void a_m_1(global::B.A P_0)
		{
			if (P_0 != null)
			{
				A_m_1(P_0.Ylogin, P_0.PhpdiskInfo);
			}
		}

		void global::B.d.A(global::B.A P_0)
		{
			//ILSpy generated this explicit interface implementation from .override directive in a_m_1
			this.a_m_1(P_0);
		}

		private void a_m_1()
		{
			A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
		}

		void global::B.d.A()
		{
			//ILSpy generated this explicit interface implementation from .override directive in a_m_1
			this.a_m_1();
		}

		internal void B_m_1()
		{
			A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
		}
	}
}
namespace C
{
	internal static class G
	{
		internal const string A = "# generated at build time; do not edit by hand\nstamp dd70ef34d3556cfe6371b7202f21545d4e83733c16f4d6e975b81b0b2df86906\nversion 1.1.1\nitem FileDedupTool.app.ico 8a7ec9196520d36db0be256a0445a2b99b50b4270b2b8238e466dca6858c1acf\nitem FileDedupTool.tray.ico 902baaae3b38b3e7e448303670b6d2afda3e75df1719ba96e8c32543774d8e2d\nitem FileDedupTool.help.zh.md a4db946f8b4e028b13b1fcfa844fa16aec60fd92682118c32190d9083dc59c35\nitem FileDedupTool.help.en.md 38fa97f0b8b94cbf173dee61c6e38fa37f92d7f5668892349df00611fb87354f\n";
	}
	[CompilerGenerated]
	internal sealed class g
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 6)]
		internal struct A
		{
		}

		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 10)]
		internal struct a
		{
		}

		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 12)]
		internal struct B
		{
		}

		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 18)]
		internal struct b
		{
		}

		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 160)]
		internal struct C
		{
		}

		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 180)]
		internal struct c
		{
		}

		internal static readonly C A_1/* Not supported: data(0F 00 00 00 23 00 00 00 1D 00 00 00 18 00 00 00 21 00 00 00 10 00 00 00 01 00 00 00 26 00 00 00 0A 00 00 00 09 00 00 00 13 00 00 00 1F 00 00 00 28 00 00 00 1B 00 00 00 16 00 00 00 17 00 00 00 19 00 00 00 0D 00 00 00 06 00 00 00 0B 00 00 00 27 00 00 00 12 00 00 00 14 00 00 00 08 00 00 00 0E 00 00 00 15 00 00 00 20 00 00 00 1A 00 00 00 02 00 00 00 1E 00 00 00 07 00 00 00 04 00 00 00 11 00 00 00 05 00 00 00 03 00 00 00 1C 00 00 00 22 00 00 00 25 00 00 00 0C 00 00 00 24 00 00 00) */;

		internal static readonly c A_2/* Not supported: data(00 00 00 00 20 00 00 00 30 00 00 00 38 00 00 00 40 00 00 00 50 00 00 00 60 00 00 00 70 00 00 00 80 00 00 00 90 00 00 00 A0 00 00 00 B0 00 00 00 C0 00 00 00 E0 00 00 00 00 01 00 00 00 00 00 00 08 00 00 00 10 00 00 00 18 00 00 00 20 00 00 00 28 00 00 00 30 00 00 00 38 00 00 00 40 00 00 00 50 00 00 00 60 00 00 00 70 00 00 00 80 00 00 00 90 00 00 00 A0 00 00 00 00 00 00 00 08 00 00 00 10 00 00 00 18 00 00 00 20 00 00 00 28 00 00 00 30 00 00 00 38 00 00 00 40 00 00 00 50 00 00 00 60 00 00 00 70 00 00 00 80 00 00 00 90 00 00 00 A0 00 00 00) */;

		internal static readonly long A_3/* Not supported: data(2C 00 22 00 0A 00 0D 00) */;

		internal static readonly A A_4/* Not supported: data(2D 00 2B 00 20 00) */;

		internal static readonly c a_1/* Not supported: data(00 00 00 00 20 00 00 00 40 00 00 00 60 00 00 00 80 00 00 00 A0 00 00 00 C0 00 00 00 E0 00 00 00 00 01 00 00 20 01 00 00 40 01 00 00 60 01 00 00 80 01 00 00 A0 01 00 00 C0 01 00 00 00 00 00 00 20 00 00 00 30 00 00 00 38 00 00 00 40 00 00 00 50 00 00 00 60 00 00 00 70 00 00 00 80 00 00 00 A0 00 00 00 C0 00 00 00 E0 00 00 00 00 01 00 00 40 01 00 00 80 01 00 00 00 00 00 00 20 00 00 00 28 00 00 00 30 00 00 00 38 00 00 00 40 00 00 00 50 00 00 00 60 00 00 00 70 00 00 00 80 00 00 00 A0 00 00 00 C0 00 00 00 E0 00 00 00 00 01 00 00 40 01 00 00) */;

		internal static readonly A a_2/* Not supported: data(3B 00 2C 00 7C 00) */;

		internal static readonly long a_3/* Not supported: data(22 00 27 00 7B 00 7D 00) */;

		internal static readonly b A_5/* Not supported: data(5C 00 2F 00 3A 00 2A 00 3F 00 22 00 3C 00 3E 00 7C 00) */;

		internal static readonly B A_6/* Not supported: data(03 90 00 00 04 90 00 00 32 01 00 00) */;

		internal static readonly long B_1/* Not supported: data(22 00 27 00 3B 00 2C 00) */;

		internal static readonly B a_4/* Not supported: data(22 00 27 00 7B 00 7D 00 3B 00 2C 00) */;

		internal static readonly a A_7/* Not supported: data(20 00 09 00 2E 00 5F 00 2D 00) */;

		internal static readonly A B_2/* Not supported: data(3B 00 0A 00 0D 00) */;

		internal static readonly long b_1/* Not supported: data(00 00 20 00 0D 00 0A 00) */;

		internal static readonly long C_1/* Not supported: data(2C 00 22 00 0D 00 0A 00) */;
	}
}
