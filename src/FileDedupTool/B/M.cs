using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B1262ED64_002DD0A6_002D499E_002D9510_002DF2240F018DBB_007D;
using C;
using Microsoft.Win32;

namespace B
{
	public sealed class M
	{
		public string A = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		public long A_1;

		public long a;

		public string a_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		public int A_2;

		public uint A_3 = 20261101u;

		public M A_m_1()
		{
			return new M
			{
				A = A,
				A_1 = A_1,
				a = a,
				a_1 = a_1,
				A_2 = A_2,
				A_3 = A_3
			};
		}
	}
	public static class m
	{
		private const string A_1 = "Software\\AI大叔\\FileDedupTool";

		private const string a = "Lic";

		private const string B = "license.dat";

		internal static string b;

		public static IEnumerable<string> Files
		{
			get
			{
				if (b != null)
				{
					yield return Path.Combine(b, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNs());
					yield break;
				}
				string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
				if (string.IsNullOrEmpty(folderPath))
				{
					folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
				}
				yield return Path.Combine(Path.Combine(folderPath, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.DA()), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNs());
				string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
				if (!string.IsNullOrEmpty(folderPath2))
				{
					yield return Path.Combine(Path.Combine(folderPath2, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.DA()), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNs());
				}
			}
		}

		private static byte[] A_m_1(string P_0, byte[] P_1)
		{
			using SHA256 sHA = SHA256.Create();
			return sHA.ComputeHash(Encoding.UTF8.GetBytes(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCE() + P_0 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lz() + BitConverter.ToString(P_1) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCe()));
		}

