using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20027DB")]
public class UIHudObEventEntryStandardController : UIHudObEventEntryController
{
	[Token(Token = "0x400F614")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudObEventEntryView m_View;

	[Token(Token = "0x600F6FB")]
	[Address(RVA = "0x1F5BF3C", Offset = "0x1F5BF3C", VA = "0x1F5BF3C")]
	public UIHudObEventEntryStandardController()
	{
	}

	[Token(Token = "0x600F6FC")]
	[Address(RVA = "0x1F5BF40", Offset = "0x1F5BF40", VA = "0x1F5BF40")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F6FD")]
	[Address(RVA = "0x1F5BFE8", Offset = "0x1F5BFE8", VA = "0x1F5BFE8", Slot = "32")]
	protected override void OnLocalEventBtnClick()
	{
	}

	[Token(Token = "0x600F6FE")]
	[Address(RVA = "0x1F5C0F4", Offset = "0x1F5C0F4", VA = "0x1F5C0F4", Slot = "31")]
	protected override void OnGlobalEventBtnClick()
	{
	}

	[Token(Token = "0x600F6FF")]
	[Address(RVA = "0x1F5C360", Offset = "0x1F5C360", VA = "0x1F5C360")]
	public void _003C_003EiFixBaseProxy_OnLocalEventBtnClick()
	{
	}

	[Token(Token = "0x600F700")]
	[Address(RVA = "0x1F5C364", Offset = "0x1F5C364", VA = "0x1F5C364")]
	public void _003C_003EiFixBaseProxy_OnGlobalEventBtnClick()
	{
	}
}
