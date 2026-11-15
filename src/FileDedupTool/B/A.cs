using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using _003CPrivateImplementationDetails_003E_007B1262ED64_002DD0A6_002D499E_002D9510_002DF2240F018DBB_007D;
using A;
using B;
using C;
using a;

namespace B
{
	internal sealed class A
	{
		[CompilerGenerated]
		private string A_f_1;

		[CompilerGenerated]
		private string a;

		[CompilerGenerated]
		private string B;

		[CompilerGenerated]
		private string b;

		[CompilerGenerated]
		private string C;

		public string Ylogin
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

		public string PhpdiskInfo
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

		public string AppToken
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

		public string Uuid
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

		public string Extra
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

		internal bool A_m_1(global::A.W P_0)
		{
			if (P_0 == null)
			{
				return false;
			}
			if (P_0.Id == global::A.v.a)
			{
				return !string.IsNullOrEmpty(AppToken);
			}
			if (!string.IsNullOrEmpty(Ylogin))
			{
				return !string.IsNullOrEmpty(PhpdiskInfo);
			}
			return false;
		}

		internal string a_m_1(global::A.W P_0)
		{
			if (P_0 != null && P_0.Id == global::A.v.a)
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iW() + global::a.z.a(AppToken);
			}
			return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iw() + global::a.z.B(Ylogin) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAE() + global::a.z.B(PhpdiskInfo);
		}
	}
	internal static class a
	{
		private sealed class A
		{
			[CompilerGenerated]
			private string A_f_1;

			[CompilerGenerated]
			private string a;

			[CompilerGenerated]
			private string B;

			[CompilerGenerated]
			private string b;

			[CompilerGenerated]
			private string C;

			[CompilerGenerated]
			private string c;

			public string platform
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

			public string ylogin
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

			public string phpdisk_info
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

			public string appToken
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

			public string uuid
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

			public string extra
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
		}

		internal static string FilePath => A_m_1(global::A.w.A);

		internal static bool Exists => a_m_1(global::A.w.A);

		internal static bool A_m_1(global::B.A P_0)
		{
			return A_m_1(global::A.w.A, P_0);
		}

		internal static global::B.A A_m_1()
		{
			return B(global::A.w.A);
		}

		internal static void a_m_1()
		{
			b(global::A.w.A);
		}

		internal static string A_m_1(global::A.W P_0)
		{
			global::A.W w2 = P_0 ?? global::A.w.A;
			return Path.Combine(global::A.Y.Dir, w2.CookieFileName);
		}

		internal static bool a_m_1(global::A.W P_0)
		{
			return File.Exists(A_m_1(P_0));
		}

		internal static bool A_m_1(global::A.W P_0, global::B.A P_1)
		{
			global::A.W w2 = P_0 ?? global::A.w.A;
			if (P_1 == null || !P_1.A_m_1(w2))
			{
				return false;
			}
			try
			{
				string text = JsonSerializer.Serialize(new A
				{
					platform = w2.Key,
					ylogin = P_1.Ylogin,
					phpdisk_info = P_1.PhpdiskInfo,
					appToken = P_1.AppToken,
					uuid = P_1.Uuid,
					extra = P_1.Extra
				});
				byte[] bytes = ProtectedData.Protect(Encoding.UTF8.GetBytes(text), null, DataProtectionScope.CurrentUser);
				File.WriteAllBytes(A_m_1(w2), bytes);
				return true;
			}
			catch (Exception ex)
			{
				p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAe() + w2.DisplayName + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.IQ() + ex.Message);
				return false;
			}
		}

		internal static global::B.A B(global::A.W P_0)
		{
			global::A.W w2 = P_0 ?? global::A.w.A;
			try
			{
				string path = A_m_1(w2);
				if (!File.Exists(path))
				{
					return null;
				}
				byte[] bytes = ProtectedData.Unprotect(File.ReadAllBytes(path), null, DataProtectionScope.CurrentUser);
				A a2 = JsonSerializer.Deserialize<A>(Encoding.UTF8.GetString(bytes));
				if (a2 == null)
				{
					return null;
				}
				if (!string.IsNullOrEmpty(a2.platform) && !string.Equals(a2.platform, w2.Key, StringComparison.OrdinalIgnoreCase))
				{
					return null;
				}
				global::B.A a3 = new global::B.A
				{
					Ylogin = a2.ylogin,
					PhpdiskInfo = a2.phpdisk_info,
					AppToken = a2.appToken,
					Uuid = a2.uuid,
					Extra = a2.extra
				};
				return a3.A_m_1(w2) ? a3 : null;
			}
			catch (Exception ex)
			{
				p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aAF() + ex.Message);
				return null;
			}
		}

		internal static void b(global::A.W P_0)
		{
			try
			{
				string path = A_m_1(P_0);
				if (File.Exists(path))
				{
					File.Delete(path);
				}
			}
			catch
			{
			}
		}

		internal static string A_m_1(string P_0)
		{
			if (string.IsNullOrEmpty(P_0))
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}
			string[] array = P_0.Split(new char[1] { ';' }, StringSplitOptions.RemoveEmptyEntries);
			for (int num = 0; num < array.Length; num++)
			{
				string text = array[num].Trim();
				if (text.StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iw(), StringComparison.OrdinalIgnoreCase))
				{
					return text.Substring(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iw().Length).Trim();
				}
			}
			return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
		}
	}
}
namespace b
{
	public sealed class A
	{
		public string A_f_1;

