using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003B72")]
public class GooglePlayDownloader
{
	[Token(Token = "0x401954A")]
	[FieldOffset(Offset = "0x0")]
	public static int OriginalVersionCode;

	[Token(Token = "0x401954B")]
	[FieldOffset(Offset = "0x4")]
	private static AndroidJavaClass detectAndroidJNI;

	[Token(Token = "0x401954C")]
	[FieldOffset(Offset = "0x8")]
	private static AndroidJavaClass Environment;

	[Token(Token = "0x401954D")]
	private const string Environment_MEDIA_MOUNTED = "mounted";

	[Token(Token = "0x401954E")]
	[FieldOffset(Offset = "0xC")]
	private static string obb_package;

	[Token(Token = "0x401954F")]
	[FieldOffset(Offset = "0x10")]
	private static int obb_version;

	[Token(Token = "0x17001825")]
	private static int ObbVersion
	{
		[Token(Token = "0x6017AAA")]
		[Address(RVA = "0x3505588", Offset = "0x3505588", VA = "0x3505588")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6017AA4")]
	[Address(RVA = "0x35047C8", Offset = "0x35047C8", VA = "0x35047C8")]
	static GooglePlayDownloader()
	{
	}

	[Token(Token = "0x6017AA5")]
	[Address(RVA = "0x3504BA0", Offset = "0x3504BA0", VA = "0x3504BA0")]
	public GooglePlayDownloader()
	{
	}

	[Token(Token = "0x6017AA6")]
	[Address(RVA = "0x3504A38", Offset = "0x3504A38", VA = "0x3504A38")]
	public static bool RunningOnAndroid()
	{
		return default(bool);
	}

	[Token(Token = "0x6017AA7")]
	[Address(RVA = "0x3504BA8", Offset = "0x3504BA8", VA = "0x3504BA8")]
	public static string GetExpansionFilePath()
	{
		return null;
	}

	[Token(Token = "0x6017AA8")]
	[Address(RVA = "0x350541C", Offset = "0x350541C", VA = "0x350541C")]
	public static string GetMainOBBPath(string expansionFilePath)
	{
		return null;
	}

	[Token(Token = "0x6017AA9")]
	[Address(RVA = "0x3505614", Offset = "0x3505614", VA = "0x3505614")]
	public static string GetPatchOBBPath(string expansionFilePath)
	{
		return null;
	}

	[Token(Token = "0x6017AAB")]
	[Address(RVA = "0x3505780", Offset = "0x3505780", VA = "0x3505780")]
	public static void FetchOBB()
	{
	}

	[Token(Token = "0x6017AAC")]
	[Address(RVA = "0x3504F80", Offset = "0x3504F80", VA = "0x3504F80")]
	private static void populateOBBData()
	{
	}
}
