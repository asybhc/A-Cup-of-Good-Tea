using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B1262ED64_002DD0A6_002D499E_002D9510_002DF2240F018DBB_007D;
using B;
using Microsoft.Win32;

namespace C;

public static class B
{
	internal static string A;

	internal static string a;

	private const string B_f_1 = "Software\\AI大叔\\FileDedupTool.Trial";

	private const string b = "Trial";

	private const string C = "trial.dat";

	private const string c = "FDTR1";

	// 23：PBKDF2 固定盐，仅用于提高离线爆破 HMAC 密钥的成本。
	private static readonly byte[] A_1 = new byte[16]
	{
		70, 68, 84, 82, 105, 97, 108, 45, 83, 97, 108, 116, 45, 118, 49, 0
	};

	private const int a_1 = 10000;

	private static string FilePath
	{
		get
		{
			if (A != null)
			{
				return Path.Combine(A, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLx());
			}
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			if (string.IsNullOrEmpty(folderPath))
			{
				folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
			}
			return Path.Combine(Path.Combine(folderPath, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.DA()), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLx());
		}
	}

	private static string RegKey => a ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLY();

	private static byte[] A_m_1()
	{
		return A_m_1(false);
	}

	/// <summary>
	/// 23：新记录用 PBKDF2(机器码, 固定盐, 10000 次) 派生密钥；旧记录用原 SHA256 派生读取后迁移。
	/// </summary>
	private static byte[] A_m_1(bool P_0)
	{
		string text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLy() + BitConverter.ToString(J.Id) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLZ();
		if (P_0)
		{
			using SHA256 sHA = SHA256.Create();
			return sHA.ComputeHash(Encoding.UTF8.GetBytes(text));
		}
		return Rfc2898DeriveBytes.Pbkdf2(text, A_1, a_1, HashAlgorithmName.SHA256, 32);
	}

	private static bool A_m_1(string P_0, string P_1, byte[] P_2)
	{
		using HMACSHA256 hMACSHA = new HMACSHA256(P_2);
		return string.Equals(BitConverter.ToString(hMACSHA.ComputeHash(Encoding.UTF8.GetBytes(P_0))).Replace(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.@as(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()), P_1, StringComparison.OrdinalIgnoreCase);
	}

	private static string A_m_1(A P_0)
	{
		string text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aLz() + P_0.A_f_1.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alA(), CultureInfo.InvariantCulture) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lz() + P_0.a.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alA(), CultureInfo.InvariantCulture) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lz() + (P_0.A_f_2 ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CM() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CN()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lz() + (P_0.a_1 ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CM() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CN());
		using HMACSHA256 hMACSHA = new HMACSHA256(A_m_1());
		byte[] array = hMACSHA.ComputeHash(Encoding.UTF8.GetBytes(text));
		return text + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lz() + BitConverter.ToString(array).Replace(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.@as(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
	}

	private static A A_m_1(string P_0)
	{
		return A_m_1(P_0, out _);
	}

	/// <summary>23：P_1 为 true 表示该记录由旧版 SHA256 密钥签名，读取成功后需迁移为新格式。</summary>
	private static A A_m_1(string P_0, out bool P_1)
	{
		P_1 = false;
		if (string.IsNullOrWhiteSpace(P_0))
		{
			return null;
		}
		string[] array = P_0.Trim().Split('|');
		if (array.Length < 5 || array[0] != _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ala())
		{
			return null;
		}
		string text = string.Join(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lz(), array, 0, array.Length - 1);
		if (!A_m_1(text, array[^1], A_m_1(false)))
		{
			if (!A_m_1(text, array[^1], A_m_1(true)))
			{
				return null;
			}
			P_1 = true;
		}
		if (!DateTime.TryParse(array[1], CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind, out var result))
		{
			return null;
		}
		if (!DateTime.TryParse(array[2], CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind, out var result2))
		{
			return null;
		}
		if (result == DateTime.MinValue)
		{
			return null;
		}
		return new A
		{
			A_f_1 = result,
			a = result2,
			A_f_2 = (array[3] == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CM()),
			a_1 = (array[4] == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CM())
		};
	}

	/// <summary>23：读取单份记录文件；旧密钥签名迁移为新格式，解析失败按无记录处理。</summary>
	private static void A_m_1(string P_0, List<A> P_1)
	{
		try
		{
			if (!File.Exists(P_0))
			{
				return;
			}
			bool flag;
			A a2 = A_m_1(File.ReadAllText(P_0), out flag);
			if (a2 == null)
			{
				return;
			}
			P_1.Add(a2);
			if (flag)
			{
				B_m_1(a2);
			}
		}
		catch
		{
		}
	}

	public static List<A> a_m_1()
	{
		List<A> list = new List<A>();
		// 23：主记录 + 隐藏副本都读，后续 B_m_1 合并时按“更严格”取值。
		A_m_1(FilePath, list);
		A_m_1(FilePath + ".bak", list);
		if (a != null || A == null)
		{
			try
			{
				using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(RegKey, writable: false);
				if (registryKey != null)
				{
					object value = registryKey.GetValue(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alB());
					if (value != null)
					{
						A a3 = A_m_1(value.ToString());
						if (a3 != null)
						{
							list.Add(a3);
						}
					}
				}
			}
			catch
			{
			}
		}
		return list;
	}

	public static A B_m_1()
	{
		List<A> list = a_m_1();
		if (list.Count == 0)
		{
			return null;
		}
		A a2 = list[0].A_m_1();
		foreach (A item in list)
		{
			if (item.A_f_1 < a2.A_f_1)
			{
				a2.A_f_1 = item.A_f_1;
			}
			if (item.a > a2.a)
			{
				a2.a = item.a;
			}
			a2.A_f_2 |= item.A_f_2;
			// 23：双存储取严——任一份记录标记了时间回拨就按回拨处理。
			a2.a_1 |= item.a_1;
		}
		return a2;
	}

	public static void a_m_1(A P_0)
	{
		B_m_1(P_0);
		b_m_1(P_0);
	}

	internal static void B_m_1(A P_0)
	{
		if (P_0 == null)
		{
			return;
		}
		string contents = A_m_1(P_0);
		try
		{
			string filePath = FilePath;
			string directoryName = Path.GetDirectoryName(filePath);
			if (!string.IsNullOrEmpty(directoryName))
			{
				Directory.CreateDirectory(directoryName);
			}
			if (File.Exists(filePath))
			{
				try
				{
					File.SetAttributes(filePath, FileAttributes.Normal);
				}
				catch
				{
				}
			}
			File.WriteAllText(filePath, contents);
			try
			{
				File.SetAttributes(filePath, FileAttributes.Hidden);
			}
			catch
			{
			}
			// 23：写第二份隐藏副本；单份被删除或篡改时仍可取到更严格的记录。
			string text2 = filePath + ".bak";
			File.WriteAllText(text2, contents);
			try
			{
				File.SetAttributes(text2, FileAttributes.Hidden);
			}
			catch
			{
			}
		}
		catch
		{
		}
	}

	internal static void b_m_1(A P_0)
	{
		if (P_0 == null || (A != null && a == null))
		{
			return;
		}
		string value = A_m_1(P_0);
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(RegKey);
			registryKey?.SetValue(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alB(), value, RegistryValueKind.String);
		}
		catch
		{
		}
	}

	internal static void b_m_1()
	{
		// 23：主记录与隐藏副本一起清除，避免重置后残留旧记录再次生效。
		a_m_1(FilePath);
		a_m_1(FilePath + ".bak");
	}

	private static void a_m_1(string P_0)
	{
		try
		{
			if (File.Exists(P_0))
			{
				File.SetAttributes(P_0, FileAttributes.Normal);
				File.Delete(P_0);
			}
		}
		catch
		{
		}
	}

	internal static void C_m_1()
	{
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(RegKey, writable: true);
			registryKey?.DeleteValue(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.alB(), throwOnMissingValue: false);
		}
		catch
		{
		}
	}

