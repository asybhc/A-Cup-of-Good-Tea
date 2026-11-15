using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using _003CPrivateImplementationDetails_003E_007B1262ED64_002DD0A6_002D499E_002D9510_002DF2240F018DBB_007D;
using A;
using a;

namespace B
{
	public static class R
	{
		private const RegexOptions A = RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant;

		private static readonly Regex[] A_1 = new Regex[3]
		{
			new Regex(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEx(), RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant),
			new Regex(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEY(), RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant),
			new Regex(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEy(), RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant)
		};

		private static readonly Regex A_2 = new Regex(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEZ(), RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant);

		private static readonly Regex a = new Regex(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEz(), RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant);

		private static readonly Regex B = new Regex(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aeA(), RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant);

		private static readonly Regex b = new Regex(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aea(), RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant);

		private static readonly Regex C = new Regex(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aeB(), RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant);

		private static readonly Regex c = new Regex(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aeb(), RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant);

		private static readonly Regex D = new Regex(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aeC(), RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant);

		private static readonly Regex[] a_1 = new Regex[8]
		{
			new Regex(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aec(), RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant),
			new Regex(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aeD(), RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant),
			new Regex(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aed(), RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant),
			new Regex(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aeE(), RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant),
			new Regex(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aee(), RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant),
			new Regex(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aeF(), RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant),
			new Regex(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aef(), RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant),
			new Regex(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aeG(), RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant)
		};

		private static readonly Regex d = new Regex(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aeg(), RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant);

		private static readonly Regex E = new Regex(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aeH(), RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant);

		private static readonly Regex e = new Regex(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aeh(), RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant);

		private static readonly Regex F = new Regex(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aeI(), RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant);

		private static readonly Regex f = new Regex(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aei(), RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant);

		private static readonly Regex G = new Regex(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aeJ(), RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant);

		private static readonly Regex g = new Regex(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aej(), RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant);

		private static readonly Regex H = new Regex(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aeK(), RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant);

		private static readonly Regex h = new Regex(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aek(), RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant);

		private static readonly Regex I = new Regex(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aeL(), RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant);

		private const string A_3 = " \t._-+&=#@!,'’~$%^()（）[]【】《》{}，。、;；:：";

		private static readonly char[] A_4 = new char[9] { '\\', '/', ':', '*', '?', '"', '<', '>', '|' };

		private const int A_5 = 200;

		private static int A_m_1(string P_0)
		{
			int num = 0;
			foreach (char c2 in P_0)
			{
				if (e.IsMatch(c2.ToString()))
				{
					num++;
				}
			}
			return num;
		}

		public static string a_m_1(string P_0)
		{
			if (string.IsNullOrEmpty(P_0))
			{
				return P_0;
			}
			string result = P_0;
			Regex[] array = A_1;
			for (int num = 0; num < array.Length; num++)
			{
				string text = array[num].Replace(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(), 1).Trim(' ', '\t');
				if (text.Length > 0 && text != P_0)
				{
					P_0 = text;
					break;
				}
			}
			while (true)
			{
				Match match = A_2.Match(P_0);
				if (!match.Success)
				{
					match = a.Match(P_0);
				}
				if (!match.Success || match.Length >= P_0.Length)
				{
					break;
				}
				string text2 = P_0.Substring(match.Length).TrimStart(' ', '\t', '.', '_', '-');
				if (text2.Length == 0)
				{
					break;
				}
				P_0 = text2;
			}
			string text3 = B.Replace(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(), 1).Trim(' ', '\t');
			if (text3.Length > 0 && text3 != P_0)
			{
				P_0 = text3;
			}
			while (true)
			{
				Match match2 = b.Match(P_0);
				if (match2.Success && match2.Length < P_0.Length)
				{
					string text4 = P_0.Substring(match2.Length).TrimStart(' ', '\t', '.', '_', '-');
					if (text4.Length == 0)
					{
						break;
					}
					P_0 = text4;
					continue;
				}
				match2 = C.Match(P_0);
				if (!match2.Success || match2.Length >= P_0.Length)
				{
					break;
				}
				string text5 = P_0.Substring(match2.Length).TrimStart(' ', '\t', '.', '_', '-');
				if (text5.Length == 0)
				{
					break;
				}
				P_0 = text5;
			}
			while (true)
			{
				string text6 = D.Replace(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEW());
				if (text6 == P_0)
				{
					text6 = c.Replace(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).Trim(' ', '\t');
				}
				if (text6.Length == 0 || text6 == P_0)
				{
					break;
				}
				P_0 = text6;
			}
			P_0 = P_0.Trim();
			if (P_0.Length != 0)
			{
				return P_0;
			}
			return result;
		}

