using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20003BE")]
public class UMAImpl : _Attribute
{
	[Token(Token = "0x6001062")]
	[Address(RVA = "0x1A37700", Offset = "0x1A37700", VA = "0x1A37700")]
	public UMAImpl()
	{
	}

	[Token(Token = "0x6001063")]
	[Address(RVA = "0x1A37708", Offset = "0x1A37708", VA = "0x1A37708", Slot = "4")]
	public GameObject GetAssetIndexResource()
	{
		return null;
	}

	[Token(Token = "0x6001064")]
	[Address(RVA = "0x1A37868", Offset = "0x1A37868", VA = "0x1A37868")]
	public static int Get1pTextureScale(int scale)
	{
		return default(int);
	}

	[Token(Token = "0x6001065")]
	[Address(RVA = "0x1A37970", Offset = "0x1A37970", VA = "0x1A37970")]
	public static int Get3pTextureScale(bool useHighQualityAvatar, bool isTeammate)
	{
		return default(int);
	}

	[Token(Token = "0x6001066")]
	[Address(RVA = "0x1A37CC8", Offset = "0x1A37CC8", VA = "0x1A37CC8")]
	public static float GetNormalSpecTexScale(bool forEp = false)
	{
		return default(float);
	}

	[Token(Token = "0x6001067")]
	[Address(RVA = "0x1A37FC4", Offset = "0x1A37FC4", VA = "0x1A37FC4")]
	public static bool GetUsingRGB565(bool for1P, bool foringame)
	{
		return default(bool);
	}

	[Token(Token = "0x6001068")]
	[Address(RVA = "0x1A3830C", Offset = "0x1A3830C", VA = "0x1A3830C")]
	public static float GetAtlasResolutionScale()
	{
		return default(float);
	}

	[Token(Token = "0x6001069")]
	[Address(RVA = "0x1A3842C", Offset = "0x1A3842C", VA = "0x1A3842C")]
	public static int GetIngameShowModelTextureScale()
	{
		return default(int);
	}

	[Token(Token = "0x600106A")]
	[Address(RVA = "0x1A3856C", Offset = "0x1A3856C", VA = "0x1A3856C", Slot = "5")]
	public Type GetDynamicAssetLoaderType()
	{
		return null;
	}
}
