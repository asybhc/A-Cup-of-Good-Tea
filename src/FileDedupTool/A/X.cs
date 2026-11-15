using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;
using _003CPrivateImplementationDetails_003E_007B1262ED64_002DD0A6_002D499E_002D9510_002DF2240F018DBB_007D;
using a;

namespace A
{
	internal static class X
	{
		internal static bool A(W P_0, IEnumerable<KeyValuePair<string, string>> P_1)
		{
			if (P_0 == null || P_1 == null)
			{
				return false;
			}
			Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
			foreach (KeyValuePair<string, string> item in P_1)
			{
				if (!string.IsNullOrEmpty(item.Key) && !string.IsNullOrEmpty(item.Value))
				{
					dictionary[item.Key.Trim()] = item.Value.Trim();
				}
			}
			if (P_0.Id == v.a)
			{
				return dictionary.ContainsKey(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iu());
			}
			if (dictionary.ContainsKey(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iV()))
			{
				return dictionary.ContainsKey(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iv());
			}
			return false;
		}

		internal static string a(W P_0, IEnumerable<KeyValuePair<string, string>> P_1)
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
			if (P_1 != null)
			{
				foreach (KeyValuePair<string, string> item in P_1)
				{
					if (!string.IsNullOrEmpty(item.Key) && !string.IsNullOrEmpty(item.Value))
					{
						dictionary[item.Key.Trim()] = item.Value.Trim();
					}
				}
			}
			if (P_0 != null && P_0.Id == v.a)
			{
				if (!dictionary.TryGetValue(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iu(), out var value))
				{
					return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
				}
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iW() + global::a.z.B(value);
			}
			dictionary.TryGetValue(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iV(), out var value2);
			dictionary.TryGetValue(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iv(), out var value3);
			string text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			if (!string.IsNullOrEmpty(value2))
			{
				text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iw() + global::a.z.B(value2);
			}
			if (!string.IsNullOrEmpty(value3))
			{
				text = text + ((text.Length > 0) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bH() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iX() + global::a.z.B(value3);
			}
			return text;
		}

		internal static List<KeyValuePair<string, string>> A(string P_0)
		{
			List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
			string text = (P_0 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).Trim();
			if (text.StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ix(), StringComparison.OrdinalIgnoreCase))
			{
				text = text.Substring(7).Trim();
			}
			text = text.Trim('"', '\'', '{', '}');
			string[] array = text.Split(new char[3] { ';', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
			for (int num = 0; num < array.Length; num++)
			{
				string text2 = array[num].Trim().TrimEnd(',');
				int num2 = text2.IndexOf('=');
				if (num2 > 0)
				{
					string text3 = text2.Substring(0, num2).Trim().Trim('"');
					string text4 = text2.Substring(num2 + 1).Trim().Trim('"');
					if (text3.Length > 0 && text4.Length > 0)
					{
						list.Add(new KeyValuePair<string, string>(text3, text4));
					}
				}
			}
			return list;
		}
	}
	public sealed class x
	{
		[CompilerGenerated]
		private string A = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		[CompilerGenerated]
		private string a = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		[CompilerGenerated]
		private string B = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		[CompilerGenerated]
		private string b = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		[CompilerGenerated]
		private string C = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		[CompilerGenerated]
		private bool A_1 = true;

		[CompilerGenerated]
		private bool a_1 = true;

		[CompilerGenerated]
		private bool B_1;

		[CompilerGenerated]
		private bool b_1 = true;

		[CompilerGenerated]
		private bool C_1 = true;

		[CompilerGenerated]
		private bool c;

		[CompilerGenerated]
		private int A_2;

		[CompilerGenerated]
		private bool D;

		[CompilerGenerated]
		private int a_2 = 8;

		// C-15：图片独立保留规则下标，0 = 体积最大；旧配置缺省时保持 0。
		[CompilerGenerated]
		private int g_2;

		[CompilerGenerated]
		private bool d;

		[CompilerGenerated]
		private bool E = true;

		[CompilerGenerated]
		private int B_2 = 1;

		[CompilerGenerated]
		private int b_2;

		[CompilerGenerated]
		private int C_2;

		[CompilerGenerated]
		private bool e;

		[CompilerGenerated]
		private bool F = true;

		[CompilerGenerated]
		private bool f;

		[CompilerGenerated]
		private int c_1;

		[CompilerGenerated]
		private bool G;

