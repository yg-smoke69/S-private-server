using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002B52")]
internal class UISPHudTeamRankingItemController : UIEasyListItemController
{
	[Token(Token = "0x4010991")]
	[FieldOffset(Offset = "0x38")]
	private UISPHudTeamRankingItemView m_View;

	[Token(Token = "0x4010992")]
	[FieldOffset(Offset = "0x3C")]
	private UISPHudTeamRankingListController m_ParentCtrl;

	[Token(Token = "0x4010993")]
	[FieldOffset(Offset = "0x40")]
	private bool m_showTeamNum;

	[Token(Token = "0x4010994")]
	[FieldOffset(Offset = "0x44")]
	private List<UISprite> m_PlayIconList;

	[Token(Token = "0x6011D7A")]
	[Address(RVA = "0x14986D8", Offset = "0x14986D8", VA = "0x14986D8")]
	public UISPHudTeamRankingItemController()
	{
	}

	[Token(Token = "0x6011D7B")]
	[Address(RVA = "0x149876C", Offset = "0x149876C", VA = "0x149876C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011D7C")]
	[Address(RVA = "0x1498814", Offset = "0x1498814", VA = "0x1498814", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011D7D")]
	[Address(RVA = "0x1498ED0", Offset = "0x1498ED0", VA = "0x1498ED0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011D7E")]
	[Address(RVA = "0x1498F34", Offset = "0x1498F34", VA = "0x1498F34")]
	public void SetParentCtrl(UISPHudTeamRankingListController ctrl)
	{
	}

	[Token(Token = "0x6011D7F")]
	[Address(RVA = "0x1498F94", Offset = "0x1498F94", VA = "0x1498F94", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x6011D80")]
	[Address(RVA = "0x1499930", Offset = "0x1499930", VA = "0x1499930")]
	private void OnToggleTeamNum(object[] data)
	{
	}

	[Token(Token = "0x6011D81")]
	[Address(RVA = "0x1499AE0", Offset = "0x1499AE0", VA = "0x1499AE0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011D82")]
	[Address(RVA = "0x1499AE8", Offset = "0x1499AE8", VA = "0x1499AE8")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
