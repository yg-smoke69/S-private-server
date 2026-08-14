using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2003AB8")]
public class WebView
{
	[Token(Token = "0x2003AB9")]
	public class Rect
	{
		[Token(Token = "0x4018F6F")]
		[FieldOffset(Offset = "0x8")]
		public float x;

		[Token(Token = "0x4018F70")]
		[FieldOffset(Offset = "0xC")]
		public float y;

		[Token(Token = "0x4018F71")]
		[FieldOffset(Offset = "0x10")]
		public float width;

		[Token(Token = "0x4018F72")]
		[FieldOffset(Offset = "0x14")]
		public float height;

		[Token(Token = "0x601742A")]
		[Address(RVA = "0x21B8234", Offset = "0x21B8234", VA = "0x21B8234")]
		public Rect()
		{
		}

		[Token(Token = "0x601742B")]
		[Address(RVA = "0x21B823C", Offset = "0x21B823C", VA = "0x21B823C")]
		public Rect(UIWidget widget)
		{
		}
	}

	[Token(Token = "0x2003ABA")]
	private class AndroidWebViewUserAgentStringModification
	{
		[Token(Token = "0x4018F73")]
		[FieldOffset(Offset = "0x8")]
		public string[] Patterns;

		[Token(Token = "0x4018F74")]
		[FieldOffset(Offset = "0xC")]
		public Func<string, string> Mod;

		[Token(Token = "0x601742C")]
		[Address(RVA = "0x21B0088", Offset = "0x21B0088", VA = "0x21B0088")]
		public AndroidWebViewUserAgentStringModification()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2003ABB")]
	private class QualityLevel
	{
		[Token(Token = "0x4018F75")]
		[FieldOffset(Offset = "0x8")]
		public int level;

		[Token(Token = "0x4018F76")]
		[FieldOffset(Offset = "0xC")]
		public string name;

		[Token(Token = "0x601742D")]
		[Address(RVA = "0x21B5C6C", Offset = "0x21B5C6C", VA = "0x21B5C6C")]
		public QualityLevel()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2003ABC")]
	private class WebViewCaptureScreenshotResult
	{
		[Token(Token = "0x4018F77")]
		[FieldOffset(Offset = "0x8")]
		public string Error;

		[Token(Token = "0x4018F78")]
		[FieldOffset(Offset = "0xC")]
		public int[] Platforms;

		[Token(Token = "0x601742E")]
		[Address(RVA = "0x21B6C7C", Offset = "0x21B6C7C", VA = "0x21B6C7C")]
		public WebViewCaptureScreenshotResult()
		{
		}
	}

