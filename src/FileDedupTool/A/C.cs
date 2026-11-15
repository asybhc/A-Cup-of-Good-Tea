using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B1262ED64_002DD0A6_002D499E_002D9510_002DF2240F018DBB_007D;

namespace A
{
	[CompilerGenerated]
	internal delegate c C<A, a, B, b, C_T_1, c>(A P_0, a P_1, B P_2, b P_3, ref C_T_1 P_4);
	public sealed class c
	{
		public int A;

		public string A_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		public string a = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		public string B = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		public string b = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.d();

		public bool IsHigh
		{
			get
			{
				if (b != null)
				{
					return b.StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.C());
				}
				return false;
			}
		}

		public bool IsMid
		{
			get
			{
				if (b != null)
				{
					return b.StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.c());
				}
				return false;
			}
		}
	}
}
namespace a
{
	public sealed class C
	{
		public string A;

		public long A_1;

		public DateTime A_2;

		public DateTime a;

		public bool A_3;
	}
	public sealed class c
	{
		public int A;

		public long A_1;

		public List<C> A_2 = new List<C>();

		public int a;

		// C-05：true 表示该组来自“只比对前 64KB”的快筛模式，成员内容尚未全量校验，
		// 删除前必须用全量 SHA-256 与组内保留文件复核。
		public bool b;

		public long Wasted => A_1 * Math.Max(0, A_2.Count - 1);
	}
}
