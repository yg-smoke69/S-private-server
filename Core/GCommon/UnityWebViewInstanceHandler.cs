using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x200402A")]
internal class UnityWebViewInstanceHandler : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200402B")]
	private struct ConsoleMessage_Android
	{
		[Token(Token = "0x401B00A")]
		[FieldOffset(Offset = "0x0")]
		public string messageLevel;

		[Token(Token = "0x401B00B")]
		[FieldOffset(Offset = "0x4")]
		public int lineNumber;

		[Token(Token = "0x401B00C")]
		[FieldOffset(Offset = "0x8")]
		public string message;

		[Token(Token = "0x401B00D")]
		[FieldOffset(Offset = "0xC")]
		public string sourceId;
	}

	[Token(Token = "0x200402C")]
	private sealed class _003COnCaptureScreenshotSuccess_003Ec__AnonStorey0
	{
		[Token(Token = "0x401B00E")]
		[FieldOffset(Offset = "0x8")]
		internal string filePath;

		[Token(Token = "0x401B00F")]
		[FieldOffset(Offset = "0xC")]
		internal UnityWebViewInstanceHandler _0024this;

		[Token(Token = "0x601A23A")]
		[Address(RVA = "0x2BCD0B4", Offset = "0x2BCD0B4", VA = "0x2BCD0B4")]
		public _003COnCaptureScreenshotSuccess_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x601A23B")]
		[Address(RVA = "0x2BCDF9C", Offset = "0x2BCDF9C", VA = "0x2BCDF9C")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x200402D")]
	private sealed class _003COnCapturedScreenshotFailure_003Ec__AnonStorey1
	{
		[Token(Token = "0x401B010")]
		[FieldOffset(Offset = "0x8")]
		internal string error;

		[Token(Token = "0x401B011")]
		[FieldOffset(Offset = "0xC")]
		internal UnityWebViewInstanceHandler _0024this;

		[Token(Token = "0x601A23C")]
		[Address(RVA = "0x2BCD1C8", Offset = "0x2BCD1C8", VA = "0x2BCD1C8")]
		public _003COnCapturedScreenshotFailure_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x601A23D")]
		[Address(RVA = "0x2BCE050", Offset = "0x2BCE050", VA = "0x2BCE050")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x200402E")]
	private sealed class _003CCanGoBackwardResult_003Ec__AnonStorey2
	{
		[Token(Token = "0x401B012")]
		[FieldOffset(Offset = "0x8")]
		internal bool canGoBackward;

		[Token(Token = "0x401B013")]
		[FieldOffset(Offset = "0xC")]
		internal UnityWebViewInstanceHandler _0024this;

		[Token(Token = "0x601A23E")]
		[Address(RVA = "0x2BCD3BC", Offset = "0x2BCD3BC", VA = "0x2BCD3BC")]
		public _003CCanGoBackwardResult_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x601A23F")]
		[Address(RVA = "0x2BCDE4C", Offset = "0x2BCDE4C", VA = "0x2BCDE4C")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x200402F")]
	private sealed class _003CCanGoForwardResult_003Ec__AnonStorey3
	{
		[Token(Token = "0x401B014")]
		[FieldOffset(Offset = "0x8")]
		internal bool canGoForward;

		[Token(Token = "0x401B015")]
		[FieldOffset(Offset = "0xC")]
		internal UnityWebViewInstanceHandler _0024this;

		[Token(Token = "0x601A240")]
		[Address(RVA = "0x2BCD5B0", Offset = "0x2BCD5B0", VA = "0x2BCD5B0")]
		public _003CCanGoForwardResult_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x601A241")]
		[Address(RVA = "0x2BCDEF4", Offset = "0x2BCDEF4", VA = "0x2BCDEF4")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2004030")]
	private sealed class _003COnJavaScriptPostMessage_003Ec__AnonStorey4
	{
		[Token(Token = "0x401B016")]
		[FieldOffset(Offset = "0x8")]
		internal string data;

		[Token(Token = "0x401B017")]
		[FieldOffset(Offset = "0xC")]
		internal UnityWebViewInstanceHandler _0024this;

		[Token(Token = "0x601A242")]
		[Address(RVA = "0x2BCD6C4", Offset = "0x2BCD6C4", VA = "0x2BCD6C4")]
		public _003COnJavaScriptPostMessage_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x601A243")]
		[Address(RVA = "0x2BCE1A4", Offset = "0x2BCE1A4", VA = "0x2BCE1A4")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2004031")]
	private sealed class _003COnJavaScriptResult_003Ec__AnonStorey5
	{
		[Token(Token = "0x401B018")]
		[FieldOffset(Offset = "0x8")]
		internal string javaScriptResultString;

		[Token(Token = "0x401B019")]
		[FieldOffset(Offset = "0xC")]
		internal UnityWebViewInstanceHandler _0024this;

		[Token(Token = "0x601A244")]
		[Address(RVA = "0x2BCD7D8", Offset = "0x2BCD7D8", VA = "0x2BCD7D8")]
		public _003COnJavaScriptResult_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x601A245")]
		[Address(RVA = "0x2BCE2D8", Offset = "0x2BCE2D8", VA = "0x2BCE2D8")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2004032")]
	private sealed class _003COnGetUserAgentString_003Ec__AnonStorey6
	{
		[Token(Token = "0x401B01A")]
		[FieldOffset(Offset = "0x8")]
		internal string userAgent;

		[Token(Token = "0x401B01B")]
		[FieldOffset(Offset = "0xC")]
		internal UnityWebViewInstanceHandler _0024this;

		[Token(Token = "0x601A246")]
		[Address(RVA = "0x2BCDDA4", Offset = "0x2BCDDA4", VA = "0x2BCDDA4")]
		public _003COnGetUserAgentString_003Ec__AnonStorey6()
		{
		}

		[Token(Token = "0x601A247")]
		[Address(RVA = "0x2BCE104", Offset = "0x2BCE104", VA = "0x2BCE104")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x401B004")]
	private const string UNITY_WEBVIEW_INSTANCE_HANDLER_TEMPLATE = "UnityWebViewInstanceHandler_{0}";

	[Token(Token = "0x401B005")]
	[FieldOffset(Offset = "0x0")]
	private static int _NextInstanceId;

	[Token(Token = "0x401B006")]
	[FieldOffset(Offset = "0x4")]
	private static Dictionary<int, UnityWebViewInstanceHandler> _Handlers;

	[Token(Token = "0x401B007")]
	[FieldOffset(Offset = "0xC")]
	private int _WebViewId;

	[Token(Token = "0x401B008")]
	[FieldOffset(Offset = "0x10")]
	public Action<string> CaptureScreenshotSuccessCallback;

	[Token(Token = "0x401B009")]
	[FieldOffset(Offset = "0x14")]
	public Action<string> CaptureScreenshotFailureCallback;

	[Token(Token = "0x601A229")]
	[Address(RVA = "0x2BCCF0C", Offset = "0x2BCCF0C", VA = "0x2BCCF0C")]
	public UnityWebViewInstanceHandler()
	{
	}

	[Token(Token = "0x601A22A")]
	[Address(RVA = "0x2BCCF14", Offset = "0x2BCCF14", VA = "0x2BCCF14")]
	private static int NewInstanceId()
	{
		return default(int);
	}

	[Token(Token = "0x601A22B")]
	[Address(RVA = "0x2BC6344", Offset = "0x2BC6344", VA = "0x2BC6344")]
	public static UnityWebViewInstanceHandler Create()
	{
		return null;
	}

	[Token(Token = "0x601A22C")]
	[Address(RVA = "0x2BCC488", Offset = "0x2BCC488", VA = "0x2BCC488")]
	public static UnityWebViewInstanceHandler Get(int webViewId)
	{
		return null;
	}

	[Token(Token = "0x601A22D")]
	[Address(RVA = "0x2BC6890", Offset = "0x2BC6890", VA = "0x2BC6890")]
	public static void Bind(int webViewId, UnityWebViewInstanceHandler handler)
	{
	}

	[Token(Token = "0x601A22E")]
	[Address(RVA = "0x2BC6DEC", Offset = "0x2BC6DEC", VA = "0x2BC6DEC")]
	public static void Destroy(int webViewId)
	{
	}

	[Token(Token = "0x601A22F")]
	[Address(RVA = "0x2BC71B4", Offset = "0x2BC71B4", VA = "0x2BC71B4")]
	public static void DestroyAll()
	{
	}

	[Token(Token = "0x601A230")]
	[Address(RVA = "0x2BCCFA8", Offset = "0x2BCCFA8", VA = "0x2BCCFA8")]
	public void OnCaptureScreenshotSuccess(string filePath)
	{
	}

	[Token(Token = "0x601A231")]
	[Address(RVA = "0x2BCD0BC", Offset = "0x2BCD0BC", VA = "0x2BCD0BC")]
	public void OnCapturedScreenshotFailure(string error)
	{
	}

	[Token(Token = "0x601A232")]
	[Address(RVA = "0x2BCD1D0", Offset = "0x2BCD1D0", VA = "0x2BCD1D0")]
	public void CanGoBackwardResult(string result)
	{
	}

	[Token(Token = "0x601A233")]
	[Address(RVA = "0x2BCD3C4", Offset = "0x2BCD3C4", VA = "0x2BCD3C4")]
	public void CanGoForwardResult(string result)
	{
	}

	[Token(Token = "0x601A234")]
	[Address(RVA = "0x2BCD5B8", Offset = "0x2BCD5B8", VA = "0x2BCD5B8")]
	public void OnJavaScriptPostMessage(string data)
	{
	}

	[Token(Token = "0x601A235")]
	[Address(RVA = "0x2BCD6CC", Offset = "0x2BCD6CC", VA = "0x2BCD6CC")]
	public void OnJavaScriptResult(string javaScriptResultString)
	{
	}

	[Token(Token = "0x601A236")]
	[Address(RVA = "0x2BCD7E0", Offset = "0x2BCD7E0", VA = "0x2BCD7E0")]
	public void OnWebViewMessage_Android(string msg)
	{
	}

	[Token(Token = "0x601A237")]
	[Address(RVA = "0x2BCD8E0", Offset = "0x2BCD8E0", VA = "0x2BCD8E0")]
	public void OnConsoleMessage_Android(string consoleMessage)
	{
	}

	[Token(Token = "0x601A238")]
	[Address(RVA = "0x2BCDC98", Offset = "0x2BCDC98", VA = "0x2BCDC98")]
	public void OnGetUserAgentString(string userAgent)
	{
	}
}
