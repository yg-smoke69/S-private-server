using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x200229D")]
internal class UIHudPDMMatchResultController : UIHudSingleFightMatchResultController
{
	[Token(Token = "0x600BE30")]
	[Address(RVA = "0x1837604", Offset = "0x1837604", VA = "0x1837604")]
	public UIHudPDMMatchResultController()
	{
	}

	[Token(Token = "0x600BE31")]
	[Address(RVA = "0x183760C", Offset = "0x183760C", VA = "0x183760C")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BE32")]
	[Address(RVA = "0x18376B4", Offset = "0x18376B4", VA = "0x18376B4", Slot = "45")]
	protected override int[] GetInfoTypes()
	{
		return null;
	}

	[Token(Token = "0x600BE33")]
	[Address(RVA = "0x1837784", Offset = "0x1837784", VA = "0x1837784", Slot = "63")]
	public override UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600BE34")]
	[Address(RVA = "0x1837988", Offset = "0x1837988", VA = "0x1837988")]
	protected ExtraPlayerDataForMatchResult GetExtraPlayerDataIncludingBotForMatchResult(ulong accountID, string nickName)
	{
		return null;
	}

	[Token(Token = "0x600BE35")]
	[Address(RVA = "0x1837AE8", Offset = "0x1837AE8", VA = "0x1837AE8", Slot = "61")]
	protected override UIHudSingleFightMatchResultItemController OpenItemController(TeammateStats data, bool single)
	{
		return null;
	}

	[Token(Token = "0x600BE36")]
	[Address(RVA = "0x1837BD8", Offset = "0x1837BD8", VA = "0x1837BD8", Slot = "60")]
	protected override PlayerData GetPlayerData(TeammateStats stats)
	{
		return null;
	}

	[Token(Token = "0x600BE37")]
	[Address(RVA = "0x1837C70", Offset = "0x1837C70", VA = "0x1837C70", Slot = "42")]
	protected override void SetResultDescTextByRank(MatchStats stats)
	{
	}

	[Token(Token = "0x600BE38")]
	[Address(RVA = "0x1837F40", Offset = "0x1837F40", VA = "0x1837F40")]
	public new int[] _003C_003EiFixBaseProxy_GetInfoTypes()
	{
		return null;
	}

	[Token(Token = "0x600BE39")]
	[Address(RVA = "0x1837F48", Offset = "0x1837F48", VA = "0x1837F48")]
	public UIEasyListItemController _003C_003EiFixBaseProxy_OpenItemController(Transform P0)
	{
		return null;
	}

	[Token(Token = "0x600BE3A")]
	[Address(RVA = "0x1837F50", Offset = "0x1837F50", VA = "0x1837F50")]
	public UIHudSingleFightMatchResultItemController _003C_003EiFixBaseProxy_OpenItemController(TeammateStats P0, bool P1)
	{
		return null;
	}

	[Token(Token = "0x600BE3B")]
	[Address(RVA = "0x1837F58", Offset = "0x1837F58", VA = "0x1837F58")]
	public PlayerData _003C_003EiFixBaseProxy_GetPlayerData(TeammateStats P0)
	{
		return null;
	}

	[Token(Token = "0x600BE3C")]
	[Address(RVA = "0x1837F60", Offset = "0x1837F60", VA = "0x1837F60")]
	public void _003C_003EiFixBaseProxy_SetResultDescTextByRank(MatchStats P0)
	{
	}
}
