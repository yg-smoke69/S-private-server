using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2001F84")]
public class UIBigEventLobbyEnterItemControler : UIEasyListItemController
{
	[Token(Token = "0x400C5D0")]
	[FieldOffset(Offset = "0x38")]
	private UIBigEventLobbyEnterItemView m_View;

	[Token(Token = "0x400C5D1")]
	[FieldOffset(Offset = "0x40")]
	private ulong m_StartTimeStamp;

	[Token(Token = "0x400C5D2")]
	[FieldOffset(Offset = "0x48")]
	private ulong m_EndTimeStamp;

	[Token(Token = "0x400C5D3")]
	[FieldOffset(Offset = "0x50")]
	private BigEventEntryDesc m_ViewData;

	[Token(Token = "0x6009C94")]
	[Address(RVA = "0x300BBF0", Offset = "0x300BBF0", VA = "0x300BBF0")]
	public UIBigEventLobbyEnterItemControler()
	{
	}

	[Token(Token = "0x6009C95")]
	[Address(RVA = "0x300BBF8", Offset = "0x300BBF8", VA = "0x300BBF8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009C96")]
	[Address(RVA = "0x300BCA0", Offset = "0x300BCA0", VA = "0x300BCA0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009C97")]
	[Address(RVA = "0x300BE70", Offset = "0x300BE70", VA = "0x300BE70", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x6009C98")]
	[Address(RVA = "0x300BED4", Offset = "0x300BED4", VA = "0x300BED4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6009C99")]
	[Address(RVA = "0x300C074", Offset = "0x300C074", VA = "0x300C074", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6009C9A")]
	[Address(RVA = "0x300C0D8", Offset = "0x300C0D8", VA = "0x300C0D8", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x6009C9B")]
	[Address(RVA = "0x300D0BC", Offset = "0x300D0BC", VA = "0x300D0BC")]
	private void OnGotoBtnClick()
	{
	}

	[Token(Token = "0x6009C9C")]
	[Address(RVA = "0x300D73C", Offset = "0x300D73C", VA = "0x300D73C")]
	private void OnNotifyCheckboxChange()
	{
	}

	[Token(Token = "0x6009C9D")]
	[Address(RVA = "0x300D8A0", Offset = "0x300D8A0", VA = "0x300D8A0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009C9E")]
	[Address(RVA = "0x300D8A8", Offset = "0x300D8A8", VA = "0x300D8A8")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x6009C9F")]
	[Address(RVA = "0x300D8B0", Offset = "0x300D8B0", VA = "0x300D8B0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6009CA0")]
	[Address(RVA = "0x300D8B8", Offset = "0x300D8B8", VA = "0x300D8B8")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
