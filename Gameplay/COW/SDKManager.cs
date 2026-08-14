using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001E08")]
public class SDKManager : MonoBehaviour
{
	[Token(Token = "0x400BE3A")]
	[FieldOffset(Offset = "0x0")]
	private static SDKManager _instance;

	[Token(Token = "0x400BE3B")]
	[FieldOffset(Offset = "0xC")]
	private PlatformType m_PlatformType;

	[Token(Token = "0x400BE3C")]
	[FieldOffset(Offset = "0x10")]
	private string openID;

	[Token(Token = "0x400BE3D")]
	[FieldOffset(Offset = "0x14")]
	private string token;

	[Token(Token = "0x400BE3E")]
	[FieldOffset(Offset = "0x18")]
	private bool m_IsDebugPlatformLogin;

	[Token(Token = "0x400BE3F")]
	[FieldOffset(Offset = "0x4")]
	private static readonly Dictionary<int, string> _AppsFlyerAccountTypes;

	[Token(Token = "0x400BE40")]
	private const string PLAYER_PREF_KEY_PLATFORM_TYPE = "SDKPlatformType";

	[Token(Token = "0x17000F15")]
	public static SDKManager Instance
	{
		[Token(Token = "0x6008F9A")]
		[Address(RVA = "0x241C378", Offset = "0x241C378", VA = "0x241C378")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F16")]
	public PlatformType PlatformType
	{
		[Token(Token = "0x6008F9B")]
		[Address(RVA = "0x241C448", Offset = "0x241C448", VA = "0x241C448")]
		get
		{
			return default(PlatformType);
		}
		[Token(Token = "0x6008F9C")]
		[Address(RVA = "0x241C4A0", Offset = "0x241C4A0", VA = "0x241C4A0")]
		set
		{
		}
	}

	[Token(Token = "0x17000F17")]
	public string OpenID
	{
		[Token(Token = "0x6008F9D")]
		[Address(RVA = "0x241C5F8", Offset = "0x241C5F8", VA = "0x241C5F8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008F9E")]
		[Address(RVA = "0x241C72C", Offset = "0x241C72C", VA = "0x241C72C")]
		set
		{
		}
	}

	[Token(Token = "0x17000F18")]
	public string Token
	{
		[Token(Token = "0x6008F9F")]
		[Address(RVA = "0x241C78C", Offset = "0x241C78C", VA = "0x241C78C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008FA0")]
		[Address(RVA = "0x241C878", Offset = "0x241C878", VA = "0x241C878")]
		set
		{
		}
	}

	[Token(Token = "0x6008F99")]
	[Address(RVA = "0x241C2D0", Offset = "0x241C2D0", VA = "0x241C2D0")]
	public SDKManager()
	{
	}

	[Token(Token = "0x6008FA1")]
	[Address(RVA = "0x241C8D8", Offset = "0x241C8D8", VA = "0x241C8D8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6008FA2")]
	[Address(RVA = "0x241C9F8", Offset = "0x241C9F8", VA = "0x241C9F8")]
	private void Start()
	{
	}

	[Token(Token = "0x6008FA3")]
	[Address(RVA = "0x241CA4C", Offset = "0x241CA4C", VA = "0x241CA4C")]
	private void Update()
	{
	}

	[Token(Token = "0x6008FA4")]
	[Address(RVA = "0x241CAA0", Offset = "0x241CAA0", VA = "0x241CAA0")]
	public bool IsSupported(PlatformType platform)
	{
		return default(bool);
	}

	[Token(Token = "0x6008FA5")]
	[Address(RVA = "0x241CC70", Offset = "0x241CC70", VA = "0x241CC70")]
	public void InitSDK(PlatformType platform, bool force = false)
	{
	}

	[Token(Token = "0x6008FA6")]
	[Address(RVA = "0x241D018", Offset = "0x241D018", VA = "0x241D018")]
	public void PCForceInitSDK(PlatformType platform)
	{
	}

	[Token(Token = "0x6008FA7")]
	[Address(RVA = "0x241D088", Offset = "0x241D088", VA = "0x241D088")]
	public void InitBindSDK(PlatformType platform)
	{
	}

	[Token(Token = "0x6008FA8")]
	[Address(RVA = "0x241D330", Offset = "0x241D330", VA = "0x241D330")]
	public void LogoutSDK()
	{
	}

	[Token(Token = "0x6008FA9")]
	[Address(RVA = "0x241D694", Offset = "0x241D694", VA = "0x241D694")]
	public static string AppsFlyerAccountType(PlatformType platform)
	{
		return null;
	}

	[Token(Token = "0x6008FAA")]
	[Address(RVA = "0x241CBD8", Offset = "0x241CBD8", VA = "0x241CBD8")]
	public static SDKType GetSDKType(PlatformType platform)
	{
		return default(SDKType);
	}

	[Token(Token = "0x6008FAB")]
	[Address(RVA = "0x241CF44", Offset = "0x241CF44", VA = "0x241CF44")]
	public SDKType GetCurrentSDKType()
	{
		return default(SDKType);
	}

	[Token(Token = "0x6008FAC")]
	[Address(RVA = "0x241D800", Offset = "0x241D800", VA = "0x241D800")]
	public PlatformType GetCachePlatformType()
	{
		return default(PlatformType);
	}

	[Token(Token = "0x6008FAD")]
	[Address(RVA = "0x241D940", Offset = "0x241D940", VA = "0x241D940")]
	public SDKType GetCacheSDKType()
	{
		return default(SDKType);
	}

	[Token(Token = "0x6008FAE")]
	[Address(RVA = "0x241C510", Offset = "0x241C510", VA = "0x241C510")]
	private void SavePlatformType(PlatformType platformType)
	{
	}

	[Token(Token = "0x6008FAF")]
	[Address(RVA = "0x241D860", Offset = "0x241D860", VA = "0x241D860")]
	private PlatformType LoadPlatformType()
	{
		return default(PlatformType);
	}

	[Token(Token = "0x6008FB0")]
	[Address(RVA = "0x241DA14", Offset = "0x241DA14", VA = "0x241DA14")]
	public bool CurrentPlatformTypeHasPlatformFriend()
	{
		return default(bool);
	}

	[Token(Token = "0x6008FB1")]
	[Address(RVA = "0x241DA9C", Offset = "0x241DA9C", VA = "0x241DA9C")]
	public void DebugPlatformLogin(PlatformType platformType, string paramOpenID, string paramToken)
	{
	}

	[Token(Token = "0x6008FB2")]
	[Address(RVA = "0x241D540", Offset = "0x241D540", VA = "0x241D540")]
	private void DebugRestorePlatformInfo()
	{
	}
}