		[CompilerGenerated]
		private bool g;

		[CompilerGenerated]
		private string c_2 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iY();

		[CompilerGenerated]
		private string D_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		[CompilerGenerated]
		private bool H = true;

		[CompilerGenerated]
		private bool h;

		[CompilerGenerated]
		private int D_2;

		[CompilerGenerated]
		private int d_1;

		[CompilerGenerated]
		private bool I;

		[CompilerGenerated]
		private bool i = true;

		[CompilerGenerated]
		private long A_3;

		[CompilerGenerated]
		private string d_2 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		[CompilerGenerated]
		private bool J = true;

		[CompilerGenerated]
		private bool j;

		[CompilerGenerated]
		private bool K;

		[CompilerGenerated]
		private int E_1 = 2;

		[CompilerGenerated]
		private bool k = true;

		[CompilerGenerated]
		private bool L;

		[CompilerGenerated]
		private string E_2 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BP();

		[CompilerGenerated]
		private string e_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		[CompilerGenerated]
		private string F_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bI();

		[CompilerGenerated]
		private int e_2 = 15;

		[CompilerGenerated]
		private int F_2 = 40;

		[CompilerGenerated]
		private bool l = true;

		[CompilerGenerated]
		private bool M;

		[CompilerGenerated]
		private double A_4;

		[CompilerGenerated]
		private double a_3;

		[CompilerGenerated]
		private bool m;

		[CompilerGenerated]
		private bool N;

		[CompilerGenerated]
		private string f_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iy();

		[CompilerGenerated]
		private string G_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		[CompilerGenerated]
		private string g_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		[CompilerGenerated]
		private string H_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iZ();

		[CompilerGenerated]
		private string h_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Dw();

		[CompilerGenerated]
		private string I_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		[CompilerGenerated]
		private int f_2 = 1500;

		[CompilerGenerated]
		private string i_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.io();

		[CompilerGenerated]
		private int G_2 = 3;

		[CompilerGenerated]
		private bool n;

		[CompilerGenerated]
		private string J_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		[CompilerGenerated]
		private string j_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iz();

		// 自动更新：清单地址。空 = 内置 GitHub releases/latest；旧配置缺此键时保持空。
		[CompilerGenerated]
		private string K_2 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		// 自动更新：清单缓存/检查周期（小时）。默认 18，与旧版硬编码值一致。
		[CompilerGenerated]
		private int L_2 = 18;

		// 自动更新：是否允许安装未通过 Authenticode 校验的更新包。
		// 默认 false：未签名包只提示并引导到发布页手动下载。旧配置缺此键时保持 false，不判为配置损坏。
		[CompilerGenerated]
		private bool M_2;

		[CompilerGenerated]
		private string K_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		[CompilerGenerated]
		private bool O;

		[CompilerGenerated]
		private long a_4 = 1L;

		[CompilerGenerated]
		private bool o;

		[CompilerGenerated]
		private bool P;

		[CompilerGenerated]
		private bool p;

		[CompilerGenerated]
		private string k_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		[CompilerGenerated]
		private Dictionary<string, x> A_5 = new Dictionary<string, x>();

		[CompilerGenerated]
		private string L_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		[CompilerGenerated]
		private string l_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		[CompilerGenerated]
		private string M_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		[CompilerGenerated]
		private string m_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		public string Source
		{
			[CompilerGenerated]
			get
			{
				return A;
			}
			[CompilerGenerated]
			set
			{
				A = value;
			}
		}

		public string Target
		{
			[CompilerGenerated]
			get
			{
				return a;
			}
			[CompilerGenerated]
			set
			{
				a = value;
			}
		}

		public string SpecDir
		{
			[CompilerGenerated]
			get
			{
				return B;
			}
			[CompilerGenerated]
			set
			{
				B = value;
			}
		}

		public string Keyword
		{
			[CompilerGenerated]
			get
			{
				return b;
			}
			[CompilerGenerated]
			set
			{
				b = value;
			}
		}

		public string Whitelist
		{
			[CompilerGenerated]
			get
			{
				return C;
			}
			[CompilerGenerated]
			set
			{
				C = value;
			}
		}

		public bool Step1
		{
			[CompilerGenerated]
			get
			{
				return A_1;
			}
			[CompilerGenerated]
			set
			{
				A_1 = value;
			}
		}

