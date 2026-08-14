using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20028BC")]
public class UIHudWereWolvesQuickChatItemController : UIEasyListItemController
{
	[Token(Token = "0x400FAC7")]
	[FieldOffset(Offset = "0x38")]
	private UIHudWereWolvesQuickChatItemView m_View;

	[Token(Token = "0x400FAC8")]
	[FieldOffset(Offset = "0x3C")]
	private WereWolvesQuickChatData m_data;

	[Token(Token = "0x6010088")]
	[Address(RVA = "0x256B7DC", Offset = "0x256B7DC", VA = "0x256B7DC")]
	public UIHudWereWolvesQuickChatItemController()
	{
	}

	[Token(Token = "0x6010089")]
	[Address(RVA = "0x256B7E4", Offset = "0x256B7E4", VA = "0x256B7E4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601008A")]
	[Address(RVA = "0x256B88C", Offset = "0x256B88C", VA = "0x256B88C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601008B")]
	[Address(RVA = "0x256B9E8", Offset = "0x256B9E8", VA = "0x256B9E8")]
	private void OnClick()
	{
	}

	[Token(Token = "0x601008C")]
	[Address(RVA = "0x256BB98", Offset = "0x256BB98", VA = "0x256BB98", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x601008D")]
	[Address(RVA = "0x256BDF8", Offset = "0x256BDF8", VA = "0x256BDF8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
