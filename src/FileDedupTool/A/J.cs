using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007B1262ED64_002DD0A6_002D499E_002D9510_002DF2240F018DBB_007D;
using B;
using C;

namespace A
{
	public sealed class J
	{
		[CompilerGenerated]
		private string A;

		[CompilerGenerated]
		private string a;

		[CompilerGenerated]
		private int A_1;

		[CompilerGenerated]
		private long A_2;

		[CompilerGenerated]
		private int a_1;

		[CompilerGenerated]
		private int B;

		[CompilerGenerated]
		private long a_2;

		[CompilerGenerated]
		private List<string> A_3 = new List<string>();

		[CompilerGenerated]
		private List<i> A_4 = new List<i>();

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

		public string Time
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

		public int FilesScanned
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

		public long ScannedBytes
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

		public int GroupCount
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

		public int DuplicateFileCount
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

		public long ReclaimableBytes
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

		public List<string> Warnings
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

		public List<i> Groups
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
	}
	public sealed class j
	{
		[CompilerGenerated]
		private int A;

		[CompilerGenerated]
		private int a;

		[CompilerGenerated]
		private int B;

		[CompilerGenerated]
		private int b;

		[CompilerGenerated]
		private int C;

		[CompilerGenerated]
		private int c;

		[CompilerGenerated]
		private int D;

		[CompilerGenerated]
		private int d;

		[CompilerGenerated]
		private int E;

		[CompilerGenerated]
		private int e;

		[CompilerGenerated]
		private int F;

		[CompilerGenerated]
		private int f;

		[CompilerGenerated]
		private int G;

		[CompilerGenerated]
		private bool A_1;

		public int Renamed
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

		public int Deleted
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

		public int Moved
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

		public int Skipped
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

		public int ReadOnlyCleared
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

		public int MoveSkipped
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

		public int HashRemoved
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

		public int ImageRemoved
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

		public int DirsRemoved
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

		public int Protected
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

		public int AudioRemoved
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

		public int Hardlinked
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

		public int Excluded
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

		public bool DryRun
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
	}
}
namespace a
{
	public sealed class J : Exception
	{
		public J(string P_0)
			: base(P_0)
		{
		}
	}
	public static class j
	{
		private const string A = "f1d2a9|2026|AI大叔|dedup-guard";

		private static readonly bool A_1 = false;

		private static global::B.k A_2 = new global::B.k();

		private static global::B.M A_3;

		private static long A_4;

		private static long a;

		private static DateTime A_5 = DateTime.Now;

		private static bool a_1;

		private static bool B;

		private static bool b;

		/// <summary>
		/// C-01：调试构建专用开关。Release 构建不读取任何测试环境变量，
		/// 避免通过环境变量关闭更新检查、跳过配置持久化等。
		/// </summary>
		internal static bool DevSwitch(string P_0)
		{
#if DEBUG
			try
			{
				return Environment.GetEnvironmentVariable(P_0) == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CM();
			}
			catch
			{
				return false;
			}
#else
			return false;
#endif
		}

		private static global::C.a A_6 = new global::C.a();

		[CompilerGenerated]
		private static bool C;

		[CompilerGenerated]
		private static string a_2;

		public static bool IntegrityFailed
		{
			[CompilerGenerated]
			get
			{
				return C;
			}
			[CompilerGenerated]
			private set
			{
				C = value;
			}
		}

		public static string IntegrityMessage
		{
			[CompilerGenerated]
			get
			{
				return a_2;
			}
			[CompilerGenerated]
			private set
			{
				a_2 = value;
			}
		}

		public static global::B.k Current
		{
			get
			{
				A_m_1();
				return A_2;
			}
		}

		public static DateTime EffectiveNow
		{
			get
			{
				A_m_1();
				return A_5;
			}
		}

		public static bool Licensed
		{
			get
			{
				A_m_1();
				if (A_1)
				{
					return true;
				}
				if (A_4 != 0L && a == A_4 && A_2 != null)
				{
					return A_2.Ok;
				}
				return false;
			}
		}

		public static bool Active => Licensed;

		public static bool TrialActive
		{
			get
			{
				A_m_1();
				if (A_6 != null)
				{
					return A_6.a_f_1;
				}
				return false;
			}
		}

