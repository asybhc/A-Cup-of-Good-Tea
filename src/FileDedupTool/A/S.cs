using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007B1262ED64_002DD0A6_002D499E_002D9510_002DF2240F018DBB_007D;
using A;
using B;
using a;
using b;

namespace A
{
	public static class S
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class A
		{
			public static readonly A A_f_1 = new A();

			public static Func<Tuple<string, double, string>, string> A_f_2;

			public static Func<Tuple<string, double, string>, double> A_f_3;

			public static Func<Tuple<string, double, string>, string> a;

			public static Func<Tuple<string, double, string>, string> B;

			internal string A_m_1(Tuple<string, double, string> P_0)
			{
				return P_0.Item3;
			}

			internal double a_m_1(Tuple<string, double, string> P_0)
			{
				return P_0.Item2;
			}

			internal string B_m_1(Tuple<string, double, string> P_0)
			{
				return P_0.Item1;
			}

			internal string b(Tuple<string, double, string> P_0)
			{
				return P_0.Item1;
			}
		}

		private static readonly string[] A_1 = new string[2]
		{
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Dt(),
			_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.DT()
		};

		public static bool A_m_1(string P_0)
		{
			string value = Path.GetExtension(P_0).ToLowerInvariant();
			return Array.IndexOf(A_1, value) >= 0;
		}

		public static double? a(string P_0)
		{
			string text = Path.GetExtension(P_0).ToLowerInvariant();
			try
			{
				if (text == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.DT())
				{
					return B(P_0);
				}
				if (text == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Dt())
				{
					return b(P_0);
				}
			}
			catch
			{
			}
			return null;
		}

		public static double? B(string P_0)
		{
			using FileStream fileStream = File.OpenRead(global::a.a.A(P_0));
			using BinaryReader binaryReader = new BinaryReader(fileStream);
			if (fileStream.Length < 44)
			{
				return null;
			}
			if (new string(binaryReader.ReadChars(4)) != _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.DU())
			{
				return null;
			}
			binaryReader.ReadBytes(4);
			if (new string(binaryReader.ReadChars(4)) != _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Du())
			{
				return null;
			}
			int num = 0;
			long num2 = -1L;
			while (fileStream.Position + 8 <= fileStream.Length)
			{
				string text = new string(binaryReader.ReadChars(4));
				uint num3 = binaryReader.ReadUInt32();
				if (text == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.DV())
				{
					binaryReader.ReadInt16();
					binaryReader.ReadInt16();
					binaryReader.ReadInt32();
					num = binaryReader.ReadInt32();
					binaryReader.ReadBytes((int)Math.Max(0u, num3 - 12));
				}
				else if (text == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CE())
				{
					num2 = num3;
					if (num > 0)
					{
						break;
					}
					binaryReader.ReadBytes((int)Math.Min(num3, (ulong)(fileStream.Length - fileStream.Position)));
				}
				else
				{
					binaryReader.ReadBytes((int)Math.Min(num3, (ulong)(fileStream.Length - fileStream.Position)));
				}
			}
			if (num <= 0 || num2 <= 0)
			{
				return null;
			}
			return (double)num2 / (double)num;
		}

		public static double? b(string P_0)
		{
			using (FileStream fileStream = File.OpenRead(global::a.a.A(P_0)))
			{
				using BinaryReader binaryReader = new BinaryReader(fileStream);
				if (fileStream.Length >= 10)
				{
					byte[] array = binaryReader.ReadBytes(3);
					if (array[0] == 73 && array[1] == 68 && array[2] == 51)
					{
						binaryReader.ReadBytes(3);
						uint num = (uint)(((binaryReader.ReadByte() & 0x7F) << 21) | ((binaryReader.ReadByte() & 0x7F) << 14) | ((binaryReader.ReadByte() & 0x7F) << 7) | (binaryReader.ReadByte() & 0x7F));
						fileStream.Seek(num + 10, SeekOrigin.Begin);
					}
					else
					{
						fileStream.Seek(0L, SeekOrigin.Begin);
					}
				}
				int num2;
				while ((num2 = fileStream.ReadByte()) >= 0)
				{
					if (num2 != 255)
					{
						continue;
					}
					int num3 = fileStream.ReadByte();
					if (num3 < 0 || (num3 & 0xE0) != 224)
					{
						continue;
					}
					int num4 = (num3 >> 3) & 3;
					int num5 = (num3 >> 1) & 3;
					if (num4 == 1 || num5 == 0)
					{
						continue;
					}
					// 25：帧头起点（已读 0xFF 与第二字节），Xing/Info 标签位置由版本与声道决定。
					long num8 = fileStream.Position - 2;
					int num6 = fileStream.ReadByte();
					if (num6 < 0)
					{
						continue;
					}
					int num9 = (num6 >> 4) & 0xF;
					int num10 = (num6 >> 2) & 3;
					int num11 = fileStream.ReadByte();
					if (num9 == 0 || num9 == 15 || num10 == 3 || num11 < 0)
					{
						continue;
					}
					int num7 = A_m_1((num4 == 3) ? 3 : 2, num5, num9);
					if (num7 <= 0)
					{
						continue;
					}
					// 25：优先用 Xing/Info 帧数换算时长（VBR 准确），失败再回退原 CBR 估算。
					double? num12 = A_m_2(fileStream, num8, num4, num5, num10, num11);
					if (num12.HasValue)
					{
						return num12.Value;
					}
					return (double)fileStream.Length * 8.0 / (double)num7;
				}
			}
			return null;
		}

