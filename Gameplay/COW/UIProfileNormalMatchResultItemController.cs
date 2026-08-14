using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002AA1")]
public class UIProfileNormalMatchResultItemController : UIHudMatchResultItemBaseController
{
	[Token(Token = "0x40105FF")]
	[FieldOffset(Offset = "0xDC")]
	private UIProfileNormalMatchResultItemView m_View;

	[Token(Token = "0x4010600")]
	[FieldOffset(Offset = "0xE0")]
	private ulong m_PlayerId;

	[Token(Token = "0x4010601")]
	[FieldOffset(Offset = "0xE8")]
	private Color BarlColor;

	[Token(Token = "0x4010602")]
	[FieldOffset(Offset = "0xF8")]
	private Color Bar2Color;

	[Token(Token = "0x4010603")]
	[FieldOffset(Offset = "0x108")]
	private Color Bar3Color;

	[Token(Token = "0x4010604")]
	[FieldOffset(Offset = "0x118")]
	private Color Bar4Color;

	[Token(Token = "0x4010605")]
	[FieldOffset(Offset = "0x128")]
	private Color Bar5Color;

	[Token(Token = "0x60116B1")]
	[Address(RVA = "0x16EADEC", Offset = "0x16EADEC", VA = "0x16EADEC")]
	public UIProfileNormalMatchResultItemController()
	{
	}

	[Token(Token = "0x60116B2")]
	[Address(RVA = "0x16EAF3C", Offset = "0x16EAF3C", VA = "0x16EAF3C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60116B3")]
	[Address(RVA = "0x16EAFE0", Offset = "0x16EAFE0", VA = "0x16EAFE0")]
	public void SetMatchInfo(MatchStats mMatchStats)
	{
	}

	[Token(Token = "0x60116B4")]
	[Address(RVA = "0x16EB2A4", Offset = "0x16EB2A4", VA = "0x16EB2A4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60116B5")]
	[Address(RVA = "0x16EB7B4", Offset = "0x16EB7B4", VA = "0x16EB7B4", Slot = "45")]
	protected override void OnClickAddFriendBtn()
	{
	}

	[Token(Token = "0x60116B6")]
	[Address(RVA = "0x16EB928", Offset = "0x16EB928", VA = "0x16EB928", Slot = "40")]
	protected override void OnSetPlayerData(TeammateStats data, bool single)
	{
	}

	[Token(Token = "0x60116B7")]
	[Address(RVA = "0x16EBF5C", Offset = "0x16EBF5C", VA = "0x16EBF5C", Slot = "41")]
	public override void OnChangePageType(EMatchResultPageType pageType)
	{
	}

	[Token(Token = "0x60116B8")]
	[Address(RVA = "0x16EBB48", Offset = "0x16EBB48", VA = "0x16EBB48")]
	private void UpdatePlayerData(TeammateStats player)
	{
	}

	[Token(Token = "0x60116B9")]
	[Address(RVA = "0x16EC224", Offset = "0x16EC224", VA = "0x16EC224")]
	private void OnBtnHeadClick()
	{
	}

	[Token(Token = "0x60116BA")]
	[Address(RVA = "0x16EC4CC", Offset = "0x16EC4CC", VA = "0x16EC4CC")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60116BB")]
	[Address(RVA = "0x16EC4D4", Offset = "0x16EC4D4", VA = "0x16EC4D4")]
	public void _003C_003EiFixBaseProxy_OnClickAddFriendBtn()
	{
	}

	[Token(Token = "0x60116BC")]
	[Address(RVA = "0x16EC4DC", Offset = "0x16EC4DC", VA = "0x16EC4DC")]
	public void _003C_003EiFixBaseProxy_OnSetPlayerData(TeammateStats P0, bool P1)
	{
	}

	[Token(Token = "0x60116BD")]
	[Address(RVA = "0x16EC4E4", Offset = "0x16EC4E4", VA = "0x16EC4E4")]
	public void _003C_003EiFixBaseProxy_OnChangePageType(EMatchResultPageType P0)
	{
	}
}
