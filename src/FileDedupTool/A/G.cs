using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007B1262ED64_002DD0A6_002D499E_002D9510_002DF2240F018DBB_007D;

namespace A
{
	public sealed class G
	{
		public bool A;

		public f A_1;

		public int A_2;

		public int a;

		public string A_3 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		public string a_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		public string B = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		public int B_1;

		public bool a_2;

		public string b = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
	}
	public sealed class g
	{
		public string A = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		public string a = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		public string B = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		public string b = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

		public int A_1 = 15;
	}
}
namespace a
{
	public sealed class G
	{
		public string A;

		public string a;

		public DriveType A_1;

		public bool A_2;

		public long A_3;

		public long a_1;

		public string B;
	}
	public static class g
	{
		[CompilerGenerated]
		private sealed class A
		{
			public bool A_f_1;

			internal F A_m_1(string P_0)
			{
				string text;
				return g.A_m_1(P_0, A_f_1, out text);
			}
		}

		public static bool A_m_1(DriveType P_0)
		{
			if (P_0 != DriveType.Fixed)
			{
				return P_0 == DriveType.Removable;
			}
			return true;
		}

		public static List<G> A_m_1(Func<IEnumerable<DriveInfo>> P_0 = null)
		{
			List<G> list = new List<G>();
			try
			{
				IEnumerable<DriveInfo> enumerable;
				if (P_0 != null)
				{
					enumerable = P_0();
				}
				else
				{
					IEnumerable<DriveInfo> drives = DriveInfo.GetDrives();
					enumerable = drives;
				}
				IEnumerable<DriveInfo> enumerable2 = enumerable;
				if (enumerable2 == null)
				{
					return list;
				}
				foreach (DriveInfo item in enumerable2)
				{
					if (item == null || !A_m_1(item.DriveType))
					{
						continue;
					}
					G g2 = new G
					{
						A = item.Name,
						A_1 = item.DriveType
					};
					try
					{
						g2.A_2 = item.IsReady;
					}
					catch
					{
						g2.A_2 = false;
					}
					if (g2.A_2)
					{
						try
						{
							g2.a = item.VolumeLabel;
						}
						catch
						{
						}
						try
						{
							g2.B = item.DriveFormat;
						}
						catch
						{
						}
						try
						{
							g2.A_3 = item.TotalSize;
						}
						catch
						{
						}
						try
						{
							g2.a_1 = item.TotalFreeSpace;
						}
						catch
						{
						}
					}
					list.Add(g2);
				}
			}
			catch
			{
			}
			return A_m_1(list);
		}

		public static List<G> A_m_1(IEnumerable<G> P_0)
		{
			List<G> list = new List<G>();
			HashSet<string> hashSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
			if (P_0 == null)
			{
				return list;
			}
			foreach (G item in P_0)
			{
				if (item != null && A_m_1(item.A_1))
				{
					string text = A_m_1(item.A);
					if (text.Length != 0 && hashSet.Add(text))
					{
						item.A = text;
						list.Add(item);
					}
				}
			}
			return list;
		}

