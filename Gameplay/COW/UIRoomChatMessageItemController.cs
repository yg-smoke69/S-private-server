using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002AE0")]
public class UIRoomChatMessageItemController : UIBaseController
{
	[Token(Token = "0x4010755")]
	[FieldOffset(Offset = "0x28")]
	private UIRoomChatMessageItemView m_View;

	[Token(Token = "0x6011950")]
	[Address(RVA = "0x23BA2F4", Offset = "0x23BA2F4", VA = "0x23BA2F4")]
	public UIRoomChatMessageItemController()
	{
	}

	[Token(Token = "0x6011951")]
	[Address(RVA = "0x23BA378", Offset = "0x23BA378", VA = "0x23BA378")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011952")]
	[Address(RVA = "0x23BA420", Offset = "0x23BA420", VA = "0x23BA420", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011953")]
	[Address(RVA = "0x23BA4DC", Offset = "0x23BA4DC", VA = "0x23BA4DC")]
	public void SetData(MessageInfo messageInfo, ulong roomCreaterID)
	{
	}

	[Token(Token = "0x6011954")]
	[Address(RVA = "0x23BAD4C", Offset = "0x23BAD4C", VA = "0x23BAD4C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
