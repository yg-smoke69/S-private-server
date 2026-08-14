using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2003FB0")]
public static class PlatformUtility_Android
{
	[Token(Token = "0x2003FB1")]
	private static class IntentExtra
	{
		[Token(Token = "0x401AD1F")]
		public const string TEXT = "android.intent.extra.TEXT";

		[Token(Token = "0x401AD20")]
		public const string STREAM = "android.intent.extra.STREAM";
	}

	[Token(Token = "0x2003FB2")]
	private static class IntentType
	{
		[Token(Token = "0x401AD21")]
		public const string TEXT_PLAIN = "text/plain";

		[Token(Token = "0x401AD22")]
		public const string IMAGE = "image/*";
	}

	[Token(Token = "0x2003FB3")]
	public static class Permissions
	{
		[Token(Token = "0x401AD23")]
		public const string READ_EXTERNAL_STORAGE = "android.permission.READ_EXTERNAL_STORAGE";

		[Token(Token = "0x401AD24")]
		public const string WRITE_EXTERNAL_STORAGE = "android.permission.WRITE_EXTERNAL_STORAGE";

		[Token(Token = "0x401AD25")]
		public const string READ_PHONE_STATE = "android.permission.READ_PHONE_STATE";

		[Token(Token = "0x401AD26")]
		public const string RECORD_AUDIO = "android.permission.RECORD_AUDIO";
	}

	[Token(Token = "0x2003FB4")]
	public enum PermissionGrantResult
	{
		[Token(Token = "0x401AD28")]
		Denied = -1,
		[Token(Token = "0x401AD29")]
		Granted
	}

	[Token(Token = "0x2003FB5")]
	public class RequestPermissionResult
	{
		[Token(Token = "0x401AD2A")]
		[FieldOffset(Offset = "0x8")]
		public int RequestCode;

		[Token(Token = "0x401AD2B")]
		[FieldOffset(Offset = "0xC")]
		public Dictionary<string, int> Results;

		[Token(Token = "0x6019F28")]
		[Address(RVA = "0x331AE84", Offset = "0x331AE84", VA = "0x331AE84")]
		public RequestPermissionResult()
		{
		}
	}

	[Token(Token = "0x2003FB6")]
	public delegate void OnRequestPermissionsResultCallback(RequestPermissionResult result);

	[Token(Token = "0x2003FB7")]
	public static class SYSTEM_FEATURES
	{
	}

	[Token(Token = "0x2003FB8")]
	public class ProcessMemoryInfo
	{
		[Token(Token = "0x401AD2C")]
		[FieldOffset(Offset = "0x8")]
		public int cost_ms;

		[Token(Token = "0x401AD2D")]
		[FieldOffset(Offset = "0xC")]
		public int dalvikPrivateDirty;

		[Token(Token = "0x401AD2E")]
		[FieldOffset(Offset = "0x10")]
		public int dalvikPss;

		[Token(Token = "0x401AD2F")]
		[FieldOffset(Offset = "0x14")]
		public int dalvikSharedDirty;

		[Token(Token = "0x401AD30")]
		[FieldOffset(Offset = "0x18")]
		public int nativePrivateDirty;

		[Token(Token = "0x401AD31")]
		[FieldOffset(Offset = "0x1C")]
		public int nativePss;

		[Token(Token = "0x401AD32")]
		[FieldOffset(Offset = "0x20")]
		public int nativeSharedDirty;

		[Token(Token = "0x401AD33")]
		[FieldOffset(Offset = "0x24")]
		public int otherPrivateDirty;

		[Token(Token = "0x401AD34")]
		[FieldOffset(Offset = "0x28")]
		public int otherPss;

		[Token(Token = "0x401AD35")]
		[FieldOffset(Offset = "0x2C")]
		public int otherSharedDirty;

		[Token(Token = "0x401AD36")]
		[FieldOffset(Offset = "0x30")]
		public int totalPrivateClean;

		[Token(Token = "0x401AD37")]
		[FieldOffset(Offset = "0x34")]
		public int totalPrivateDirty;

		[Token(Token = "0x401AD38")]
		[FieldOffset(Offset = "0x38")]
		public int totalPss;

		[Token(Token = "0x401AD39")]
		[FieldOffset(Offset = "0x3C")]
		public int totalSharedClean;

		[Token(Token = "0x401AD3A")]
		[FieldOffset(Offset = "0x40")]
		public int totalSharedDirty;

		[Token(Token = "0x401AD3B")]
		[FieldOffset(Offset = "0x44")]
		public int totalSwappablePss;

		[Token(Token = "0x6019F2D")]
		[Address(RVA = "0x332295C", Offset = "0x332295C", VA = "0x332295C")]
		public ProcessMemoryInfo()
		{
		}
	}

