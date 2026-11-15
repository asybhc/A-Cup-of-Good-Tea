using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using _003CPrivateImplementationDetails_003E_007B1262ED64_002DD0A6_002D499E_002D9510_002DF2240F018DBB_007D;
using A;

namespace A
{
	public sealed class N
	{
		[CompilerGenerated]
		private string A;

		[CompilerGenerated]
		private string a;

		[CompilerGenerated]
		private string B;

		[CompilerGenerated]
		private int A_1;

		[CompilerGenerated]
		private long A_2;

		[CompilerGenerated]
		private int a_1;

		[CompilerGenerated]
		private int B_1;

		[CompilerGenerated]
		private long a_2;

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
		private long B_2;

		[CompilerGenerated]
		private bool A_3;

		[CompilerGenerated]
		private string b_1;

		[CompilerGenerated]
		private List<M> A_4 = new List<M>();

		[CompilerGenerated]
		private List<m> A_5 = new List<m>();

		public string Granularity
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

		public string Mode
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

		public string Conflict
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

		public int FileCount
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

		public long TotalBytes
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

		public int Conflicts
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

		public int DuplicateDeletes
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

		public int Renamed
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

		public int Unknown
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

		public int Succeeded
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

		public int Failed
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

		public int Skipped
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

		public int DuplicateDeleted
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

		public int DuplicateSkipped
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

		public long ReclaimedBytes
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

		public bool DryRun
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

		public string PlanSummary
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

		public List<M> Groups
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

		public List<m> Items
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
	}
	public sealed class n
	{
		[CompilerGenerated]
		private bool A;

		[CompilerGenerated]
		private string A_1;

		[CompilerGenerated]
		private string a;

		[CompilerGenerated]
		private string B;

		[CompilerGenerated]
		private string b;

		[CompilerGenerated]
		private bool a_1;

		[CompilerGenerated]
		private J A_2;

		[CompilerGenerated]
		private j A_3;

		[CompilerGenerated]
		private N A_4;

		[CompilerGenerated]
		private string C;

		public bool Ok
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

		public string Error
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

		public string Detail
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

		public string Mode
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

		public string Source
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

		public bool DryRun
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

		public J Scan
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

		public j Stats
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

		public N Organize
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

		public string OpsLogPath
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
	}
}
namespace a
{
	internal static class N
	{
		internal const string A = "FileDedupTool.help.zh.md";

		internal const string a = "FileDedupTool.help.en.md";

		internal static Func<string, string> A_1 = A_m_1;

		internal static string A_m_1(string P_0)
		{
			try
			{
				using Stream stream = typeof(N).Assembly.GetManifestResourceStream(P_0);
				if (stream == null)
				{
					return null;
				}
				using StreamReader streamReader = new StreamReader(stream, Encoding.UTF8);
				return streamReader.ReadToEnd();
			}
			catch
			{
				return null;
			}
		}

		internal static string A_m_1(bool P_0)
		{
			string arg = (P_0 ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lq() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lQ());
			string text = ((A_1 == null) ? null : A_1(arg));
			if (!string.IsNullOrWhiteSpace(text))
			{
				return text;
			}
			if (!P_0)
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lR();
			}
			return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lr();
		}

