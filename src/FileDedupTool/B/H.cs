using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Encodings.Web;
using System.Text.Json;
using _003CPrivateImplementationDetails_003E_007B1262ED64_002DD0A6_002D499E_002D9510_002DF2240F018DBB_007D;
using A;
using a;

namespace B
{
	internal sealed class H
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
		private long a_1;

		[CompilerGenerated]
		private string b;

		[CompilerGenerated]
		private string C;

		[CompilerGenerated]
		private string c;

		public string Platform
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

		public string FolderId
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

		public string Path
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

		public long LastWriteUtcTicks
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

		public string Md5
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

		public string RemoteId
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

		public string SavedAt
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
	}
	internal sealed class h
	{
		private readonly string A;

		private readonly bool A_1;

		private readonly object A_2 = new object();

		private readonly object a = new object();

		private readonly Dictionary<string, H> A_3 = new Dictionary<string, H>(StringComparer.OrdinalIgnoreCase);

		private static readonly JsonSerializerOptions A_4 = new JsonSerializerOptions
		{
			WriteIndented = true,
			Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
		};

		internal int Count
		{
			get
			{
				lock (A_2)
				{
					return A_3.Count;
				}
			}
		}

		internal static h A_m_1()
		{
			if (global::a.j.DevSwitch(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JB()))
			{
				return new h(null);
			}
			return new h(Path.Combine(global::A.Y.Dir, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aaU()));
		}

		internal h(string P_0)
		{
			A = P_0;
			A_1 = !string.IsNullOrEmpty(P_0);
			if (A_1)
			{
				a_m_1();
			}
		}

		internal H A_m_1(bool P_0, string P_1, string P_2, string P_3, long P_4, long P_5, string P_6)
		{
			if (P_0)
			{
				return null;
			}
			return A_m_1(P_1, P_2, P_3, P_4, P_5, P_6);
		}

		internal H A_m_1(string P_0, string P_1, string P_2, long P_3, long P_4, string P_5)
		{
			string key = A_m_1(P_0, P_1, P_2);
			lock (A_2)
			{
				if (!A_3.TryGetValue(key, out var value) || value == null)
				{
					return null;
				}
				if (value.Size != P_3)
				{
					return null;
				}
				if (value.LastWriteUtcTicks != P_4)
				{
					return null;
				}
				if (!string.Equals(value.Md5 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(), P_5 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(), StringComparison.OrdinalIgnoreCase))
				{
					return null;
				}
				return value;
			}
		}

		internal void A_m_1(string P_0, string P_1, string P_2, long P_3, long P_4, string P_5, string P_6)
		{
			string key = A_m_1(P_0, P_1, P_2);
			lock (A_2)
			{
				A_3[key] = new H
				{
					Platform = (P_0 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()),
					FolderId = (P_1 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()),
					Path = A_m_1(P_2),
					Size = P_3,
					LastWriteUtcTicks = P_4,
					Md5 = (P_5 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()),
					RemoteId = (P_6 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()),
					SavedAt = DateTime.Now.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CI())
				};
			}
			B();
		}

		private static string A_m_1(string P_0, string P_1, string P_2)
		{
			return P_0 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BD() + P_1 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BD() + A_m_1(P_2);
		}

		private static string A_m_1(string P_0)
		{
			if (string.IsNullOrEmpty(P_0))
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}
			try
			{
				return Path.GetFullPath(P_0);
			}
			catch
			{
				return P_0;
			}
		}

		private void a_m_1()
		{
			try
			{
				if (!File.Exists(A))
				{
					return;
				}
				string text = File.ReadAllText(A);
				if (string.IsNullOrWhiteSpace(text))
				{
					return;
				}
				List<H> list = JsonSerializer.Deserialize<List<H>>(text, A_4);
				if (list == null)
				{
					return;
				}
				lock (A_2)
				{
					foreach (H item in list)
					{
						if (item != null && !string.IsNullOrEmpty(item.Path))
						{
							A_3[A_m_1(item.Platform, item.FolderId, item.Path)] = item;
						}
					}
				}
			}
			catch (Exception ex)
			{
				p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aau() + ex.Message);
			}
		}

		internal void B()
		{
			if (!A_1)
			{
				return;
			}
			lock (a)
			{
				try
				{
					List<H> value;
					lock (A_2)
					{
						value = new List<H>(A_3.Values);
					}
					string contents = JsonSerializer.Serialize(value, A_4);
					string directoryName = Path.GetDirectoryName(A);
					if (!string.IsNullOrEmpty(directoryName))
					{
						Directory.CreateDirectory(directoryName);
					}
					string text = A + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lm();
					File.WriteAllText(text, contents);
					File.Move(text, A, overwrite: true);
				}
				catch (Exception ex)
				{
					p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aaV() + ex.Message);
				}
			}
		}
	}
}
namespace b
{
	public sealed class H
	{
		public bool A;

		public string A_1;

		public string a;
	}
	public static class h
	{
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		private struct A
		{
			public nint A_f_1;

			public uint A_f_2;

			[MarshalAs(UnmanagedType.LPWStr)]
			public string A_f_3;

			[MarshalAs(UnmanagedType.LPWStr)]
			public string a;

			public ushort A_f_4;

			[MarshalAs(UnmanagedType.Bool)]
			public bool A_f_5;

			public nint a_1;

			[MarshalAs(UnmanagedType.LPWStr)]
			public string B;
		}

