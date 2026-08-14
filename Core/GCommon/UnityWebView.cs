using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2004024")]
public static class UnityWebView
{
	[Serializable]
	[Token(Token = "0x2004025")]
	public class WebViewParameters
	{
		[Token(Token = "0x401AFF4")]
		[FieldOffset(Offset = "0x8")]
		public string UnitySendMessageGameObjectName;

		[Token(Token = "0x401AFF5")]
		[FieldOffset(Offset = "0xC")]
		public bool Scaling;

		[Token(Token = "0x401AFF6")]
		[FieldOffset(Offset = "0xD")]
		public bool UseCookie;

		[Token(Token = "0x401AFF7")]
		[FieldOffset(Offset = "0xE")]
		public bool DeferredDisplay;

		[Token(Token = "0x401AFF8")]
		[FieldOffset(Offset = "0xF")]
		public bool AutoPlayMedia;

		[Token(Token = "0x401AFF9")]
		[FieldOffset(Offset = "0x10")]
		public bool ExtraLog;

		[Token(Token = "0x401AFFA")]
		[FieldOffset(Offset = "0x11")]
		public bool HardwareAcceleration;

		[Token(Token = "0x601A21F")]
		[Address(RVA = "0x2BCCB00", Offset = "0x2BCCB00", VA = "0x2BCCB00")]
		public WebViewParameters()
		{
		}
	}

	[Token(Token = "0x2004026")]
	private class JavaScriptMessageHandler
	{
		[Token(Token = "0x401AFFB")]
		[FieldOffset(Offset = "0x8")]
		public string[] Parameters;

		[Token(Token = "0x401AFFC")]
		[FieldOffset(Offset = "0xC")]
		public Action<string, string[], int, string> Handler;

		[Token(Token = "0x601A220")]
		[Address(RVA = "0x2BC8B9C", Offset = "0x2BC8B9C", VA = "0x2BC8B9C")]
		public JavaScriptMessageHandler()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2004027")]
	public class JavaScriptResult
	{
		[Token(Token = "0x401AFFD")]
		[FieldOffset(Offset = "0x8")]
		public string id;

		[Token(Token = "0x401AFFE")]
		[FieldOffset(Offset = "0xC")]
		public string callback;

		[Token(Token = "0x401AFFF")]
		[FieldOffset(Offset = "0x10")]
		public string error;

		[Token(Token = "0x401B000")]
		[FieldOffset(Offset = "0x14")]
		public string value;

		[Token(Token = "0x601A221")]
		[Address(RVA = "0x2BCCAF8", Offset = "0x2BCCAF8", VA = "0x2BCCAF8")]
		public JavaScriptResult()
		{
		}
	}

	[Token(Token = "0x401AFE3")]
	[FieldOffset(Offset = "0x0")]
	private static string _003CJavaScriptName_003Ek__BackingField;

	[Token(Token = "0x401AFE4")]
	[FieldOffset(Offset = "0x4")]
	private static Action<string> OnLog;

	[Token(Token = "0x401AFE5")]
	[FieldOffset(Offset = "0x8")]
	private static Action<string> OnLogError;

	[Token(Token = "0x401AFE6")]
	[FieldOffset(Offset = "0xC")]
	private static Action<string> OnForceCloseAll;

	[Token(Token = "0x401AFE7")]
	[FieldOffset(Offset = "0x10")]
	private static bool _003CUseJavaScriptInjection_003Ek__BackingField;

	[Token(Token = "0x401AFE8")]
	[FieldOffset(Offset = "0x11")]
	private static bool _003CUseMediaManipulationOnHideAndShowByJavaScript_003Ek__BackingField;

	[Token(Token = "0x401AFE9")]
	[FieldOffset(Offset = "0x14")]
	private static Dictionary<int, Action<int, string>> _GetUserAgentStringCallback;

	[Token(Token = "0x401AFEA")]
	[FieldOffset(Offset = "0x18")]
	private static Dictionary<int, Action<int, bool>> _CanGoBackwardCallback;

	[Token(Token = "0x401AFEB")]
	[FieldOffset(Offset = "0x1C")]
	private static Dictionary<int, Action<int, bool>> _CanGoForwardCallback;

	[Token(Token = "0x401AFEC")]
	[FieldOffset(Offset = "0x20")]
	private static Dictionary<string, JavaScriptMessageHandler> _JavaScriptMessageHandlers;

	[Token(Token = "0x401AFED")]
	private const string PROMISE_ID_KEY = "PromiseId";

	[Token(Token = "0x401AFEE")]
	[FieldOffset(Offset = "0x24")]
	private static Dictionary<int, Dictionary<string, Action<int, JavaScriptResult>>> _JavaScriptCallbacks;

	[Token(Token = "0x401AFEF")]
	[FieldOffset(Offset = "0x28")]
	private static int _JavaScriptEchoId;