	[Token(Token = "0x2003FB9")]
	public class MemoryInfo
	{
		[Token(Token = "0x401AD3C")]
		[FieldOffset(Offset = "0x8")]
		public long availMem;

		[Token(Token = "0x401AD3D")]
		[FieldOffset(Offset = "0x10")]
		public bool lowMemory;

		[Token(Token = "0x401AD3E")]
		[FieldOffset(Offset = "0x18")]
		public long threshold;

		[Token(Token = "0x401AD3F")]
		[FieldOffset(Offset = "0x20")]
		public long totalMem;

		[Token(Token = "0x401AD40")]
		[FieldOffset(Offset = "0x28")]
		public int cost_ms;

		[Token(Token = "0x6019F2E")]
		[Address(RVA = "0x3322908", Offset = "0x3322908", VA = "0x3322908")]
		public MemoryInfo()
		{
		}
	}

	[Token(Token = "0x2003FBA")]
	public class StorageDeviceSpace
	{
		[Token(Token = "0x401AD41")]
		[FieldOffset(Offset = "0x8")]
		public long Free;

		[Token(Token = "0x401AD42")]
		[FieldOffset(Offset = "0x10")]
		public long Total;

		[Token(Token = "0x6019F2F")]
		[Address(RVA = "0x3322964", Offset = "0x3322964", VA = "0x3322964")]
		public StorageDeviceSpace()
		{
		}
	}

	[Token(Token = "0x2003FBB")]
	public static class MimeTypes
	{
		[Token(Token = "0x401AD43")]
		public const string VIDEO_AVC = "video/avc";
	}

	[Token(Token = "0x2003FBC")]
	public class GetAdvertisingIdResult
	{
		[Token(Token = "0x401AD44")]
		[FieldOffset(Offset = "0x8")]
		public string Exception;

		[Token(Token = "0x401AD45")]
		[FieldOffset(Offset = "0xC")]
		public string AdvertisingId;

		[Token(Token = "0x401AD46")]
		[FieldOffset(Offset = "0x10")]
		public string ProviderPackageName;

		[Token(Token = "0x401AD47")]
		[FieldOffset(Offset = "0x14")]
		public bool IsLimitAdTrackingEnabled;

		[Token(Token = "0x6019F30")]
		[Address(RVA = "0x33228F8", Offset = "0x33228F8", VA = "0x33228F8")]
		public GetAdvertisingIdResult()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2003FBD")]
	public class InAppReviewResult
	{
		[Token(Token = "0x401AD48")]
		[FieldOffset(Offset = "0x8")]
		public bool RequestFailure;

		[Token(Token = "0x401AD49")]
		[FieldOffset(Offset = "0x9")]
		public bool LaunchFailure;

		[Token(Token = "0x401AD4A")]
		[FieldOffset(Offset = "0xC")]
		public string ExceptionType;

		[Token(Token = "0x401AD4B")]
		[FieldOffset(Offset = "0x10")]
		public string ExceptionMessage;

		[Token(Token = "0x6019F31")]
		[Address(RVA = "0x3322900", Offset = "0x3322900", VA = "0x3322900")]
		public InAppReviewResult()
		{
		}
	}

	[Token(Token = "0x2003FBE")]
	private sealed class _003COnGetAdvertisingId_003Ec__AnonStorey0
	{
		[Token(Token = "0x401AD4C")]
		[FieldOffset(Offset = "0x8")]
		internal GetAdvertisingIdResult result;

