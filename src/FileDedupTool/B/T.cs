using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007B1262ED64_002DD0A6_002D499E_002D9510_002DF2240F018DBB_007D;
using a;

namespace B
{
	public sealed class T
	{
		public string A = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		public S A_1 = S.a;

		public bool A_2 = true;

		public static T Default => new T();
	}
	public static class t
	{
		public sealed class A
		{
			public string A_f_1;

			public string a;

			public A(string P_0, string P_1)
			{
				A_f_1 = P_0;
				a = P_1;
			}
		}

		[Serializable]
		[CompilerGenerated]
		private sealed class a
		{
			public static readonly a A = new a();

			public static Func<string, string> A_1;

			public static Func<string, bool> A_2;

			internal string A_m_1(string P_0)
			{
				return P_0.Trim();
			}

			internal bool a_m_1(string P_0)
			{
				return P_0.Length > 0;
			}
		}

		private const RegexOptions A_1 = RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant;

		private static readonly Regex A_2 = new Regex(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aey(), RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant);

		private static readonly Regex a_1 = new Regex(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aeZ(), RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant);

		private static readonly Regex B = new Regex(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aez(), RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant);

		private static readonly Regex b = new Regex(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFA(), RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant);

		private static readonly Regex C = new Regex(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aeJ(), RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant);

		private static readonly Regex c = new Regex(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFa(), RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant);

		private static readonly Regex D = new Regex(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFB(), RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant);

		private static readonly Regex d = new Regex(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFb(), RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant);

