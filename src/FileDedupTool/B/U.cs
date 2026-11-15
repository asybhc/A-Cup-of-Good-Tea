using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using _003CPrivateImplementationDetails_003E_007B1262ED64_002DD0A6_002D499E_002D9510_002DF2240F018DBB_007D;
using A;
using a;

namespace B
{
	public static class U
	{
		private sealed class A
		{
			[CompilerGenerated]
			private List<string> A_f_1 = new List<string>();

			public List<string> Items
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
		}

		private static readonly object A_1 = new object();

		private static List<string> A_2 = null;

		private static long A_3 = -1L;

		// 24：只读路径失败只记一条，写路径逐条记录。
		private static int A_4;

		private static int A_5;

		public static string FilePath => Path.Combine(global::A.Y.Dir, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGG());

		private static long A_m_1()
		{
			try
			{
				return File.Exists(FilePath) ? File.GetLastWriteTimeUtc(FilePath).Ticks : 0;
			}
			catch (Exception ex)
			{
				if (Interlocked.Exchange(ref A_4, 1) == 0)
				{
					global::B.p.a_m_1("读取排除列表时间戳失败：" + FilePath + "；" + ex.GetType().Name + "：" + ex.Message);
				}
				return 0L;
			}
		}

		public static List<string> a()
		{
			lock (A_1)
			{
				long num = A_m_1();
				if (A_2 != null && num == A_3)
				{
					return A_2;
				}
				A_2 = new List<string>();
				try
				{
					if (File.Exists(FilePath))
					{
						A a2 = JsonSerializer.Deserialize<A>(File.ReadAllText(FilePath));
						if (a2 != null && a2.Items != null)
						{
							foreach (string item in a2.Items)
							{
								if (!string.IsNullOrWhiteSpace(item) && !A_2.Contains(item.Trim(), StringComparer.OrdinalIgnoreCase))
								{
									A_2.Add(item.Trim());
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					if (Interlocked.Exchange(ref A_5, 1) == 0)
					{
						global::B.p.a_m_1("读取排除列表失败，按空列表处理：" + FilePath + "；" + ex.GetType().Name + "：" + ex.Message);
					}
				}
				A_3 = num;
				return A_2;
			}
		}

		public static bool A_m_1(string P_0)
		{
			if (string.IsNullOrEmpty(P_0))
			{
				return false;
			}
			string text = t.A_m_1(P_0);
			foreach (string item in a())
			{
				if (string.Equals(t.A_m_1(item), text, StringComparison.OrdinalIgnoreCase))
				{
					return true;
				}
			}
			return false;
		}

		public static bool a(string P_0)
		{
			string text = t.A_m_1(P_0);
			if (text.Length == 0)
			{
				return false;
			}
			lock (A_1)
			{
				List<string> list = a();
				foreach (string item in list)
				{
					if (string.Equals(t.A_m_1(item), text, StringComparison.OrdinalIgnoreCase))
					{
						return false;
					}
				}
				list.Add(text);
				A_m_1(list);
				return true;
			}
		}

		public static void B()
		{
			lock (A_1)
			{
				A_2 = new List<string>();
				A_3 = -1L;
				try
				{
					if (File.Exists(FilePath))
					{
						File.Delete(FilePath);
					}
				}
				catch (Exception ex)
				{
					global::B.p.a_m_1("删除排除列表文件失败：" + FilePath + "；" + ex.GetType().Name + "：" + ex.Message);
				}
			}
		}

		private static void A_m_1(List<string> P_0)
		{
			try
			{
				string contents = JsonSerializer.Serialize(new A
				{
					Items = P_0
				}, new JsonSerializerOptions
				{
					WriteIndented = true,
					Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
				});
				File.WriteAllText(FilePath, contents);
				A_2 = P_0;
				A_3 = A_m_1();
			}
			catch (Exception ex)
			{
				global::B.p.a_m_1("保存排除列表失败：" + FilePath + "；" + ex.GetType().Name + "：" + ex.Message);
			}
		}
	}
	public sealed class u
	{
		public string A;

		public long A_1;

		public s A_2;
	}
}
namespace b
{
	public static class U
	{
		[CompilerGenerated]
		private static class A
		{
			public static Func<char, bool> A_f_1;
		}

		private static readonly string[] A_1 = new string[5]
		{
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLK(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLk(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLL(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLl(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLM()
		};

		public static string A_m_1()
		{
			try
			{
				string environmentVariable = Environment.GetEnvironmentVariable(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLb());
				if (!string.IsNullOrWhiteSpace(environmentVariable))
				{
					return File.Exists(environmentVariable) ? environmentVariable : null;
				}
				string[] a_ = A_1;
				for (int num = 0; num < a_.Length; num++)
				{
					string text = Path.Combine(Environment.ExpandEnvironmentVariables(a_[num]), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLC());
					if (File.Exists(text))
					{
						return text;
					}
				}
				string environmentVariable2 = Environment.GetEnvironmentVariable(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLc());
				if (!string.IsNullOrEmpty(environmentVariable2))
				{
					a_ = environmentVariable2.Split(';');
					foreach (string text2 in a_)
					{
						if (!string.IsNullOrWhiteSpace(text2))
						{
							string text3 = Path.Combine(text2.Trim(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLC());
							if (File.Exists(text3))
							{
								return text3;
							}
						}
					}
				}
			}
			catch
			{
			}
			return null;
		}

		internal static string[] A_m_1(string P_0, int P_1)
		{
			return new string[11]
			{
				_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLD(),
				P_1.ToString(),
				_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLd(),
				_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLE(),
				_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLe(),
				_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLF(),
				_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLf(),
				_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CM(),
				_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLG(),
				_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CM(),
				P_0 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()
			};
		}

		public static T A_m_1(string P_0, int P_1, CancellationToken P_2)
		{
			T t2 = new T
			{
				A = s.B
			};
			string text = A_m_1();
			if (text == null)
			{
				t2.A_3 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLg();
				return t2;
			}
			try
			{
				ProcessStartInfo processStartInfo = new ProcessStartInfo(text)
				{
					UseShellExecute = false,
					CreateNoWindow = true,
					RedirectStandardOutput = true,
					RedirectStandardError = true,
					StandardOutputEncoding = Encoding.UTF8,
					StandardErrorEncoding = Encoding.UTF8
				};
				string[] array = A_m_1(P_0, P_1);
				foreach (string item in array)
				{
					processStartInfo.ArgumentList.Add(item);
				}
				using Process process = Process.Start(processStartInfo);
				if (process == null)
				{
					t2.A_3 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLH();
					return t2;
				}
				string text2 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
				Task<string> task = process.StandardOutput.ReadToEndAsync();
				Task<string> task2 = process.StandardError.ReadToEndAsync();
				int num2 = t.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLh(), 15000);
				long num3 = Environment.TickCount64 + num2;
				while (!process.HasExited)
				{
					if (P_2.IsCancellationRequested)
					{
						try
						{
							process.Kill();
						}
						catch
						{
						}
						t2.a = true;
						return t2;
					}
					if (Environment.TickCount64 > num3)
					{
						try
						{
							process.Kill();
						}
						catch
						{
						}
						t2.A_3 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLI();
						return t2;
					}
					Thread.Sleep(10);
				}
				try
				{
					text2 = task.Result;
				}
				catch
				{
				}
				process.WaitForExit(2000);
				if (process.ExitCode != 0)
				{
					string text3 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
					try
					{
						text3 = task2.Result;
					}
					catch
					{
					}
					t2.A_3 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLi() + process.ExitCode + (string.IsNullOrWhiteSpace(text3) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D() : (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ah() + text3.Trim()));
					return t2;
				}
				List<S> list = A_m_1(text2, P_1, out var a_);
				A_m_1(list);
				t2.A_1.AddRange(list);
				t2.A_2 = a_;
				t2.a_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLJ();
				return t2;
			}
			catch (Exception ex)
			{
				t2.A_3 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLj() + ex.Message;
				return t2;
			}
		}

		internal static List<S> A_m_1(string P_0, int P_1, out bool P_2)
		{
			P_2 = false;
			List<S> list = new List<S>();
			if (string.IsNullOrEmpty(P_0))
			{
				return list;
			}
			string[] array = P_0.Replace(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kk(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BD()).Replace('\r', '\n').Split('\n');
			foreach (string text in array)
			{
				if (text.Length != 0)
				{
					if (list.Count >= P_1)
					{
						P_2 = true;
						break;
					}
					S s2 = A_m_1(text);
					if (s2 != null)
					{
						list.Add(s2);
					}
				}
			}
			return list;
		}

		internal static S A_m_1(string P_0)
		{
			if (string.IsNullOrWhiteSpace(P_0))
			{
				return null;
			}
			string[] array = P_0.Split('\t');
			string text = null;
			long result = -1L;
			DateTime dateTime = DateTime.MinValue;
			string[] array2 = array;
			for (int num = 0; num < array2.Length; num++)
			{
				string text2 = array2[num].Trim();
				if (text2.Length != 0 && a(text2) && (text == null || text2.Length > text.Length))
				{
					text = text2;
				}
			}
			array2 = array;
			for (int num = 0; num < array2.Length; num++)
			{
				string text3 = array2[num].Trim();
				if (text == null || !(text3 == text))
				{
					DateTime result2;
					if (result < 0 && text3.Length > 0 && text3.All(char.IsDigit))
					{
						long.TryParse(text3, out result);
					}
					else if (dateTime == DateTime.MinValue && DateTime.TryParse(text3, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out result2))
					{
						dateTime = result2;
					}
				}
			}
			if (text == null)
			{
				return null;
			}
			string fileName;
			string directoryName;
			try
			{
				fileName = Path.GetFileName(text);
				directoryName = Path.GetDirectoryName(text);
			}
			catch
			{
				return null;
			}
			if (string.IsNullOrEmpty(fileName))
			{
				return null;
			}
			return new S
			{
				A = fileName,
				a = directoryName,
				B = text,
				A_1 = result,
				A_2 = dateTime
			};
		}

		private static bool a(string P_0)
		{
			if (P_0.Length < 3)
			{
				return false;
			}
			if (P_0.IndexOf('\\') < 0)
			{
				return P_0.IndexOf('/') >= 0;
			}
			return true;
		}

		private static void A_m_1(List<S> P_0)
		{
			foreach (S item in P_0)
			{
				if (item.A_1 >= 0 && item.A_2 != DateTime.MinValue)
				{
					continue;
				}
				try
				{
					FileInfo fileInfo = new FileInfo(global::a.a.A(item.B));
					if (fileInfo.Exists)
					{
						if (item.A_1 < 0)
						{
							item.A_1 = fileInfo.Length;
						}
						if (item.A_2 == DateTime.MinValue)
						{
							item.A_2 = fileInfo.LastWriteTime;
						}
					}
				}
				catch
				{
				}
			}
		}
	}
	public static class u
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class A
		{
			public static readonly A A_f_1 = new A();

			public static Comparison<S> A_f_2;

			internal int A_m_1(S P_0, S P_1)
			{
				int num = string.Compare(P_0.A, P_1.A, StringComparison.OrdinalIgnoreCase);
				if (num == 0)
				{
					return string.Compare(P_0.B, P_1.B, StringComparison.OrdinalIgnoreCase);
				}
				return num;
			}
		}

		public static T A_m_1(string P_0, string P_1, int P_2, CancellationToken P_3)
		{
			T t2 = new T
			{
				A = s.b
			};
			if (string.IsNullOrWhiteSpace(P_0) || !Directory.Exists(P_0))
			{
				t2.A_3 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLm();
				return t2;
			}
			List<S> list = new List<S>();
			bool flag = false;
			try
			{
				Stack<string> stack = new Stack<string>();
				stack.Push(P_0);
				int num = 0;
				while (stack.Count > 0)
				{
					P_3.ThrowIfCancellationRequested();
					string text = stack.Pop();
					FileInfo[] files;
					DirectoryInfo[] directories;
					try
					{
						DirectoryInfo directoryInfo = new DirectoryInfo(global::a.a.A(text));
						files = directoryInfo.GetFiles();
						directories = directoryInfo.GetDirectories();
					}
					catch
					{
						continue;
					}
					DirectoryInfo[] array = directories;
					foreach (DirectoryInfo directoryInfo2 in array)
					{
						try
						{
							if ((directoryInfo2.Attributes & FileAttributes.ReparsePoint) != 0)
							{
								continue;
							}
						}
						catch
						{
							continue;
						}
						stack.Push(global::a.a.a_m_1(directoryInfo2.FullName));
					}
					FileInfo[] array2 = files;
					foreach (FileInfo fileInfo in array2)
					{
						P_3.ThrowIfCancellationRequested();
						num++;
						if (num % 500 == 0)
						{
							P_3.ThrowIfCancellationRequested();
						}
						if (A_m_1(fileInfo.Name, P_1))
						{
							list.Add(new S
							{
								A = fileInfo.Name,
								a = global::a.a.a_m_1(fileInfo.DirectoryName),
								B = global::a.a.a_m_1(fileInfo.FullName),
								A_1 = A_m_1(fileInfo),
								A_2 = a(fileInfo)
							});
							if (list.Count > P_2)
							{
								flag = true;
								break;
							}
						}
					}
					if (flag)
					{
						break;
					}
				}
			}
			catch (OperationCanceledException)
			{
				t2.a = true;
				return t2;
			}
			catch (Exception ex2)
			{
				t2.A_3 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLN() + ex2.Message;
				return t2;
			}
			if (list.Count > P_2)
			{
				list.RemoveRange(P_2, list.Count - P_2);
				flag = true;
			}
			list.Sort((S s2, S s3) =>
			{
				int num3 = string.Compare(s2.A, s3.A, StringComparison.OrdinalIgnoreCase);
				return (num3 == 0) ? string.Compare(s2.B, s3.B, StringComparison.OrdinalIgnoreCase) : num3;
			});
			t2.A_1.AddRange(list);
			t2.A_2 = flag;
			t2.a_1 = global::a.Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.TS());
			return t2;
		}

		private static long A_m_1(FileInfo P_0)
		{
			try
			{
				return P_0.Length;
			}
			catch
			{
				return -1L;
			}
		}

		private static DateTime a(FileInfo P_0)
		{
			try
			{
				return P_0.LastWriteTime;
			}
			catch
			{
				return DateTime.MinValue;
			}
		}

		internal static bool A_m_1(string P_0, string P_1)
		{
			if (string.IsNullOrEmpty(P_1))
			{
				return true;
			}
			if (P_1.IndexOf('*') >= 0 || P_1.IndexOf('?') >= 0)
			{
				string pattern = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLn() + A_m_1(P_1) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLO();
				try
				{
					return Regex.IsMatch(P_0, pattern, RegexOptions.IgnoreCase);
				}
				catch
				{
					return false;
				}
			}
			return P_0.IndexOf(P_1, StringComparison.OrdinalIgnoreCase) >= 0;
		}

		private static string A_m_1(string P_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int num = 0; num < P_0.Length; num++)
			{
				char c2 = P_0[num];
				switch (c2)
				{
				case '*':
					stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLo());
					break;
				case '?':
					stringBuilder.Append('.');
					break;
				default:
					stringBuilder.Append(Regex.Escape(c2.ToString()));
					break;
				}
			}
			return stringBuilder.ToString();
		}
	}
}
