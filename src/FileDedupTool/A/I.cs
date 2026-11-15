using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace A
{
	public sealed class I
	{
		[CompilerGenerated]
		private string A;

		[CompilerGenerated]
		private long A_1;

		[CompilerGenerated]
		private string a;

		[CompilerGenerated]
		private bool A_2;

		[CompilerGenerated]
		private string B;

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

		public string Modified
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

		public bool IsKeep
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

		public string Sha256
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
	public sealed class i
	{
		[CompilerGenerated]
		private string A;

		[CompilerGenerated]
		private string a;

		[CompilerGenerated]
		private string B;

		[CompilerGenerated]
		private string b;

		[CompilerGenerated]
		private int A_1;

		[CompilerGenerated]
		private long A_2;

		[CompilerGenerated]
		private long a_1;

		[CompilerGenerated]
		private List<I> A_3 = new List<I>();

		public string Kind
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

		public string KindText
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

		public string Key
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

		public string Keep
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

		public int Count
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

		public long TotalSize
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

		public long ReclaimableBytes
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

		public List<I> Items
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
	}
}
namespace a
{
	internal readonly struct I
	{
		internal readonly bool A;

		internal readonly long A_1;

		internal readonly int A_2;

		internal I(bool P_0, long P_1, int P_2)
		{
			A = P_0;
			A_1 = (P_0 ? P_1 : 0);
			A_2 = P_2;
		}

		internal static I A_m_1(int P_0)
		{
			return new I(false, 0L, P_0);
		}

		internal bool A_m_1()
		{
			if (A && A_1 != 0L)
			{
				return i.a_m_1(A_2, A_1);
			}
			return false;
		}

		internal int a(int P_0)
		{
			if (!A_m_1())
			{
				return 1;
			}
			int num = (int)((A_1 >> 33) & 7);
			int num2 = P_0 + num;
			if (num2 > 0)
			{
				return num2;
			}
			return 1;
		}
	}
	internal static class i
	{
		private const long A = -7046029254386353131L;

		private const int A_1 = 13;

		private const int a = 81;

		internal static long A_m_1(int P_0, long P_1)
		{
			if (P_1 == 0L)
			{
				return 0L;
			}
			long num = P_1 ^ (P_0 * -7046029254386353131L);
			long num2 = ((num ^ (num >> 13)) * -7046029254386353131L) ^ ((long)P_0 << 7);
			long num3 = (num2 ^ (num2 >>> 29)) * -4658895280553007687L;
			long num4 = num3 ^ (num3 >>> 32);
			if (num4 != 0L)
			{
				return num4;
			}
			return 1L;
		}

		internal static bool a_m_1(int P_0, long P_1)
		{
			if (P_1 == 0L)
			{
				return false;
			}
			if (!j.A_m_1(out var num))
			{
				return false;
			}
			return A_m_1(P_0, num) == P_1;
		}

		internal static int A_m_1(string P_0)
		{
			uint num = 2166136261u;
			if (P_0 != null)
			{
				for (int num2 = 0; num2 < P_0.Length; num2++)
				{
					num ^= P_0[num2];
					num *= 16777619;
				}
			}
			return (int)(num & 0x7FFFFFFF);
		}

		internal static long A_m_1(long P_0)
		{
			if (P_0 != 0L)
			{
				return A_m_1(81, P_0);
			}
			return 0L;
		}
	}
}
