using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200281C")]
internal class UIHudQuitController : UIBaseController
{
	[Token(Token = "0x400F79F")]
	[FieldOffset(Offset = "0x28")]
	private UIHudQuitView m_View;

	[Token(Token = "0x600F9E9")]
	[Address(RVA = "0x1FD7568", Offset = "0x1FD7568", VA = "0x1FD7568")]
	public UIHudQuitController()
	{
	}

	[Token(Token = "0x600F9EA")]
	[Address(RVA = "0x1FD75EC", Offset = "0x1FD75EC", VA = "0x1FD75EC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F9EB")]
	[Address(RVA = "0x1FD7690", Offset = "0x1FD7690", VA = "0x1FD7690", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F9EC")]
	[Address(RVA = "0x1FD77EC", Offset = "0x1FD77EC", VA = "0x1FD77EC", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600F9ED")]
	[Address(RVA = "0x1FD7850", Offset = "0x1FD7850", VA = "0x1FD7850")]
	private void OnBtnDrop()
	{
	}

	[Token(Token = "0x600F9EE")]
	[Address(RVA = "0x1FD7C94", Offset = "0x1FD7C94", VA = "0x1FD7C94")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F9EF")]
	[Address(RVA = "0x1FD7C9C", Offset = "0x1FD7C9C", VA = "0x1FD7C9C")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
