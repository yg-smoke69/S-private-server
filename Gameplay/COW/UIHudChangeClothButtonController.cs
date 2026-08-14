using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20023CC")]
public class UIHudChangeClothButtonController : UIBaseController
{
	[Token(Token = "0x400DEA4")]
	[FieldOffset(Offset = "0x28")]
	private UIHudChangeClothButtonView m_View;

	[Token(Token = "0x400DEA5")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudChangeClothListController ctrl;

	[Token(Token = "0x400DEA6")]
	[FieldOffset(Offset = "0x30")]
	private List<InventoryClothInfo> allClothsId;

	[Token(Token = "0x600C9E3")]
	[Address(RVA = "0x2148BBC", Offset = "0x2148BBC", VA = "0x2148BBC")]
	public UIHudChangeClothButtonController()
	{
	}

	[Token(Token = "0x600C9E4")]
	[Address(RVA = "0x2148C74", Offset = "0x2148C74", VA = "0x2148C74")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C9E5")]
	[Address(RVA = "0x2148D18", Offset = "0x2148D18", VA = "0x2148D18", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C9E6")]
	[Address(RVA = "0x21490BC", Offset = "0x21490BC", VA = "0x21490BC")]
	private void OnChangeClothClick()
	{
	}

	[Token(Token = "0x600C9E7")]
	[Address(RVA = "0x2149694", Offset = "0x2149694", VA = "0x2149694")]
	private void AutoChangeCloth()
	{
	}

	[Token(Token = "0x600C9E8")]
	[Address(RVA = "0x2149BE4", Offset = "0x2149BE4", VA = "0x2149BE4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
