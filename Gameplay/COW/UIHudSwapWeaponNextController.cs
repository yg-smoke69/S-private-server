using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002860")]
internal class UIHudSwapWeaponNextController : UIHudButtonBaseController
{
	[Token(Token = "0x400F91A")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudSwapWeaponNextView m_View;

	[Token(Token = "0x600FCBB")]
	[Address(RVA = "0x1FEFDF0", Offset = "0x1FEFDF0", VA = "0x1FEFDF0")]
	public UIHudSwapWeaponNextController()
	{
	}

	[Token(Token = "0x600FCBC")]
	[Address(RVA = "0x1FEFDF8", Offset = "0x1FEFDF8", VA = "0x1FEFDF8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FCBD")]
	[Address(RVA = "0x1FEFE9C", Offset = "0x1FEFE9C", VA = "0x1FEFE9C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FCBE")]
	[Address(RVA = "0x1FEFF7C", Offset = "0x1FEFF7C", VA = "0x1FEFF7C", Slot = "36")]
	protected override string GetMappingName()
	{
		return null;
	}

	[Token(Token = "0x600FCBF")]
	[Address(RVA = "0x1FF0020", Offset = "0x1FF0020", VA = "0x1FF0020")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
