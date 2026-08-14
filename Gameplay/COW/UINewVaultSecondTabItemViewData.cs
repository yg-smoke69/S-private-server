using System;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20029F3")]
public class UINewVaultSecondTabItemViewData
{
	[Token(Token = "0x40101FF")]
	[FieldOffset(Offset = "0x8")]
	public int DataIndex;

	[Token(Token = "0x4010200")]
	[FieldOffset(Offset = "0xC")]
	public UIModelNewVault.eSecondTab Tab;

	[Token(Token = "0x4010201")]
	[FieldOffset(Offset = "0x10")]
	public bool IsTip;

	[Token(Token = "0x4010202")]
	[FieldOffset(Offset = "0x14")]
	public int Count;

	[Token(Token = "0x4010203")]
	[FieldOffset(Offset = "0x18")]
	public uint IconItemID;

	[Token(Token = "0x4010204")]
	[FieldOffset(Offset = "0x1C")]
	public bool IsGray;

	[Token(Token = "0x4010205")]
	[FieldOffset(Offset = "0x20")]
	public Action<int> OnClick;

	[Token(Token = "0x4010206")]
	[FieldOffset(Offset = "0x24")]
	public Action<UIModelNewVault.eSecondTab, UINewVaultSecondTabItemController> OnRefreshIcon;

	[Token(Token = "0x4010207")]
	[FieldOffset(Offset = "0x28")]
	public Action<UIModelNewVault.eSecondTab> OnCloseTips;

	[Token(Token = "0x6010E89")]
	[Address(RVA = "0x26CF7A0", Offset = "0x26CF7A0", VA = "0x26CF7A0")]
	public UINewVaultSecondTabItemViewData()
	{
	}

	[Token(Token = "0x6010E8A")]
	[Address(RVA = "0x26CCF54", Offset = "0x26CCF54", VA = "0x26CCF54")]
	public void RefreshIconItemID()
	{
	}
}
