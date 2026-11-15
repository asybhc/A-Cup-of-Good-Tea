using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using _003CPrivateImplementationDetails_003E_007B1262ED64_002DD0A6_002D499E_002D9510_002DF2240F018DBB_007D;
using A;
using B;
using C;
using b;

namespace A
{
	public static class H
	{
		private sealed class A
		{
			public bool A_f_1;

			public int A_f_2;

			public string A_f_3 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

			public int a;
		}

		public const int A_1 = 15;

		public const string A_2 = "ping";

		public static g A_m_1(x P_0)
		{
			string text = ((P_0 == null) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D() : (P_0.AiBaseUrl ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).Trim());
			string value = ((P_0 == null) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D() : (P_0.AiModel ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).Trim());
			int num = P_0?.AiTimeoutSec ?? 15;
			if (num <= 0)
			{
				num = 15;
			}
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aB(), value);
			dictionary.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ac(), new object[1]
			{
				new Dictionary<string, string>
				{
					{
						_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aD(),
						_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ae()
					},
					{
						_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aE(),
						_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bV()
					}
				}
			});
			dictionary.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bv(), 1);
			dictionary.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ab(), 0);
			dictionary.Add(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aC(), false);
			Dictionary<string, object> value2 = dictionary;
			return new g
			{
				A = E.A_m_1(text),
				a = A_m_1(text),
				B = JsonSerializer.Serialize(value2),
				b = value,
				A_1 = num
			};
		}

		public static string A_m_1(string P_0)
		{
			string text = (P_0 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).Trim().TrimEnd('/');
			if (text.Length == 0)
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}
			if (text.EndsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.H(), StringComparison.OrdinalIgnoreCase))
			{
				text = text.Substring(0, text.Length - _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.H().Length).TrimEnd('/');
			}
			if (text.EndsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bW(), StringComparison.OrdinalIgnoreCase))
			{
				return text;
			}
			return text + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bW();
		}

		public static string a_m_1(string P_0)
		{
			string text = (P_0 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).Trim();
			if (text.Length == 0)
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}
			if (text.Length >= 12)
			{
				return text.Substring(0, 4) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.j() + text.Substring(text.Length - 4);
			}
			if (text.Length > 8)
			{
				return text.Substring(0, 2) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.j() + text.Substring(text.Length - 2);
			}
			return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bw();
		}

		public static string A_m_1(string P_0, string P_1)
		{
			if (P_0 == null)
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}
			string text = (P_1 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).Trim();
			if (text.Length == 0)
			{
				return P_0;
			}
			return P_0.Replace(text, a_m_1(text));
		}

		public static string A_m_1(string P_0, int P_1)
		{
			if (P_0 == null)
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}
			if (P_1 <= 0)
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}
			if (P_0.Length > P_1)
			{
				return P_0.Substring(0, P_1);
			}
			return P_0;
		}

		public static f A_m_1(int P_0)
		{
			if (P_0 == 401 || P_0 == 403)
			{
				return f.B;
			}
			if (P_0 == 404)
			{
				return f.b;
			}
			if (P_0 == 429)
			{
				return f.C;
			}
			if (P_0 == 408)
			{
				return f.d;
			}
			if (P_0 >= 500)
			{
				return f.c;
			}
			if (P_0 >= 400)
			{
				return f.D;
			}
			return f.f_f_1;
		}

		public static string a_m_1(int P_0)
		{
			return A_m_1(P_0) switch
			{
				f.B => _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bX(), 
				f.b => _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bx(), 
				f.C => _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bY(), 
				f.d => _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.by(), 
				f.c => _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bZ(), 
				f.D => _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bz(), 
				_ => _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CA(), 
			};
		}

		public static G A_m_1(Exception P_0, bool P_1, int P_2, string P_3, string P_4)
		{
			G g2 = new G
			{
				B_1 = P_2,
				b = (P_4 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D())
			};
			if (P_1)
			{
				g2.A_1 = f.F;
				g2.a_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bF();
				return g2;
			}
			if (P_0 is OperationCanceledException)
			{
				g2.A_1 = f.d;
				g2.a_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.by();
				return g2;
			}
			if (P_0 is HttpRequestException)
			{
				if (A_m_1(P_0))
				{
					g2.A_1 = f.E;
					g2.a_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ca();
				}
				else
				{
					g2.A_1 = f.e;
					g2.a_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CB();
				}
				g2.B = A_m_1(A_m_1(P_0.Message, P_3), 200);
				return g2;
			}
			g2.A_1 = f.f_f_1;
			g2.a_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bd();
			g2.B = A_m_1(A_m_1((P_0 == null) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D() : P_0.Message, P_3), 200);
			return g2;
		}

		private static bool A_m_1(Exception P_0)
		{
			Exception ex = P_0;
			int num = 0;
			while (ex != null && num < 6)
			{
				if (ex is AuthenticationException)
				{
					return true;
				}
				string text = ex.Message ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
				if (text.IndexOf(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cb(), StringComparison.OrdinalIgnoreCase) >= 0 || text.IndexOf(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CC(), StringComparison.OrdinalIgnoreCase) >= 0 || text.IndexOf(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cc(), StringComparison.OrdinalIgnoreCase) >= 0 || text.IndexOf(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CD(), StringComparison.Ordinal) >= 0 || text.IndexOf(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cd(), StringComparison.Ordinal) >= 0)
				{
					return true;
				}
				ex = ex.InnerException;
				num++;
			}
			return false;
		}

		public static async Task<G> A_m_1(x P_0, CancellationToken P_1)
		{
			int num = P_0?.AiTimeoutSec ?? 15;
			if (num <= 0)
			{
				num = 15;
			}
			G g2 = new G
			{
				B_1 = num
			};
			string text = ((P_0 == null) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D() : (P_0.AiBaseUrl ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).Trim());
			string text2 = ((P_0 == null) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D() : (P_0.AiApiKey ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).Trim());
			if (text.Length == 0 || text2.Length == 0)
			{
				g2.A_1 = f.a;
				g2.a_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.pN();
				A_m_1(g2);
				return g2;
			}
			if (!text.StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bb(), StringComparison.OrdinalIgnoreCase) && !text.StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bC(), StringComparison.OrdinalIgnoreCase))
			{
				g2.A_1 = f.a;
				g2.a_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.pU();
				g2.B = A_m_1(text, 200);
				A_m_1(g2);
				return g2;
			}
			g g3 = A_m_1(P_0);
			g2.B_1 = g3.A_1;
			g2.A_3 = g3.b;
			Stopwatch stopwatch = Stopwatch.StartNew();
			string text3 = g3.A;
			try
			{
				if (g3.b.Length > 0)
				{
					g2.b = g3.A;
					A a2 = await A_m_1(HttpMethod.Post, g3.A, g3.B, text2, g3.A_1, P_1).ConfigureAwait(continueOnCapturedContext: false);
					g2.A_2 = a2.a;
					g2.a = a2.A_f_2;
					g2.B = A_m_1(A_m_1(a2.A_f_3, text2), 200);
					if (a2.A_f_1)
					{
						g2.A = true;
						g2.A_3 = a_m_1(a2.A_f_3, g3.b);
						A_m_1(g2);
						return g2;
					}
					if (a2.A_f_2 != 400 && a2.A_f_2 != 404 && a2.A_f_2 != 405 && a2.A_f_2 != 501)
					{
						g2.A_1 = A_m_1(a2.A_f_2);
						g2.a_1 = a_m_1(a2.A_f_2);
						A_m_1(g2);
						return g2;
					}
				}
				text3 = g3.a;
				g2.b = g3.a;
				A a3 = await A_m_1(HttpMethod.Get, g3.a, null, text2, g3.A_1, P_1).ConfigureAwait(continueOnCapturedContext: false);
				g2.A_2 = a3.a;
				g2.a = a3.A_f_2;
				g2.B = A_m_1(A_m_1(a3.A_f_3, text2), 200);
				if (a3.A_f_1)
				{
					g2.A = true;
					g2.a_2 = true;
					g2.A_3 = ((g3.b.Length > 0) ? g3.b : B_m_1(a3.A_f_3));
					A_m_1(g2);
					return g2;
				}
				g2.A_1 = A_m_1(a3.A_f_2);
				g2.a_1 = a_m_1(a3.A_f_2);
				A_m_1(g2);
				return g2;
			}
			catch (OperationCanceledException)
			{
				stopwatch.Stop();
				g2.A_2 = (int)stopwatch.ElapsedMilliseconds;
				if (P_1.IsCancellationRequested)
				{
					g2.A_1 = f.F;
					g2.a_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bF();
				}
				else
				{
					g2.A_1 = f.d;
					g2.a_1 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.by();
				}
				A_m_1(g2);
				return g2;
			}
			catch (Exception ex2)
			{
				stopwatch.Stop();
				G g4 = A_m_1(ex2, false, g3.A_1, text2, text3);
				g4.A_2 = (int)stopwatch.ElapsedMilliseconds;
				A_m_1(g4);
				return g4;
			}
		}

		private static async Task<A> A_m_1(HttpMethod P_0, string P_1, string P_2, string P_3, int P_4, CancellationToken P_5)
		{
			using CancellationTokenSource cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(P_5);
			cancellationTokenSource.CancelAfter(TimeSpan.FromSeconds(P_4));
			using HttpRequestMessage httpRequestMessage = new HttpRequestMessage(P_0, P_1);
			if (P_2 != null)
			{
				httpRequestMessage.Content = new StringContent(P_2, Encoding.UTF8, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aF());
			}
			httpRequestMessage.Headers.TryAddWithoutValidation(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.af(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aG() + P_3);
			Stopwatch stopwatch = Stopwatch.StartNew();
			using HttpResponseMessage httpResponseMessage = await E.A_1.SendAsync(httpRequestMessage, cancellationTokenSource.Token).ConfigureAwait(continueOnCapturedContext: false);
			string text = await httpResponseMessage.Content.ReadAsStringAsync(cancellationTokenSource.Token).ConfigureAwait(continueOnCapturedContext: false);
			stopwatch.Stop();
			return new A
			{
				A_f_1 = httpResponseMessage.IsSuccessStatusCode,
				A_f_2 = (int)httpResponseMessage.StatusCode,
				A_f_3 = (text ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()),
				a = (int)stopwatch.ElapsedMilliseconds
			};
		}

		private static string a_m_1(string P_0, string P_1)
		{
			try
			{
				using JsonDocument jsonDocument = JsonDocument.Parse(P_0 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
				if (jsonDocument.RootElement.TryGetProperty(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aB(), out var value) && value.ValueKind == JsonValueKind.String)
				{
					string text = value.GetString();
					if (!string.IsNullOrWhiteSpace(text))
					{
						return text.Trim();
					}
				}
			}
			catch
			{
			}
			return P_1 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
		}

		private static string B_m_1(string P_0)
		{
			try
			{
				using JsonDocument jsonDocument = JsonDocument.Parse(P_0 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
				if (jsonDocument.RootElement.TryGetProperty(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CE(), out var value) && value.ValueKind == JsonValueKind.Array && value.GetArrayLength() > 0 && value[0].TryGetProperty(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ce(), out var value2) && value2.ValueKind == JsonValueKind.String)
				{
					return (value2.GetString() ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).Trim();
				}
			}
			catch
			{
			}
			return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
		}

		public static void A_m_1(G P_0)
		{
			if (P_0 != null)
			{
				string text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CF() + (P_0.A ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CG() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cf()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Cg() + Math.Max(0, P_0.A_2) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CH() + ((P_0.a > 0) ? P_0.a.ToString() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bE()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ch() + (string.IsNullOrWhiteSpace(P_0.A_3) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bE() : P_0.A_3);
				if (P_0.A)
				{
					global::B.p.A_m_1(text);
				}
				else
				{
					global::B.p.a_m_1(text);
				}
			}
		}
	}
	public static class h
	{
		public static readonly string A = r.c;

		public static readonly JsonSerializerOptions A_1 = new JsonSerializerOptions
		{
			PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
			DictionaryKeyPolicy = null,
			DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
			WriteIndented = false,
			Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
		};

		public static readonly JsonSerializerOptions a = new JsonSerializerOptions
		{
			PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
			DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
			WriteIndented = true,
			Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
		};

		public static string A_m_1(object P_0)
		{
			return JsonSerializer.Serialize(P_0, A_1);
		}

		public static string a_m_1(object P_0)
		{
			return JsonSerializer.Serialize(P_0, a);
		}
	}
}
namespace a
{
	public sealed class H : Form
	{
		private sealed class A
		{
			public bool A_f_1;

			public global::a.c A_f_2;

			public global::a.C A_f_3;

			public int A_f_4;
		}

		private sealed class a
		{
			public global::a.c A;

			public List<Tuple<global::a.C, int>> A_1;

			public string A_2 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();

			public long A_3;

			public long a_f_1;
		}

		private sealed class B : CheckBox
		{
			private readonly global::b.Y A;

			private bool A_1;

			public B(global::b.Y P_0)
			{
				A = P_0;
				SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
				AutoSize = false;
				Size = new Size(26, 26);
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}

			protected override void OnMouseEnter(EventArgs P_0)
			{
				A_1 = true;
				Invalidate();
				base.OnMouseEnter(P_0);
			}

			protected override void OnMouseLeave(EventArgs P_0)
			{
				A_1 = false;
				Invalidate();
				base.OnMouseLeave(P_0);
			}

			protected override void OnEnabledChanged(EventArgs P_0)
			{
				Invalidate();
				base.OnEnabledChanged(P_0);
			}

			protected override void OnPaint(PaintEventArgs P_0)
			{
				Graphics graphics = P_0.Graphics;
				graphics.SmoothingMode = SmoothingMode.AntiAlias;
				Color color = BackColor;
				if (color == Color.Transparent)
				{
					color = ((Parent != null) ? Parent.BackColor : A.a);
				}
				using (SolidBrush brush = new SolidBrush(color))
				{
					graphics.FillRectangle(brush, ClientRectangle);
				}
				int num = (Width - 20) / 2;
				int num2 = (Height - 20) / 2;
				Color color2;
				if (Enabled)
				{
					color2 = (A_1 ? A.f : A.d);
				}
				else
				{
					color2 = A.B;
				}
				using (Pen pen = new Pen(color2))
				{
					graphics.DrawRectangle(pen, num, num2, 19, 19);
				}
				if (Checked)
				{
					using Pen pen2 = new Pen(Enabled ? A.j : A.I, 2.2f);
					graphics.DrawLine(pen2, num + 4, num2 + 10, num + 8, num2 + 15);
					graphics.DrawLine(pen2, num + 8, num2 + 15, num + 16, num2 + 4);
				}
				if (Focused && ShowFocusCues)
				{
					ControlPaint.DrawFocusRectangle(graphics, ClientRectangle);
				}
			}
		}

		[Serializable]
		[CompilerGenerated]
		private sealed class b
		{
			public static readonly b A = new b();

			public static Comparison<a> A_1;

			public static Comparison<a> a;

			public static Comparison<a> B;

			public static Comparison<a> b_f_1;

			internal int A_m_1(a P_0, a P_1)
			{
				return P_0.A.A_1.CompareTo(P_1.A.A_1);
			}

			internal int a_m_1(a P_0, a P_1)
			{
				return string.Compare(P_0.A_2, P_1.A_2, StringComparison.OrdinalIgnoreCase);
			}

			internal int B_m_1(a P_0, a P_1)
			{
				return P_0.A_3.CompareTo(P_1.A_3);
			}

			internal int b_m_1(a P_0, a P_1)
			{
				return P_0.a_f_1.CompareTo(P_1.a_f_1);
			}
		}

		[CompilerGenerated]
		private sealed class C
		{
			public List<global::a.c> A;

			public HashSet<global::a.C> A_1;

			public bool A_2;

			public CancellationToken A_3;

			public H A_4;

			public Func<global::a.C, bool> A_5;

			internal global::a.d A_m_1()
			{
				return global::a.e.A_m_1(A, (global::a.C P_0) => P_0.A_3 && A_1.Contains(P_0), A_2, A_3);
			}

			internal bool A_m_1(global::a.C P_0)
			{
				if (P_0.A_3)
				{
					return A_1.Contains(P_0);
				}
				return false;
			}

			internal void A_m_1(Task<global::a.d> t)
			{
				A_4.a_5 = false;
				A_4.Cursor = Cursors.Default;
				global::a.d result = t.Result;
				if (result == null || !result.A)
				{
					string text = ((result == null) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D() : (result.A_1 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()));
					if (result != null && result.A_4.Count > 0)
					{
						text = string.Join(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kk(), result.A_4.Take(5));
					}
					MessageBox.Show(A_4, Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Zo()) + text, A_4.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				else
				{
					A_4.A_25 = result.a_1;
					string text2 = ((result.a > 0) ? Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.yH(), result.A_2, result.a, global::a.h.A_m_1(result.A_3)) : Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Zp(), result.A_2, global::a.h.A_m_1(result.A_3)));
					if (result.A_4.Count > 0)
					{
						text2 = text2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kk() + Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Zq()) + string.Join(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.DG(), result.A_4.Take(5));
					}
					MessageBox.Show(A_4, text2, A_4.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				foreach (global::a.C item in A_1)
				{
					if (!File.Exists(global::a.a.A(item.A)))
					{
						item.A_3 = false;
					}
				}
				A_4.A_11.Invalidate();
				A_4.l();
				A_4.M();
			}
		}

		[CompilerGenerated]
		private sealed class c
		{
			public string A;

			public H A_1;

			internal global::B.w.A A_m_1()
			{
				return global::B.w.A_m_1(A, true, CancellationToken.None);
			}

			internal void A_m_1(Task<global::B.w.A> t)
			{
				A_1.Cursor = Cursors.Default;
				global::B.w.A result = t.Result;
				if (result == null)
				{
					MessageBox.Show(A_1, Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Zt()), A_1.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				string text = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.yI(), result.D, result.f);
				MessageBox.Show(A_1, text + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKU() + result.ToString(), A_1.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				foreach (global::a.c item in A_1.A_12)
				{
					foreach (global::a.C item2 in item.A_2)
					{
						if (item2.A_3 && File.Exists(global::a.a.A(item2.A)))
						{
							item2.A_3 = false;
						}
					}
				}
				A_1.A_11.Invalidate();
				A_1.l();
				A_1.M();
			}
		}

		[CompilerGenerated]
		private sealed class D
		{
			public G A;

			public B A_1;

			public H A_2;

			internal void A_m_1(object? _003Cp0_003E, EventArgs P_1)
			{
				if (A.A_2)
				{
					A_1.Checked = !A_1.Checked;
				}
			}

			internal void a(object? _003Cp0_003E, EventArgs P_1)
			{
				A_2.f();
			}
		}

		[CompilerGenerated]
		private sealed class d
		{
			public E A;

			public H A_1;

			public CancellationToken A_2;

			internal void A_m_1()
			{
				A.A_m_1(A_1.A_m_1, A_2);
			}

			internal void A_m_1(Task P_0)
			{
				A_1.A_m_1(P_0);
			}
		}

		private readonly global::b.Y A_1;

		private readonly global::A.x A_2;

		private TableLayoutPanel A_3;

		private readonly List<Tuple<G, CheckBox>> A_4 = new List<Tuple<G, CheckBox>>();

		private Label A_5;

		private Button A_6;

		private Button a_1;

		private CheckBox A_7;

		private CheckBox a_2;

		private CheckBox B_1;

		private CheckBox b_1;

		private NumericUpDown A_8;

		private Label a_3;

		private Label B_2;

		private Button B_3;

		private Button b_2;

		private Button C_1;

		private Button c_1;

		private Button D_1;

		private Button d_1;

		private Button E;

		private Button e;

		private Label b_3;

		private Label C_2;

		private Label c_2;

		private Label D_2;

		private ProgressBar A_9;

		private TextBox A_10;

		private NumericUpDown a_4;

		private DataGridView A_11;

		private List<global::a.c> A_12 = new List<global::a.c>();

		private List<A> A_13 = new List<A>();

		private string[] A_14 = new string[0];

		private E A_15;

		private CancellationTokenSource A_16;

		private Task A_17;

		private bool A_18;

		private bool a_5;

		private readonly object A_19 = new object();

		private global::a.D A_20;

		private readonly System.Windows.Forms.Timer A_21;

		private readonly System.Windows.Forms.Timer a_6;

		private long A_22;

		private int A_23;

		private TimeSpan A_24;

		private string A_25;

		private bool B_4;

		private int a_7 = -1;

		private bool b_4 = true;

		internal static Func<int, long, bool> A_26;

		internal static Func<IEnumerable<G>> A_27;

		internal static Func<global::b.C, bool> A_28;

		public H(global::b.Y P_0, global::A.x P_1)
		{
			A_1 = P_0 ?? global::b.Y.A_m_1();
			A_2 = P_1 ?? new global::A.x();
			Text = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jP());
			StartPosition = FormStartPosition.CenterParent;
			Icon = global::A.R.App;
			Font = global::B.Q.A_m_1(10f);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1180, 760);
			MinimumSize = new Size(900, 560);
			BackColor = P_0.A;
			ForeColor = P_0.b;
			ShowInTaskbar = false;
			A_21 = new System.Windows.Forms.Timer
			{
				Interval = 300
			};
			A_21.Tick += delegate
			{
				a_m_1(I());
			};
			a_6 = new System.Windows.Forms.Timer
			{
				Interval = 450
			};
			a_6.Tick += delegate
			{
				a_6.Stop();
				L();
			};
			A_m_1();
			d_m_1();
			g();
			global::b.Z.A_m_1(this, A_1, B_3);
			Q.A_m_1(this);
			M();
			FormClosing += delegate
			{
				H_m_1();
				if (A_16 != null)
				{
					try
					{
						A_16.Cancel();
					}
					catch
					{
					}
				}
				if (A_15 != null)
				{
					A_15.B_m_1();
				}
				A_21.Stop();
				a_6.Stop();
			};
			Shown += delegate
			{
				G();
				A_11.Focus();
			};
		}

		private void A_m_1()
		{
			TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
			{
				Dock = DockStyle.Fill,
				ColumnCount = 1,
				RowCount = 6,
				Padding = new Padding(12),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jp()
			};
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel.Controls.Add(a_m_1(), 0, 0);
			tableLayoutPanel.Controls.Add(B_m_1(), 0, 1);
			tableLayoutPanel.Controls.Add(b_m_1(), 0, 2);
			tableLayoutPanel.Controls.Add(C_m_1(), 0, 3);
			tableLayoutPanel.Controls.Add(c_m_1(), 0, 4);
			tableLayoutPanel.Controls.Add(D_m_1(), 0, 5);
			Controls.Add(tableLayoutPanel);
		}

		private Control a_m_1()
		{
			TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
			{
				Dock = DockStyle.Fill,
				ColumnCount = 2,
				RowCount = 1,
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				Margin = new Padding(0, 0, 0, 6),
				ColumnStyles = 
				{
					new ColumnStyle(SizeType.Percent, 55f),
					new ColumnStyle(SizeType.Percent, 45f)
				}
			};
			GroupBox groupBox = new GroupBox
			{
				Text = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jQ()),
				Dock = DockStyle.Fill,
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				Padding = new Padding(10),
				Margin = new Padding(0, 0, 8, 0),
				MinimumSize = new Size(0, 150)
			};
			TableLayoutPanel tableLayoutPanel2 = new TableLayoutPanel
			{
				Dock = DockStyle.Top,
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				ColumnCount = 1,
				RowCount = 4,
				AutoScroll = false
			};
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel
			{
				Dock = DockStyle.Top,
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				WrapContents = false,
				Margin = new Padding(0, 0, 0, 4),
				AutoScroll = false
			};
			A_6 = new Button
			{
				Text = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jq()),
				Width = 72,
				Height = 28,
				Margin = new Padding(0, 0, 6, 0),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jR()
			};
			A_6.Click += delegate
			{
				A_m_1(true);
			};
			flowLayoutPanel.Controls.Add(A_6);
			a_1 = new Button
			{
				Text = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jr()),
				Width = 72,
				Height = 28,
				Margin = new Padding(0, 0, 6, 0),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jS()
			};
			a_1.Click += delegate
			{
				A_m_1(false);
			};
			flowLayoutPanel.Controls.Add(a_1);
			tableLayoutPanel2.Controls.Add(flowLayoutPanel, 0, 0);
			A_3 = new TableLayoutPanel
			{
				Dock = DockStyle.Top,
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				ColumnCount = 1,
				Margin = new Padding(0),
				AutoScroll = false,
				BackColor = Color.Transparent,
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.js()
			};
			A_3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			tableLayoutPanel2.Controls.Add(A_3, 0, 1);
			A_5 = new Label
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(),
				AutoSize = true,
				MaximumSize = new Size(510, 0),
				ForeColor = A_1.J,
				Margin = new Padding(2, 6, 2, 0),
				Visible = false,
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BH()
			};
			tableLayoutPanel2.Controls.Add(A_5, 0, 2);
			Label control = new Label
			{
				Text = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jT()),
				AutoSize = true,
				MaximumSize = new Size(510, 0),
				Margin = new Padding(2, 6, 2, 0),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BH()
			};
			tableLayoutPanel2.Controls.Add(control, 0, 3);
			groupBox.Controls.Add(tableLayoutPanel2);
			tableLayoutPanel.Controls.Add(groupBox, 0, 0);
			GroupBox groupBox2 = new GroupBox
			{
				Text = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jt()),
				Dock = DockStyle.Fill,
				Padding = new Padding(10),
				Margin = new Padding(8, 0, 0, 0),
				MinimumSize = new Size(0, 150)
			};
			TableLayoutPanel tableLayoutPanel3 = new TableLayoutPanel
			{
				Dock = DockStyle.Fill,
				ColumnCount = 3,
				RowCount = 6,
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink
			};
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			A_7 = new CheckBox
			{
				Text = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jU()),
				AutoSize = true,
				Margin = new Padding(2, 4, 2, 4)
			};
			tableLayoutPanel3.Controls.Add(A_7, 0, 0);
			tableLayoutPanel3.SetColumnSpan(A_7, 3);
			a_2 = new CheckBox
			{
				Text = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ju()),
				AutoSize = true,
				Margin = new Padding(2, 4, 2, 4)
			};
			tableLayoutPanel3.Controls.Add(a_2, 0, 1);
			tableLayoutPanel3.SetColumnSpan(a_2, 3);
			B_1 = new CheckBox
			{
				Text = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jV()),
				AutoSize = true,
				Margin = new Padding(2, 4, 2, 4)
			};
			tableLayoutPanel3.Controls.Add(B_1, 0, 2);
			tableLayoutPanel3.SetColumnSpan(B_1, 3);
			b_1 = new CheckBox
			{
				Text = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jv()),
				AutoSize = true,
				Margin = new Padding(2, 4, 2, 4),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.cH()
			};
			b_1.CheckedChanged += delegate
			{
				f();
			};
			tableLayoutPanel3.Controls.Add(b_1, 0, 3);
			tableLayoutPanel3.SetColumnSpan(b_1, 3);
			Label control2 = new Label
			{
				Text = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jW()),
				AutoSize = true,
				Anchor = AnchorStyles.Left,
				Margin = new Padding(2, 8, 6, 4)
			};
			tableLayoutPanel3.Controls.Add(control2, 0, 4);
			A_8 = new NumericUpDown
			{
				Minimum = 0m,
				Maximum = 1048576m,
				Value = 1m,
				Width = 90,
				Anchor = AnchorStyles.Left,
				Margin = new Padding(0, 6, 6, 4),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jw()
			};
			tableLayoutPanel3.Controls.Add(A_8, 1, 4);
			a_3 = new Label
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(),
				AutoSize = true,
				MaximumSize = new Size(520, 0),
				Margin = new Padding(2, 6, 2, 0),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BH()
			};
			tableLayoutPanel3.Controls.Add(a_3, 0, 5);
			tableLayoutPanel3.SetColumnSpan(a_3, 3);
			groupBox2.Controls.Add(tableLayoutPanel3);
			tableLayoutPanel.Controls.Add(groupBox2, 1, 0);
			return tableLayoutPanel;
		}

		private Control B_m_1()
		{
			FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel
			{
				Dock = DockStyle.Fill,
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				WrapContents = true,
				Margin = new Padding(0, 0, 0, 6)
			};
			B_3 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jX(), 104, true);
			B_3.Click += delegate
			{
				h();
			};
			flowLayoutPanel.Controls.Add(B_3);
			b_2 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jx(), 80, false);
			b_2.Click += delegate
			{
				i();
			};
			flowLayoutPanel.Controls.Add(b_2);
			C_1 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jY(), 80, false);
			C_1.Click += delegate
			{
				J();
			};
			flowLayoutPanel.Controls.Add(C_1);
			c_1 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jy(), 168, false);
			c_1.Click += delegate
			{
				N();
			};
			flowLayoutPanel.Controls.Add(c_1);
			D_1 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jZ(), 110, false);
			D_1.Click += delegate
			{
				n();
			};
			flowLayoutPanel.Controls.Add(D_1);
			d_1 = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jz(), 122, false);
			d_1.Click += delegate
			{
				O();
			};
			flowLayoutPanel.Controls.Add(d_1);
			E = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.KA(), 100, false);
			E.Click += delegate
			{
				o();
			};
			flowLayoutPanel.Controls.Add(E);
			e = A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ka(), 104, false);
			e.Click += delegate
			{
				P();
			};
			flowLayoutPanel.Controls.Add(e);
			return flowLayoutPanel;
		}

		private Control b_m_1()
		{
			TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
			{
				Dock = DockStyle.Fill,
				ColumnCount = 1,
				RowCount = 3,
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				Margin = new Padding(0, 0, 0, 4),
				ColumnStyles = 
				{
					new ColumnStyle(SizeType.Percent, 100f)
				},
				RowStyles = 
				{
					new RowStyle(SizeType.AutoSize),
					new RowStyle(SizeType.AutoSize),
					new RowStyle(SizeType.AutoSize)
				}
			};
			b_3 = new Label
			{
				Text = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.KB()),
				AutoSize = true,
				MaximumSize = new Size(1100, 0),
				Margin = new Padding(2, 2, 2, 2)
			};
			tableLayoutPanel.Controls.Add(b_3, 0, 0);
			A_9 = new ProgressBar
			{
				Dock = DockStyle.Fill,
				Height = 14,
				Style = ProgressBarStyle.Continuous,
				Maximum = 1000,
				Margin = new Padding(2, 0, 2, 2)
			};
			tableLayoutPanel.Controls.Add(A_9, 0, 1);
			C_2 = new Label
			{
				Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(),
				AutoSize = true,
				MaximumSize = new Size(1100, 0),
				Margin = new Padding(2, 0, 2, 2),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BH()
			};
			tableLayoutPanel.Controls.Add(C_2, 0, 2);
			return tableLayoutPanel;
		}

		private Control C_m_1()
		{
			TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
			{
				Dock = DockStyle.Fill,
				ColumnCount = 4,
				RowCount = 1,
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				Margin = new Padding(0, 4, 0, 4),
				ColumnStyles = 
				{
					new ColumnStyle(SizeType.Percent, 100f),
					new ColumnStyle(SizeType.AutoSize),
					new ColumnStyle(SizeType.AutoSize),
					new ColumnStyle(SizeType.AutoSize)
				}
			};
			c_2 = new Label
			{
				Text = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Kb()),
				AutoSize = true,
				Anchor = AnchorStyles.Left,
				Margin = new Padding(2, 6, 8, 4),
				Font = global::B.Q.A_m_1(10f, FontStyle.Bold)
			};
			tableLayoutPanel.Controls.Add(c_2, 0, 0);
			A_10 = new TextBox
			{
				Width = 220,
				Anchor = AnchorStyles.Left,
				Margin = new Padding(4, 6, 4, 4),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jw()
			};
			A_10.TextChanged += delegate
			{
				j();
			};
			tableLayoutPanel.Controls.Add(A_10, 1, 0);
			Label control = new Label
			{
				Text = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.KC()),
				AutoSize = true,
				Anchor = AnchorStyles.Left,
				Margin = new Padding(8, 6, 4, 4),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BH()
			};
			tableLayoutPanel.Controls.Add(control, 2, 0);
			a_4 = new NumericUpDown
			{
				Minimum = 0m,
				Maximum = 1048576m,
				Value = 0m,
				Width = 88,
				Anchor = AnchorStyles.Left,
				Margin = new Padding(0, 4, 2, 4),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jw()
			};
			a_4.ValueChanged += delegate
			{
				j();
			};
			tableLayoutPanel.Controls.Add(a_4, 3, 0);
			D_2 = new Label
			{
				Text = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Kc()),
				AutoSize = true,
				Anchor = AnchorStyles.Left,
				Margin = new Padding(2, 0, 2, 2),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BH()
			};
			tableLayoutPanel.RowCount = 2;
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel.Controls.Add(D_2, 0, 1);
			tableLayoutPanel.SetColumnSpan(D_2, 4);
			return tableLayoutPanel;
		}

		private Control c_m_1()
		{
			A_11 = new DataGridView
			{
				Dock = DockStyle.Fill,
				VirtualMode = true,
				AllowUserToAddRows = false,
				AllowUserToDeleteRows = false,
				AllowUserToResizeRows = false,
				RowHeadersVisible = false,
				MultiSelect = false,
				SelectionMode = DataGridViewSelectionMode.FullRowSelect,
				EditMode = DataGridViewEditMode.EditOnEnter,
				BorderStyle = BorderStyle.FixedSingle,
				Font = global::B.Q.A_m_1(9.5f),
				BackgroundColor = A_1.c,
				GridColor = A_1.B,
				EnableHeadersVisualStyles = false,
				ColumnHeadersHeight = 30,
				RowTemplate = 
				{
					Height = 26
				},
				Margin = new Padding(0)
			};
			DataGridViewCheckBoxColumn dataGridViewColumn = new DataGridViewCheckBoxColumn
			{
				HeaderText = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(),
				Width = 42,
				ReadOnly = false,
				SortMode = DataGridViewColumnSortMode.NotSortable
			};
			A_11.Columns.Add(dataGridViewColumn);
			A_11.Columns.Add(new DataGridViewTextBoxColumn
			{
				HeaderText = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.KD()),
				AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
				FillWeight = 100f,
				ReadOnly = true,
				SortMode = DataGridViewColumnSortMode.Programmatic
			});
			A_11.Columns.Add(new DataGridViewTextBoxColumn
			{
				HeaderText = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Kd()),
				Width = 104,
				ReadOnly = true,
				SortMode = DataGridViewColumnSortMode.Programmatic
			});
			A_11.Columns.Add(new DataGridViewTextBoxColumn
			{
				HeaderText = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.KE()),
				Width = 138,
				ReadOnly = true,
				SortMode = DataGridViewColumnSortMode.Programmatic
			});
			A_11.Columns.Add(new DataGridViewTextBoxColumn
			{
				HeaderText = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ke()),
				Width = 138,
				ReadOnly = true,
				SortMode = DataGridViewColumnSortMode.Programmatic
			});
			A_11.Columns.Add(new DataGridViewTextBoxColumn
			{
				HeaderText = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.KF()),
				Width = 86,
				ReadOnly = true,
				SortMode = DataGridViewColumnSortMode.NotSortable
			});
			A_11.CellValueNeeded += A_m_1;
			A_11.CellValuePushed += a_m_1;
			A_11.CellPainting += A_m_1;
			A_11.CellFormatting += A_m_1;
			A_11.CellBeginEdit += A_m_1;
			A_11.CurrentCellDirtyStateChanged += delegate
			{
				if (A_11.IsCurrentCellDirty)
				{
					A_11.CommitEdit(DataGridViewDataErrorContexts.Commit);
				}
			};
			A_11.ColumnHeaderMouseClick += A_m_1;
			return A_11;
		}

		private Control D_m_1()
		{
			B_2 = new Label
			{
				Text = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Kf()),
				AutoSize = true,
				MaximumSize = new Size(1100, 0),
				Margin = new Padding(2, 6, 2, 0),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BH()
			};
			return B_2;
		}

		private Button A_m_1(string P_0, int P_1, bool P_2)
		{
			return new Button
			{
				Text = Q.A_m_1(P_0),
				Width = P_1,
				Height = 34,
				Margin = new Padding(0, 0, 8, 6),
				Font = global::B.Q.A_m_1(P_2 ? 10.5f : 10f, P_2 ? FontStyle.Bold : FontStyle.Regular)
			};
		}

		private void d_m_1()
		{
			A_3.SuspendLayout();
			A_3.Controls.Clear();
			A_3.RowStyles.Clear();
			A_3.RowCount = 0;
			A_4.Clear();
			IEnumerable<G> enumerable2;
			if (A_27 == null)
			{
				IEnumerable<G> enumerable = global::a.g.A_m_1((Func<IEnumerable<DriveInfo>>)null);
				enumerable2 = enumerable;
			}
			else
			{
				enumerable2 = A_27();
			}
			List<G> list = global::a.g.A_m_1(enumerable2);
			e_m_1();
			string text = (A_2.FullScanDrives ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).Trim();
			HashSet<string> hashSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
			if (text.Length > 0)
			{
				string[] array = text.Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries);
				for (int num = 0; num < array.Length; num++)
				{
					string text2 = global::a.g.A_m_1(array[num]);
					if (text2.Length > 0)
					{
						hashSet.Add(text2);
					}
				}
			}
			foreach (G item in list)
			{
				bool flag = item.A_2 && (text.Length == 0 || hashSet.Contains(item.A));
				A_m_1(item, flag);
			}
			A_3.ResumeLayout();
			f();
			bool flag2 = global::b.t.A_m_1(out var text3);
			a_3.Text = (flag2 ? Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Kg(), text3) : Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.KG()));
		}

		private int E_m_1()
		{
			int height = TextRenderer.MeasureText(Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.KH()), Font).Height;
			return Math.Max(36, height + 18);
		}

		private void e_m_1()
		{
			int num = Math.Max(24, TextRenderer.MeasureText(Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.KH()), Font).Height + 6);
			TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
			{
				ColumnCount = 6,
				RowCount = 1,
				Dock = DockStyle.Fill,
				Height = num,
				Margin = new Padding(0, 0, 0, 2),
				BackColor = Color.Transparent,
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Kh()
			};
			A_m_1(tableLayoutPanel);
			tableLayoutPanel.Controls.Add(A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(), true), 0, 0);
			tableLayoutPanel.Controls.Add(A_m_1(Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.KI()), true), 1, 0);
			tableLayoutPanel.Controls.Add(A_m_1(Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ki()), true), 2, 0);
			tableLayoutPanel.Controls.Add(A_m_1(Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BI()), true), 3, 0);
			tableLayoutPanel.Controls.Add(A_m_1(Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.KJ()), true), 4, 0);
			tableLayoutPanel.Controls.Add(A_m_1(Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Kj()), true), 5, 0);
			A_3.RowStyles.Add(new RowStyle(SizeType.Absolute, num));
			A_3.RowCount = A_3.RowStyles.Count;
			A_3.Controls.Add(tableLayoutPanel, 0, A_3.RowCount - 1);
		}

		private void A_m_1(TableLayoutPanel P_0)
		{
			P_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 34f));
			P_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 48f));
			P_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			P_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112f));
			P_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 96f));
			P_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 96f));
		}

		private Label A_m_1(string P_0, bool P_1)
		{
			return new Label
			{
				Text = P_0,
				AutoSize = false,
				Dock = DockStyle.Fill,
				TextAlign = ContentAlignment.MiddleLeft,
				AutoEllipsis = true,
				Margin = new Padding(2, 0, 2, 0),
				BackColor = Color.Transparent,
				ForeColor = (P_1 ? A_1.I : A_1.b),
				Tag = (P_1 ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BH() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.KK())
			};
		}

		private void A_m_1(G P_0, bool P_1)
		{
			int num = E_m_1();
			A_3.RowStyles.Add(new RowStyle(SizeType.Absolute, num));
			A_3.RowCount = A_3.RowStyles.Count;
			TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
			{
				ColumnCount = 6,
				RowCount = 1,
				Dock = DockStyle.Fill,
				Height = num,
				Margin = new Padding(0, 1, 0, 1),
				BackColor = Color.Transparent,
				Cursor = (P_0.A_2 ? Cursors.Hand : Cursors.Default),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Kk()
			};
			A_m_1(tableLayoutPanel);
			B A_1 = new B(this.A_1)
			{
				Checked = P_1,
				Enabled = P_0.A_2,
				Anchor = AnchorStyles.None,
				Margin = new Padding(0),
				Tag = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.KL(),
				AccessibleName = P_0.A + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aH() + global::a.g.a(P_0.A_1)
			};
			string text;
			if (P_0.A_2)
			{
				text = (string.IsNullOrWhiteSpace(P_0.a) ? Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Kl()) : P_0.a.Trim());
			}
			else
			{
				text = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bE());
			}
			string text2 = global::a.g.a(P_0.A_1);
			if (!P_0.A_2)
			{
				text2 = text2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bH() + global::a.g.A_m_1();
			}
			string text3 = (P_0.A_2 ? global::a.h.A_m_1(P_0.A_3) : Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bE()));
			string text4 = (P_0.A_2 ? global::a.h.A_m_1(P_0.a_1) : Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bE()));
			tableLayoutPanel.Controls.Add(A_1, 0, 0);
			tableLayoutPanel.Controls.Add(A_m_1(P_0.A.TrimEnd('\\'), !P_0.A_2), 1, 0);
			tableLayoutPanel.Controls.Add(A_m_1(text, !P_0.A_2), 2, 0);
			tableLayoutPanel.Controls.Add(A_m_1(text2, !P_0.A_2), 3, 0);
			tableLayoutPanel.Controls.Add(A_m_1(text3, !P_0.A_2), 4, 0);
			tableLayoutPanel.Controls.Add(A_m_1(text4, !P_0.A_2), 5, 0);
			EventHandler value = delegate
			{
				if (P_0.A_2)
				{
					A_1.Checked = !A_1.Checked;
				}
			};
			tableLayoutPanel.Click += value;
			foreach (Control control in tableLayoutPanel.Controls)
			{
				if (control != A_1)
				{
					control.Click += value;
				}
			}
			A_1.CheckedChanged += delegate
			{
				f();
			};
			A_3.Controls.Add(tableLayoutPanel, 0, A_3.RowCount - 1);
			A_4.Add(Tuple.Create(P_0, (CheckBox)A_1));
		}

		private void A_m_1(bool P_0)
		{
			A_3.SuspendLayout();
			foreach (Tuple<G, CheckBox> item in A_4)
			{
				if (item.Item1.A_2)
				{
					item.Item2.Checked = P_0;
				}
			}
			A_3.ResumeLayout();
			f();
		}

		private List<string> F()
		{
			List<string> list = new List<string>();
			foreach (Tuple<G, CheckBox> item in A_4)
			{
				if (item.Item1.A_2 && item.Item2.Checked)
				{
					list.Add(item.Item1.A);
				}
			}
			return list;
		}

		private void f()
		{
			bool flag = false;
			foreach (Tuple<G, CheckBox> item in A_4)
			{
				if (item.Item2.Checked && item.Item1.A_2 && !global::a.g.A_m_1(item.Item1, out var _))
				{
					flag = true;
					break;
				}
			}
			bool flag2 = b_1 != null && b_1.Checked;
			Label label = A_5;
			string text2;
			if (flag)
			{
				text2 = (flag2 ? Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Km()) : Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.KM()));
			}
			else
			{
				text2 = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}
			label.Text = text2;
			A_5.Visible = flag;
			if (B_2 != null)
			{
				B_2.Text = (flag2 ? Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.KN()) : Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Kf()));
			}
			if (A_5.Parent != null)
			{
				A_5.Parent.PerformLayout();
			}
		}

		private void G()
		{
			try
			{
				int num = Math.Max(0, A_4.Count - 3) * E_m_1();
				int val = 560 + num + 30;
				MinimumSize = new Size(900, Math.Min(1200, val));
				int val2 = Screen.FromControl(this).WorkingArea.Height - 60;
				int num2 = Math.Min(Math.Max(560, val), val2);
				if (ClientSize.Height < num2)
				{
					ClientSize = new Size(ClientSize.Width, num2);
				}
			}
			catch
			{
			}
		}

		private void g()
		{
			A_7.Checked = A_2.FullScanIncludeZero;
			a_2.Checked = A_2.FullScanQuickOnly;
			B_1.Checked = A_2.FullScanUseEverything;
			b_1.Checked = A_2.FullScanPermanentDelete;
			long fullScanMinSizeKB = A_2.FullScanMinSizeKB;
			NumericUpDown a_ = A_8;
			decimal value;
			if (fullScanMinSizeKB < 0)
			{
				value = 0m;
			}
			else
			{
				value = (((decimal)fullScanMinSizeKB > A_8.Maximum) ? A_8.Maximum : ((decimal)fullScanMinSizeKB));
			}
			a_.Value = value;
		}

		private void H_m_1()
		{
			List<string> values = F();
			A_2.FullScanDrives = string.Join(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Kn(), values);
			A_2.FullScanIncludeZero = A_7.Checked;
			A_2.FullScanQuickOnly = a_2.Checked;
			A_2.FullScanUseEverything = B_1.Checked;
			A_2.FullScanPermanentDelete = b_1.Checked;
			A_2.FullScanMinSizeKB = (long)A_8.Value;
			global::A.Y.A_m_1(A_2);
		}

		private void h()
		{
			if (a_5)
			{
				return;
			}
			List<string> list = F();
			if (list.Count == 0)
			{
				MessageBox.Show(this, Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.KO()), Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			H_m_1();
			A_12 = new List<global::a.c>();
			A_13 = new List<A>();
			A_14 = list.ToArray();
			A_11.RowCount = 0;
			A_22 = 0L;
			A_23 = 0;
			A_24 = TimeSpan.Zero;
			A_25 = null;
			B_4 = false;
			a_7 = -1;
			b_4 = true;
			lock (A_19)
			{
				A_20 = null;
			}
			global::a.b b2 = new global::a.b
			{
				A = list,
				A_1 = A_7.Checked,
				A_2 = (long)A_8.Value,
				a = a_2.Checked,
				B = B_1.Checked
			};
			A_15 = new E(b2);
			A_16 = new CancellationTokenSource();
			a_5 = true;
			A_18 = false;
			b_2.Text = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jx());
			A_9.Style = ProgressBarStyle.Marquee;
			b_3.Text = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ko());
			C_2.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			A_21.Start();
			M();
			E A = A_15;
			CancellationToken A_2 = A_16.Token;
			A_17 = Task.Run(() =>
			{
				A.A_m_1(A_m_1, A_2);
			});
			A_17.ContinueWith((Task P_0) =>
			{
				A_m_1(P_0);
			}, TaskScheduler.FromCurrentSynchronizationContext());
		}

		private void A_m_1(global::a.D P_0)
		{
			if (P_0 == null)
			{
				return;
			}
			lock (A_19)
			{
				A_20 = P_0;
			}
		}

		private global::a.D I()
		{
			lock (A_19)
			{
				return A_20;
			}
		}

		private void a_m_1(global::a.D P_0)
		{
			if (P_0 == null)
			{
				return;
			}
			A_22 = P_0.A_1;
			A_23 = (int)Math.Min(2147483647L, P_0.a);
			A_24 = P_0.A_3;
			string text = P_0.A ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			if (text == _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JW())
			{
				A_9.Style = ProgressBarStyle.Continuous;
				if (!A_18)
				{
					A_18 = true;
					b_2.Text = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.KP());
					M();
				}
				text = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JW());
			}
			else if (A_18 && text != _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jt() && text != _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JV() && text != _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Jv())
			{
				A_18 = false;
				b_2.Text = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jx());
			}
			b_3.Text = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Kp(), A_m_1(text), P_0.A_1.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.KQ()), P_0.A_2.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.KQ()), P_0.a.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.KQ()));
			if (P_0.b > 0)
			{
				A_9.Style = ProgressBarStyle.Continuous;
				int value = (int)Math.Min(1000L, Math.Max(0L, P_0.B * 1000 / P_0.b));
				A_9.Value = value;
				if (P_0.B > 0 && P_0.B < P_0.b && P_0.A_3.TotalSeconds > 0.5)
				{
					double val = (double)P_0.B / P_0.A_3.TotalSeconds;
					TimeSpan timeSpan = TimeSpan.FromSeconds((double)(P_0.b - P_0.B) / Math.Max(0.01, val));
					C_2.Text = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Kq(), P_0.a_1 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(), global::a.h.A_m_1(P_0.A_3), global::a.h.A_m_1(timeSpan));
				}
				else
				{
					C_2.Text = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.KR(), P_0.a_1 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D(), global::a.h.A_m_1(P_0.A_3));
				}
			}
			else
			{
				A_9.Style = ProgressBarStyle.Marquee;
				C_2.Text = (((P_0.a_1 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).Length == 0) ? Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Kr(), global::a.h.A_m_1(P_0.A_3)) : Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.KR(), P_0.a_1, global::a.h.A_m_1(P_0.A_3)));
			}
		}

		private static string A_m_1(string P_0)
		{
			if (string.IsNullOrEmpty(P_0))
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			}
			int num = P_0.IndexOf('/');
			if (num > 0 && P_0.StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JU()))
			{
				return Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.KS(), P_0.Substring(3, num - 3), P_0.Substring(num + 1));
			}
			if (num > 0 && P_0.StartsWith(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ju()))
			{
				return Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ks(), P_0.Substring(5, num - 5), P_0.Substring(num + 1));
			}
			return Q.A_m_1(P_0);
		}

		private async void A_m_1(Task P_0)
		{
			a_5 = false;
			A_18 = false;
			A_21.Stop();
			a_m_1(I());
			try
			{
				// 19：原 GetAwaiter().GetResult() 在 UI 线程同步等待，改为 await 后不再阻塞消息泵。
				await P_0;
			}
			catch (Exception ex)
			{
				b_3.Text = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.KT()) + ex.Message;
				M();
				return;
			}
			A_12 = A_15.Groups;
			A_22 = A_15.ScannedFiles;
			A_23 = (int)Math.Min(2147483647L, A_15.SkippedDirs);
			B_4 = A_15.UsedEverything;
			global::a.D d2 = I();
			if (d2 != null)
			{
				A_24 = d2.A_3;
			}
			A_9.Style = ProgressBarStyle.Continuous;
			A_9.Value = ((!A_15.Canceled && A_15.ScannedFiles != 0L) ? 1000 : 0);
			b_3.Text = (A_15.Canceled ? Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.KU(), A_22.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.KQ()), A_12.Count) : Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Kt(), A_22.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.KQ()), A_12.Count));
			if (B_4)
			{
				b_3.Text += Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ku());
			}
			C_2.Text = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			L();
			M();
		}

		private void i()
		{
			if (a_5 && A_15 != null)
			{
				if (A_18)
				{
					A_15.a_m_1();
					A_18 = false;
					b_2.Text = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jx());
				}
				else
				{
					A_15.A_m_1();
					A_18 = true;
					b_2.Text = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.KP());
				}
				M();
			}
		}

		private void J()
		{
			if (a_5 && A_15 != null)
			{
				A_15.B_m_1();
				C_1.Enabled = false;
				b_3.Text = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.KV());
			}
		}

		private void j()
		{
			a_6.Stop();
			a_6.Start();
		}

		private string K()
		{
			return (A_10.Text ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()).Trim().ToLowerInvariant();
		}

		private long k()
		{
			return (long)a_4.Value * 1024;
		}

		private void L()
		{
			string text = K();
			long num = k();
			List<a> list = new List<a>();
			foreach (global::a.c item in A_12)
			{
				if (item.A_1 < num)
				{
					continue;
				}
				List<Tuple<global::a.C, int>> list2 = new List<Tuple<global::a.C, int>>();
				for (int num2 = 0; num2 < item.A_2.Count; num2++)
				{
					global::a.C c2 = item.A_2[num2];
					if (text.Length <= 0 || c2.A.ToLowerInvariant().Contains(text))
					{
						list2.Add(Tuple.Create(c2, num2));
					}
				}
				if (list2.Count == 0)
				{
					continue;
				}
				a a2 = new a
				{
					A = item,
					A_1 = list2,
					A_2 = list2[0].Item1.A
				};
				foreach (Tuple<global::a.C, int> item2 in list2)
				{
					long num3 = ((item2.Item1.A_2 == DateTime.MinValue) ? 0 : item2.Item1.A_2.Ticks);
					long num4 = ((item2.Item1.a == DateTime.MinValue) ? 0 : item2.Item1.a.Ticks);
					if (num3 > a2.A_3)
					{
						a2.A_3 = num3;
					}
					if (num4 > a2.a_f_1)
					{
						a2.a_f_1 = num4;
					}
					if (string.Compare(item2.Item1.A, a2.A_2, StringComparison.OrdinalIgnoreCase) < 0)
					{
						a2.A_2 = item2.Item1.A;
					}
				}
				list.Add(a2);
			}
			if (a_7 >= 0)
			{
				list.Sort(a_7 switch
				{
					2 => (Comparison<a>)((a P_0, a P_1) => P_0.A.A_1.CompareTo(P_1.A.A_1)), 
					1 => (a P_0, a P_1) => string.Compare(P_0.A_2, P_1.A_2, StringComparison.OrdinalIgnoreCase), 
					3 => (a P_0, a P_1) => P_0.A_3.CompareTo(P_1.A_3), 
					_ => (a P_0, a P_1) => P_0.a_f_1.CompareTo(P_1.a_f_1), 
				});
				if (!b_4)
				{
					list.Reverse();
				}
			}
			List<A> list3 = new List<A>();
			foreach (a item3 in list)
			{
				list3.Add(new A
				{
					A_f_1 = true,
					A_f_2 = item3.A
				});
				List<Tuple<global::a.C, int>> list4 = item3.A_1;
				if (a_7 >= 0)
				{
					list4.Sort((Tuple<global::a.C, int> P_0, Tuple<global::a.C, int> P_1) =>
					{
						int num5 = a_7 switch
						{
							1 => string.Compare(P_0.Item1.A, P_1.Item1.A, StringComparison.OrdinalIgnoreCase), 
							2 => P_0.Item1.A_1.CompareTo(P_1.Item1.A_1), 
							3 => P_0.Item1.A_2.CompareTo(P_1.Item1.A_2), 
							_ => P_0.Item1.a.CompareTo(P_1.Item1.a), 
						};
						return (!b_4) ? (-num5) : num5;
					});
				}
				foreach (Tuple<global::a.C, int> item4 in list4)
				{
					list3.Add(new A
					{
						A_f_1 = false,
						A_f_2 = item3.A,
						A_f_3 = item4.Item1,
						A_f_4 = item4.Item2
					});
				}
			}
			A_13 = list3;
			A_11.RowCount = 0;
			A_11.RowCount = A_13.Count;
			A_11.Invalidate();
			l();
			M();
		}

		private void A_m_1(object P_0, DataGridViewCellValueEventArgs P_1)
		{
			if (P_1.RowIndex < 0 || P_1.RowIndex >= A_13.Count)
			{
				return;
			}
			A a2 = A_13[P_1.RowIndex];
			if (a2.A_f_1)
			{
				if (P_1.ColumnIndex == 1)
				{
					P_1.Value = A_m_1(a2.A_f_2);
				}
				else if (P_1.ColumnIndex >= 2 && P_1.ColumnIndex <= 4)
				{
					P_1.Value = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
				}
				else if (P_1.ColumnIndex == 5)
				{
					P_1.Value = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
				}
				return;
			}
			global::a.C a_f_ = a2.A_f_3;
			switch (P_1.ColumnIndex)
			{
			case 0:
				P_1.Value = a_f_.A_3;
				break;
			case 1:
				P_1.Value = a_f_.A;
				break;
			case 2:
				P_1.Value = global::a.h.A_m_1(a_f_.A_1);
				break;
			case 3:
				P_1.Value = ((a_f_.A_2 == DateTime.MinValue) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D() : a_f_.A_2.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CI()));
				break;
			case 4:
				P_1.Value = ((a_f_.a == DateTime.MinValue) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D() : a_f_.a.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CI()));
				break;
			case 5:
				P_1.Value = ((a2.A_f_4 == a2.A_f_2.a) ? Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bi()) : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D());
				break;
			}
		}

		private void a_m_1(object P_0, DataGridViewCellValueEventArgs P_1)
		{
			if (P_1.RowIndex >= 0 && P_1.RowIndex < A_13.Count)
			{
				A a2 = A_13[P_1.RowIndex];
				if (!a2.A_f_1 && a2.A_f_3 != null && P_1.ColumnIndex == 0)
				{
					bool flag = ((P_1.Value is bool) ? ((bool)P_1.Value) : Convert.ToBoolean(P_1.Value ?? ((object)false)));
					a2.A_f_3.A_3 = flag;
					A_11.InvalidateRow(P_1.RowIndex);
					l();
					M();
				}
			}
		}

		private void A_m_1(object P_0, DataGridViewCellPaintingEventArgs P_1)
		{
			if (P_1.RowIndex < 0 || P_1.RowIndex >= A_13.Count)
			{
				return;
			}
			A a2 = A_13[P_1.RowIndex];
			if (a2.A_f_1)
			{
				using (SolidBrush brush = new SolidBrush(A_1.a))
				{
					P_1.Graphics.FillRectangle(brush, P_1.CellBounds);
				}
				using (Pen pen = new Pen(A_1.B))
				{
					P_1.Graphics.DrawLine(pen, P_1.CellBounds.Left, P_1.CellBounds.Top, P_1.CellBounds.Right, P_1.CellBounds.Top);
				}
				if (P_1.ColumnIndex == 1)
				{
					TextRenderer.DrawText(P_1.Graphics, A_m_1(a2.A_f_2), global::B.Q.A_m_1(9.5f, FontStyle.Bold), P_1.CellBounds, A_1.C, TextFormatFlags.EndEllipsis | TextFormatFlags.NoPrefix | TextFormatFlags.VerticalCenter);
				}
				P_1.Handled = true;
			}
		}

		private void A_m_1(object P_0, DataGridViewCellFormattingEventArgs P_1)
		{
			if (P_1.RowIndex < 0 || P_1.RowIndex >= A_13.Count)
			{
				return;
			}
			A a2 = A_13[P_1.RowIndex];
			if (!a2.A_f_1)
			{
				if (a2.A_f_4 == a2.A_f_2.a)
				{
					P_1.CellStyle.ForeColor = A_1.j;
				}
				else if (a2.A_f_3.A_3)
				{
					P_1.CellStyle.ForeColor = A_1.i;
				}
				else
				{
					P_1.CellStyle.ForeColor = A_1.D;
				}
			}
		}

		private void A_m_1(object P_0, DataGridViewCellCancelEventArgs P_1)
		{
			if (P_1.RowIndex < 0 || P_1.RowIndex >= A_13.Count)
			{
				P_1.Cancel = true;
			}
			else if (A_13[P_1.RowIndex].A_f_1 || P_1.ColumnIndex != 0)
			{
				P_1.Cancel = true;
			}
		}

		private void A_m_1(object P_0, DataGridViewCellMouseEventArgs P_1)
		{
			if (P_1.ColumnIndex >= 1 && P_1.ColumnIndex <= 4)
			{
				if (a_7 == P_1.ColumnIndex)
				{
					b_4 = !b_4;
				}
				else
				{
					a_7 = P_1.ColumnIndex;
					b_4 = true;
				}
				for (int num = 1; num <= 4; num++)
				{
					A_11.Columns[num].HeaderCell.SortGlyphDirection = ((num == a_7) ? (b_4 ? SortOrder.Ascending : SortOrder.Descending) : SortOrder.None);
				}
				L();
			}
		}

		private string A_m_1(global::a.c P_0)
		{
			return Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Kv(), P_0.A, global::a.h.A_m_1(P_0.A_1), P_0.A_2.Count, global::a.h.A_m_1(P_0.Wasted));
		}

		private void l()
		{
			long num = 0L;
			foreach (global::a.c item in A_12)
			{
				num += item.Wasted;
			}
			c_2.Text = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.KW(), A_12.Count, global::a.h.A_m_1(num), A_23, global::a.h.A_m_1(A_24));
			int num2 = 0;
			long num3 = 0L;
			foreach (A item2 in A_13)
			{
				if (!item2.A_f_1 && item2.A_f_3 != null && item2.A_f_3.A_3)
				{
					num2++;
					num3 += item2.A_f_3.A_1;
				}
			}
			D_2.Text = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Kw(), num2, global::a.h.A_m_1(num3));
		}

		private void M()
		{
			B_3.Enabled = !a_5;
			b_2.Enabled = a_5;
			C_1.Enabled = a_5;
			A_3.Enabled = !a_5;
			A_6.Enabled = !a_5;
			a_1.Enabled = !a_5;
			A_7.Enabled = !a_5;
			a_2.Enabled = !a_5;
			B_1.Enabled = !a_5;
			b_1.Enabled = !a_5;
			A_8.Enabled = !a_5;
			bool flag = A_13.Count > 0 && !a_5;
			c_1.Enabled = flag;
			E.Enabled = flag;
			e.Enabled = flag;
			d_1.Enabled = A_25 != null && !a_5;
			D_1.Enabled = flag && m() > 0;
		}

		private int m()
		{
			int num = 0;
			foreach (A item in A_13)
			{
				if (!item.A_f_1 && item.A_f_3 != null && item.A_f_3.A_3)
				{
					num++;
				}
			}
			return num;
		}

		private void N()
		{
			HashSet<global::a.c> hashSet = new HashSet<global::a.c>();
			foreach (A item in A_13)
			{
				if (!item.A_f_1 && item.A_f_3 != null && hashSet.Add(item.A_f_2))
				{
					for (int num = 0; num < item.A_f_2.A_2.Count; num++)
					{
						item.A_f_2.A_2[num].A_3 = num != item.A_f_2.a;
					}
				}
			}
			A_11.Invalidate();
			l();
			M();
		}

		private f A_m_1(HashSet<global::a.C> P_0)
		{
			return global::a.g.A_m_1(P_0, b_1.Checked);
		}

		private void n()
		{
			if (a_5)
			{
				return;
			}
			foreach (global::a.c item in A_12)
			{
				int num = 0;
				bool flag = false;
				foreach (A item2 in A_13)
				{
					if (!item2.A_f_1 && item2.A_f_3 != null && item2.A_f_2 == item && item2.A_f_3.A_3)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					continue;
				}
				foreach (global::a.C item3 in item.A_2)
				{
					if (item3.A_3)
					{
						num++;
					}
				}
				if (num >= item.A_2.Count)
				{
					MessageBox.Show(this, Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.KX(), item.A), Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
			}
			HashSet<global::a.C> A_1 = new HashSet<global::a.C>();
			int num2 = 0;
			long num3 = 0L;
			foreach (A item4 in A_13)
			{
				if (!item4.A_f_1 && item4.A_f_3 != null && item4.A_f_3.A_3)
				{
					A_1.Add(item4.A_f_3);
					num2++;
					num3 += item4.A_f_3.A_1;
				}
			}
			if (num2 == 0)
			{
				MessageBox.Show(this, Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jB()), Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			bool A_2 = b_1.Checked;
			f f2 = A_m_1(A_1);
			int num4 = f2.a;
			int num5 = f2.A;
			int num6 = f2.B;
			if (num4 == 0 && num6 >= num2)
			{
				MessageBox.Show(this, Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Kx()), Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			string text;
			if (num4 == 0)
			{
				text = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.KY(), num5, global::a.h.A_m_1(f2.A_1));
				if (num6 > 0)
				{
					text = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ky(), num6) + text;
				}
			}
			else
			{
				text = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.KZ(), num4, global::a.h.A_m_1(f2.a_1));
				if (num5 > 0)
				{
					text += Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Kz(), num5);
				}
				if (num6 > 0)
				{
					text += Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kA(), num6);
				}
				text += Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ka());
			}
			bool flag2;
			if (num4 > 0)
			{
				global::b.C c2 = new global::b.C
				{
					A = num4,
					A_1 = f2.a_1,
					a = num5,
					B = num6
				};
				flag2 = ((A_28 != null) ? A_28(c2) : global::b.c.A_m_1(this, text, c2));
			}
			else
			{
				flag2 = ((A_26 != null) ? A_26(num2, num3) : (MessageBox.Show(this, text, Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kB()), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes));
			}
			if (!flag2)
			{
				return;
			}
			a_5 = true;
			M();
			Cursor = Cursors.WaitCursor;
			List<global::a.c> A = A_12;
			CancellationToken A_3 = CancellationToken.None;
			Task.Run(() => global::a.e.A_m_1(A, (global::a.C P_0) => P_0.A_3 && A_1.Contains(P_0), A_2, A_3)).ContinueWith((Task<global::a.d> task) =>
			{
				a_5 = false;
				Cursor = Cursors.Default;
				global::a.d result = task.Result;
				if (result == null || !result.A)
				{
					string text2 = ((result == null) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D() : (result.A_1 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D()));
					if (result != null && result.A_4.Count > 0)
					{
						text2 = string.Join(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kk(), result.A_4.Take(5));
					}
					MessageBox.Show(this, Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Zo()) + text2, Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				else
				{
					A_25 = result.a_1;
					string text3 = ((result.a > 0) ? Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.yH(), result.A_2, result.a, global::a.h.A_m_1(result.A_3)) : Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Zp(), result.A_2, global::a.h.A_m_1(result.A_3)));
					if (result.A_4.Count > 0)
					{
						text3 = text3 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kk() + Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Zq()) + string.Join(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.DG(), result.A_4.Take(5));
					}
					MessageBox.Show(this, text3, Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				foreach (global::a.C item5 in A_1)
				{
					if (!File.Exists(global::a.a.A(item5.A)))
					{
						item5.A_3 = false;
					}
				}
				A_11.Invalidate();
				l();
				M();
			}, TaskScheduler.FromCurrentSynchronizationContext());
		}

		private void O()
		{
			if (A_25 == null || a_5 || MessageBox.Show(this, Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kb()), Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.jz()), MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
			{
				return;
			}
			d_1.Enabled = false;
			Cursor = Cursors.WaitCursor;
			string A = A_25;
			Task.Run(() => global::B.w.A_m_1(A, true, CancellationToken.None)).ContinueWith((Task<global::B.w.A> task) =>
			{
				Cursor = Cursors.Default;
				global::B.w.A result = task.Result;
				if (result == null)
				{
					MessageBox.Show(this, Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Zt()), Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else
				{
					string text = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.yI(), result.D, result.f);
					MessageBox.Show(this, text + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.aKU() + result.ToString(), Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					foreach (global::a.c item in A_12)
					{
						foreach (global::a.C item2 in item.A_2)
						{
							if (item2.A_3 && File.Exists(global::a.a.A(item2.A)))
							{
								item2.A_3 = false;
							}
						}
					}
					A_11.Invalidate();
					l();
					M();
				}
			}, TaskScheduler.FromCurrentSynchronizationContext());
		}

		private void o()
		{
			if (A_12.Count == 0)
			{
				MessageBox.Show(this, Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kC()), Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			I i2 = global::b.G.B(this, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kc(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kD());
			if (!i2.A)
			{
				return;
			}
			using SaveFileDialog saveFileDialog = new SaveFileDialog
			{
				Filter = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kd()),
				FileName = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kE() + DateTime.Now.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ke()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kF()
			};
			if (saveFileDialog.ShowDialog(this) != DialogResult.OK)
			{
				return;
			}
			if (!i2.A_m_1())
			{
				try
				{
					global::B.p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kf());
				}
				catch
				{
				}
				MessageBox.Show(this, p(), Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			try
			{
				global::a.h.A_m_1(saveFileDialog.FileName, A_12, A_23, A_24, i2.a(256));
				MessageBox.Show(this, Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kG()) + saveFileDialog.FileName, Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			catch (Exception ex)
			{
				MessageBox.Show(this, Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kg()) + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void P()
		{
			if (A_12.Count == 0)
			{
				MessageBox.Show(this, Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kC()), Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			I i2 = global::b.G.B(this, _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kH(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kh());
			if (!i2.A)
			{
				return;
			}
			using SaveFileDialog saveFileDialog = new SaveFileDialog
			{
				Filter = Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kI()),
				FileName = _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kE() + DateTime.Now.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ke()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ki()
			};
			if (saveFileDialog.ShowDialog(this) != DialogResult.OK)
			{
				return;
			}
			if (!i2.A_m_1())
			{
				try
				{
					global::B.p.a_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kf());
				}
				catch
				{
				}
				MessageBox.Show(this, p(), Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			try
			{
				string text = string.Join(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.o(), A_14);
				global::a.h.A_m_1(saveFileDialog.FileName, A_12, A_22, A_23, A_24, text, i2.a(256));
				MessageBox.Show(this, Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kG()) + saveFileDialog.FileName, Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			catch (Exception ex)
			{
				MessageBox.Show(this, Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kg()) + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private static string p()
		{
			if (!Q.EnMode)
			{
				return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kJ();
			}
			return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kj();
		}

		[CompilerGenerated]
		private void A_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			a_m_1(I());
		}

		[CompilerGenerated]
		private void a_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			a_6.Stop();
			L();
		}

		[CompilerGenerated]
		private void A_m_1(object? _003Cp0_003E, FormClosingEventArgs P_1)
		{
			H_m_1();
			if (A_16 != null)
			{
				try
				{
					A_16.Cancel();
				}
				catch
				{
				}
			}
			if (A_15 != null)
			{
				A_15.B_m_1();
			}
			A_21.Stop();
			a_6.Stop();
		}

		[CompilerGenerated]
		private void B_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			G();
			A_11.Focus();
		}

		[CompilerGenerated]
		private void b_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			A_m_1(true);
		}

		[CompilerGenerated]
		private void C_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			A_m_1(false);
		}

		[CompilerGenerated]
		private void c_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			f();
		}

		[CompilerGenerated]
		private void D_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			h();
		}

		[CompilerGenerated]
		private void d_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			i();
		}

		[CompilerGenerated]
		private void E_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			J();
		}

		[CompilerGenerated]
		private void e_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			N();
		}

		[CompilerGenerated]
		private void F(object? _003Cp0_003E, EventArgs P_1)
		{
			n();
		}

		[CompilerGenerated]
		private void f(object? _003Cp0_003E, EventArgs P_1)
		{
			O();
		}

		[CompilerGenerated]
		private void G(object? _003Cp0_003E, EventArgs P_1)
		{
			o();
		}

		[CompilerGenerated]
		private void g(object? _003Cp0_003E, EventArgs P_1)
		{
			P();
		}

		[CompilerGenerated]
		private void H_m_1(object? _003Cp0_003E, EventArgs P_1)
		{
			j();
		}

		[CompilerGenerated]
		private void h(object? _003Cp0_003E, EventArgs P_1)
		{
			j();
		}

		[CompilerGenerated]
		private void I(object? _003Cp0_003E, EventArgs P_1)
		{
			if (A_11.IsCurrentCellDirty)
			{
				A_11.CommitEdit(DataGridViewDataErrorContexts.Commit);
			}
		}

		[CompilerGenerated]
		private int A_m_1(Tuple<global::a.C, int> P_0, Tuple<global::a.C, int> P_1)
		{
			int num = a_7 switch
			{
				1 => string.Compare(P_0.Item1.A, P_1.Item1.A, StringComparison.OrdinalIgnoreCase), 
				2 => P_0.Item1.A_1.CompareTo(P_1.Item1.A_1), 
				3 => P_0.Item1.A_2.CompareTo(P_1.Item1.A_2), 
				_ => P_0.Item1.a.CompareTo(P_1.Item1.a), 
			};
			if (!b_4)
			{
				return -num;
			}
			return num;
		}
	}
	public static class h
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class A
		{
			public static readonly A A_f_1 = new A();

			public static Func<c, long> A_f_2;

			internal long A_m_1(c P_0)
			{
				return P_0.Wasted;
			}
		}

		public static void A_m_1(string P_0, IEnumerable<c> P_1, int P_2, TimeSpan P_3, int P_4 = 0)
		{
			StringBuilder stringBuilder = new StringBuilder(A_m_1(P_4));
			stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kK()).Append(global::C.f.CsvHeaderSuffix).Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kk());
			foreach (c item in P_1)
			{
				for (int num = 0; num < item.A_2.Count; num++)
				{
					C c2 = item.A_2[num];
					stringBuilder.Append(item.A).Append(',').Append(A_m_1(c2.A))
						.Append(',')
						.Append(c2.A_1)
						.Append(',')
						.Append((c2.A_2 == DateTime.MinValue) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D() : c2.A_2.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CI()))
						.Append(',')
						.Append((c2.a == DateTime.MinValue) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D() : c2.a.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CI()))
						.Append(',')
						.Append((num == item.a) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kL() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D())
						.Append(',')
						.Append(c2.A_3 ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kl() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D())
						.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kk());
				}
			}
			stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kk()).Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kM()).Append(P_2)
				.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.km())
				.Append(A_m_1(P_3))
				.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kk());
			File.WriteAllText(global::a.a.A(P_0), stringBuilder.ToString(), new UTF8Encoding(encoderShouldEmitUTF8Identifier: true));
		}

		public static void A_m_1(string P_0, IEnumerable<c> P_1, long P_2, int P_3, TimeSpan P_4, string P_5, int P_6 = 0)
		{
			List<c> list = P_1.ToList();
			long num = list.Sum((c c3) => c3.Wasted);
			StringBuilder stringBuilder = new StringBuilder(A_m_1(P_6));
			stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kN()).Append(Q.EnMode ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Hk() : _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.HK()).Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kn());
			stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kO()).Append(a(Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ko()))).Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kP());
			stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kp());
			stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kQ());
			stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kq());
			stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kR());
			stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kr());
			stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kS());
			stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ks());
			stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kT());
			stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kt());
			stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kU()).Append(a(Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ko()))).Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ku());
			stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kV()).Append(a(Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kv()))).Append(a(P_5))
				.Append(Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kW()))
				.Append(DateTime.Now.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.CI()))
				.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kw());
			stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kX() + Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kx()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kY()).Append(P_2).Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ky());
			stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kX() + Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kZ()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kY()).Append(list.Count).Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ky());
			stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kX() + Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kz()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kY()).Append(A_m_1(num)).Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ky());
			stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kX() + Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LA()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kY()).Append(P_3).Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ky());
			stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kX() + Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.La()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kY()).Append(A_m_1(P_4)).Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.ky());
			foreach (c item in list)
			{
				stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LB()).Append(item.A).Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Il())
					.Append(Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.kZ()))
					.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bH())
					.Append(A_m_1(item.A_1))
					.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lb())
					.Append(item.A_2.Count)
					.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.bH())
					.Append(Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LC()))
					.Append(A_m_1(item.Wasted))
					.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lc());
				stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LD()).Append(Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ld())).Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LE())
					.Append(Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Le()))
					.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LE())
					.Append(Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Kd()))
					.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LE())
					.Append(Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.KE()))
					.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LE())
					.Append(Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ke()))
					.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LF());
				for (int num2 = 0; num2 < item.A_2.Count; num2++)
				{
					C c2 = item.A_2[num2];
					stringBuilder.Append((num2 == item.a) ? (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LH() + Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bi()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lg()) : (_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lf() + Q.A_m_1(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LG()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lg()));
					stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lh()).Append(a(c2.A)).Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LI())
						.Append(A_m_1(c2.A_1))
						.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LI())
						.Append((c2.A_2 == DateTime.MinValue) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D() : c2.A_2.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.q()))
						.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LI())
						.Append((c2.a == DateTime.MinValue) ? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D() : c2.a.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.q()))
						.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Li());
				}
				stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LJ());
			}
			stringBuilder.Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lj()).Append(a(global::C.f.HtmlLine)).Append(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LK());
			File.WriteAllText(global::a.a.A(P_0), stringBuilder.ToString(), new UTF8Encoding(encoderShouldEmitUTF8Identifier: true));
		}

		private static string A_m_1(string P_0)
		{
			P_0 = P_0 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			if (P_0.IndexOfAny(new char[4] { ',', '"', '\n', '\r' }) < 0)
			{
				return P_0;
			}
			return _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JX() + P_0.Replace(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JX(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lk()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JX();
		}

		private static int A_m_1(int P_0)
		{
			if (P_0 <= 0)
			{
				return 16;
			}
			long num = (long)P_0 * 1024L;
			if (num <= 1048576)
			{
				return (int)num;
			}
			return 1048576;
		}

		private static string a(string P_0)
		{
			P_0 = P_0 ?? _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.D();
			return P_0.Replace(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LL(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ll()).Replace(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LM(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lm()).Replace(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LN(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Ln())
				.Replace(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.JX(), _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LO());
		}

		public static string A_m_1(long P_0)
		{
			if (P_0 < 1024)
			{
				return P_0 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bd();
			}
			double num = (double)P_0 / 1024.0;
			if (num < 1024.0)
			{
				return num.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.w()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BE();
			}
			num /= 1024.0;
			if (num < 1024.0)
			{
				return num.ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.w()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Be();
			}
			return (num / 1024.0).ToString(_657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.BF()) + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Bf();
		}

		public static string A_m_1(TimeSpan P_0)
		{
			if (P_0.TotalSeconds < 60.0)
			{
				return (int)P_0.TotalSeconds + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lo();
			}
			int num = (int)P_0.TotalMinutes;
			int num2 = (int)(P_0.TotalSeconds - (double)(num * 60));
			return num + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.LP() + num2 + _657D2D75_002D39DA_002D46DB_002DB6E5_002D9A23768DC132.Lo();
		}
	}
}
