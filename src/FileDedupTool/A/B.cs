using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B1262ED64_002DD0A6_002D499E_002D9510_002DF2240F018DBB_007D;

namespace A
{
	[CompilerGenerated]
	internal sealed class B<A_T_1, a, B_T_1>
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly A_T_1 A;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly a A_1;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly B_T_1 A_2;

		public A_T_1 Ext => A;

		public a Count => A_1;

		public B_T_1 Bytes => A_2;

		[DebuggerHidden]
		public B(A_T_1 P_0, a P_1, B_T_1 P_2)
		{
			A = P_0;
			A_1 = P_1;
			A_2 = P_2;
		}

		[DebuggerHidden]
		public override bool Equals(object P_0)
		{
			B<A_T_1, a, B_T_1> b2 = P_0 as B<A_T_1, a, B_T_1>;
			if (this != b2)
			{
				if (b2 != null && EqualityComparer<A_T_1>.Default.Equals(A, b2.A) && EqualityComparer<a>.Default.Equals(A_1, b2.A_1))
				{
					return EqualityComparer<B_T_1>.Default.Equals(A_2, b2.A_2);
				}
				return false;
			}
			return true;
		}

		[DebuggerHidden]
		public override int GetHashCode()
		{
			return ((unchecked(-1360333707 * -1521134295) + EqualityComparer<A_T_1>.Default.GetHashCode(A)) * -1521134295 + EqualityComparer<a>.Default.GetHashCode(A_1)) * -1521134295 + EqualityComparer<B_T_1>.Default.GetHashCode(A_2);
		}

		[DebuggerHidden]
		public override string ToString()
		{
			string format = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.B();
			object[] array = new object[3];
			A_T_1 val = A;
			array[0] = ((val != null) ? val.ToString() : null);
			a val2 = A_1;
			array[1] = ((val2 != null) ? val2.ToString() : null);
			B_T_1 val3 = A_2;
			array[2] = ((val3 != null) ? val3.ToString() : null);
			return string.Format(null, format, array);
		}
	}
	[CompilerGenerated]
	internal sealed class b<A_T_1, a>
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly A_T_1 A;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly a A_1;

		public A_T_1 G => A;

		public a W => A_1;

		[DebuggerHidden]
		public b(A_T_1 P_0, a P_1)
		{
			A = P_0;
			A_1 = P_1;
		}

		[DebuggerHidden]
		public override bool Equals(object P_0)
		{
			b<A_T_1, a> b2 = P_0 as b<A_T_1, a>;
			if (this != b2)
			{
				if (b2 != null && EqualityComparer<A_T_1>.Default.Equals(A, b2.A))
				{
					return EqualityComparer<a>.Default.Equals(A_1, b2.A_1);
				}
				return false;
			}
			return true;
		}

		[DebuggerHidden]
		public override int GetHashCode()
		{
			return (unchecked(-1189821390 * -1521134295) + EqualityComparer<A_T_1>.Default.GetHashCode(A)) * -1521134295 + EqualityComparer<a>.Default.GetHashCode(A_1);
		}

		[DebuggerHidden]
		public override string ToString()
		{
			string format = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.b();
			object[] array = new object[2];
			A_T_1 val = A;
			array[0] = ((val != null) ? val.ToString() : null);
			a val2 = A_1;
			array[1] = ((val2 != null) ? val2.ToString() : null);
			return string.Format(null, format, array);
		}
	}
}
namespace a
{
	public static class B
	{
		public static readonly string[] A = new string[12]
		{
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JO(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jo(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JP(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jp(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JM(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jm(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JQ(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jq(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jn(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JN(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JR(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jr()
		};

		public static readonly string[] a = new string[3]
		{
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JS(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Js(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JT()
		};

		private static string[] B_f_1;

		private static string[] A_m_1()
		{
			if (B_f_1 != null)
			{
				return B_f_1;
			}
			List<string> list = new List<string>();
			try
			{
				DriveInfo[] drives = DriveInfo.GetDrives();
				foreach (DriveInfo driveInfo in drives)
				{
					if (driveInfo.DriveType == DriveType.Fixed)
					{
						global::a.a.B(driveInfo.RootDirectory.FullName);
						string[] array = A;
						foreach (string path in array)
						{
							list.Add(global::a.a.B(Path.Combine(driveInfo.RootDirectory.FullName, path)));
						}
					}
				}
			}
			catch
			{
			}
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
			if (!string.IsNullOrEmpty(folderPath))
			{
				list.Add(global::a.a.B(folderPath));
			}
			B_f_1 = list.Distinct().ToArray();
			return B_f_1;
		}

		public static IEnumerable<string> a_m_1()
		{
			List<string> list = new List<string>();
			try
			{
				list.Add(global::a.a.B(AppContext.BaseDirectory));
			}
			catch
			{
			}
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
			if (!string.IsNullOrEmpty(folderPath))
			{
				list.Add(global::a.a.B(Path.Combine(folderPath, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.DA())));
			}
			if (!string.IsNullOrEmpty(folderPath2))
			{
				list.Add(global::a.a.B(Path.Combine(folderPath2, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.DA())));
			}
			return list;
		}

		public static bool A_m_1(string P_0)
		{
			string text = Path.GetFileName(P_0) ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			if (text.StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jl(), StringComparison.OrdinalIgnoreCase))
			{
				return true;
			}
			string[] array = a;
			foreach (string text2 in array)
			{
				if (string.Equals(text, text2, StringComparison.OrdinalIgnoreCase))
				{
					return true;
				}
			}
			return false;
		}

		public static bool a_m_1(string P_0)
		{
			string text = global::a.a.B(P_0);
			if (text.Length == 0)
			{
				return true;
			}
			string[] array = A_m_1();
			foreach (string text2 in array)
			{
				if (text == text2 || text.StartsWith(text2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jb(), StringComparison.Ordinal))
				{
					return true;
				}
			}
			array = new string[4]
			{
				_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JM(),
				_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jm(),
				_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JN(),
				_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jn()
			};
			foreach (string text3 in array)
			{
				if (text.EndsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jb() + text3.ToLowerInvariant(), StringComparison.Ordinal))
				{
					return true;
				}
			}
			foreach (string item in a_m_1())
			{
				if (text == item || text.StartsWith(item + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jb(), StringComparison.Ordinal))
				{
					return true;
				}
			}
			return false;
		}
	}
	public sealed class b
	{
		public List<string> A = new List<string>();

		public bool A_1;

		public long A_2 = 1L;

		public bool a;

		public bool B = true;

		public long MinBytes
		{
			get
			{
				if (A_2 > 0)
				{
					return A_2 * 1024;
				}
				return 0L;
			}
		}
	}
}
