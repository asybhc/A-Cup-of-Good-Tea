using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B1262ED64_002DD0A6_002D499E_002D9510_002DF2240F018DBB_007D;
using Microsoft.Win32;
using b;

namespace A
{
	[CompilerGenerated]
	internal sealed class A<A_T_1, a, B>
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly A_T_1 A_f_1;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly a A_f_2;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly B A_f_3;

		public A_T_1 ok => A_f_1;

		public a id => A_f_2;

		public B status => A_f_3;

		[DebuggerHidden]
		public A(A_T_1 P_0, a P_1, B P_2)
		{
			A_f_1 = P_0;
			A_f_2 = P_1;
			A_f_3 = P_2;
		}

		[DebuggerHidden]
		public override bool Equals(object P_0)
		{
			A<A_T_1, a, B> a2 = P_0 as A<A_T_1, a, B>;
			if (this != a2)
			{
				if (a2 != null && EqualityComparer<A_T_1>.Default.Equals(A_f_1, a2.A_f_1) && EqualityComparer<a>.Default.Equals(A_f_2, a2.A_f_2))
				{
					return EqualityComparer<B>.Default.Equals(A_f_3, a2.A_f_3);
				}
				return false;
			}
			return true;
		}

		[DebuggerHidden]
		public override int GetHashCode()
		{
			return ((unchecked(1593389487 * -1521134295) + EqualityComparer<A_T_1>.Default.GetHashCode(A_f_1)) * -1521134295 + EqualityComparer<a>.Default.GetHashCode(A_f_2)) * -1521134295 + EqualityComparer<B>.Default.GetHashCode(A_f_3);
		}

