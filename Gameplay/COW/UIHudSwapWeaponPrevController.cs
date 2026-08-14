using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002861")]
internal class UIHudSwapWeaponPrevController : UIHudButtonBaseController
{
	[Token(Token = "0x400F91B")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudSwapWeaponPrevView m_View;

	[Token(Token = "0x600FCC0")]
	[Address(RVA = "0x1FF01E0", Offset = "0x1FF01E0", VA = "0x1FF01E0")]
	public UIHudSwapWeaponPrevController()
	{
	}

	[Token(Token = "0x600FCC1")]
	[Address(RVA = "0x1FF01E8", Offset = "0x1FF01E8", VA = "0x1FF01E8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FCC2")]
	[Address(RVA = "0x1FF028C", Offset = "0x1FF028C", VA = "0x1FF028C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FCC3")]
	[Address(RVA = "0x1FF036C", Offset = "0x1FF036C", VA = "0x1FF036C", Slot = "36")]
	protected override string GetMappingName()
	{
		return null;
	}

	[Token(Token = "0x600FCC4")]
	[Address(RVA = "0x1FF0410", Offset = "0x1FF0410", VA = "0x1FF0410")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
