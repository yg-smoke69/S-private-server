using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002254")]
public class UIHudTeamBattleMatchResultItemController : UIHudMatchResultItemBaseController
{
	[Token(Token = "0x400D6E8")]
	[FieldOffset(Offset = "0xDC")]
	protected UIHudTeamBattleMatchResultItemView m_View;

	[Token(Token = "0x400D6E9")]
	[FieldOffset(Offset = "0xE0")]
	private Color Bar2Color;

	[Token(Token = "0x400D6EA")]
	[FieldOffset(Offset = "0xF0")]
	private Color Bar3Color;

	[Token(Token = "0x400D6EB")]
	[FieldOffset(Offset = "0x100")]
	private Color BarlColor;

	[Token(Token = "0x600BB49")]
	[Address(RVA = "0x1798E40", Offset = "0x1798E40", VA = "0x1798E40")]
	public UIHudTeamBattleMatchResultItemController()
	{
	}

	[Token(Token = "0x600BB4A")]
	[Address(RVA = "0x1798F20", Offset = "0x1798F20", VA = "0x1798F20")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BB4B")]
	[Address(RVA = "0x1798FC8", Offset = "0x1798FC8", VA = "0x1798FC8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BB4C")]
	[Address(RVA = "0x1799548", Offset = "0x1799548", VA = "0x1799548", Slot = "40")]
	protected override void OnSetPlayerData(TeammateStats data, bool single)
	{
	}

	[Token(Token = "0x600BB4D")]
	[Address(RVA = "0x1799B3C", Offset = "0x1799B3C", VA = "0x1799B3C", Slot = "41")]
	public override void OnChangePageType(EMatchResultPageType pageType)
	{
	}

	[Token(Token = "0x600BB4E")]
	[Address(RVA = "0x179967C", Offset = "0x179967C", VA = "0x179967C")]
	private void UpdatePlayerData(TeammateStats player)
	{
	}

	[Token(Token = "0x600BB4F")]
	[Address(RVA = "0x1799D78", Offset = "0x1799D78", VA = "0x1799D78")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600BB50")]
	[Address(RVA = "0x1799D80", Offset = "0x1799D80", VA = "0x1799D80")]
	public void _003C_003EiFixBaseProxy_OnSetPlayerData(TeammateStats P0, bool P1)
	{
	}

	[Token(Token = "0x600BB51")]
	[Address(RVA = "0x1799D88", Offset = "0x1799D88", VA = "0x1799D88")]
	public void _003C_003EiFixBaseProxy_OnChangePageType(EMatchResultPageType P0)
	{
	}
}