		public static bool TrialExpired
		{
			get
			{
				A_m_1();
				if (A_6 != null && A_6.A)
				{
					return A_6.B;
				}
				return false;
			}
		}

		public static int TrialDaysLeft
		{
			get
			{
				A_m_1();
				if (A_6 != null)
				{
					return A_6.A_2;
				}
				return 0;
			}
		}

		public static bool TrialNoticeShown
		{
			get
			{
				A_m_1();
				if (A_6 != null)
				{
					return A_6.C;
				}
				return false;
			}
		}

		public static bool Pro
		{
			get
			{
				if (A_1)
				{
					return true;
				}
				if (TrialActive)
				{
					return true;
				}
				if (Licensed && A_2 != null && A_2.A_2 != null)
				{
					return A_2.A_2.C == 1;
				}
				return false;
			}
		}

		public static bool Authorized
		{
			get
			{
				if (!Licensed)
				{
					return TrialActive;
				}
				return true;
			}
		}

		public static string StatusText
		{
			get
			{
				A_m_1();
				if (Licensed)
				{
					if (A_2 == null)
					{
						return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lp();
					}
					if (!A_2.IsForever)
					{
						return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LQ() + A_2.Expiry.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CL()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bH() + A_2.A_2.EditionName + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lq() + DaysLeft + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LR();
					}
					return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lr() + A_2.A_2.EditionName;
				}
				if (TrialActive)
				{
					return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LS() + TrialDaysLeft + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ls();
				}
				if (A_2 != null && A_2.A == global::B.K.c)
				{
					return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LT();
				}
				if (TrialExpired)
				{
					if (A_6 == null || !A_6.b)
					{
						return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lt();
					}
					return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LU();
				}
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lu();
			}
		}

		public static string MachineCode => global::B.J.Formatted;

		public static bool DebuggerDetected
		{
			get
			{
				A_m_1();
				return B;
			}
		}

		public static bool IsForever
		{
			get
			{
				if (A_2 != null)
				{
					return A_2.IsForever;
				}
				return false;
			}
		}

		public static int DaysLeft
		{
			get
			{
				if (A_2 != null)
				{
					return A_2.A_m_1(A_5);
				}
				return 0;
			}
		}

		public static bool CanExecute
		{
			get
			{
				A_m_1();
				if (!Licensed)
				{
					return TrialActive;
				}
				return true;
			}
		}

		public static bool ShouldShowTrialNotice
		{
			get
			{
				A_m_1();
				if (A_6 != null && A_6.A && A_6.B)
				{
					return !A_6.C;
				}
				return false;
			}
		}

		public static void A_m_1()
		{
			if (!a_1)
			{
				a_m_1();
			}
		}

		public static void a_m_1()
		{
			a_1 = true;
#if DEBUG
			// C-01：测试授权开关仅在 Debug 构建生效。Release 构建下环境变量不再能把授权置为永久 Pro。
			if (A_1)
			{
				bool flag = false;
				if (Environment.GetEnvironmentVariable(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LV()) == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CM())
				{
					flag = true;
				}
				if (flag)
				{
					A_2 = new global::B.k
					{
						A = global::B.K.A,
						A_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lv()
					};
					A_2.A_2 = global::B.j.A_m_1(global::B.J.Id, new DateTime(2099, 1, 1), 1);
					A_4 = 1L;
					a = 1L;
					return;
				}
			}
			try
			{
				B = Debugger.IsAttached || Debugger.IsLogging();
			}
			catch
			{
				B = false;
			}
#else
			// C-01 / C-22：Release 构建禁用调试器短路，保证完整性校验与正常授权路径始终执行。
			B = false;
#endif
			A_3 = global::B.m.A_m_1();
			a = 0L;
			A_4 = 0L;
			A_m_1(DateTime.Now, A_3 == null || string.IsNullOrEmpty(A_3.A));
			if (A_3 == null || string.IsNullOrEmpty(A_3.A))
			{
				A_2 = new global::B.k
				{
					A = global::B.K.a,
					a = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LW()
				};
				return;
			}
			DateTime now = DateTime.Now;
			DateTime dateTime = now;
			if (A_3.A_1 > 0)
			{
				DateTime dateTime2 = A_m_1(A_3.A_1);
				if (dateTime2 > dateTime)
				{
					dateTime = dateTime2;
				}
			}
			if (dateTime > now.AddDays(1.0))
			{
				dateTime = now;
			}
			A_5 = dateTime;
			A_2 = global::B.L.A_m_1(A_3.A, global::B.J.Id, A_5, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lw());
			if (!A_2.Ok)
			{
				return;
			}
			r r2 = null;
			try
			{
				r2 = S.A_m_1();
			}
			catch
			{
				r2 = null;
			}
			if (r2 != null && !r2.A && !b)
			{
				IntegrityFailed = true;
				IntegrityMessage = r2.A_1;
				try
				{
					global::B.p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LX() + r2.a);
				}
				catch
				{
				}
				A_2 = A_m_1(r2, A_3.A);
				A_4 = 0L;
				a = 0L;
				return;
			}
			A_4 = A_m_1(A_2);
			a = A_4;
			try
			{
				A_3.a = A_m_1(now);
				if (A_3.A_1 < A_m_1(now))
				{
					A_3.A_1 = A_m_1(now);
				}
				global::B.m.a_m_1(A_3);
			}
			catch
			{
			}
		}

