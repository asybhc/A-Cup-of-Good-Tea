using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007B1262ED64_002DD0A6_002D499E_002D9510_002DF2240F018DBB_007D;
using A;
using B;
using a;
using b;

namespace C;

internal static class E
{
	// C-08：更新包 Authenticode 数字签名校验（WinVerifyTrust）。
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	private struct WINTRUST_FILE_INFO
	{
		public uint cbStruct;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string pcwszFilePath;

		public IntPtr hFile;

		public IntPtr pgKnownSubject;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	private struct WINTRUST_DATA
	{
		public uint cbStruct;

		public IntPtr pPolicyCallbackData;

		public IntPtr pSIPClientData;

		public uint dwUIChoice;

		public uint fdwRevocationChecks;

		public uint dwUnionChoice;

		public IntPtr pFile;

		public uint dwStateAction;

		public IntPtr hWVTStateData;

		public IntPtr pwszURLReference;

		public uint dwProvFlags;

		public uint dwUIContext;

		public IntPtr pSignatureSettings;
	}

	[DllImport("wintrust.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
	private static extern uint WinVerifyTrust(IntPtr hwnd, ref Guid pgActionID, IntPtr pWVTData);

	/// <summary>
	/// C-08：校验文件的 Authenticode 签名是否有效。仅本地校验，不做联网吊销检查。
	/// </summary>
	private static bool VerifyAuthenticode(string P_0)
	{
		IntPtr intPtr = IntPtr.Zero;
		IntPtr intPtr2 = IntPtr.Zero;
		try
		{
			WINTRUST_FILE_INFO wINTRUST_FILE_INFO = new WINTRUST_FILE_INFO
			{
				cbStruct = (uint)Marshal.SizeOf(typeof(WINTRUST_FILE_INFO)),
				pcwszFilePath = P_0,
				hFile = IntPtr.Zero,
				pgKnownSubject = IntPtr.Zero
			};
			intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(WINTRUST_FILE_INFO)));
			Marshal.StructureToPtr(wINTRUST_FILE_INFO, intPtr, false);
			WINTRUST_DATA wINTRUST_DATA = new WINTRUST_DATA
			{
				cbStruct = (uint)Marshal.SizeOf(typeof(WINTRUST_DATA)),
				dwUIChoice = 2u,
				fdwRevocationChecks = 0u,
				dwUnionChoice = 1u,
				pFile = intPtr,
				dwStateAction = 0u,
				dwProvFlags = 16u
			};
			intPtr2 = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(WINTRUST_DATA)));
			Marshal.StructureToPtr(wINTRUST_DATA, intPtr2, false);
			Guid pgActionID = new Guid("00AAC56B-CD44-11d0-8CC2-00C04FC295EE");
			return WinVerifyTrust(IntPtr.Zero, ref pgActionID, intPtr2) == 0;
		}
		catch
		{
			return false;
		}
		finally
		{
			if (intPtr2 != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intPtr2);
			}
			if (intPtr != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}
	}

	/// <summary>
	/// C-09：复制后校验长度与 SHA-256，确保落盘文件与更新包一致。
	/// </summary>
	private static bool VerifySameContent(string P_0, string P_1)
	{
		try
		{
			FileInfo fileInfo = new FileInfo(P_0);
			FileInfo fileInfo2 = new FileInfo(P_1);
			if (fileInfo.Length != fileInfo2.Length)
			{
				return false;
			}
			using SHA256 sHA = SHA256.Create();
			using SHA256 sHA2 = SHA256.Create();
			using FileStream stream = File.OpenRead(P_0);
			using FileStream stream2 = File.OpenRead(P_1);
			return Convert.ToHexString(sHA.ComputeHash(stream)) == Convert.ToHexString(sHA2.ComputeHash(stream2));
		}
		catch
		{
			return false;
		}
	}

	internal sealed class A
	{
		[CompilerGenerated]
		private DateTime A_f_1;

		[CompilerGenerated]
		private c A_f_2;

		public DateTime FetchedAtUtc
		{
			[CompilerGenerated]
			get
			{
				return A_f_1;
			}
			[CompilerGenerated]
			set
			{
				A_f_1 = value;
			}
		}

		public c Info
		{
			[CompilerGenerated]
			get
			{
				return A_f_2;
			}
			[CompilerGenerated]
			set
			{
				A_f_2 = value;
			}
		}
	}

	internal const string A_1 = "https://api.github.com/repos/asybhc/A-Cup-of-Good-Tea/releases/latest";

	internal const string a = "https://github.com/asybhc/A-Cup-of-Good-Tea/releases";

	internal const string B = "A-Cup-of-Good-Tea-FileDedupTool-UpdateChecker";

	internal static readonly TimeSpan A_2 = TimeSpan.FromHours(18.0);

	private static readonly TimeSpan a_1 = TimeSpan.FromSeconds(8.0);

	internal static HttpMessageHandler A_3 = null;

	internal static string b = null;

	internal static string C = null;

	internal const string c = "manual";

	internal const string D = "startup";

	// 自动更新配置：默认值与旧版硬编码行为保持一致（18 小时缓存周期）。
	internal const int DefaultCacheHours = 18;

	private const int MinCacheHours = 1;

	private const int MaxCacheHours = 720;

	internal static int CacheHours
	{
		get
		{
			int num = DefaultCacheHours;
			global::A.x x2 = a_m_2();
			if (x2 != null && x2.UpdateCheckIntervalHours > 0)
			{
				num = x2.UpdateCheckIntervalHours;
			}
			if (num < MinCacheHours)
			{
				return MinCacheHours;
			}
			if (num > MaxCacheHours)
			{
				return MaxCacheHours;
			}
			return num;
		}
	}

	internal static TimeSpan CacheTtl => TimeSpan.FromHours(CacheHours);

	/// <summary>
	/// C-08 分流开关：是否允许安装未通过 Authenticode 校验的更新包。
	/// 默认 false（未签名包不自动更新）；旧配置缺该键时同样取 false，不视为配置损坏。
	/// </summary>
	internal static bool AllowUnsignedAutoUpdate
	{
		get
		{
			global::A.x x2 = a_m_2();
			return x2 != null && x2.AllowUnsignedAutoUpdate;
		}
	}

	/// <summary>
	/// C-08 分流：供更新对话框在安装前判定包是否通过验签。校验逻辑本身不变，只影响失败后的处置方式。
	/// </summary>
	internal static bool IsPackageSigned(string P_0)
	{
		return VerifyAuthenticode(P_0);
	}

	/// <summary>
	/// 清单地址：测试钩子 b 优先，其次配置 UpdateManifestUrl，最后内置 GitHub 接口。
	/// 配置值必须是 http/https 绝对地址，否则回落到内置地址。
	/// </summary>
	internal static string ManifestUrl
	{
		get
		{
			if (!string.IsNullOrWhiteSpace(b))
			{
				return b;
			}
			global::A.x x2 = a_m_2();
			string text = x2?.UpdateManifestUrl?.Trim();
			if (!string.IsNullOrEmpty(text) && Uri.TryCreate(text, UriKind.Absolute, out Uri uri) && (uri.Scheme == Uri.UriSchemeHttp || uri.Scheme == Uri.UriSchemeHttps))
			{
				return text;
			}
			return A_1;
		}
	}

	private static global::A.x a_m_2()
	{
		try
		{
			return global::A.Y.A_m_1();
		}
		catch
		{
			return null;
		}
	}

	internal static string CachePath => C ?? Path.Combine(global::A.Y.Dir, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alb());

	internal static int[] A_m_1(string P_0)
	{
		string text = (P_0 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).Trim();
		if (text.StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alC(), StringComparison.OrdinalIgnoreCase))
		{
			text = text.Substring(1);
		}
		int num = text.IndexOfAny(new char[3] { '-', '+', ' ' });
		if (num >= 0)
		{
			text = text.Substring(0, num);
		}
		string[] array = text.Split('.');
		int[] array2 = new int[3];
		for (int num2 = 0; num2 < array2.Length; num2++)
		{
			if (num2 < array.Length && int.TryParse(array[num2].Trim(), out var result) && result >= 0)
			{
				array2[num2] = result;
			}
		}
		return array2;
	}

	internal static int A_m_1(string P_0, string P_1)
	{
		int[] array = A_m_1(P_0);
		int[] array2 = A_m_1(P_1);
		for (int num = 0; num < 3; num++)
		{
			if (array[num] != array2[num])
			{
				if (array[num] <= array2[num])
				{
					return -1;
				}
				return 1;
			}
		}
		return 0;
	}

	internal static bool a_m_1(string P_0, string P_1)
	{
		return A_m_1(P_0, P_1) > 0;
	}

	internal static bool A_m_1(c P_0, global::A.x P_1)
	{
		if (P_0 == null || string.IsNullOrEmpty(P_0.Version))
		{
			return false;
		}
		if (!a_m_1(P_0.Version, global::A.r.c))
		{
			return false;
		}
		if (P_1 != null && string.Equals(P_1.SkippedVersion, P_0.Version, StringComparison.OrdinalIgnoreCase))
		{
			return false;
		}
		return true;
	}

	internal static string A_m_1(long P_0)
	{
		if (P_0 <= 0)
		{
			return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bE();
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
			return ((double)P_0 / 1024.0).ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alc()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BE();
		}
		return P_0 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alD();
	}

	internal static string a_m_1(string P_0)
	{
		if (!string.Equals(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDl(), StringComparison.OrdinalIgnoreCase))
		{
			return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iz();
		}
		return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDl();
	}

	internal static bool B_m_1(string P_0)
	{
		return a_m_1(P_0) != _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDl();
	}

	internal static D A_m_1(bool P_0, CancellationToken P_1)
	{
		A a2 = a_m_1();
		if (!P_0 && a2 != null && a2.Info != null && DateTime.UtcNow - a2.FetchedAtUtc < CacheTtl)
		{
			return new D
			{
				Info = a2.Info,
				FromCache = true,
				FetchedAtUtc = a2.FetchedAtUtc
			};
		}
		try
		{
			c c2 = b_m_1(A_m_1(P_1));
			D d2 = new D
			{
				Info = c2,
				FetchedAtUtc = DateTime.UtcNow
			};
			A_m_1(d2.FetchedAtUtc, c2);
			return d2;
		}
		catch (OperationCanceledException) when (P_1.IsCancellationRequested)
		{
			throw;
		}
		catch (Exception ex2)
		{
			if (a2 != null && a2.Info != null)
			{
				return new D
				{
					Info = a2.Info,
					FromCache = true,
					FetchedAtUtc = a2.FetchedAtUtc,
					Error = A_m_1(ex2)
				};
			}
			return new D
			{
				Error = A_m_1(ex2)
			};
		}
	}

	private static string A_m_1(CancellationToken P_0)
	{
		HttpMessageHandler a_ = A_3;
		HttpMessageHandler httpMessageHandler = a_;
		if (httpMessageHandler == null)
		{
			httpMessageHandler = new HttpClientHandler
			{
				AutomaticDecompression = (DecompressionMethods.GZip | DecompressionMethods.Deflate)
			};
		}
		using HttpClient httpClient = new HttpClient(httpMessageHandler, a_ == null);
		httpClient.Timeout = a_1;
		httpClient.DefaultRequestHeaders.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAh(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ald());
		httpClient.DefaultRequestHeaders.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAf(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alE());
		using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, ManifestUrl);
		using CancellationTokenSource cancellationTokenSource = new CancellationTokenSource(a_1);
		using CancellationTokenSource cancellationTokenSource2 = CancellationTokenSource.CreateLinkedTokenSource(P_0, cancellationTokenSource.Token);
		using HttpResponseMessage httpResponseMessage = httpClient.SendAsync(request, HttpCompletionOption.ResponseContentRead, cancellationTokenSource2.Token).GetAwaiter().GetResult();
		string result = httpResponseMessage.Content.ReadAsStringAsync().GetAwaiter().GetResult();
		if (httpResponseMessage.StatusCode == HttpStatusCode.Forbidden || httpResponseMessage.StatusCode == HttpStatusCode.TooManyRequests)
		{
			throw new global::a.v(global::a.V.b, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alF());
		}
		if (!httpResponseMessage.IsSuccessStatusCode)
		{
			throw new global::a.v(global::a.V.b, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alf() + (int)httpResponseMessage.StatusCode + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ah() + E_m_1(result));
		}
		return result;
	}

	private static string A_m_1(Exception P_0)
	{
		if (P_0 is OperationCanceledException)
		{
			return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alG();
		}
		return (P_0.Message ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alg()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alH();
	}

	internal static c b_m_1(string P_0)
	{
		string text = (P_0 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).Trim();
		if (text.Length == 0)
		{
			throw new global::a.v(global::a.V.B, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alh());
		}
		JsonElement rootElement;
		try
		{
			// C-21：JsonDocument 使用池化缓冲，必须释放；RootElement 先 Clone 再返回。
			using JsonDocument jsonDocument = JsonDocument.Parse(text);
			rootElement = jsonDocument.RootElement.Clone();
		}
		catch (JsonException)
		{
			throw new global::a.v(global::a.V.C, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alI() + E_m_1(text) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ln());
		}
		if (rootElement.ValueKind != JsonValueKind.Object)
		{
			throw new global::a.v(global::a.V.C, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ali());
		}
		string text2 = A_m_1(rootElement, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alJ());
		if (string.IsNullOrEmpty(text2))
		{
			throw new global::a.v(global::a.V.C, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alj());
		}
		c c2 = new c
		{
			Tag = text2,
			Version = C_m_1(text2),
			Title = A_m_1(rootElement, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zP()),
			Notes = A_m_1(rootElement, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alK()),
			HtmlUrl = A_m_1(rootElement, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alk()),
			PublishedAt = A_m_1(rootElement, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alL())
		};
		C c3 = A_m_1(rootElement, global::A.T.IsTestBuild);
		if (c3 != null)
		{
			c2.AssetName = c3.Name;
			c2.AssetUrl = c3.Url;
			c2.AssetSize = c3.Size;
			c2.Digest = c3.Digest;
		}
		return c2;
	}

	internal static C A_m_1(JsonElement P_0, bool P_1)
	{
		if (!P_0.TryGetProperty(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.all(), out var value) || value.ValueKind != JsonValueKind.Array)
		{
			return null;
		}
		C c2 = null;
		C c3 = null;
		C c4 = null;
		foreach (JsonElement item in value.EnumerateArray())
		{
			if (item.ValueKind != JsonValueKind.Object)
			{
				continue;
			}
			string text = A_m_1(item, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zP());
			string text2 = A_m_1(item, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alM());
			if (string.IsNullOrEmpty(text2))
			{
				continue;
			}
			long size = a_m_1(item, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zZ());
			string digest = A_m_1(item, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alm());
			C c5 = new C
			{
				Name = text,
				Url = text2,
				Size = size,
				Digest = digest
			};
			if (c4 == null)
			{
				c4 = c5;
			}
			if (text.EndsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alN(), StringComparison.OrdinalIgnoreCase))
			{
				if (c2 == null)
				{
					c2 = c5;
				}
				string value2 = (P_1 ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Dx() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.DX());
				if (text.IndexOf(value2, StringComparison.OrdinalIgnoreCase) >= 0)
				{
					c3 = c5;
					break;
				}
			}
		}
		return c3 ?? c2 ?? c4;
	}

	internal static string C_m_1(string P_0)
	{
		string text = (P_0 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).Trim();
		if (text.StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alC(), StringComparison.OrdinalIgnoreCase))
		{
			text = text.Substring(1);
		}
		int num = text.IndexOfAny(new char[3] { '-', '+', ' ' });
		if (num >= 0)
		{
			text = text.Substring(0, num);
		}
		return text;
	}

	internal static d A_m_1(c P_0, string P_1, Action<long, long> P_2, CancellationToken P_3)
	{
		if (P_0 == null || string.IsNullOrEmpty(P_0.AssetUrl))
		{
			return new d
			{
				Error = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aln()
			};
		}
		string text = (P_0.Digest ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).Trim();
		if (!text.StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alO(), StringComparison.OrdinalIgnoreCase))
		{
			return new d
			{
				Error = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alo()
			};
		}
		try
		{
			Directory.CreateDirectory(P_1);
			string path = c_m_1(string.IsNullOrEmpty(P_0.AssetName) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alP() : P_0.AssetName);
			string text2 = Path.Combine(P_1, path);
			string text3 = text2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alp();
			if (File.Exists(text3))
			{
				File.Delete(text3);
			}
			long arg = P_0.AssetSize;
			long num = 0L;
			byte[] hash;
			using (HttpClientHandler handler = new HttpClientHandler
			{
				AutomaticDecompression = (DecompressionMethods.GZip | DecompressionMethods.Deflate)
			})
			{
				using HttpClient httpClient = new HttpClient(handler, disposeHandler: true);
				using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, P_0.AssetUrl);
				httpClient.Timeout = TimeSpan.FromMinutes(30.0);
				httpClient.DefaultRequestHeaders.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAh(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ald());
				using HttpResponseMessage httpResponseMessage = httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, P_3).GetAwaiter().GetResult();
				if (!httpResponseMessage.IsSuccessStatusCode)
				{
					return new d
					{
						Error = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alQ() + (int)httpResponseMessage.StatusCode
					};
				}
				long num2 = httpResponseMessage.Content.Headers.ContentLength ?? (-1);
				if (num2 > 0)
				{
					arg = num2;
				}
				using Stream stream = httpResponseMessage.Content.ReadAsStreamAsync().GetAwaiter().GetResult();
				using FileStream fileStream = new FileStream(text3, FileMode.Create, FileAccess.Write, FileShare.None);
				using SHA256 sHA = SHA256.Create();
				byte[] array = new byte[81920];
				while (true)
				{
					P_3.ThrowIfCancellationRequested();
					int num3 = stream.Read(array, 0, array.Length);
					if (num3 <= 0)
					{
						break;
					}
					fileStream.Write(array, 0, num3);
					sHA.TransformBlock(array, 0, num3, null, 0);
					num += num3;
					P_2?.Invoke(num, arg);
				}
				sHA.TransformFinalBlock(new byte[0], 0, 0);
				hash = sHA.Hash;
			}
			string text4 = text.Substring(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alO().Length).Trim().ToLowerInvariant();
			string text5 = Convert.ToHexString(hash).ToLowerInvariant();
			if (!string.Equals(text4, text5, StringComparison.Ordinal))
			{
				try
				{
					File.Delete(text3);
				}
				catch
				{
				}
				return new d
				{
					Error = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alq() + text4 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alR() + text5
				};
			}
			if (File.Exists(text2))
			{
				File.Delete(text2);
			}
			File.Move(text3, text2);
			return new d
			{
				Ok = true,
				FilePath = text2
			};
		}
		catch (OperationCanceledException)
		{
			throw;
		}
		catch (Exception ex2)
		{
			return new d
			{
				Error = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alr() + ex2.Message
			};
		}
	}

	internal static string c_m_1(string P_0)
	{
		string text = Path.GetFileName(P_0 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
		char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
		foreach (char oldChar in invalidFileNameChars)
		{
			text = text.Replace(oldChar, '_');
		}
		if (!string.IsNullOrWhiteSpace(text))
		{
			return text;
		}
		return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alP();
	}

	internal static string A_m_1(string P_0, string P_1, Action<string> P_2)
	{
		if (!File.Exists(P_0))
		{
			return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alS() + P_0;
		}
		if (!File.Exists(P_1))
		{
			return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.als() + P_1;
		}
		// C-08：安装前校验更新包的 Authenticode 签名。签名无效时不再静默替换程序，
		// 而是明确提示风险并由用户显式确认（默认按钮为“否”），避免被篡改的更新包直接落盘。
		if (!VerifyAuthenticode(P_0))
		{
			// C-08 分流：禁止未签名包自动更新时，直接拒绝安装，不弹“是否继续”框，也不做任何替换。
			// 允许时仍走原有“是否继续”确认分支（默认否），原有分支与后续重试/回滚逻辑保持不变。
			if (!AllowUnsignedAutoUpdate)
			{
				return global::a.Q.EnMode ? "Automatic installation is disabled for update packages that fail digital signature verification. Please download and install it manually from the release page." : "该更新包未通过数字签名校验，已禁止自动安装。请前往发布页手动下载安装。";
			}
			string text7 = global::a.Q.EnMode ? "The update package is not digitally signed, or its signature could not be verified. Installing it may run tampered code. Continue anyway?" : "更新包未通过数字签名校验，可能已被篡改。继续安装存在安全风险，是否仍要继续？";
			if (MessageBox.Show(text7, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOG()), MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
			{
				return global::a.Q.EnMode ? "Installation cancelled: the update package failed signature verification." : "已取消安装：更新包未通过数字签名校验。";
			}
		}
		string text = P_1 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alT();
		try
		{
			if (File.Exists(text))
			{
				File.Delete(text);
			}
		}
		catch (Exception ex)
		{
			return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alt() + ex.Message;
		}
		try
		{
			File.Move(P_1, text);
		}
		catch (Exception ex2)
		{
			return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alU() + ex2.Message;
		}
		try
		{
			// C-09：先复制到临时文件并校验长度与 SHA-256，通过后再原子改名覆盖，
			// 避免复制中断/磁盘写入不完整导致的“半截程序”。
			string text8 = P_1 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alT() + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alT();
			if (File.Exists(text8))
			{
				File.Delete(text8);
			}
			File.Copy(P_0, text8, overwrite: true);
			if (!VerifySameContent(P_0, text8))
			{
				try
				{
					File.Delete(text8);
				}
				catch
				{
				}
				B_m_1(text, P_1);
				return global::a.Q.EnMode ? "The copied update file failed integrity verification. The previous version has been restored." : "更新文件复制后校验失败，已恢复原程序。";
			}
			File.Move(text8, P_1, overwrite: true);
		}
		catch (Exception ex3)
		{
			B_m_1(text, P_1);
			return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alu() + ex3.Message;
		}
		try
		{
			P_2(P_1);
		}
		catch (Exception ex4)
		{
			try
			{
				if (File.Exists(P_1))
				{
					File.Delete(P_1);
				}
			}
			catch
			{
			}
			B_m_1(text, P_1);
			return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alV() + ex4.Message;
		}
		try
		{
			File.Delete(P_0);
		}
		catch
		{
		}
		return null;
	}

	private static void B_m_1(string P_0, string P_1)
	{
		try
		{
			if (File.Exists(P_0))
			{
				if (File.Exists(P_1))
				{
					File.Delete(P_1);
				}
				File.Move(P_0, P_1);
			}
		}
		catch
		{
		}
	}

	internal static void A_m_1()
	{
		try
		{
			string processPath = Environment.ProcessPath;
			if (!string.IsNullOrEmpty(processPath))
			{
				string path = processPath + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alT();
				if (File.Exists(path))
				{
					File.Delete(path);
				}
			}
		}
		catch
		{
		}
	}

	internal static void D_m_1(string P_0)
	{
		// C-23：只允许启动真实存在的可执行文件，避免把任意路径（脚本/快捷方式/远程路径）交给 ShellExecute。
		if (string.IsNullOrWhiteSpace(P_0) || !File.Exists(P_0))
		{
			global::B.p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D() + "拒绝启动不存在的程序：" + P_0);
			return;
		}
		string extension = Path.GetExtension(P_0).ToLowerInvariant();
		if (extension != ".exe" && extension != ".msi" && extension != ".bat" && extension != ".cmd")
		{
			global::B.p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D() + "拒绝启动非可执行文件：" + P_0);
			return;
		}
		Process.Start(new ProcessStartInfo
		{
			FileName = P_0,
			UseShellExecute = true,
			WorkingDirectory = (Path.GetDirectoryName(P_0) ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D())
		});
	}

	internal static void d(string P_0)
	{
		if (string.IsNullOrWhiteSpace(P_0))
		{
			P_0 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alv();
		}
		// C-23：只允许通过默认浏览器打开 http/https 链接。
		if (!Uri.TryCreate(P_0, UriKind.Absolute, out Uri uri) || (uri.Scheme != Uri.UriSchemeHttp && uri.Scheme != Uri.UriSchemeHttps))
		{
			global::B.p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D() + "拒绝打开非 http/https 链接：" + P_0);
			return;
		}
		Process.Start(new ProcessStartInfo
		{
			FileName = P_0,
			UseShellExecute = true
		});
	}

	internal static A a_m_1()
	{
		try
		{
			string cachePath = CachePath;
			if (!File.Exists(cachePath))
			{
				return null;
			}
			return JsonSerializer.Deserialize<A>(File.ReadAllText(cachePath, Encoding.UTF8));
		}
		catch
		{
			return null;
		}
	}

	internal static void A_m_1(DateTime P_0, c P_1)
	{
		try
		{
			Directory.CreateDirectory(Path.GetDirectoryName(CachePath) ?? global::A.Y.Dir);
			File.WriteAllText(CachePath, JsonSerializer.Serialize(new A
			{
				FetchedAtUtc = P_0,
				Info = P_1
			}), new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
		}
		catch
		{
		}
	}

	internal static bool A_m_1(A P_0, DateTime P_1)
	{
		if (P_0 != null && P_0.Info != null)
		{
			return P_1 - P_0.FetchedAtUtc < CacheTtl;
		}
		return false;
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
		return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
	}

	private static long a_m_1(JsonElement P_0, string P_1)
	{
		if (!P_0.TryGetProperty(P_1, out var value) || value.ValueKind != JsonValueKind.Number)
		{
			return 0L;
		}
		try
		{
			long value2;
			return value.TryGetInt64(out value2) ? value2 : 0;
		}
		catch
		{
			return 0L;
		}
	}

	private static string E_m_1(string P_0)
	{
		P_0 = (P_0 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).Replace(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bc(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aH()).Replace(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BD(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aH());
		if (P_0.Length > 100)
		{
			return P_0.Substring(0, 100) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.j();
		}
		return P_0;
	}
}
internal sealed class e : Form
{
	[CompilerGenerated]
	private static class A
	{
		public static Action<string> A_f_1;
	}

	[CompilerGenerated]
	private sealed class a
	{
		public e A;

		public string A_1;

		internal d A_m_1()
		{
			return E.A_m_1(A.A_1, A_1, (long P_0, long P_1) =>
			{
				if (A.IsDisposed)
				{
					return;
				}
				try
				{
					A.BeginInvoke(() =>
					{
						if (!A.IsDisposed && !A.A_5.IsDisposed)
						{
							if (P_1 > 0)
							{
								int num = (int)Math.Min(100L, P_0 * 100 / P_1);
								A.A_5.Value = num;
								A.A_6.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOd(), E.A_m_1(P_0), E.A_m_1(P_1), num);
							}
							else
							{
								A.A_6.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOE()) + E.A_m_1(P_0);
							}
						}
					});
				}
				catch
				{
				}
			}, A.A_7.Token);
		}

		internal void A_m_1(long P_0, long P_1)
		{
			if (A.IsDisposed)
			{
				return;
			}
			try
			{
				A.BeginInvoke(() =>
				{
					if (!A.IsDisposed && !A.A_5.IsDisposed)
					{
						if (P_1 > 0)
						{
							int num = (int)Math.Min(100L, P_0 * 100 / P_1);
							A.A_5.Value = num;
							A.A_6.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOd(), E.A_m_1(P_0), E.A_m_1(P_1), num);
						}
						else
						{
							A.A_6.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOE()) + E.A_m_1(P_0);
						}
					}
				});
			}
			catch
			{
			}
		}
	}

	[CompilerGenerated]
	private sealed class B
	{
		public long A;

		public long a;

		public a A_1;

		internal void A_m_1()
		{
			if (!A_1.A.IsDisposed && !A_1.A.A_5.IsDisposed)
			{
				if (A > 0)
				{
					int num = (int)Math.Min(100L, a * 100 / A);
					A_1.A.A_5.Value = num;
					A_1.A.A_6.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOd(), E.A_m_1(a), E.A_m_1(A), num);
				}
				else
				{
					A_1.A.A_6.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOE()) + E.A_m_1(a);
				}
			}
		}
	}

	private readonly c A_1;

	private readonly global::A.x A_2;

	private readonly global::b.Y A_3;

	internal Button A_4;

	internal Button a_1;

	internal Button B_1;

	internal Button b_1;

	internal Button C;

	internal ProgressBar A_5;

	internal Label A_6;

	private CancellationTokenSource A_7;

	private bool A_8;

	internal e(c P_0, global::A.x P_1, global::b.Y P_2)
	{
		A_1 = P_0 ?? new c();
		A_2 = P_1 ?? new global::A.x();
		A_3 = P_2 ?? global::b.Y.A_m_1();
		Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alW());
		Icon = global::A.R.App;
		Font = global::B.Q.A_m_1(10f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(760, 430);
		MinimumSize = new Size(680, 400);
		StartPosition = FormStartPosition.CenterParent;
		MaximizeBox = false;
		MinimizeBox = false;
		ShowInTaskbar = false;
		BackColor = A_3.A;
		ForeColor = A_3.b;
		A_m_1();
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
		for (int num = 0; num < 5; num++)
		{
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
		}
		tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		Controls.Add(tableLayoutPanel);
		Label label = new Label();
		label.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alw(), A_1.Version, global::A.r.c);
		label.AutoSize = true;
		label.Font = global::B.Q.A_m_1(13f, FontStyle.Bold);
		label.ForeColor = A_3.b;
		label.Margin = new Padding(0, 0, 0, 10);
		Label control = label;
		tableLayoutPanel.Controls.Add(control, 0, 0);
		label = new Label();
		label.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alX(), string.IsNullOrEmpty(A_1.AssetName) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bE() : A_1.AssetName, A_1.SizeText, A_m_1(A_1.PublishedAt));
		label.AutoSize = true;
		label.MaximumSize = new Size(700, 0);
		label.ForeColor = A_3.I;
		label.Margin = new Padding(0, 0, 0, 10);
		Label control2 = label;
		tableLayoutPanel.Controls.Add(control2, 0, 1);
		TextBox control3 = new TextBox
		{
			Dock = DockStyle.Fill,
			Multiline = true,
			ReadOnly = true,
			ScrollBars = ScrollBars.Vertical,
			BackColor = A_3.c,
			ForeColor = A_3.D,
			BorderStyle = BorderStyle.FixedSingle,
			Font = global::B.Q.A_m_1(9.5f),
			Text = (string.IsNullOrEmpty(A_1.Notes) ? global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alx()) : A_1.Notes),
			Margin = new Padding(0, 0, 0, 8)
		};
		tableLayoutPanel.Controls.Add(control3, 0, 2);
		A_5 = new ProgressBar
		{
			Dock = DockStyle.Fill,
			Minimum = 0,
			Maximum = 100,
			Height = 20,
			Margin = new Padding(0, 0, 0, 4)
		};
		tableLayoutPanel.Controls.Add(A_5, 0, 3);
		A_6 = new Label
		{
			Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alY()),
			AutoSize = true,
			// C-08：限制最大宽度，保证最小窗口（680）下长文案换行而不被右侧裁掉。
			MaximumSize = new Size(600, 0),
			ForeColor = A_3.I,
			Margin = new Padding(0, 0, 0, 10)
		};
		tableLayoutPanel.Controls.Add(A_6, 0, 4);
		FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel
		{
			Dock = DockStyle.Bottom,
			AutoSize = true,
			FlowDirection = FlowDirection.LeftToRight,
			WrapContents = true,
			Margin = new Padding(0)
		};
		A_4 = A_m_1(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aly()), true);
		A_4.Click += delegate
		{
			C_m_1();
		};
		a_1 = A_m_1(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alZ()), false);
		a_1.Click += delegate
		{
			a_m_1();
		};
		B_1 = A_m_1(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alz()), false);
		B_1.Click += delegate
		{
			B_m_1();
		};
		b_1 = A_m_1(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMA()), false);
		b_1.Click += delegate
		{
			DialogResult = DialogResult.Cancel;
			Close();
		};
		C = A_m_1(global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMa()), false);
		C.Click += delegate
		{
			b_m_1();
		};
		C.Enabled = false;
		flowLayoutPanel.Controls.Add(A_4);
		flowLayoutPanel.Controls.Add(a_1);
		flowLayoutPanel.Controls.Add(B_1);
		flowLayoutPanel.Controls.Add(b_1);
		flowLayoutPanel.Controls.Add(C);
		tableLayoutPanel.Controls.Add(flowLayoutPanel, 0, 5);
		AcceptButton = A_4;
		CancelButton = b_1;
		FormClosing += delegate
		{
			b_m_1();
		};
		// C-08 分流：清单不提供包签名状态，先按“当前程序是否签名”决定默认展示。
		// 当前程序未签名且未允许未签名自动更新时，默认引导到下载页；「下载并更新」入口保留，
		// 若新包实际已签名仍可正常安装；最终处置仍以下载后的验签结果为准。
		if (!E.AllowUnsignedAutoUpdate && !E.IsPackageSigned(Environment.ProcessPath))
		{
			D_m_1(false);
		}
	}

	private Button A_m_1(string P_0, bool P_1)
	{
		Button button = new Button();
		button.Text = P_0;
		button.AutoSize = true;
		button.MinimumSize = new Size(0, 36);
		button.Padding = new Padding(14, 4, 14, 4);
		button.BackColor = (P_1 ? A_3.f : A_3.E);
		button.ForeColor = (P_1 ? A_3.G : A_3.e);
		button.FlatStyle = FlatStyle.Flat;
		button.Margin = new Padding(0, 4, 10, 0);
		button.FlatAppearance.BorderColor = (P_1 ? A_3.f : A_3.B);
		return button;
	}

	internal static string A_m_1(string P_0)
	{
		if (string.IsNullOrWhiteSpace(P_0))
		{
			return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bE();
		}
		if (DateTime.TryParse(P_0, out var result))
		{
			return result.ToLocalTime().ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.q());
		}
		return P_0;
	}

	private void a_m_1()
	{
		try
		{
			E.d(string.IsNullOrEmpty(A_1.HtmlUrl) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alv() : A_1.HtmlUrl);
		}
		catch (Exception ex)
		{
			MessageBox.Show(this, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMB()) + ex.Message, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bB()), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private void B_m_1()
	{
		try
		{
			A_2.SkippedVersion = A_1.Version ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			global::A.Y.A_m_1(A_2);
			global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMb() + A_2.SkippedVersion + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aMC());
		}
		catch
		{
		}
		DialogResult = DialogResult.OK;
		Close();
	}

	private void A_m_1(bool P_0)
	{
		A_8 = P_0;
		A_4.Enabled = !P_0;
		a_1.Enabled = !P_0;
		B_1.Enabled = !P_0;
		b_1.Enabled = !P_0;
		C.Enabled = P_0;
	}

	/// <summary>
	/// C-08 分流：未签名包不提供自动安装，改为提示“发现新版本”并引导到发布页手动下载。
	/// P_0 = true：已确认下载到的包未通过验签，同时停用下载/取消按钮；
	/// P_0 = false：仅按当前程序未签名调整默认按钮，保留「下载并更新」入口。
	/// </summary>
	private void D_m_1(bool P_0)
	{
		if (P_0)
		{
			A_4.Enabled = false;
			C.Enabled = false;
			A_5.Value = 0;
			A_6.ForeColor = A_3.J;
			A_6.Text = global::a.Q.EnMode ? ("New version v" + A_1.Version + " is available, but the update package failed digital signature verification. Automatic update is disabled; please use \"Open download page\" to download and install it manually.") : ("发现新版本 v" + A_1.Version + "，但该更新包未通过数字签名校验，已停止自动更新。请点「打开下载页」手动下载安装。");
		}
		else
		{
			A_6.ForeColor = A_3.I;
			A_6.Text = global::a.Q.EnMode ? "This build is not digitally signed, so automatic update is disabled by default. Please use \"Open download page\" to download the new version manually." : "当前程序未通过数字签名校验，已默认关闭自动更新。请点「打开下载页」手动下载新版本。";
		}
		a_1.Text = global::a.Q.EnMode ? "Open download page" : "打开下载页";
		a_1.Enabled = true;
		B_1.Enabled = true;
		b_1.Enabled = true;
		// 未签名分流下回车默认打开下载页，避免误触发下载/安装。
		AcceptButton = a_1;
	}

	private void b_m_1()
	{
		try
		{
			if (A_7 != null)
			{
				A_7.Cancel();
			}
		}
		catch
		{
		}
	}

	private async void C_m_1()
	{
		if (A_8)
		{
			return;
		}
		A_m_1(true);
		A_7 = new CancellationTokenSource();
		A_5.Value = 0;
		A_6.ForeColor = A_3.I;
		A_6.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOe());
		string A_1 = Path.Combine(Path.GetTempPath(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOF());
		d d2;
		try
		{
			d2 = await Task.Run(() => E.A_m_1(this.A_1, A_1, (long P_0, long P_1) =>
			{
				if (IsDisposed)
				{
					return;
				}
				try
				{
					BeginInvoke(() =>
					{
						if (!IsDisposed && !A_5.IsDisposed)
						{
							if (P_1 > 0)
							{
								int num = (int)Math.Min(100L, P_0 * 100 / P_1);
								A_5.Value = num;
								A_6.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOd(), E.A_m_1(P_0), E.A_m_1(P_1), num);
							}
							else
							{
								A_6.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOE()) + E.A_m_1(P_0);
							}
						}
					});
				}
				catch
				{
				}
			}, A_7.Token));
		}
		catch (OperationCanceledException)
		{
			d2 = new d
			{
				Error = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOf())
			};
		}
		catch (Exception ex2)
		{
			d2 = new d
			{
				Error = ex2.Message
			};
		}
		if (IsDisposed)
		{
			return;
		}
		if (!d2.Ok)
		{
			A_m_1(false);
			A_5.Value = 0;
			bool flag = A_7 != null && A_7.IsCancellationRequested;
			A_6.ForeColor = (flag ? A_3.I : A_3.J);
			A_6.Text = d2.Error;
			if (!flag)
			{
				MessageBox.Show(this, d2.Error, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOG()), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			return;
		}
		// C-08 分流：下载完成且摘要校验通过后，再按包实际验签结果决定处置。
		// 未签名且未允许自动更新时，不弹“是否继续”，不替换程序，转为“发现新版本 + 打开下载页”。
		if (!E.IsPackageSigned(d2.FilePath) && !E.AllowUnsignedAutoUpdate)
		{
			A_m_1(false);
			D_m_1(true);
			try
			{
				File.Delete(d2.FilePath);
			}
			catch
			{
			}
			return;
		}
		A_5.Value = 100;
		A_6.ForeColor = A_3.j;
		A_6.Text = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOg());
		string processPath = Environment.ProcessPath;
		string text = E.A_m_1(d2.FilePath, processPath, E.D_m_1);
		if (text != null)
		{
			A_m_1(false);
			A_6.ForeColor = A_3.J;
			A_6.Text = text;
			MessageBox.Show(this, text, global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOG()), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		else
		{
			global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOH() + this.A_1.Version + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOh());
			Environment.Exit(0);
		}
	}

	[CompilerGenerated]
	private void A_m_1(object? _003Cp0_003E, EventArgs P_1)
	{
		C_m_1();
	}

	[CompilerGenerated]
	private void a_m_1(object? _003Cp0_003E, EventArgs P_1)
	{
		a_m_1();
	}

	[CompilerGenerated]
	private void B_m_1(object? _003Cp0_003E, EventArgs P_1)
	{
		B_m_1();
	}

	[CompilerGenerated]
	private void b_m_1(object? _003Cp0_003E, EventArgs P_1)
	{
		DialogResult = DialogResult.Cancel;
		Close();
	}

	[CompilerGenerated]
	private void C_m_1(object? _003Cp0_003E, EventArgs P_1)
	{
		b_m_1();
	}

	[CompilerGenerated]
	private void A_m_1(object? _003Cp0_003E, FormClosingEventArgs P_1)
	{
		b_m_1();
	}
}
