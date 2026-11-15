using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using _003CPrivateImplementationDetails_003E_007B1262ED64_002DD0A6_002D499E_002D9510_002DF2240F018DBB_007D;
using A;
using B;
using a;

namespace B
{
	internal static class D
	{
		internal const int A = 100;

		private static readonly char[] A_1 = new char[9] { '\\', '/', ':', '*', '?', '"', '<', '>', '|' };

		internal static string A_m_1(string P_0)
		{
			return (P_0 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).Trim();
		}

		internal static string A_m_1(string P_0, IEnumerable<string> P_1)
		{
			string text = A_m_1(P_0);
			if (text.Length == 0)
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Xp();
			}
			if (text == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.DS() || text == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aaa())
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Xq();
			}
			if (text.Length > 100)
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aaB() + 100 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aab();
			}
			string text2 = text;
			foreach (char c2 in text2)
			{
				if (c2 < ' ')
				{
					return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Xs();
				}
				if (Array.IndexOf(A_1, c2) >= 0)
				{
					return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Xt();
				}
			}
			if (P_1 != null)
			{
				foreach (string item in P_1)
				{
					if (item != null && string.Equals(A_m_1(item), text, StringComparison.OrdinalIgnoreCase))
					{
						return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Xu() + text;
					}
				}
			}
			return null;
		}

		internal static string a(string P_0)
		{
			if (string.IsNullOrEmpty(P_0))
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}
			if (P_0.StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Xu(), StringComparison.Ordinal))
			{
				return global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Xu()) + P_0.Substring(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Xu().Length);
			}
			return global::a.Q.A_m_1(P_0);
		}
	}
	internal interface d : IDisposable
	{
		bool HasCookie { get; }

		bool SupportsCreateFolder { get; }

		string CreateFolderUnsupportedReason { get; }

		void A(A P_0);

		void A();

		Task<List<global::a.W>> A(string P_0, CancellationToken P_1);

		Task<List<global::a.w>> a(string P_0, CancellationToken P_1);

		Task<global::a.s> B(string P_0, CancellationToken P_1);

		Task<string> A(string P_0, string P_1, CancellationToken P_2);

		Task<global::a.X> A(string P_0, string P_1, string P_2, CancellationToken P_3, Action<long, long> P_4, string P_5 = null);
	}
}
namespace b
{
	public enum D
	{
		A,
		a,
		B
	}
	public sealed class d
	{
		public string A = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		public string a = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		public string B = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		public string b = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		public string C = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		public string c = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.hF();

		public bool A_1 = true;

		public bool a_1 = true;

		public bool B_1;

		public bool b_1 = true;

		public bool C_1 = true;

		public D A_2;

		public global::a.A A_3;

		public bool c_1;

		public bool D;

		public Func<string, List<global::B.N>, bool> A_4;

		public bool d_f_1;

		public string D_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.cA();

		// C-15：图片去重使用独立保留规则，默认“体积最大”，不复用全局 D_1。
		public string h_2 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aia();

		public bool E;

		public int A_5 = 8;

		public bool e;

		public long A_6;

		public string d_f_2 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		public bool F = true;

		public bool f;

		public int a_2 = 2;

		public bool G;

		public bool g = true;

		public int B_2 = 1;

		public HashSet<string> A_7;

		public Dictionary<string, string> A_8;

		public Dictionary<string, global::A.Z> A_9;

		public bool SafeMode
		{
			get
			{
				return A_2 == global::b.D.a;
			}
			set
			{
				if (value)
				{
					A_2 = global::b.D.a;
				}
				else if (A_2 == global::b.D.a)
				{
					A_2 = global::b.D.A;
				}
			}
		}
	}
}