		/// <summary>
		/// 25：读取 Xing/Info 标签的 frames 字段换算时长。标签不存在或数据不合法时返回 null，
		/// 由调用方回退原有的 CBR 估算，保证既有行为不变。
		/// </summary>
		private static double? A_m_2(FileStream P_0, long P_1, int P_2, int P_3, int P_4, int P_5)
		{
			bool flag = ((P_5 >> 6) & 3) == 3;
			int num = ((P_2 == 3) ? (flag ? 17 : 32) : (flag ? 9 : 17));
			long num2 = P_1 + 4 + num;
			if (num2 + 12 > P_0.Length)
			{
				return null;
			}
			long position = P_0.Position;
			try
			{
				P_0.Seek(num2, SeekOrigin.Begin);
				byte[] array = new byte[12];
				if (P_0.Read(array, 0, array.Length) < array.Length)
				{
					return null;
				}
				bool flag2 = array[0] == 88 && array[1] == 105 && array[2] == 110 && array[3] == 103;
				bool flag3 = array[0] == 73 && array[1] == 110 && array[2] == 102 && array[3] == 111;
				if (!flag2 && !flag3)
				{
					return null;
				}
				uint num3 = (uint)((array[4] << 24) | (array[5] << 16) | (array[6] << 8) | array[7]);
				if ((num3 & 1) == 0)
				{
					return null;
				}
				uint num4 = (uint)((array[8] << 24) | (array[9] << 16) | (array[10] << 8) | array[11]);
				if (num4 == 0)
				{
					return null;
				}
				int num5 = A_m_2(P_2, P_4);
				if (num5 <= 0)
				{
					return null;
				}
				int num6 = ((P_3 == 1) ? ((P_2 == 3) ? 1152 : 576) : ((P_3 == 3) ? 384 : 1152));
				double num7 = (double)num4 * (double)num6 / (double)num5;
				// 时长与文件剩余字节换算出的平均码率需落在 MP3 合理区间，避免误读随机数据。
				double num8 = (double)(P_0.Length - P_1) * 8.0 / num7;
				if (num7 >= 1.0 && num7 <= 86400.0 && num8 >= 8000.0 && num8 <= 640000.0)
				{
					return num7;
				}
			}
			catch
			{
			}
			finally
			{
				P_0.Seek(position, SeekOrigin.Begin);
			}
			return null;
		}

		private static int A_m_2(int P_0, int P_1)
		{
			int[] array = ((P_0 == 3) ? new int[3] { 44100, 48000, 32000 } : ((P_0 == 2) ? new int[3] { 22050, 24000, 16000 } : new int[3] { 11025, 12000, 8000 }));
			if (P_1 < 0 || P_1 > 2)
			{
				return 0;
			}
			return array[P_1];
		}

