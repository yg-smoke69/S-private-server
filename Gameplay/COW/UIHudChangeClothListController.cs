using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20023CD")]
public class UIHudChangeClothListController : UIPopupWindowController
{
	[Token(Token = "0x400DEA7")]
	[FieldOffset(Offset = "0x48")]
	private UIHudChangeClothListView m_View;

	[Token(Token = "0x400DEA8")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelInventory m_InventoryModel;

	[Token(Token = "0x400DEA9")]
	[FieldOffset(Offset = "0x50")]
	private UIModelAvatar m_ModelAvatar;

	[Token(Token = "0x400DEAA")]
	[FieldOffset(Offset = "0x54")]
	private AvatarManager m_amManager;

	[Token(Token = "0x400DEAB")]
	[FieldOffset(Offset = "0x0")]
	private static Func<string, uint> _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x400DEAC")]
	[FieldOffset(Offset = "0x4")]
	private static Func<string, uint> _003C_003Ef__mg_0024cache1;

	[Token(Token = "0x600C9E9")]
	[Address(RVA = "0x2149DA4", Offset = "0x2149DA4", VA = "0x2149DA4")]
	public UIHudChangeClothListController()
	{
	}

	[Token(Token = "0x600C9EA")]
	[Address(RVA = "0x2149DAC", Offset = "0x2149DAC", VA = "0x2149DAC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C9EB")]
	[Address(RVA = "0x2149E50", Offset = "0x2149E50", VA = "0x2149E50", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C9EC")]
	[Address(RVA = "0x214927C", Offset = "0x214927C", VA = "0x214927C")]
	public void InitClothesData()
	{
	}

	[Token(Token = "0x600C9ED")]
	[Address(RVA = "0x214A1F0", Offset = "0x214A1F0", VA = "0x214A1F0")]
	private void OnCloseClick()
	{
	}

	[Token(Token = "0x600C9EE")]
	[Address(RVA = "0x214A278", Offset = "0x214A278", VA = "0x214A278")]
	private void On1PShowClick()
	{
	}

	[Token(Token = "0x600C9EF")]
	[Address(RVA = "0x214A70C", Offset = "0x214A70C", VA = "0x214A70C")]
	private void On3PShowClick()
	{
	}

	[Token(Token = "0x600C9F0")]
	[Address(RVA = "0x214AA3C", Offset = "0x214AA3C", VA = "0x214AA3C")]
	private void OnSearchInputChange()
	{
	}

	[Token(Token = "0x600C9F1")]
	[Address(RVA = "0x214ABC8", Offset = "0x214ABC8", VA = "0x214ABC8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