		public bool Step2
		{
			[CompilerGenerated]
			get
			{
				return a_1;
			}
			[CompilerGenerated]
			set
			{
				a_1 = value;
			}
		}

		public bool Step3
		{
			[CompilerGenerated]
			get
			{
				return B_1;
			}
			[CompilerGenerated]
			set
			{
				B_1 = value;
			}
		}

		public bool Step4
		{
			[CompilerGenerated]
			get
			{
				return b_1;
			}
			[CompilerGenerated]
			set
			{
				b_1 = value;
			}
		}

		public bool Step5
		{
			[CompilerGenerated]
			get
			{
				return C_1;
			}
			[CompilerGenerated]
			set
			{
				C_1 = value;
			}
		}

		public bool HashDedup
		{
			[CompilerGenerated]
			get
			{
				return c;
			}
			[CompilerGenerated]
			set
			{
				c = value;
			}
		}

		public int HashKeep
		{
			[CompilerGenerated]
			get
			{
				return A_2;
			}
			[CompilerGenerated]
			set
			{
				A_2 = value;
			}
		}

		public bool ImageDedup
		{
			[CompilerGenerated]
			get
			{
				return D;
			}
			[CompilerGenerated]
			set
			{
				D = value;
			}
		}

		public int ImageThreshold
		{
			[CompilerGenerated]
			get
			{
				return a_2;
			}
			[CompilerGenerated]
			set
			{
				a_2 = value;
			}
		}

		/// <summary>C-15：图片去重独立保留规则下标（0 = 体积最大，1 = 最新，2 = 最旧，3 = 文件名最短，4 = 路径最短）。</summary>
		public int ImageKeep
		{
			[CompilerGenerated]
			get
			{
				return g_2;
			}
			[CompilerGenerated]
			set
			{
				g_2 = value;
			}
		}

		public bool CleanEmptyDirs
		{
			[CompilerGenerated]
			get
			{
				return d;
			}
			[CompilerGenerated]
			set
			{
				d = value;
			}
		}

		public bool SuspectConfirm
		{
			[CompilerGenerated]
			get
			{
				return E;
			}
			[CompilerGenerated]
			set
			{
				E = value;
			}
		}

		public int NameScorePreset
		{
			[CompilerGenerated]
			get
			{
				return B_2;
			}
			[CompilerGenerated]
			set
			{
				B_2 = value;
			}
		}

		public int Conflict
		{
			[CompilerGenerated]
			get
			{
				return b_2;
			}
			[CompilerGenerated]
			set
			{
				b_2 = value;
			}
		}

		public int DeleteMode
		{
			[CompilerGenerated]
			get
			{
				return C_2;
			}
			[CompilerGenerated]
			set
			{
				C_2 = value;
			}
		}

		public bool AutoReleaseLock
		{
			[CompilerGenerated]
			get
			{
				return e;
			}
			[CompilerGenerated]
			set
			{
				e = value;
			}
		}

		public bool UndoRestoreRecycle
		{
			[CompilerGenerated]
			get
			{
				return F;
			}
			[CompilerGenerated]
			set
			{
				F = value;
			}
		}

		public bool DryRun
		{
			[CompilerGenerated]
			get
			{
				return f;
			}
			[CompilerGenerated]
			set
			{
				f = value;
			}
		}

		public int Mode
		{
			[CompilerGenerated]
			get
			{
				return c_1;
			}
			[CompilerGenerated]
			set
			{
				c_1 = value;
			}
		}

		public bool Dark
		{
			[CompilerGenerated]
			get
			{
				return G;
			}
			[CompilerGenerated]
			set
			{
				G = value;
			}
		}

		public bool OrganizeAutoOpenFolder
		{
			[CompilerGenerated]
			get
			{
				return g;
			}
			[CompilerGenerated]
			set
			{
				g = value;
			}
		}

		public string ThemeMode
		{
			[CompilerGenerated]
			get
			{
				return c_2;
			}
			[CompilerGenerated]
			set
			{
				c_2 = value;
			}
		}

		public string Lang
		{
			[CompilerGenerated]
			get
			{
				return D_1;
			}
			[CompilerGenerated]
			set
			{
				D_1 = value;
			}
		}

		public bool ClosePrompt
		{
			[CompilerGenerated]
			get
			{
				return H;
			}
			[CompilerGenerated]
			set
			{
				H = value;
			}
		}

