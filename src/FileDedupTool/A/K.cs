using System;
using System.Buffers;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B1262ED64_002DD0A6_002D499E_002D9510_002DF2240F018DBB_007D;

namespace A
{
	public sealed class K
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
		private int a_1;

		[CompilerGenerated]
		private string b;

		[CompilerGenerated]
		private string C;

		[CompilerGenerated]
		private string c;

		[CompilerGenerated]
		private string D;

		[CompilerGenerated]
		private string d;

		[CompilerGenerated]
		private bool A_2;

		[CompilerGenerated]
		private bool a_2;

		[CompilerGenerated]
		private string E;

		[CompilerGenerated]
		private J A_3;

		[CompilerGenerated]
		private j A_4;

		public string Id
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

		public string Status
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

		public string Stage
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

		public int Done
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

		public int Total
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

		public string CurrentFile
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

		public string Error
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

		public string CreatedAt
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

		public string StartedAt
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

		public string FinishedAt
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

		public bool Applied
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

		public bool DryRun
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

		public string OpsLogPath
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

		public J Result
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

		public j Stats
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
	public sealed class k
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
		private bool B;

		[CompilerGenerated]
		private int A_2;

		[CompilerGenerated]
		private string B_1;

		[CompilerGenerated]
		private string b;

		public bool Active
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

		public bool Pro
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

		public string Edition
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

		public string Expiry
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

		public bool IsForever
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

		public int DaysLeft
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

		public string MachineCode
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

		public string Status
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
	}
}
namespace a
{
	public static class K
	{
		[DllImport("kernel32.dll", CharSet = CharSet.Unicode, EntryPoint = "CreateHardLink", SetLastError = true)]
		private static extern bool A(string P_0, string P_1, nint P_2);

		[DllImport("kernel32.dll", EntryPoint = "GetLogicalDriveStringsW", SetLastError = true)]
		private static extern uint A(uint P_0, char[] P_1);

		[DllImport("kernel32.dll", CharSet = CharSet.Unicode, EntryPoint = "GetVolumeInformationW", SetLastError = true)]
		private static extern uint A(string P_0, char[] P_1, uint P_2, out uint P_3, out uint P_4, out uint P_5, char[] P_6, uint P_7);

		public static bool A(string P_0, string P_1)
		{
			try
			{
				uint num = A(Path.GetPathRoot(Path.GetFullPath(P_0)));
				uint num2 = A(Path.GetPathRoot(Path.GetFullPath(P_1)));
				return num != 0 && num == num2;
			}
			catch
			{
				return false;
			}
		}

		private static uint A(string P_0)
		{
			if (string.IsNullOrEmpty(P_0))
			{
				return 0u;
			}
			char[] array = new char[261];
			char[] array2 = new char[261];
			if (A(P_0, array, 261u, out var result, out var _, out var _, array2, 261u) == 0)
			{
				return 0u;
			}
			return result;
		}

