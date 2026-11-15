using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using _003CPrivateImplementationDetails_003E_007B1262ED64_002DD0A6_002D499E_002D9510_002DF2240F018DBB_007D;
using B;
using a;

namespace c;

internal sealed class m : global::B.d, IDisposable
{
	[CompilerGenerated]
	private static class A
	{
		public static Func<int, Task> A_f_1;
	}

	[CompilerGenerated]
	private sealed class a
	{
		public string A;

		internal HttpContent A_m_1()
		{
			return new StringContent(A, Encoding.UTF8, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aF());
		}
	}

	internal const string A_1 = "https://api.ilanzou.com";

	internal const string a_1 = "https://upload.qiniup.com/";

	internal const string B_1 = "0";

	internal const string b_1 = "-1";

	internal const int A_2 = 60;

	internal const int a_2 = 1000;

	internal const int B_2 = 600;

	internal const string C_1 = "wpanstore-lanzou";

	internal const int b_2 = 8388608;

	private const int C_2 = 200;

	private const int c_1 = 2;

	private const int D_1 = 2000;

	private const int d_1 = 90;

	private const int E_1 = 1800;

	private const string c_2 = "chrome";

	private const string D_2 = "131";

	internal const string d_2 = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.70 Safari/537.36";

	private const string E_2 = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.70 Safari/537.36";

	private readonly HttpClient A_3;

	private readonly bool A_4;

	private readonly string e_1;

	private readonly int e_2;

	private readonly Func<int, Task> A_5;

	private readonly int F_1;

	private long A_6 = long.MinValue;

	private readonly SemaphoreSlim A_7 = new SemaphoreSlim(1, 1);

	private volatile string A_8 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

	private volatile string a_3 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

	private volatile string B_3 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

	private string F_2 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

	private string f_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

	public bool HasCookie => !string.IsNullOrEmpty(A_8);

	public bool SupportsRecycleBin => false;

	public string DeleteCapabilityText => _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNb();

	public bool SupportsCreateFolder => false;

	public string CreateFolderUnsupportedReason => _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Xo();

	internal m()
		: this(null, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amq(), 0, null, 1000)
	{
	}

	internal m(HttpMessageHandler P_0, string P_1, int P_2, Func<int, Task> P_3, int P_4)
	{
		e_1 = (string.IsNullOrWhiteSpace(P_1) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amq() : P_1.TrimEnd('/'));
		e_2 = ((P_2 >= 0) ? P_2 : 0);
		A_5 = P_3 ?? new Func<int, Task>(A_m_1);
		F_1 = ((P_4 >= 0) ? P_4 : 0);
		A_4 = P_0 == null;
		if (P_0 != null)
		{
			A_3 = new HttpClient(P_0, disposeHandler: false);
		}
		else
		{
			HttpClientHandler handler = new HttpClientHandler
			{
				AutomaticDecompression = (DecompressionMethods.GZip | DecompressionMethods.Deflate)
			};
			A_3 = new HttpClient(handler, disposeHandler: true);
		}
		A_3.Timeout = TimeSpan.FromMinutes(30.0);
		A_3.DefaultRequestHeaders.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAh(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAI());
		A_3.DefaultRequestHeaders.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAg(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAH());
	}

	public void A_m_1(global::B.A P_0)
	{
		A_8 = ((P_0 == null) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D() : (P_0.AppToken ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()));
		a_3 = ((P_0 == null) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D() : (P_0.Uuid ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()));
		if (!string.IsNullOrEmpty(A_8) && string.IsNullOrEmpty(a_3))
		{
			a_3 = Guid.NewGuid().ToString();
		}
		B_3 = ((P_0 == null) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D() : (P_0.Extra ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()));
		F_2 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
		f_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
	}

	void global::B.d.A(global::B.A P_0)
	{
		//ILSpy generated this explicit interface implementation from .override directive in A_m_1
		this.A_m_1(P_0);
	}

	public void A_m_1()
	{
		A_m_1((global::B.A)null);
	}