		public bool CloseRememberToTray
		{
			[CompilerGenerated]
			get
			{
				return h;
			}
			[CompilerGenerated]
			set
			{
				h = value;
			}
		}

		public int WinW
		{
			[CompilerGenerated]
			get
			{
				return D_2;
			}
			[CompilerGenerated]
			set
			{
				D_2 = value;
			}
		}

		public int WinH
		{
			[CompilerGenerated]
			get
			{
				return d_1;
			}
			[CompilerGenerated]
			set
			{
				d_1 = value;
			}
		}

		public bool CloseToTray
		{
			[CompilerGenerated]
			get
			{
				return I;
			}
			[CompilerGenerated]
			set
			{
				I = value;
			}
		}

		public bool TrayBalloon
		{
			[CompilerGenerated]
			get
			{
				return i;
			}
			[CompilerGenerated]
			set
			{
				i = value;
			}
		}

		public long MinSizeKB
		{
			[CompilerGenerated]
			get
			{
				return A_3;
			}
			[CompilerGenerated]
			set
			{
				A_3 = value;
			}
		}

		public string ExcludeFolders
		{
			[CompilerGenerated]
			get
			{
				return d_2;
			}
			[CompilerGenerated]
			set
			{
				d_2 = value;
			}
		}

		public bool SkipHidden
		{
			[CompilerGenerated]
			get
			{
				return J;
			}
			[CompilerGenerated]
			set
			{
				J = value;
			}
		}

		public bool Hardlink
		{
			[CompilerGenerated]
			get
			{
				return j;
			}
			[CompilerGenerated]
			set
			{
				j = value;
			}
		}

		public bool AudioDedup
		{
			[CompilerGenerated]
			get
			{
				return K;
			}
			[CompilerGenerated]
			set
			{
				K = value;
			}
		}

		public int AudioToleranceSec
		{
			[CompilerGenerated]
			get
			{
				return E_1;
			}
			[CompilerGenerated]
			set
			{
				E_1 = value;
			}
		}

		public bool PreviewScan
		{
			[CompilerGenerated]
			get
			{
				return k;
			}
			[CompilerGenerated]
			set
			{
				k = value;
			}
		}

		public bool AiEnabled
		{
			[CompilerGenerated]
			get
			{
				return L;
			}
			[CompilerGenerated]
			set
			{
				L = value;
			}
		}

		public string AiBaseUrl
		{
			[CompilerGenerated]
			get
			{
				return E_2;
			}
			[CompilerGenerated]
			set
			{
				E_2 = value;
			}
		}

		public string AiApiKey
		{
			[CompilerGenerated]
			get
			{
				return e_1;
			}
			[CompilerGenerated]
			set
			{
				e_1 = value;
			}
		}

		public string AiModel
		{
			[CompilerGenerated]
			get
			{
				return F_1;
			}
			[CompilerGenerated]
			set
			{
				F_1 = value;
			}
		}

		public int AiTimeoutSec
		{
			[CompilerGenerated]
			get
			{
				return e_2;
			}
			[CompilerGenerated]
			set
			{
				e_2 = value;
			}
		}

		public int AiMaxGroups
		{
			[CompilerGenerated]
			get
			{
				return F_2;
			}
			[CompilerGenerated]
			set
			{
				F_2 = value;
			}
		}

		public bool AiAutoRun
		{
			[CompilerGenerated]
			get
			{
				return l;
			}
			[CompilerGenerated]
			set
			{
				l = value;
			}
		}

		public bool AiAutoApply
		{
			[CompilerGenerated]
			get
			{
				return M;
			}
			[CompilerGenerated]
			set
			{
				M = value;
			}
		}

		public double AiPriceInPerMillion
		{
			[CompilerGenerated]
			get
			{
				return A_4;
			}
			[CompilerGenerated]
			set
			{
				A_4 = value;
			}
		}

		public double AiPriceOutPerMillion
		{
			[CompilerGenerated]
			get
			{
				return a_3;
			}
			[CompilerGenerated]
			set
			{
				a_3 = value;
			}
		}

		public bool LanzouDisclaimerAccepted
		{
			[CompilerGenerated]
			get
			{
				return m;
			}
			[CompilerGenerated]
			set
			{
				m = value;
			}
		}

		public bool LanzouUploadEnabled
		{
			[CompilerGenerated]
			get
			{
				return N;
			}
			[CompilerGenerated]
			set
			{
				N = value;
			}
		}