		public long A_f_2;

		public DateTime? A_f_3;

		public global::B.Z A_f_4 = global::B.Z.C;

		public string a;

		public string B;

		public string b;

		public bool A_f_5;

		public bool a_1;

		public string C;

		public string c;

		public bool B_1;

		public bool b_1;

		public string D = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		public bool C_1;

		public string d = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		public string E = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
	}
	public sealed class a
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class A
		{
			public static readonly A A_f_1 = new A();

			public static Func<global::b.A, long> A_f_2;

			public static Func<global::b.A, bool> A_f_3;

			public static Func<global::b.A, bool> a;

			public static Func<global::b.A, bool> B;

			public static Func<global::b.A, bool> b;

			public static Func<global::b.A, long> a_1;

			public static Func<global::b.A, bool> C;

			public static Func<global::b.A, bool> c;

			public static Func<global::b.A, bool> D;

			public static Func<global::b.A, bool> d;

			public static Func<KeyValuePair<string, int>, string> A_f_4;

			internal long A_m_1(global::b.A P_0)
			{
				return P_0.A_f_2;
			}

			internal bool a_m_1(global::b.A P_0)
			{
				if (!P_0.A_f_5 && !P_0.B_1)
				{
					return P_0.C_1;
				}
				return true;
			}

			internal bool B_m_1(global::b.A P_0)
			{
				return P_0.a_1;
			}

			internal bool b_m_1(global::b.A P_0)
			{
				return P_0.a_1;
			}

			internal bool C_m_1(global::b.A P_0)
			{
				return P_0.a_1;
			}

			internal long c_m_1(global::b.A P_0)
			{
				return P_0.A_f_2;
			}

			internal bool D_m_1(global::b.A P_0)
			{
				return P_0.B_1;
			}

			internal bool d_m_1(global::b.A P_0)
			{
				return P_0.b_1;
			}

			internal bool E(global::b.A P_0)
			{
				return P_0.A_f_4 == global::B.Z.C;
			}

			internal bool e(global::b.A P_0)
			{
				return P_0.C_1;
			}

			internal string A_m_1(KeyValuePair<string, int> P_0)
			{
				return P_0.Key;
			}
		}

		public string A_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		public string a_f_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		public global::B.x A_2;

		public global::B.Y A_3;

		public global::B.y A_4;

		public bool A_5;

		public readonly List<global::b.A> A_6 = new List<global::b.A>();

		public readonly List<string> A_7 = new List<string>();

		public int FileCount => A_6.Count;

		public long TotalBytes => A_6.Sum((global::b.A P_0) => P_0.A_f_2);

		public int ConflictCount => Enumerable.Count(A_6, (global::b.A P_0) => P_0.A_f_5 || P_0.B_1 || P_0.C_1);

		public int DuplicateCount => Enumerable.Count(A_6, (global::b.A P_0) => P_0.a_1);