		private const uint A_1 = 3u;

		private const ushort A_2 = 4;

		private const ushort a = 16;

		private const ushort B = 64;

		private const ushort b = 1024;

		public const int A_3 = 240;

		[DllImport("shell32.dll", CharSet = CharSet.Unicode, EntryPoint = "SHFileOperation", SetLastError = true)]
		private static extern int A_m_1(ref A P_0);

		public static bool A_m_1(string P_0)
		{
			return a_m_1(P_0).A;
		}

		public static H a_m_1(string P_0)
		{
			H h2 = new H
			{
				a = P_0
			};
			if (string.IsNullOrEmpty(P_0))
			{
				h2.A_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajB();
				return h2;
			}
			if (!File.Exists(global::a.a.A(P_0)))
			{
				h2.A_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jH();
				return h2;
			}
			string text = global::a.a.a_m_1(Path.GetFullPath(global::a.a.a_m_1(P_0)));
			if (text.Length <= 240)
			{
				return A_m_1(text, text);
			}
			return B_m_1(text);
		}

		private static H A_m_1(string P_0, string P_1)
		{
			H h2 = new H
			{
				a = P_1
			};
			A a2 = new A
			{
				A_f_1 = IntPtr.Zero,
				A_f_2 = 3u,
				A_f_3 = P_0 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajb(),
				a = null,
				A_f_4 = 1108
			};
			int num;
			try
			{
				num = A_m_1(ref a2);
			}
			catch (Exception ex)
			{
				h2.A_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajC() + ex.Message;
				return h2;
			}
			if (num != 0 || a2.A_f_5)
			{
				h2.A_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajc() + num + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ln();
				return h2;
			}
			if (File.Exists(global::a.a.A(P_1)))
			{
				h2.A_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajD();
				return h2;
			}
			h2.A = true;
			return h2;
		}

		private static H B_m_1(string P_0)
		{
			H h2 = new H
			{
				a = P_0
			};
			string directoryName = Path.GetDirectoryName(P_0);
			int num = 0;
			while (!string.IsNullOrEmpty(directoryName) && directoryName.Length > 200 && num++ < 40)
			{
				directoryName = Path.GetDirectoryName(directoryName);
			}
			if (string.IsNullOrEmpty(directoryName) || !Directory.Exists(global::a.a.A(directoryName)))
			{
				h2.A_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajd();
				return h2;
			}
			string text = Path.Combine(directoryName, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajE() + Guid.NewGuid().ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.cL()).Substring(0, 8));
			string text2 = Path.GetExtension(P_0);
			if (text2.Length > 20)
			{
				text2 = text2.Substring(0, 20);
			}
			// R14 / C-13：临时文件名带上原文件名主干，回收站中可直接看出对应哪个文件（原实现只有 GUID，无法辨认）。
			string text4 = Path.GetFileNameWithoutExtension(P_0);
			if (text4.Length > 60)
			{
				text4 = text4.Substring(0, 60);
			}
			if (string.IsNullOrEmpty(text4))
			{
				text4 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}
			string path = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aje() + text4 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajg() + Guid.NewGuid().ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.cL()).Substring(0, 10) + text2;
			string text3 = Path.Combine(text, path);
			try
			{
				Directory.CreateDirectory(global::a.a.A(text));
				File.Move(global::a.a.A(P_0), global::a.a.A(text3));
			}
			catch (Exception ex)
			{
				try
				{
					Directory.Delete(global::a.a.A(text), recursive: false);
				}
				catch (Exception ex2)
				{
					global::B.p.a_m_1("清理临时目录失败（移动失败回滚时）：" + text + "；" + ex2.GetType().Name + "：" + ex2.Message);
				}
				h2.A_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajF() + ex.Message;
				return h2;
			}
			H h3 = A_m_1(text3, text3);
			if (!h3.A)
			{
				try
				{
					File.Move(global::a.a.A(text3), global::a.a.A(P_0));
					h2.A_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajf() + (h3.A_1 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGr()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ln();
				}
				catch (Exception ex2)
				{
					// R14 / C-13：回移失败时再尝试复制回原路径，避免文件滞留在临时目录而用户无从查找。
					try
					{
						File.Copy(global::a.a.A(text3), global::a.a.A(P_0), overwrite: false);
						File.Delete(global::a.a.A(text3));
						h2.A_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajf() + (h3.A_1 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aGr()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ln();
					}
					catch
					{
						h2.a = text3;
						h2.A_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajG() + global::a.a.a_m_1(text3) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajg() + ex2.Message + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ln();
					}
				}
				try
				{
					Directory.Delete(global::a.a.A(text), recursive: false);
				}
				catch (Exception ex3)
				{
					global::B.p.a_m_1("清理临时目录失败（长路径回移后）：" + text + "；" + ex3.GetType().Name + "：" + ex3.Message);
				}
				return h2;
			}
			try
			{
				Directory.Delete(global::a.a.A(text), recursive: false);
			}
			catch (Exception ex4)
			{
				global::B.p.a_m_1("清理临时目录失败（长路径回收成功后）：" + text + "；" + ex4.GetType().Name + "：" + ex4.Message);
			}
			h2.A = true;
			h2.a = text3;
			return h2;
		}
	}
}