		public static string B_m_1(string P_0)
		{
			if (string.IsNullOrEmpty(P_0))
			{
				return P_0;
			}
			string result = P_0;
			int num = 0;
			while (num++ < 32)
			{
				string text = P_0;
				Regex[] array = a_1;
				for (int num2 = 0; num2 < array.Length; num2++)
				{
					string text2 = array[num2].Replace(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
					text2 = text2.TrimEnd(' ', '\t', '.', '_', '-');
					if (text2.Length > 0 && text2 != P_0)
					{
						P_0 = text2;
						break;
					}
				}
				if (P_0 == text)
				{
					break;
				}
			}
			P_0 = P_0.Trim();
			if (P_0.Length != 0)
			{
				return P_0;
			}
			return result;
		}

		public static bool b_m_1(string P_0)
		{
			if (!string.IsNullOrEmpty(P_0))
			{
				return d.IsMatch(P_0);
			}
			return false;
		}

		public static bool C_m_1(string P_0)
		{
			if (string.IsNullOrEmpty(P_0))
			{
				return false;
			}
			if (A_m_1(P_0) != 2)
			{
				return false;
			}
			string text = e.Replace(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
			if (text.Length == 0 || !E.IsMatch(text))
			{
				return false;
			}
			bool flag = false;
			bool flag2 = false;
			string text2 = text;
			foreach (char c2 in text2)
			{
				if (char.IsLetter(c2))
				{
					flag = true;
				}
				else if (char.IsDigit(c2))
				{
					flag2 = true;
				}
			}
			return flag & flag2;
		}

		public static bool c_m_1(string P_0)
		{
			if (string.IsNullOrEmpty(P_0))
			{
				return false;
			}
			if (A_m_1(P_0) != 2)
			{
				return false;
			}
			string text = e.Replace(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
			if (text.Length < 3 || text.Length != P_0.Length - 2)
			{
				return false;
			}
			string text2 = text;
			for (int num = 0; num < text2.Length; num++)
			{
				if (!char.IsDigit(text2[num]))
				{
					return false;
				}
			}
			if (text.Length == 4 && int.TryParse(text, out var result) && result >= 1900 && result <= 2099)
			{
				return false;
			}
			return true;
		}

		public static bool D_m_1(string P_0)
		{
			if (string.IsNullOrEmpty(P_0))
			{
				return false;
			}
			int num = A_m_1(P_0);
			if (num < 1 || num > 2)
			{
				return false;
			}
			int num2 = -1;
			int num3 = -1;
			for (int num4 = 0; num4 < P_0.Length; num4++)
			{
				if (e.IsMatch(P_0[num4].ToString()))
				{
					if (num2 < 0)
					{
						num2 = num4;
					}
					num3 = num4;
				}
			}
			if (num2 <= 0 || num3 >= P_0.Length - 1)
			{
				return false;
			}
			return E_m_1(e.Replace(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()));
		}

		public static bool d_m_1(string P_0)
		{
			if (string.IsNullOrEmpty(P_0) || P_0.Length < 4)
			{
				return false;
			}
			bool flag = false;
			foreach (char value in P_0)
			{
				if (!char.IsLetterOrDigit(value) && _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEw().IndexOf(value) < 0)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return false;
			}
			if (A_m_1(P_0) > 2)
			{
				return false;
			}
			return true;
		}

		public static bool E_m_1(string P_0)
		{
			if (string.IsNullOrEmpty(P_0))
			{
				return false;
			}
			if (P_0.Length < 6 || P_0.Length > 64)
			{
				return false;
			}
			if (!E.IsMatch(P_0))
			{
				return false;
			}
			if (d.IsMatch(P_0))
			{
				return false;
			}
			bool flag = false;
			bool flag2 = false;
			for (int num = 0; num < P_0.Length; num++)
			{
				if (char.IsDigit(P_0[num]))
				{
					flag2 = true;
				}
				else
				{
					flag = true;
				}
			}
			if (!(flag & flag2))
			{
				return false;
			}
			if (g.IsMatch(P_0))
			{
				return true;
			}
			if (F.IsMatch(P_0))
			{
				return false;
			}
			if (G.IsMatch(P_0))
			{
				return false;
			}
			if (H.IsMatch(P_0))
			{
				return false;
			}
			int num2 = 0;
			int num3 = i(P_0);
			if (num3 >= 4)
			{
				num2 += 2;
			}
			else if (num3 == 3)
			{
				num2++;
			}
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			int num7 = 0;
			for (int num8 = 0; num8 < P_0.Length; num8++)
			{
				char c2 = P_0[num8];
				if (char.IsDigit(c2))
				{
					num6++;
					continue;
				}
				num4++;
				if (h.IsMatch(c2.ToString().ToLowerInvariant()))
				{
					num5++;
				}
				if (num8 > 0 && char.IsUpper(c2))
				{
					num7++;
				}
			}
			if (num4 < 4 || num6 < 2)
			{
				return false;
			}
			double num9 = (double)num6 / (double)P_0.Length;
			double num10 = (double)num5 / (double)num4;
			if (num10 < 0.2)
			{
				num2 += 2;
			}
			else if (num10 < 0.3)
			{
				num2++;
			}
			if (num7 >= 2)
			{
				num2++;
			}
			if (!f.IsMatch(P_0) && P_0.Length >= 10)
			{
				num2++;
			}
			if (num9 > 0.3)
			{
				num2++;
			}
			if (num2 >= 4)
			{
				return true;
			}
			if (num2 >= 3)
			{
				return num9 >= 0.3;
			}
			return false;
		}

		public static bool e_m_1(string P_0)
		{
			if (string.IsNullOrEmpty(P_0) || P_0.Length < 6 || P_0.Length > 20)
			{
				return false;
			}
			if (!Regex.IsMatch(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEX()))
			{
				return false;
			}
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			for (int num4 = 0; num4 < P_0.Length; num4++)
			{
				char c2 = P_0[num4];
				if (char.IsUpper(c2))
				{
					num++;
				}
				else
				{
					num2++;
				}
				if (h.IsMatch(c2.ToString().ToLowerInvariant()))
				{
					num3++;
				}
			}
			if (num2 == 0)
			{
				return false;
			}
			if (num * 100 < P_0.Length * 60)
			{
				return false;
			}
			return num3 * 4 <= P_0.Length;
		}

		public static bool F_m_1(string P_0)
		{
			if (string.IsNullOrEmpty(P_0) || P_0.Length < 8 || P_0.Length > 40)
			{
				return false;
			}
			return I.IsMatch(P_0.ToLowerInvariant());
		}

		public static bool f_m_1(string P_0)
		{
			if (string.IsNullOrEmpty(P_0) || P_0.Length < 6 || P_0.Length > 40)
			{
				return false;
			}
			if (!Regex.IsMatch(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aEX()))
			{
				return false;
			}
			int num = 0;
			int num2 = 1;
			int num3 = 1;
			int num4 = 0;
			for (int num5 = 0; num5 < P_0.Length; num5++)
			{
				if (char.IsUpper(P_0[num5]))
				{
					num4++;
				}
				if (num5 == 0)
				{
					continue;
				}
				if (char.IsUpper(P_0[num5]) != char.IsUpper(P_0[num5 - 1]))
				{
					num++;
					num2 = 1;
					continue;
				}
				num2++;
				if (num2 > num3)
				{
					num3 = num2;
				}
			}
			if (num4 >= 2 && num >= 4)
			{
				return num3 <= 2;
			}
			return false;
		}

		public static string G_m_1(string P_0)
		{
			if (string.IsNullOrEmpty(P_0))
			{
				return P_0;
			}
			int num = 0;
			int num2 = 0;
			string text = P_0;
			for (int num3 = 0; num3 < text.Length; num3++)
			{
				switch (text[num3])
				{
				case '(':
				case '（':
					num++;
					break;
				case ')':
				case '）':
					num2++;
					break;
				}
			}
			if (num < 3 || num2 < 3)
			{
				return P_0;
			}
			StringBuilder stringBuilder = new StringBuilder(P_0.Length);
			text = P_0;
			foreach (char c2 in text)
			{
				if (c2 != '(' && c2 != ')' && c2 != '（' && c2 != '）')
				{
					stringBuilder.Append(c2);
				}
			}
			string text2 = stringBuilder.ToString().Trim();
			if (text2.Length != 0)
			{
				return text2;
			}
			return P_0;
		}

		public static string g_m_1(string P_0)
		{
			if (string.IsNullOrEmpty(P_0))
			{
				return P_0;
			}
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(P_0);
			string text = Path.GetExtension(P_0) ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			string text2 = G_m_1(fileNameWithoutExtension);
			if (text2.Length == 0 || string.Equals(text2, fileNameWithoutExtension, StringComparison.Ordinal))
			{
				return P_0;
			}
			StringBuilder stringBuilder = new StringBuilder(text2.Length);
			string text3 = text2;
			foreach (char c2 in text3)
			{
				stringBuilder.Append((Array.IndexOf(A_4, c2) >= 0) ? '_' : c2);
			}
			string text4 = stringBuilder.ToString().Trim().TrimEnd('.', ' ');
			if (text4.Length == 0)
			{
				return P_0;
			}
			if (text4.Length > 200)
			{
				text4 = text4.Substring(0, 200).TrimEnd('.', ' ');
				if (text4.Length == 0)
				{
					return P_0;
				}
			}
			return text4 + text;
		}

		public static bool H_m_1(string P_0)
		{
			return !string.Equals(g_m_1(P_0), P_0, StringComparison.Ordinal);
		}

		public static bool h_m_1(string P_0)
		{
			if (P_0 != null)
			{
				return F.IsMatch(P_0);
			}
			return false;
		}

		public static string I_m_1(string P_0)
		{
			if (string.IsNullOrEmpty(P_0))
			{
				return null;
			}
			s s2 = t.B_m_1(P_0, new T
			{
				A_2 = false
			});
			if (!s2.IsGarbage)
			{
				return null;
			}
			return s2.a;
		}

		private static int i(string P_0)
		{
			int num = 0;
			bool flag = false;
			for (int num2 = 0; num2 < P_0.Length; num2++)
			{
				bool flag2 = char.IsDigit(P_0[num2]);
				if (num2 == 0 || flag2 != flag)
				{
					num++;
				}
				flag = flag2;
			}
			return num;
		}
	}
	public enum r
	{
		A,
		a,
		B
	}
}
namespace b
{
	public sealed class R
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class A
		{
			public static readonly A A_f_1 = new A();

			public static Func<Q, bool> A_f_2;

			public static Func<q, int> A_f_3;

			public static Func<q, long> A_f_4;

			internal int A_m_1(q P_0)
			{
				return Enumerable.Count(P_0.A_2, (Q q2) => !q2.A_3);
			}

			internal bool A_m_1(Q P_0)
			{
				return !P_0.A_3;
			}

			internal long a(q P_0)
			{
				return P_0.WastedBytes;
			}
		}

		public List<q> A_1 = new List<q>();

		public int A_2;

		public long A_3;

		public string A_4 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		public DateTime A_5 = DateTime.Now;

		public List<string> A_6 = new List<string>();

		public int DupFileCount => A_1.Sum((q P_0) => Enumerable.Count(P_0.A_2, (Q q2) => !q2.A_3));

		public long WastedBytes => A_1.Sum((q P_0) => P_0.WastedBytes);
	}
	public static class r
	{
		[CompilerGenerated]
		private static class A
		{
			public static Func<string, long> A_f_1;

			public static Func<string, bool> A_f_2;

			public static Func<string, bool> a;
		}

		[Serializable]
		[CompilerGenerated]
		private sealed class a
		{
			public static readonly a A = new a();

			public static Func<string, string> A_1;

			public static Func<string, string> a_f_1;

			public static Func<string, bool> A_2;

			internal string A_m_1(string P_0)
			{
				return P_0;
			}

			internal string a_m_1(string P_0)
			{
				return P_0.Trim();
			}

			internal bool B(string P_0)
			{
				return P_0.Length > 0;
			}
		}

		[CompilerGenerated]
		private sealed class B
		{
			public Action<string, int, int, string> A;

			internal void A_m_1(int P_0, int P_1)
			{
				A?.Invoke(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.air(), P_0, P_1, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
			}

			internal void a(int P_0, int P_1)
			{
				A?.Invoke(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aiS(), P_0, P_1, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
			}
		}

		[CompilerGenerated]
		private sealed class b
		{
			public string A;

			internal bool A_m_1(string P_0)
			{
				return !global::a.a.A(P_0, A, true);
			}
		}

		public static R A_m_1(d P_0, CancellationToken P_1, Action<string, int, int, string> P_2)
		{
			R r2 = new R
			{
				A_4 = P_0.A
			};
			P_2?.Invoke(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHp(), 0, 0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHQ());
			List<string> list = e.B_m_1(P_0.A);
			if (!string.IsNullOrWhiteSpace(P_0.a))
			{
				string A = Path.GetFullPath(P_0.a);
				list = list.Where((string text4) => !global::a.a.A(text4, A, true)).ToList();
			}
			string[] array = a_m_1(P_0.d_f_2);
			if (array.Length != 0 || P_0.A_6 > 0 || P_0.F)
			{
				list = global::A.y.A_m_1(list, array, P_0.A_6, P_0.F, null);
			}
			List<string> list2 = list;
			r2.A_2 = list2.Count;
			r2.A_3 = ((IEnumerable<string>)list2).Sum((Func<string, long>)global::a.k.c);
			int arg = Math.Max(1, list2.Count);
			int num = 0;
			if (P_0.d_f_1)
			{
				P_2?.Invoke(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIV(), 0, arg, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIv());
				foreach (List<string> item in global::a.k.A_m_1(list2))
				{
					if (P_1.IsCancellationRequested)
					{
						break;
					}
					Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>(StringComparer.Ordinal);
					Dictionary<string, global::A.Z> dictionary2 = new Dictionary<string, global::A.Z>(StringComparer.OrdinalIgnoreCase);
					foreach (string item2 in item)
					{
						if (P_1.IsCancellationRequested)
						{
							break;
						}
						try
						{
							global::A.Z z2 = global::A.Z.A_m_1(item2, false);
							string key = (z2.A_2 = global::a.k.A_m_1(item2, P_1));
							dictionary2[item2] = z2;
							// R9 / C-03：登记扫描期快照，供实际删除路径统一复核。
							global::A.Z.a_m_1(item2, z2);
							if (!dictionary.TryGetValue(key, out var value))
							{
								value = (dictionary[key] = new List<string>());
							}
							value.Add(item2);
						}
						catch (Exception ex)
						{
							r2.A_6.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akT() + item2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JL() + ex.Message + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.R());
						}
						P_2?.Invoke(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIV(), ++num, arg, Path.GetFileName(item2));
					}
					foreach (KeyValuePair<string, List<string>> item3 in dictionary)
					{
						if (item3.Value.Count >= 2)
						{
							string text = e.A_m_1(item3.Value, P_0.D_1);
							r2.A_1.Add(A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cs(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.QN(), item3.Key, item3.Value, text, dictionary2));
						}
					}
				}
			}
			if (P_0.E && !P_1.IsCancellationRequested)
			{
				List<string> list4 = list2.Where(global::a.q.A_m_1).ToList();
				if (list4.Count >= 2)
				{
					P_2?.Invoke(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.air(), 0, list4.Count, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akt());
					Dictionary<string, global::A.Z> dictionary3 = A_m_1(list4);
					List<List<string>> list5 = global::a.q.A_m_1(list4, P_0.A_5, (int arg2, int arg3) =>
					{
						P_2?.Invoke(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.air(), arg2, arg3, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
					}, P_1);
					int num2 = 0;
					foreach (List<string> item4 in list5)
					{
						// C-15：扫描预览与真实执行使用同一套图片保留口径。
						string text2 = e.A_m_1(item4, (string.IsNullOrEmpty(P_0.h_2) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aia() : P_0.h_2));
						r2.A_1.Add(A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CU(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.QL(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akU() + ++num2, item4, text2, dictionary3));
					}
				}
			}
			if (P_0.f && !P_1.IsCancellationRequested)
			{
				List<string> list6 = list2.Where(global::A.S.A_m_1).ToList();
				P_2?.Invoke(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aiS(), 0, list6.Count, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aku());
				Dictionary<string, global::A.Z> dictionary4 = A_m_1(list6);
				List<List<string>> list7 = global::A.S.A_m_1(list6, P_0.a_2, (int arg2, int arg3) =>
				{
					P_2?.Invoke(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aiS(), arg2, arg3, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
				});
				int num3 = 0;
				foreach (List<string> item5 in list7)
				{
					string text3 = e.A_m_1(item5, P_0.D_1);
					r2.A_1.Add(A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CV(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.QM(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akV() + ++num3, item5, text3, dictionary4));
				}
			}
			P_2?.Invoke(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jv(), 1, 1, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.qO() + r2.A_1.Count + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akv());
			return r2;
		}

		private static q A_m_1(string P_0, string P_1, string P_2, List<string> P_3, string P_4, Dictionary<string, global::A.Z> P_5)
		{
			q q2 = new q
			{
				A_1 = P_0,
				a = P_1,
				B = P_2
			};
			foreach (string item in P_3.OrderBy((string result) => result, StringComparer.OrdinalIgnoreCase))
			{
				bool flag = string.Equals(item, P_4, StringComparison.OrdinalIgnoreCase);
				if (P_5 == null || !P_5.TryGetValue(item, out var value) || value == null)
				{
					value = global::A.Z.A_m_1(item, P_0 == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cs());
				}
				else if (string.IsNullOrEmpty(value.A_2))
				{
					// R8：相似图片/相似音频组原先只按 大小+修改时间 复核，内容变化但大小与时间戳未变时会被误删。
					// 这里对进入候选组的成员补算全量哈希（只针对候选组成员，成本可控），删除前复核改用哈希比对。
					global::A.Z z2 = global::A.Z.A_m_1(item, true);
					if (z2 != null && z2.A_3)
					{
						value = z2;
					}
				}
				// R9 / C-03：登记扫描期快照，供实际删除路径统一复核。
				global::A.Z.a_m_1(item, value);
				q2.A_2.Add(new Q
				{
					A = item,
					A_1 = global::a.k.c(item),
					A_2 = A_m_1(item),
					A_3 = flag,
					a = !flag,
					A_4 = value
				});
			}
			return q2;
		}

		private static Dictionary<string, global::A.Z> A_m_1(List<string> P_0)
		{
			Dictionary<string, global::A.Z> dictionary = new Dictionary<string, global::A.Z>(StringComparer.OrdinalIgnoreCase);
			foreach (string item in P_0)
			{
				try
				{
					dictionary[item] = global::A.Z.A_m_1(item, false);
				}
				catch
				{
				}
			}
			return dictionary;
		}

		private static DateTime A_m_1(string P_0)
		{
			try
			{
				return File.GetLastWriteTime(global::a.a.A(P_0));
			}
			catch
			{
				return DateTime.MinValue;
			}
		}

		private static string[] a_m_1(string P_0)
		{
			if (string.IsNullOrWhiteSpace(P_0))
			{
				return new string[0];
			}
			return (from text in Regex.Split(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aeq())
				select text.Trim() into text
				where text.Length > 0
				select text).ToArray();
		}
	}
}
