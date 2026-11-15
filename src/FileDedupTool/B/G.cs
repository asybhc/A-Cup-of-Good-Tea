using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007B1262ED64_002DD0A6_002D499E_002D9510_002DF2240F018DBB_007D;
using A;
using B;
using a;

namespace B
{
	internal sealed class G
	{
		public int A;

		public int a;

		public int B;

		public int b;

		public int C;

		public int c;

		public int D;

		public int d;

		internal int Processed => a + B + b + C + c + D + d;

		internal int Completed => a + B + b + C + c + D;

		internal void A_m_1(f P_0)
		{
			switch (P_0)
			{
			case f.A:
				Interlocked.Increment(ref a);
				break;
			case f.a:
				Interlocked.Increment(ref B);
				break;
			case f.B:
				Interlocked.Increment(ref b);
				break;
			case f.b:
				Interlocked.Increment(ref C);
				break;
			case f.C:
				Interlocked.Increment(ref c);
				break;
			case f.c:
				Interlocked.Increment(ref D);
				break;
			default:
				Interlocked.Increment(ref d);
				break;
			}
		}
	}
	internal static class g
	{
		[CompilerGenerated]
		private sealed class A<A_T_1>
		{
			public IReadOnlyList<A_T_1> A_f_1;

			public CancellationToken A_f_2;

			public Channel<A_T_1> A_f_3;

			public Func<A_T_1, CancellationToken, Task<f>> A_f_4;

			public G A_f_5;

			public Action<A_T_1, f, Exception> A_f_6;

			public Func<Task?> A_f_7;

			internal async Task? A_m_1()
			{
				try
				{
					foreach (A_T_1 item in A_f_1)
					{
						A_f_2.ThrowIfCancellationRequested();
						await A_f_3.Writer.WriteAsync(item, A_f_2).ConfigureAwait(continueOnCapturedContext: false);
					}
				}
				catch (OperationCanceledException)
				{
				}
				catch (ChannelClosedException)
				{
				}
				finally
				{
					A_f_3.Writer.TryComplete();
				}
			}

			internal async Task? a_m_1()
			{
				while (true)
				{
					A_T_1 item;
					try
					{
						if (!(await A_f_3.Reader.WaitToReadAsync(A_f_2).ConfigureAwait(continueOnCapturedContext: false)))
						{
							break;
						}
						if (!A_f_3.Reader.TryRead(out item))
						{
							continue;
						}
					}
					catch (OperationCanceledException)
					{
						break;
					}
					Exception arg = null;
					f f2;
					try
					{
						A_f_2.ThrowIfCancellationRequested();
						f2 = await A_f_4(item, A_f_2).ConfigureAwait(continueOnCapturedContext: false);
					}
					catch (OperationCanceledException)
					{
						f2 = f.D;
					}
					catch (Exception ex3)
					{
						f2 = f.c;
						arg = ex3;
					}
					A_f_5.A_m_1(f2);
					if (A_f_6 != null)
					{
						try
						{
							A_f_6(item, f2, arg);
						}
						catch
						{
						}
					}
					item = default;
				}
			}
		}

		internal const int A_1 = 5;

		internal static int A_m_1(int P_0, int P_1)
		{
			int num = ((P_0 < 1) ? 1 : P_0);
			if (num > 5)
			{
				num = 5;
			}
			if (P_1 > 0 && num > P_1)
			{
				num = P_1;
			}
			return num;
		}