		public static List<List<string>> A_m_1(List<string> P_0, int P_1, Action<int, int> P_2 = null)
		{
			List<List<string>> list = new List<List<string>>();
			List<Tuple<string, double, string>> list2 = new List<Tuple<string, double, string>>();
			int num = 0;
			foreach (string item in P_0)
			{
				double? num2 = a(item);
				P_2?.Invoke(++num, P_0.Count);
				if (num2.HasValue)
				{
					list2.Add(Tuple.Create(item, num2.Value, Path.GetExtension(item).ToLowerInvariant()));
				}
			}
			foreach (IGrouping<string, Tuple<string, double, string>> item2 in from tuple in list2
				group tuple by tuple.Item3)
			{
				List<Tuple<string, double, string>> list3 = item2.OrderBy((Tuple<string, double, string> tuple) => tuple.Item2).ToList();
				List<Tuple<string, double, string>> list4 = new List<Tuple<string, double, string>>();
				foreach (Tuple<string, double, string> item3 in list3)
				{
					// R11：时长改为与组首成员（锚点）比较，而非与上一个成员比较。
					// 链式比较会让“逐个相差一点点”的文件串成一串，累积偏差远超阈值后仍被当成同一组；
					// 锚点比较保证组内任意成员的时长都落在“锚点 ± 阈值”区间内。
					if (list4.Count == 0 || item3.Item2 - list4[0].Item2 <= (double)Math.Max(0, P_1))
					{
						list4.Add(item3);
						continue;
					}
					if (list4.Count >= 2)
					{
						list.Add(list4.Select((Tuple<string, double, string> tuple) => tuple.Item1).ToList());
					}
					list4 = new List<Tuple<string, double, string>> { item3 };
				}
				if (list4.Count >= 2)
				{
					list.Add(list4.Select((Tuple<string, double, string> tuple) => tuple.Item1).ToList());
				}
			}
			return list;
		}

