using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000204")]
public class PlayerSocialTagsInfoManager : SingletonModule<PlayerSocialTagsInfoManager>
{
	[Token(Token = "0x4000BFB")]
	[FieldOffset(Offset = "0xC")]
	private List<PlayerSocialTagsInfoData> m_ListData;

	[Token(Token = "0x4000BFC")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<PlayerSocialTagsInfoData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6000A6D")]
	[Address(RVA = "0x1C0C390", Offset = "0x1C0C390", VA = "0x1C0C390")]
	public PlayerSocialTagsInfoManager()
	{
	}

	[Token(Token = "0x6000A6E")]
	[Address(RVA = "0x1C0C454", Offset = "0x1C0C454", VA = "0x1C0C454", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6000A6F")]
	[Address(RVA = "0x1C0C758", Offset = "0x1C0C758", VA = "0x1C0C758", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6000A70")]
	[Address(RVA = "0x1C0C818", Offset = "0x1C0C818", VA = "0x1C0C818")]
	public PlayerSocialTagsInfoData GetDataById(uint id)
	{
		return null;
	}

	[Token(Token = "0x6000A71")]
	[Address(RVA = "0x1C0C9D4", Offset = "0x1C0C9D4", VA = "0x1C0C9D4")]
	public List<PlayerSocialTagsInfoData> GetAllData()
	{
		return null;
	}

	[Token(Token = "0x6000A72")]
	[Address(RVA = "0x1C0CA2C", Offset = "0x1C0CA2C", VA = "0x1C0CA2C")]
	private static int _003COnInit_003Em__0(PlayerSocialTagsInfoData a, PlayerSocialTagsInfoData b)
	{
		return default(int);
	}
}
