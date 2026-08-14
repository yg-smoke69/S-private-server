using GCommon;
using Il2CppDummyDll;
using tcp;

namespace COW;

[Token(Token = "0x2002533")]
public class UIClanChatItemController : UIBaseChatItemController
{
	[Token(Token = "0x400E693")]
	[FieldOffset(Offset = "0x88")]
	private UIClanChatItemView m_View;

	[Token(Token = "0x600D869")]
	[Address(RVA = "0x2F27B30", Offset = "0x2F27B30", VA = "0x2F27B30")]
	public UIClanChatItemController()
	{
	}

	[Token(Token = "0x600D86A")]
	[Address(RVA = "0x2F27B38", Offset = "0x2F27B38", VA = "0x2F27B38")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D86B")]
	[Address(RVA = "0x2F27BE0", Offset = "0x2F27BE0", VA = "0x2F27BE0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D86C")]
	[Address(RVA = "0x2F27E78", Offset = "0x2F27E78", VA = "0x2F27E78", Slot = "31")]
	protected override EChannel.ChannelType GetParentChannelType()
	{
		return default(EChannel.ChannelType);
	}

	[Token(Token = "0x600D86D")]
	[Address(RVA = "0x2F28070", Offset = "0x2F28070", VA = "0x2F28070")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D86E")]
	[Address(RVA = "0x2F28078", Offset = "0x2F28078", VA = "0x2F28078")]
	public EChannel.ChannelType _003C_003EiFixBaseProxy_GetParentChannelType()
	{
		return default(EChannel.ChannelType);
	}
}
