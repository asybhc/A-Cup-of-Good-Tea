using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using _003CPrivateImplementationDetails_003E_007B1262ED64_002DD0A6_002D499E_002D9510_002DF2240F018DBB_007D;
using B;
using a;

namespace B
{
	public sealed class N
	{
		public int A;

		public string A_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		public string a = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		public uint A_2;

		public uint a_1;

		public bool A_3;

		/// <summary>
		/// C-02：进程启动时间（UTC Ticks）。仅凭 PID 结束进程存在 PID 复用误杀风险，
		/// 结束前需同时校验 PID + 启动时间。0 表示无法获取（此时不做强制结束）。
		/// </summary>
		public long A_4;

		/// <summary>
		/// C-02：枚举时是否拥有主窗口。拥有主窗口的进程更可能持有未保存数据，
		/// 静默模式下也不能跳过确认。
		/// </summary>
		public bool a_2;

		public string Display
		{
			get
			{
				string text = (string.IsNullOrEmpty(A_1) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCI() : A_1) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCi() + A + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ln();
				if (A_3)
				{
					text += _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCJ();
				}
				return text;
			}
		}
	}
	public enum n
	{
		A,
		a,
		B,
		b
	}
}
namespace b
{
	internal sealed class N
	{
		[CompilerGenerated]
		private string A;

		[CompilerGenerated]
		private long A_1;

		[CompilerGenerated]
		private bool A_2;

		[CompilerGenerated]
		private string a;

		public string Path
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

		public long Size
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

		public bool Ok
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

		public string Reason
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
	}
	internal static class n
	{
		[CompilerGenerated]
		private static class A
		{
			public static Comparison<l> A_f_1;
		}

		[Serializable]
		[CompilerGenerated]
		private sealed class a
		{
			public static readonly a A = new a();

			public static Comparison<m> A_1;

			internal int A_m_1(m P_0, m P_1)
			{
				if (P_0.Size != P_1.Size)
				{
					if (P_0.Size <= P_1.Size)
					{
						return 1;
					}
					return -1;
				}
				return string.Compare(P_0.Name, P_1.Name, StringComparison.OrdinalIgnoreCase);
			}
		}

		internal const int A_1 = 8;

		internal const int a_1 = 50000;

		internal const int B_1 = 20;

		internal static async Task<M> A_m_1(Func<string, CancellationToken, Task<global::a.s>> P_0, string P_1, int P_2, Action<int, int, string> P_3, CancellationToken P_4)
		{
			if (P_0 == null)
			{
				throw new ArgumentNullException(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anL());
			}
			if (P_2 < 1)
			{
				P_2 = 1;
			}
			M m2 = new M();
			Queue<l> queue = new Queue<l>();
			HashSet<string> hashSet = new HashSet<string>(StringComparer.Ordinal);
			queue.Enqueue(new l
			{
				Id = (string.IsNullOrWhiteSpace(P_1) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iZ() : P_1),
				Name = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Dw(),
				Path = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Dw(),
				DirPath = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(),
				IsFolder = true,
				Depth = 0
			});
			hashSet.Add(queue.Peek().Id);
			while (queue.Count > 0)
			{
				P_4.ThrowIfCancellationRequested();
				l l2 = queue.Dequeue();
				if (m2.FoldersScanned >= 50000)
				{
					m2.Errors.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anl() + 50000 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anM());
					break;
				}
				global::a.s s2;
				try
				{
					s2 = await P_0(l2.Id, P_4).ConfigureAwait(continueOnCapturedContext: false);
					if (s2 == null)
					{
						s2 = new global::a.s();
					}
				}
				catch (global::a.v v2)
				{
					if (v2.Kind == global::a.V.a)
					{
						throw;
					}
					m2.Errors.Add(l2.Path + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anm() + v2.Message + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ln());
					m2.FoldersScanned++;
					P_3?.Invoke(m2.FoldersScanned, m2.FilesFound, l2.Path);
					continue;
				}
				m2.FoldersScanned++;
				if (s2.Folders != null)
				{
					foreach (global::a.W folder in s2.Folders)
					{
						if (folder != null && !string.IsNullOrEmpty(folder.Id))
						{
							string text = (string.IsNullOrEmpty(folder.Name) ? folder.Id : folder.Name);
							string path = A_m_1(l2.Path, text);
							if (l2.Depth + 1 >= P_2)
							{
								m2.DepthLimited = true;
								m2.FolderLimitSkipped++;
							}
							else if (hashSet.Add(folder.Id))
							{
								queue.Enqueue(new l
								{
									Id = folder.Id,
									Name = text,
									Path = path,
									DirPath = l2.Path,
									IsFolder = true,
									Depth = l2.Depth + 1
								});
							}
						}
					}
				}
				if (s2.Files != null)
				{
					foreach (global::a.w file in s2.Files)
					{
						if (file != null && !string.IsNullOrEmpty(file.Name))
						{
							m2.Nodes.Add(new l
							{
								Id = file.Id,
								Name = file.Name,
								Path = A_m_1(l2.Path, file.Name),
								DirPath = l2.Path,
								Size = file.SizeBytes,
								Time = file.Time,
								IsFolder = false,
								Depth = l2.Depth + 1
							});
						}
					}
				}
				P_3?.Invoke(m2.FoldersScanned, m2.FilesFound, l2.Path);
			}
			return m2;
		}

