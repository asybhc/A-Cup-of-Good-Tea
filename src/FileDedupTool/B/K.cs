using System;
using System.Collections.Generic;
using System.IO;
using _003CPrivateImplementationDetails_003E_007B1262ED64_002DD0A6_002D499E_002D9510_002DF2240F018DBB_007D;
using a;

namespace B
{
	public enum K
	{
		A,
		a,
		B,
		b,
		C,
		c,
		D,
		d
	}
	public sealed class k
	{
		public K A = K.a;

		public string A_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		public j A_2;

		public string a = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		public bool Ok => A == K.A;

		public DateTime Expiry
		{
			get
			{
				if (A_2 != null)
				{
					return A_2.Expiry;
				}
				return DateTime.MinValue;
			}
		}

		public bool IsForever
		{
			get
			{
				if (A_2 != null)
				{
					return A_2.IsForever;
				}
				return false;
			}
		}

		public int A_m_1(DateTime P_0)
		{
			if (A_2 == null || A_2.IsForever)
			{
				return int.MaxValue;
			}
			return (int)Math.Ceiling((A_2.Expiry - P_0.Date).TotalDays);
		}
	}
}
namespace b
{
	public sealed class K
	{
		public int A;

		public int a;

		public int B;

		public int b;

		public int C;

		public readonly List<j> A_1 = new List<j>();
	}
	public static class k
	{
		public const int A = 15;

		public static int A_m_1(I P_0, IList<i> P_1)
		{
			if (P_0 == null || P_1 == null)
			{
				return -1;
			}
			string text = global::a.a.B(global::a.a.C(P_0.a ?? P_0.A));
			string fileName = Path.GetFileName(global::a.a.a_m_1(P_0.a ?? P_0.A));
			if (text.Length == 0 || fileName.Length == 0)
			{
				return -1;
			}
			int num = -1;
			TimeSpan timeSpan = TimeSpan.MaxValue;
			bool flag = false;
			for (int num2 = 0; num2 < P_1.Count; num2++)
			{
				i i2 = P_1[num2];
				if (i2 == null || string.IsNullOrEmpty(i2.A) || string.IsNullOrEmpty(i2.a) || !string.Equals(i2.a, fileName, StringComparison.OrdinalIgnoreCase) || !string.Equals(global::a.a.B(global::a.a.C(Path.Combine(i2.A, i2.a))), text, StringComparison.Ordinal))
				{
					continue;
				}
				if (!P_0.A_1.HasValue || !i2.A_1.HasValue)
				{
					if (num < 0)
					{
						num = num2;
					}
					continue;
				}
				TimeSpan timeSpan2 = P_0.A_1.Value - i2.A_1.Value;
				if (timeSpan2 < TimeSpan.Zero)
				{
					timeSpan2 = -timeSpan2;
				}
				TimeSpan timeSpan3 = TimeZoneInfo.Local.BaseUtcOffset;
				if (timeSpan3 < TimeSpan.Zero)
				{
					timeSpan3 = -timeSpan3;
				}
				TimeSpan timeSpan4 = timeSpan2 - timeSpan3;
				if (timeSpan4 < TimeSpan.Zero)
				{
					timeSpan4 = -timeSpan4;
				}
				if (timeSpan2 > TimeSpan.FromMinutes(15.0) && timeSpan4 < timeSpan2)
				{
					timeSpan2 = timeSpan4;
				}
				if (timeSpan2 < timeSpan)
				{
					timeSpan = timeSpan2;
					num = num2;
					flag = true;
				}
			}
			if (((num >= 0) & flag) && P_0.A_1.HasValue && timeSpan > TimeSpan.FromMinutes(15.0))
			{
				return -1;
			}
			return num;
		}
	}
}