		private static readonly HashSet<string> A_3 = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
		{
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFC(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFc(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFD(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFd(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CU(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFE(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFe(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFF(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFf(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFG(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CE(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFg(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFH(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFh(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFI(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFi(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFJ(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CJ(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFj(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFK(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFk(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFL(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFl(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFM(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFm(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFN(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFn(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFO(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFo(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFP(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFp(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFQ(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFq(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFR(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFr(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFS(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFs(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFT(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFt(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFU(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFu(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFV(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFv(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFW(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFw(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFX(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFx(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFY(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFy(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFZ(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aFz(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.afA(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.afa(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.afB(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.afb(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.afC(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.afc(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.afD(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.afd(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aDl(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.afE(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.afe(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.afF(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aff(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.afG(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.afg(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.afH(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.afh(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.afI(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.afi(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.afJ(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.afj(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.afK(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.afk(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.afL(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.afl(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.afM(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.afm(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.HE(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.afN(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.afn(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.afO(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.afo(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.afP(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.afp(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.afQ(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aaK(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.afq(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.afR(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.afr(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.afS(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ad(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.afs(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.afT(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aft(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.afU(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.afu(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.afV(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.afv(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.afW(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.dy(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.de(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.dF(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.dN(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.dn(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.dT(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.dt(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.dE(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.dQ(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.gO(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.gp(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.gb(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Fk(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.FL(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.afw(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.afX(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.afx(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.afY(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.afy(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.afZ(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.afz(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGA(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGa(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGB(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGb(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGC(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGc(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGD(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGd(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGE(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGe(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGF()
		};

		private static readonly HashSet<string> a_2 = new HashSet<string>(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGf().Split(' '), StringComparer.OrdinalIgnoreCase);

		public static string A_m_1(string P_0)
		{
			if (string.IsNullOrEmpty(P_0))
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}
			string text = P_0.Trim();
			int num = 0;
			while (num++ < 8)
			{
				Match match = A_2.Match(text);
				if (!match.Success)
				{
					break;
				}
				text = text.Substring(match.Length).TrimStart();
			}
			num = 0;
			while (num++ < 8)
			{
				string text2 = a_1.Replace(text, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).TrimEnd();
				if (text2.Length == 0 || text2 == text)
				{
					break;
				}
				text = text2;
			}
			return text.Trim();
		}

		public static A A_m_1(string P_0, T P_1)
		{
			if (P_0.Length == 0)
			{
				return new A(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ael(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.xN());
			}
			if (P_1 != null && P_1.A_2 && U.A_m_1(P_0))
			{
				return new A(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aeM(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.xO());
			}
			if (P_1 != null && A_m_1(P_0, P_1.A))
			{
				return new A(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aem(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.xP());
			}
			if (B.IsMatch(P_0))
			{
				return new A(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aeN(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.xR());
			}
			if (b.IsMatch(P_0) || C.IsMatch(P_0) || c.IsMatch(P_0))
			{
				return new A(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aen(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.xS());
			}
			if (d.IsMatch(P_0) && P_0.Length >= 3)
			{
				return new A(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aeO(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.xT());
			}
			if (D.IsMatch(P_0))
			{
				return new A(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aeo(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.xU());
			}
			if (P_0.Length <= 3)
			{
				return new A(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aeP(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.xQ());
			}
			string[] array = Regex.Split(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aep());
			foreach (string text in array)
			{
				if (text.Length >= 3 && A_3.Contains(text))
				{
					return new A(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aeQ(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.xV());
				}
			}
			if (A_3.Contains(P_0))
			{
				return new A(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aeQ(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.xV());
			}
			return null;
		}

		private static bool A_m_1(string P_0, string P_1)
		{
			if (string.IsNullOrWhiteSpace(P_1))
			{
				return false;
			}
			string[] array = (from text in Regex.Split(P_1, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aeq())
				select text.Trim() into text
				where text.Length > 0
				select text).ToArray();
			foreach (string value in array)
			{
				if (P_0.IndexOf(value, StringComparison.OrdinalIgnoreCase) >= 0)
				{
					return true;
				}
			}
			return false;
		}

		public static string[] a_m_1(string P_0)
		{
			if (string.IsNullOrEmpty(P_0))
			{
				return null;
			}
			if (R.b_m_1(P_0) && !R.h_m_1(P_0))
			{
				return new string[2]
				{
					_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aeR(),
					_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.xW()
				};
			}
			if (R.c_m_1(P_0))
			{
				return new string[2]
				{
					_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aer(),
					_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.xX()
				};
			}
			if (R.C_m_1(P_0))
			{
				return new string[2]
				{
					_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aeS(),
					_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.xY()
				};
			}
			if (R.D_m_1(P_0))
			{
				return new string[2]
				{
					_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aes(),
					_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.xZ()
				};
			}
			if (R.d_m_1(P_0))
			{
				return new string[2]
				{
					_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aeT(),
					_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.YA()
				};
			}
			if (R.E_m_1(P_0))
			{
				return new string[2]
				{
					_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aet(),
					_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.YB()
				};
			}
			if (R.f_m_1(P_0))
			{
				return new string[2]
				{
					_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aeU(),
					_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.YC()
				};
			}
			if (R.F_m_1(P_0))
			{
				return new string[2]
				{
					_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aeu(),
					_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.YD()
				};
			}
			if (R.e_m_1(P_0))
			{
				return new string[2]
				{
					_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aeV(),
					_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.YE()
				};
			}
			return null;
		}

		public static int B_m_1(string P_0)
		{
			if (P_0 == null)
			{
				return 0;
			}
			P_0 = P_0.Trim();
			if (P_0.Length < 4)
			{
				return 0;
			}
			if (!Regex.IsMatch(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aeH()))
			{
				return 0;
			}
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 1;
			int num7 = 1;
			int num8 = 0;
			int num9 = 0;
			HashSet<char> hashSet = new HashSet<char>();
			bool flag = false;
			bool flag2 = false;
			int num10 = 0;
			for (int num11 = 0; num11 < P_0.Length; num11++)
			{
				char c2 = P_0[num11];
				hashSet.Add(c2);
				bool flag3 = char.IsDigit(c2);
				if (num11 == 0 || flag3 != flag2)
				{
					num10++;
					flag2 = flag3;
				}
				if (flag3)
				{
					num2++;
					num9 = 0;
					continue;
				}
				num++;
				if (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aev().IndexOf(c2) >= 0)
				{
					num3++;
					num9 = 0;
				}
				else
				{
					num9++;
					if (num9 > num8)
					{
						num8 = num9;
					}
				}
				bool flag4 = char.IsUpper(c2);
				if (flag4)
				{
					num4++;
				}
				if (num11 > 0 && char.IsLetter(P_0[num11 - 1]))
				{
					if (flag4 != flag)
					{
						num5++;
						num7 = 1;
					}
					else
					{
						num7++;
						if (num7 > num6)
						{
							num6 = num7;
						}
					}
				}
				flag = flag4;
			}
			if (num < 3)
			{
				return 0;
			}
			int num12 = 0;
			if (num10 >= 4)
			{
				num12 += 2;
			}
			else if (num10 == 3)
			{
				num12++;
			}
			double num13 = (double)num3 / (double)Math.Max(1, num);
			if (num13 < 0.1)
			{
				num12 += 2;
			}
			else if (num13 < 0.2)
			{
				num12++;
			}
			if (num2 > 0 && (double)num2 / (double)P_0.Length > 0.35)
			{
				num12 += 2;
			}
			else if (num2 > 0 && (double)num2 / (double)P_0.Length >= 0.25)
			{
				num12++;
			}
			if (num5 >= 4)
			{
				num12 += 2;
			}
			else if (num5 >= 2)
			{
				num12++;
			}
			if (num8 >= 4)
			{
				num12++;
			}
			if ((double)hashSet.Count / (double)P_0.Length >= 0.7)
			{
				num12++;
			}
			if (!b_m_1(Regex.Replace(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aeW(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D())))
			{
				num12 += 2;
			}
			if (num12 > 10)
			{
				num12 = 10;
			}
			return num12;
		}

		public static bool b_m_1(string P_0)
		{
			if (string.IsNullOrEmpty(P_0))
			{
				return true;
			}
			if (A_3.Contains(P_0))
			{
				return true;
			}
			foreach (string item in A_3)
			{
				if (item.Length >= 4 && P_0.IndexOf(item, StringComparison.OrdinalIgnoreCase) >= 0)
				{
					return true;
				}
			}
			string text = P_0.ToLowerInvariant();
			bool[] array = new bool[text.Length + 1];
			array[0] = true;
			for (int num = 1; num <= text.Length; num++)
			{
				for (int num2 = 1; num2 <= 6 && num2 <= num; num2++)
				{
					if (array[num - num2])
					{
						string text2 = text.Substring(num - num2, num2);
						if (num2 == 1 && _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aew().IndexOf(text2[0]) >= 0)
						{
							array[num] = true;
							break;
						}
						if (a_2.Contains(text2))
						{
							array[num] = true;
							break;
						}
					}
				}
			}
			return array[text.Length];
		}

		public static r A_m_1(int P_0, S P_1)
		{
			int num;
			int num2;
			switch (P_1)
			{
			case S.A:
				num = 2;
				num2 = 9;
				break;
			case S.B:
				num = 2;
				num2 = 5;
				break;
			default:
				num = 3;
				num2 = 7;
				break;
			}
			if (P_0 >= num2)
			{
				return r.a;
			}
			if (P_0 <= num)
			{
				return r.A;
			}
			return r.B;
		}

		public static s a_m_1(string P_0, T P_1)
		{
			P_1 = P_1 ?? T.Default;
			string text = A_m_1(P_0);
			s s2 = new s
			{
				B = text
			};
			A a2 = A_m_1(text, P_1);
			if (a2 != null)
			{
				s2.A = r.A;
				s2.A_1 = a2.A_f_1;
				s2.a = a2.a;
				s2.A_2 = 0;
				return s2;
			}
			string[] array = a_m_1(text);
			if (array != null)
			{
				s2.A = r.a;
				s2.A_1 = array[0];
				s2.a = array[1];
				s2.A_2 = 10;
				s2.A_3 = true;
				return s2;
			}
			s2.A = A_m_1(s2.A_2 = B_m_1(text), P_1.A_1);
			if (s2.A == r.a)
			{
				s2.A_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aeX();
				s2.a = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.YF();
			}
			else if (s2.A == r.B)
			{
				s2.A_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aex();
				s2.a = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.YG();
			}
			else
			{
				s2.A_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aeY();
				s2.a = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.YH();
			}
			return s2;
		}

		public static s B_m_1(string P_0, T P_1)
		{
			P_1 = P_1 ?? T.Default;
			string text = A_m_1(P_0);
			s s2 = new s
			{
				B = text
			};
			A a2 = A_m_1(text, P_1);
			if (a2 != null)
			{
				s2.A = r.A;
				s2.A_1 = a2.A_f_1;
				s2.a = a2.a;
				return s2;
			}
			string[] array = a_m_1(text);
			if (array != null)
			{
				s2.A = r.a;
				s2.A_1 = array[0];
				s2.a = array[1];
				s2.A_2 = 10;
				s2.A_3 = true;
			}
			else
			{
				s2.A = r.A;
				s2.A_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aeY();
				s2.a = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.YH();
				s2.A_2 = B_m_1(text);
			}
			return s2;
		}
	}
}
namespace b
{
	public sealed class T
	{
		public s A;

		public readonly List<S> A_1 = new List<S>();

		public bool A_2;

		public bool a;

		public string A_3;

		public string a_1;

		public string BackendKey => A switch
		{
			s.a => _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akW(), 
			s.B => _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akw(), 
			s.b => _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akX(), 
			_ => _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akx(), 
		};
	}
	public static class t
	{
		private struct A
		{
			public nuint A_f_1;

			public int A_f_2;

			public nint A_f_3;
		}

		private struct a
		{
			public nint A;

			public uint A_1;

			public nint a_f_1;

			public nint B;

			public uint a_f_2;

			public int A_2;

			public int a_f_3;

			public uint B_1;
		}

		private sealed class B : NativeWindow
		{
			public volatile bool A;

			public byte[] A_1;

			private readonly int A_2;

			public B(int P_0)
			{
				A_2 = P_0;
				CreateParams cp = new CreateParams
				{
					Caption = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aOc(),
					X = 0,
					Y = 0,
					Width = 0,
					Height = 0,
					Parent = new IntPtr(-3)
				};
				CreateHandle(cp);
			}

			protected override void WndProc(ref Message P_0)
			{
				if (P_0.Msg == 74 && P_0.LParam != IntPtr.Zero)
				{
					A a2 = Marshal.PtrToStructure<A>(P_0.LParam);
					if ((int)a2.A_f_1 == A_2 && a2.A_f_3 != IntPtr.Zero && a2.A_f_2 > 0)
					{
						byte[] array = new byte[a2.A_f_2];
						Marshal.Copy(a2.A_f_3, array, 0, array.Length);
						A_1 = array;
						A = true;
					}
					P_0.Result = 1;
				}
				else
				{
					base.WndProc(ref P_0);
				}
			}
		}

		private const int A_1 = 74;

		private const uint A_2 = 1024u;

		private const int a_1 = 18;

		private const int B_1 = 19024;

		private const int b = -3;

		private const uint a_2 = 1u;

		private const uint B_2 = 2u;

		private const uint b_1 = 16u;

		private const uint C = 64u;

		private const uint c = 1u;

		private const uint D = 1u;

		private const uint d = 1u;

		[DllImport("user32.dll", CharSet = CharSet.Unicode, EntryPoint = "FindWindowW", SetLastError = true)]
		private static extern nint A_m_1(string P_0, string P_1);

		[DllImport("user32.dll", EntryPoint = "SendMessageW")]
		private static extern nint A_m_1(nint P_0, uint P_1, nint P_2, nint P_3);

		[DllImport("user32.dll", EntryPoint = "SendMessageW")]
		private static extern nint A_m_1(nint P_0, uint P_1, nint P_2, ref A P_3);

		[DllImport("user32.dll", EntryPoint = "PeekMessageW")]
		private static extern bool A_m_1(out a P_0, nint P_1, uint P_2, uint P_3, uint P_4);

		[DllImport("user32.dll", EntryPoint = "TranslateMessage")]
		private static extern bool A_m_1(ref a P_0);

		[DllImport("user32.dll", EntryPoint = "DispatchMessageW")]
		private static extern nint a_m_1(ref a P_0);

		public static bool A_m_1(out string P_0)
		{
			P_0 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			try
			{
				nint num = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akY(), null);
				if (num == IntPtr.Zero)
				{
					return false;
				}
				int num2 = (int)A_m_1(num, 1024u, 0, IntPtr.Zero);
				int num3 = (int)A_m_1(num, 1024u, 1, IntPtr.Zero);
				int num4 = (int)A_m_1(num, 1024u, 2, IntPtr.Zero);
				int num5 = (int)A_m_1(num, 1024u, 3, IntPtr.Zero);
				if (num2 <= 0)
				{
					return false;
				}
				P_0 = num2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.DS() + num3 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.DS() + num4 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.DS() + num5;
				if (num2 < 1)
				{
					return false;
				}
				if (num2 == 1 && num3 < 4)
				{
					return false;
				}
				if (num2 == 1 && num3 == 4 && num4 < 1)
				{
					return false;
				}
				return true;
			}
			catch
			{
				return false;
			}
		}

		public static T A_m_1(string P_0, int P_1, CancellationToken P_2)
		{
			T t2 = new T
			{
				A = s.a
			};
			if (!A_m_1(out var text))
			{
				t2.A_3 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aky();
				return t2;
			}
			int num = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akZ(), 8000);
			nint num2 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akY(), null);
			B b2 = null;
			try
			{
				b2 = new B(19024);
				byte[] array = A_m_1(b2.Handle, 19024, P_0, P_1, 83u);
				A a2 = new A
				{
					A_f_1 = 18u,
					A_f_2 = array.Length,
					A_f_3 = Marshal.AllocHGlobal(array.Length)
				};
				try
				{
					Marshal.Copy(array, 0, a2.A_f_3, array.Length);
					nint num3;
					lock (typeof(t))
					{
						num3 = A_m_1(num2, 74u, b2.Handle, ref a2);
					}
					if (num3 == IntPtr.Zero)
					{
						t2.A_3 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.akz();
						return t2;
					}
				}
				finally
				{
					Marshal.FreeHGlobal(a2.A_f_3);
				}
				long num4 = Environment.TickCount64 + num;
				while (!b2.A)
				{
					P_2.ThrowIfCancellationRequested();
					if (Environment.TickCount64 > num4)
					{
						t2.A_3 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLA();
						return t2;
					}
					if (A_m_1(out var a3, IntPtr.Zero, 0u, 0u, 1u))
					{
						A_m_1(ref a3);
						a_m_1(ref a3);
					}
					else
					{
						Thread.Sleep(1);
					}
				}
				if (b2.A_1 == null || b2.A_1.Length == 0)
				{
					t2.A_3 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLa();
					return t2;
				}
				t2.A_1.AddRange(A_m_1(b2.A_1));
				if (t2.A_1.Count >= P_1)
				{
					t2.A_2 = true;
				}
				t2.a_1 = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.TU(), text);
				return t2;
			}
			catch (OperationCanceledException)
			{
				t2.a = true;
				return t2;
			}
			catch (Exception ex2)
			{
				t2.A_3 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLB() + ex2.Message;
				return t2;
			}
			finally
			{
				if (b2 != null)
				{
					try
					{
						b2.ReleaseHandle();
					}
					catch
					{
					}
				}
			}
		}

		internal static byte[] A_m_1(nint P_0, int P_1, string P_2, int P_3, uint P_4)
		{
			if (P_2 == null)
			{
				P_2 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}
			byte[] array = new byte[28 + (P_2.Length + 1) * 2];
			A_m_1(array, 0, (uint)(((IntPtr)P_0).ToInt64() & 0xFFFFFFFFu));
			A_m_1(array, 4, (uint)P_1);
			A_m_1(array, 8, 0u);
			A_m_1(array, 12, 0u);
			A_m_1(array, 16, (uint)P_3);
			A_m_1(array, 20, P_4);
			A_m_1(array, 24, 1u);
			for (int num = 0; num < P_2.Length; num++)
			{
				A_m_1(array, 28 + num * 2, P_2[num]);
			}
			return array;
		}

		private static void A_m_1(byte[] P_0, int P_1, uint P_2)
		{
			P_0[P_1] = (byte)P_2;
			P_0[P_1 + 1] = (byte)(P_2 >> 8);
			P_0[P_1 + 2] = (byte)(P_2 >> 16);
			P_0[P_1 + 3] = (byte)(P_2 >> 24);
		}

		private static void A_m_1(byte[] P_0, int P_1, ushort P_2)
		{
			P_0[P_1] = (byte)P_2;
			P_0[P_1 + 1] = (byte)(P_2 >> 8);
		}

		private static uint A_m_1(byte[] P_0, int P_1)
		{
			return (uint)(P_0[P_1] | (P_0[P_1 + 1] << 8) | (P_0[P_1 + 2] << 16) | (P_0[P_1 + 3] << 24));
		}

		internal static List<S> A_m_1(byte[] P_0)
		{
			List<S> list = new List<S>();
			if (P_0 == null || P_0.Length < 20)
			{
				return list;
			}
			int num = (int)A_m_1(P_0, 4);
			uint num2 = A_m_1(P_0, 12);
			int num3 = 20;
			for (int num4 = 0; num4 < num; num4++)
			{
				int num5 = num3 + num4 * 8;
				if (num5 + 8 > P_0.Length)
				{
					break;
				}
				uint num6 = A_m_1(P_0, num5);
				int num7 = (int)A_m_1(P_0, num5 + 4);
				if (num7 <= 0 || num7 >= P_0.Length)
				{
					continue;
				}
				string text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
				string text2 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
				long num8 = -1L;
				DateTime dateTime = DateTime.MinValue;
				int num9 = num7;
				if ((num2 & 1) != 0)
				{
					text = A_m_1(P_0, ref num9);
				}
				if ((num2 & 2) != 0)
				{
					text2 = A_m_1(P_0, ref num9);
				}
				if ((num2 & 4) != 0)
				{
					A_m_1(P_0, ref num9);
				}
				if ((num2 & 0x10) != 0 && num9 + 8 <= P_0.Length)
				{
					long num10 = 0L;
					for (int num11 = 7; num11 >= 0; num11--)
					{
						num10 = (num10 << 8) | P_0[num9 + num11];
					}
					num8 = num10;
					num9 += 8;
				}
				if ((num2 & 8) != 0)
				{
					A_m_1(P_0, ref num9);
				}
				if ((num2 & 0x20) != 0 && num9 + 8 <= P_0.Length)
				{
					num9 += 8;
				}
				if ((num2 & 0x40) != 0 && num9 + 8 <= P_0.Length)
				{
					long num12 = 0L;
					for (int num13 = 7; num13 >= 0; num13--)
					{
						num12 = (num12 << 8) | P_0[num9 + num13];
					}
					if (num12 > 0 && num12 < long.MaxValue)
					{
						try
						{
							dateTime = DateTime.FromFileTimeUtc(num12).ToLocalTime();
						}
						catch
						{
						}
					}
					num9 += 8;
				}
				if ((num6 & 1) == 0 && text.Length != 0)
				{
					string text3 = (string.IsNullOrEmpty(text2) ? text : (text2.TrimEnd('\\', '/') + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jb() + text));
					S item = new S
					{
						A = text,
						a = text2,
						B = text3,
						A_1 = num8,
						A_2 = dateTime
					};
					list.Add(item);
				}
			}
			return list;
		}

		private static string A_m_1(byte[] P_0, ref int P_1)
		{
			if (P_1 + 4 > P_0.Length)
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}
			int num = (int)A_m_1(P_0, P_1);
			P_1 += 4;
			int num2 = num * 2;
			if (num <= 0 || P_1 + num2 > P_0.Length)
			{
				P_1 += Math.Max(0, num2);
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}
			StringBuilder stringBuilder = new StringBuilder(num);
			for (int num3 = 0; num3 < num; num3++)
			{
				stringBuilder.Append((char)(P_0[P_1 + num3 * 2] | (P_0[P_1 + num3 * 2 + 1] << 8)));
			}
			P_1 += num2 + 2;
			return stringBuilder.ToString();
		}

		internal static int A_m_1(string P_0, int P_1)
		{
			try
			{
				string environmentVariable = Environment.GetEnvironmentVariable(P_0);
				if (!string.IsNullOrWhiteSpace(environmentVariable) && int.TryParse(environmentVariable, out var result) && result > 0)
				{
					return result;
				}
			}
			catch
			{
			}
			return P_1;
		}
	}
}
