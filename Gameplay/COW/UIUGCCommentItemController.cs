using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002B99")]
internal class UIUGCCommentItemController : UIBaseController
{
	[Token(Token = "0x2002B9A")]
	private enum EItemType
	{
		[Token(Token = "0x4010AD3")]
		EToBeSelected,
		[Token(Token = "0x4010AD4")]
		ESelected
	}

	[Token(Token = "0x4010ACD")]
	[FieldOffset(Offset = "0x28")]
	private UIUGCCommentItemView m_View;

	[Token(Token = "0x4010ACE")]
	[FieldOffset(Offset = "0x2C")]
	private WorkshopCommentConfigData m_Data;

	[Token(Token = "0x4010ACF")]
	[FieldOffset(Offset = "0x30")]
	private EItemType m_ItemType;

	[Token(Token = "0x4010AD0")]
	[FieldOffset(Offset = "0x34")]
	private bool m_HasSelected;

	[Token(Token = "0x4010AD1")]
	[FieldOffset(Offset = "0x35")]
	private bool m_CanBeSelected;

	[Token(Token = "0x601203F")]
	[Address(RVA = "0x2B855A4", Offset = "0x2B855A4", VA = "0x2B855A4")]
	public UIUGCCommentItemController()
	{
	}

	[Token(Token = "0x6012040")]
	[Address(RVA = "0x2B85628", Offset = "0x2B85628", VA = "0x2B85628")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012041")]
	[Address(RVA = "0x2B856D0", Offset = "0x2B856D0", VA = "0x2B856D0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6012042")]
	[Address(RVA = "0x2B83B4C", Offset = "0x2B83B4C", VA = "0x2B83B4C")]
	public void SetToBeSelectedViewData(WorkshopCommentConfigData data, bool hasSelected, bool canSelected)
	{
	}

	[Token(Token = "0x6012043")]
	[Address(RVA = "0x2B84B3C", Offset = "0x2B84B3C", VA = "0x2B84B3C")]
	public void SetSelectedViewData(WorkshopCommentConfigData data)
	{
	}

	[Token(Token = "0x6012044")]
	[Address(RVA = "0x2B858A0", Offset = "0x2B858A0", VA = "0x2B858A0")]
	private void OnUIUGCCommentItemClick()
	{
	}

	[Token(Token = "0x6012045")]
	[Address(RVA = "0x2B85B50", Offset = "0x2B85B50", VA = "0x2B85B50")]
	private void OnDeleteBtnClick()
	{
	}

	[Token(Token = "0x6012046")]
	[Address(RVA = "0x2B85CCC", Offset = "0x2B85CCC", VA = "0x2B85CCC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