		internal static string A_m_1(string P_0, string P_1)
		{
			if (string.IsNullOrEmpty(P_0))
			{
				return P_1 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}
			return P_0.TrimEnd('/') + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aA() + P_1;
		}

		internal static List<m> A_m_1(IEnumerable<l> P_0)
		{
			Dictionary<string, m> dictionary = new Dictionary<string, m>(StringComparer.Ordinal);
			if (P_0 != null)
			{
				foreach (l item in P_0)
				{
					if (item != null && !item.IsFolder && !string.IsNullOrEmpty(item.Name) && item.Size >= 0)
					{
						string key = item.Name.ToLowerInvariant() + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aHq() + item.Size;
						if (!dictionary.TryGetValue(key, out var value))
						{
							value = (dictionary[key] = new m
							{
								Name = item.Name,
								Size = item.Size
							});
						}
						value.Items.Add(item);
					}
				}
			}
			List<m> list = new List<m>();
			foreach (m value2 in dictionary.Values)
			{
				if (value2.Items.Count >= 2)
				{
					value2.Items.Sort(A_m_1);
					value2.KeepIndex = A_m_1(value2.Items);
					list.Add(value2);
				}
			}
			list.Sort((m m3, m m4) => (m3.Size != m4.Size) ? ((m3.Size <= m4.Size) ? 1 : (-1)) : string.Compare(m3.Name, m4.Name, StringComparison.OrdinalIgnoreCase));
			return list;
		}

		private static int A_m_1(l P_0, l P_1)
		{
			return string.Compare(P_0.Path, P_1.Path, StringComparison.OrdinalIgnoreCase);
		}

		internal static int A_m_1(IList<l> P_0)
		{
			if (P_0 == null || P_0.Count == 0)
			{
				return -1;
			}
			int num = 0;
			for (int num2 = 1; num2 < P_0.Count; num2++)
			{
				if (a_m_1(P_0[num2], P_0[num]))
				{
					num = num2;
				}
			}
			return num;
		}

		internal static bool a_m_1(l P_0, l P_1)
		{
			if (P_0.Depth != P_1.Depth)
			{
				return P_0.Depth < P_1.Depth;
			}
			int num = ((P_0.Path != null) ? P_0.Path.Length : 0);
			int num2 = ((P_1.Path != null) ? P_1.Path.Length : 0);
			if (num != num2)
			{
				return num < num2;
			}
			int num3 = string.Compare(P_0.Path, P_1.Path, StringComparison.OrdinalIgnoreCase);
			if (num3 != 0)
			{
				return num3 < 0;
			}
			return string.Compare(P_0.Path, P_1.Path, StringComparison.Ordinal) < 0;
		}

		internal static List<l> A_m_1(IEnumerable<m> P_0)
		{
			List<l> list = new List<l>();
			if (P_0 == null)
			{
				return list;
			}
			foreach (m item in P_0)
			{
				for (int num = 0; num < item.Items.Count; num++)
				{
					if (num != item.KeepIndex)
					{
						list.Add(item.Items[num]);
					}
				}
			}
			return list;
		}

		internal static List<List<A>> A_m_1<A>(IList<A> P_0, int P_1)
		{
			List<List<A>> list = new List<List<A>>();
			if (P_0 == null)
			{
				return list;
			}
			if (P_1 <= 0)
			{
				P_1 = 20;
			}
			for (int num = 0; num < P_0.Count; num += P_1)
			{
				List<A> list2 = new List<A>();
				int num2 = Math.Min(P_0.Count, num + P_1);
				for (int num3 = num; num3 < num2; num3++)
				{
					list2.Add(P_0[num3]);
				}
				list.Add(list2);
			}
			return list;
		}

		internal static string A_m_1(IList<N> P_0, string P_1, DateTime P_2)
		{
			try
			{
				Directory.CreateDirectory(P_1);
				string text = Path.Combine(P_1, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajw() + P_2.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGJ()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kF());
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajX());
				if (P_0 != null)
				{
					foreach (N item in P_0)
					{
						stringBuilder.Append(A_m_1(item.Path)).Append(',').Append(item.Size)
							.Append(',')
							.Append(item.Ok ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CG() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf())
							.Append(',')
							.Append(A_m_1(item.Reason))
							.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kk());
					}
				}
				File.WriteAllText(text, stringBuilder.ToString(), new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
				return text;
			}
			catch (Exception ex)
			{
				global::B.p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajx() + ex.Message);
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}
		}

		private static string A_m_1(string P_0)
		{
			P_0 = P_0 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			if (P_0.IndexOfAny(new char[4] { ',', '"', '\r', '\n' }) < 0)
			{
				return P_0;
			}
			return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JX() + P_0.Replace(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JX(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lk()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JX();
		}
	}
}