		public static bool A(string P_0, string P_1, out string P_2)
		{
			P_2 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			try
			{
				if (string.Equals(Path.GetFullPath(P_0), Path.GetFullPath(P_1), StringComparison.OrdinalIgnoreCase))
				{
					P_2 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lj();
					return false;
				}
				if (!A(P_0, P_1))
				{
					P_2 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lK();
					return false;
				}
				if (!File.Exists(global::a.a.A(P_1)))
				{
					P_2 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lk() + P_1;
					return false;
				}
				if (!File.Exists(global::a.a.A(P_0)))
				{
					P_2 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lL() + P_0;
					return false;
				}
			}
			catch (Exception ex)
			{
				P_2 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ll() + ex.Message;
				return false;
			}
			string text = Path.Combine(Path.GetDirectoryName(Path.GetFullPath(P_0)) ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.DS(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lM() + Guid.NewGuid().ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.cL()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lm());
			// R16 / R17 / R18：调整硬链接替换顺序为“先改名备份 → 再建链接 → 最后删备份”。
			// 原顺序（建链接 → 删原文件 → 移动链接）在最后一步失败时会删掉唯一链接，导致数据不可恢复。
			if (!A_m_1(P_0, text, out string text2))
			{
				P_2 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lo() + text2;
				return false;
			}
			if (!A(global::a.a.A(P_0), global::a.a.A(P_1), IntPtr.Zero))
			{
				int lastWin32Error = Marshal.GetLastWin32Error();
				// 建链接失败：把备份改回原名，保持文件系统原状。
				if (!A_m_1(text, P_0, out string text3))
				{
					P_2 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lN() + lastWin32Error + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajg() + global::a.a.a_m_1(text) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajg() + text3 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ln();
					return false;
				}
				P_2 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lN() + lastWin32Error + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ln();
				return false;
			}
			try
			{
				File.Delete(global::a.a.A(text));
			}
			catch
			{
				// R17：删备份失败只会残留一个额外硬链接，不再影响数据完整性；留待后续清理。
			}
			return true;
		}

		/// <summary>
		/// R16：带重试的移动/改名，缓解杀毒软件、索引服务短暂占用导致的移动失败。
		/// </summary>
		private static bool A_m_1(string P_0, string P_1, out string P_2)
		{
			P_2 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			for (int i = 0; i < 4; i++)
			{
				try
				{
					File.Move(global::a.a.A(P_0), global::a.a.A(P_1));
					return true;
				}
				catch (Exception ex)
				{
					P_2 = ex.Message;
					if (i < 3)
					{
						System.Threading.Thread.Sleep(120);
					}
				}
			}
			try
			{
				File.Copy(global::a.a.A(P_0), global::a.a.A(P_1), overwrite: true);
				File.Delete(global::a.a.A(P_0));
				return true;
			}
			catch (Exception ex2)
			{
				P_2 = ex2.Message;
				return false;
			}
		}

		private static void a(string P_0)
		{
			try
			{
				File.Delete(global::a.a.A(P_0));
			}
			catch
			{
			}
		}
	}
	public static class k
	{
		private static readonly Dictionary<string, string> A_1 = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

		private static readonly object A_2 = new object();

		internal static long A_3;

		// C-12：记录写入顺序，达到上限时按 FIFO 淘汰最旧的一部分，避免整体 Clear 造成的周期性重算。
		private static readonly Queue<string> A_4 = new Queue<string>();

		private static void A_m_1(string P_0, string P_1)
		{
			if (A_1.Count >= 20000)
			{
				int num = 0;
				while (num++ < 2000 && A_4.Count > 0)
				{
					A_1.Remove(A_4.Dequeue());
				}
			}
			if (!A_1.ContainsKey(P_0))
			{
				A_4.Enqueue(P_0);
			}
			A_1[P_0] = P_1;
		}

		internal static void A_m_1()
		{
			lock (A_2)
			{
				A_3 = 0L;
				A_4.Clear();
			}
		}

		// 19：分块大小。8 MB 是顺序读吞吐与取消延迟的折中；块边界即取消检查点。
		private const int A_5 = 8388608;

		/// <summary>
		/// 19：与 ComputeHash 结果逐字节一致的分块哈希。每读一块检查一次取消。
		/// </summary>
		private static string B_m_1(Stream P_0, HashAlgorithm P_1, CancellationToken P_2)
		{
			byte[] array = ArrayPool<byte>.Shared.Rent(A_5);
			try
			{
				int num;
				while ((num = P_0.Read(array, 0, A_5)) > 0)
				{
					P_2.ThrowIfCancellationRequested();
					P_1.TransformBlock(array, 0, num, null, 0);
				}
				P_1.TransformFinalBlock(Array.Empty<byte>(), 0, 0);
				return b_m_1(P_1.Hash);
			}
			finally
			{
				ArrayPool<byte>.Shared.Return(array);
			}
		}

		/// <summary>19：字节数组转小写十六进制，与原实现编码保持一致。</summary>
		private static string b_m_1(byte[] P_0)
		{
			StringBuilder stringBuilder = new StringBuilder(P_0.Length * 2);
			foreach (byte b2 in P_0)
			{
				stringBuilder.Append(b2.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lp()));
			}
			return stringBuilder.ToString();
		}