	[Token(Token = "0x2003ABD")]
	public static class WebPage
	{
		[Token(Token = "0x170016EA")]
		public static bool AnimateOpenClose
		{
			[Token(Token = "0x601742F")]
			[Address(RVA = "0x21B8530", Offset = "0x21B8530", VA = "0x21B8530")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6017430")]
		[Address(RVA = "0x21B8580", Offset = "0x21B8580", VA = "0x21B8580")]
		public static bool IsSupported()
		{
			return default(bool);
		}

		[Token(Token = "0x6017431")]
		[Address(RVA = "0x21B8640", Offset = "0x21B8640", VA = "0x21B8640")]
		public static void OpenWebPage(string url)
		{
		}
	}

	[Token(Token = "0x2003ABE")]
	private sealed class _003CCheckForFaulty_003Ec__AnonStorey0
	{
		[Token(Token = "0x4018F79")]
		[FieldOffset(Offset = "0x8")]
		internal Action<bool> callback;

		[Token(Token = "0x6017432")]
		[Address(RVA = "0x21B1248", Offset = "0x21B1248", VA = "0x21B1248")]
		public _003CCheckForFaulty_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6017433")]
		[Address(RVA = "0x21B7328", Offset = "0x21B7328", VA = "0x21B7328")]
		internal void _003C_003Em__0(bool b)
		{
		}
	}

	[Token(Token = "0x2003ABF")]
	private sealed class _003CCheck_003Ec__AnonStorey1
	{
		[Token(Token = "0x4018F7A")]
		[FieldOffset(Offset = "0x8")]
		internal Action onContinue;

		[Token(Token = "0x4018F7B")]
		[FieldOffset(Offset = "0xC")]
		internal string text;

		[Token(Token = "0x6017434")]
		[Address(RVA = "0x21B2144", Offset = "0x21B2144", VA = "0x21B2144")]
		public _003CCheck_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6017435")]
		[Address(RVA = "0x21B6EC4", Offset = "0x21B6EC4", VA = "0x21B6EC4")]
		internal void _003C_003Em__0(bool faulty)
		{
		}
	}

	[Token(Token = "0x2003AC0")]
	private sealed class _003COnGetUserAgent_003Ec__AnonStorey2
	{
		[Token(Token = "0x4018F7C")]
		[FieldOffset(Offset = "0x8")]
		internal string promiseId;

		[Token(Token = "0x6017436")]
		[Address(RVA = "0x21B53F8", Offset = "0x21B53F8", VA = "0x21B53F8")]
		public _003COnGetUserAgent_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x6017437")]
		[Address(RVA = "0x21B818C", Offset = "0x21B818C", VA = "0x21B818C")]
		internal void _003C_003Em__0(int _webViewId, string userAgent)
		{
		}
	}

	[Token(Token = "0x2003AC1")]
	private sealed class _003COnCaptureAndShareScreenshot_003Ec__AnonStorey3
	{
		[Token(Token = "0x4018F7D")]
		[FieldOffset(Offset = "0x8")]
		internal int webViewId;

		[Token(Token = "0x4018F7E")]
		[FieldOffset(Offset = "0xC")]
		internal string promiseId;

		[Token(Token = "0x4018F7F")]
		[FieldOffset(Offset = "0x0")]
		private static Converter<int, string> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x6017438")]
		[Address(RVA = "0x21B6C74", Offset = "0x21B6C74", VA = "0x21B6C74")]
		public _003COnCaptureAndShareScreenshot_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x6017439")]
		[Address(RVA = "0x21B73E4", Offset = "0x21B73E4", VA = "0x21B73E4")]
		internal void _003C_003Em__0(string filePath)
		{
		}

		[Token(Token = "0x601743A")]
		[Address(RVA = "0x21B7954", Offset = "0x21B7954", VA = "0x21B7954")]
		internal void _003C_003Em__1(string error)
		{
		}

		[Token(Token = "0x601743B")]
		[Address(RVA = "0x21B7AFC", Offset = "0x21B7AFC", VA = "0x21B7AFC")]
		internal void _003C_003Em__2()
		{
		}

		[Token(Token = "0x601743C")]
		[Address(RVA = "0x21B8168", Offset = "0x21B8168", VA = "0x21B8168")]
		private static string _003C_003Em__3(int i)
		{
			return null;
		}
	}

	[Token(Token = "0x4018F55")]
	[FieldOffset(Offset = "0x8")]
	private int m_Handler;

	[Token(Token = "0x4018F56")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<int, WebView> _HandlerToInstances;

	[Token(Token = "0x4018F57")]
	[FieldOffset(Offset = "0xC")]
	public bool IsShow;

	[Token(Token = "0x4018F58")]
	[FieldOffset(Offset = "0x4")]
	private static bool _003CFaulty_003Ek__BackingField;

	[Token(Token = "0x4018F59")]
	[FieldOffset(Offset = "0x5")]
	private static bool _003CCheckedForFaulty_003Ek__BackingField;

	[Token(Token = "0x4018F5A")]
	[FieldOffset(Offset = "0x6")]
	private static bool promptedFaulty;

	[Token(Token = "0x4018F5B")]
	[FieldOffset(Offset = "0x8")]
	private static readonly AndroidWebViewUserAgentStringModification[] _AndroidWebViewUserAgentStringModifications;

	[Token(Token = "0x4018F5C")]
	[FieldOffset(Offset = "0x10")]
	private UIBaseController _UIBaseController;

	[Token(Token = "0x4018F5D")]
	[FieldOffset(Offset = "0x14")]
	private string _Url;

	[Token(Token = "0x4018F5E")]
	private const string WEBVIEW_CAPTURE_SCREENSHOT_FILE_NAME = "WebViewScreenshot";

	[Token(Token = "0x4018F5F")]
	[FieldOffset(Offset = "0x18")]
	private List<int> _SharedPlatforms;

	[Token(Token = "0x4018F60")]
	[FieldOffset(Offset = "0xC")]
	private static Action<string> _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x4018F61")]
	[FieldOffset(Offset = "0x10")]
	private static Action<string> _003C_003Ef__mg_0024cache1;

	[Token(Token = "0x4018F62")]
	[FieldOffset(Offset = "0x14")]
	private static Action<string> _003C_003Ef__mg_0024cache2;

	[Token(Token = "0x4018F63")]
	[FieldOffset(Offset = "0x18")]
	private static Action<string, string[], int, string> _003C_003Ef__mg_0024cache3;

	[Token(Token = "0x4018F64")]
	[FieldOffset(Offset = "0x1C")]
	private static Action<string, string[], int, string> _003C_003Ef__mg_0024cache4;

	[Token(Token = "0x4018F65")]
	[FieldOffset(Offset = "0x20")]
	private static Action<string, string[], int, string> _003C_003Ef__mg_0024cache5;

	[Token(Token = "0x4018F66")]
	[FieldOffset(Offset = "0x24")]
	private static Action<string, string[], int, string> _003C_003Ef__mg_0024cache6;

	[Token(Token = "0x4018F67")]
	[FieldOffset(Offset = "0x28")]
	private static Action<string, string[], int, string> _003C_003Ef__mg_0024cache7;

	[Token(Token = "0x4018F68")]
	[FieldOffset(Offset = "0x2C")]
	private static Action<string, string[], int, string> _003C_003Ef__mg_0024cache8;

	[Token(Token = "0x4018F69")]
	[FieldOffset(Offset = "0x30")]
	private static Action<string, string[], int, string> _003C_003Ef__mg_0024cache9;

	[Token(Token = "0x4018F6A")]
	[FieldOffset(Offset = "0x34")]
	private static Action<string, string[], int, string> _003C_003Ef__mg_0024cacheA;

	[Token(Token = "0x4018F6B")]
	[FieldOffset(Offset = "0x38")]
	private static Action<string, string[], int, string> _003C_003Ef__mg_0024cacheB;

	[Token(Token = "0x4018F6C")]
	[FieldOffset(Offset = "0x3C")]
	private static Action<string, string[], int, string> _003C_003Ef__mg_0024cacheC;

	[Token(Token = "0x4018F6D")]
	[FieldOffset(Offset = "0x40")]
	private static Action<string, string[], int, string> _003C_003Ef__mg_0024cacheD;

	[Token(Token = "0x4018F6E")]
	[FieldOffset(Offset = "0x44")]
	private static Action _003C_003Ef__mg_0024cacheE;

	[Token(Token = "0x170016E0")]
	public static bool PromptFaulty
	{
		[Token(Token = "0x60173F9")]
		[Address(RVA = "0x21B0908", Offset = "0x21B0908", VA = "0x21B0908")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170016E1")]
	public static bool FallbackToBrowser
	{
		[Token(Token = "0x60173FA")]
		[Address(RVA = "0x21B0A4C", Offset = "0x21B0A4C", VA = "0x21B0A4C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170016E2")]
	private static bool ShouldCheckForFaulty
	{
		[Token(Token = "0x60173FB")]
		[Address(RVA = "0x21B0B90", Offset = "0x21B0B90", VA = "0x21B0B90")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170016E3")]
	public static bool Faulty
	{
		[Token(Token = "0x60173FC")]
		[Address(RVA = "0x21B0C6C", Offset = "0x21B0C6C", VA = "0x21B0C6C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60173FD")]
		[Address(RVA = "0x21B0CF8", Offset = "0x21B0CF8", VA = "0x21B0CF8")]
		private set
		{
		}
	}

	[Token(Token = "0x170016E4")]
	private static bool CheckedForFaulty
	{
		[Token(Token = "0x60173FE")]
		[Address(RVA = "0x21B0D88", Offset = "0x21B0D88", VA = "0x21B0D88")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60173FF")]
		[Address(RVA = "0x21B0E14", Offset = "0x21B0E14", VA = "0x21B0E14")]
		set
		{
		}
	}

	[Token(Token = "0x170016E5")]
	public static string NameInJavaScript
	{
		[Token(Token = "0x6017404")]
		[Address(RVA = "0x21B14F4", Offset = "0x21B14F4", VA = "0x21B14F4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016E6")]
	public static bool RunJavaScriptAllowed
	{
		[Token(Token = "0x6017405")]
		[Address(RVA = "0x21B1638", Offset = "0x21B1638", VA = "0x21B1638")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170016E7")]
	public static bool DeferredDisplay
	{
		[Token(Token = "0x6017406")]
		[Address(RVA = "0x21B177C", Offset = "0x21B177C", VA = "0x21B177C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170016E8")]
	public static bool DisableJavaScriptInjection
	{
		[Token(Token = "0x6017408")]
		[Address(RVA = "0x21B1CBC", Offset = "0x21B1CBC", VA = "0x21B1CBC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170016E9")]
	public static bool DisableMediaManipulationOnHideAndShow
	{
		[Token(Token = "0x6017409")]
		[Address(RVA = "0x21B1E00", Offset = "0x21B1E00", VA = "0x21B1E00")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60173F5")]
	[Address(RVA = "0x21AF2CC", Offset = "0x21AF2CC", VA = "0x21AF2CC")]
	static WebView()
	{
	}

	[Token(Token = "0x60173F6")]
	[Address(RVA = "0x21B0090", Offset = "0x21B0090", VA = "0x21B0090")]
	public WebView(UIBaseController controller)
	{
	}

	[Token(Token = "0x60173F7")]
	[Address(RVA = "0x21B00B0", Offset = "0x21B00B0", VA = "0x21B00B0")]
	private static void ForceCloseAll(string msg)
	{
	}

	[Token(Token = "0x60173F8")]
	[Address(RVA = "0x21B04A4", Offset = "0x21B04A4", VA = "0x21B04A4")]
	public static WebViewSettingData GetSettingData(string url)
	{
		return null;
	}

	[Token(Token = "0x6017400")]
	[Address(RVA = "0x21B0EA4", Offset = "0x21B0EA4", VA = "0x21B0EA4")]
	private static void CheckForFaulty(Action<bool> callback)
	{
	}

	[Token(Token = "0x6017401")]
	[Address(RVA = "0x21B1250", Offset = "0x21B1250", VA = "0x21B1250")]
	public static void ConfigureForStartup()
	{
	}

	[Token(Token = "0x6017402")]
	[Address(RVA = "0x21B1374", Offset = "0x21B1374", VA = "0x21B1374")]
	public static void ConfigureForFrontEnd()
	{
	}

	[Token(Token = "0x6017403")]
	[Address(RVA = "0x21B1310", Offset = "0x21B1310", VA = "0x21B1310")]
	public static void Configure(bool useActivity)
	{
	}

	[Token(Token = "0x6017407")]
	[Address(RVA = "0x21B18C0", Offset = "0x21B18C0", VA = "0x21B18C0")]
	public static bool AutoPlayMedia(string networkType, string url)
	{
		return default(bool);
	}

	[Token(Token = "0x601740A")]
	[Address(RVA = "0x21B1F44", Offset = "0x21B1F44", VA = "0x21B1F44")]
	public static void Check(string text, Action onContinue)
	{
	}

	[Token(Token = "0x601740B")]
	[Address(RVA = "0x21B214C", Offset = "0x21B214C", VA = "0x21B214C")]
	private static void OnDeepLink(string deepLinkUrl, string[] parameters, int webViewId, string promiseId)
	{
	}

	[Token(Token = "0x601740C")]
	[Address(RVA = "0x21B24A0", Offset = "0x21B24A0", VA = "0x21B24A0")]
	private void ApplyAndroidWebViewUserAgentStringModifications(int webViewId, string url)
	{
	}

	[Token(Token = "0x601740D")]
	[Address(RVA = "0x21B25D4", Offset = "0x21B25D4", VA = "0x21B25D4")]
	private void OnGetAndroidWebViewUserAgentStringForModifications(int webViewId, string userAgentString)
	{
	}

	[Token(Token = "0x601740E")]
	[Address(RVA = "0x21B2E20", Offset = "0x21B2E20", VA = "0x21B2E20")]
	public void Open(string url, Rect rect, [Optional] bool? scaling, [Optional] bool? cookie, bool needCheck = true, bool forcePlay = false)
	{
	}

	[Token(Token = "0x601740F")]
	[Address(RVA = "0x21B3C04", Offset = "0x21B3C04", VA = "0x21B3C04")]
	public void ShowWebView()
	{
	}

	[Token(Token = "0x6017410")]
	[Address(RVA = "0x21B3D2C", Offset = "0x21B3D2C", VA = "0x21B3D2C")]
	public void HideWebView()
	{
	}

	[Token(Token = "0x6017411")]
	[Address(RVA = "0x21B3E54", Offset = "0x21B3E54", VA = "0x21B3E54")]
	public static bool HasWebViewShowNow()
	{
		return default(bool);
	}

	[Token(Token = "0x6017412")]
	[Address(RVA = "0x21B4088", Offset = "0x21B4088", VA = "0x21B4088")]
	public void RunJavaScript(string jsCode, string id, Action<int, UnityWebView.JavaScriptResult> callback)
	{
	}

	[Token(Token = "0x6017413")]
	[Address(RVA = "0x21B4250", Offset = "0x21B4250", VA = "0x21B4250")]
	public void Close()
	{
	}

	[Token(Token = "0x6017414")]
	[Address(RVA = "0x21B4468", Offset = "0x21B4468", VA = "0x21B4468")]
	public static void CloseAll()
	{
	}

	[Token(Token = "0x6017415")]
	[Address(RVA = "0x21B4594", Offset = "0x21B4594", VA = "0x21B4594")]
	public bool IsOpen()
	{
		return default(bool);
	}

	[Token(Token = "0x6017416")]
	[Address(RVA = "0x21B4600", Offset = "0x21B4600", VA = "0x21B4600")]
	public bool IsLoading()
	{
		return default(bool);
	}

	[Token(Token = "0x6017417")]
	[Address(RVA = "0x21B46D0", Offset = "0x21B46D0", VA = "0x21B46D0")]
	public float GetLoadingProgress()
	{
		return default(float);
	}

	[Token(Token = "0x6017418")]
	[Address(RVA = "0x21B47A0", Offset = "0x21B47A0", VA = "0x21B47A0")]
	public void Reload()
	{
	}

	[Token(Token = "0x6017419")]
	[Address(RVA = "0x21B4DAC", Offset = "0x21B4DAC", VA = "0x21B4DAC")]
	public string GetURL()
	{
		return null;
	}

	[Token(Token = "0x601741A")]
	[Address(RVA = "0x21B4E7C", Offset = "0x21B4E7C", VA = "0x21B4E7C")]
	public void GoBackward()
	{
	}

	[Token(Token = "0x601741B")]
	[Address(RVA = "0x21B4F4C", Offset = "0x21B4F4C", VA = "0x21B4F4C")]
	public void GoForward()
	{
	}

	[Token(Token = "0x601741C")]
	[Address(RVA = "0x21B501C", Offset = "0x21B501C", VA = "0x21B501C")]
	private static void OnGetAudioVolume(string channel, string[] parameters, int webViewId, string promiseId)
	{
	}

	[Token(Token = "0x601741D")]
	[Address(RVA = "0x21B528C", Offset = "0x21B528C", VA = "0x21B528C")]
	private static void OnGetUserAgent(string param, string[] parameters, int webViewId, string promiseId)
	{
	}

	[Token(Token = "0x601741E")]
	[Address(RVA = "0x21B5400", Offset = "0x21B5400", VA = "0x21B5400")]
	private static void OnGetNetworkType(string param, string[] parameters, int webViewId, string promiseId)
	{
	}

	[Token(Token = "0x601741F")]
	[Address(RVA = "0x21B550C", Offset = "0x21B550C", VA = "0x21B550C")]
	private static void OnGetMailAppealInfo(string param, string[] parameters, int webViewId, string promiseId)
	{
	}

	[Token(Token = "0x6017420")]
	[Address(RVA = "0x21B58BC", Offset = "0x21B58BC", VA = "0x21B58BC")]
	private static void OnGetQuality(string param, string[] parameters, int webViewId, string promiseId)
	{
	}

	[Token(Token = "0x6017421")]
	[Address(RVA = "0x21B5C74", Offset = "0x21B5C74", VA = "0x21B5C74")]
	private static void OnGetLiveTvEsportsReserve(string param, string[] parameters, int webViewId, string promiseId)
	{
	}

	[Token(Token = "0x6017422")]
	[Address(RVA = "0x21B61EC", Offset = "0x21B61EC", VA = "0x21B61EC")]
	private static void OnGoToInternalBrowser(string param, string[] parameters, int webViewId, string promiseId)
	{
	}

	[Token(Token = "0x6017423")]
	[Address(RVA = "0x21B652C", Offset = "0x21B652C", VA = "0x21B652C")]
	private static void OnEsportsAnnouncement(string param, string[] parameters, int webViewId, string promiseId)
	{
	}

	[Token(Token = "0x6017424")]
	[Address(RVA = "0x21B69E0", Offset = "0x21B69E0", VA = "0x21B69E0")]
	private static void OnCanCaptureScreenshot(string param, string[] parameters, int webViewId, string promiseId)
	{
	}

	[Token(Token = "0x6017425")]
	[Address(RVA = "0x21B6B5C", Offset = "0x21B6B5C", VA = "0x21B6B5C")]
	public void OnShareImage(bool success, int platform)
	{
	}

	[Token(Token = "0x6017426")]
	[Address(RVA = "0x21B4948", Offset = "0x21B4948", VA = "0x21B4948")]
	private static void OnCaptureAndShareScreenshot(string param, string[] parameters, int webViewId, string promiseId)
	{
	}

	[Token(Token = "0x6017427")]
	[Address(RVA = "0x21B6C84", Offset = "0x21B6C84", VA = "0x21B6C84")]
	public static bool CanClearData()
	{
		return default(bool);
	}

	[Token(Token = "0x6017428")]
	[Address(RVA = "0x21B6D44", Offset = "0x21B6D44", VA = "0x21B6D44")]
	public static void ClearData()
	{
	}

	[Token(Token = "0x6017429")]
	[Address(RVA = "0x21B6E04", Offset = "0x21B6E04", VA = "0x21B6E04")]
	private static string _003C_AndroidWebViewUserAgentStringModifications_003Em__0(string userAgentString)
	{
		return null;
	}
}
