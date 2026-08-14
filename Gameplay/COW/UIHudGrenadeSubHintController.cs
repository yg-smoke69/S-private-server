using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002772")]
internal class UIHudGrenadeSubHintController : UIBaseController
{
	[Token(Token = "0x400F38D")]
	[FieldOffset(Offset = "0x28")]
	private UIHudGrenadeSubHintView m_View;

	[Token(Token = "0x600F16C")]
	[Address(RVA = "0x133B614", Offset = "0x133B614", VA = "0x133B614")]
	public UIHudGrenadeSubHintController()
	{
	}

	[Token(Token = "0x600F16D")]
	[Address(RVA = "0x133B698", Offset = "0x133B698", VA = "0x133B698")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F16E")]
	[Address(RVA = "0x133B73C", Offset = "0x133B73C", VA = "0x133B73C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F16F")]
	[Address(RVA = "0x1336FE4", Offset = "0x1336FE4", VA = "0x1336FE4")]
	public void SetActive(bool val)
	{
	}

	[Token(Token = "0x600F170")]
	[Address(RVA = "0x1339168", Offset = "0x1339168", VA = "0x1339168")]
	public void SetHintType(UIHudGrenadeHintController.HintType hinttype)
	{
	}

	[Token(Token = "0x600F171")]
	[Address(RVA = "0x133B7F8", Offset = "0x133B7F8", VA = "0x133B7F8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
