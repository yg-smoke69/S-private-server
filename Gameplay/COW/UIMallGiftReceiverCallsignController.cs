using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20021EB")]
public class UIMallGiftReceiverCallsignController : UIEasyListItemController
{
	[Token(Token = "0x400D43E")]
	[FieldOffset(Offset = "0x38")]
	private UIMallGiftReceiverCallsignView m_View;

	[Token(Token = "0x600B66F")]
	[Address(RVA = "0x225C420", Offset = "0x225C420", VA = "0x225C420")]
	public UIMallGiftReceiverCallsignController()
	{
	}

	[Token(Token = "0x600B670")]
	[Address(RVA = "0x225C428", Offset = "0x225C428", VA = "0x225C428")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B671")]
	[Address(RVA = "0x225C4CC", Offset = "0x225C4CC", VA = "0x225C4CC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B672")]
	[Address(RVA = "0x225C588", Offset = "0x225C588", VA = "0x225C588", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600B673")]
	[Address(RVA = "0x22577D0", Offset = "0x22577D0", VA = "0x22577D0")]
	public void RefreshData(FriendInfo data)
	{
	}

	[Token(Token = "0x600B674")]
	[Address(RVA = "0x225C6D4", Offset = "0x225C6D4", VA = "0x225C6D4")]
	public void UpdateBanner(uint bannerId)
	{
	}

	[Token(Token = "0x600B675")]
	[Address(RVA = "0x225C87C", Offset = "0x225C87C", VA = "0x225C87C")]
	public void UpdateBanner(ResourceID resId)
	{
	}

	[Token(Token = "0x600B676")]
	[Address(RVA = "0x225CAD0", Offset = "0x225CAD0", VA = "0x225CAD0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
