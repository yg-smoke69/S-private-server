using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200285F")]
internal class UIHudSwapWeaponController : UIHudButtonBaseController
{
	[Token(Token = "0x400F919")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudSwapWeaponView m_View;

	[Token(Token = "0x600FCB6")]
	[Address(RVA = "0x1FEFBB8", Offset = "0x1FEFBB8", VA = "0x1FEFBB8")]
	public UIHudSwapWeaponController()
	{
	}

	[Token(Token = "0x600FCB7")]
	[Address(RVA = "0x1FEFBC0", Offset = "0x1FEFBC0", VA = "0x1FEFBC0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FCB8")]
	[Address(RVA = "0x1FEFC64", Offset = "0x1FEFC64", VA = "0x1FEFC64", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FCB9")]
	[Address(RVA = "0x1FEFD44", Offset = "0x1FEFD44", VA = "0x1FEFD44", Slot = "36")]
	protected override string GetMappingName()
	{
		return null;
	}

	[Token(Token = "0x600FCBA")]
	[Address(RVA = "0x1FEFDE8", Offset = "0x1FEFDE8", VA = "0x1FEFDE8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