		[DebuggerHidden]
		public override string ToString()
		{
			string format = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.A();
			object[] array = new object[3];
			A_T_1 val = A_f_1;
			array[0] = ((val != null) ? val.ToString() : null);
			a val2 = A_f_2;
			array[1] = ((val2 != null) ? val2.ToString() : null);
			B val3 = A_f_3;
			array[2] = ((val3 != null) ? val3.ToString() : null);
			return string.Format(null, format, array);
		}
	}
	[CompilerGenerated]
	internal sealed class a<A_T_1, a_T_1, B>
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly A_T_1 A;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly a_T_1 A_1;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly B A_2;

		public A_T_1 ok => A;

		public a_T_1 jobId => A_1;

		public B status => A_2;

		[DebuggerHidden]
		public a(A_T_1 P_0, a_T_1 P_1, B P_2)
		{
			A = P_0;
			A_1 = P_1;
			A_2 = P_2;
		}

		[DebuggerHidden]
		public override bool Equals(object P_0)
		{
			a<A_T_1, a_T_1, B> a2 = P_0 as a<A_T_1, a_T_1, B>;
			if (this != a2)
			{
				if (a2 != null && EqualityComparer<A_T_1>.Default.Equals(A, a2.A) && EqualityComparer<a_T_1>.Default.Equals(A_1, a2.A_1))
				{
					return EqualityComparer<B>.Default.Equals(A_2, a2.A_2);
				}
				return false;
			}
			return true;
		}

		[DebuggerHidden]
		public override int GetHashCode()
		{
			return ((unchecked(1093757508 * -1521134295) + EqualityComparer<A_T_1>.Default.GetHashCode(A)) * -1521134295 + EqualityComparer<a_T_1>.Default.GetHashCode(A_1)) * -1521134295 + EqualityComparer<B>.Default.GetHashCode(A_2);
		}

		[DebuggerHidden]
		public override string ToString()
		{
			string format = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.a();
			object[] array = new object[3];
			A_T_1 val = A;
			array[0] = ((val != null) ? val.ToString() : null);
			a_T_1 val2 = A_1;
			array[1] = ((val2 != null) ? val2.ToString() : null);
			B val3 = A_2;
			array[2] = ((val3 != null) ? val3.ToString() : null);
			return string.Format(null, format, array);
		}
	}
}
namespace a
{
	public enum A
	{
		A_f_1,
		a
	}
	public static class a
	{
		public static string A(string P_0)
		{
			if (string.IsNullOrEmpty(P_0))
			{
				return P_0;
			}
			if (P_0.StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JI(), StringComparison.Ordinal))
			{
				return P_0;
			}
			string text = P_0.Trim();
			if (text.Length == 0)
			{
				return P_0;
			}
			text = b(text);
			string fullPath;
			try
			{
				fullPath = Path.GetFullPath(text);
			}
			catch
			{
				return P_0;
			}
			if (fullPath.StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JI(), StringComparison.Ordinal))
			{
				return fullPath;
			}
			if (fullPath.StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ji(), StringComparison.Ordinal))
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JJ() + fullPath.Substring(2);
			}
			return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JI() + fullPath;
		}

		public static string a_m_1(string P_0)
		{
			if (string.IsNullOrEmpty(P_0))
			{
				return P_0;
			}
			if (P_0.StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JJ(), StringComparison.Ordinal))
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ji() + P_0.Substring(8);
			}
			if (P_0.StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JI(), StringComparison.Ordinal))
			{
				return P_0.Substring(4);
			}
			return P_0;
		}

		public static string B(string P_0)
		{
			if (string.IsNullOrEmpty(P_0))
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}
			string text = a_m_1(P_0);
			try
			{
				text = Path.GetFullPath(text);
			}
			catch
			{
			}
			return a_m_1(text).TrimEnd('\\', '/').ToLowerInvariant();
		}

		public static bool A(string P_0, string P_1)
		{
			return string.Equals(B(P_0), B(P_1), StringComparison.Ordinal);
		}

		private static string b(string P_0)
		{
			int num = P_0.Length;
			while (num > 1 && (P_0[num - 1] == ' ' || P_0[num - 1] == '.'))
			{
				num--;
			}
			return P_0.Substring(0, num);
		}

		[DllImport("kernel32.dll", CharSet = CharSet.Unicode, EntryPoint = "GetLongPathNameW", SetLastError = true)]
		private static extern uint A(string P_0, StringBuilder P_1, uint P_2);

		public static string C(string P_0)
		{
			string text = a_m_1(P_0);
			if (string.IsNullOrEmpty(text) || text.IndexOf('~') < 0)
			{
				return text;
			}
			string directoryName = Path.GetDirectoryName(text);
			string fileName = Path.GetFileName(text);
			if (!string.IsNullOrEmpty(directoryName) && Directory.Exists(A(directoryName)))
			{
				string text2 = c(directoryName);
				if (!string.IsNullOrEmpty(text2))
				{
					return Path.Combine(a_m_1(text2), fileName);
				}
			}
			string text3 = c(text);
			if (!string.IsNullOrEmpty(text3))
			{
				return a_m_1(text3);
			}
			return text;
		}

		private static string c(string P_0)
		{
			try
			{
				StringBuilder stringBuilder = new StringBuilder(32768);
				uint num = A(A(P_0), stringBuilder, (uint)stringBuilder.Capacity);
				if (num == 0 || num >= stringBuilder.Capacity)
				{
					return null;
				}
				return stringBuilder.ToString(0, (int)num);
			}
			catch
			{
				return null;
			}
		}

		public static bool A()
		{
			try
			{
				using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jj(), writable: false);
				object obj = registryKey?.GetValue(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JK());
				return obj is int && (int)obj != 0;
			}
			catch
			{
				return false;
			}
		}

		public static bool D(string P_0)
		{
			try
			{
				return (File.GetAttributes(A(P_0)) & FileAttributes.ReparsePoint) != 0;
			}
			catch
			{
				return false;
			}
		}

		public static void d(string P_0)
		{
			try
			{
				string path = A(P_0);
				FileAttributes attributes = File.GetAttributes(path);
				if ((attributes & FileAttributes.ReadOnly) != 0)
				{
					File.SetAttributes(path, attributes & ~FileAttributes.ReadOnly);
				}
			}
			catch (Exception ex)
			{
				global::B.p.a_m_1("清除只读属性失败：" + P_0 + "；" + ex.GetType().Name + "：" + ex.Message);
			}
		}

		public static bool A(string P_0, A P_1, out string P_2)
		{
			string text;
			return A(P_0, P_1, out P_2, out text);
		}

		public static bool A(string P_0, A P_1, out string P_2, out string P_3)
		{
			P_2 = null;
			P_3 = P_0;
			string path = A(P_0);
			try
			{
				// R9 / C-03：删除前统一复核。扫描期登记过快照的文件，若大小/哈希/修改时间已变化则拒绝删除，
				// 避免“扫描后文件被替换或追加写入，仍按旧结论删除”的 TOCTOU 数据丢失。
				string text2;
				if (!global::A.Z.C_m_1(P_0, out text2))
				{
					P_2 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIn() + text2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ln();
					global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ahV(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aIN(), P_0, P_2, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ip());
					return false;
				}
				FileAttributes attributes = File.GetAttributes(path);
				if ((attributes & FileAttributes.ReadOnly) != 0)
				{
					File.SetAttributes(path, attributes & ~FileAttributes.ReadOnly);
				}
				if (P_1 == global::a.A.A_f_1)
				{
					global::b.H h2 = global::b.h.a_m_1(P_0);
					P_3 = h2.a ?? P_0;
					if (h2.A)
					{
						global::A.Z.a_m_1(P_0);
						return true;
					}
					P_2 = h2.A_1 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jk();
					return false;
				}
				File.Delete(path);
				global::A.Z.a_m_1(P_0);
				return true;
			}
			catch (Exception ex)
			{
				P_2 = ex.Message;
				return false;
			}
		}

		public static void a_m_1(string P_0, string P_1)
		{
			string directoryName = Path.GetDirectoryName(P_1);
			if (!string.IsNullOrEmpty(directoryName))
			{
				Directory.CreateDirectory(A(directoryName));
			}
			File.Move(A(P_0), A(P_1));
		}

		public static string E(string P_0)
		{
			if (!File.Exists(A(P_0)))
			{
				return P_0;
			}
			string path = Path.GetDirectoryName(P_0) ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(P_0);
			string extension = Path.GetExtension(P_0);
			for (int num = 1; num < 9999; num++)
			{
				string text = Path.Combine(path, fileNameWithoutExtension + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JL() + num + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.R() + extension);
				if (!File.Exists(A(text)))
				{
					return text;
				}
			}
			return Path.Combine(path, fileNameWithoutExtension + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JL() + Guid.NewGuid().ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.cL()).Substring(0, 6) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.R() + extension);
		}

		/// <summary>
		/// 递归清理目录的“安全模式”：只删除空目录，绝不删除任何文件。
		/// R15 / C-17：原实现会递归 File.Delete 目录下全部文件，一旦上层传错路径即静默清空整棵目录（且不经回收站）。
		/// 现默认行为改为“清理空目录”，非空目录原样保留并写入诊断日志。
		/// </summary>
		public static void e(string P_0)
		{
			e(P_0, null);
		}

		/// <summary>
		/// 递归清理目录。
		/// 仅当 allowRoot 非空且 path 位于 allowRoot 子树内（或等于 allowRoot）时，才允许删除目录内文件（保持原有“清空”语义，
		/// 该语义只应作用于程序自建的临时/自检目录）；其余情况一律退化为“只删空目录”。
		/// R15 / C-17：新增 allowRoot 白名单与系统目录防护，防止误传用户目录导致不可逆数据丢失。
		/// </summary>
		public static void e(string P_0, string allowRoot)
		{
			string path = A(P_0);
			if (!Directory.Exists(path))
			{
				return;
			}
			if (IsProtectedDirectory(path))
			{
				global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D() + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.DG() + path);
				return;
			}
			bool flag = false;
			if (!string.IsNullOrEmpty(allowRoot))
			{
				string text = B(allowRoot);
				string text2 = B(path);
				if (text.Length > 0 && text2.Length > 0 && (string.Equals(text, text2, StringComparison.Ordinal) || A(path, allowRoot, false)))
				{
					flag = true;
				}
			}
			if (flag)
			{
				foreach (string item in Directory.EnumerateFiles(path))
				{
					try
					{
						File.Delete(item);
					}
					catch (Exception ex)
					{
						global::B.p.a_m_1("删除文件失败：" + item + "；" + ex.GetType().Name + "：" + ex.Message);
					}
				}
			}
			foreach (string item2 in Directory.EnumerateDirectories(path))
			{
				if (!D(item2))
				{
					e(a_m_1(item2), allowRoot);
				}
			}
			try
			{
				if (!flag && Directory.GetFileSystemEntries(path).Length != 0)
				{
					global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D() + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.DG() + path);
					return;
				}
				Directory.Delete(path, recursive: false);
			}
			catch (Exception ex)
			{
				global::B.p.a_m_1("删除目录失败：" + path + "；" + ex.GetType().Name + "：" + ex.Message);
			}
		}

		/// <summary>
		/// R15 / C-17：系统关键目录防护。这些路径即使出现在 allowRoot 白名单内也拒绝清空。
		/// </summary>
		private static bool IsProtectedDirectory(string P_0)
		{
			string text;
			try
			{
				text = Path.GetFullPath(a_m_1(P_0)).TrimEnd('\\', '/');
			}
			catch
			{
				return true;
			}
			if (text.Length <= 2)
			{
				return true;
			}
			string pathRoot = Path.GetPathRoot(text);
			if (!string.IsNullOrEmpty(pathRoot) && string.Equals(pathRoot.TrimEnd('\\', '/'), text, StringComparison.OrdinalIgnoreCase))
			{
				return true;
			}
			System.Environment.SpecialFolder[] array = new System.Environment.SpecialFolder[11]
			{
				Environment.SpecialFolder.Windows,
				Environment.SpecialFolder.System,
				Environment.SpecialFolder.SystemX86,
				Environment.SpecialFolder.ProgramFiles,
				Environment.SpecialFolder.ProgramFilesX86,
				Environment.SpecialFolder.CommonProgramFiles,
				Environment.SpecialFolder.CommonProgramFilesX86,
				Environment.SpecialFolder.UserProfile,
				Environment.SpecialFolder.Desktop,
				Environment.SpecialFolder.MyDocuments,
				Environment.SpecialFolder.ApplicationData
			};
			foreach (System.Environment.SpecialFolder specialFolder in array)
			{
				string text2;
				try
				{
					text2 = Environment.GetFolderPath(specialFolder).TrimEnd('\\', '/');
				}
				catch
				{
					continue;
				}
				if (text2.Length <= 2)
				{
					continue;
				}
				if (string.Equals(text, text2, StringComparison.OrdinalIgnoreCase))
				{
					return true;
				}
				if (text2.StartsWith(text + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jb(), StringComparison.OrdinalIgnoreCase))
				{
					return true;
				}
			}
			return false;
		}

		public static bool F(string P_0)
		{
			try
			{
				using (new FileStream(A(P_0), FileMode.Open, FileAccess.ReadWrite, FileShare.None))
				{
				}
				return false;
			}
			catch (IOException)
			{
				return true;
			}
			catch
			{
				return false;
			}
		}

		public static bool A(string P_0, string P_1, bool P_2)
		{
			string text = B(P_0);
			string text2 = B(P_1);
			if (text.Length == 0 || text2.Length == 0)
			{
				return false;
			}
			if (string.Equals(text, text2, StringComparison.OrdinalIgnoreCase))
			{
				return P_2;
			}
			return text.StartsWith(text2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jb(), StringComparison.OrdinalIgnoreCase);
		}
	}
}