	[Token(Token = "0x401AFF0")]
	[FieldOffset(Offset = "0x2C")]
	private static string _JavaScriptEchoMsg;

	[Token(Token = "0x401AFF1")]
	public const string NATIVE_TO_JAVASCRIPT_PROMISE_THEN = "nativePromiseThen";

	[Token(Token = "0x401AFF2")]
	[FieldOffset(Offset = "0x30")]
	private static Action<int, JavaScriptResult> _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x401AFF3")]
	[FieldOffset(Offset = "0x34")]
	private static MatchEvaluator _003C_003Ef__am_0024cache0;

	[Token(Token = "0x17001CAA")]
	public static string JavaScriptName
	{
		[Token(Token = "0x601A1E6")]
		[Address(RVA = "0x2BC5678", Offset = "0x2BC5678", VA = "0x2BC5678")]
		get
		{
			return null;
		}
		[Token(Token = "0x601A1E7")]
		[Address(RVA = "0x2BC5704", Offset = "0x2BC5704", VA = "0x2BC5704")]
		private set
		{
		}
	}

	[Token(Token = "0x17001CAB")]
	public static bool UseJavaScriptInjection
	{
		[Token(Token = "0x601A1EF")]
		[Address(RVA = "0x2BC5DE4", Offset = "0x2BC5DE4", VA = "0x2BC5DE4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601A1F0")]
		[Address(RVA = "0x2BC5E70", Offset = "0x2BC5E70", VA = "0x2BC5E70")]
		set
		{
		}
	}