	public static void c_m_1()
	{
		b_m_1();
		C_m_1();
	}
}
public static class b
{
	public const int A = 3;

	// 23：回拨判定阈值由 10 分钟收紧为 2 分钟，减少"改系统时间再改回"的容错窗口。
	public static readonly TimeSpan A_1 = TimeSpan.FromMinutes(2.0);

	public static a A_m_1(A P_0, DateTime P_1, bool P_2, out A P_3)
	{
		P_3 = ((P_0 == null) ? new A() : P_0.A_m_1());
		a a2 = new a();
		if (P_3.A_f_1 == DateTime.MinValue)
		{
			if (!P_2)
			{
				a2.A = false;
				a2.B = true;
				return a2;
			}
			P_3.A_f_1 = P_1;
			P_3.a = P_1;
		}
		a2.A = true;
		a2.A_1 = P_3.A_f_1;
		a2.a_f_2 = P_3.A_f_1.AddDays(3.0);
		a2.C = P_3.A_f_2;
		if (P_3.a_1)
		{
			a2.a_f_1 = false;
			a2.B = true;
			a2.b = true;
			a2.A_2 = 0;
			return a2;
		}
		DateTime dateTime = ((P_3.a > P_3.A_f_1) ? P_3.a : P_3.A_f_1);
		if (P_1 < dateTime - A_1)
		{
			P_3.a_1 = true;
			a2.a_f_1 = false;
			a2.B = true;
			a2.b = true;
			a2.A_2 = 0;
			return a2;
		}
		DateTime dateTime2 = ((P_1 < dateTime) ? dateTime : P_1);
		if (P_3.a < P_1)
		{
			P_3.a = P_1;
		}
		a2.a_f_1 = dateTime2 < a2.a_f_2;
		a2.B = !a2.a_f_1;
		if (a2.a_f_1)
		{
			a2.A_2 = (int)Math.Ceiling((a2.a_f_2 - dateTime2).TotalDays);
			if (a2.A_2 < 1)
			{
				a2.A_2 = 1;
			}
			if (a2.A_2 > 3)
			{
				a2.A_2 = 3;
			}
		}
		return a2;
	}

	public static a A_m_1(DateTime P_0, bool P_1)
	{
		A a2;
		return A_m_1(B.B_m_1(), P_0, P_1, out a2);
	}

	public static void A_m_1(A P_0)
	{
		if (P_0 != null)
		{
			B.a_m_1(P_0);
		}
	}

	public static void A_m_1()
	{
		A a2 = B.B_m_1() ?? new A();
		if (a2.A_f_1 == DateTime.MinValue)
		{
			a2.A_f_1 = DateTime.Now;
		}
		a2.A_f_2 = true;
		a2.a = DateTime.Now;
		B.a_m_1(a2);
	}

	public static void A_m_1(DateTime P_0)
	{
		if (B.B_m_1() == null)
		{
			B.a_m_1(new A
			{
				A_f_1 = P_0.AddDays(-4.0),
				a = P_0,
				A_f_2 = true
			});
		}
	}
}