		internal static async Task<G> A_m_1<A>(IReadOnlyList<A> P_0, int P_1, Func<A, CancellationToken, Task<f>> P_2, Action<A, f, Exception> P_3, CancellationToken P_4)
		{
			G A_f_5 = new G
			{
				A = ((P_0 != null) ? P_0.Count : 0)
			};
			if (P_0 == null || P_0.Count == 0)
			{
				return A_f_5;
			}
			if (P_2 == null)
			{
				throw new ArgumentNullException(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aNC());
			}
			int num = A_m_1(P_1, P_0.Count);
			Channel<A> A_f_6 = Channel.CreateBounded<A>(new BoundedChannelOptions(num)
			{
				SingleWriter = true,
				SingleReader = false,
				FullMode = BoundedChannelFullMode.Wait
			});
			Task task = Task.Run(async () =>
			{
				try
				{
					foreach (A item2 in P_0)
					{
						P_4.ThrowIfCancellationRequested();
						await A_f_6.Writer.WriteAsync(item2, P_4).ConfigureAwait(continueOnCapturedContext: false);
					}
				}
				catch (OperationCanceledException)
				{
				}
				catch (ChannelClosedException)
				{
				}
				finally
				{
					A_f_6.Writer.TryComplete();
				}
			});
			Task[] array = new Task[num];
			for (int num2 = 0; num2 < num; num2++)
			{
				array[num2] = Task.Run(async () =>
				{
					while (true)
					{
						A item;
						try
						{
							if (!(await A_f_6.Reader.WaitToReadAsync(P_4).ConfigureAwait(continueOnCapturedContext: false)))
							{
								break;
							}
							if (!A_f_6.Reader.TryRead(out item))
							{
								continue;
							}
						}
						catch (OperationCanceledException)
						{
							break;
						}
						Exception arg = null;
						f f2;
						try
						{
							P_4.ThrowIfCancellationRequested();
							f2 = await P_2(item, P_4).ConfigureAwait(continueOnCapturedContext: false);
						}
						catch (OperationCanceledException)
						{
							f2 = f.D;
						}
						catch (Exception ex3)
						{
							f2 = f.c;
							arg = ex3;
						}
						A_f_5.A_m_1(f2);
						if (P_3 != null)
						{
							try
							{
								P_3(item, f2, arg);
							}
							catch
							{
							}
						}
						item = default;
					}
				});
			}
			await Task.WhenAll(array).ConfigureAwait(continueOnCapturedContext: false);
			await task.ConfigureAwait(continueOnCapturedContext: false);
			int num3 = A_f_5.A - A_f_5.Processed;
			if (num3 > 0)
			{
				Interlocked.Add(ref A_f_5.d, num3);
			}
			return A_f_5;
		}
	}
}
namespace b
{
	internal static class G
	{
		internal static Func<string, bool> A;

		internal static bool A_m_1(IWin32Window P_0, string P_1, string P_2)
		{
			return a(P_0, P_1, P_2).A;
		}

		internal static global::a.I a(IWin32Window P_0, string P_1, string P_2)
		{
			int num = global::a.i.A_m_1(P_1);
			if (!global::a.j.A_m_1(P_0, P_1, P_2))
			{
				return global::a.I.A_m_1(num);
			}
			if (!global::a.j.Pro)
			{
				bool flag;
				if (A != null)
				{
					flag = A(P_1);
				}
				else
				{
					string caption = (global::a.Q.EnMode ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJF() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJe());
					string text = (global::a.Q.EnMode ? (P_2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJG()) : (P_1 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJf()));
					flag = MessageBox.Show(P_0, text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes;
				}
				if (!flag)
				{
					return global::a.I.A_m_1(num);
				}
				if (!global::a.j.a_m_1(P_0))
				{
					return global::a.I.A_m_1(num);
				}
			}
			if (!global::a.j.A_m_1(out var num2))
			{
				return global::a.I.A_m_1(num);
			}
			return new global::a.I(true, global::a.i.A_m_1(num, num2), num);
		}

		internal static global::a.I B(IWin32Window P_0, string P_1, string P_2)
		{
			int num = global::a.i.A_m_1(P_1);
			if (!global::a.j.A_m_1(P_0, P_1, P_2))
			{
				return global::a.I.A_m_1(num);
			}
			if (!global::a.j.A_m_1(out var num2))
			{
				return global::a.I.A_m_1(num);
			}
			return new global::a.I(true, global::a.i.A_m_1(num, num2), num);
		}
	}
	internal static class g
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class A
		{
			public static readonly A A_f_1 = new A();

			public static Func<string, bool> A_f_2;

			public static Func<string, bool> a;

			public static Func<string, bool> B;

			public static Func<string, bool> b;

			public static Func<string, bool> C;

			public static Func<string, bool> c;

			public static Func<string, bool> D;

			public static Func<string, bool> d;

			public static ThreadExceptionEventHandler A_f_3;

			internal bool A_m_1(string P_0)
			{
				return string.Equals(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Hl(), StringComparison.OrdinalIgnoreCase);
			}

			internal bool a_m_1(string P_0)
			{
				return string.Equals(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJq(), StringComparison.OrdinalIgnoreCase);
			}

			internal bool B_m_1(string P_0)
			{
				return string.Equals(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.HL(), StringComparison.OrdinalIgnoreCase);
			}

			internal bool b_m_1(string P_0)
			{
				if (!string.Equals(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anI(), StringComparison.OrdinalIgnoreCase))
				{
					return string.Equals(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ani(), StringComparison.Ordinal);
				}
				return true;
			}

			internal bool C_m_1(string P_0)
			{
				if (!string.Equals(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.HQ(), StringComparison.OrdinalIgnoreCase) && !string.Equals(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.HU(), StringComparison.OrdinalIgnoreCase))
				{
					return P_0.StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anJ(), StringComparison.OrdinalIgnoreCase);
				}
				return true;
			}

