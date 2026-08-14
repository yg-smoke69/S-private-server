using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003D00")]
public static class UMAFacade
{
	[Token(Token = "0x4019E53")]
	[FieldOffset(Offset = "0x0")]
	private static IUMAInterface m_Impl;

	[Token(Token = "0x60186D8")]
	[Address(RVA = "0x2A5B93C", Offset = "0x2A5B93C", VA = "0x2A5B93C")]
	public static void SetImpl(IUMAInterface impl)
	{
	}

	[Token(Token = "0x60186D9")]
	[Address(RVA = "0x2A5B9F4", Offset = "0x2A5B9F4", VA = "0x2A5B9F4")]
	public static GameObject GetAssetIndexResource()
	{
		return null;
	}

	[Token(Token = "0x60186DA")]
	[Address(RVA = "0x2A5BB08", Offset = "0x2A5BB08", VA = "0x2A5BB08")]
	public static Type GetDynamicAssetLoaderType()
	{
		return null;
	}
}
