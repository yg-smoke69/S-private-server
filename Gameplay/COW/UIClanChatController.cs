using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002532")]
public class UIClanChatController : UIBaseChatController<UIClanChatItemController>
{
	[Token(Token = "0x400E692")]
	[FieldOffset(Offset = "0xF0")]
	private UIClanChatView m_View;

	[Token(Token = "0x600D862")]
	[Address(RVA = "0x2F2720C", Offset = "0x2F2720C", VA = "0x2F2720C")]
	public UIClanChatController()
	{
	}

	[Token(Token = "0x600D863")]
	[Address(RVA = "0x2F27270", Offset = "0x2F27270", VA = "0x2F27270")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D864")]
	[Address(RVA = "0x2F27314", Offset = "0x2F27314", VA = "0x2F27314", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D865")]
	[Address(RVA = "0x2F27814", Offset = "0x2F27814", VA = "0x2F27814", Slot = "35")]
	protected override ChatChannelInfo GetCurShowChannel()
	{
		return null;
	}

	[Token(Token = "0x600D866")]
	[Address(RVA = "0x2F27A68", Offset = "0x2F27A68", VA = "0x2F27A68")]
	public void OnChatMessageShow()
	{
	}

	[Token(Token = "0x600D867")]
	[Address(RVA = "0x2F27B28", Offset = "0x2F27B28", VA = "0x2F27B28")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D868")]
	[Address(RVA = "0x2F27B2C", Offset = "0x2F27B2C", VA = "0x2F27B2C")]
	public ChatChannelInfo _003C_003EiFixBaseProxy_GetCurShowChannel()
	{
		return null;
	}
}
