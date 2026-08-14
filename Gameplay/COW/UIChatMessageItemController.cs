using GCommon;
using Il2CppDummyDll;
using tcp;

namespace COW;

[Token(Token = "0x200250D")]
public class UIChatMessageItemController : UIBaseChatItemController
{
	[Token(Token = "0x400E5F9")]
	[FieldOffset(Offset = "0x88")]
	private UIChatMessageItemView m_View;

	[Token(Token = "0x400E5FA")]
	public const int POPMENU_POS_X = 800;

	[Token(Token = "0x400E5FB")]
	public const int POPMENU_POS_Y = 190;

	[Token(Token = "0x600D6FA")]
	[Address(RVA = "0x26346B8", Offset = "0x26346B8", VA = "0x26346B8")]
	public UIChatMessageItemController()
	{
	}

	[Token(Token = "0x600D6FB")]
	[Address(RVA = "0x26346C0", Offset = "0x26346C0", VA = "0x26346C0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D6FC")]
	[Address(RVA = "0x2634764", Offset = "0x2634764", VA = "0x2634764", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D6FD")]
	[Address(RVA = "0x26349FC", Offset = "0x26349FC", VA = "0x26349FC", Slot = "31")]
	protected override EChannel.ChannelType GetParentChannelType()
	{
		return default(EChannel.ChannelType);
	}

	[Token(Token = "0x600D6FE")]
	[Address(RVA = "0x2634BF4", Offset = "0x2634BF4", VA = "0x2634BF4", Slot = "32")]
	public override void OpenIteractionPanel(InteractionPopUtil.UIInteractionPoptype PopType)
	{
	}

	[Token(Token = "0x600D6FF")]
	[Address(RVA = "0x2634DB8", Offset = "0x2634DB8", VA = "0x2634DB8")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D700")]
	[Address(RVA = "0x2634DC0", Offset = "0x2634DC0", VA = "0x2634DC0")]
	public EChannel.ChannelType _003C_003EiFixBaseProxy_GetParentChannelType()
	{
		return default(EChannel.ChannelType);
	}

	[Token(Token = "0x600D701")]
	[Address(RVA = "0x2634DC8", Offset = "0x2634DC8", VA = "0x2634DC8")]
	public void _003C_003EiFixBaseProxy_OpenIteractionPanel(InteractionPopUtil.UIInteractionPoptype P0)
	{
	}
}
