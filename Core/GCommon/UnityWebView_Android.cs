using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2004033")]
public static class UnityWebView_Android
{
	[Token(Token = "0x2004034")]
	private sealed class _003COnTestResult_003Ec__AnonStorey0
	{
		[Token(Token = "0x401B01F")]
		[FieldOffset(Offset = "0x8")]
		internal bool result;

		[Token(Token = "0x601A266")]
		[Address(RVA = "0x2BCEA60", Offset = "0x2BCEA60", VA = "0x2BCEA60")]
		public _003COnTestResult_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x601A267")]
		[Address(RVA = "0x2BCEA68", Offset = "0x2BCEA68", VA = "0x2BCEA68")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x401B01C")]
	[FieldOffset(Offset = "0x0")]
	private static AndroidJavaClass _WebViewManager;

	[Token(Token = "0x401B01D")]
	[FieldOffset(Offset = "0x4")]
	private static AndroidJavaClass _CustomTabsManager;

	[Token(Token = "0x401B01E")]
	[FieldOffset(Offset = "0x8")]
	private static Action<bool> _OnTestResult;

	[Token(Token = "0x17001CAD")]
	private static AndroidJavaClass WebViewManager
	{
		[Token(Token = "0x601A248")]
		[Address(RVA = "0x2BCE694", Offset = "0x2BCE694", VA = "0x2BCE694")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CAE")]
	private static AndroidJavaClass CustomTabsManager
	{
		[Token(Token = "0x601A249")]
		[Address(RVA = "0x2BCE754", Offset = "0x2BCE754", VA = "0x2BCE754")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x601A24A")]
	[Address(RVA = "0x2BCE810", Offset = "0x2BCE810", VA = "0x2BCE810")]
	public static void Configure(bool useActivity)
	{
	}

	[Token(Token = "0x601A24B")]
	[Address(RVA = "0x2BCE938", Offset = "0x2BCE938", VA = "0x2BCE938")]
	public static void SetWebViewActivityDebugLog(bool debugLog)
	{
	}

	[Token(Token = "0x601A24C")]
	[Address(RVA = "0x2BC5BB8", Offset = "0x2BC5BB8", VA = "0x2BC5BB8")]
	public static void SetUnitySendMessageGameObjectName(string name)
	{
	}

	[Token(Token = "0x601A24D")]
	[Address(RVA = "0x2BC5CBC", Offset = "0x2BC5CBC", VA = "0x2BC5CBC")]
	public static void SetSendConsoleMessagesToUnity(bool send)
	{
	}

	[Token(Token = "0x601A24E")]
	[Address(RVA = "0x2BC64DC", Offset = "0x2BC64DC", VA = "0x2BC64DC")]
	public static int Open(string url, float x, float y, float width, float height, UnityWebView.WebViewParameters parameters)
	{
		return default(int);
	}

	[Token(Token = "0x601A24F")]
	[Address(RVA = "0x2BC6974", Offset = "0x2BC6974", VA = "0x2BC6974")]
	public static void Test(Action<bool> onTestResult)
	{
	}

	[Token(Token = "0x601A250")]
	[Address(RVA = "0x2BCCCA0", Offset = "0x2BCCCA0", VA = "0x2BCCCA0")]
	internal static void OnTestResult(bool result)
	{
	}

	[Token(Token = "0x601A251")]
	[Address(RVA = "0x2BC6C08", Offset = "0x2BC6C08", VA = "0x2BC6C08")]
	public static void Close(int webViewId)
	{
	}

	[Token(Token = "0x601A252")]
	[Address(RVA = "0x2BC7064", Offset = "0x2BC7064", VA = "0x2BC7064")]
	public static void CloseAll()
	{
	}

	[Token(Token = "0x601A253")]
	[Address(RVA = "0x2BC743C", Offset = "0x2BC743C", VA = "0x2BC743C")]
	public static void Reload(int webViewId)
	{
	}

	[Token(Token = "0x601A254")]
	[Address(RVA = "0x2BC7CA4", Offset = "0x2BC7CA4", VA = "0x2BC7CA4")]
	public static bool CanGoBackward(int webViewId)
	{
		return default(bool);
	}

	[Token(Token = "0x601A255")]
	[Address(RVA = "0x2BC8024", Offset = "0x2BC8024", VA = "0x2BC8024")]
	public static bool CanGoForward(int webViewId)
	{
		return default(bool);
	}

	[Token(Token = "0x601A256")]
	[Address(RVA = "0x2BC815C", Offset = "0x2BC815C", VA = "0x2BC815C")]
	public static void GoBackward(int webViewId)
	{
	}

	[Token(Token = "0x601A257")]
	[Address(RVA = "0x2BC8288", Offset = "0x2BC8288", VA = "0x2BC8288")]
	public static void GoForward(int webViewId)
	{
	}

	[Token(Token = "0x601A258")]
	[Address(RVA = "0x2BC83B4", Offset = "0x2BC83B4", VA = "0x2BC83B4")]
	public static string GetURL(int webViewId)
	{
		return null;
	}

	[Token(Token = "0x601A259")]
	[Address(RVA = "0x2BC84EC", Offset = "0x2BC84EC", VA = "0x2BC84EC")]
	public static float GetLoadingProgress(int webViewId)
	{
		return default(float);
	}

	[Token(Token = "0x601A25A")]
	[Address(RVA = "0x2BC8630", Offset = "0x2BC8630", VA = "0x2BC8630")]
	public static bool IsLoading(int webViewId)
	{
		return default(bool);
	}

	[Token(Token = "0x601A25B")]
	[Address(RVA = "0x2BC87EC", Offset = "0x2BC87EC", VA = "0x2BC87EC")]
	public static void SetNameInJavaScript(string name)
	{
	}

	[Token(Token = "0x601A25C")]
	[Address(RVA = "0x2BCB024", Offset = "0x2BCB024", VA = "0x2BCB024")]
	public static void RunJavaScript(int webViewId, string jsCode, string callback, string id)
	{
	}

	[Token(Token = "0x601A25D")]
	[Address(RVA = "0x2BCC070", Offset = "0x2BCC070", VA = "0x2BCC070")]
	public static void ClearData()
	{
	}

	[Token(Token = "0x601A25E")]
	[Address(RVA = "0x2BCC110", Offset = "0x2BCC110", VA = "0x2BCC110")]
	public static void Show(int webViewId)
	{
	}

	[Token(Token = "0x601A25F")]
	[Address(RVA = "0x2BCC23C", Offset = "0x2BCC23C", VA = "0x2BCC23C")]
	public static void Hide(int webViewId)
	{
	}

	[Token(Token = "0x601A260")]
	[Address(RVA = "0x2BCC36C", Offset = "0x2BCC36C", VA = "0x2BCC36C")]
	public static bool CanCaptureScreenshot()
	{
		return default(bool);
	}

	[Token(Token = "0x601A261")]
	[Address(RVA = "0x2BCC564", Offset = "0x2BCC564", VA = "0x2BCC564")]
	public static bool CaptureScreenshot(int webViewId, string fileName)
	{
		return default(bool);
	}

	[Token(Token = "0x601A262")]
	[Address(RVA = "0x2BC77B0", Offset = "0x2BC77B0", VA = "0x2BC77B0")]
	public static void GetUserAgentString(int webViewId)
	{
	}

	[Token(Token = "0x601A263")]
	[Address(RVA = "0x2BC78DC", Offset = "0x2BC78DC", VA = "0x2BC78DC")]
	public static void SetUserAgentString(int webViewId, string userAgentString)
	{
	}

	[Token(Token = "0x601A264")]
	[Address(RVA = "0x2BCC6F0", Offset = "0x2BCC6F0", VA = "0x2BCC6F0")]
	public static bool SupportCustomTabs()
	{
		return default(bool);
	}

	[Token(Token = "0x601A265")]
	[Address(RVA = "0x2BCC79C", Offset = "0x2BCC79C", VA = "0x2BCC79C")]
	public static void OpenCustomTabs(string url)
	{
	}
}