	[Token(Token = "0x17001CAC")]
	public static bool UseMediaManipulationOnHideAndShowByJavaScript
	{
		[Token(Token = "0x601A1F1")]
		[Address(RVA = "0x2BC5F00", Offset = "0x2BC5F00", VA = "0x2BC5F00")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601A1F2")]
		[Address(RVA = "0x2BC5F8C", Offset = "0x2BC5F8C", VA = "0x2BC5F8C")]
		set
		{
		}
	}

	[Token(Token = "0x601A1E5")]
	[Address(RVA = "0x2BC548C", Offset = "0x2BC548C", VA = "0x2BC548C")]
	public static void Init()
	{
	}

	[Token(Token = "0x601A1E8")]
	[Address(RVA = "0x2BC5794", Offset = "0x2BC5794", VA = "0x2BC5794")]
	public static void SetLogCallbacks(Action<string> onLog, Action<string> onLogError)
	{
	}

	[Token(Token = "0x601A1E9")]
	[Address(RVA = "0x2BC5830", Offset = "0x2BC5830", VA = "0x2BC5830")]
	public static void SetForceCloseAllHandler(Action<string> closeAll)
	{
	}

	[Token(Token = "0x601A1EA")]
	[Address(RVA = "0x2BC58C0", Offset = "0x2BC58C0", VA = "0x2BC58C0")]
	internal static void ForceCloseAll(string msg)
	{
	}

	[Token(Token = "0x601A1EB")]
	[Address(RVA = "0x2BC59BC", Offset = "0x2BC59BC", VA = "0x2BC59BC")]
	internal static void Log(string log)
	{
	}

	[Token(Token = "0x601A1EC")]
	[Address(RVA = "0x2BC5AB8", Offset = "0x2BC5AB8", VA = "0x2BC5AB8")]
	internal static void LogError(string logError)
	{
	}

	[Token(Token = "0x601A1ED")]
	[Address(RVA = "0x2BC5BB4", Offset = "0x2BC5BB4", VA = "0x2BC5BB4")]
	public static void SetUnitySendMessageGameObjectName(string gameObjectName)
	{
	}

	[Token(Token = "0x601A1EE")]
	[Address(RVA = "0x2BC5CB8", Offset = "0x2BC5CB8", VA = "0x2BC5CB8")]
	public static void SetSendConsoleMessagesToUnity(bool send)
	{
	}

	[Token(Token = "0x601A1F3")]
	[Address(RVA = "0x2BC601C", Offset = "0x2BC601C", VA = "0x2BC601C")]
	public static int Open(string url, float x, float y, float width, float height, WebViewParameters parameters)
	{
		return default(int);
	}

	[Token(Token = "0x601A1F4")]
	[Address(RVA = "0x2BC6968", Offset = "0x2BC6968", VA = "0x2BC6968")]
	public static void Test(Action<bool> onTestResult)
	{
	}

	[Token(Token = "0x601A1F5")]
	[Address(RVA = "0x2BC6A2C", Offset = "0x2BC6A2C", VA = "0x2BC6A2C")]
	public static bool CanFix()
	{
		return default(bool);
	}

	[Token(Token = "0x601A1F6")]
	[Address(RVA = "0x2BC6A34", Offset = "0x2BC6A34", VA = "0x2BC6A34")]
	public static void Fix()
	{
	}

	[Token(Token = "0x601A1F7")]
	[Address(RVA = "0x2BC6A94", Offset = "0x2BC6A94", VA = "0x2BC6A94")]
	public static void Close(int webViewId)
	{
	}

	[Token(Token = "0x601A1F8")]
	[Address(RVA = "0x2BC6F90", Offset = "0x2BC6F90", VA = "0x2BC6F90")]
	public static void CloseAll()
	{
	}

	[Token(Token = "0x601A1F9")]
	[Address(RVA = "0x2BC7438", Offset = "0x2BC7438", VA = "0x2BC7438")]
	public static void Reload(int webViewId)
	{
	}

	[Token(Token = "0x601A1FA")]
	[Address(RVA = "0x2BC7564", Offset = "0x2BC7564", VA = "0x2BC7564")]
	internal static void OnGetUserAgentString(int webViewId, string userAgentString)
	{
	}

	[Token(Token = "0x601A1FB")]
	[Address(RVA = "0x2BC76E4", Offset = "0x2BC76E4", VA = "0x2BC76E4")]
	public static void GetUserAgentString(int webViewId, Action<int, string> callback)
	{
	}

	[Token(Token = "0x601A1FC")]
	[Address(RVA = "0x2BC78D8", Offset = "0x2BC78D8", VA = "0x2BC78D8")]
	public static void SetUserAgentString(int webViewId, string userAgentString)
	{
	}

	[Token(Token = "0x601A1FD")]
	[Address(RVA = "0x2BC7A58", Offset = "0x2BC7A58", VA = "0x2BC7A58")]
	internal static void OnCanGoBackward(int webViewId, bool result)
	{
	}

	[Token(Token = "0x601A1FE")]
	[Address(RVA = "0x2BC7BD8", Offset = "0x2BC7BD8", VA = "0x2BC7BD8")]
	public static void CanGoBackward(int webViewId, Action<int, bool> callback)
	{
	}

	[Token(Token = "0x601A1FF")]
	[Address(RVA = "0x2BC7DD8", Offset = "0x2BC7DD8", VA = "0x2BC7DD8")]
	internal static void OnCanGoForward(int webViewId, bool result)
	{
	}

	[Token(Token = "0x601A200")]
	[Address(RVA = "0x2BC7F58", Offset = "0x2BC7F58", VA = "0x2BC7F58")]
	public static void CanGoForward(int webViewId, Action<int, bool> callback)
	{
	}

	[Token(Token = "0x601A201")]
	[Address(RVA = "0x2BC8158", Offset = "0x2BC8158", VA = "0x2BC8158")]
	public static void GoBackward(int webViewId)
	{
	}

	[Token(Token = "0x601A202")]
	[Address(RVA = "0x2BC8284", Offset = "0x2BC8284", VA = "0x2BC8284")]
	public static void GoForward(int webViewId)
	{
	}

	[Token(Token = "0x601A203")]
	[Address(RVA = "0x2BC83B0", Offset = "0x2BC83B0", VA = "0x2BC83B0")]
	public static string GetURL(int webViewId)
	{
		return null;
	}

	[Token(Token = "0x601A204")]
	[Address(RVA = "0x2BC84E8", Offset = "0x2BC84E8", VA = "0x2BC84E8")]
	public static float GetLoadingProgress(int webViewId)
	{
		return default(float);
	}

	[Token(Token = "0x601A205")]
	[Address(RVA = "0x2BC862C", Offset = "0x2BC862C", VA = "0x2BC862C")]
	public static bool IsLoading(int webViewId)
	{
		return default(bool);
	}

	[Token(Token = "0x601A206")]
	[Address(RVA = "0x2BC8764", Offset = "0x2BC8764", VA = "0x2BC8764")]
	public static void SetNameInJavaScript(string name)
	{
	}

	[Token(Token = "0x601A207")]
	[Address(RVA = "0x2BC88EC", Offset = "0x2BC88EC", VA = "0x2BC88EC")]
	public static void RegisterJavaScriptMessageHandler(string msg, string[] parameters, Action<string, string[], int, string> handler)
	{
	}

	[Token(Token = "0x601A208")]
	[Address(RVA = "0x2BC8BA4", Offset = "0x2BC8BA4", VA = "0x2BC8BA4")]
	public static void UnregisterJavaScriptMessageHandler(string msg)
	{
	}

	[Token(Token = "0x601A209")]
	[Address(RVA = "0x2BC8D18", Offset = "0x2BC8D18", VA = "0x2BC8D18")]
	public static void MessageHandlerReturnToJavaScript(int webViewId, string promiseId, string result, bool error = false)
	{
	}

	[Token(Token = "0x601A20A")]
	[Address(RVA = "0x2BC978C", Offset = "0x2BC978C", VA = "0x2BC978C")]
	internal static void OnJavaScriptPostMessage(int webViewId, string msg)
	{
	}

	[Token(Token = "0x601A20B")]
	[Address(RVA = "0x2BCA5EC", Offset = "0x2BCA5EC", VA = "0x2BCA5EC")]
	private static string JavaScriptResultCallbackString(int webViewId, Action<int, JavaScriptResult> callback)
	{
		return null;
	}

	[Token(Token = "0x601A20C")]
	[Address(RVA = "0x2BCA984", Offset = "0x2BCA984", VA = "0x2BCA984")]
	private static string SetJavaScriptCallback(int webViewId, Action<int, JavaScriptResult> callback)
	{
		return null;
	}

	[Token(Token = "0x601A20D")]
	[Address(RVA = "0x2BCAC64", Offset = "0x2BCAC64", VA = "0x2BCAC64")]
	internal static void DoJavaScriptCallback(int webViewId, JavaScriptResult result)
	{
	}

	[Token(Token = "0x601A20E")]
	[Address(RVA = "0x2BC6D30", Offset = "0x2BC6D30", VA = "0x2BC6D30")]
	private static void ClearJavaScriptCallbacks(int webViewId)
	{
	}

	[Token(Token = "0x601A20F")]
	[Address(RVA = "0x2BC7100", Offset = "0x2BC7100", VA = "0x2BC7100")]
	private static void ClearAllJavaScriptCallbacks()
	{
	}

	[Token(Token = "0x601A210")]
	[Address(RVA = "0x2BC9504", Offset = "0x2BC9504", VA = "0x2BC9504")]
	public static void RunJavaScript(int webViewId, string jsCode, string id, Action<int, JavaScriptResult> callback)
	{
	}

	[Token(Token = "0x601A211")]
	[Address(RVA = "0x2BCB248", Offset = "0x2BCB248", VA = "0x2BCB248")]
	public static void JavaScriptEcho(int webViewId, string msg)
	{
	}

	[Token(Token = "0x601A212")]
	[Address(RVA = "0x2BCB5D4", Offset = "0x2BCB5D4", VA = "0x2BCB5D4")]
	private static void OnJavaScriptEchoCallback(int webViewId, JavaScriptResult jsr)
	{
	}

	[Token(Token = "0x601A213")]
	[Address(RVA = "0x2BC9070", Offset = "0x2BC9070", VA = "0x2BC9070")]
	public static string ToLiteral(string input)
	{
		return null;
	}

	[Token(Token = "0x601A214")]
	[Address(RVA = "0x2BCB934", Offset = "0x2BCB934", VA = "0x2BCB934")]
	public static string FromLiteral(string input)
	{
		return null;
	}

	[Token(Token = "0x601A215")]
	[Address(RVA = "0x2BCC064", Offset = "0x2BCC064", VA = "0x2BCC064")]
	public static bool CanClearData()
	{
		return default(bool);
	}

	[Token(Token = "0x601A216")]
	[Address(RVA = "0x2BCC06C", Offset = "0x2BCC06C", VA = "0x2BCC06C")]
	public static void ClearData()
	{
	}

	[Token(Token = "0x601A217")]
	[Address(RVA = "0x2BCC10C", Offset = "0x2BCC10C", VA = "0x2BCC10C")]
	public static void ShowWebView(int webViewId)
	{
	}

	[Token(Token = "0x601A218")]
	[Address(RVA = "0x2BCC238", Offset = "0x2BCC238", VA = "0x2BCC238")]
	public static void HideWebView(int webViewId)
	{
	}

	[Token(Token = "0x601A219")]
	[Address(RVA = "0x2BCC364", Offset = "0x2BCC364", VA = "0x2BCC364")]
	public static bool CanCaptureScreenshot()
	{
		return default(bool);
	}

	[Token(Token = "0x601A21A")]
	[Address(RVA = "0x2BCC374", Offset = "0x2BCC374", VA = "0x2BCC374")]
	public static bool CaptureScreenshot(int webViewId, string fileName, Action<string> onSuccess, Action<string> onFailure)
	{
		return default(bool);
	}

	[Token(Token = "0x601A21B")]
	[Address(RVA = "0x2BCC6EC", Offset = "0x2BCC6EC", VA = "0x2BCC6EC")]
	public static bool SupportWebPage()
	{
		return default(bool);
	}

	[Token(Token = "0x601A21C")]
	[Address(RVA = "0x2BCC798", Offset = "0x2BCC798", VA = "0x2BCC798")]
	public static void OpenWebPage(string url, bool animated)
	{
	}

	[Token(Token = "0x601A21E")]
	[Address(RVA = "0x2BCCA0C", Offset = "0x2BCCA0C", VA = "0x2BCCA0C")]
	private static string _003CFromLiteral_003Em__0(Match match)
	{
		return null;
	}
}