			internal bool c_m_1(string P_0)
			{
				return string.Equals(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anj(), StringComparison.OrdinalIgnoreCase);
			}

			internal bool D_m_1(string P_0)
			{
				return string.Equals(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anK(), StringComparison.OrdinalIgnoreCase);
			}

			internal bool d_m_1(string P_0)
			{
				if (!string.Equals(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.HO(), StringComparison.OrdinalIgnoreCase) && !string.Equals(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Hq(), StringComparison.Ordinal))
				{
					return string.Equals(P_0, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.HR(), StringComparison.Ordinal);
				}
				return true;
			}

			internal void A_m_1(object P_0, ThreadExceptionEventArgs P_1)
			{
				MessageBox.Show(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ank() + P_1.Exception.Message, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.or(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		[CompilerGenerated]
		private sealed class a
		{
			public EventWaitHandle A;

			public global::B.Q A_1;

			internal void A_m_1()
			{
				while (true)
				{
					try
					{
						A.WaitOne();
					}
					catch
					{
						break;
					}
					try
					{
						if (A_1.IsHandleCreated)
						{
							A_1.BeginInvoke(A_1.z);
						}
					}
					catch
					{
					}
				}
			}
		}

		[CompilerGenerated]
		private sealed class B
		{
			public string[] A;

			public bool A_1;

			internal string A_m_1(ref b P_0)
			{
				if (P_0.A + 1 >= A.Length)
				{
					return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
				}
				return A[++P_0.A];
			}

			internal void A_m_1(string P_0)
			{
				try
				{
					if (A_1)
					{
						Console.Error.WriteLine(P_0);
					}
					else
					{
						Console.WriteLine(P_0);
					}
				}
				catch
				{
				}
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct b
		{
			public int A;
		}

		[CompilerGenerated]
		private sealed class C
		{
			public ManualResetEventSlim A;

			internal void A_m_1(object P_0, ConsoleCancelEventArgs P_1)
			{
				P_1.Cancel = true;
				A.Set();
			}
		}

		private const string A_1 = "Local\\FileDedupTool.SingleInstance";

		private const string a_1 = "Local\\FileDedupTool.ShowWindow";

		private static Mutex A_2;

		[STAThread]
		private static void Main(string[] P_0)
		{
			bool flag = P_0?.Any((string text3) => string.Equals(text3, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Hl(), StringComparison.OrdinalIgnoreCase)) ?? false;
			bool flag2 = P_0?.Any((string text3) => string.Equals(text3, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJq(), StringComparison.OrdinalIgnoreCase)) ?? false;
			bool flag3 = P_0?.Any((string text3) => string.Equals(text3, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.HL(), StringComparison.OrdinalIgnoreCase)) ?? false;
			if (P_0 != null && P_0.Any((string text3) => string.Equals(text3, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anI(), StringComparison.OrdinalIgnoreCase) || string.Equals(text3, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ani(), StringComparison.Ordinal)))
			{
				Console.Out.WriteLine(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.abD() + global::A.r.TitleSuffix);
				Environment.Exit(0);
				return;
			}
			if (P_0 != null && P_0.Any((string text3) => string.Equals(text3, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.HQ(), StringComparison.OrdinalIgnoreCase) || string.Equals(text3, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.HU(), StringComparison.OrdinalIgnoreCase) || text3.StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anJ(), StringComparison.OrdinalIgnoreCase)))
			{
				flag = true;
			}
			if (flag3)
			{
				flag = true;
			}
			if (P_0 != null && P_0.Any((string text3) => string.Equals(text3, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anj(), StringComparison.OrdinalIgnoreCase)))
			{
				string text = null;
				for (int num = 0; num < P_0.Length; num++)
				{
					if (string.Equals(P_0[num], _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Hj(), StringComparison.OrdinalIgnoreCase) && num + 1 < P_0.Length)
					{
						text = P_0[++num];
					}
					else if (P_0[num].StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJg(), StringComparison.OrdinalIgnoreCase))
					{
						text = P_0[num].Substring(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJg().Length);
					}
				}
				bool flag4 = string.Equals(text, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Hk(), StringComparison.OrdinalIgnoreCase);
				using (StreamWriter streamWriter = new StreamWriter(Console.OpenStandardOutput(), new UTF8Encoding(encoderShouldEmitUTF8Identifier: false)))
				{
					streamWriter.Write(global::a.N.C(flag4));
					streamWriter.Write('\n');
				}
				Environment.Exit(0);
				return;
			}
			if (P_0 != null && P_0.Any((string text3) => string.Equals(text3, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.anK(), StringComparison.OrdinalIgnoreCase)))
			{
				global::a.r r2 = global::a.S.A_m_1();
				using (StreamWriter streamWriter2 = new StreamWriter(Console.OpenStandardOutput(), new UTF8Encoding(encoderShouldEmitUTF8Identifier: false)))
				{
					streamWriter2.Write((r2.A ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.IK() : (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJH() + r2.a)) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BD());
				}
				try
				{
					global::B.p.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJh() + (r2.A ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJI() : r2.a));
				}
				catch
				{
				}
				Environment.Exit((!r2.A) ? 1 : 0);
				return;
			}
			global::a.j.a_m_1();
			if (P_0 != null && P_0.Any((string text3) => string.Equals(text3, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.HO(), StringComparison.OrdinalIgnoreCase) || string.Equals(text3, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Hq(), StringComparison.Ordinal) || string.Equals(text3, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.HR(), StringComparison.Ordinal)))
			{
				global::A.U.A_m_1(flag3);
				Environment.Exit(0);
				return;
			}
			if (flag2)
			{
				Environment.Exit(A_m_1(P_0, flag3));
				return;
			}
			if (flag)
			{
				if (!global::a.j.Authorized)
				{
					string text2 = ((global::a.j.Current == null) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJi() : global::a.j.Current.a);
					global::A.U.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cl(), text2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJJ() + global::B.J.Formatted, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJj(), flag3);
					Environment.Exit(5);
				}
				if (!global::a.j.Pro)
				{
					global::A.U.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJK(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJk(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJj(), flag3);
					Environment.Exit(6);
				}
				Environment.Exit(global::A.U.A_m_1(P_0));
			}
			Mutex a_ = new Mutex(initiallyOwned: true, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJL(), out var createdNew);
			if (!createdNew)
			{
				try
				{
					using EventWaitHandle eventWaitHandle = EventWaitHandle.OpenExisting(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJl());
					eventWaitHandle.Set();
					return;
				}
				catch
				{
					return;
				}
			}
			A_2 = a_;
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(defaultValue: false);
			try
			{
				Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
			}
			catch
			{
			}
			Application.ThreadException += (object obj4, ThreadExceptionEventArgs e2) =>
			{
				MessageBox.Show(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ank() + e2.Exception.Message, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.or(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
			};
			// C-10：async void 与后台线程抛出的异常不会走 ThreadException，这里补两层兜底，
			// 统一写日志，避免进程静默崩溃或事件被吞掉。
			Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
			AppDomain.CurrentDomain.UnhandledException += delegate(object obj4, UnhandledExceptionEventArgs e2)
			{
				try
				{
					global::B.p.a_m_1("未处理异常：" + e2.ExceptionObject);
				}
				catch
				{
				}
			};
			TaskScheduler.UnobservedTaskException += delegate(object obj4, UnobservedTaskExceptionEventArgs e2)
			{
				try
				{
					global::B.p.a_m_1("未观察的任务异常：" + e2.Exception);
					e2.SetObserved();
				}
				catch
				{
				}
			};
			if (global::a.j.IntegrityFailed && !string.IsNullOrEmpty(global::a.j.IntegrityMessage))
			{
				MessageBox.Show(global::a.j.IntegrityMessage + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJM(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJm(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			if (global::a.j.ShouldShowTrialNotice)
			{
				global::a.j.c();
				string caption = (global::a.Q.EnMode ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJn() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJN());
				if (MessageBox.Show(global::a.Q.EnMode ? (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJP() + global::B.J.Formatted + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJp()) : (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJO() + global::B.J.Formatted + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJo()), caption, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
				{
					using global::B.l l2 = new global::B.l(false, false, global::a.j.A_m_1((string)null), global::a.j.a_m_1((string)null));
					l2.ShowDialog();
				}
			}
			global::B.Q q2 = new global::B.Q();
			A_m_1(q2);
			Application.Run(q2);
		}

		private static void A_m_1(global::B.Q P_0)
		{
			EventWaitHandle A;
			try
			{
				A = new EventWaitHandle(initialState: false, EventResetMode.AutoReset, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJl());
			}
			catch
			{
				return;
			}
			Thread thread = new Thread(() =>
			{
				while (true)
				{
					try
					{
						A.WaitOne();
					}
					catch
					{
						break;
					}
					try
					{
						if (P_0.IsHandleCreated)
						{
							P_0.BeginInvoke(P_0.z);
						}
					}
					catch
					{
					}
				}
			});
			thread.IsBackground = true;
			thread.Name = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJQ();
			thread.Start();
		}

		private static int A_m_1(string[] P_0, bool P_1)
		{
			B CS_0024_003C_003E8__locals13 = new B();
			CS_0024_003C_003E8__locals13.A = P_0;
			CS_0024_003C_003E8__locals13.A_1 = P_1;
			string text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.cj();
			int num = 8731;
			string text2 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			try
			{
				b b2 = default;
				b2.A = 0;
				while (b2.A < CS_0024_003C_003E8__locals13.A.Length)
				{
					string text3 = CS_0024_003C_003E8__locals13.A[b2.A];
					string text4 = text3.ToLowerInvariant();
					if (!(text4 == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJq()))
					{
						if (!(text4 == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJR()))
						{
							if (!(text4 == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJr()))
							{
								if (text4 == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJS())
								{
									text2 = CS_0024_003C_003E8__locals13.A_m_1(ref b2);
								}
								else if (text3.StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJU(), StringComparison.OrdinalIgnoreCase))
								{
									global::A.U.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.hj() + text3, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.hK(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJt(), CS_0024_003C_003E8__locals13.A_1);
									return 2;
								}
							}
							else
							{
								if (!int.TryParse(CS_0024_003C_003E8__locals13.A_m_1(ref b2), out var result) || result < 1 || result > 65535)
								{
									global::A.U.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJs(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJT(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJt(), CS_0024_003C_003E8__locals13.A_1);
									return 2;
								}
								num = result;
							}
						}
						else
						{
							text = CS_0024_003C_003E8__locals13.A_m_1(ref b2);
						}
					}
					b2.A++;
				}
			}
			catch
			{
				return 2;
			}
			if (text2.Length == 0)
			{
				string environmentVariable = Environment.GetEnvironmentVariable(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJu());
				if (!string.IsNullOrEmpty(environmentVariable))
				{
					text2 = environmentVariable;
				}
			}
			if (!global::a.j.Authorized)
			{
				global::A.U.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cl(), ((global::a.j.Current == null) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJi() : global::a.j.Current.a) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJJ() + global::B.J.Formatted, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJt(), CS_0024_003C_003E8__locals13.A_1);
				return 5;
			}
			if (!global::a.j.Pro)
			{
				global::A.U.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJK(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJV(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJt(), CS_0024_003C_003E8__locals13.A_1);
				return 6;
			}
			global::A.q q2;
			try
			{
				string text5 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
				try
				{
					text5 = global::A.Y.A_m_1().AllowedApiDirectories ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
				}
				catch
				{
				}
				q2 = new global::A.q(text, num, text2, text5);
				q2.A_m_1();
			}
			catch (Exception ex)
			{
				global::A.U.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJv(), ex.Message, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJt(), CS_0024_003C_003E8__locals13.A_1);
				return 4;
			}
			using (q2)
			{
				Action<string> action = (string value) =>
				{
					try
					{
						if (CS_0024_003C_003E8__locals13.A_1)
						{
							Console.Error.WriteLine(value);
						}
						else
						{
							Console.WriteLine(value);
						}
					}
					catch
					{
					}
				};
				try
				{
					action(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJW());
					action(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJw() + q2.BaseUrl);
					if (q2.TokenAutoGenerated)
					{
						action(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJX());
						action(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJx() + q2.Token);
						action(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJY());
					}
					else
					{
						action(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJy());
					}
					action(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJZ() + global::a.j.StatusText);
					action(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aJz() + q2.BaseUrl + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.cT());
					action(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ajA());
				}
				catch
				{
				}
				ManualResetEventSlim A = new ManualResetEventSlim(initialState: false);
				Console.CancelKeyPress += (object obj6, ConsoleCancelEventArgs e2) =>
				{
					e2.Cancel = true;
					A.Set();
				};
				try
				{
					A.Wait();
				}
				catch
				{
				}
				try
				{
					Console.WriteLine(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aja());
				}
				catch
				{
				}
				q2.a_m_1();
			}
			return 0;
		}
	}
}