		public string NetworkDuplicateFolderName
		{
			[CompilerGenerated]
			get
			{
				return f_1;
			}
			[CompilerGenerated]
			set
			{
				f_1 = value;
			}
		}

		public string NetworkDuplicateFolderPath
		{
			[CompilerGenerated]
			get
			{
				return G_1;
			}
			[CompilerGenerated]
			set
			{
				G_1 = value;
			}
		}

		public string LanzouLastLocalDir
		{
			[CompilerGenerated]
			get
			{
				return g_1;
			}
			[CompilerGenerated]
			set
			{
				g_1 = value;
			}
		}

		public string LanzouLastFolderId
		{
			[CompilerGenerated]
			get
			{
				return H_1;
			}
			[CompilerGenerated]
			set
			{
				H_1 = value;
			}
		}

		public string LanzouLastFolderName
		{
			[CompilerGenerated]
			get
			{
				return h_1;
			}
			[CompilerGenerated]
			set
			{
				h_1 = value;
			}
		}

		public string LanzouLastFolderChain
		{
			[CompilerGenerated]
			get
			{
				return I_1;
			}
			[CompilerGenerated]
			set
			{
				I_1 = value;
			}
		}

		public int LanzouRateLimitMs
		{
			[CompilerGenerated]
			get
			{
				return f_2;
			}
			[CompilerGenerated]
			set
			{
				f_2 = value;
			}
		}

		public string LanzouPlatform
		{
			[CompilerGenerated]
			get
			{
				return i_1;
			}
			[CompilerGenerated]
			set
			{
				i_1 = value;
			}
		}

		public int LanzouUploadWorkers
		{
			[CompilerGenerated]
			get
			{
				return G_2;
			}
			[CompilerGenerated]
			set
			{
				G_2 = value;
			}
		}

		public bool LanzouForceReupload
		{
			[CompilerGenerated]
			get
			{
				return n;
			}
			[CompilerGenerated]
			set
			{
				n = value;
			}
		}

		public string SkippedVersion
		{
			[CompilerGenerated]
			get
			{
				return J_1;
			}
			[CompilerGenerated]
			set
			{
				J_1 = value;
			}
		}

		public string UpdateCheckMode
		{
			[CompilerGenerated]
			get
			{
				return j_1;
			}
			[CompilerGenerated]
			set
			{
				j_1 = value;
			}
		}

		// 自动更新清单地址。留空使用内置 GitHub releases/latest；支持 http/https 绝对地址。
		public string UpdateManifestUrl
		{
			[CompilerGenerated]
			get
			{
				return K_2;
			}
			[CompilerGenerated]
			set
			{
				K_2 = value;
			}
		}

		// 自动更新清单缓存/检查周期（小时）。缺省 18；非法值在读取时回落到 18。
		public int UpdateCheckIntervalHours
		{
			[CompilerGenerated]
			get
			{
				return L_2;
			}
			[CompilerGenerated]
			set
			{
				L_2 = value;
			}
		}

		// 自动更新：是否允许安装未签名的更新包。默认 false（仅提示 + 打开下载页）。
		// 旧配置若缺少该键，反序列化后保持字段默认值 false，不会被当成配置损坏。
		public bool AllowUnsignedAutoUpdate
		{
			[CompilerGenerated]
			get
			{
				return M_2;
			}
			[CompilerGenerated]
			set
			{
				M_2 = value;
			}
		}

		public string FullScanDrives
		{
			[CompilerGenerated]
			get
			{
				return K_1;
			}
			[CompilerGenerated]
			set
			{
				K_1 = value;
			}
		}

		public bool FullScanIncludeZero
		{
			[CompilerGenerated]
			get
			{
				return O;
			}
			[CompilerGenerated]
			set
			{
				O = value;
			}
		}

		public long FullScanMinSizeKB
		{
			[CompilerGenerated]
			get
			{
				return a_4;
			}
			[CompilerGenerated]
			set
			{
				a_4 = value;
			}
		}

		public bool FullScanQuickOnly
		{
			[CompilerGenerated]
			get
			{
				return o;
			}
			[CompilerGenerated]
			set
			{
				o = value;
			}
		}

		public bool FullScanUseEverything
		{
			[CompilerGenerated]
			get
			{
				return P;
			}
			[CompilerGenerated]
			set
			{
				P = value;
			}
		}