		internal static string a_m_1(bool P_0)
		{
			if (P_0)
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lS() + global::A.r.c + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ls();
			}
			return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lT() + global::A.r.c + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lt();
		}

		internal static string B(bool P_0)
		{
			if (P_0)
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lU() + global::A.r.c + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lu();
			}
			return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lV() + global::A.r.c + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lv();
		}

		internal static string b(bool P_0)
		{
			string text = A_m_1(P_0);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lW()).Append(a_m_1(P_0)).Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lw());
			stringBuilder.Append(text.TrimEnd()).Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lX());
			stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lW()).Append(B(P_0)).Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lx());
			return stringBuilder.ToString();
		}

		internal static string C(bool P_0)
		{
			return n.A_m_1(n.A_m_1(b(P_0)));
		}
	}
	internal static class n
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class A
		{
			public static readonly A A_f_1 = new A();

			public static Func<string[], int> A_f_2;

			internal int A_m_1(string[] P_0)
			{
				return P_0.Length;
			}
		}

		private static readonly Regex A_1 = new Regex(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.MC(), RegexOptions.Compiled);

		private static readonly Regex a = new Regex(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Mc(), RegexOptions.Compiled);

		private static readonly Regex B = new Regex(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.MD(), RegexOptions.Compiled);

		private static readonly Regex b = new Regex(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Md(), RegexOptions.Compiled);

		internal static List<l> A_m_1(string P_0)
		{
			List<l> list = new List<l>();
			if (P_0 == null)
			{
				return list;
			}
			string[] array = P_0.Replace(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kk(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BD()).Replace('\r', '\n').Split('\n');
			StringBuilder stringBuilder = new StringBuilder();
			StringBuilder stringBuilder2 = new StringBuilder();
			bool flag = false;
			for (int num = 0; num < array.Length; num++)
			{
				string text = array[num];
				string text2 = text.Trim();
				if (text2.StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lY(), StringComparison.Ordinal))
				{
					A_m_1(list, stringBuilder);
					if (flag)
					{
						list.Add(new l
						{
							A = L.c,
							B = stringBuilder2.ToString().TrimEnd('\n')
						});
						stringBuilder2.Length = 0;
						flag = false;
					}
					else
					{
						flag = true;
					}
					continue;
				}
				if (flag)
				{
					stringBuilder2.Append(text).Append('\n');
					continue;
				}
				if (text2.Length == 0)
				{
					A_m_1(list, stringBuilder);
					continue;
				}
				if (text2 == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ly() || text2 == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lZ() || text2 == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lz())
				{
					A_m_1(list, stringBuilder);
					list.Add(new l
					{
						A = L.D
					});
					continue;
				}
				Match match = A_1.Match(text);
				if (match.Success)
				{
					A_m_1(list, stringBuilder);
					list.Add(new l
					{
						A = L.A,
						A_1 = match.Groups[1].Value.Length,
						a = match.Groups[2].Value.Trim()
					});
					continue;
				}
				if (text2.StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lz(), StringComparison.Ordinal))
				{
					A_m_1(list, stringBuilder);
					List<string[]> list2 = new List<string[]>();
					int num2;
					for (num2 = num; num2 < array.Length && array[num2].TrimStart().StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lz(), StringComparison.Ordinal); num2++)
					{
						string[] array2 = a_m_1(array[num2]);
						if (!A_m_1(array2))
						{
							list2.Add(array2);
						}
					}
					if (list2.Count > 0)
					{
						list.Add(new l
						{
							A = L.C,
							A_4 = list2
						});
					}
					num = num2 - 1;
					continue;
				}
				Match match2 = a.Match(text);
				if (match2.Success)
				{
					A_m_1(list, stringBuilder);
					string value = match2.Groups[2].Value;
					int length = match2.Groups[1].Value.Length;
					list.Add(new l
					{
						A = L.b,
						A_1 = ((length >= 2) ? 1 : 0),
						A_2 = (value.Length > 1),
						A_3 = ((value.Length > 1) ? value : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.@as()),
						a = match2.Groups[3].Value.Trim()
					});
					continue;
				}
				Match match3 = B.Match(text);
				if (match3.Success)
				{
					A_m_1(list, stringBuilder);
					list.Add(new l
					{
						A = L.B,
						a = match3.Groups[1].Value.Trim()
					});
				}
				else
				{
					if (stringBuilder.Length > 0 && A_m_1(stringBuilder[stringBuilder.Length - 1], text.TrimStart()[0]))
					{
						stringBuilder.Append(' ');
					}
					stringBuilder.Append(text.Trim());
				}
			}
			A_m_1(list, stringBuilder);
			if (flag && stringBuilder2.Length > 0)
			{
				list.Add(new l
				{
					A = L.c,
					B = stringBuilder2.ToString().TrimEnd('\n')
				});
			}
			return list;
		}

		private static bool A_m_1(char P_0, char P_1)
		{
			if (A_m_1(P_0) || A_m_1(P_1))
			{
				return false;
			}
			if (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.MA().IndexOf(P_1) >= 0)
			{
				return false;
			}
			return true;
		}

		private static bool A_m_1(char P_0)
		{
			if ((P_0 < '⺀' || P_0 > '\ua4cf') && (P_0 < '가' || P_0 > '힣') && (P_0 < '豈' || P_0 > '\ufaff') && (P_0 < '︰' || P_0 > '\ufe6f'))
			{
				if (P_0 >= '\uff00')
				{
					return P_0 <= '｠';
				}
				return false;
			}
			return true;
		}

		private static void A_m_1(List<l> P_0, StringBuilder P_1)
		{
			if (P_1.Length != 0)
			{
				P_0.Add(new l
				{
					A = L.a,
					a = P_1.ToString()
				});
				P_1.Length = 0;
			}
		}

		private static string[] a_m_1(string P_0)
		{
			string text = P_0.Trim();
			if (text.StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lz(), StringComparison.Ordinal))
			{
				text = text.Substring(1);
			}
			if (text.EndsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lz(), StringComparison.Ordinal))
			{
				text = text.Substring(0, text.Length - 1);
			}
			string[] array = text.Split('|');
			for (int num = 0; num < array.Length; num++)
			{
				array[num] = array[num].Trim();
			}
			return array;
		}

		private static bool A_m_1(string[] P_0)
		{
			if (P_0.Length == 0)
			{
				return false;
			}
			foreach (string text in P_0)
			{
				if (!b.IsMatch(text.Replace(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aH(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D())))
				{
					return false;
				}
			}
			return true;
		}

		internal static List<M> B_m_1(string P_0)
		{
			List<M> list = new List<M>();
			if (string.IsNullOrEmpty(P_0))
			{
				return list;
			}
			StringBuilder stringBuilder = new StringBuilder();
			int num = 0;
			while (num < P_0.Length)
			{
				if (num + 1 < P_0.Length && P_0[num] == '*' && P_0[num + 1] == '*')
				{
					int num2 = P_0.IndexOf(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lW(), num + 2, StringComparison.Ordinal);
					if (num2 > num)
					{
						A_m_1(list, stringBuilder);
						list.Add(new M
						{
							A = P_0.Substring(num + 2, num2 - num - 2),
							A_1 = true
						});
						num = num2 + 2;
						continue;
					}
				}
				if (P_0[num] == '`')
				{
					int num3 = P_0.IndexOf('`', num + 1);
					if (num3 > num)
					{
						A_m_1(list, stringBuilder);
						list.Add(new M
						{
							A = P_0.Substring(num + 1, num3 - num - 1),
							a = true
						});
						num = num3 + 1;
						continue;
					}
				}
				stringBuilder.Append(P_0[num]);
				num++;
			}
			A_m_1(list, stringBuilder);
			return list;
		}

		private static void A_m_1(List<M> P_0, StringBuilder P_1)
		{
			if (P_1.Length != 0)
			{
				P_0.Add(new M
				{
					A = P_1.ToString()
				});
				P_1.Length = 0;
			}
		}

		internal static string A_m_1(List<l> P_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (l item in P_0)
			{
				switch (item.A)
				{
				case L.A:
					stringBuilder.Append(item.a).Append('\n').Append('\n');
					break;
				case L.a:
				case L.B:
					stringBuilder.Append(b_m_1(item.a)).Append('\n').Append('\n');
					break;
				case L.b:
					stringBuilder.Append(' ', item.A_1 * 2).Append(item.A_2 ? (item.A_3 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aH()) : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ma()).Append(b_m_1(item.a))
						.Append('\n');
					break;
				case L.C:
					stringBuilder.Append(A_m_1(item.A_4)).Append('\n');
					break;
				case L.c:
					stringBuilder.Append(item.B).Append('\n').Append('\n');
					break;
				case L.D:
					stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ly()).Append('\n').Append('\n');
					break;
				}
			}
			return stringBuilder.ToString();
		}

		internal static string b_m_1(string P_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (M item in B_m_1(P_0))
			{
				stringBuilder.Append(item.A);
			}
			return stringBuilder.ToString();
		}

		internal static string A_m_1(List<string[]> P_0)
		{
			if (P_0 == null || P_0.Count == 0)
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}
			int num = P_0.Max((string[] array3) => array3.Length);
			int[] array = new int[num];
			foreach (string[] item in P_0)
			{
				for (int num2 = 0; num2 < num; num2++)
				{
					array[num2] = Math.Max(array[num2], (num2 < item.Length) ? C(item[num2]) : 0);
				}
			}
			StringBuilder stringBuilder = new StringBuilder();
			for (int num3 = 0; num3 < P_0.Count; num3++)
			{
				string[] array2 = P_0[num3];
				for (int num4 = 0; num4 < num; num4++)
				{
					string text = ((num4 < array2.Length) ? array2[num4] : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
					stringBuilder.Append(text);
					stringBuilder.Append(' ', array[num4] - C(text));
					if (num4 < num - 1)
					{
						stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.MB());
					}
				}
				stringBuilder.Append('\n');
				if (num3 != 0)
				{
					continue;
				}
				for (int num5 = 0; num5 < num; num5++)
				{
					stringBuilder.Append('-', Math.Max(3, array[num5]));
					if (num5 < num - 1)
					{
						stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Mb());
					}
				}
				stringBuilder.Append('\n');
			}
			return stringBuilder.ToString();
		}

		internal static int C(string P_0)
		{
			int num = 0;
			foreach (char c2 in P_0)
			{
				num = ((c2 < 'ᄀ' || (c2 > 'ᅟ' && (c2 < '⺀' || c2 > '\ua4cf') && (c2 < '가' || c2 > '힣') && (c2 < '豈' || c2 > '\ufaff') && (c2 < '︰' || c2 > '\ufe6f') && (c2 < '\uff00' || c2 > '｠') && (c2 < '￠' || c2 > '￦'))) ? (num + 1) : (num + 2));
			}
			return num;
		}
	}
}
