using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002C26")]
internal class UIWorkshopCreateRoomSlotItemController : UIEasyListItemController
{
	[Token(Token = "0x4010DA0")]
	[FieldOffset(Offset = "0x38")]
	private UIWorkshopCreateRoomSlotItemView m_View;

	[Token(Token = "0x4010DA1")]
	[FieldOffset(Offset = "0x3C")]
	private SceneEditSlotInfo m_CurSlotInfo;

	[Token(Token = "0x4010DA2")]
	[FieldOffset(Offset = "0x40")]
	private int m_SlotIndex;

	[Token(Token = "0x6012628")]
	[Address(RVA = "0x1A2A290", Offset = "0x1A2A290", VA = "0x1A2A290")]
	public UIWorkshopCreateRoomSlotItemController()
	{
	}

	[Token(Token = "0x6012629")]
	[Address(RVA = "0x1A2A298", Offset = "0x1A2A298", VA = "0x1A2A298")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601262A")]
	[Address(RVA = "0x1A2A340", Offset = "0x1A2A340", VA = "0x1A2A340", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601262B")]
	[Address(RVA = "0x1A2A49C", Offset = "0x1A2A49C", VA = "0x1A2A49C", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x601262C")]
	[Address(RVA = "0x1A2A6D0", Offset = "0x1A2A6D0", VA = "0x1A2A6D0", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x601262D")]
	[Address(RVA = "0x1A2A76C", Offset = "0x1A2A76C", VA = "0x1A2A76C", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x601262E")]
	[Address(RVA = "0x1A2AB40", Offset = "0x1A2AB40", VA = "0x1A2AB40")]
	private void RefreshCDNMapIcon(SceneEditSlotInfo info)
	{
	}

	[Token(Token = "0x601262F")]
	[Address(RVA = "0x1A2AE98", Offset = "0x1A2AE98", VA = "0x1A2AE98")]
	private void _003CRefreshCDNMapIcon_003Em__0()
	{
	}

	[Token(Token = "0x6012630")]
	[Address(RVA = "0x1A2AF78", Offset = "0x1A2AF78", VA = "0x1A2AF78")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6012631")]
	[Address(RVA = "0x1A2AF80", Offset = "0x1A2AF80", VA = "0x1A2AF80")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x6012632")]
	[Address(RVA = "0x1A2AF88", Offset = "0x1A2AF88", VA = "0x1A2AF88")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
