using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B1262ED64_002DD0A6_002D499E_002D9510_002DF2240F018DBB_007D;
using Microsoft.Win32;

namespace B
{
	public static class J
	{
		private static byte[] A;

		private static string A_1;

		public static byte[] Id
		{
			get
			{
				if (A == null)
				{
					A_m_1();
				}
				return A;
			}
		}

		public static string Trace
		{
			get
			{
				if (A == null)
				{
					A_m_1();
				}
				return A_1;
			}
		}

		public static string Code => i.A_m_1(Id);

		public static string Formatted => A_m_1(Code);

		public static string A_m_1(string P_0)
		{
			if (string.IsNullOrEmpty(P_0))
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}
			StringBuilder stringBuilder = new StringBuilder(P_0.Length + P_0.Length / 4);
			for (int num = 0; num < P_0.Length; num++)
			{
				if (num > 0 && num % 4 == 0)
				{
					stringBuilder.Append('-');
				}
				stringBuilder.Append(P_0[num]);
			}
			return stringBuilder.ToString();
		}

		private static void A_m_1()
		{
			string text = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBM(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBm());
			string text2 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBN(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBn()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lz() + A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBN(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBO());
			string text3 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBo(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBP()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lz() + A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBo(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBp());
			string text4 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			try
			{
				string pathRoot = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.Windows));
				if (!string.IsNullOrEmpty(pathRoot))
				{
					text4 = B(pathRoot).ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBQ());
				}
			}
			catch
			{
			}
			string text5 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			try
			{
				text5 = Environment.MachineName;
			}
			catch
			{
			}
			List<string> list = new List<string>();
			if (!string.IsNullOrWhiteSpace(text))
			{
				list.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBq() + a(text));
				list.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBR() + text4);
			}
			else
			{
				list.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBr() + a(text2));
				list.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBS() + a(text3));
				list.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBR() + text4);
				list.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBs() + a(text5));
			}
			string text6 = string.Join(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BD(), list.ToArray());
			byte[] src;
			using (SHA256 sHA = SHA256.Create())
			{
				src = sHA.ComputeHash(Encoding.UTF8.GetBytes(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBT() + text6));
			}
			byte[] dst = new byte[10];
			Buffer.BlockCopy(src, 0, dst, 0, 10);
			A_1 = text6.Replace(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BD(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.o());
			A = dst;
		}

		private static string a(string P_0)
		{
			if (string.IsNullOrEmpty(P_0))
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}
			StringBuilder stringBuilder = new StringBuilder(P_0.Length);
			string text = P_0.Trim().ToLowerInvariant();
			foreach (char value in text)
			{
				if (!char.IsWhiteSpace(value))
				{
					stringBuilder.Append(value);
				}
			}
			return stringBuilder.ToString();
		}

		private static string A_m_1(string P_0, string P_1)
		{
			try
			{
				using RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
				using RegistryKey registryKey2 = registryKey.OpenSubKey(P_0, writable: false);
				if (registryKey2 == null)
				{
					return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
				}
				object value = registryKey2.GetValue(P_1);
				return (value == null) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D() : value.ToString();
			}
			catch
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}
		}

		[DllImport("kernel32.dll", CharSet = CharSet.Unicode, EntryPoint = "GetVolumeInformation", SetLastError = true)]
		private static extern bool A_m_1(string P_0, StringBuilder P_1, int P_2, out uint P_3, out uint P_4, out uint P_5, StringBuilder P_6, int P_7);

		private static uint B(string P_0)
		{
			try
			{
				StringBuilder stringBuilder = new StringBuilder(260);
				StringBuilder stringBuilder2 = new StringBuilder(260);
				if (A_m_1(P_0, stringBuilder, 260, out var result, out var _, out var _, stringBuilder2, 260))
				{
					return result;
				}
			}
			catch
			{
			}
			return 0u;
		}
	}
	public sealed class j
	{
		public const int A = 18;

		public const int a = 17;

		public const int B = 14;

		public const int b = 65535;

		public static readonly DateTime A_1 = new DateTime(2024, 1, 1);

		public const byte A_2 = 2;

		public const uint A_3 = 20261101u;

		public const byte a_1 = 0;

		public const byte B_1 = 1;

		public byte b_1 = 2;

		public uint a_2 = 20261101u;

		public byte[] A_4 = new byte[10];

		public ushort A_5 = ushort.MaxValue;

		public byte C;

		public bool IsForever => A_5 == ushort.MaxValue;

		public DateTime Expiry
		{
			get
			{
				if (A_5 != ushort.MaxValue)
				{
					return A_1.AddDays((int)A_5).Date;
				}
				return DateTime.MaxValue;
			}
		}

		public string MachineCode => i.A_m_1(A_4);

		public string EditionName
		{
			get
			{
				if (C != 1)
				{
					return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBt();
				}
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aBU();
			}
		}

		public static j A_m_1(byte[] P_0, DateTime P_1, int P_2)
		{
			return A_m_1(P_0, P_1, P_2, 20261101u);
		}

		public static j A_m_1(byte[] P_0, DateTime P_1, int P_2, uint P_3)
		{
			j j2 = new j();
			if (P_0 != null && P_0.Length == 10)
			{
				Buffer.BlockCopy(P_0, 0, j2.A_4, 0, 10);
			}
			j2.A_5 = ((P_1.Year >= 2200) ? ushort.MaxValue : A_m_1(P_1));
			j2.C = (byte)(P_2 & 0xFF);
			j2.a_2 = P_3;
			j2.b_1 = 2;
			return j2;
		}

		public static ushort A_m_1(DateTime P_0)
		{
			int num = (int)(P_0.Date - A_1).TotalDays;
			if (num < 1)
			{
				num = 1;
			}
			if (num >= 65535)
			{
				num = 65534;
			}
			return (ushort)num;
		}

		public byte[] A_m_1()
		{
			byte[] array = new byte[18]
			{
				b_1,
				(byte)(a_2 & 0xFF),
				(byte)((a_2 >> 8) & 0xFF),
				(byte)((a_2 >> 16) & 0xFF),
				(byte)((a_2 >> 24) & 0xFF),
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0
			};
			Buffer.BlockCopy(A_4, 0, array, 5, 10);
			array[15] = (byte)(A_5 & 0xFF);
			array[16] = (byte)(A_5 >> 8);
			array[17] = C;
			return array;
		}

		public static j A_m_1(byte[] P_0, int P_1)
		{
			return A_m_1(P_0, P_1, 18);
		}

		public static j A_m_1(byte[] P_0, int P_1, int P_2)
		{
			if (P_0 == null || P_2 < 17 || P_0.Length < P_1 + P_2)
			{
				return null;
			}
			j j2 = new j();
			j2.b_1 = P_0[P_1];
			j2.a_2 = (uint)(P_0[P_1 + 1] | (P_0[P_1 + 2] << 8) | (P_0[P_1 + 3] << 16) | (P_0[P_1 + 4] << 24));
			Buffer.BlockCopy(P_0, P_1 + 5, j2.A_4, 0, 10);
			j2.A_5 = (ushort)(P_0[P_1 + 15] | (P_0[P_1 + 16] << 8));
			j2.C = (byte)((P_2 < 18) ? 1 : P_0[P_1 + 17]);
			return j2;
		}
	}
}
namespace b
{
	public enum J
	{
		A,
		a,
		B,
		b,
		C
	}
	public sealed class j
	{
		public I A;

		public J A_1;

		public string A_2;
	}
}