		private static void A_m_1(DateTime P_0, bool P_1)
		{
			try
			{
				global::C.A a2 = global::C.B.B_m_1();
				A_6 = global::C.b.A_m_1(a2, P_0, P_1, out var a3);
				if (A_6.A && (a2 == null || a3.A_f_1 != a2.A_f_1 || a3.a_1 != a2.a_1 || a3.A_f_2 != a2.A_f_2 || a3.a - a2.a > TimeSpan.FromMinutes(30.0)))
				{
					global::C.B.a_m_1(a3);
				}
			}
			catch
			{
				A_6 = new global::C.a();
			}
		}

		public static bool B_m_1()
		{
			bool active = Active;
			a_1 = false;
			a_m_1();
			if (active && !Active)
			{
				try
				{
					global::B.p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lx() + ((A_2 == null) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LY() : A_2.a));
				}
				catch
				{
				}
			}
			return Active;
		}

		internal static global::B.k A_m_1(r P_0, string P_1)
		{
			return new global::B.k
			{
				A = global::B.K.d,
				A_1 = (P_1 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()),
				a = ((P_0 == null) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ly() : P_0.A_1)
			};
		}

		internal static bool A_m_1(out long P_0)
		{
			A_m_1();
			P_0 = 0L;
			long num = 0L;
			long num2 = 0L;
			long num3 = 0L;
			bool flag = false;
			if (Licensed)
			{
				flag = true;
				num = ((A_4 != 0L) ? A_4 : 27747);
				if (A_2 != null && A_2.A_2 != null)
				{
					num2 = A_2.A_2.C;
				}
			}
			if (TrialActive)
			{
				flag = true;
				num3 = ((A_6 != null && A_6.A) ? A_6.A_1.Ticks : 29810);
			}
			if (!flag)
			{
				return false;
			}
			long num4 = num ^ (num3 * 31) ^ (num2 << 17) ^ (IntegrityFailed ? 23130 : 0);
			P_0 = i.A_m_1(num4);
			return P_0 != 0;
		}

		private static long A_m_1(global::B.k P_0)
		{
			try
			{
				string text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LZ() + P_0.A_1 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lz() + BitConverter.ToString(global::B.J.Id) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lz() + ((P_0.A_2 != null) ? P_0.A_2.A_5 : 0) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lz() + ((P_0.A_2 != null) ? P_0.A_2.C : 0) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lz() + ((P_0.A_2 != null) ? P_0.A_2.a_2 : 0u) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lz() + ((P_0.A_2 != null) ? P_0.A_2.b_1 : 0) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lA();
				using SHA256 sHA = SHA256.Create();
				byte[] value = sHA.ComputeHash(Encoding.UTF8.GetBytes(text));
				long num = BitConverter.ToInt64(value, 0);
				long num2 = BitConverter.ToInt64(value, 8);
				long num3 = BitConverter.ToInt64(value, 16);
				long num4 = num ^ num2 ^ num3;
				return (num4 == 0L) ? 1 : num4;
			}
			catch
			{
				return 0L;
			}
		}

		private static long A_m_1(DateTime P_0)
		{
			return (long)(P_0.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
		}

		private static DateTime A_m_1(long P_0)
		{
			if (P_0 <= 0)
			{
				return DateTime.MinValue;
			}
			return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(P_0).ToLocalTime();
		}

		public static bool A_m_1(string P_0, out string P_1)
		{
			return A_m_1(P_0, out P_1, false);
		}

		public static bool A_m_1(string P_0, out string P_1, bool P_2)
		{
			P_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			if (B)
			{
				P_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.la();
				return false;
			}
			DateTime now = DateTime.Now;
			DateTime dateTime = now;
			global::B.M m2 = global::B.m.A_m_1();
			if (m2 != null && m2.A_1 > 0)
			{
				DateTime dateTime2 = A_m_1(m2.A_1);
				if (dateTime2 > dateTime && dateTime2 < now.AddDays(1.0))
				{
					dateTime = dateTime2;
				}
			}
			global::B.k k2 = global::B.L.A_m_1(P_0, global::B.J.Id, dateTime, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lw());
			if (!k2.Ok)
			{
				P_1 = k2.a;
				return false;
			}
			int num = ((k2.A_2 != null) ? k2.A_2.C : 0);
			if (P_2 && num != 1)
			{
				P_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lB();
				return false;
			}
			if (m2 != null && m2.A_2 > num)
			{
				P_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lb();
				return false;
			}
			global::B.m.a_m_1(new global::B.M
			{
				A = k2.A_1,
				a_1 = Guid.NewGuid().ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.cL()),
				a = A_m_1(now),
				A_1 = A_m_1(now),
				A_2 = ((m2 != null && m2.A_2 > num) ? m2.A_2 : num),
				A_3 = 20261101u
			});
			try
			{
				global::C.b.A_m_1(now);
			}
			catch
			{
			}
			b = true;
			a_1 = false;
			a_m_1();
			if (!Active)
			{
				P_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lC();
				return false;
			}
			try
			{
				global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lc() + StatusText);
			}
			catch
			{
			}
			return true;
		}

		public static bool a_m_1(string P_0, out string P_1)
		{
			return A_m_1(P_0, out P_1, true);
		}

		public static void b_m_1()
		{
			global::B.m.a_m_1();
			A_3 = null;
			A_4 = 0L;
			a = 0L;
			a_1 = false;
			a_m_1();
			try
			{
				global::B.p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lD());
			}
			catch
			{
			}
		}

		public static string A_m_1(string P_0)
		{
			return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ld() + (string.IsNullOrEmpty(P_0) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D() : (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lE() + P_0 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kk())) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.le() + global::B.J.Formatted + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lF();
		}

		public static string a_m_1(string P_0)
		{
			return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lf() + (string.IsNullOrEmpty(P_0) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D() : (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lG() + P_0 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kk())) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lg() + global::B.J.Formatted + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lH();
		}

		public static void C_m_1()
		{
			if (CanExecute)
			{
				return;
			}
			throw new J(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lh() + global::B.J.Formatted + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lI());
		}

		public static bool A_m_1(IWin32Window P_0, string P_1, string P_2)
		{
			A_m_1();
			if (CanExecute)
			{
				return true;
			}
			B_m_1();
			if (CanExecute)
			{
				return true;
			}
			try
			{
				global::B.p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.li() + (P_1 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lJ()));
			}
			catch
			{
			}
			using global::B.l l2 = new global::B.l(false, false, A_m_1(P_1), a_m_1(P_2));
			return l2.ShowDialog(P_0) == DialogResult.OK && CanExecute;
		}

		public static bool A_m_1(IWin32Window P_0)
		{
			return A_m_1(P_0, null, null);
		}

		public static void c()
		{
			if (A_6 != null)
			{
				A_6.C = true;
			}
			try
			{
				global::C.b.A_m_1();
			}
			catch
			{
			}
		}

		public static bool a_m_1(IWin32Window P_0)
		{
			if (Pro)
			{
				return true;
			}
			using (global::B.l l2 = new global::B.l(false, Licensed))
			{
				if (l2.ShowDialog(P_0) == DialogResult.OK)
				{
					return Pro;
				}
			}
			return Pro;
		}
	}
}