		private static string A_m_1(M P_0)
		{
			byte[] id = J.Id;
			byte[] bytes = Encoding.UTF8.GetBytes(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCF() + P_0.A + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BD() + P_0.A_1 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BD() + P_0.a + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BD() + P_0.a_1 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BD() + P_0.A_2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BD() + P_0.A_3);
			byte[] key = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCf(), id);
			byte[] key2 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCG(), id);
			using Aes aes = Aes.Create();
			aes.KeySize = 256;
			aes.Mode = CipherMode.CBC;
			aes.Padding = PaddingMode.PKCS7;
			aes.Key = key;
			aes.GenerateIV();
			byte[] array = aes.CreateEncryptor().TransformFinalBlock(bytes, 0, bytes.Length);
			byte[] array2 = new byte[aes.IV.Length + array.Length];
			Buffer.BlockCopy(aes.IV, 0, array2, 0, 16);
			Buffer.BlockCopy(array, 0, array2, 16, array.Length);
			byte[] array3;
			using (HMACSHA256 hMACSHA = new HMACSHA256(key2))
			{
				array3 = hMACSHA.ComputeHash(array2);
			}
			byte[] array4 = new byte[array2.Length + array3.Length];
			Buffer.BlockCopy(array2, 0, array4, 0, array2.Length);
			Buffer.BlockCopy(array3, 0, array4, array2.Length, array3.Length);
			return Convert.ToBase64String(array4);
		}

		private static M A_m_1(string P_0)
		{
			if (string.IsNullOrWhiteSpace(P_0))
			{
				return null;
			}
			byte[] array;
			try
			{
				array = Convert.FromBase64String(P_0.Trim());
			}
			catch
			{
				return null;
			}
			if (array.Length < 64)
			{
				return null;
			}
			byte[] id = J.Id;
			byte[] key = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCf(), id);
			byte[] key2 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCG(), id);
			int num = array.Length - 32;
			byte[] array2 = new byte[num];
			byte[] array3 = new byte[32];
			Buffer.BlockCopy(array, 0, array2, 0, num);
			Buffer.BlockCopy(array, num, array3, 0, 32);
			byte[] array4;
			using (HMACSHA256 hMACSHA = new HMACSHA256(key2))
			{
				array4 = hMACSHA.ComputeHash(array2);
			}
			if (!A_m_1(array3, array4))
			{
				return null;
			}
			using Aes aes = Aes.Create();
			aes.KeySize = 256;
			aes.Mode = CipherMode.CBC;
			aes.Padding = PaddingMode.PKCS7;
			aes.Key = key;
			byte[] array5 = new byte[16];
			Buffer.BlockCopy(array2, 0, array5, 0, 16);
			aes.IV = array5;
			byte[] array6 = new byte[num - 16];
			Buffer.BlockCopy(array2, 16, array6, 0, array6.Length);
			try
			{
				byte[] bytes = aes.CreateDecryptor().TransformFinalBlock(array6, 0, array6.Length);
				string[] array7 = Encoding.UTF8.GetString(bytes).Split('\n');
				if (array7.Length < 7 || array7[0] != _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCg())
				{
					return null;
				}
				M m2 = new M();
				m2.A = L.A_m_1(array7[1]);
				long.TryParse(array7[2], out m2.A_1);
				long.TryParse(array7[3], out m2.a);
				m2.a_1 = array7[4].Trim();
				int.TryParse(array7[5], out m2.A_2);
				uint.TryParse(array7[6], out m2.A_3);
				if (m2.A_3 != 20261101)
				{
					return null;
				}
				return m2;
			}
			catch
			{
				return null;
			}
		}

		public static bool A_m_1(byte[] P_0, byte[] P_1)
		{
			if (P_0 == null || P_1 == null || P_0.Length != P_1.Length)
			{
				return false;
			}
			int num = 0;
			for (int num2 = 0; num2 < P_0.Length; num2++)
			{
				num |= P_0[num2] ^ P_1[num2];
			}
			return num == 0;
		}

		public static M A_m_1()
		{
			foreach (string file in Files)
			{
				try
				{
					if (File.Exists(file))
					{
						M m2 = A_m_1(File.ReadAllText(file));
						if (m2 != null && m2.A.Length > 0)
						{
							return m2;
						}
					}
				}
				catch
				{
				}
			}
			if (b != null)
			{
				return null;
			}
			try
			{
				using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCH(), writable: false);
				if (registryKey != null)
				{
					object value = registryKey.GetValue(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCh());
					if (value != null)
					{
						M m3 = A_m_1(value.ToString());
						if (m3 != null && m3.A.Length > 0)
						{
							return m3;
						}
					}
				}
			}
			catch
			{
			}
			return null;
		}

		public static void a_m_1(M P_0)
		{
			if (P_0 == null)
			{
				return;
			}
			string text = A_m_1(P_0);
			foreach (string file in Files)
			{
				try
				{
					string directoryName = Path.GetDirectoryName(file);
					if (!string.IsNullOrEmpty(directoryName))
					{
						Directory.CreateDirectory(directoryName);
					}
					if (File.Exists(file))
					{
						try
						{
							File.SetAttributes(file, FileAttributes.Normal);
						}
						catch
						{
						}
					}
					File.WriteAllText(file, text);
					try
					{
						File.SetAttributes(file, FileAttributes.Hidden);
					}
					catch
					{
					}
				}
				catch
				{
				}
			}
			if (b != null)
			{
				return;
			}
			try
			{
				using RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCH());
				registryKey?.SetValue(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCh(), text, RegistryValueKind.String);
			}
			catch
			{
			}
		}

		public static void a_m_1()
		{
			foreach (string file in Files)
			{
				try
				{
					if (File.Exists(file))
					{
						File.SetAttributes(file, FileAttributes.Normal);
						File.Delete(file);
					}
				}
				catch
				{
				}
			}
			if (b != null)
			{
				return;
			}
			try
			{
				using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCH(), writable: true);
				registryKey?.DeleteValue(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCh(), throwOnMissingValue: false);
			}
			catch
			{
			}
		}

		public static int B_m_1()
		{
			int num = 0;
			foreach (string file in Files)
			{
				try
				{
					if (File.Exists(file))
					{
						num++;
					}
				}
				catch
				{
				}
			}
			if (b != null)
			{
				return num;
			}
			try
			{
				using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCH(), writable: false);
				if (registryKey != null && registryKey.GetValue(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aCh()) != null)
				{
					num++;
				}
			}
			catch
			{
			}
			return num;
		}
	}
}
namespace b
{
	internal sealed class M
	{
		[CompilerGenerated]
		private List<l> A = new List<l>();

		[CompilerGenerated]
		private List<string> A_1 = new List<string>();

		[CompilerGenerated]
		private int A_2;

		[CompilerGenerated]
		private int a;

		[CompilerGenerated]
		private bool A_3;

		public List<l> Nodes
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

		public List<string> Errors
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

		public int FoldersScanned
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

		public int FolderLimitSkipped
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

		public bool DepthLimited
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

		public int FilesFound
		{
			get
			{
				int num = 0;
				foreach (l node in Nodes)
				{
					if (!node.IsFolder)
					{
						num++;
					}
				}
				return num;
			}
		}
	}
	internal sealed class m
	{
		[CompilerGenerated]
		private string A;

		[CompilerGenerated]
		private long A_1;

		[CompilerGenerated]
		private List<l> A_2 = new List<l>();

		[CompilerGenerated]
		private int A_3;

		public string Name
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

		public List<l> Items
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

		public int KeepIndex
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

		public string SizeText => global::C.E.A_m_1(Size);
	}
}
