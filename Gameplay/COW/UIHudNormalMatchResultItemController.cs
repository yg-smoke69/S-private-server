using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002250")]
public class UIHudNormalMatchResultItemController : UIHudMatchResultItemBaseController
{
	[Token(Token = "0x400D6D6")]
	[FieldOffset(Offset = "0xDC")]
	private UIHudNormalMatchResultItemView m_View;

	[Token(Token = "0x400D6D7")]
	[FieldOffset(Offset = "0xE0")]
	private Color BarlColor;

	[Token(Token = "0x400D6D8")]
	[FieldOffset(Offset = "0xF0")]
	private Color Bar2Color;

	[Token(Token = "0x400D6D9")]
	[FieldOffset(Offset = "0x100")]
	private Color Bar3Color;

	[Token(Token = "0x400D6DA")]
	[FieldOffset(Offset = "0x110")]
	private Color Bar4Color;

	[Token(Token = "0x400D6DB")]
	[FieldOffset(Offset = "0x120")]
	private Color Bar5Color;

	[Token(Token = "0x600BAEF")]
	[Address(RVA = "0x1F566F0", Offset = "0x1F566F0", VA = "0x1F566F0")]
	public UIHudNormalMatchResultItemController()
	{
	}

	[Token(Token = "0x600BAF0")]
	[Address(RVA = "0x1F56840", Offset = "0x1F56840", VA = "0x1F56840")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BAF1")]
	[Address(RVA = "0x1F568E8", Offset = "0x1F568E8", VA = "0x1F568E8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BAF2")]
	[Address(RVA = "0x1F56E64", Offset = "0x1F56E64", VA = "0x1F56E64", Slot = "40")]
	protected override void OnSetPlayerData(TeammateStats data, bool single)
	{
	}

	[Token(Token = "0x600BAF3")]
	[Address(RVA = "0x1F57538", Offset = "0x1F57538", VA = "0x1F57538", Slot = "41")]
	public override void OnChangePageType(EMatchResultPageType pageType)
	{
	}

	[Token(Token = "0x600BAF4")]
	[Address(RVA = "0x1F5700C", Offset = "0x1F5700C", VA = "0x1F5700C")]
	private void UpdatePlayerData(TeammateStats player)
	{
	}

	[Token(Token = "0x600BAF5")]
	[Address(RVA = "0x1F57800", Offset = "0x1F57800", VA = "0x1F57800")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600BAF6")]
	[Address(RVA = "0x1F57808", Offset = "0x1F57808", VA = "0x1F57808")]
	public void _003C_003EiFixBaseProxy_OnSetPlayerData(TeammateStats P0, bool P1)
	{
	}

	[Token(Token = "0x600BAF7")]
	[Address(RVA = "0x1F57810", Offset = "0x1F57810", VA = "0x1F57810")]
	public void _003C_003EiFixBaseProxy_OnChangePageType(EMatchResultPageType P0)
	{
	}
}
