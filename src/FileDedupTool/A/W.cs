using System;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B1262ED64_002DD0A6_002D499E_002D9510_002DF2240F018DBB_007D;

namespace A
{
	internal sealed class W
	{
		[CompilerGenerated]
		private v A;

		[CompilerGenerated]
		private string A_1;

		[CompilerGenerated]
		private string a;

		[CompilerGenerated]
		private string B;

		[CompilerGenerated]
		private string b;

		[CompilerGenerated]
		private string C;

		[CompilerGenerated]
		private string c;

		[CompilerGenerated]
		private bool A_2;

		public v Id
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

		public string Key
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

		public string DisplayName
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

		public string CookieFileName
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

		public string LoginUrl
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

		public string CookieCheckUrl
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

		public string RequiredCookieHint
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

		public bool Experimental
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
	}
	internal static class w
	{
		internal static readonly W A = new W
		{
			Id = v.A,
			Key = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.io(),
			DisplayName = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iP(),
			CookieFileName = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ip(),
			LoginUrl = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iQ(),
			CookieCheckUrl = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iq(),
			RequiredCookieHint = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iR(),
			Experimental = false
		};

		internal static readonly W a = new W
		{
			Id = v.a,
			Key = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ir(),
			DisplayName = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iS(),
			CookieFileName = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.@is(),
			LoginUrl = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iT(),
			CookieCheckUrl = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.it(),
			RequiredCookieHint = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.iU(),
			Experimental = true
		};

		internal static readonly W[] A_1 = new W[2] { A, a };

		internal static W Default => A;

		internal static W A_m_1(string P_0)
		{
			if (!string.IsNullOrWhiteSpace(P_0))
			{
				W[] a_ = A_1;
				foreach (W w2 in a_)
				{
					if (string.Equals(w2.Key, P_0.Trim(), StringComparison.OrdinalIgnoreCase))
					{
						return w2;
					}
				}
			}
			return A;
		}
	}
}
namespace a
{
	internal sealed class W
	{
		[CompilerGenerated]
		private string A;

		[CompilerGenerated]
		private string a;

		[CompilerGenerated]
		private int A_1 = -1;

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

		public int ItemCount
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
	}
	internal sealed class w
	{
		[CompilerGenerated]
		private string A;

		[CompilerGenerated]
		private string a;

		[CompilerGenerated]
		private string B;

		[CompilerGenerated]
		private long A_1;

		[CompilerGenerated]
		private string b;

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

		public string SizeText
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

		public long SizeBytes
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

		public string Time
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