		public static string A_m_1(string P_0)
		{
			if (string.IsNullOrWhiteSpace(P_0))
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}
			string text = P_0.Trim();
			if (!text.EndsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jb(), StringComparison.Ordinal) && !text.EndsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aA(), StringComparison.Ordinal))
			{
				text += _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jb();
			}
			return text;
		}

		public static string a(DriveType P_0)
		{
			return P_0 switch
			{
				DriveType.Fixed => Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jI()), 
				DriveType.Removable => Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ji()), 
				DriveType.Network => Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jJ()), 
				DriveType.CDRom => Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jj()), 
				DriveType.Ram => Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jK()), 
				_ => Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.dc()), 
			};
		}

		public static string A_m_1()
		{
			return Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jk());
		}

		public static bool A_m_1(G P_0, out string P_1)
		{
			P_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			if (P_0 == null)
			{
				P_1 = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jL());
				return false;
			}
			if (!P_0.A_2)
			{
				P_1 = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jl());
				return false;
			}
			if (!A_m_1(P_0))
			{
				return true;
			}
			if (P_0.A_1 == DriveType.Removable)
			{
				P_1 = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jM());
				return false;
			}
			P_1 = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jm(), (P_0.B ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).Trim());
			return false;
		}

		private static bool A_m_1(G P_0)
		{
			if (P_0.A_1 == DriveType.Removable)
			{
				return true;
			}
			string text = (P_0.B ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).Trim();
			if (text.Length > 0)
			{
				return !string.Equals(text, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jN(), StringComparison.OrdinalIgnoreCase);
			}
			return false;
		}

		public static F A_m_1(G P_0, bool P_1, out string P_2)
		{
			P_2 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			if (P_0 == null)
			{
				P_2 = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jL());
				return F.B;
			}
			if (!P_0.A_2)
			{
				P_2 = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jl());
				return F.B;
			}
			if (!A_m_1(P_0))
			{
				return F.A;
			}
			if (P_1)
			{
				return F.a;
			}
			A_m_1(P_0, out P_2);
			return F.B;
		}

		public static F A_m_1(string P_0, bool P_1, out string P_2)
		{
			P_2 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			try
			{
				string pathRoot = Path.GetPathRoot(global::a.a.a_m_1(Path.GetFullPath(global::a.a.a_m_1(P_0))));
				if (string.IsNullOrEmpty(pathRoot))
				{
					P_2 = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jn());
					return F.B;
				}
				DriveInfo driveInfo = new DriveInfo(pathRoot);
				G g2 = new G
				{
					A = driveInfo.Name,
					A_1 = driveInfo.DriveType
				};
				try
				{
					g2.A_2 = driveInfo.IsReady;
				}
				catch
				{
					g2.A_2 = false;
				}
				if (g2.A_2)
				{
					try
					{
						g2.B = driveInfo.DriveFormat;
					}
					catch
					{
					}
				}
				return A_m_1(g2, P_1, out P_2);
			}
			catch (Exception ex)
			{
				P_2 = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jO()) + ex.Message;
				return F.B;
			}
		}

		public static f A_m_1(IEnumerable<C> P_0, bool P_1)
		{
			return A_m_1(P_0, (string text) => A_m_1(text, P_1, out var _));
		}

		public static f A_m_1(IEnumerable<C> P_0, Func<string, F> P_1)
		{
			f f2 = new f();
			if (P_0 == null)
			{
				return f2;
			}
			Dictionary<string, F> dictionary = new Dictionary<string, F>(StringComparer.OrdinalIgnoreCase);
			foreach (C item in P_0)
			{
				if (item == null || P_1 == null)
				{
					f2.B++;
					continue;
				}
				string key;
				try
				{
					key = Path.GetPathRoot(global::a.a.a_m_1(item.A)) ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
				}
				catch
				{
					key = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
				}
				if (!dictionary.TryGetValue(key, out var value))
				{
					try
					{
						value = P_1(item.A);
					}
					catch
					{
						value = F.B;
					}
					dictionary[key] = value;
				}
				switch (value)
				{
				case F.A:
					f2.A++;
					f2.A_1 += item.A_1;
					break;
				case F.a:
					f2.a++;
					f2.a_1 += item.A_1;
					break;
				default:
					f2.B++;
					break;
				}
			}
			return f2;
		}

		public static bool A_m_1(string P_0, out string P_1)
		{
			P_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			try
			{
				string pathRoot = Path.GetPathRoot(global::a.a.a_m_1(Path.GetFullPath(global::a.a.a_m_1(P_0))));
				if (string.IsNullOrEmpty(pathRoot))
				{
					P_1 = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jn());
					return false;
				}
				DriveInfo driveInfo = new DriveInfo(pathRoot);
				G g2 = new G
				{
					A = driveInfo.Name,
					A_1 = driveInfo.DriveType
				};
				try
				{
					g2.A_2 = driveInfo.IsReady;
				}
				catch
				{
					g2.A_2 = false;
				}
				if (g2.A_2)
				{
					try
					{
						g2.B = driveInfo.DriveFormat;
					}
					catch
					{
					}
				}
				return A_m_1(g2, out P_1);
			}
			catch (Exception ex)
			{
				P_1 = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jo()) + ex.Message;
				return false;
			}
		}
	}
}
