using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007B1262ED64_002DD0A6_002D499E_002D9510_002DF2240F018DBB_007D;

namespace A
{
	public static class R
	{
		private static Icon A;

		public static Icon App
		{
			get
			{
				if (A == null)
				{
					A = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.DP(), 0);
				}
				return A;
			}
		}

		public static Icon A_m_1()
		{
			int width = SystemInformation.SmallIconSize.Width;
			return A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Dp(), width);
		}

		private static Icon A_m_1(string P_0, int P_1)
		{
			try
			{
				using Stream stream = typeof(R).Assembly.GetManifestResourceStream(P_0);
				if (stream != null)
				{
					return (P_1 > 0) ? new Icon(stream, P_1, P_1) : new Icon(stream);
				}
			}
			catch
			{
			}
			return SystemIcons.Application;
		}
	}
	public static class r
	{
		public const string A = "一杯好茶";

		public const string a = "一杯好茶.文件整理";

		public const string B = "QQ：694484255（一杯好茶）";

		public const string b = "Contact author on QQ: 694484255";

		public const string C = "694484255";

		public static readonly string c = A_m_1();

		public static string TitleSuffix => _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.DR() + c + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Dr();

		public static string A_m_1(bool P_0)
		{
			if (!P_0)
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.DQ();
			}
			return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Dq();
		}

		private static string A_m_1()
		{
			try
			{
				Assembly assembly = typeof(r).Assembly;
				AssemblyInformationalVersionAttribute customAttribute = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>();
				if (customAttribute != null && !string.IsNullOrWhiteSpace(customAttribute.InformationalVersion))
				{
					return customAttribute.InformationalVersion.Split('+')[0].Trim();
				}
				Version version = assembly.GetName().Version;
				if (version != null)
				{
					return version.Major + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.DS() + version.Minor + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.DS() + version.Build;
				}
			}
			catch
			{
			}
			return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ds();
		}
	}
}
namespace a
{
	internal sealed class R
	{
		public string A;

		public string a;

		public string B;

		public bool A_1;
	}
	internal sealed class r
	{
		public bool A;

		public string A_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		public string a = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		public readonly List<R> A_2 = new List<R>();
	}
}