	void global::B.d.A()
	{
		//ILSpy generated this explicit interface implementation from .override directive in A_m_1
		this.A_m_1();
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
			if (e_2 > 0 && A_6 != long.MinValue)
			{
				long tickCount = Environment.TickCount64;
				long num = e_2 - (tickCount - A_6);
				if (num > 0)
				{
					await A_5((int)num).ConfigureAwait(continueOnCapturedContext: false);
				}
			}
			P_0.ThrowIfCancellationRequested();
			A_6 = Environment.TickCount64;
		}
		finally
		{
			A_7.Release();
		}
	}

	private void A_m_1(HttpRequestMessage P_0)
	{
		P_0.Headers.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAf(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amR());
		P_0.Headers.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAi(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAJ());
		P_0.Headers.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAj(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.it());
		if (!string.IsNullOrEmpty(A_8))
		{
			P_0.Headers.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.af(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aG() + A_8);
		}
		if (!string.IsNullOrEmpty(F_2))
		{
			P_0.Headers.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amr(), F_2);
		}
		P_0.Headers.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amS(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CM());
		if (!string.IsNullOrEmpty(B_3))
		{
			P_0.Headers.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAt(), B_3);
		}
	}

	internal static string A_m_1(string P_0, string P_1, long P_2)
	{
		string stringToEscape = P_1 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
		string text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ams() + Uri.EscapeDataString(stringToEscape) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amT() + Uri.EscapeDataString(stringToEscape) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amt() + global::B.F.A(P_2) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amU();
		if (!string.IsNullOrEmpty(P_0))
		{
			text = text + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amu() + Uri.EscapeDataString(P_0);
		}
		return text;
	}

	private string A_m_1(string P_0)
	{
		return P_0 + ((P_0.IndexOf('?') >= 0) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LL() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.DW()) + A_m_1(A_8, a_3, DateTimeOffset.Now.ToUnixTimeMilliseconds());
	}

	private async Task<string> A_m_1(HttpMethod P_0, string P_1, Func<HttpContent> P_2, int P_3, CancellationToken P_4)
	{
		if (string.IsNullOrEmpty(A_8))
		{
			throw new global::a.v(global::a.V.a, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOm());
		}
		Exception ex = null;
		for (int num = 0; num <= 2; num++)
		{
			P_4.ThrowIfCancellationRequested();
			await A_m_1(P_4).ConfigureAwait(continueOnCapturedContext: false);
			try
			{
				using HttpRequestMessage httpRequestMessage = new HttpRequestMessage(P_0, P_1);
				A_m_1(httpRequestMessage);
				if (P_2 != null)
				{
					httpRequestMessage.Content = P_2();
				}
				using CancellationTokenSource cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(P_3));
				using CancellationTokenSource cancellationTokenSource2 = CancellationTokenSource.CreateLinkedTokenSource(P_4, cancellationTokenSource.Token);
				using HttpResponseMessage httpResponseMessage = await A_3.SendAsync(httpRequestMessage, HttpCompletionOption.ResponseContentRead, cancellationTokenSource2.Token).ConfigureAwait(continueOnCapturedContext: false);
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
				string text = await httpResponseMessage.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);
				if (!httpResponseMessage.IsSuccessStatusCode)
				{
					ex = new global::a.v(global::a.V.b, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aON() + (int)httpResponseMessage.StatusCode + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ah() + global::a.y.A(text));
					if (num >= 2)
					{
						throw ex;
					}
					continue;
				}
				return text;
			}
			catch (global::a.v)
			{
				throw;
			}
			catch (OperationCanceledException)
			{
				if (P_4.IsCancellationRequested)
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

	private Task<string> b_m_1(string P_0, CancellationToken P_1)
	{
		return A_m_1(HttpMethod.Get, e_1 + A_m_1(P_0), null, 90, P_1);
	}

	private Task<string> a_m_1(string P_0, string P_1, CancellationToken P_2)
	{
		return A_m_1(HttpMethod.Post, e_1 + A_m_1(P_0), () => new StringContent(P_1, Encoding.UTF8, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aF()), 90, P_2);
	}

	private async Task a_m_1(CancellationToken P_0)
	{
		if (!string.IsNullOrEmpty(F_2))
		{
			return;
		}
		if (string.IsNullOrEmpty(A_8))
		{
			throw new global::a.v(global::a.V.a, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOm());
		}
		try
		{
			JsonElement jsonElement = global::B.F.A(await b_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOs(), P_0).ConfigureAwait(continueOnCapturedContext: false), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOT());
			global::B.F.A(jsonElement, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOT());
			global::B.F.A(jsonElement, out F_2, out f_1);
		}
		catch (global::a.v v2)
		{
			if (v2.Kind == global::a.V.a)
			{
				throw;
			}
			global::B.p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOt() + v2.Message);
		}
	}

	internal static string a_m_1(string P_0)
	{
		string text = (P_0 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).Trim();
		if (text.Length == 0 || text == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iZ() || text == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jp())
		{
			return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CN();
		}
		return text;
	}

	internal static string A_m_1(string P_0, int P_1)
	{
		return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amV() + Math.Max(1, P_1) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amv() + 60 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amW() + Uri.EscapeDataString(a_m_1(P_0)) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amw();
	}

	internal static string a_m_1(string P_0, int P_1)
	{
		return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amX() + Math.Max(1, P_1) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amv() + 60 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amW() + Uri.EscapeDataString(a_m_1(P_0)) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amw();
	}

	internal static string A_m_1(string P_0, long P_1, string P_2, string P_3)
	{
		string text = a_m_1(P_2);
		return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amx() + B_m_1(P_0) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amY() + A_m_1(P_1) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amy() + B_m_1(text) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amZ() + B_m_1(P_3 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.amz();
	}

	internal static long A_m_1(long P_0)
	{
		if (P_0 <= 0)
		{
			return 1L;
		}
		long num = (long)Math.Round((double)P_0 / 1024.0, MidpointRounding.ToEven);
		if (num >= 1)
		{
			return num;
		}
		return 1L;
	}

	private static string B_m_1(string P_0)
	{
		return JsonSerializer.Serialize(P_0 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
	}

	private async Task<List<global::B.E>> C_m_1(string P_0, CancellationToken P_1)
	{
		await a_m_1(P_1).ConfigureAwait(continueOnCapturedContext: false);
		List<global::B.E> list = new List<global::B.E>();
		int num = 1;
		int num2;
		do
		{
			P_1.ThrowIfCancellationRequested();
			num2 = global::B.F.A(await b_m_1(A_m_1(P_0, num), P_1).ConfigureAwait(continueOnCapturedContext: false), out List<global::B.E> collection);
			list.AddRange(collection);
			num++;
		}
		while (num <= num2 && num <= 200);
		return list;
	}

	private async Task<List<global::a.W>> c_m_1(string P_0, CancellationToken P_1)
	{
		await a_m_1(P_1).ConfigureAwait(continueOnCapturedContext: false);
		List<global::a.W> list = new List<global::a.W>();
		int num = 1;
		int num2;
		do
		{
			P_1.ThrowIfCancellationRequested();
			num2 = global::B.F.A(await b_m_1(a_m_1(P_0, num), P_1).ConfigureAwait(continueOnCapturedContext: false), out List<global::a.W> collection);
			list.AddRange(collection);
			num++;
		}
		while (num <= num2 && num <= 200);
		return list;
	}

	public Task<List<global::a.W>> A_m_1(string P_0, CancellationToken P_1)
	{
		return c_m_1(P_0, P_1);
	}

	Task<List<global::a.W>> global::B.d.A(string P_0, CancellationToken P_1)
	{
		//ILSpy generated this explicit interface implementation from .override directive in A_m_1
		return this.A_m_1(P_0, P_1);
	}

	public async Task<List<global::a.w>> a_m_1(string P_0, CancellationToken P_1)
	{
		List<global::B.E> list = await C_m_1(P_0, P_1).ConfigureAwait(continueOnCapturedContext: false);
		List<global::a.w> list2 = new List<global::a.w>();
		foreach (global::B.E item in list)
		{
			if (!item.IsFolder)
			{
				list2.Add(A_m_1(item));
			}
		}
		return list2;
	}

	Task<List<global::a.w>> global::B.d.a(string P_0, CancellationToken P_1)
	{
		//ILSpy generated this explicit interface implementation from .override directive in a_m_1
		return this.a_m_1(P_0, P_1);
	}

	public async Task<global::a.s> B_m_1(string P_0, CancellationToken P_1)
	{
		global::a.s s2 = new global::a.s();
		HashSet<string> hashSet = new HashSet<string>(StringComparer.Ordinal);
		foreach (global::a.W item in await c_m_1(P_0, P_1).ConfigureAwait(continueOnCapturedContext: false))
		{
			if (!string.IsNullOrEmpty(item.Id) && hashSet.Add(item.Id))
			{
				s2.Folders.Add(item);
			}
		}
		foreach (global::B.E item2 in await C_m_1(P_0, P_1).ConfigureAwait(continueOnCapturedContext: false))
		{
			if (item2.IsFolder)
			{
				if (!string.IsNullOrEmpty(item2.FileId) && hashSet.Add(item2.FileId))
				{
					s2.Folders.Add(new global::a.W
					{
						Id = item2.FileId,
						Name = (item2.Name ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D())
					});
				}
			}
			else
			{
				s2.Files.Add(A_m_1(item2));
			}
		}
		return s2;
	}

	Task<global::a.s> global::B.d.B(string P_0, CancellationToken P_1)
	{
		//ILSpy generated this explicit interface implementation from .override directive in B_m_1
		return this.B_m_1(P_0, P_1);
	}

	private static global::a.w A_m_1(global::B.E P_0)
	{
		return new global::a.w
		{
			Id = (P_0.FileId ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()),
			Name = (P_0.Name ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()),
			SizeText = global::B.F.a(P_0.SizeBytes),
			SizeBytes = P_0.SizeBytes,
			Time = (P_0.Time ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D())
		};
	}

	internal static string A_m_1(string P_0, string P_1)
	{
		return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNA() + B_m_1(P_1 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNa() + B_m_1(P_0 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNB();
	}

	public async Task D_m_1(string P_0, CancellationToken P_1)
	{
		if (string.IsNullOrWhiteSpace(P_0))
		{
			throw new global::a.v(global::a.V.C, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOR());
		}
		global::B.F.a(await a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOr(), A_m_1(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()), P_1).ConfigureAwait(continueOnCapturedContext: false), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOS());
	}

	public Task<string> A_m_1(string P_0, string P_1, CancellationToken P_2)
	{
		throw new global::a.v(global::a.V.b, CreateFolderUnsupportedReason);
	}

	Task<string> global::B.d.A(string P_0, string P_1, CancellationToken P_2)
	{
		//ILSpy generated this explicit interface implementation from .override directive in A_m_1
		return this.A_m_1(P_0, P_1, P_2);
	}

	public async Task<global::a.X> A_m_1(string P_0, string P_1, string P_2, CancellationToken P_3, Action<long, long> P_4, string P_5 = null)
	{
		FileInfo fileInfo = new FileInfo(P_0);
		if (!fileInfo.Exists)
		{
			throw new global::a.v(global::a.V.C, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNP());
		}
		if (string.IsNullOrEmpty(A_8))
		{
			throw new global::a.v(global::a.V.a, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOV());
		}
		string text = (string.IsNullOrEmpty(P_2) ? fileInfo.Name : P_2);
		await a_m_1(P_3).ConfigureAwait(continueOnCapturedContext: false);
		string text2 = (string.IsNullOrEmpty(P_5) ? global::B.F.c(P_0) : P_5);
		string text3 = await a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOv(), A_m_1(text, fileInfo.Length, P_1, text2), P_3).ConfigureAwait(continueOnCapturedContext: false);
		string text4;
		try
		{
			text4 = global::B.F.A(text3);
		}
		catch (global::a.v v2)
		{
			string text9 = await a_m_2(fileInfo.Length, P_3).ConfigureAwait(continueOnCapturedContext: false);
			global::B.p.a_m_1("蓝奏优享上传失败：" + v2.Message + "；" + text9);
			throw new global::a.v(v2.Kind, v2.Message + "；" + text9);
		}
		if (text4 == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iZ())
		{
			string text5 = global::B.F.a(text3);
			if (string.IsNullOrEmpty(text5))
			{
				throw new global::a.v(global::a.V.b, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOW());
			}
			return new global::a.X
			{
				Success = true,
				Instant = true,
				FileId = text5,
				Reason = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()
			};
		}
		DateTimeOffset now = DateTimeOffset.Now;
		string text6 = global::B.F.A(f_1, now, now.ToUnixTimeMilliseconds(), Guid.NewGuid().ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.cL()));
		string text7 = ((!a_m_1(fileInfo.Length)) ? (await A_m_1(text4, text6, text, P_0, fileInfo.Length, P_4, P_3).ConfigureAwait(continueOnCapturedContext: false)) : (await a_m_1(text4, text6, text, P_0, fileInfo.Length, P_4, P_3).ConfigureAwait(continueOnCapturedContext: false)));
		string text8 = global::B.F.B(text7);
		global::B.e e2 = await B_m_1(text8, text, P_3).ConfigureAwait(continueOnCapturedContext: false);
		return new global::a.X
		{
			Success = true,
			FileId = (e2.FileId ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()),
			Reason = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()
		};
	}

	private async Task<string> a_m_2(long P_0, CancellationToken P_1)
	{
		string text = "本次文件 " + global::B.F.a(P_0) + "（" + P_0.ToString(CultureInfo.InvariantCulture) + " 字节）";
		if (P_1.IsCancellationRequested)
		{
			return text + "；配额信息未读取（操作已取消）";
		}
		try
		{
			string text2 = await b_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOs(), P_1).ConfigureAwait(continueOnCapturedContext: false);
			using JsonDocument jsonDocument = JsonDocument.Parse(text2);
			JsonElement jsonElement = jsonDocument.RootElement;
			if (jsonElement.TryGetProperty("map", out var value) && value.ValueKind == JsonValueKind.Object)
			{
				jsonElement = value;
			}
			long num = global::B.F.A(jsonElement, "totalSize", -1L);
			long num2 = global::B.F.A(jsonElement, "usedSize", -1L);
			long num3 = global::B.F.A(jsonElement, "vipSize", -1L);
			string text3 = global::B.F.a(jsonElement, "vipTime");
			string text4 = ((num < 0) ? "未知" : (global::B.F.a(num) + "（" + num.ToString(CultureInfo.InvariantCulture) + " 字节）"));
			string text5 = ((num2 < 0) ? "未知" : (global::B.F.a(num2) + "（" + num2.ToString(CultureInfo.InvariantCulture) + " 字节）"));
			string text6 = ((num3 < 0) ? "未知" : (global::B.F.a(num3) + "（" + num3.ToString(CultureInfo.InvariantCulture) + " 字节）"));
			string text7 = (string.IsNullOrEmpty(text3) ? "未知" : text3);
			return text + "；配额上限 " + text4 + "；已用空间 " + text5 + "；VIP 配额 " + text6 + "；VIP 到期 " + text7;
		}
		catch (Exception ex)
		{
			return text + "；配额信息读取失败：" + ex.Message;
		}
	}

	Task<global::a.X> global::B.d.A(string P_0, string P_1, string P_2, CancellationToken P_3, Action<long, long> P_4, string P_5 = null)
	{
		//ILSpy generated this explicit interface implementation from .override directive in A_m_1
		return this.A_m_1(P_0, P_1, P_2, P_3, P_4, P_5);
	}

	private async Task<string> A_m_1(string P_0, string P_1, string P_2, string P_3, long P_4, Action<long, long> P_5, CancellationToken P_6)
	{
		MultipartFormDataContent multipartFormDataContent = new MultipartFormDataContent();
		multipartFormDataContent.Add(new StringContent(P_0, Encoding.UTF8), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aam());
		multipartFormDataContent.Add(new StringContent(P_1, Encoding.UTF8), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.dx());
		FileStream fileStream = new FileStream(P_3, FileMode.Open, FileAccess.Read, FileShare.Read);
		StreamContent streamContent = new StreamContent((P_5 == null) ? ((Stream)fileStream) : ((Stream)new global::a.Y(fileStream, P_4, P_5)));
		streamContent.Headers.ContentType = new MediaTypeHeaderValue(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zp());
		streamContent.Headers.ContentDisposition = new ContentDispositionHeaderValue(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zQ())
		{
			Name = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOw(),
			FileName = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JX() + b_m_1(P_2) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JX()
		};
		multipartFormDataContent.Add(streamContent);
		try
		{
			using HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOX());
			httpRequestMessage.Headers.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAh(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAI());
			httpRequestMessage.Headers.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAi(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAJ());
			httpRequestMessage.Headers.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAj(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.it());
			httpRequestMessage.Content = multipartFormDataContent;
			using CancellationTokenSource cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(1800.0));
			using CancellationTokenSource cancellationTokenSource2 = CancellationTokenSource.CreateLinkedTokenSource(P_6, cancellationTokenSource.Token);
			using HttpResponseMessage httpResponseMessage = await A_3.SendAsync(httpRequestMessage, HttpCompletionOption.ResponseContentRead, cancellationTokenSource2.Token).ConfigureAwait(continueOnCapturedContext: false);
			string text = await httpResponseMessage.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);
			if (!httpResponseMessage.IsSuccessStatusCode)
			{
				throw new global::a.v(global::a.V.b, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOu() + (int)httpResponseMessage.StatusCode + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aH() + global::a.y.A(text));
			}
			return text;
		}
		catch (global::a.v)
		{
			throw;
		}
		catch (OperationCanceledException)
		{
			if (P_6.IsCancellationRequested)
			{
				throw;
			}
			throw new global::a.v(global::a.V.B, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOQ());
		}
		catch (Exception ex2) when (ex2 is HttpRequestException || ex2 is IOException)
		{
			throw new global::a.v(global::a.V.B, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOq() + ex2.Message);
		}
	}

	internal static bool a_m_1(long P_0)
	{
		return P_0 > 8388608;
	}

	internal static int B_m_1(long P_0)
	{
		if (P_0 <= 0)
		{
			return 1;
		}
		return (int)((P_0 + 8388608 - 1) / 8388608);
	}

	private async Task<string> a_m_1(string P_0, string P_1, string P_2, string P_3, long P_4, Action<long, long> P_5, CancellationToken P_6)
	{
		string text = Convert.ToBase64String(Encoding.UTF8.GetBytes(P_1));
		string text2 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOx() + text + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOY();
		string text3 = global::B.F.b(await A_m_1(HttpMethod.Post, text2, P_0, new ByteArrayContent(Array.Empty<byte>()), P_6).ConfigureAwait(continueOnCapturedContext: false));
		int num = B_m_1(P_4);
		List<string> list = new List<string>(num);
		using (FileStream fileStream = new FileStream(P_3, FileMode.Open, FileAccess.Read, FileShare.Read))
		{
			byte[] array = new byte[8388608];
			long num2 = 0L;
			for (int num3 = 1; num3 <= num; num3++)
			{
				int num4 = (int)Math.Min(8388608L, P_4 - num2);
				int num5;
				int num6;
				for (num5 = 0; num5 < num4; num5 += num6)
				{
					num6 = await fileStream.ReadAsync(array, num5, num4 - num5, P_6).ConfigureAwait(continueOnCapturedContext: false);
					if (num6 <= 0)
					{
						break;
					}
				}
				if (num5 <= 0)
				{
					throw new global::a.v(global::a.V.C, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOy());
				}
				ByteArrayContent byteArrayContent = new ByteArrayContent(array, 0, num5);
				byteArrayContent.Headers.ContentType = new MediaTypeHeaderValue(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zp());
				using (MD5 mD = MD5.Create())
				{
					byteArrayContent.Headers.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOZ(), Convert.ToBase64String(mD.ComputeHash(array, 0, num5)));
				}
				string text4 = global::B.F.C(await A_m_1(HttpMethod.Put, text2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aA() + num3, P_0, byteArrayContent, P_6).ConfigureAwait(continueOnCapturedContext: false));
				list.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOz() + num3 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aoA() + B_m_1(text4) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aoa());
				num2 += num5;
				P_5?.Invoke(num2, P_4);
			}
		}
		string content = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aoB() + string.Join(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Kn(), list) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aob();
		return await A_m_1(HttpMethod.Post, text2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aA() + text3, P_0, new StringContent(content, Encoding.UTF8, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aF()), P_6).ConfigureAwait(continueOnCapturedContext: false);
	}

	private async Task<string> A_m_1(HttpMethod P_0, string P_1, string P_2, HttpContent P_3, CancellationToken P_4)
	{
		_ = 1;
		try
		{
			using HttpRequestMessage httpRequestMessage = new HttpRequestMessage(P_0, P_1);
			httpRequestMessage.Headers.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.af(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOU() + P_2);
			httpRequestMessage.Headers.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAh(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAI());
			httpRequestMessage.Headers.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAi(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAJ());
			httpRequestMessage.Headers.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAj(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.it());
			httpRequestMessage.Content = P_3;
			using CancellationTokenSource cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(1800.0));
			using CancellationTokenSource cancellationTokenSource2 = CancellationTokenSource.CreateLinkedTokenSource(P_4, cancellationTokenSource.Token);
			using HttpResponseMessage httpResponseMessage = await A_3.SendAsync(httpRequestMessage, HttpCompletionOption.ResponseContentRead, cancellationTokenSource2.Token).ConfigureAwait(continueOnCapturedContext: false);
			string text = await httpResponseMessage.Content.ReadAsStringAsync().ConfigureAwait(continueOnCapturedContext: false);
			if (!httpResponseMessage.IsSuccessStatusCode)
			{
				throw new global::a.v(global::a.V.b, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOu() + (int)httpResponseMessage.StatusCode + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aH() + global::a.y.A(text));
			}
			return text;
		}
		catch (global::a.v)
		{
			throw;
		}
		catch (OperationCanceledException)
		{
			if (P_4.IsCancellationRequested)
			{
				throw;
			}
			throw new global::a.v(global::a.V.B, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOQ());
		}
		catch (Exception ex2) when (ex2 is HttpRequestException || ex2 is IOException)
		{
			throw new global::a.v(global::a.V.B, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOq() + ex2.Message);
		}
	}

	private async Task<global::B.e> B_m_1(string P_0, string P_1, CancellationToken P_2)
	{
		string text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aoC() + Uri.EscapeDataString(P_0) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aoc() + Uri.EscapeDataString(global::B.F.A(DateTimeOffset.Now));
		global::B.e e2 = null;
		for (int num = 0; num < 600; num++)
		{
			P_2.ThrowIfCancellationRequested();
			global::B.e e3 = global::B.F.B(await b_m_1(text, P_2).ConfigureAwait(continueOnCapturedContext: false), P_1);
			if (e3 != null && e3.Success)
			{
				return e3;
			}
			if (e3 != null)
			{
				e2 = e3;
			}
			if (num < 599)
			{
				await A_5(F_1).ConfigureAwait(continueOnCapturedContext: false);
			}
		}
		throw new global::a.v(global::a.V.b, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aoD() + ((e2 != null && !string.IsNullOrEmpty(e2.Message)) ? (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ah() + e2.Message) : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()));
	}

	private static string b_m_1(string P_0)
	{
		if (P_0 == null)
		{
			return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zR();
		}
		StringBuilder stringBuilder = new StringBuilder(P_0.Length);
		foreach (char c2 in P_0)
		{
			stringBuilder.Append((c2 < ' ' || c2 > '~' || c2 == '"' || c2 == '\\') ? '_' : c2);
		}
		if (stringBuilder.Length != 0)
		{
			return stringBuilder.ToString();
		}
		return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zR();
	}

	public void Dispose()
	{
		if (A_4)
		{
			A_3.Dispose();
		}
	}
}