		public int PredictedDeleteCount
		{
			get
			{
				if (A_3 != global::B.Y.A)
				{
					return 0;
				}
				return Enumerable.Count(A_6, (global::b.A P_0) => P_0.a_1);
			}
		}

		public long PredictedDeleteBytes
		{
			get
			{
				if (A_3 != global::B.Y.A)
				{
					return 0L;
				}
				return A_6.Where((global::b.A P_0) => P_0.a_1).Sum((global::b.A P_0) => P_0.A_f_2);
			}
		}

		public int RenameCount => Enumerable.Count(A_6, (global::b.A P_0) => P_0.B_1);

		public int TitleRewriteCount => Enumerable.Count(A_6, (global::b.A P_0) => P_0.b_1);

		public int UnknownCount => Enumerable.Count(A_6, (global::b.A P_0) => P_0.A_f_4 == global::B.Z.C);

		public int SkipCount => Enumerable.Count(A_6, (global::b.A P_0) => P_0.C_1);

		public List<KeyValuePair<string, int>> A_m_1()
		{
			Dictionary<string, int> dictionary = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
			foreach (global::b.A item in A_6)
			{
				dictionary.TryGetValue(item.a, out var value);
				dictionary[item.a] = value + 1;
			}
			List<KeyValuePair<string, int>> list = new List<KeyValuePair<string, int>>();
			foreach (KeyValuePair<string, int> item2 in dictionary.OrderBy((KeyValuePair<string, int> P_0) => P_0.Key, StringComparer.OrdinalIgnoreCase))
			{
				list.Add(item2);
			}
			return list;
		}

		public string a_m_1()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agV(), FileCount, A_m_1(TotalBytes), A_m_1().Count, ConflictCount);
			if (A_4 == global::B.y.A)
			{
				if (A_3 == global::B.Y.a)
				{
					stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agv());
				}
				else
				{
					stringBuilder.AppendFormat(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agW(), PredictedDeleteCount, A_m_1(PredictedDeleteBytes));
				}
			}
			stringBuilder.AppendFormat(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agw(), RenameCount, UnknownCount);
			if (TitleRewriteCount > 0)
			{
				stringBuilder.AppendFormat(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agX(), TitleRewriteCount);
			}
			if (SkipCount > 0)
			{
				stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agx() + SkipCount + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ij());
			}
			if (A_4 == global::B.y.A && A_3 == global::B.Y.a && DuplicateCount > 0)
			{
				stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agY() + DuplicateCount + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ij());
			}
			return stringBuilder.ToString();
		}

		public void A_m_1(string P_0, int P_1 = 0)
		{
			StringBuilder stringBuilder = new StringBuilder((P_1 > 0) ? Math.Min(1048576, Math.Max(1024, P_1 * 512)) : 16);
			stringBuilder.AppendLine(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.agy() + global::C.f.CsvHeaderSuffix);
			foreach (global::b.A item in A_6)
			{
				stringBuilder.AppendLine(string.Join(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Kn(), A_m_1(item.A_f_1), A_m_1(b.A_m_1(item.A_f_4)), A_m_1(item.A_f_3.HasValue ? item.A_f_3.Value.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CI()) : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()), A_m_1(item.a), A_m_1(item.B), A_m_1(item.d), A_m_1((item.E.Length > 0) ? item.E : b.A_m_1(item))));
			}
			File.WriteAllText(P_0, stringBuilder.ToString(), new UTF8Encoding(encoderShouldEmitUTF8Identifier: true));
		}

		private static string A_m_1(string P_0)
		{
			if (P_0 == null)
			{
				P_0 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}
			if (P_0.IndexOfAny(new char[4] { ',', '"', '\n', '\r' }) >= 0)
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JX() + P_0.Replace(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JX(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lk()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JX();
			}
			return P_0;
		}

		internal static string A_m_1(long P_0)
		{
			double num = P_0;
			if (num < 1024.0)
			{
				return P_0 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bd();
			}
			if (num < 1048576.0)
			{
				return (num / 1024.0).ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.w()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BE();
			}
			if (num < 1073741824.0)
			{
				return (num / 1024.0 / 1024.0).ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.w()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Be();
			}
			return (num / 1024.0 / 1024.0 / 1024.0).ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BF()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bf();
		}
	}
}
