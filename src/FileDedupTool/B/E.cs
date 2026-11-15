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
using B;
using a;

namespace B
{
	internal sealed class E
	{
		[CompilerGenerated]
		private string A;

		[CompilerGenerated]
		private string a;

		[CompilerGenerated]
		private bool A_1;

		[CompilerGenerated]
		private long A_2;

		[CompilerGenerated]
		private string B;

		public string FileId
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

		public string Name
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

		public bool IsFolder
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

		public long SizeBytes
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

		public string Time
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
	}
	internal sealed class e
	{
		[CompilerGenerated]
		private bool A;

		[CompilerGenerated]
		private bool a;

		[CompilerGenerated]
		private string A_1;

		[CompilerGenerated]
		private string a_1;

		[CompilerGenerated]
		private string B;

		public bool Found
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

		public bool Success
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

		public string FileName
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

		public string Message
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
	}
}
namespace b
{
	public sealed class E
	{
		public int A;

		public int a;

		public int B;

		public int b;

		public int C;

		public int c;

		public int D;

		public int d;

		public int E_f_1;

		public int e;

		public int F;

		public int f;

		public int G;

		public int g;

		public bool A_1;

		public override string ToString()
		{
			string text = ((g > 0) ? (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahk() + g) : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
			return string.Format(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahL(), A, a, B, C, D, d, E_f_1, b + c, A_1 ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahl() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(), F, f, G, text);
		}

		public string A_m_1()
		{
			if (!global::a.Q.EnMode)
			{
				return ToString();
			}
			string text = ((g > 0) ? (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahM() + g) : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
			return string.Format(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahm(), A, a, B, C, D, d, E_f_1, b + c, A_1 ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahN() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(), F, f, G, text);
		}
	}
	public sealed class e
	{
		[CompilerGenerated]
		private static class A
		{
			public static Func<string, bool> A_f_1;

			public static Func<string, bool> a;

			public static Func<string, DateTime> A_f_2;

			public static Func<string, long> A_f_3;
		}

		[Serializable]
		[CompilerGenerated]
		private sealed class a
		{
			public static readonly a A = new a();

			public static Func<string, string> A_1;

			public static Func<string, bool> A_2;

			public static Func<string, int> A_3;

			public static Func<string, int> a_f_1;

			public static Func<string, int> B;

			public static Func<string, int> b;

			public static Func<string, int> C;

			public static Func<string, int> c;

			public static Func<KeyValuePair<string, int>, int> A_4;

			public static Comparison<string> A_5;

			internal string A_m_1(string P_0)
			{
				return P_0.Trim();
			}

			internal bool a_m_1(string P_0)
			{
				return P_0.Length > 0;
			}

			internal int B_m_1(string P_0)
			{
				return P_0.Length;
			}

			internal int b_m_1(string P_0)
			{
				return P_0.Length;
			}

			internal int C_m_1(string P_0)
			{
				return P_0.Length;
			}

			internal int c_m_1(string P_0)
			{
				return Path.GetFileName(P_0).Length;
			}

			internal int D(string P_0)
			{
				return P_0.Length;
			}

			internal int d(string P_0)
			{
				return P_0.Length;
			}

			internal int A_m_1(KeyValuePair<string, int> P_0)
			{
				return P_0.Value;
			}

			internal int A_m_1(string P_0, string P_1)
			{
				return P_1.Length.CompareTo(P_0.Length);
			}
		}

		[CompilerGenerated]
		private sealed class B
		{
			public string A;

			internal bool A_m_1(string P_0)
			{
				return !global::a.a.A(P_0, A, true);
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

		[CompilerGenerated]
		private sealed class C
		{
			public string A;

			internal bool A_m_1(string P_0)
			{
				return A.IndexOf(P_0, StringComparison.OrdinalIgnoreCase) >= 0;
			}
		}

		private readonly d A_1;

		private readonly E A_2 = new E();

		private CancellationToken A_3;

		private bool A_4;

		private global::B.w A_5;

		private string[] A_6 = new string[0];

		public Action<string, int, int, string> A_7;

		private List<string> A_8;

		private string A_9 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		public E Result => A_2;

		public string OpsLogPath
		{
			get
			{
				if (A_5 != null)
				{
					return A_5.FilePath;
				}
				return null;
			}
		}

		public e(d P_0)
		{
			A_1 = P_0;
		}

		public E A_m_1(CancellationToken P_0)
		{
			A_3 = P_0;
			A_2.A_1 = A_1.c_1;
			A_6 = A_m_1(A_1.C);
			A_5 = new global::B.w(A_1.c_1);
			try
			{
				global::a.j.C_m_1();
			}
			catch (global::a.J j2)
			{
				global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahn(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHS(), A_1.A, j2.Message, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf());
				A_5.Dispose();
				return A_2;
			}
			global::B.p.A_m_1(new string('#', 56));
			global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahO() + DateTime.Now.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CI()) + (A_1.c_1 ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHT() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()));
			global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Sz() + A_1.A);
			global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.rq() + ((A_1.a.Length > 0) ? A_1.a : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aho()));
			global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahP() + A_m_1(A_1.A_2));
			string text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahp();
			string text2;
			if (A_1.c_1)
			{
				text2 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahq();
			}
			else
			{
				text2 = ((A_1.A_3 == global::a.A.A_f_1) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahQ() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ci());
			}
			global::B.p.A_m_1(text + text2);
			global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.IB() + A_5.FilePath);
			if (A_6.Length != 0)
			{
				global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahR() + string.Join(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aw(), A_6));
			}
			if (!Directory.Exists(A_1.A))
			{
				global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahn(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHp(), A_1.A, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.It(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf());
				A_5.Dispose();
				return A_2;
			}
			try
			{
				if (A_1.A_8 != null)
				{
					if (A_1.d_f_1 && !A_m_1())
					{
						D();
					}
					if (A_1.E && !A_m_1())
					{
						d();
					}
					if (A_1.f && !A_m_1())
					{
						E();
					}
					if (A_1.A_1 && !A_m_1())
					{
						A_m_1(true);
					}
					if (A_1.a_1 && !A_m_1())
					{
						A_m_1(false);
					}
					if (A_1.B_1 && !A_m_1())
					{
						C_m_1();
					}
					if (A_1.b_1 && !A_m_1())
					{
						c();
					}
				}
				else
				{
					if (A_1.A_1 && !A_m_1())
					{
						A_m_1(true);
					}
					if (A_1.a_1 && !A_m_1())
					{
						A_m_1(false);
					}
					if (A_1.B_1 && !A_m_1())
					{
						C_m_1();
					}
					if (A_1.b_1 && !A_m_1())
					{
						c();
					}
					if (A_1.d_f_1 && !A_m_1())
					{
						D();
					}
					if (A_1.E && !A_m_1())
					{
						d();
					}
					if (A_1.f && !A_m_1())
					{
						E();
					}
				}
				if (A_1.C_1 && !A_m_1())
				{
					e_m_1();
				}
				if (A_1.e && !A_m_1())
				{
					F();
				}
			}
			catch (Exception ex)
			{
				global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahn(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lJ(), A_1.A, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahr() + ex.Message, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf());
				global::B.p.B(ex.StackTrace ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
			}
			finally
			{
				A_5.Dispose();
			}
			global::B.p.A_m_1(new string('=', 46));
			global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahS() + (P_0.IsCancellationRequested ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahs() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jv()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bH() + A_2);
			A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jv(), 1, 1, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
			return A_2;
		}

		private static string A_m_1(D P_0)
		{
			return P_0 switch
			{
				global::b.D.a => _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahT(), 
				global::b.D.B => _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aht(), 
				_ => _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahU(), 
			};
		}

		private bool A_m_1()
		{
			if (A_3.IsCancellationRequested)
			{
				if (!A_4)
				{
					A_4 = true;
					global::B.p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahu());
				}
				return true;
			}
			return false;
		}

		private void A_m_1(string P_0, int P_1, int P_2, string P_3)
		{
			Action<string, int, int, string> a_ = A_7;
			if (a_ != null)
			{
				try
				{
					a_(P_0, P_1, P_2, P_3);
				}
				catch
				{
				}
			}
		}

		private static string[] A_m_1(string P_0)
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

		private bool a_m_1(string P_0)
		{
			if (A_6.Length == 0)
			{
				return false;
			}
			string[] a_ = A_6;
			foreach (string value in a_)
			{
				if (P_0.IndexOf(value, StringComparison.OrdinalIgnoreCase) >= 0)
				{
					A_2.e++;
					return true;
				}
			}
			return false;
		}

		public static List<string> B_m_1(string P_0)
		{
			List<string> list = new List<string>();
			Stack<string> stack = new Stack<string>();
			stack.Push(P_0);
			while (stack.Count > 0)
			{
				string text = stack.Pop();
				try
				{
					foreach (string item in Directory.EnumerateFiles(global::a.a.A(text)))
					{
						string text2 = global::a.a.a_m_1(item);
						try
						{
							if ((File.GetAttributes(global::a.a.A(text2)) & FileAttributes.ReparsePoint) != 0)
							{
								continue;
							}
						}
						catch
						{
							continue;
						}
						list.Add(text2);
					}
				}
				catch (Exception ex)
				{
					global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahV(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahv(), text, ex.Message, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf());
				}
				try
				{
					foreach (string item2 in Directory.EnumerateDirectories(global::a.a.A(text)))
					{
						string text3 = global::a.a.a_m_1(item2);
						try
						{
							if ((File.GetAttributes(global::a.a.A(text3)) & FileAttributes.ReparsePoint) != 0)
							{
								global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahV(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHp(), text3, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahW(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ip());
								continue;
							}
						}
						catch
						{
							continue;
						}
						stack.Push(text3);
					}
				}
				catch (Exception ex2)
				{
					global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahV(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahw(), text, ex2.Message, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf());
				}
			}
			return list;
		}

		private List<string> a_m_1()
		{
			List<string> list = B_m_1(A_1.A);
			if (!string.IsNullOrWhiteSpace(A_1.a))
			{
				string A = Path.GetFullPath(A_1.a);
				list = list.Where((string P_0) => !global::a.a.A(P_0, A, true)).ToList();
			}
			string[] array = A_m_1(A_1.d_f_2);
			if (array.Length != 0 || A_1.A_6 > 0 || A_1.F)
			{
				int count = list.Count;
				list = global::A.y.A_m_1(list, array, A_1.A_6, A_1.F, delegate
				{
					A_2.G++;
				});
				if (count - list.Count > 0)
				{
					global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahX() + (count - list.Count) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahx() + ((A_1.A_6 > 0) ? (A_1.A_6 / 1024 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BE()) : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahY()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahy() + array.Length + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahZ() + (A_1.F ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIA() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahz()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ln());
				}
			}
			return list;
		}

		public static List<string> A_m_1(d P_0)
		{
			List<string> list = B_m_1(P_0.A);
			if (!string.IsNullOrWhiteSpace(P_0.a))
			{
				string A = Path.GetFullPath(P_0.a);
				list = list.Where((string text) => !global::a.a.A(text, A, true)).ToList();
			}
			string[] array = A_m_1(P_0.d_f_2);
			if (array.Length != 0 || P_0.A_6 > 0 || P_0.F)
			{
				list = global::A.y.A_m_1(list, array, P_0.A_6, P_0.F, null);
			}
			return list;
		}

		private List<string> B_m_1()
		{
			string text = A_1.A + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lz() + A_1.a + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lz() + A_1.d_f_2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lz() + A_1.A_6 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lz() + A_1.F;
			if (A_8 != null && A_9 == text)
			{
				return A_8;
			}
			A_8 = a_m_1();
			A_9 = text;
			return A_8;
		}

		private void b_m_1()
		{
			A_8 = null;
			A_9 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
		}

		private void A_m_1(bool P_0)
		{
			string text = (P_0 ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIB() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIa());
			global::B.p.A_m_1(new string('=', 46));
			global::B.p.A_m_1(P_0 ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIC() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIb());
			List<string> list = B_m_1();
			int num = 0;
			foreach (string item in list)
			{
				if (A_3.IsCancellationRequested)
				{
					return;
				}
				string fileName = Path.GetFileName(item);
				A_m_1(text, ++num, list.Count, fileName);
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);
				string extension = Path.GetExtension(fileName);
				if (!a_m_1(fileNameWithoutExtension))
				{
					string text2 = (P_0 ? global::B.R.a_m_1(fileNameWithoutExtension) : global::B.R.B_m_1(fileNameWithoutExtension));
					if (!(text2 == fileNameWithoutExtension))
					{
						A_m_1(item, Path.Combine(Path.GetDirectoryName(item), text2 + extension));
					}
				}
			}
			b_m_1();
		}

		private void A_m_1(string P_0, string P_1)
		{
			string fileName = Path.GetFileName(P_0);
			string fileName2 = Path.GetFileName(P_1);
			if (string.Equals(fileName, fileName2, StringComparison.OrdinalIgnoreCase))
			{
				return;
			}
			if (File.Exists(global::a.a.A(P_1)))
			{
				switch (A_1.A_2)
				{
				case global::b.D.a:
					global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahV(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIc(), P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHv(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ip());
					A_2.b++;
					A_5.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGm(), P_0, P_1, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aeY());
					return;
				case global::b.D.B:
					break;
				default:
					a_m_1(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aID());
					return;
				}
				P_1 = global::a.a.E(P_1);
				fileName2 = Path.GetFileName(P_1);
			}
			if (A_1.c_1)
			{
				global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aId() + fileName + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.IS() + fileName2);
				A_2.A++;
				A_5.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGm(), P_0, P_1, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ik());
				return;
			}
			if (!B_m_1(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIc()))
			{
				A_2.b++;
				A_5.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGm(), P_0, P_1, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahA());
				return;
			}
			try
			{
				global::a.a.a_m_1(P_0, P_1);
				global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIE() + fileName + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.IS() + fileName2);
				A_2.A++;
				A_5.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGm(), P_0, P_1, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.IK());
			}
			catch (Exception ex)
			{
				global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahV(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIc(), P_0, ex.Message, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf());
				A_2.b++;
				A_5.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGm(), P_0, P_1, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jD());
			}
		}

		private void C_m_1()
		{
			global::B.p.A_m_1(new string('=', 46));
			global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIe());
			List<string> list = B_m_1();
			global::B.T t2 = new global::B.T
			{
				A = A_1.C,
				A_1 = (global::B.S)Math.Max(0, Math.Min(2, A_1.B_2))
			};
			List<KeyValuePair<string, global::B.s>> list2 = new List<KeyValuePair<string, global::B.s>>();
			int num = 0;
			foreach (string item in list)
			{
				if (A_3.IsCancellationRequested)
				{
					return;
				}
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(item);
				if (!a_m_1(fileNameWithoutExtension))
				{
					global::B.s s2 = global::B.t.a_m_1(fileNameWithoutExtension, t2);
					list2.Add(new KeyValuePair<string, global::B.s>(item, s2));
					if (s2.A == global::B.r.B)
					{
						num++;
					}
				}
			}
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			foreach (KeyValuePair<string, global::B.s> item2 in list2)
			{
				if (A_3.IsCancellationRequested)
				{
					return;
				}
				string key = item2.Key;
				global::B.s value = item2.Value;
				string fileName = Path.GetFileName(key);
				A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIF(), ++num2, list.Count, fileName);
				if (value.A == global::B.r.A)
				{
					if (value.A_1 != _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aeY() && value.A_1.Length > 0)
					{
						global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIf() + fileName + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.IF() + value.a + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ln());
					}
				}
				else if (value.A == global::B.r.B)
				{
					if (A_1.g && A_1.A_7 != null && A_1.A_7.Contains(b_m_1(key)))
					{
						global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIG() + key + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acf() + value.a + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIg() + num);
						A_5.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIH(), key, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jc(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBI() + value.a + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ach() + num);
						num3++;
						if (a_m_1(key, value.a))
						{
							A_2.a++;
						}
					}
					else
					{
						num4++;
						A_2.g++;
						global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIG() + key + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.acf() + value.a + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIh() + num);
						A_5.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIH(), key, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aeY(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBI() + value.a + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ach() + num);
					}
				}
				else
				{
					num3++;
					if (a_m_1(key, value.a))
					{
						A_2.a++;
					}
				}
			}
			global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aII() + list.Count + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIi() + num3 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIJ());
			if (num4 > 0)
			{
				string text = (A_1.g ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIK() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIj());
				global::B.p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIk() + num4 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIL() + text + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ln());
			}
			b_m_1();
		}

		private bool a_m_1(string P_0, string P_1)
		{
			return A_m_1(P_0, P_1, null);
		}

		private bool B_m_1(string P_0, string P_1)
		{
			if (!global::a.a.F(P_0))
			{
				return true;
			}
			if (global::B.O.A_m_1(P_0, A_1.D, A_1.A_4, out var text) == global::B.n.a)
			{
				global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIl() + P_1 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.IQ() + P_0 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.DG() + text);
				return true;
			}
			global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahV(), P_1, P_0, (text.Length > 0) ? text : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHz(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ip());
			return false;
		}

		private bool A_m_1(string P_0, string P_1, string P_2)
		{
			if (A_1.A_2 == global::b.D.a)
			{
				global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahV(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aha(), P_0, P_1, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ip());
				A_5.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jc(), P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aeY());
				A_2.b++;
				return false;
			}
			if (A_1.c_1)
			{
				global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIM() + P_1 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIm() + P_0);
				A_5.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jc(), P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ik());
				return true;
			}
			if (A_1.A_9 != null)
			{
				string key = b_m_1(P_0);
				if (A_1.A_9.TryGetValue(key, out var value) && value != null)
				{
					string text = value.A_m_1(P_0);
					if (text != null)
					{
						global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahV(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIN(), P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIn() + text + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ln(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ip());
						A_5.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jc(), P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIO());
						A_2.b++;
						return false;
					}
				}
				else if (A_1.A_8 != null && A_1.A_8.ContainsKey(key))
				{
					global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahV(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIN(), P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIo(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ip());
					A_5.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jc(), P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIP());
					A_2.b++;
					return false;
				}
			}
			if (!B_m_1(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ot()))
			{
				A_5.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jc(), P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahA());
				A_2.b++;
				return false;
			}
			if (A_1.G && !string.IsNullOrEmpty(P_2))
			{
				if (global::a.K.A(P_0, P_2, out var text2))
				{
					global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIp() + P_1 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIm() + P_0 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.IS() + P_2);
					A_5.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIQ(), P_0, P_2, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.IK());
					A_2.f++;
					return true;
				}
				global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahV(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIq(), P_0, text2, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ip());
				A_5.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIQ(), P_0, P_2, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jD());
				A_2.b++;
				return false;
			}
			if (global::a.a.A(P_0, A_1.A_3, out var text3, out var text4))
			{
				global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIR() + P_1 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIm() + P_0);
				string text5 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
				if (!string.IsNullOrEmpty(text4) && !global::a.a.A(text4, P_0))
				{
					text5 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jF() + text4;
				}
				A_5.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jc(), P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.IK(), text5);
				return true;
			}
			global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahV(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ot(), P_0, text3, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf());
			A_5.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jc(), P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jD());
			A_2.b++;
			return false;
		}

		private void c()
		{
			global::B.p.A_m_1(new string('=', 46));
			global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIr());
			List<string> list = B_m_1();
			int num = 0;
			int num2 = 0;
			foreach (string item in list)
			{
				if (A_3.IsCancellationRequested)
				{
					return;
				}
				A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIS(), ++num, list.Count, Path.GetFileName(item));
				try
				{
					FileAttributes attributes = File.GetAttributes(global::a.a.A(item));
					if ((attributes & FileAttributes.ReadOnly) != FileAttributes.None)
					{
						num2++;
						if (!A_1.c_1)
						{
							File.SetAttributes(global::a.a.A(item), attributes & ~FileAttributes.ReadOnly);
							A_5.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIs(), item, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.IK());
						}
					}
				}
				catch (Exception ex)
				{
					global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahV(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIT(), item, ex.Message, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf());
				}
			}
			A_2.C = num2;
			global::B.p.A_m_1((A_1.c_1 ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIU() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIt()) + num2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIJ());
		}

		private void D()
		{
			global::B.p.A_m_1(new string('=', 46));
			global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIu() + A_1.D_1 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ln());
			List<string> list = B_m_1();
			int count = list.Count;
			int num = 0;
			int num2 = 0;
			A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIV(), 0, count, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIv());
			foreach (List<string> item in global::a.k.A_m_1(list))
			{
				if (A_3.IsCancellationRequested)
				{
					return;
				}
				Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>(StringComparer.Ordinal);
				foreach (string item2 in item)
				{
					if (A_3.IsCancellationRequested)
					{
						return;
					}
					A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIV(), ++num, count, Path.GetFileName(item2));
					string key;
					try
					{
						key = global::a.k.A_m_1(item2, A_3);
					}
					catch (Exception ex)
					{
						global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahV(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIW(), item2, ex.Message, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ip());
						continue;
					}
					if (!dictionary.TryGetValue(key, out var value))
					{
						value = (dictionary[key] = new List<string>());
					}
					value.Add(item2);
				}
				foreach (KeyValuePair<string, List<string>> item3 in dictionary)
				{
					if (item3.Value.Count < 2)
					{
						continue;
					}
					string text = A_m_1(item3.Value, A_1.D_1);
					foreach (string item4 in item3.Value)
					{
						if (A_1.A_8 != null)
						{
							if (A_1.A_8.TryGetValue(b_m_1(item4), out var value2) && !string.Equals(item4, value2, StringComparison.OrdinalIgnoreCase) && A_m_1(item4, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIw() + Path.GetFileName(value2), value2))
							{
								num2++;
							}
						}
						else if (!string.Equals(item4, text, StringComparison.OrdinalIgnoreCase) && A_m_1(item4, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIX() + Path.GetFileName(text), text))
						{
							num2++;
						}
					}
				}
			}
			A_2.D = num2;
			global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIx() + num2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIJ());
			b_m_1();
		}

		private void d()
		{
			global::B.p.A_m_1(new string('=', 46));
			global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIY() + A_1.A_5 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIy());
			List<string> list = B_m_1().Where(global::a.q.A_m_1).ToList();
			if (list.Count < 2)
			{
				global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIZ());
				return;
			}
			if (list.Count > 4000)
			{
				global::B.p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIz() + list.Count + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aiA());
			}
			List<List<string>> list2 = global::a.q.A_m_1(list, A_1.A_5, (int P_0, int P_1) =>
			{
				A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.air(), P_0, P_1, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
			});
			// C-15：图片组保留规则取自独立设置，缺省回退“体积最大”，判定仍统一走 A_m_1。
			string textImageKeep = (string.IsNullOrEmpty(A_1.h_2) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aia() : A_1.h_2);
			int num = 0;
			foreach (List<string> item in list2)
			{
				if (A_3.IsCancellationRequested)
				{
					return;
				}
				string text = A_m_1(item, textImageKeep);
				foreach (string item2 in item)
				{
					if (A_1.A_8 != null)
					{
						if (A_1.A_8.TryGetValue(b_m_1(item2), out var value) && !string.Equals(item2, value, StringComparison.OrdinalIgnoreCase) && A_m_1(item2, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aiB() + Path.GetFileName(value), value))
						{
							num++;
						}
					}
					else if (!string.Equals(item2, text, StringComparison.OrdinalIgnoreCase) && A_m_1(item2, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aib() + Path.GetFileName(text), text))
					{
						num++;
					}
				}
			}
			A_2.d = num;
			global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aiC() + num + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aic());
			b_m_1();
		}

		private void E()
		{
			global::B.p.A_m_1(new string('=', 46));
			global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aiD() + A_1.a_2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aid());
			List<string> list = B_m_1().Where(global::A.S.A_m_1).ToList();
			if (list.Count < 2)
			{
				global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aiE());
				return;
			}
			List<List<string>> list2 = global::A.S.A_m_1(list, A_1.a_2, (int P_0, int P_1) =>
			{
				A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aiS(), P_0, P_1, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
			});
			int num = 0;
			foreach (List<string> item in list2)
			{
				if (A_3.IsCancellationRequested)
				{
					return;
				}
				string text = A_m_1(item, A_1.D_1);
				foreach (string item2 in item)
				{
					if (A_1.A_8 != null)
					{
						if (A_1.A_8.TryGetValue(b_m_1(item2), out var value) && !string.Equals(item2, value, StringComparison.OrdinalIgnoreCase) && A_m_1(item2, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aie() + Path.GetFileName(value), value))
						{
							num++;
						}
					}
					else if (!string.Equals(item2, text, StringComparison.OrdinalIgnoreCase) && A_m_1(item2, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aiF() + Path.GetFileName(text), text))
					{
						num++;
					}
				}
			}
			A_2.F = num;
			global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aif() + num + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIJ());
			b_m_1();
		}

		public static string b_m_1(string P_0)
		{
			try
			{
				return Path.GetFullPath(P_0).TrimEnd('\\').ToLowerInvariant();
			}
			catch
			{
				return (P_0 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).TrimEnd('\\').ToLowerInvariant();
			}
		}

		public static string A_m_1(List<string> P_0, string P_1)
		{
			if (!(P_1 == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.hf()))
			{
				if (!(P_1 == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.hG()))
				{
					if (!(P_1 == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aia()))
					{
						if (P_1 == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.hg())
						{
							return P_0.OrderBy((string path) => Path.GetFileName(path).Length).ThenBy((string text) => text.Length).First();
						}
						return P_0.OrderBy((string text) => text.Length).First();
					}
					return P_0.OrderByDescending(c).ThenBy((string text) => text.Length).First();
				}
				return P_0.OrderBy(C_m_1).ThenBy((string text) => text.Length).First();
			}
			return P_0.OrderByDescending(C_m_1).ThenBy((string text) => text.Length).First();
		}

		private static DateTime C_m_1(string P_0)
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

		private static long c(string P_0)
		{
			try
			{
				return new FileInfo(global::a.a.A(P_0)).Length;
			}
			catch
			{
				return -1L;
			}
		}

		private void e_m_1()
		{
			global::B.p.A_m_1(new string('=', 46));
			global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aiG() + A_1.c + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ln());
			if (string.IsNullOrWhiteSpace(A_1.a))
			{
				global::B.p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aig());
				return;
			}
			Directory.CreateDirectory(global::a.a.A(A_1.a));
			List<string> list = B_m_1();
			int num = 0;
			Dictionary<string, int> dictionary = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
			string text = A_1.c;
			if (!(text == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.hF()))
			{
				if (!(text == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.hB()))
				{
					if (!(text == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.hC()))
					{
						if (!(text == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.hD()))
						{
							if (!(text == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.he()))
							{
								global::B.p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aiK() + A_1.c + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aik());
								return;
							}
							string text2 = (A_1.b ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).Trim();
							if (text2.Length == 0)
							{
								global::B.p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aii());
								return;
							}
							Regex regex;
							try
							{
								regex = new Regex(text2, RegexOptions.IgnoreCase);
							}
							catch (Exception ex)
							{
								global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahV(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aiJ(), A_1.b, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aij() + ex.Message, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf());
								return;
							}
							foreach (string item in list)
							{
								if (A_3.IsCancellationRequested)
								{
									return;
								}
								A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aiH(), ++num, list.Count, Path.GetFileName(item));
								if (regex.IsMatch(Path.GetFileName(item)))
								{
									b_m_1(item, A_1.a);
								}
								else
								{
									A_2.c++;
								}
							}
						}
						else
						{
							string[] array = A_m_1(A_1.b);
							if (array.Length == 0)
							{
								global::B.p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aiI());
								return;
							}
							foreach (string item2 in list)
							{
								if (A_3.IsCancellationRequested)
								{
									return;
								}
								A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aiH(), ++num, list.Count, Path.GetFileName(item2));
								string A = Path.GetFileName(item2);
								if (array.Any((string P_0) => A.IndexOf(P_0, StringComparison.OrdinalIgnoreCase) >= 0))
								{
									b_m_1(item2, A_1.a);
								}
								else
								{
									A_2.c++;
								}
							}
						}
					}
					else
					{
						string text3 = A_1.B;
						if (string.IsNullOrWhiteSpace(text3))
						{
							text3 = Path.Combine(A_1.a, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aih());
						}
						Directory.CreateDirectory(global::a.a.A(text3));
						foreach (string item3 in list)
						{
							if (A_3.IsCancellationRequested)
							{
								return;
							}
							A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aiH(), ++num, list.Count, Path.GetFileName(item3));
							b_m_1(item3, text3);
						}
					}
				}
				else
				{
					foreach (string item4 in list)
					{
						if (A_3.IsCancellationRequested)
						{
							return;
						}
						A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aiH(), ++num, list.Count, Path.GetFileName(item4));
						string text4 = global::A.t.B(item4);
						A_m_1(dictionary, text4);
						b_m_1(item4, Path.Combine(A_1.a, text4));
					}
				}
			}
			else
			{
				foreach (string item5 in list)
				{
					if (A_3.IsCancellationRequested)
					{
						return;
					}
					A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aiH(), ++num, list.Count, Path.GetFileName(item5));
					string text5 = global::A.t.a_m_1(item5);
					A_m_1(dictionary, text5);
					b_m_1(item5, Path.Combine(A_1.a, text5));
				}
			}
			if (dictionary.Count > 0 && !A_3.IsCancellationRequested)
			{
				StringBuilder stringBuilder = new StringBuilder();
				foreach (KeyValuePair<string, int> item6 in dictionary.OrderByDescending((KeyValuePair<string, int> P_0) => P_0.Value))
				{
					if (stringBuilder.Length > 0)
					{
						stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bH());
					}
					stringBuilder.Append(item6.Key).Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aH()).Append(item6.Value);
				}
				global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aiL() + stringBuilder);
				if (dictionary.TryGetValue(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.dc(), out var value) && value > 0)
				{
					global::B.p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahH() + value + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ail());
				}
			}
			global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aiM() + list.Count + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aim() + A_2.B + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aiN() + A_2.c + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIJ());
			b_m_1();
			if (A_2.c > 0)
			{
				global::B.p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahH() + A_2.c + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ain());
			}
		}

		private static void A_m_1(Dictionary<string, int> P_0, string P_1)
		{
			if (P_1 == null)
			{
				P_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.dc();
			}
			P_0.TryGetValue(P_1, out var value);
			P_0[P_1] = value + 1;
		}

		private void b_m_1(string P_0, string P_1)
		{
			try
			{
				Directory.CreateDirectory(global::a.a.A(P_1));
			}
			catch (Exception ex)
			{
				global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahV(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahD(), P_1, ex.Message, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf());
				A_2.c++;
				return;
			}
			string fileName = Path.GetFileName(P_0);
			string text = global::B.R.g_m_1(fileName);
			bool flag = !string.Equals(text, fileName, StringComparison.Ordinal);
			string text2 = Path.Combine(P_1, text);
			string text3 = (flag ? (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHR() + fileName + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHr() + text) : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
			if (string.Equals(Path.GetFullPath(text2), Path.GetFullPath(P_0), StringComparison.OrdinalIgnoreCase))
			{
				A_2.c++;
				return;
			}
			if (File.Exists(global::a.a.A(text2)))
			{
				if (flag && !C_m_1(P_0, text2))
				{
					text2 = global::a.a.E(text2);
					text = Path.GetFileName(text2);
					text3 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHR() + fileName + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHr() + text;
				}
				else
				{
					switch (A_1.A_2)
					{
					case global::b.D.a:
						global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahV(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Id(), P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHv(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ip());
						A_2.c++;
						A_5.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGN(), P_0, text2, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aeY());
						return;
					case global::b.D.B:
						break;
					default:
						if (a_m_1(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aiO()))
						{
							A_2.a++;
						}
						else
						{
							A_2.c++;
						}
						return;
					}
					text2 = global::a.a.E(text2);
				}
			}
			if (A_1.c_1)
			{
				global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aio() + P_0 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.IS() + text2 + ((text3.Length > 0) ? (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.IF() + text3 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ln()) : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()));
				A_2.B++;
				A_5.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGN(), P_0, text2, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ik(), text3);
				return;
			}
			try
			{
				if (!B_m_1(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Id()))
				{
					A_2.c++;
					A_5.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGN(), P_0, text2, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahA());
					return;
				}
				global::a.a.a_m_1(P_0, text2);
				global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahf() + P_0 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.IS() + text2 + ((text3.Length > 0) ? (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.IF() + text3 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ln()) : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()));
				A_2.B++;
				A_5.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGN(), P_0, text2, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.IK(), text3);
			}
			catch (Exception ex2)
			{
				global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahV(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Id(), P_0, ex2.Message, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf());
				A_2.c++;
				A_5.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGN(), P_0, text2, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jD());
			}
		}

		private static bool C_m_1(string P_0, string P_1)
		{
			try
			{
				FileInfo fileInfo = new FileInfo(global::a.a.A(P_0));
				FileInfo fileInfo2 = new FileInfo(global::a.a.A(P_1));
				if (fileInfo.Length != fileInfo2.Length)
				{
					return false;
				}
				return string.Equals(global::a.k.a(P_0), global::a.k.a(P_1), StringComparison.OrdinalIgnoreCase);
			}
			catch
			{
				return false;
			}
		}

		private void F()
		{
			global::B.p.A_m_1(new string('=', 46));
			global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aiP());
			List<string> list = new List<string>();
			A_m_1(A_1.A, list);
			list.Sort((string P_0, string P_1) => P_1.Length.CompareTo(P_0.Length));
			int num = 0;
			foreach (string item in list)
			{
				if (A_3.IsCancellationRequested)
				{
					return;
				}
				if (string.Equals(item.TrimEnd('\\'), A_1.A.TrimEnd('\\'), StringComparison.OrdinalIgnoreCase) || (!string.IsNullOrWhiteSpace(A_1.a) && global::a.a.A(item, A_1.a, true)))
				{
					continue;
				}
				try
				{
					if (Directory.GetFileSystemEntries(global::a.a.A(item)).Length == 0)
					{
						if (A_1.c_1)
						{
							global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aip() + item);
							num++;
						}
						else
						{
							Directory.Delete(global::a.a.A(item));
							global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aiQ() + item);
							num++;
						}
					}
				}
				catch (Exception ex)
				{
					global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahV(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aiq(), item, ex.Message, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf());
				}
			}
			A_2.E_f_1 = num;
			global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aiR() + num + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIJ());
		}

		private static void A_m_1(string P_0, List<string> P_1)
		{
			Stack<string> stack = new Stack<string>();
			stack.Push(P_0);
			while (stack.Count > 0)
			{
				string text = stack.Pop();
				try
				{
					foreach (string item in Directory.EnumerateDirectories(global::a.a.A(text)))
					{
						string text2 = global::a.a.a_m_1(item);
						try
						{
							if ((File.GetAttributes(global::a.a.A(text2)) & FileAttributes.ReparsePoint) != 0)
							{
								continue;
							}
						}
						catch
						{
							continue;
						}
						P_1.Add(text2);
						stack.Push(text2);
					}
				}
				catch
				{
				}
			}
		}

		[CompilerGenerated]
		private void D(string P_0)
		{
			A_2.G++;
		}

		[CompilerGenerated]
		private void A_m_1(int P_0, int P_1)
		{
			A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.air(), P_0, P_1, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
		}

		[CompilerGenerated]
		private void a_m_1(int P_0, int P_1)
		{
			A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aiS(), P_0, P_1, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
		}
	}
}
