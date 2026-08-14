using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001FF")]
public class PlayerBattleTagsInfoManager : SingletonModule<PlayerBattleTagsInfoManager>
{
	[Token(Token = "0x4000BF0")]
	[FieldOffset(Offset = "0xC")]
	private List<PlayerBattleTagsInfoData> m_ListData;

	[Token(Token = "0x4000BF1")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<PlayerBattleTagsInfoData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6000A5A")]
	[Address(RVA = "0x1C07FC8", Offset = "0x1C07FC8", VA = "0x1C07FC8")]
	public PlayerBattleTagsInfoManager()
	{
	}

	[Token(Token = "0x6000A5B")]
	[Address(RVA = "0x1C0808C", Offset = "0x1C0808C", VA = "0x1C0808C", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6000A5C")]
	[Address(RVA = "0x1C08390", Offset = "0x1C08390", VA = "0x1C08390", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6000A5D")]
	[Address(RVA = "0x1C08450", Offset = "0x1C08450", VA = "0x1C08450")]
	public PlayerBattleTagsInfoData GetDataById(uint id)
	{
		return null;
	}

	[Token(Token = "0x6000A5E")]
	[Address(RVA = "0x1C0860C", Offset = "0x1C0860C", VA = "0x1C0860C")]
	public List<PlayerBattleTagsInfoData> GetAllData()
	{
		return null;
	}

	[Token(Token = "0x6000A5F")]
	[Address(RVA = "0x1C08664", Offset = "0x1C08664", VA = "0x1C08664")]
	private static int _003COnInit_003Em__0(PlayerBattleTagsInfoData a, PlayerBattleTagsInfoData b)
	{
		return default(int);
	}
}