		[CompilerGenerated]
		internal static int A_m_1(int P_0, int P_1, int P_2)
		{
			int[,] array = new int[3, 15]
			{
				{
					0, 32, 64, 96, 128, 160, 192, 224, 256, 288,
					320, 352, 384, 416, 448
				},
				{
					0, 32, 48, 56, 64, 80, 96, 112, 128, 160,
					192, 224, 256, 320, 384
				},
				{
					0, 32, 40, 48, 56, 64, 80, 96, 112, 128,
					160, 192, 224, 256, 320
				}
			};
			int[,] array2 = new int[3, 15]
			{
				{
					0, 32, 48, 56, 64, 80, 96, 112, 128, 144,
					160, 176, 192, 224, 256
				},
				{
					0, 8, 16, 24, 32, 40, 48, 56, 64, 80,
					96, 112, 128, 144, 160
				},
				{
					0, 8, 16, 24, 32, 40, 48, 56, 64, 80,
					96, 112, 128, 144, 160
				}
			};
			int num = P_1 switch
			{
				2 => 1, 
				3 => 0, 
				_ => 2, 
			};
			return ((P_0 == 3) ? array[num, P_2] : array2[num, P_2]) * 1000;
		}
	}
	internal sealed class s : Control
	{
		private readonly b.Y A;

		private readonly List<B.C> A_1 = new List<B.C>();

		private readonly List<Rectangle> A_2 = new List<Rectangle>();

		private int A_3 = -1;

		[CompilerGenerated]
		private Action<int> A_4;

		internal event Action<int> CrumbClicked
		{
			[CompilerGenerated]
			add
			{
				Action<int> action = A_4;
				Action<int> action2;
				do
				{
					action2 = action;
					Action<int> value2 = (Action<int>)Delegate.Combine(action2, value);
					action = Interlocked.CompareExchange(ref A_4, value2, action2);
				}
				while ((object)action != action2);
			}
			[CompilerGenerated]
			remove
			{
				Action<int> action = A_4;
				Action<int> action2;
				do
				{
					action2 = action;
					Action<int> value2 = (Action<int>)Delegate.Remove(action2, value);
					action = Interlocked.CompareExchange(ref A_4, value2, action2);
				}
				while ((object)action != action2);
			}
		}

		internal s(b.Y P_0)
		{
			A = P_0 ?? b.Y.A_m_1();
			SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
			Font = B.Q.A_m_1(10f);
			Height = 28;
			BackColor = A.A;
			ForeColor = A.b;
			Cursor = Cursors.Default;
			A_m_1(B.c.A_m_1());
		}

		internal void A_m_1(IList<B.C> P_0)
		{
			A_1.Clear();
			if (P_0 != null)
			{
				A_1.AddRange(P_0);
			}
			if (A_1.Count == 0)
			{
				A_1.AddRange(B.c.A_m_1());
			}
			Text = B.c.A_m_1((IEnumerable<B.C>)A_1);
			A_3 = -1;
			Invalidate();
		}

		protected override void OnPaint(PaintEventArgs P_0)
		{
			A_2.Clear();
			using (SolidBrush brush = new SolidBrush(BackColor))
			{
				P_0.Graphics.FillRectangle(brush, ClientRectangle);
			}
			string text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Dv();
			int num = 2;
			for (int num2 = 0; num2 < A_1.Count; num2++)
			{
				if (num2 > 0)
				{
					int width = TextRenderer.MeasureText(P_0.Graphics, text, Font).Width;
					if (num + width > Width - 4)
					{
						break;
					}
					TextRenderer.DrawText(P_0.Graphics, text, Font, new Point(num, (Height - Font.Height) / 2), A.I, TextFormatFlags.NoPrefix);
					num += width;
				}
				string text2 = (A_1[num2].a ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).Trim();
				if (text2.Length == 0)
				{
					text2 = ((num2 == 0) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Dw() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.DW());
				}
				int width2 = TextRenderer.MeasureText(P_0.Graphics, text2, Font).Width;
				int val = Math.Max(1, Width - num - 4);
				Rectangle rectangle = new Rectangle(num, 0, Math.Min(width2, val), Height);
				A_2.Add(rectangle);
				bool flag = num2 == A_1.Count - 1;
				TextRenderer.DrawText(foreColor: flag ? A.b : ((!Enabled) ? A.I : ((A_3 == num2) ? A.C : A.f)), dc: P_0.Graphics, text: text2, font: Font, bounds: rectangle, flags: TextFormatFlags.EndEllipsis | TextFormatFlags.NoPrefix | TextFormatFlags.VerticalCenter);
				if (!flag && Enabled && A_3 == num2)
				{
					int num3 = (Height + Font.Height) / 2 + 1;
					using Pen pen = new Pen(A.f);
					P_0.Graphics.DrawLine(pen, rectangle.Left, num3, rectangle.Right, num3);
				}
				num += width2;
				if (num >= Width - 4)
				{
					break;
				}
			}
		}

		private int A_m_1(Point P_0)
		{
			for (int num = 0; num < A_2.Count; num++)
			{
				if (A_2[num].Contains(P_0))
				{
					return num;
				}
			}
			return -1;
		}

		protected override void OnMouseMove(MouseEventArgs P_0)
		{
			int num = (Enabled ? A_m_1(P_0.Location) : (-1));
			if (num != A_3)
			{
				A_3 = num;
				Cursor = ((num >= 0 && num < A_1.Count - 1) ? Cursors.Hand : Cursors.Default);
				Invalidate();
			}
			base.OnMouseMove(P_0);
		}

		protected override void OnMouseLeave(EventArgs P_0)
		{
			if (A_3 != -1)
			{
				A_3 = -1;
				Cursor = Cursors.Default;
				Invalidate();
			}
			base.OnMouseLeave(P_0);
		}

		protected override void OnMouseUp(MouseEventArgs P_0)
		{
			if (P_0.Button == MouseButtons.Left && Enabled)
			{
				int num = A_m_1(P_0.Location);
				if (num >= 0 && num < A_1.Count - 1 && A_4 != null)
				{
					A_4(num);
				}
			}
			base.OnMouseUp(P_0);
		}

		protected override void OnEnabledChanged(EventArgs P_0)
		{
			if (!Enabled)
			{
				A_3 = -1;
			}
			Invalidate();
			base.OnEnabledChanged(P_0);
		}
	}
}
namespace a
{
	internal static class S
	{
		private const string A = "FileDedupTool|integrity|v";

		private static readonly Dictionary<string, string> A_1 = new Dictionary<string, string>
		{
			{
				_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.DP(),
				_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zK()
			},
			{
				_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Dp(),
				_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zk()
			},
			{
				_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lQ(),
				_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zL()
			},
			{
				_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.lq(),
				_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zl()
			}
		};

		internal static Func<string, byte[]> A_2 = a;

		internal static r A_m_1()
		{
			return A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ZX(), A_2);
		}

