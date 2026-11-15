using System;

namespace C;

public sealed class A
{
	public DateTime A_f_1 = DateTime.MinValue;

	public DateTime a = DateTime.MinValue;

	public bool A_f_2;

	public bool a_1;

	public A A_m_1()
	{
		return new A
		{
			A_f_1 = A_f_1,
			a = a,
			A_f_2 = A_f_2,
			a_1 = a_1
		};
	}
}
public sealed class a
{
	public bool A;

	public bool a_f_1;

	public bool B;

	public bool b;

	public DateTime A_1;

	public DateTime a_f_2;

	public int A_2;

	public bool C;
}
