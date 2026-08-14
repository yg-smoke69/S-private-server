using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x2002482")]
internal class UIHUDUGC_TwoTeamLeaderboard_TeammateItemController : UIHUDUGC_BaseLeaderboard_TeammateItemController
{
	[Token(Token = "0x400E277")]
	[FieldOffset(Offset = "0x3C")]
	private UIHUDUGC_TwoTeamLeaderboard_TeammateItemView m_View;

	[Token(Token = "0x400E278")]
	[FieldOffset(Offset = "0x40")]
	private Dictionary<int, UILabel> m_LabelDict;

	[Token(Token = "0x600D049")]
	[Address(RVA = "0x292A2E8", Offset = "0x292A2E8", VA = "0x292A2E8")]
	public UIHUDUGC_TwoTeamLeaderboard_TeammateItemController()
	{
	}

	[Token(Token = "0x600D04A")]
	[Address(RVA = "0x292A374", Offset = "0x292A374", VA = "0x292A374")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D04B")]
	[Address(RVA = "0x292A418", Offset = "0x292A418", VA = "0x292A418", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D04C")]
	[Address(RVA = "0x2929A18", Offset = "0x2929A18", VA = "0x2929A18")]
	public void SetViewData(List<int> scoreTypes)
	{
	}

	[Token(Token = "0x600D04D")]
	[Address(RVA = "0x292A4D4", Offset = "0x292A4D4", VA = "0x292A4D4", Slot = "38")]
	protected override void ShowProfileInfo(BaseProfileInfo profileInfo)
	{
	}

	[Token(Token = "0x600D04E")]
	[Address(RVA = "0x292AA94", Offset = "0x292AA94", VA = "0x292AA94", Slot = "37")]
	protected override void SetSelf(bool isSelf)
	{
	}

	[Token(Token = "0x600D04F")]
	[Address(RVA = "0x292AB74", Offset = "0x292AB74", VA = "0x292AB74", Slot = "39")]
	public override void RefreshInfo(CBNPMCENMKE infoType)
	{
	}

	[Token(Token = "0x600D050")]
	[Address(RVA = "0x292ACC0", Offset = "0x292ACC0", VA = "0x292ACC0", Slot = "40")]
	public override void RefreshAllInfo()
	{
	}

	[Token(Token = "0x600D051")]
	[Address(RVA = "0x292AF0C", Offset = "0x292AF0C", VA = "0x292AF0C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D052")]
	[Address(RVA = "0x292AF14", Offset = "0x292AF14", VA = "0x292AF14")]
	public void _003C_003EiFixBaseProxy_ShowProfileInfo(BaseProfileInfo P0)
	{
	}

	[Token(Token = "0x600D053")]
	[Address(RVA = "0x292AF1C", Offset = "0x292AF1C", VA = "0x292AF1C")]
	public void _003C_003EiFixBaseProxy_SetSelf(bool P0)
	{
	}

	[Token(Token = "0x600D054")]
	[Address(RVA = "0x292AF24", Offset = "0x292AF24", VA = "0x292AF24")]
	public void _003C_003EiFixBaseProxy_RefreshInfo(CBNPMCENMKE P0)
	{
	}

	[Token(Token = "0x600D055")]
	[Address(RVA = "0x292AF2C", Offset = "0x292AF2C", VA = "0x292AF2C")]
	public void _003C_003EiFixBaseProxy_RefreshAllInfo()
	{
	}
}
