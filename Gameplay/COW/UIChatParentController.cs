using GCommon;
using Il2CppDummyDll;
using tcp;

namespace COW;

[Token(Token = "0x200250E")]
public class UIChatParentController : UIPopupWindowController
{
	[Token(Token = "0x400E5FC")]
	[FieldOffset(Offset = "0x48")]
	private UIChatParentView m_View;

	[Token(Token = "0x400E5FD")]
	[FieldOffset(Offset = "0x4C")]
	private UIChatController m_ChatController;

	[Token(Token = "0x600D702")]
	[Address(RVA = "0x20720BC", Offset = "0x20720BC", VA = "0x20720BC")]
	public UIChatParentController()
	{
	}

	[Token(Token = "0x600D703")]
	[Address(RVA = "0x20720C4", Offset = "0x20720C4", VA = "0x20720C4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D704")]
	[Address(RVA = "0x2072168", Offset = "0x2072168", VA = "0x2072168", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D705")]
	[Address(RVA = "0x2072358", Offset = "0x2072358", VA = "0x2072358", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600D706")]
	[Address(RVA = "0x207248C", Offset = "0x207248C", VA = "0x207248C", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600D707")]
	[Address(RVA = "0x207259C", Offset = "0x207259C", VA = "0x207259C")]
	public void GotoChannel(EChannel.ChannelType type, ulong roomid = 0uL)
	{
	}

	[Token(Token = "0x600D708")]
	[Address(RVA = "0x2072650", Offset = "0x2072650", VA = "0x2072650", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600D709")]
	[Address(RVA = "0x2072708", Offset = "0x2072708", VA = "0x2072708")]
	private void OnClose()
	{
	}

	[Token(Token = "0x600D70A")]
	[Address(RVA = "0x20727C0", Offset = "0x20727C0", VA = "0x20727C0")]
	private void CloseChatWindow(object[] objs)
	{
	}

	[Token(Token = "0x600D70B")]
	[Address(RVA = "0x2072A1C", Offset = "0x2072A1C", VA = "0x2072A1C", Slot = "38")]
	protected override bool UseCustomizedAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x600D70C")]
	[Address(RVA = "0x2072A74", Offset = "0x2072A74", VA = "0x2072A74")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D70D")]
	[Address(RVA = "0x2072A7C", Offset = "0x2072A7C", VA = "0x2072A7C")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600D70E")]
	[Address(RVA = "0x2072A84", Offset = "0x2072A84", VA = "0x2072A84")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600D70F")]
	[Address(RVA = "0x2072A8C", Offset = "0x2072A8C", VA = "0x2072A8C")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600D710")]
	[Address(RVA = "0x2072A94", Offset = "0x2072A94", VA = "0x2072A94")]
	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return default(bool);
	}
}