		internal static r A_m_1(string P_0, Func<string, byte[]> P_1)
		{
			r r2 = new r();
			if (string.IsNullOrWhiteSpace(P_0))
			{
				r2.A_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Zx();
				r2.a = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ZY();
				return r2;
			}
			if (P_1 == null)
			{
				r2.A_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Zy();
				r2.a = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ZZ();
				return r2;
			}
			string text = null;
			string text2 = null;
			List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
			string[] array = P_0.Replace(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kk(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BD()).Replace('\r', '\n').Split('\n');
			for (int num = 0; num < array.Length; num++)
			{
				string text3 = array[num].Trim();
				if (text3.Length == 0 || text3[0] == '#')
				{
					continue;
				}
				if (text3.StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Zz(), StringComparison.Ordinal))
				{
					text = text3.Substring(6).Trim();
				}
				else if (text3.StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zA(), StringComparison.Ordinal))
				{
					text2 = text3.Substring(8).Trim();
				}
				else if (text3.StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.za(), StringComparison.Ordinal))
				{
					string text4 = text3.Substring(5).Trim();
					int num2 = text4.IndexOf(' ');
					if (num2 <= 0)
					{
						r2.A_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zB();
						r2.a = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zb();
						return r2;
					}
					list.Add(new KeyValuePair<string, string>(text4.Substring(0, num2), text4.Substring(num2 + 1).Trim()));
				}
			}
			if (text == null || text2 == null || list.Count == 0)
			{
				r2.A_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zC();
				r2.a = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zc();
				return r2;
			}
			if (!string.Equals(text2, global::A.r.c, StringComparison.Ordinal))
			{
				r2.A_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zD() + text2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zd() + global::A.r.c + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zE();
				r2.a = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ze() + text2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zF() + global::A.r.c;
				return r2;
			}
			string text5 = A_m_1(text2, list);
			string text6 = A_m_1(Encoding.UTF8.GetBytes(text5));
			if (!string.Equals(text, text6, StringComparison.OrdinalIgnoreCase))
			{
				r2.A_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zf();
				r2.a = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zG();
				return r2;
			}
			List<string> list2 = new List<string>();
			List<string> list3 = new List<string>();
			foreach (KeyValuePair<string, string> item in list)
			{
				R r3 = new R
				{
					A = item.Key,
					a = A_m_1(item.Key)
				};
				byte[] array2 = null;
				try
				{
					array2 = P_1(item.Key);
				}
				catch
				{
					array2 = null;
				}
				if (array2 == null)
				{
					r3.A_1 = false;
					r3.B = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zg();
				}
				else
				{
					string text7 = A_m_1(array2);
					r3.A_1 = string.Equals(text7, item.Value, StringComparison.OrdinalIgnoreCase);
					r3.B = (r3.A_1 ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zh() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zH());
				}
				r2.A_2.Add(r3);
				if (!r3.A_1)
				{
					list2.Add(r3.a + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.IF() + r3.B + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ln());
					list3.Add(r3.A + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zI() + r3.B);
				}
			}
			r2.A = list2.Count == 0;
			if (!r2.A)
			{
				r2.A_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zi() + string.Join(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aw(), list2) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zJ();
				r2.a = string.Join(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.DG(), list3);
			}
			return r2;
		}

		private static string A_m_1(string P_0, List<KeyValuePair<string, string>> P_1)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.zj()).Append(P_0).Append('\n');
			foreach (KeyValuePair<string, string> item in P_1)
			{
				stringBuilder.Append(item.Key).Append('|').Append(item.Value.ToLowerInvariant())
					.Append('\n');
			}
			return stringBuilder.ToString();
		}

		private static string A_m_1(string P_0)
		{
			string value;
			return (A_1.TryGetValue(P_0, out value) ? value : null) ?? P_0;
		}

		private static string A_m_1(byte[] P_0)
		{
			using SHA256 sHA = SHA256.Create();
			return BitConverter.ToString(sHA.ComputeHash(P_0)).Replace(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.@as(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).ToLowerInvariant();
		}

		private static byte[] a(string P_0)
		{
			try
			{
				using Stream stream = typeof(S).Assembly.GetManifestResourceStream(P_0);
				if (stream == null)
				{
					return null;
				}
				using MemoryStream memoryStream = new MemoryStream();
				stream.CopyTo(memoryStream);
				return memoryStream.ToArray();
			}
			catch
			{
				return null;
			}
		}
	}
	internal sealed class s
	{
		[CompilerGenerated]
		private List<W> A = new List<W>();

		[CompilerGenerated]
		private List<w> A_1 = new List<w>();

		public List<W> Folders
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

		public List<w> Files
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

		public int FolderCount
		{
			get
			{
				if (Folders != null)
				{
					return Folders.Count;
				}
				return 0;
			}
		}

		public int FileCount
		{
			get
			{
				if (Files != null)
				{
					return Files.Count;
				}
				return 0;
			}
		}

		public bool IsEmpty
		{
			get
			{
				if (FolderCount == 0)
				{
					return FileCount == 0;
				}
				return false;
			}
		}
	}
}