		public static string A_m_1(string P_0)
		{
			return A_m_1(P_0, CancellationToken.None);
		}

		/// <summary>19：带取消的 SHA-256（含缓存）。取消时抛 OperationCanceledException。</summary>
		public static string A_m_1(string P_0, CancellationToken P_1)
		{
			P_1.ThrowIfCancellationRequested();
			string text = B(P_0);
			if (text == null)
			{
				return b(P_0, P_1);
			}
			lock (A_2)
			{
				if (A_1.TryGetValue(text, out var value))
				{
					return value;
				}
			}
			P_1.ThrowIfCancellationRequested();
			string text2 = b(P_0, P_1);
			lock (A_2)
			{
				A_m_1(text, text2);
				return text2;
			}
		}

		public static string a(string P_0)
		{
			return a(P_0, CancellationToken.None);
		}

		/// <summary>19：带取消的 MD5（含缓存）。取消时抛 OperationCanceledException。</summary>
		public static string a(string P_0, CancellationToken P_1)
		{
			P_1.ThrowIfCancellationRequested();
			string text = B(P_0);
			if (text != null)
			{
				text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lP() + text;
			}
			if (text != null)
			{
				lock (A_2)
				{
					if (A_1.TryGetValue(text, out var value))
					{
						return value;
					}
				}
			}
			P_1.ThrowIfCancellationRequested();
			string text2 = C(P_0, P_1);
			if (text != null)
			{
				lock (A_2)
				{
					A_3++;
					A_m_1(text, text2);
				}
			}
			return text2;
		}

		private static string B(string P_0)
		{
			try
			{
				FileInfo fileInfo = new FileInfo(global::a.a.A(P_0));
				if (!fileInfo.Exists)
				{
					return null;
				}
				// 26：缓存键不再包含 CreationTimeUtc。复制/移动会改变创建时间，原键导致缓存长期不命中。
				// 仍保留 路径+长度+LastWriteTimeUtc 作为内容指纹，语义与修复前一致。
				return P_0 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lz() + fileInfo.Length + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lz() + fileInfo.LastWriteTimeUtc.Ticks;
			}
			catch
			{
				return null;
			}
		}

		public static string b(string P_0)
		{
			return b(P_0, CancellationToken.None);
		}

		/// <summary>19：可取消的 SHA-256 全文件哈希。</summary>
		public static string b(string P_0, CancellationToken P_1)
		{
			using FileStream inputStream = new FileStream(global::a.a.A(P_0), FileMode.Open, FileAccess.Read, FileShare.Read, 1048576);
			using SHA256 sHA = SHA256.Create();
			return B_m_1(inputStream, sHA, P_1);
		}

		public static string C(string P_0)
		{
			return C(P_0, CancellationToken.None);
		}

		/// <summary>19：可取消的 MD5 全文件哈希。</summary>
		public static string C(string P_0, CancellationToken P_1)
		{
			using FileStream inputStream = new FileStream(global::a.a.A(P_0), FileMode.Open, FileAccess.Read, FileShare.Read, 1048576);
			using MD5 mD = MD5.Create();
			return B_m_1(inputStream, mD, P_1);
		}

		public static long c(string P_0)
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

		public static IEnumerable<List<string>> A_m_1(List<string> P_0)
		{
			Dictionary<long, List<string>> dictionary = new Dictionary<long, List<string>>();
			foreach (string item in P_0)
			{
				long num = c(item);
				if (num >= 0)
				{
					if (!dictionary.TryGetValue(num, out var value))
					{
						value = (dictionary[num] = new List<string>());
					}
					value.Add(item);
				}
				else
				{
					// C-25 / R1：无法读取大小的文件不再静默丢弃，写入日志便于用户确认漏扫原因。
					try
					{
						global::B.p.a_m_1("跳过无法读取大小的文件：" + item);
					}
					catch
					{
					}
				}
			}
			foreach (KeyValuePair<long, List<string>> item2 in dictionary)
			{
				if (item2.Value.Count > 1)
				{
					yield return item2.Value;
				}
			}
		}
	}
}