		[Token(Token = "0x6019F32")]
		[Address(RVA = "0x331F820", Offset = "0x331F820", VA = "0x331F820")]
		public _003COnGetAdvertisingId_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6019F33")]
		[Address(RVA = "0x33227F0", Offset = "0x33227F0", VA = "0x33227F0")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2003FBF")]
	private sealed class _003COnDoneInAppReview_003Ec__AnonStorey1
	{
		[Token(Token = "0x401AD4D")]
		[FieldOffset(Offset = "0x8")]
		internal InAppReviewResult result;

		[Token(Token = "0x6019F34")]
		[Address(RVA = "0x331FAA8", Offset = "0x331FAA8", VA = "0x331FAA8")]
		public _003COnDoneInAppReview_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6019F35")]
		[Address(RVA = "0x33225DC", Offset = "0x33225DC", VA = "0x33225DC")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x401AD0E")]
	public const int PERMISSION_REQUEST_CODE = 1638;

	[Token(Token = "0x401AD0F")]
	[FieldOffset(Offset = "0x0")]
	public static string FileProviderAuthorities;

	[Token(Token = "0x401AD10")]
	[FieldOffset(Offset = "0x4")]
	private static OnRequestPermissionsResultCallback _OnRequestPermissionsResult;

	[Token(Token = "0x401AD11")]
	[FieldOffset(Offset = "0x8")]
	private static AndroidJavaClass _FFAPI;

	[Token(Token = "0x401AD12")]
	[FieldOffset(Offset = "0xC")]
	private static Dictionary<string, Action> _PositiveCallbacks;

	[Token(Token = "0x401AD13")]
	[FieldOffset(Offset = "0x10")]
	private static Dictionary<string, Action> _NegativeCallbacks;

	[Token(Token = "0x401AD14")]
	[FieldOffset(Offset = "0x14")]
	private static Dictionary<string, Action> _NeutralCallbacks;

	[Token(Token = "0x401AD15")]
	[FieldOffset(Offset = "0x18")]
	private static readonly Dictionary<string, string[]> _EmulatorFiles;

	[Token(Token = "0x401AD16")]
	[FieldOffset(Offset = "0x1C")]
	private static readonly Dictionary<string, string> _EmulatorProperties;

	[Token(Token = "0x401AD17")]
	private const int PROPERTIES_THRESHOLD = 5;

	[Token(Token = "0x401AD18")]
	[FieldOffset(Offset = "0x20")]
	private static readonly string[] _EmulatorPackageNames;

	[Token(Token = "0x401AD19")]
	public const string CODEC_NAME_PREFIX_SOFTWARE = "OMX.google.";

	[Token(Token = "0x401AD1A")]
	[FieldOffset(Offset = "0x24")]
	private static Action<GetAdvertisingIdResult> _GetAdvertisingIdCallback;

	[Token(Token = "0x401AD1B")]
	[FieldOffset(Offset = "0x28")]
	private static Action<bool> _DoInAppReviewCallback;

	[Token(Token = "0x401AD1C")]
	[FieldOffset(Offset = "0x2C")]
	private static AndroidJavaClass _FFLocalNotification;

	[Token(Token = "0x401AD1D")]
	[FieldOffset(Offset = "0x30")]
	private static Func<byte, string> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x401AD1E")]
	[FieldOffset(Offset = "0x34")]
	private static Comparison<string> _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x17001C53")]
	private static AndroidJavaClass FFAPI
	{
		[Token(Token = "0x6019EB5")]
		[Address(RVA = "0x3317290", Offset = "0x3317290", VA = "0x3317290")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C54")]
	public static string DeviceIdentifier
	{
		[Token(Token = "0x6019EDF")]
		[Address(RVA = "0x331A804", Offset = "0x331A804", VA = "0x331A804")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C55")]
	private static AndroidJavaClass FFLocalNotification
	{
		[Token(Token = "0x6019F1A")]
		[Address(RVA = "0x331FDAC", Offset = "0x331FDAC", VA = "0x331FDAC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6019EB6")]
	[Address(RVA = "0x33173D0", Offset = "0x33173D0", VA = "0x33173D0")]
	public static int Build_VERSION_SDK_INT()
	{
		return default(int);
	}

	[Token(Token = "0x6019EB7")]
	[Address(RVA = "0x33174A4", Offset = "0x33174A4", VA = "0x33174A4")]
	public static string BuildVariant_PackageName()
	{
		return null;
	}

	[Token(Token = "0x6019EB8")]
	public static T GetAndroidManifestMetaData<T>(string packageName, string name)
	{
		return (T)null;
	}

	[Token(Token = "0x6019EB9")]
	[Address(RVA = "0x3317578", Offset = "0x3317578", VA = "0x3317578")]
	public static void NativeLog(string log)
	{
	}

	[Token(Token = "0x6019EBA")]
	[Address(RVA = "0x33176A4", Offset = "0x33176A4", VA = "0x33176A4")]
	public static bool IsGooglePlayServicesAvailable()
	{
		return default(bool);
	}

	[Token(Token = "0x6019EBB")]
	[Address(RVA = "0x3317778", Offset = "0x3317778", VA = "0x3317778")]
	public static void SetUnitySendMessageGameObjectName(string gameObjectName)
	{
	}

	[Token(Token = "0x6019EBC")]
	[Address(RVA = "0x33178A4", Offset = "0x33178A4", VA = "0x33178A4")]
	public static PermissionGrantResult CheckPermission(string permission)
	{
		return default(PermissionGrantResult);
	}

	[Token(Token = "0x6019EBD")]
	[Address(RVA = "0x33179DC", Offset = "0x33179DC", VA = "0x33179DC")]
	public static void RequestPermissions(int requestCode, string[] permissions, OnRequestPermissionsResultCallback callback)
	{
	}

	[Token(Token = "0x6019EBE")]
	[Address(RVA = "0x3317C4C", Offset = "0x3317C4C", VA = "0x3317C4C")]
	public static bool ShouldShowRequestPermissionRationale(string permission)
	{
		return default(bool);
	}

	[Token(Token = "0x6019EBF")]
	[Address(RVA = "0x3317D84", Offset = "0x3317D84", VA = "0x3317D84")]
	public static string ConvertFilePathToUri(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6019EC0")]
	[Address(RVA = "0x3317F24", Offset = "0x3317F24", VA = "0x3317F24")]
	public static PlatformUtility.OpenedWith GetOpenedWith()
	{
		return null;
	}

	[Token(Token = "0x6019EC1")]
	[Address(RVA = "0x331832C", Offset = "0x331832C", VA = "0x331832C")]
	public static void ClearOpenedWith()
	{
	}

	[Token(Token = "0x6019EC2")]
	[Address(RVA = "0x33183F4", Offset = "0x33183F4", VA = "0x33183F4")]
	public static void SetCanHandleLowMemory(bool canHandle)
	{
	}

	[Token(Token = "0x6019EC3")]
	[Address(RVA = "0x3318548", Offset = "0x3318548", VA = "0x3318548")]
	public static void CopyStringToClipboard(string content)
	{
	}

	[Token(Token = "0x6019EC4")]
	[Address(RVA = "0x33186D0", Offset = "0x33186D0", VA = "0x33186D0")]
	public static string CopyStringFromClipboard()
	{
		return null;
	}

	[Token(Token = "0x6019EC5")]
	[Address(RVA = "0x33187A4", Offset = "0x33187A4", VA = "0x33187A4")]
	public static void SaveImageToAlbum(byte[] imageData, string title, string description)
	{
	}

	[Token(Token = "0x6019EC6")]
	[Address(RVA = "0x3317BAC", Offset = "0x3317BAC", VA = "0x3317BAC")]
	public static AndroidJavaObject ToJava(string[] strings)
	{
		return null;
	}

	[Token(Token = "0x6019EC7")]
	[Address(RVA = "0x3318978", Offset = "0x3318978", VA = "0x3318978")]
	public static AndroidJavaObject ToJava(float[] floats)
	{
		return null;
	}

	[Token(Token = "0x6019EC8")]
	[Address(RVA = "0x3318A18", Offset = "0x3318A18", VA = "0x3318A18")]
	public static AndroidJavaObject ToJava(byte[] bytes)
	{
		return null;
	}

	[Token(Token = "0x6019EC9")]
	private static AndroidJavaObject ToJava<T>(T[] ts, string javaClass)
	{
		return null;
	}

	[Token(Token = "0x6019ECA")]
	[Address(RVA = "0x3318AB8", Offset = "0x3318AB8", VA = "0x3318AB8")]
	public static bool IsPackageInstalled(string bundleIdentifier)
	{
		return default(bool);
	}

	[Token(Token = "0x6019ECB")]
	[Address(RVA = "0x3318C00", Offset = "0x3318C00", VA = "0x3318C00")]
	public static bool HasSystemFeature(string feature)
	{
		return default(bool);
	}

	[Token(Token = "0x6019ECC")]
	[Address(RVA = "0x3318D38", Offset = "0x3318D38", VA = "0x3318D38")]
	public static bool SendText(string title, string text)
	{
		return default(bool);
	}

	[Token(Token = "0x6019ECD")]
	[Address(RVA = "0x3319018", Offset = "0x3319018", VA = "0x3319018")]
	public static bool SendImage(string title, string filePath, string packageName = "", string className = "")
	{
		return default(bool);
	}

	[Token(Token = "0x6019ECE")]
	[Address(RVA = "0x33193AC", Offset = "0x33193AC", VA = "0x33193AC")]
	public static int GetAppMemory()
	{
		return default(int);
	}

	[Token(Token = "0x6019ECF")]
	[Address(RVA = "0x331948C", Offset = "0x331948C", VA = "0x331948C")]
	public static ProcessMemoryInfo GetProcessMemoryInfo()
	{
		return null;
	}

	[Token(Token = "0x6019ED0")]
	[Address(RVA = "0x33196D0", Offset = "0x33196D0", VA = "0x33196D0")]
	public static MemoryInfo GetMemoryInfo()
	{
		return null;
	}

	[Token(Token = "0x6019ED1")]
	[Address(RVA = "0x3319914", Offset = "0x3319914", VA = "0x3319914")]
	public static int GetAvailMemory()
	{
		return default(int);
	}

	[Token(Token = "0x6019ED2")]
	[Address(RVA = "0x3319A00", Offset = "0x3319A00", VA = "0x3319A00")]
	public static int GetLowMemoryThreshold()
	{
		return default(int);
	}

	[Token(Token = "0x6019ED3")]
	[Address(RVA = "0x3319AEC", Offset = "0x3319AEC", VA = "0x3319AEC")]
	public static long GetSDCardAvailStorageWithByte()
	{
		return default(long);
	}

	[Token(Token = "0x6019ED4")]
	[Address(RVA = "0x3319BC0", Offset = "0x3319BC0", VA = "0x3319BC0")]
	public static long GetSDCardTotalStorageWithByte()
	{
		return default(long);
	}

	[Token(Token = "0x6019ED5")]
	[Address(RVA = "0x3319C94", Offset = "0x3319C94", VA = "0x3319C94")]
	public static long GetSystemInnerTotalStorageWithByte()
	{
		return default(long);
	}

	[Token(Token = "0x6019ED6")]
	[Address(RVA = "0x3319D68", Offset = "0x3319D68", VA = "0x3319D68")]
	public static long GetSystemInnerAvailStorageWithByte()
	{
		return default(long);
	}

	[Token(Token = "0x6019ED7")]
	[Address(RVA = "0x3319E3C", Offset = "0x3319E3C", VA = "0x3319E3C")]
	public static int GetSDCardTotalStorage()
	{
		return default(int);
	}

	[Token(Token = "0x6019ED8")]
	[Address(RVA = "0x3319F24", Offset = "0x3319F24", VA = "0x3319F24")]
	public static int GetSDCardAvailStorage()
	{
		return default(int);
	}

	[Token(Token = "0x6019ED9")]
	[Address(RVA = "0x331A00C", Offset = "0x331A00C", VA = "0x331A00C")]
	public static int GetSystemInnerTotalStorage()
	{
		return default(int);
	}

	[Token(Token = "0x6019EDA")]
	[Address(RVA = "0x331A0F4", Offset = "0x331A0F4", VA = "0x331A0F4")]
	public static int GetSystemInnerAvailStorage()
	{
		return default(int);
	}

	[Token(Token = "0x6019EDB")]
	[Address(RVA = "0x331A1DC", Offset = "0x331A1DC", VA = "0x331A1DC")]
	public static int getAvailbleStorageByPath(string _path)
	{
		return default(int);
	}

	[Token(Token = "0x6019EDC")]
	[Address(RVA = "0x331A328", Offset = "0x331A328", VA = "0x331A328")]
	public static int getTotalStorageByPath(string _path)
	{
		return default(int);
	}

	[Token(Token = "0x6019EDD")]
	[Address(RVA = "0x331A474", Offset = "0x331A474", VA = "0x331A474")]
	public static StorageDeviceSpace getInternalStorageDeviceSpace()
	{
		return null;
	}

	[Token(Token = "0x6019EDE")]
	[Address(RVA = "0x331A63C", Offset = "0x331A63C", VA = "0x331A63C")]
	public static StorageDeviceSpace getExternalStorageDeviceSpace()
	{
		return null;
	}

	[Token(Token = "0x6019EE0")]
	[Address(RVA = "0x3316000", Offset = "0x3316000", VA = "0x3316000")]
	public static void OnRequestPermissionsResult(string result)
	{
	}

	[Token(Token = "0x6019EE1")]
	[Address(RVA = "0x331B2CC", Offset = "0x331B2CC", VA = "0x331B2CC")]
	public static void ShowAlertDialog(string title, string content, string yes, string no, string cancel, Action onYes, Action onNo, Action onCancel, string identifier = "")
	{
	}

	[Token(Token = "0x6019EE2")]
	[Address(RVA = "0x3316544", Offset = "0x3316544", VA = "0x3316544")]
	public static void OnAlertDialogPositiveButtonClick(string identifier)
	{
	}

	[Token(Token = "0x6019EE3")]
	[Address(RVA = "0x33167DC", Offset = "0x33167DC", VA = "0x33167DC")]
	public static void OnAlertDialogNegativeButtonClick(string identifier)
	{
	}

	[Token(Token = "0x6019EE4")]
	[Address(RVA = "0x3316A74", Offset = "0x3316A74", VA = "0x3316A74")]
	public static void OnAlertDialogNeutralButtonClick(string identifier)
	{
	}

	[Token(Token = "0x6019EE5")]
	[Address(RVA = "0x331B69C", Offset = "0x331B69C", VA = "0x331B69C")]
	public static void ShowRequestPermissionRationalesAlertDialog(Action onOK, string identifier)
	{
	}

	[Token(Token = "0x6019EE6")]
	[Address(RVA = "0x331B814", Offset = "0x331B814", VA = "0x331B814")]
	public static void ShowRequestPermissionRationaleAlertDialog(string permission, bool isCritical, Action onYes, Action onNo, string identifier)
	{
	}

	[Token(Token = "0x6019EE7")]
	[Address(RVA = "0x331BB20", Offset = "0x331BB20", VA = "0x331BB20")]
	public static void ShowGotoApplicationDetailsSettingsAlertDialog(string permission, Action onYes, Action onNo, string identifier, bool critical)
	{
	}

	[Token(Token = "0x6019EE8")]
	[Address(RVA = "0x331BDB4", Offset = "0x331BDB4", VA = "0x331BDB4")]
	public static void GotoApplicationDetailsSettings()
	{
	}

	[Token(Token = "0x6019EE9")]
	[Address(RVA = "0x331AC08", Offset = "0x331AC08", VA = "0x331AC08")]
	public static string GetBuildSerial()
	{
		return null;
	}

	[Token(Token = "0x6019EEA")]
	[Address(RVA = "0x331BE7C", Offset = "0x331BE7C", VA = "0x331BE7C")]
	public static string GetBuildFingerPrint()
	{
		return null;
	}

	[Token(Token = "0x6019EEB")]
	[Address(RVA = "0x331BF50", Offset = "0x331BF50", VA = "0x331BF50")]
	public static string GetBuildModel()
	{
		return null;
	}

	[Token(Token = "0x6019EEC")]
	[Address(RVA = "0x331C024", Offset = "0x331C024", VA = "0x331C024")]
	public static string GetBuildHardware()
	{
		return null;
	}

	[Token(Token = "0x6019EED")]
	[Address(RVA = "0x331C0F8", Offset = "0x331C0F8", VA = "0x331C0F8")]
	public static string GetBuildDevice()
	{
		return null;
	}

	[Token(Token = "0x6019EEE")]
	[Address(RVA = "0x331C1CC", Offset = "0x331C1CC", VA = "0x331C1CC")]
	public static string GetBuildBrand()
	{
		return null;
	}

	[Token(Token = "0x6019EEF")]
	[Address(RVA = "0x331C2A0", Offset = "0x331C2A0", VA = "0x331C2A0")]
	public static string GetBuildManufacturer()
	{
		return null;
	}

	[Token(Token = "0x6019EF0")]
	[Address(RVA = "0x331C374", Offset = "0x331C374", VA = "0x331C374")]
	public static string GetBuildProduct()
	{
		return null;
	}

	[Token(Token = "0x6019EF1")]
	[Address(RVA = "0x331C448", Offset = "0x331C448", VA = "0x331C448")]
	public static string GetBuildBoard()
	{
		return null;
	}

	[Token(Token = "0x6019EF2")]
	[Address(RVA = "0x331C51C", Offset = "0x331C51C", VA = "0x331C51C")]
	public static string GetBuildBootloader()
	{
		return null;
	}

	[Token(Token = "0x6019EF3")]
	[Address(RVA = "0x331C5F0", Offset = "0x331C5F0", VA = "0x331C5F0")]
	public static string GetTelephonyManagerSubscriberId()
	{
		return null;
	}

	[Token(Token = "0x6019EF4")]
	[Address(RVA = "0x331ACDC", Offset = "0x331ACDC", VA = "0x331ACDC")]
	public static string GetTelephonyManagerIMEI()
	{
		return null;
	}

	[Token(Token = "0x6019EF5")]
	[Address(RVA = "0x331ADB0", Offset = "0x331ADB0", VA = "0x331ADB0")]
	public static string GetTelephonyManagerMEID()
	{
		return null;
	}

	[Token(Token = "0x6019EF6")]
	[Address(RVA = "0x331C6C4", Offset = "0x331C6C4", VA = "0x331C6C4")]
	public static ulong DigestEmulatorInfoDetail(Dictionary<string, bool> detail)
	{
		return default(ulong);
	}

	[Token(Token = "0x6019EF7")]
	[Address(RVA = "0x331CA28", Offset = "0x331CA28", VA = "0x331CA28")]
	public static Dictionary<string, bool> CheckEmulatorFilesDetail()
	{
		return null;
	}

	[Token(Token = "0x6019EF8")]
	[Address(RVA = "0x331CE50", Offset = "0x331CE50", VA = "0x331CE50")]
	public static bool CheckEmulatorFiles()
	{
		return default(bool);
	}

	[Token(Token = "0x6019EF9")]
	[Address(RVA = "0x331D0AC", Offset = "0x331D0AC", VA = "0x331D0AC")]
	private static string GetString(string className, string methodName, string[] parameters)
	{
		return null;
	}

	[Token(Token = "0x6019EFA")]
	[Address(RVA = "0x331D298", Offset = "0x331D298", VA = "0x331D298")]
	private static string GetSystemProperty(string propertyName)
	{
		return null;
	}

	[Token(Token = "0x6019EFB")]
	[Address(RVA = "0x331D3D0", Offset = "0x331D3D0", VA = "0x331D3D0")]
	public static Dictionary<string, bool> CheckEmualtorPropertiesDetail()
	{
		return null;
	}

	[Token(Token = "0x6019EFC")]
	[Address(RVA = "0x331D864", Offset = "0x331D864", VA = "0x331D864")]
	public static bool CheckEmulatorProperties()
	{
		return default(bool);
	}

	[Token(Token = "0x6019EFD")]
	[Address(RVA = "0x331DBA4", Offset = "0x331DBA4", VA = "0x331DBA4")]
	private static bool CheckPackageName(string packageName)
	{
		return default(bool);
	}

	[Token(Token = "0x6019EFE")]
	[Address(RVA = "0x331DCDC", Offset = "0x331DCDC", VA = "0x331DCDC")]
	public static Dictionary<string, bool> CheckEmulatorPackageNamesDetail()
	{
		return null;
	}

	[Token(Token = "0x6019EFF")]
	[Address(RVA = "0x331DE5C", Offset = "0x331DE5C", VA = "0x331DE5C")]
	public static bool CheckEmulatorPackageNames()
	{
		return default(bool);
	}

	[Token(Token = "0x6019F00")]
	[Address(RVA = "0x331CD18", Offset = "0x331CD18", VA = "0x331CD18")]
	public static bool CheckFileExists(string fileName)
	{
		return default(bool);
	}

	[Token(Token = "0x6019F01")]
	[Address(RVA = "0x331DF74", Offset = "0x331DF74", VA = "0x331DF74")]
	public static string GetNetworkOperatorName()
	{
		return null;
	}

	[Token(Token = "0x6019F02")]
	[Address(RVA = "0x331E048", Offset = "0x331E048", VA = "0x331E048")]
	public static string GetNetworkType()
	{
		return null;
	}

	[Token(Token = "0x6019F03")]
	[Address(RVA = "0x331E11C", Offset = "0x331E11C", VA = "0x331E11C")]
	public static bool IsEmulator()
	{
		return default(bool);
	}

	[Token(Token = "0x6019F04")]
	[Address(RVA = "0x331E3D8", Offset = "0x331E3D8", VA = "0x331E3D8")]
	public static void ToggleBatteryReport(bool shouldReport)
	{
	}

	[Token(Token = "0x6019F05")]
	[Address(RVA = "0x331E52C", Offset = "0x331E52C", VA = "0x331E52C")]
	public static float GetBatteryLevel()
	{
		return default(float);
	}

	[Token(Token = "0x6019F06")]
	[Address(RVA = "0x331E600", Offset = "0x331E600", VA = "0x331E600")]
	public static bool IsBatteryCharging()
	{
		return default(bool);
	}

	[Token(Token = "0x6019F07")]
	[Address(RVA = "0x331E6D4", Offset = "0x331E6D4", VA = "0x331E6D4")]
	public static float GetWifiSignalLevel()
	{
		return default(float);
	}

	[Token(Token = "0x6019F08")]
	[Address(RVA = "0x331E7A8", Offset = "0x331E7A8", VA = "0x331E7A8")]
	public static void CallTraceRoute(string address, int thread_count)
	{
	}

	[Token(Token = "0x6019F09")]
	[Address(RVA = "0x331E950", Offset = "0x331E950", VA = "0x331E950")]
	public static string GetNativeLibraryDir()
	{
		return null;
	}

	[Token(Token = "0x6019F0A")]
	[Address(RVA = "0x331EA24", Offset = "0x331EA24", VA = "0x331EA24")]
	public static string GetNativeDir()
	{
		return null;
	}

	[Token(Token = "0x6019F0B")]
	[Address(RVA = "0x331EAF8", Offset = "0x331EAF8", VA = "0x331EAF8")]
	public static void SendBroadcast(string packageName, string actionName, Dictionary<string, string> extras)
	{
	}

	[Token(Token = "0x6019F0C")]
	[Address(RVA = "0x331EF84", Offset = "0x331EF84", VA = "0x331EF84")]
	public static string[] GetCodecsForMediaFormat_MimeType(string mime_type, bool isEncoder, bool log)
	{
		return null;
	}

	[Token(Token = "0x6019F0D")]
	[Address(RVA = "0x331F1AC", Offset = "0x331F1AC", VA = "0x331F1AC")]
	public static bool SupportHardwareDecodingForH264(bool log)
	{
		return default(bool);
	}

	[Token(Token = "0x6019F0E")]
	[Address(RVA = "0x331F2D4", Offset = "0x331F2D4", VA = "0x331F2D4")]
	public static string GetCpuArchitecture()
	{
		return null;
	}

	[Token(Token = "0x6019F0F")]
	[Address(RVA = "0x331F3A8", Offset = "0x331F3A8", VA = "0x331F3A8")]
	public static bool Relaunch(long delayMS)
	{
		return default(bool);
	}

	[Token(Token = "0x6019F10")]
	[Address(RVA = "0x331F50C", Offset = "0x331F50C", VA = "0x331F50C")]
	public static GetAdvertisingIdResult GetGoogleAdvertisingId()
	{
		return null;
	}

	[Token(Token = "0x6019F11")]
	[Address(RVA = "0x331F74C", Offset = "0x331F74C", VA = "0x331F74C")]
	public static bool IsAdvertisingIdProviderAvailable()
	{
		return default(bool);
	}

	[Token(Token = "0x6019F12")]
	[Address(RVA = "0x3316E98", Offset = "0x3316E98", VA = "0x3316E98")]
	internal static void OnGetAdvertisingId(GetAdvertisingIdResult result)
	{
	}

	[Token(Token = "0x6019F13")]
	[Address(RVA = "0x331F828", Offset = "0x331F828", VA = "0x331F828")]
	public static void GetAdvertisingId(Action<GetAdvertisingIdResult> callback)
	{
	}

	[Token(Token = "0x6019F14")]
	[Address(RVA = "0x331F90C", Offset = "0x331F90C", VA = "0x331F90C")]
	public static bool SupportInAppReview()
	{
		return default(bool);
	}

	[Token(Token = "0x6019F15")]
	[Address(RVA = "0x331F9C0", Offset = "0x331F9C0", VA = "0x331F9C0")]
	public static bool DoInAppReview(Action<bool> callback)
	{
		return default(bool);
	}

	[Token(Token = "0x6019F16")]
	[Address(RVA = "0x3317194", Offset = "0x3317194", VA = "0x3317194")]
	internal static void OnDoneInAppReview(InAppReviewResult result)
	{
	}

	[Token(Token = "0x6019F17")]
	[Address(RVA = "0x331FAB0", Offset = "0x331FAB0", VA = "0x331FAB0")]
	public static void SetDebugDisplayCutout(bool debug)
	{
	}

	[Token(Token = "0x6019F18")]
	[Address(RVA = "0x331FC04", Offset = "0x331FC04", VA = "0x331FC04")]
	public static bool HasDisplayCutout()
	{
		return default(bool);
	}

	[Token(Token = "0x6019F19")]
	[Address(RVA = "0x331FCD8", Offset = "0x331FCD8", VA = "0x331FCD8")]
	public static byte[] GetSignature()
	{
		return null;
	}

	[Token(Token = "0x6019F1B")]
	[Address(RVA = "0x331FEEC", Offset = "0x331FEEC", VA = "0x331FEEC")]
	public static void SetLocalNotificationChannel(string channel_id, PlatformUtility.LocalNotificationImportance importance, string name, string description)
	{
	}

	[Token(Token = "0x6019F1C")]
	[Address(RVA = "0x332013C", Offset = "0x332013C", VA = "0x332013C")]
	public static void GotoChannelNotificationSettings()
	{
	}

	[Token(Token = "0x6019F1D")]
	[Address(RVA = "0x3320204", Offset = "0x3320204", VA = "0x3320204")]
	public static void ScheduleLocalNotification(int type, int id, string title, string content, long time_ms, int repeat_interval_ms, int repeat_times, string uri, string channel_id)
	{
	}

	[Token(Token = "0x6019F1E")]
	[Address(RVA = "0x3320680", Offset = "0x3320680", VA = "0x3320680")]
	public static void UnscheduleLocalNotification(int id)
	{
	}

	[Token(Token = "0x6019F1F")]
	[Address(RVA = "0x33207D4", Offset = "0x33207D4", VA = "0x33207D4")]
	public static void UnscheduleAllLocalNotifications()
	{
	}

	[Token(Token = "0x6019F20")]
	[Address(RVA = "0x332089C", Offset = "0x332089C", VA = "0x332089C")]
	public static void ClearAllNotifications()
	{
	}

	[Token(Token = "0x6019F21")]
	[Address(RVA = "0x3320964", Offset = "0x3320964", VA = "0x3320964")]
	public static bool AreNotificationsEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x6019F22")]
	[Address(RVA = "0x3320A38", Offset = "0x3320A38", VA = "0x3320A38")]
	public static bool HasNotificationChannels()
	{
		return default(bool);
	}

	[Token(Token = "0x6019F23")]
	[Address(RVA = "0x3320B0C", Offset = "0x3320B0C", VA = "0x3320B0C")]
	public static bool IsNotificationChannelEnabled(string channelId)
	{
		return default(bool);
	}

	[Token(Token = "0x6019F24")]
	[Address(RVA = "0x3320C44", Offset = "0x3320C44", VA = "0x3320C44")]
	public static Dictionary<int, int> GetLocalNotificationRecords()
	{
		return null;
	}

	[Token(Token = "0x6019F25")]
	[Address(RVA = "0x33210E4", Offset = "0x33210E4", VA = "0x33210E4")]
	public static void ClearLocalNotificationRecords()
	{
	}

	[Token(Token = "0x6019F27")]
	[Address(RVA = "0x332256C", Offset = "0x332256C", VA = "0x332256C")]
	private static string _003Cget_DeviceIdentifier_003Em__0(byte item)
	{
		return null;
	}
}