		public bool FullScanPermanentDelete
		{
			[CompilerGenerated]
			get
			{
				return p;
			}
			[CompilerGenerated]
			set
			{
				p = value;
			}
		}

		public string AllowedApiDirectories
		{
			[CompilerGenerated]
			get
			{
				return k_1;
			}
			[CompilerGenerated]
			set
			{
				k_1 = value;
			}
		}

		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
		public Dictionary<string, x> Profiles
		{
			[CompilerGenerated]
			get
			{
				return A_5;
			}
			[CompilerGenerated]
			set
			{
				A_5 = value;
			}
		}

		public string SavedAt
		{
			[CompilerGenerated]
			get
			{
				return L_1;
			}
			[CompilerGenerated]
			set
			{
				L_1 = value;
			}
		}

		public string LastProfile
		{
			[CompilerGenerated]
			get
			{
				return l_1;
			}
			[CompilerGenerated]
			set
			{
				l_1 = value;
			}
		}

		public string LastSearchKeyword
		{
			[CompilerGenerated]
			get
			{
				return M_1;
			}
			[CompilerGenerated]
			set
			{
				M_1 = value;
			}
		}

		public string SearchBackend
		{
			[CompilerGenerated]
			get
			{
				return m_1;
			}
			[CompilerGenerated]
			set
			{
				m_1 = value;
			}
		}

		public x A_m_1()
		{
			x x2 = (x)MemberwiseClone();
			x2.Profiles = null;
			return x2;
		}
	}
}
namespace a
{
	internal sealed class X
	{
		[CompilerGenerated]
		private bool A;

		[CompilerGenerated]
		private bool a;

		[CompilerGenerated]
		private bool B;

		[CompilerGenerated]
		private string A_1;

		[CompilerGenerated]
		private string a_1;

		public bool Success
		{
			[CompilerGenerated]
			get
			{
				return A;
			}
			[CompilerGenerated]
			set
			{
				A = value;
			}
		}

		public bool SkippedTooLarge
		{
			[CompilerGenerated]
			get
			{
				return a;
			}
			[CompilerGenerated]
			set
			{
				a = value;
			}
		}

		public bool Instant
		{
			[CompilerGenerated]
			get
			{
				return B;
			}
			[CompilerGenerated]
			set
			{
				B = value;
			}
		}

		public string FileId
		{
			[CompilerGenerated]
			get
			{
				return A_1;
			}
			[CompilerGenerated]
			set
			{
				A_1 = value;
			}
		}

		public string Reason
		{
			[CompilerGenerated]
			get
			{
				return a_1;
			}
			[CompilerGenerated]
			set
			{
				a_1 = value;
			}
		}
	}
	internal static class x
	{
		internal static List<KeyValuePair<string, string>> A(string P_0, string P_1)
		{
			return new List<KeyValuePair<string, string>>
			{
				new KeyValuePair<string, string>(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zM(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CM()),
				new KeyValuePair<string, string>(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zm(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zN()),
				new KeyValuePair<string, string>(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zn(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zN()),
				new KeyValuePair<string, string>(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ce(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zO()),
				new KeyValuePair<string, string>(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zo(), string.IsNullOrWhiteSpace(P_1) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iZ() : P_1),
				new KeyValuePair<string, string>(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zP(), P_0 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D())
			};
		}

		internal static MultipartFormDataContent A(string P_0, string P_1, string P_2, long P_3, Action<long, long> P_4)
		{
			MultipartFormDataContent multipartFormDataContent = new MultipartFormDataContent();
			foreach (KeyValuePair<string, string> item in A(P_0, P_1))
			{
				multipartFormDataContent.Add(new StringContent(item.Value, Encoding.UTF8), item.Key);
			}
			Stream stream = new FileStream(P_2, FileMode.Open, FileAccess.Read, FileShare.Read);
			StreamContent streamContent = new StreamContent((P_4 == null) ? stream : new Y(stream, P_3, P_4));
			streamContent.Headers.ContentType = new MediaTypeHeaderValue(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zp());
			streamContent.Headers.ContentDisposition = new ContentDispositionHeaderValue(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zQ())
			{
				Name = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zq(),
				FileName = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JX() + A(P_0) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JX()
			};
			multipartFormDataContent.Add(streamContent);
			return multipartFormDataContent;
		}

		private static string A(string P_0)
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
	}
}
